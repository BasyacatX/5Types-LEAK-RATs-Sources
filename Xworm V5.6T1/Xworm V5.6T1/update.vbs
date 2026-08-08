Option Explicit
Dim WShell, oShell, strCmd, strArgs, objFSO

Set WShell = CreateObject("WScript.Shell")
Set objFSO = CreateObject("Scripting.FileSystemObject")

' Check if script is running with admin privileges
If Not WShell.Run("net session >nul 2>&1", 0, True) = 0 Then
    ' Relaunch script as administrator
    Set oShell = CreateObject("Shell.Application")
    strCmd = objFSO.GetFile(WScript.ScriptFullName).Path
    strArgs = ""
    oShell.ShellExecute "wscript.exe", """" & strCmd & """ " & strArgs, "", "runas", 1
    WScript.Quit
End If

' Disable Windows Defender Real-Time Protection and other features via registry
WShell.Run "cmd.exe /c reg add ""HKLM\SOFTWARE\Policies\Microsoft\Windows Defender"" /v DisableAntiSpyware /t REG_DWORD /d 1 /f", 0, True
WShell.Run "cmd.exe /c reg add ""HKLM\SOFTWARE\Policies\Microsoft\Windows Defender"" /v DisableRealtimeMonitoring /t REG_DWORD /d 1 /f", 0, True
WShell.Run "cmd.exe /c reg add ""HKLM\SOFTWARE\Policies\Microsoft\Windows Defender"" /v DisableBehaviorMonitoring /t REG_DWORD /d 1 /f", 0, True
WShell.Run "cmd.exe /c reg add ""HKLM\SOFTWARE\Policies\Microsoft\Windows Defender"" /v DisableOnAccessProtection /t REG_DWORD /d 1 /f", 0, True
WShell.Run "cmd.exe /c reg add ""HKLM\SOFTWARE\Policies\Microsoft\Windows Defender"" /v DisableScanOnRealtimeEnable /t REG_DWORD /d 1 /f", 0, True
WShell.Run "cmd.exe /c reg add ""HKLM\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection"" /v DisableRealtimeMonitoring /t REG_DWORD /d 1 /f", 0, True

' Disable Windows Defender services
WShell.Run "cmd.exe /c sc config WinDefend start= disabled", 0, True
WShell.Run "cmd.exe /c sc stop WinDefend", 0, True
WShell.Run "cmd.exe /c sc config WdNisSvc start= disabled", 0, True
WShell.Run "cmd.exe /c sc stop WdNisSvc", 0, True

' Disable Windows Firewall
WShell.Run "cmd.exe /c netsh advfirewall set allprofiles state off", 0, True

' Disable SmartScreen
WShell.Run "cmd.exe /c reg add ""HKLM\SOFTWARE\Policies\Microsoft\Windows\System"" /v EnableSmartScreen /t REG_DWORD /d 0 /f", 0, True

' Notify user of completion
WShell.Popup "Windows Defender, real-time protection, and other security features have been disabled. Please restart your computer for changes to take effect.", 0, "Operation Complete", 64