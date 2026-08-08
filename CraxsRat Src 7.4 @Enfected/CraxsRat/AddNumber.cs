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
public class AddNumber : Form
{
	private IContainer components;

	private DrakeUIButtonIcon _DrakeUIButtonIcon3;

	private List<Rectangle> RectInputText0;

	internal Panel Panel1;
	//{
	//	[CompilerGenerated]
	//	get
	//	{
	//		return _Panel1;
	//	}
	//	[MethodImpl(MethodImplOptions.Synchronized)]
	//	[CompilerGenerated]
	//	set
	//	{
	//		PaintEventHandler value2 = Panel1_Paint;
	//		Panel panel = _Panel1;
	//		if (panel != null)
	//			panel.Paint -= value2;
	//		_Panel1 = value;
	//		panel = _Panel1;
	//		if (panel != null)
	//			panel.Paint += value2;
	//	}
	//}

	[field: AccessedThroughProperty("InputText1")]
	internal TextBox InputText1
;

    [field: AccessedThroughProperty("L1")]
	internal Label L1
;

    [field: AccessedThroughProperty("InputText0")]
	internal TextBox InputText0
;

    [field: AccessedThroughProperty("L0")]
	internal Label L0
;
    private Sipaa.Framework.SButton sButton1;
    internal Timer TOpacity
	;
	//{
	//	[CompilerGenerated]
	//	get
	//	{
	//		return _DrakeUIButtonIcon3;
	//	}
	//	[MethodImpl(MethodImplOptions.Synchronized)]
	//	[CompilerGenerated]
	//	set
	//	{
	//		EventHandler value2 = DrakeUIButtonIcon3_Click;
	//		DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon3;
	//		if (drakeUIButtonIcon != null)
	//			drakeUIButtonIcon.Click -= value2;
	//		_DrakeUIButtonIcon3 = value;
	//		drakeUIButtonIcon = _DrakeUIButtonIcon3;
	//		if (drakeUIButtonIcon != null)
	//			drakeUIButtonIcon.Click += value2;
	//	}
	//}

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
            this.sButton1 = new Sipaa.Framework.SButton();
            this.InputText1 = new System.Windows.Forms.TextBox();
            this.L1 = new System.Windows.Forms.Label();
            this.InputText0 = new System.Windows.Forms.TextBox();
            this.L0 = new System.Windows.Forms.Label();
            this.TOpacity = new System.Windows.Forms.Timer(this.components);
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Black;
            this.Panel1.Controls.Add(this.sButton1);
            this.Panel1.Controls.Add(this.InputText1);
            this.Panel1.Controls.Add(this.L1);
            this.Panel1.Controls.Add(this.InputText0);
            this.Panel1.Controls.Add(this.L0);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(447, 231);
            this.Panel1.TabIndex = 1;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // sButton1
            // 
            this.sButton1.BackColor = System.Drawing.Color.Black;
            this.sButton1.BorderColor = System.Drawing.Color.Red;
            this.sButton1.BorderRadius = 6;
            this.sButton1.BorderSize = 2;
            this.sButton1.FlatAppearance.BorderSize = 0;
            this.sButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton1.ForeColor = System.Drawing.Color.Red;
            this.sButton1.Location = new System.Drawing.Point(90, 170);
            this.sButton1.Name = "sButton1";
            this.sButton1.Size = new System.Drawing.Size(231, 40);
            this.sButton1.TabIndex = 6;
            this.sButton1.Text = "Add";
            this.sButton1.UseVisualStyleBackColor = false;
            // 
            // InputText1
            // 
            this.InputText1.BackColor = System.Drawing.Color.White;
            this.InputText1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.InputText1.Location = new System.Drawing.Point(12, 122);
            this.InputText1.Name = "InputText1";
            this.InputText1.Size = new System.Drawing.Size(419, 19);
            this.InputText1.TabIndex = 5;
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.L1.Location = new System.Drawing.Point(12, 89);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(143, 19);
            this.L1.TabIndex = 4;
            this.L1.Text = "New contact number";
            // 
            // InputText0
            // 
            this.InputText0.BackColor = System.Drawing.Color.White;
            this.InputText0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputText0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputText0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.InputText0.Location = new System.Drawing.Point(12, 56);
            this.InputText0.Name = "InputText0";
            this.InputText0.Size = new System.Drawing.Size(419, 19);
            this.InputText0.TabIndex = 2;
            // 
            // L0
            // 
            this.L0.AutoSize = true;
            this.L0.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.L0.Location = new System.Drawing.Point(12, 23);
            this.L0.Name = "L0";
            this.L0.Size = new System.Drawing.Size(130, 19);
            this.L0.TabIndex = 1;
            this.L0.Text = "New contact name";
            // 
            // TOpacity
            // 
            this.TOpacity.Interval = 1;
            this.TOpacity.Tick += new System.EventHandler(this.TOpacity_Tick);
            // 
            // AddNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 231);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNumber";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.Text = "Add Number";
            this.TopMost = true;
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

	}

	private void b_ok_Click(object sender, EventArgs e)
	{
	}

	public AddNumber()
	{
		base.Load += AddNumber_Load;
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

	private void AddNumber_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\12.ico");
		TOpacity.Interval = SpySettings.T_Interval;
		TOpacity.Enabled = true;
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

	private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.OK;
	}
}
