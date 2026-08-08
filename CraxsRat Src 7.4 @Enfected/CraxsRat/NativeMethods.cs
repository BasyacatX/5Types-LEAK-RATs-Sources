using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Eagle_Spy;

public class NativeMethods
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct BLENDFUNCTION
	{
		public byte BlendOp;

		public byte BlendFlags;

		public byte SourceConstantAlpha;

		public byte AlphaFormat;

		public BLENDFUNCTION(byte alpha)
		{
			this = default(BLENDFUNCTION);
			BlendOp = 0;
			BlendFlags = 0;
			SourceConstantAlpha = alpha;
			AlphaFormat = 1;
		}
	}

	internal struct RECT
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;
	}

	internal const int WS_EX_LAYERED = 524288;

	internal const int AC_SRC_OVER = 0;

	internal const int AC_SRC_ALPHA = 1;

	internal const int ULW_ALPHA = 2;

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern bool UpdateLayeredWindow(IntPtr hwnd, IntPtr hdcDst, ref Point pptDst, ref Size psize, IntPtr hdcSrc, ref Point pptSrc, int crKey, ref BLENDFUNCTION pblend, int dwFlags);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern IntPtr GetDC(IntPtr hWnd);

	[DllImport("gdi32.dll")]
	internal static extern IntPtr CreateCompatibleDC(IntPtr dc);

	[DllImport("gdi32.dll")]
	internal static extern IntPtr SelectObject(IntPtr hdc, IntPtr hObj);

	[DllImport("gdi32.dll")]
	internal static extern IntPtr DeleteDC(IntPtr dc);

	[DllImport("gdi32.dll")]
	internal static extern IntPtr DeleteObject(IntPtr hObj);
}
