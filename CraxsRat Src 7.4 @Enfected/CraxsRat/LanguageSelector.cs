using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class LanguageSelector : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("copydev")]
	private DrakeUIButton _copydev;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButton1")]
	private DrakeUIButton _DrakeUIButton1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButton2")]
	private DrakeUIButton _DrakeUIButton2;

	public string SelectedLang;

	[field: AccessedThroughProperty("titletext")]
	internal DrakeUISymbolLabel titletext
	;

	internal DrakeUIButton copydev
	;

	internal DrakeUIButton DrakeUIButton1
	;
    private Label label5;
    private Label label3;
    private Label label2;
    private Label label1;
    internal DrakeUIButton DrakeUIButton2
	;

	public LanguageSelector()
	{
		base.Load += LanguageSelector_Load;
		SelectedLang = "";
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
            this.titletext = new DrakeUI.Framework.DrakeUISymbolLabel();
            this.copydev = new DrakeUI.Framework.DrakeUIButton();
            this.DrakeUIButton1 = new DrakeUI.Framework.DrakeUIButton();
            this.DrakeUIButton2 = new DrakeUI.Framework.DrakeUIButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titletext
            // 
            this.titletext.Dock = System.Windows.Forms.DockStyle.Top;
            this.titletext.Font = new System.Drawing.Font("Calibri", 15F);
            this.titletext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.titletext.Location = new System.Drawing.Point(0, 0);
            this.titletext.Margin = new System.Windows.Forms.Padding(2);
            this.titletext.Name = "titletext";
            this.titletext.Padding = new System.Windows.Forms.Padding(49, 0, 0, 0);
            this.titletext.Size = new System.Drawing.Size(411, 45);
            this.titletext.Style = DrakeUI.Framework.UIStyle.Custom;
            this.titletext.Symbol = 61870;
            this.titletext.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.titletext.SymbolSize = 45;
            this.titletext.TabIndex = 0;
            this.titletext.Text = "WELCOME TO CraxsRat";
            // 
            // copydev
            // 
            this.copydev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copydev.FillColor = System.Drawing.Color.Black;
            this.copydev.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.copydev.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.copydev.FillPressColor = System.Drawing.Color.Black;
            this.copydev.FillSelectedColor = System.Drawing.Color.Black;
            this.copydev.Font = new System.Drawing.Font("Calibri", 12F);
            this.copydev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.copydev.Location = new System.Drawing.Point(56, 460);
            this.copydev.Name = "copydev";
            this.copydev.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.copydev.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.copydev.Size = new System.Drawing.Size(54, 65);
            this.copydev.Style = DrakeUI.Framework.UIStyle.Custom;
            this.copydev.TabIndex = 15;
            this.copydev.Text = "العربية";
            this.copydev.Visible = false;
            // 
            // DrakeUIButton1
            // 
            this.DrakeUIButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DrakeUIButton1.FillColor = System.Drawing.Color.Black;
            this.DrakeUIButton1.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButton1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButton1.FillPressColor = System.Drawing.Color.Black;
            this.DrakeUIButton1.FillSelectedColor = System.Drawing.Color.Black;
            this.DrakeUIButton1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrakeUIButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButton1.Location = new System.Drawing.Point(0, 434);
            this.DrakeUIButton1.Name = "DrakeUIButton1";
            this.DrakeUIButton1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButton1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButton1.Size = new System.Drawing.Size(411, 77);
            this.DrakeUIButton1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButton1.TabIndex = 16;
            this.DrakeUIButton1.Text = "I AGREE";
            this.DrakeUIButton1.Click += new System.EventHandler(this.DrakeUIButton1_Click);
            // 
            // DrakeUIButton2
            // 
            this.DrakeUIButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButton2.FillColor = System.Drawing.Color.Black;
            this.DrakeUIButton2.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButton2.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButton2.FillPressColor = System.Drawing.Color.Black;
            this.DrakeUIButton2.FillSelectedColor = System.Drawing.Color.Black;
            this.DrakeUIButton2.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButton2.Location = new System.Drawing.Point(348, 477);
            this.DrakeUIButton2.Name = "DrakeUIButton2";
            this.DrakeUIButton2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButton2.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButton2.Size = new System.Drawing.Size(54, 65);
            this.DrakeUIButton2.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButton2.TabIndex = 17;
            this.DrakeUIButton2.Text = "中国人";
            this.DrakeUIButton2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(87, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Terms && Conditions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(24, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 100);
            this.label3.TabIndex = 20;
            this.label3.Text = "3. you are the only responsible for any \r\nillegal usage of this software   \r\nowne" +
    "r is not responsible for any \r\ndamage caused by this software.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(24, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 125);
            this.label2.TabIndex = 19;
            this.label2.Text = "2.  You are granted a non-transferable\r\n license for intended use only. \r\nAny for" +
    "m of unauthorized \r\ndistribution or modification is\r\n against the terms of use.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(24, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 100);
            this.label1.TabIndex = 18;
            this.label1.Text = "1.  keep your license key secure, \r\nand ensure that your use of \r\nthe software co" +
    "mplies with all\r\n applicable laws and regulations.";
            // 
            // LanguageSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(411, 511);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DrakeUIButton1);
            this.Controls.Add(this.copydev);
            this.Controls.Add(this.titletext);
            this.Controls.Add(this.DrakeUIButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(411, 511);
            this.MinimumSize = new System.Drawing.Size(411, 511);
            this.Name = "LanguageSelector";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LanguageSelector";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

	}

	private void Copydev_Click(object sender, EventArgs e)
	{
		SelectedLang = "AR";
		Close();
	}

	private void DrakeUIButton1_Click(object sender, EventArgs e)
	{
		SelectedLang = "EN";
		Close();
	}

	private void DrakeUIButton2_Click(object sender, EventArgs e)
	{
		SelectedLang = "CN";
		Close();
	}

	private void LanguageSelector_Load(object sender, EventArgs e)
	{
	}

 
}
