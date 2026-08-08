using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class Apkinstaller : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	[field: AccessedThroughProperty("Panel1")]
	internal Panel Panel1
	;

	[field: AccessedThroughProperty("PictureBox1")]
	internal PictureBox PictureBox1
    ;

    [field: AccessedThroughProperty("Panel2")]
	internal Panel Panel2
    ;

	internal LinkLabel LinkLabel1
;

    [field: AccessedThroughProperty("Label1")]
	internal Label Label1
    ;

    public Apkinstaller()
	{
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(614, 501);
            this.Panel1.TabIndex = 0;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(86, 33);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(451, 416);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.LinkLabel1);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel2.Location = new System.Drawing.Point(0, 466);
            this.Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(614, 35);
            this.Panel2.TabIndex = 1;
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.LinkLabel1.Font = new System.Drawing.Font("Calibri", 9F);
            this.LinkLabel1.Location = new System.Drawing.Point(211, 0);
            this.LinkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(55, 35);
            this.LinkLabel1.TabIndex = 3;
            this.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // Label1
            // 
            this.Label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(211, 35);
            this.Label1.TabIndex = 1;
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Apkinstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(614, 501);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Apkinstaller";
            this.Text = "Apkinstaller";
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

	}

	private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
	}
}
