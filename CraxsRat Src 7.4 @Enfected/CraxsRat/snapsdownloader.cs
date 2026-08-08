using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Eagle_Spy.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class snapsdownloader : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon12")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon12;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	public int imageCounter;

	public int totalImages;

	public string Downloadfolder;

	[field: AccessedThroughProperty("Bbar")]
	internal DrakeUIProcessBar Bbar
	;

	[field: AccessedThroughProperty("Panel1")]
	internal Panel Panel1
        ;

    [field: AccessedThroughProperty("infotext")]
	internal Label infotext
        ;

    [field: AccessedThroughProperty("clipic")]
	internal PictureBox clipic
        ;

	internal DrakeUIButtonIcon DrakeUIButtonIcon12
;

	internal DrakeUIButtonIcon DrakeUIButtonIcon1
	;



	[field: AccessedThroughProperty("lefttext")]
	internal Label lefttext
    ;

    [field: AccessedThroughProperty("finishedtext")]
	internal Label finishedtext
    ;

    [field: AccessedThroughProperty("totaltext")]
	internal Label totaltext
    ;

    [field: AccessedThroughProperty("statustext")]
	internal Label statustext
    ;

    [field: AccessedThroughProperty("Label1")]
	internal Label Label1
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
		this.lefttext = new System.Windows.Forms.Label();
		this.finishedtext = new System.Windows.Forms.Label();
		this.totaltext = new System.Windows.Forms.Label();
		this.statustext = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.Bbar = new DrakeUI.Framework.DrakeUIProcessBar();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.DrakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.infotext = new System.Windows.Forms.Label();
		this.DrakeUIButtonIcon12 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.clipic = new System.Windows.Forms.PictureBox();
		this.Panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.clipic).BeginInit();
		base.SuspendLayout();


        DrakeUIButtonIcon12.Click += new EventHandler(DrakeUIButtonIcon12_Click);
        DrakeUIButtonIcon1.Click += new EventHandler(DrakeUIButtonIcon1_Click);



































































        this.lefttext.Dock = System.Windows.Forms.DockStyle.Top;
		this.lefttext.Font = new System.Drawing.Font("Calibri", 10f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lefttext.Location = new System.Drawing.Point(0, 156);
		this.lefttext.Name = "lefttext";
		this.lefttext.Size = new System.Drawing.Size(764, 28);
		this.lefttext.TabIndex = 59;
		this.lefttext.Text = "-> left : 0";
		this.finishedtext.Dock = System.Windows.Forms.DockStyle.Top;
		this.finishedtext.Font = new System.Drawing.Font("Calibri", 10f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.finishedtext.Location = new System.Drawing.Point(0, 128);
		this.finishedtext.Name = "finishedtext";
		this.finishedtext.Size = new System.Drawing.Size(764, 28);
		this.finishedtext.TabIndex = 58;
		this.finishedtext.Text = "-> Finished : 0";
		this.totaltext.Dock = System.Windows.Forms.DockStyle.Top;
		this.totaltext.Font = new System.Drawing.Font("Calibri", 10f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.totaltext.Location = new System.Drawing.Point(0, 100);
		this.totaltext.Name = "totaltext";
		this.totaltext.Size = new System.Drawing.Size(764, 28);
		this.totaltext.TabIndex = 56;
		this.totaltext.Text = "-> Total : 0";
		this.statustext.Dock = System.Windows.Forms.DockStyle.Top;
		this.statustext.Font = new System.Drawing.Font("Calibri", 10f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.statustext.Location = new System.Drawing.Point(0, 72);
		this.statustext.Name = "statustext";
		this.statustext.Size = new System.Drawing.Size(764, 28);
		this.statustext.TabIndex = 57;
		this.statustext.Text = "-> Status : Starting";
		this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label1.Font = new System.Drawing.Font("Calibri", 10f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(0, 44);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(764, 28);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "-> Downloading Client Snaps";
		this.Bbar.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Bbar.FillColor = System.Drawing.Color.Black;
		this.Bbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.Bbar.ForeColor = System.Drawing.Color.Red;
		this.Bbar.Location = new System.Drawing.Point(0, 200);
		this.Bbar.MinimumSize = new System.Drawing.Size(70, 23);
		this.Bbar.Name = "Bbar";
		this.Bbar.RectColor = System.Drawing.Color.Red;
		this.Bbar.Size = new System.Drawing.Size(764, 23);
		this.Bbar.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Bbar.StyleCustomMode = true;
		this.Bbar.TabIndex = 54;
		this.Bbar.Text = "0.0%";
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon1);
		this.Panel1.Controls.Add(this.infotext);
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon12);
		this.Panel1.Controls.Add(this.clipic);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(764, 44);
		this.Panel1.TabIndex = 55;
		this.DrakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon1.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIButtonIcon1.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon1.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon1.Font = new System.Drawing.Font("Calibri", 9f);
		this.DrakeUIButtonIcon1.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon1.Location = new System.Drawing.Point(704, 0);
		this.DrakeUIButtonIcon1.Margin = new System.Windows.Forms.Padding(4);
		this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
		this.DrakeUIButtonIcon1.RectColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon1.RectHoverColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon1.RectPressColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon1.RectSelectedColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon1.Size = new System.Drawing.Size(30, 44);
		this.DrakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon1.StyleCustomMode = true;
		this.DrakeUIButtonIcon1.Symbol = 61564;
		this.DrakeUIButtonIcon1.SymbolSize = 25;
		this.DrakeUIButtonIcon1.TabIndex = 51;
		this.infotext.Cursor = System.Windows.Forms.Cursors.Hand;
		this.infotext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.infotext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.infotext.Font = new System.Drawing.Font("Calibri", 10f, System.Drawing.FontStyle.Bold);
		this.infotext.Location = new System.Drawing.Point(53, 0);
		this.infotext.Name = "infotext";
		this.infotext.Size = new System.Drawing.Size(681, 44);
		this.infotext.TabIndex = 49;
		this.infotext.Text = "Name :      IP:";
		this.infotext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.DrakeUIButtonIcon12.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon12.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIButtonIcon12.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon12.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon12.Font = new System.Drawing.Font("Calibri", 9f);
		this.DrakeUIButtonIcon12.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon12.Location = new System.Drawing.Point(734, 0);
		this.DrakeUIButtonIcon12.Margin = new System.Windows.Forms.Padding(4);
		this.DrakeUIButtonIcon12.Name = "DrakeUIButtonIcon12";
		this.DrakeUIButtonIcon12.RectColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon12.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon12.RectHoverColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon12.RectPressColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon12.RectSelectedColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon12.Size = new System.Drawing.Size(30, 44);
		this.DrakeUIButtonIcon12.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon12.StyleCustomMode = true;
		this.DrakeUIButtonIcon12.Symbol = 61527;
		this.DrakeUIButtonIcon12.SymbolSize = 25;
		this.DrakeUIButtonIcon12.TabIndex = 50;
		this.clipic.Dock = System.Windows.Forms.DockStyle.Left;
		this.clipic.Location = new System.Drawing.Point(0, 0);
		this.clipic.Name = "clipic";
		this.clipic.Size = new System.Drawing.Size(53, 44);
		this.clipic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.clipic.TabIndex = 0;
		this.clipic.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.ClientSize = new System.Drawing.Size(764, 223);
		base.Controls.Add(this.lefttext);
		base.Controls.Add(this.finishedtext);
		base.Controls.Add(this.totaltext);
		base.Controls.Add(this.statustext);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.Bbar);
		this.ForeColor = System.Drawing.Color.White;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "snapsdownloader";
		base.ShowIcon = false;
		this.Text = "Downloader";
		base.TopMost = true;
		this.Panel1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.clipic).EndInit();
		base.ResumeLayout(false);
	}

	public snapsdownloader()
	{
		base.Load += Snapsdownloader_Load;
		imageCounter = 0;
		totalImages = 0;
		Downloadfolder = "";
		InitializeComponent();
	}

	private void Snapsdownloader_Load(object sender, EventArgs e)
	{
		base.Visible = true;
		base.Location = checked(new Point(Screen.PrimaryScreen.WorkingArea.Width - base.Width, Screen.PrimaryScreen.WorkingArea.Height - base.Height));
	}

	public void UpdateProgressBar()
	{
		if (base.InvokeRequired)
		{
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				UpdateProgressBar();
			}));
			return;
		}
		checked
		{
			int value = (int)Math.Round((double)imageCounter / (double)totalImages * 100.0);
			Bbar.Value = value;
			finishedtext.Text = "-> Finished: " + imageCounter;
			lefttext.Text = "-> Left: " + (totalImages - imageCounter);
			if (Bbar.Value == Bbar.Maximum)
				statustext.Text = "-> Status : Done.";
			else
				statustext.Text = "-> Status : Downloading...";
		}
	}

	private void DrakeUIButtonIcon12_Click(object sender, EventArgs e)
	{
		if (Bbar.Value == Bbar.Maximum || Codes.MyMsgBox("Alert", "Exit without finish download ?", useno: true, Resources.information48px))
			Close();
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (Directory.Exists(Downloadfolder))
			Process.Start(Downloadfolder);
	}
}
