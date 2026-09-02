param(
    [Parameter(Mandatory = $true)]
    [string]$File
)

# Mendapatkan lokasi repository
$Root = Split-Path -Parent $MyInvocation.MyCommand.Path

# Membuat path lengkap menuju file C#
$FilePath = Join-Path $Root $File

# Memastikan file ada
if (-not (Test-Path $FilePath)) {
    Write-Host "⚠️ File tidak ditemukan:" -ForegroundColor Red
    Write-Host $FilePath
    exit 1
}

# Menjalankan file C#
Write-Host "File" $File "ditemukan di path:" -ForegroundColor Green
Write-Host $FilePath -ForegroundColor Green
Write-Host "========================================" -ForegroundColor Cyan
Write-Host " Menjalankan...: $File" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

dotnet run --file $FilePath