using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Eagle_Spy.My;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class CallPhone : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private Timer _TOpacity;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("B_hash")]
	private Button _B_hash;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b0")]
	private Button _b0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("B_star")]
	private Button _B_star;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b9")]
	private Button _b9;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b8")]
	private Button _b8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b7")]
	private Button _b7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b6")]
	private Button _b6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b5")]
	private Button _b5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b4")]
	private Button _b4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b3")]
	private Button _b3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b2")]
	private Button _b2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b1")]
	private Button _b1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b_DEL")]
	private Button _b_DEL;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CutToolStripMenuItem")]
	private ToolStripMenuItem _CutToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CopyToolStripMenuItem")]
	private ToolStripMenuItem _CopyToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PasteToolStripMenuItem")]
	private ToolStripMenuItem _PasteToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	private bool _keyback;

	public string _Call;

	public string Title;

	private List<Rectangle> RectInputText0;

	internal TextBox TextBox1
	;

	internal Timer TOpacity
;

	internal Panel Panel1
	;

	[field: AccessedThroughProperty("L0")]
	internal Label L0
    ;

	internal Button B_hash
	;
	internal Button b0
	;

	internal Button B_star
;

	internal Button b9
	;

	internal Button b8
	;

	internal Button b7
	;

	internal Button b6
;

	internal Button b5
	;

	internal Button b4
	;

	internal Button b3
;

	internal Button b2
	;

	internal Button b1
	;

	internal Button b_DEL
;

	[field: AccessedThroughProperty("CMenu")]
	internal ContextMenuStrip CMenu
    ;

	internal ToolStripMenuItem CutToolStripMenuItem
	;

	internal ToolStripMenuItem CopyToolStripMenuItem
	;

	internal ToolStripMenuItem PasteToolStripMenuItem
