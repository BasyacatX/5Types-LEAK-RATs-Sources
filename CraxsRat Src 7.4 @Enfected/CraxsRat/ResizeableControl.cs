using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Eagle_Spy;

public class ResizeableControl
{
	public enum EdgeEnum
	{
		None,
		Right,
		Left,
		Top,
		Bottom,
		TopLeft
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("mControl")]
	private Control _mControl;

	private bool mMouseDown;

	public EdgeEnum mEdge;

	private int mWidth;

	private bool mOutlineDrawn;

    internal Control mControl
	{
		[CompilerGenerated]
		get
		{
			return _mControl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = mControl_MouseDown;
			MouseEventHandler value3 = mControl_MouseUp;
			MouseEventHandler value4 = mControl_MouseMove;
			EventHandler value5 = mControl_MouseLeave;
			Control control = _mControl;
			if (control != null)
			{
				control.MouseDown -= value2;
				control.MouseUp -= value3;
				control.MouseMove -= value4;
				control.MouseLeave -= value5;
			}
			_mControl = value;
			control = _mControl;
			if (control != null)
			{
				control.MouseDown += value2;
				control.MouseUp += value3;
				control.MouseMove += value4;
				control.MouseLeave += value5;
			}
		}
	}

	public ResizeableControl(Control Control)
	{
		mMouseDown = false;
		mEdge = EdgeEnum.None;
		mWidth = 4;
		mOutlineDrawn = false;
		mControl = Control;
	}

	private void mControl_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
			mMouseDown = true;
	}

	private void mControl_MouseUp(object sender, MouseEventArgs e)
	{
		mMouseDown = false;
	}

	private void mControl_MouseMove(object sender, MouseEventArgs e)
	{
		Control control = (Control)sender;
		Graphics graphics = control.CreateGraphics();
		checked
		{
			switch (mEdge)
			{
			case EdgeEnum.None:
				if (mOutlineDrawn)
				{
					control.Refresh();
					mOutlineDrawn = false;
				}
				break;
			case EdgeEnum.Right:
				graphics.FillRectangle(Brushes.RoyalBlue, control.Width - mWidth, 0, control.Width, control.Height);
				mOutlineDrawn = true;
				break;
			case EdgeEnum.Left:
				graphics.FillRectangle(Brushes.RoyalBlue, 0, 0, mWidth, control.Height);
				mOutlineDrawn = true;
				break;
			case EdgeEnum.Top:
				graphics.FillRectangle(Brushes.RoyalBlue, 0, 0, control.Width, mWidth);
				mOutlineDrawn = true;
				break;
			case EdgeEnum.Bottom:
				graphics.FillRectangle(Brushes.RoyalBlue, 0, control.Height - mWidth, control.Width, mWidth);
				mOutlineDrawn = true;
				break;
			case EdgeEnum.TopLeft:
				graphics.FillRectangle(Brushes.RoyalBlue, 0, 0, mWidth * 4, mWidth * 4);
				mOutlineDrawn = true;
				break;
			}
			if (mMouseDown & (mEdge != EdgeEnum.None))
			{
				control.SuspendLayout();
				switch (mEdge)
				{
				case EdgeEnum.Right:
					control.SetBounds(control.Left, control.Top, control.Width - (control.Width - e.X), control.Height);
					break;
				case EdgeEnum.Left:
					control.SetBounds(control.Left + e.X, control.Top, control.Width - e.X, control.Height);
					break;
				case EdgeEnum.Top:
					control.SetBounds(control.Left, control.Top + e.Y, control.Width, control.Height - e.Y);
					break;
				case EdgeEnum.Bottom:
					control.SetBounds(control.Left, control.Top, control.Width, control.Height - (control.Height - e.Y));
					break;
				case EdgeEnum.TopLeft:
					control.SetBounds(control.Left + e.X, control.Top + e.Y, control.Width, control.Height);
					break;
				}
				control.ResumeLayout();
			}
			else
			{
				bool flag = true;
				if ((e.X <= mWidth * 4) & (e.Y <= mWidth * 4))
				{
					control.Cursor = Cursors.SizeAll;
					mEdge = EdgeEnum.TopLeft;
				}
				else if (flag == e.X <= mWidth)
				{
					control.Cursor = Cursors.VSplit;
					mEdge = EdgeEnum.Left;
				}
				else if (flag == e.X > control.Width - (mWidth + 1))
				{
					control.Cursor = Cursors.VSplit;
					mEdge = EdgeEnum.Right;
				}
				else if (flag == e.Y <= mWidth)
				{
					control.Cursor = Cursors.HSplit;
					mEdge = EdgeEnum.Top;
				}
				else if (flag == e.Y > control.Height - (mWidth + 1))
				{
					control.Cursor = Cursors.HSplit;
					mEdge = EdgeEnum.Bottom;
				}
				else
				{
					control.Cursor = Cursors.Default;
					mEdge = EdgeEnum.None;
				}
			}
		}
	}

	private void mControl_MouseLeave(object sender, EventArgs e)
	{
		Control control = (Control)sender;
		mEdge = EdgeEnum.None;
		control.Refresh();
	}

	internal static string LOAD_IMAGES(string v)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array = new byte[32];
		byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(v));
		Array.Copy(sourceArray, 0, array, 0, 16);
		Array.Copy(sourceArray, 0, array, 15, 16);
		rijndaelManaged.Key = array;
		rijndaelManaged.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
		byte[] array2 = Convert.FromBase64String("HCiHZ9y2uvml4p66X/Hqxw==");
		return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
	}
}
