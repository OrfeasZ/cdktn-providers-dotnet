#!/usr/bin/env python3
"""
Patches generated .csproj files in .gen/ to:
  1. Set PackageVersion from .gen/versions.json (+ unique suffix)
  2. Remove GeneratePackageOnBuild property
  3. Remove embedded .tgz resource (and its ItemGroup if empty)
  4. Update PackageId to OrfeasZ.Cdktn.<Author>.<Provider>
  5. Update license to MPL-2.0
"""

import json
import os
import sys
import urllib.request
import urllib.error
import xml.etree.ElementTree as ET


NUGET_INDEX_URL = "https://api.nuget.org/v3-flatcontainer/{package_id}/index.json"


def get_published_versions(package_id: str) -> set[str]:
    """Fetch the set of already-published versions for a package from nuget.org."""
    url = NUGET_INDEX_URL.format(package_id=package_id.lower())
    try:
        with urllib.request.urlopen(url) as resp:
            data = json.loads(resp.read())
            return set(data.get("versions", []))
    except urllib.error.HTTPError as e:
        if e.code == 404:
            return set()
        raise


def next_available_version(base_version: str, published: set[str]) -> str:
    """Return base_version.N where N is the smallest int >= 1 not yet published.

    Always produces a 4-part version. Starts at .1 since NuGet normalizes
    X.Y.Z.0 to X.Y.Z.
    """
    revision = 1
    while True:
        candidate = f"{base_version}.{revision}"
        if candidate not in published:
            return candidate
        revision += 1

script_dir = os.path.dirname(os.path.abspath(__file__))
gen_dir = os.path.join(script_dir, ".gen")
versions_file = os.path.join(gen_dir, "versions.json")

if not os.path.isfile(versions_file):
    print(f"versions.json not found at {versions_file}", file=sys.stderr)
    sys.exit(1)

with open(versions_file, "r", encoding="utf-8") as f:
    versions = json.load(f)

patched_count = 0

for key, version in versions.items():
    segments = key.split("/")
    if len(segments) < 3:
        print(f"WARNING: Skipping unexpected key format: {key}")
        continue

    author = segments[-2]
    provider = segments[-1]
    package_id = f"OrfeasZ.Cdktn.{author}.{provider}"

    csproj_path = os.path.join(gen_dir, provider, f"{provider}.csproj")

    if not os.path.isfile(csproj_path):
        print(f"WARNING: Project not found: {csproj_path}")
        continue

    tree = ET.parse(csproj_path)
    root = tree.getroot()
    changed = False

    # Resolve an available version (base_version.N) that isn't already on nuget.org
    published = get_published_versions(package_id)
    resolved_version = next_available_version(version, published)

    # 1. Patch PackageVersion
    for el in root.iter("PackageVersion"):
        if el.text != resolved_version:
            el.text = resolved_version
            changed = True

    # 2. Remove GeneratePackageOnBuild
    for prop_group in root.findall("PropertyGroup"):
        for el in prop_group.findall("GeneratePackageOnBuild"):
            prop_group.remove(el)
            changed = True

    # 3. Remove ItemGroup containing embedded .tgz EmbeddedResource
    # TODO: Make sure this doesn't break anything.
    for item_group in root.findall("ItemGroup"):
        tgz_resources = [
            el for el in item_group.findall("EmbeddedResource")
            if el.get("Include", "").endswith(".tgz")
        ]
        for el in tgz_resources:
            item_group.remove(el)
            changed = True
        # Remove the ItemGroup if it's now empty
        if len(item_group) == 0:
            root.remove(item_group)

    # 4. Update PackageId
    for el in root.iter("PackageId"):
        if el.text != package_id:
            el.text = package_id
            changed = True

    # 5. Update license to MPL-2.0
    for el in root.iter("PackageLicenseExpression"):
        if el.text != "MPL-2.0":
            el.text = "MPL-2.0"
            changed = True

    if changed:
        ET.indent(tree, space="  ")
        tree.write(csproj_path, encoding="unicode", xml_declaration=False)
        # Ensure trailing newline
        with open(csproj_path, "a", encoding="utf-8") as f:
            f.write("\n")
        print(f"Patched {provider} ({author}) -> version={resolved_version}, PackageId={package_id}")
        patched_count += 1
    else:
        print(f"{provider} ({author}) already up to date (version={resolved_version})")

print(f"\nDone. {patched_count} project(s) patched.")
