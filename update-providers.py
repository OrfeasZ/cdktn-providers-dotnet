#!/usr/bin/env python3
"""
Queries the Terraform registry for the latest version of each provider
in cdktf.json and updates the version constraints accordingly.

Writes the full latest provider version back into cdktf.json as an exact
version constraint.
"""

import json
import os
import re
import sys
import urllib.request
import urllib.error

REGISTRY_VERSIONS_URL = "https://registry.terraform.io/v1/providers/{namespace}/{name}/versions"
STABLE_VERSION_RE = re.compile(r"^\d+\.\d+\.\d+$")

script_dir = os.path.dirname(os.path.abspath(__file__))
cdktf_file = os.path.join(script_dir, "cdktf.json")

if not os.path.isfile(cdktf_file):
    print(f"cdktf.json not found at {cdktf_file}", file=sys.stderr)
    sys.exit(1)

with open(cdktf_file, "r", encoding="utf-8") as f:
    cdktf = json.load(f)

providers = cdktf.get("terraformProviders", [])
if not providers:
    print("No providers found in cdktf.json")
    sys.exit(0)

# Pattern: namespace/name@X.Y[.Z] or namespace/name@~> X.Y[.Z]
PROVIDER_RE = re.compile(r"^(?P<ns>[^/]+)/(?P<name>[^@]+)@(?P<constraint>.+)$")
CONSTRAINT_RE = re.compile(r"^(?:~>\s*)?(?P<version>\d+\.\d+(?:\.\d+)?)$")


def parse_stable_version(version: str) -> tuple[int, int, int] | None:
    if not STABLE_VERSION_RE.fullmatch(version):
        return None

    major, minor, patch = version.split(".")
    return int(major), int(minor), int(patch)


def latest_stable_version(namespace: str, name: str) -> str:
    url = REGISTRY_VERSIONS_URL.format(namespace=namespace, name=name)
    with urllib.request.urlopen(url) as resp:
        data = json.loads(resp.read())

    versions = data.get("versions", [])
    stable_versions = []
    for entry in versions:
        version = entry.get("version") if isinstance(entry, dict) else entry
        if not isinstance(version, str):
            continue

        parsed = parse_stable_version(version)
        if parsed is not None:
            stable_versions.append((parsed, version))

    if not stable_versions:
        raise KeyError(f"No stable versions found for {namespace}/{name}")

    stable_versions.sort(key=lambda item: item[0])
    return stable_versions[-1][1]

updated_count = 0
updated_providers = []

for i, entry in enumerate(providers):
    m = PROVIDER_RE.match(entry)
    if not m:
        print(f"WARNING: Skipping unrecognised provider format: {entry}")
        updated_providers.append(entry)
        continue

    ns = m.group("ns")
    name = m.group("name")
    constraint = m.group("constraint")

    cm = CONSTRAINT_RE.match(constraint)
    if not cm:
        print(f"WARNING: Skipping unrecognised constraint format: {constraint}")
        updated_providers.append(entry)
        continue

    try:
        latest = latest_stable_version(ns, name)
    except (urllib.error.HTTPError, KeyError) as e:
        print(f"WARNING: Could not fetch latest stable version for {ns}/{name}: {e}")
        updated_providers.append(entry)
        continue

    new_constraint = latest
    new_entry = f"{ns}/{name}@{new_constraint}"

    if new_entry != entry:
        print(f"Updated {ns}/{name}: {constraint} -> {new_constraint} (latest: {latest})")
        updated_count += 1
    else:
        print(f"{ns}/{name}: already at latest ({constraint})")

    updated_providers.append(new_entry)

cdktf["terraformProviders"] = updated_providers

with open(cdktf_file, "w", encoding="utf-8") as f:
    json.dump(cdktf, f, indent=2, ensure_ascii=False)
    f.write("\n")

print(f"\nDone. {updated_count} provider(s) updated.")
