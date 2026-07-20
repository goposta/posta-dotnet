#!/usr/bin/env bash
set -euo pipefail

ROOT="$(cd -- "$(dirname -- "${BASH_SOURCE[0]}")" && pwd)"
OUTPUT="$ROOT/artifacts"

echo "Restoring Posta projects..."
dotnet restore "$ROOT/Posta.Aspire/Posta.Aspire.csproj"

echo "Packing Posta..."
dotnet pack "$ROOT/Posta.csproj" \
  --configuration Release \
  --no-restore \
  --output "$OUTPUT"

echo "Packing Posta.Aspire..."
dotnet pack "$ROOT/Posta.Aspire/Posta.Aspire.csproj" \
  --configuration Release \
  --no-restore \
  --output "$OUTPUT"

printf '\nNuGet packages created in "%s".\n' "$OUTPUT"
