@echo off
setlocal

set "ROOT=%~dp0"
set "OUTPUT=%ROOT%artifacts"

if not exist "%OUTPUT%" mkdir "%OUTPUT%"

echo Packing Posta...
dotnet pack "%ROOT%Posta.csproj" ^
    --configuration Release ^
    --output "%OUTPUT%"

if errorlevel 1 exit /b 1

echo Packing Posta.Aspire...
dotnet pack "%ROOT%Posta.Aspire\Posta.Aspire.csproj" ^
    --configuration Release ^
    --output "%OUTPUT%"

if errorlevel 1 exit /b 1

echo.
echo Created NuGet packages:
dir /b "%OUTPUT%\*.nupkg"

exit /b 0