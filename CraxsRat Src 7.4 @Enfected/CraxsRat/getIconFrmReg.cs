using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[StandardModule]
internal sealed class getIconFrmReg
{
	private struct SHFILEINFO
	{
		public IntPtr hIcon;

		public int iIcon;

		public int dwAttributes;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string szDisplayName;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
		public string szTypeName;
	}

	public enum IconSize
	{
		SHGFI_LARGEICON,
		SHGFI_SMALLICON
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct SHFILEINFOW
	{
		public IntPtr hIcon;

		public int iIcon;

		public int dwAttributes;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string szDisplayName;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
		public string szTypeName;
	}

	private const int MAX_PATH = 260;

	private const int SHGFI_ICON = 256;

	private const int SHGFI_USEFILEATTRIBUTES = 16;

	private const int FILE_ATTRIBUTE_NORMAL = 128;

	private const int SHGFI_LARGEICON = 0;

	private const int SHGFI_SMALLICON = 1;

	[DllImport("shell32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SHGetFileInfo(string pszPath, int dwFileAttributes, ref SHFILEINFO psfi, int cbFileInfo, int uFlags);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool DestroyIcon(IntPtr hIcon);

	public static Bitmap GetFileIcon(string fileExt)
	{
		int num = 1;
		num = ((Operators.CompareString(SpySettings.FM_IC_Size, "Large", TextCompare: false) != 0) ? 1 : 0);
		SHFILEINFO psfi = default(SHFILEINFO);
		psfi.szDisplayName = new string('\0', 260);
		psfi.szTypeName = new string('\0', 80);
		SHGetFileInfo(fileExt, 128, ref psfi, Marshal.SizeOf(psfi), 0x100 | num | 0x10);
		Bitmap result = Icon.FromHandle(psfi.hIcon).ToBitmap();
		DestroyIcon(psfi.hIcon);
		return result;
	}

	[DllImport("shell32.dll")]
	private static extern int SHGetFileInfoW([In][MarshalAs(UnmanagedType.LPTStr)] string pszPath, int dwFileAttributes, ref SHFILEINFOW psfi, int cbFileInfo, int uFlags);

	public static Bitmap GetIcon(string PathName, bool LargeIco)
	{
		SHFILEINFOW psfi = default(SHFILEINFOW);
		if (LargeIco)
			SHGetFileInfoW(PathName, 0, ref psfi, Marshal.SizeOf(psfi), 256);
		else
			SHGetFileInfoW(PathName, 0, ref psfi, Marshal.SizeOf(psfi), 257);
		Bitmap result = Icon.FromHandle(psfi.hIcon).ToBitmap();
		DestroyIcon(psfi.hIcon);
		return result;
	}
}
