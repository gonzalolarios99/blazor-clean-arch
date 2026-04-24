# Inicia un repositorio Git local y realiza el primer commit.
# Ejecútalo desde la raíz del repositorio: .\scripts\init-git.ps1

$ErrorActionPreference = 'Stop'

if (-not (Get-Command git -ErrorAction SilentlyContinue)) {
    Write-Error 'Git no está instalado o no está en el PATH. Instala Git antes de usar este script.'
    exit 1
}

Set-Location -Path (Resolve-Path '..' | Select-Object -ExpandProperty Path)

if (-not (Test-Path '.git')) {
    git init
}

git add .
git commit -m 'Initial commit: Blazor Clean Architecture'

Write-Host 'Repositorio Git inicializado y primer commit realizado.' -ForegroundColor Green
Write-Host 'Ahora puedes crear el repositorio en GitHub y añadir el remoto:'
Write-Host '  git remote add origin https://github.com/<tu-usuario>/blazor-clean-arch.git'
Write-Host '  git branch -M main'
Write-Host '  git push -u origin main'
