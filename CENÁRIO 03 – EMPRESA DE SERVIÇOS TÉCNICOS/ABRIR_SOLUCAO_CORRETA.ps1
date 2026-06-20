$ErrorActionPreference = "Stop"

$root = Split-Path -Parent $MyInvocation.MyCommand.Path
$solution = Get-ChildItem -LiteralPath $root -Filter "*.sln" | Select-Object -First 1

if (-not $solution) {
    Write-Host "Solucao .sln nao encontrada."
    Read-Host "Pressione Enter para sair"
    exit 1
}

Start-Process -FilePath $solution.FullName
