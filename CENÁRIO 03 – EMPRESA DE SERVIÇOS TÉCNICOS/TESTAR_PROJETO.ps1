$ErrorActionPreference = "Stop"

$root = Split-Path -Parent $MyInvocation.MyCommand.Path
$project = Get-ChildItem -LiteralPath $root -Recurse -Filter "*.csproj" |
    Where-Object { $_.Name -like "CEN*SERVI*.csproj" } |
    Select-Object -First 1

if (-not $project) {
    Write-Host "Projeto .csproj nao encontrado."
    Read-Host "Pressione Enter para sair"
    exit 1
}

Write-Host "Compilando o projeto..."
dotnet build $project.FullName

if ($LASTEXITCODE -ne 0) {
    Write-Host ""
    Write-Host "A compilacao falhou. Veja a mensagem acima."
    Read-Host "Pressione Enter para sair"
    exit $LASTEXITCODE
}

Write-Host ""
Write-Host "Abrindo o sistema..."
$projectDir = Split-Path -Parent $project.FullName
$exe = Get-ChildItem -LiteralPath (Join-Path $projectDir "bin\Debug\net10.0-windows") -Filter "*.exe" |
    Where-Object { $_.Name -like "CEN*SERVI*.exe" } |
    Select-Object -First 1

if (-not $exe) {
    Write-Host "Executavel nao encontrado depois da compilacao."
    Read-Host "Pressione Enter para sair"
    exit 1
}

Start-Process -FilePath $exe.FullName
Write-Host "Sistema aberto."
