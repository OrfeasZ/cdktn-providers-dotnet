#!/usr/bin/env python3
"""Generate provider bindings and publish their jsii tarballs to a GitHub release.

This is the single entry point used both locally (on a fast machine) and from CI
(.github/workflows/update-providers.yml). The heavy ``.tgz`` jsii tarballs that
get embedded into each NuGet package are NOT stored in git -- they live as assets
on a rolling prerelease (default tag: ``provider-binaries``). The generated ``.cs``
bindings stay committed and drive build.yml's selective publishing; build.yml
downloads only the tarballs it needs from the release before packing.

Typical usage:

    # Local: refresh constraints, regenerate, upload, commit and push
    python sync-providers.py --update-constraints

    # Local: regenerate with the current cdktf.json (no constraint refresh)
    python sync-providers.py

    # Bootstrap: create the release and upload the tarballs already on disk
    python sync-providers.py --skip-generate --skip-commit

    # Dry-ish run: do everything except git push
    python sync-providers.py --no-push

Requirements: gh (authenticated), node/npx, terraform, dotnet -- only the pieces a
given run actually exercises. The cdktn CLI is fetched on demand via npx (pinned
below), so it does not need to be installed globally.
"""

from __future__ import annotations

import argparse
import os
import subprocess
import sys
from pathlib import Path

REPO_ROOT = Path(__file__).resolve().parent
GEN_DIR = REPO_ROOT / ".gen"
DEFAULT_RELEASE_TAG = "provider-binaries"
# cdktn CLI is run via npx, so it need not be installed globally. Bump here.
CDKTN_CLI_PACKAGE = "cdktn-cli@0.23.3"


def run(cmd: list[str]) -> None:
    print(f"$ {' '.join(cmd)}", flush=True)
    subprocess.run(cmd, check=True, cwd=REPO_ROOT)


def capture(cmd: list[str]) -> str:
    return subprocess.run(
        cmd, check=True, cwd=REPO_ROOT, capture_output=True, text=True
    ).stdout


def tgz_files() -> list[Path]:
    return sorted(GEN_DIR.glob("*/*.tgz"))


def release_exists(tag: str) -> bool:
    return (
        subprocess.run(
            ["gh", "release", "view", tag],
            cwd=REPO_ROOT,
            stdout=subprocess.DEVNULL,
            stderr=subprocess.DEVNULL,
        ).returncode
        == 0
    )


def ensure_release(tag: str) -> None:
    if release_exists(tag):
        return
    print(f"Creating release '{tag}'...")
    run(
        [
            "gh",
            "release",
            "create",
            tag,
            "--title",
            "Provider binaries",
            "--notes",
            "Internal store of generated jsii tarballs (.tgz) embedded into the "
            "published NuGet packages. Managed by sync-providers.py; not a "
            "user-facing release.",
            "--prerelease",
        ]
    )


def git_changed_providers() -> set[str]:
    """Provider directory names under .gen/ that have uncommitted changes."""
    providers: set[str] = set()
    for line in capture(["git", "status", "--porcelain", "--", ".gen"]).splitlines():
        path = line[3:].strip()
        if path.startswith('"') and path.endswith('"'):
            path = path[1:-1]
        if " -> " in path:  # rename: take the destination
            path = path.split(" -> ", 1)[1]
        parts = Path(path).parts
        if len(parts) >= 2 and parts[0] == ".gen":
            providers.add(parts[1])
    return providers


def select_uploads(everything: list[Path], *, upload_all: bool) -> list[Path]:
    if upload_all:
        return everything
    changed = git_changed_providers()
    return [p for p in everything if p.parent.name in changed]


def write_output(**values: object) -> None:
    """Append step outputs for GitHub Actions when running in CI."""
    output_path = os.environ.get("GITHUB_OUTPUT")
    if not output_path:
        return
    with open(output_path, "a", encoding="utf-8") as handle:
        for key, value in values.items():
            if isinstance(value, bool):
                value = "true" if value else "false"
            handle.write(f"{key}={value}\n")


def verify(providers: set[str]) -> None:
    for provider in sorted(providers):
        csproj = GEN_DIR / provider / f"{provider}.csproj"
        if csproj.exists():
            run(["dotnet", "build", str(csproj), "-c", "Release"])


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--release-tag", default=DEFAULT_RELEASE_TAG)
    parser.add_argument(
        "--update-constraints",
        action="store_true",
        help="Run update-providers.py to refresh cdktf.json before generating.",
    )
    parser.add_argument(
        "--force",
        action="store_true",
        help="Generate even when --update-constraints found no constraint changes.",
    )
    parser.add_argument("--skip-generate", action="store_true", help="Do not run cdktn get.")
    parser.add_argument(
        "--parallelism",
        type=int,
        default=1,
        help="Parallelism passed to cdktn get (default: 1).",
    )
    parser.add_argument("--skip-upload", action="store_true", help="Do not upload tarballs.")
    parser.add_argument("--skip-commit", action="store_true", help="Do not commit or push.")
    parser.add_argument("--no-push", action="store_true", help="Commit but do not push.")
    parser.add_argument(
        "--all",
        action="store_true",
        help="Upload every tarball, not just changed providers.",
    )
    parser.add_argument(
        "--verify",
        action="store_true",
        help="dotnet build the changed providers before committing.",
    )
    parser.add_argument("--message", default="Update generated providers")
    return parser.parse_args()


def main() -> int:
    args = parse_args()
    tag = args.release_tag

    if args.update_constraints:
        run([sys.executable, "update-providers.py"])
        constraints_changed = bool(
            capture(["git", "status", "--porcelain", "--", "cdktf.json"]).strip()
        )
        if not constraints_changed and not args.force:
            print("No constraint changes; nothing to regenerate (use --force to override).")
            write_output(pushed=False)
            return 0

    if not args.skip_generate:
        run([
            "npx", "--yes", "-p", CDKTN_CLI_PACKAGE,
            "cdktn", "get", "--parallelism", str(args.parallelism),
        ])

    if args.verify:
        verify(git_changed_providers())

    if not args.skip_upload:
        upload_all = args.all or not release_exists(tag)
        ensure_release(tag)
        uploads = select_uploads(tgz_files(), upload_all=upload_all)
        if uploads:
            run(["gh", "release", "upload", tag, *[str(p) for p in uploads], "--clobber"])
            print(f"Uploaded {len(uploads)} tarball(s) to release '{tag}'.")
        else:
            print("No tarballs needed uploading.")

    if args.skip_commit:
        write_output(pushed=False)
        return 0

    run(["git", "add", "cdktf.json", ".gen"])
    has_staged = (
        subprocess.run(
            ["git", "diff", "--cached", "--quiet"], cwd=REPO_ROOT
        ).returncode
        != 0
    )
    if not has_staged:
        print("No binding changes to commit.")
        write_output(pushed=False)
        return 0

    before_sha = capture(["git", "rev-parse", "HEAD"]).strip()
    run(["git", "commit", "-m", args.message])
    after_sha = capture(["git", "rev-parse", "HEAD"]).strip()

    if args.no_push:
        print("Committed locally; skipping push (--no-push).")
        write_output(pushed=False)
        return 0

    run(["git", "push"])
    print("Pushed updated bindings.")
    write_output(pushed=True, before_sha=before_sha, after_sha=after_sha)
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
