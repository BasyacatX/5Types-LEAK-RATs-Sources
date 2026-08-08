using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Eagle_Spy;

public class RTB : RichTextBox
{
	private bool ctrlPressed;

	private const int WM_MOUSEWHEEL = 522;

	public RTB()
	{
		SetStyle(ControlStyles.EnableNotifyMessage, value: true);
		HideCaret(base.Handle);
	}

	protected override void WndProc(ref Message m)
	{
		if (m.Msg != 522 || !ctrlPressed)
			base.WndProc(ref m);
		HideCaret(base.Handle);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		if (e.Modifiers == Keys.Control)
			ctrlPressed = true;
		base.OnKeyDown(e);
		HideCaret(base.Handle);
	}

	protected override void OnKeyUp(KeyEventArgs e)
	{
		ctrlPressed = false;
		base.OnKeyUp(e);
		HideCaret(base.Handle);
	}

	[DllImport("user32.dll")]
	public static extern bool HideCaret(IntPtr hwnd);
}
