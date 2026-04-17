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

REGISTRY_URL = "https://registry.terraform.io/v1/providers/{namespace}/{name}"

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

    # Query Terraform registry for latest version
    url = REGISTRY_URL.format(namespace=ns, name=name)
    try:
        with urllib.request.urlopen(url) as resp:
            data = json.loads(resp.read())
            latest = data["version"]  # e.g. "6.42.0"
    except (urllib.error.HTTPError, KeyError) as e:
        print(f"WARNING: Could not fetch latest version for {ns}/{name}: {e}")
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