;
    private DrakeUIButtonIcon drakeUIButtonIcon1;

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
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TOpacity = new System.Windows.Forms.Timer(this.components);
            this.Panel1 = new System.Windows.Forms.Panel();
            this.drakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.b_DEL = new System.Windows.Forms.Button();
            this.B_hash = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.B_star = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.L0 = new System.Windows.Forms.Label();
            this.CMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel1.SuspendLayout();
            this.CMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.Black;
            this.TextBox1.ForeColor = System.Drawing.Color.White;
            this.TextBox1.Location = new System.Drawing.Point(37, 37);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ShortcutsEnabled = false;
            this.TextBox1.Size = new System.Drawing.Size(156, 20);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.TextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            this.TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // TOpacity
            // 
            this.TOpacity.Interval = 1;
            this.TOpacity.Tick += new System.EventHandler(this.TOpacity_Tick);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Black;
            this.Panel1.Controls.Add(this.drakeUIButtonIcon1);
            this.Panel1.Controls.Add(this.b_DEL);
            this.Panel1.Controls.Add(this.B_hash);
            this.Panel1.Controls.Add(this.b0);
            this.Panel1.Controls.Add(this.B_star);
            this.Panel1.Controls.Add(this.b9);
            this.Panel1.Controls.Add(this.b8);
            this.Panel1.Controls.Add(this.b7);
            this.Panel1.Controls.Add(this.b6);
            this.Panel1.Controls.Add(this.b5);
            this.Panel1.Controls.Add(this.b4);
            this.Panel1.Controls.Add(this.b3);
            this.Panel1.Controls.Add(this.b2);
            this.Panel1.Controls.Add(this.b1);
            this.Panel1.Controls.Add(this.L0);
            this.Panel1.Controls.Add(this.TextBox1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(232, 326);
            this.Panel1.TabIndex = 2;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // drakeUIButtonIcon1
            // 
            this.drakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon1.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUIButtonIcon1.Location = new System.Drawing.Point(23, 284);
            this.drakeUIButtonIcon1.Name = "drakeUIButtonIcon1";
            this.drakeUIButtonIcon1.Radius = 35;
            this.drakeUIButtonIcon1.RectColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.drakeUIButtonIcon1.Size = new System.Drawing.Size(175, 35);
            this.drakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon1.Symbol = 61589;
            this.drakeUIButtonIcon1.TabIndex = 21;
            this.drakeUIButtonIcon1.Text = "CALL";
            // 
            // b_DEL
            // 
            this.b_DEL.FlatAppearance.BorderSize = 0;
            this.b_DEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_DEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_DEL.ForeColor = System.Drawing.Color.Red;
            this.b_DEL.Location = new System.Drawing.Point(200, 37);
            this.b_DEL.Name = "b_DEL";
            this.b_DEL.Size = new System.Drawing.Size(32, 21);
            this.b_DEL.TabIndex = 15;
            this.b_DEL.Text = "<";
            this.b_DEL.UseVisualStyleBackColor = true;
            this.b_DEL.Click += new System.EventHandler(this.b_DEL_Click);
            // 
            // B_hash
            // 
            this.B_hash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_hash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.B_hash.Location = new System.Drawing.Point(145, 224);
            this.B_hash.Name = "B_hash";
            this.B_hash.Size = new System.Drawing.Size(48, 48);
            this.B_hash.TabIndex = 14;
            this.B_hash.Text = "#";
            this.B_hash.UseVisualStyleBackColor = true;
            this.B_hash.Click += new System.EventHandler(this.B_hash_Click);
            // 
            // b0
            // 
            this.b0.FlatAppearance.BorderSize = 0;
            this.b0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.b0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b0.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.b0.Location = new System.Drawing.Point(91, 224);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(48, 48);
            this.b0.TabIndex = 13;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // B_star
            // 
            this.B_star.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_star.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.B_star.Location = new System.Drawing.Point(37, 224);
            this.B_star.Name = "B_star";
            this.B_star.Size = new System.Drawing.Size(48, 48);
            this.B_star.TabIndex = 12;
            this.B_star.Text = "*";
            this.B_star.UseVisualStyleBackColor = true;
            this.B_star.Click += new System.EventHandler(this.B_star_Click);
            // 
            // b9
            // 
            this.b9.FlatAppearance.BorderSize = 0;
            this.b9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.b9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.b9.Location = new System.Drawing.Point(145, 170);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(48, 48);
            this.b9.TabIndex = 11;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b8
            // 
            this.b8.FlatAppearance.BorderSize = 0;
            this.b8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.b8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.b8.Location = new System.Drawing.Point(91, 170);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(48, 48);
            this.b8.TabIndex = 10;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b7
            // 
            this.b7.FlatAppearance.BorderSize = 0;
            this.b7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.b7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.b7.Location = new System.Drawing.Point(37, 170);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(48, 48);
            this.b7.TabIndex = 9;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b6
            // 
            this.b6.FlatAppearance.BorderSize = 0;
            this.b6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.b6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.b6.Location = new System.Drawing.Point(145, 116);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(48, 48);
            this.b6.TabIndex = 8;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b5
            // 
            this.b5.FlatAppearance.BorderSize = 0;
            this.b5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.b5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.b5.Location = new System.Drawing.Point(91, 116);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(48, 48);
            this.b5.TabIndex = 7;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b4
            // 
            this.b4.FlatAppearance.BorderSize = 0;
            this.b4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.b4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.b4.Location = new System.Drawing.Point(37, 116);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(48, 48);
            this.b4.TabIndex = 6;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b3
            // 
            this.b3.FlatAppearance.BorderSize = 0;
            this.b3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.b3.Location = new System.Drawing.Point(145, 62);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(48, 48);
            this.b3.TabIndex = 5;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b2
            // 
            this.b2.FlatAppearance.BorderSize = 0;
            this.b2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.b2.Location = new System.Drawing.Point(91, 62);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(48, 48);
            this.b2.TabIndex = 4;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b1
            // 
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.b1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.b1.Location = new System.Drawing.Point(37, 62);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(48, 48);
            this.b1.TabIndex = 3;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // L0
            // 
            this.L0.AutoSize = true;
            this.L0.Location = new System.Drawing.Point(3, 9);
            this.L0.Name = "L0";
            this.L0.Size = new System.Drawing.Size(23, 13);
            this.L0.TabIndex = 2;
            this.L0.Text = "null";
            // 
            // CMenu
            // 
            this.CMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem});
            this.CMenu.Name = "CMenu";
            this.CMenu.ShowImageMargin = false;
            this.CMenu.Size = new System.Drawing.Size(78, 70);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(77, 22);
            this.CutToolStripMenuItem.Text = "Cut";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(77, 22);
            this.CopyToolStripMenuItem.Text = "Copy";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(77, 22);
            this.PasteToolStripMenuItem.Text = "Paste";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // CallPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(232, 326);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CallPhone";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.Text = "Call Phone";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.CMenu.ResumeLayout(false);
            this.ResumeLayout(false);

	}

	public CallPhone()
	{
		base.Load += CallPhone_Load;
		_keyback = false;
		_Call = "call";
		Title = "null";
		RectInputText0 = new List<Rectangle>();
		InitializeComponent();
		Font = reso.f;
	}

	private void TOpacity_Tick(object sender, EventArgs e)
	{
		if (base.Opacity != 1.0)
			base.Opacity += 0.1;
		else
			TOpacity.Enabled = false;
	}

	private void CallPhone_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\18.ico");
		TextBox1.ContextMenuStrip = CMenu;
		int fontSize = MySettingsProperty.Settings.FontSize;
		if (IsFontInstalled("Wingdings 3"))
		{
			b_DEL.Font = new Font("Wingdings 3", fontSize, FontStyle.Regular);
			b_DEL.Text = "…";
		}
		else
			b_DEL.Text = "<";
		TOpacity.Interval = SpySettings.T_Interval;
		TOpacity.Enabled = true;
	}

	public static bool IsFontInstalled(string FontName)
	{
		using Font font = new Font(FontName, 10f);
		return string.Compare(FontName, font.Name, StringComparison.InvariantCultureIgnoreCase) == 0;
	}

	private void Panel1_Paint(object sender, PaintEventArgs e)
	{
		e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
		Color defaultColor_Foreground = SpySettings.DefaultColor_Foreground;
		if (RectInputText0.Count <= 0)
			return;
		foreach (Rectangle item in RectInputText0)
		{
			if (item.Width > 0)
				e.Graphics.FillRectangle(new SolidBrush(defaultColor_Foreground), item);
		}
	}

	private void b1_Click(object sender, EventArgs e)
	{
		TextBox1.Text += "1";
	}

	private void b2_Click(object sender, EventArgs e)
	{
		TextBox1.Text += "2";
	}

	private void b3_Click(object sender, EventArgs e)
	{
		TextBox1.Text += "3";
	}

	private void b4_Click(object sender, EventArgs e)
	{
		TextBox1.Text += "4";
	}

	private void b5_Click(object sender, EventArgs e)
	{
		TextBox1.Text += "5";
	}

	private void b6_Click(object sender, EventArgs e)
	{
		TextBox1.Text += "6";
	}

	private void b7_Click(object sender, EventArgs e)
	{
		TextBox1.Text += "7";
	}

	private void b8_Click(object sender, EventArgs e)
	{
		TextBox1.Text += "8";
	}

	private void b9_Click(object sender, EventArgs e)
	{
		TextBox1.Text += "9";
	}

	private void b0_Click(object sender, EventArgs e)
	{
		TextBox1.Text += "0";
	}

	private void b_DEL_Click(object sender, EventArgs e)
	{
		if (TextBox1.Text.Length > 0)
			TextBox1.Text = TextBox1.Text.Remove(checked(TextBox1.Text.Length - 1));
	}

	private void B_star_Click(object sender, EventArgs e)
	{
		TextBox1.Text += "*";
	}

	private void B_hash_Click(object sender, EventArgs e)
	{
		TextBox1.Text += "#";
	}

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (_keyback)
		{
			e.Handled = false;
			return;
		}
		string text = "0123456789,*#+";
		if (!text.Contains(e.KeyChar.ToString()))
			e.Handled = true;
	}

	private void TextBox1_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Back)
			_keyback = true;
		else
			_keyback = false;
	}

	private void CutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		TextBox1.Cut();
	}

	private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		TextBox1.Copy();
	}

	private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		string text = "0123456789,*#+";
		if (MyProject.Computer.Clipboard.ContainsText())
		{
			string text2 = MyProject.Computer.Clipboard.GetText();
			if (text2.Length <= 1500)
			{
				string text3 = text2;
				foreach (char c in text3)
				{
					if (!text.ToString().Contains(Conversions.ToString(c)))
						return;
				}
			}
		}
		TextBox1.Paste();
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		_Call = "call";
		base.DialogResult = DialogResult.OK;
	}

 
}
