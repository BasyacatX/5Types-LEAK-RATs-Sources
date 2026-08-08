using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[StandardModule]
internal sealed class RefreshExplorer
{
	[Flags]
	public enum HChangeNotifyFlags
	{
		SHCNF_DWORD = 3,
		SHCNF_IDLIST = 0,
		SHCNF_PATHA = 1,
		SHCNF_PATHW = 5,
		SHCNF_PRINTERA = 2,
		SHCNF_PRINTERW = 6,
		SHCNF_FLUSH = 0x1000,
		SHCNF_FLUSHNOWAIT = 0x2000
	}

	[Flags]
	public enum HChangeNotifyEventID
	{
		SHCNE_ALLEVENTS = int.MaxValue,
		SHCNE_ASSOCCHANGED = 0x8000000,
		SHCNE_ATTRIBUTES = 0x800,
		SHCNE_CREATE = 2,
		SHCNE_DELETE = 4,
		SHCNE_DRIVEADD = 0x10,
		SHCNE_DRIVEADDGUI = 0x10000,
		SHCNE_DRIVEREMOVED = 0x80,
		SHCNE_EXTENDED_EVENT = 0x4000000,
		SHCNE_FREESPACE = 0x40000,
		SHCNE_MEDIAINSERTED = 0x20,
		SHCNE_MEDIAREMOVED = 0x40,
		SHCNE_MKDIR = 8,
		SHCNE_NETSHARE = 0x200,
		SHCNE_NETUNSHARE = 0x400,
		SHCNE_RENAMEFOLDER = 0x20000,
		SHCNE_RENAMEITEM = 1,
		SHCNE_RMDIR = 0x10,
		SHCNE_SERVERDISCONNECT = 0x4000,
		SHCNE_UPDATEDIR = 0x1000,
		SHCNE_UPDATEIMAGE = 0x8000
	}

	[DllImport("shell32.dll")]
	public static extern void SHChangeNotify(HChangeNotifyEventID wEventID, HChangeNotifyFlags uFlags, IntPtr dwItem1, IntPtr dwItem2);

	public static void EnvRefresh()
	{
		SHChangeNotify(HChangeNotifyEventID.SHCNE_ASSOCCHANGED, HChangeNotifyFlags.SHCNF_IDLIST, IntPtr.Zero, IntPtr.Zero);
	}
}
