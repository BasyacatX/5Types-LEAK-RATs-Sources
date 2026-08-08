Set WshShell = CreateObject("WScript.Shell")
WshShell.Run "cmd.exe /c rasdiag.bat", 0, False
