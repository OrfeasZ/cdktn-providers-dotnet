#!/usr/bin/env python3
"""Select which generated providers should be packed and published for a push."""

from __future__ import annotations

import argparse
import subprocess
import sys
from pathlib import Path


ZERO_SHA = "0" * 40
GLOBAL_TRIGGER_FILES = {
    "patch-projects.py",
    ".github/workflows/build.yml",
}


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser(
        description="Determine which providers should be built for the current push."
    )
    parser.add_argument("--before", required=True, help="The pre-push git SHA.")
    parser.add_argument("--after", required=True, help="The post-push git SHA.")
    parser.add_argument(
        "--output",
        required=True,
        help="Path to the GitHub Actions output file.",
    )
    return parser.parse_args()


def git_changed_files(before: str, after: str) -> list[str]:
    result = subprocess.run(
        ["git", "diff", "--name-only", before, after],
        check=True,
        capture_output=True,
        text=True,
    )
    return [line.strip().replace("\\", "/") for line in result.stdout.splitlines() if line.strip()]


def changed_providers(changed_files: list[str]) -> list[str]:
    providers: set[str] = set()
    for path in changed_files:
        parts = Path(path).parts
        if len(parts) >= 3 and parts[0] == ".gen":
            providers.add(parts[1])
    return sorted(providers)


def write_outputs(output_path: str, *, build_all: bool, should_publish: bool, providers: list[str]) -> None:
    with open(output_path, "a", encoding="utf-8") as handle:
        handle.write(f"build_all={'true' if build_all else 'false'}\n")
        handle.write(f"should_publish={'true' if should_publish else 'false'}\n")
        handle.write(f"providers={' '.join(providers)}\n")


def main() -> int:
    args = parse_args()

    if not args.before or args.before == ZERO_SHA:
        write_outputs(args.output, build_all=True, should_publish=True, providers=[])
        return 0

    try:
        changed_files = git_changed_files(args.before, args.after)
    except subprocess.CalledProcessError as exc:
        print(exc.stderr, file=sys.stderr)
        write_outputs(args.output, build_all=True, should_publish=True, providers=[])
        return 0

    if any(path in GLOBAL_TRIGGER_FILES for path in changed_files):
        write_outputs(args.output, build_all=True, should_publish=True, providers=[])
        return 0

    providers = changed_providers(changed_files)
    if not providers:
        write_outputs(args.output, build_all=False, should_publish=False, providers=[])
        return 0

    write_outputs(args.output, build_all=False, should_publish=True, providers=providers)
    return 0


if __name__ == "__main__":
    raise SystemExit(main())