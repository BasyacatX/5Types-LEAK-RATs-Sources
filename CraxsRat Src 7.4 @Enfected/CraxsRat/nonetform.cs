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
public class nonetform : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar1")]
	private DrakeUIAvatar _DrakeUIAvatar1;

	internal DrakeUIAvatar DrakeUIAvatar1
	;


	[field: AccessedThroughProperty("Label1")]
	internal Label Label1
    ;

    [field: AccessedThroughProperty("DrakeUIAvatar2")]
	internal DrakeUIAvatar DrakeUIAvatar2
    ;

    public nonetform()
	{
		base.Load += Nonetform_Load;
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
		this.DrakeUIAvatar1 = new DrakeUI.Framework.DrakeUIAvatar();
		this.Label1 = new System.Windows.Forms.Label();
		this.DrakeUIAvatar2 = new DrakeUI.Framework.DrakeUIAvatar();
		base.SuspendLayout();

        DrakeUIAvatar1.Click += new EventHandler(DrakeUIAvatar1_Click);













        this.DrakeUIAvatar1.AvatarSize = 45;
		this.DrakeUIAvatar1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar1.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIAvatar1.FillColor = System.Drawing.Color.Black;
		this.DrakeUIAvatar1.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar1.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIAvatar1.Icon = DrakeUI.Framework.DrakeUIAvatar.UIIcon.Text;
		this.DrakeUIAvatar1.Location = new System.Drawing.Point(494, 0);
		this.DrakeUIAvatar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.DrakeUIAvatar1.Name = "DrakeUIAvatar1";
		this.DrakeUIAvatar1.Size = new System.Drawing.Size(87, 81);
		this.DrakeUIAvatar1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar1.StyleCustomMode = true;
		this.DrakeUIAvatar1.Symbol = 61452;
		this.DrakeUIAvatar1.SymbolSize = 25;
		this.DrakeUIAvatar1.TabIndex = 0;
		this.DrakeUIAvatar1.Text = "OK";
		this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Label1.Font = new System.Drawing.Font("Calibri", 9f, System.Drawing.FontStyle.Bold);
		this.Label1.ForeColor = System.Drawing.Color.White;
		this.Label1.Location = new System.Drawing.Point(95, 0);
		this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(399, 81);
		this.Label1.TabIndex = 1;
		this.Label1.Text = "No internet Connection.\r\n\r\nPlease Check you internet and try again.";
		this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.DrakeUIAvatar2.AvatarSize = 45;
		this.DrakeUIAvatar2.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeUIAvatar2.FillColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIAvatar2.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar2.ForeColor = System.Drawing.Color.Black;
		this.DrakeUIAvatar2.Location = new System.Drawing.Point(0, 0);
		this.DrakeUIAvatar2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.DrakeUIAvatar2.Name = "DrakeUIAvatar2";
		this.DrakeUIAvatar2.Size = new System.Drawing.Size(95, 81);
		this.DrakeUIAvatar2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar2.StyleCustomMode = true;
		this.DrakeUIAvatar2.Symbol = 61553;
		this.DrakeUIAvatar2.SymbolSize = 25;
		this.DrakeUIAvatar2.TabIndex = 2;
		this.DrakeUIAvatar2.Text = "DrakeUIAvatar2";
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.ClientSize = new System.Drawing.Size(581, 81);
		base.ControlBox = false;
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.DrakeUIAvatar2);
		base.Controls.Add(this.DrakeUIAvatar1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		base.Name = "nonetform";
		base.ShowIcon = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "nonetform";
		base.TopMost = true;
		base.ResumeLayout(false);
	}

	private void DrakeUIAvatar1_Click(object sender, EventArgs e)
	{
		Close();
		CraxsStyle();
	}

	public void CraxsStyle()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
				Label1.Text = "No internet Connection.\r\n\r\nPlease Check your internet and try again.";
			else
				Label1.Text = "没有网络连接。\r\n\r\n请检查您的互联网并重试。";
		}
		else
			Label1.Text = "لا يوجد اتصال بالإنترنت.\r\n\r\nيرجى التحقق من الإنترنت الخاص بك وحاول مرة أخرى.";
	}

	private void Nonetform_Load(object sender, EventArgs e)
	{
		base.StartPosition = FormStartPosition.Manual;
		base.Location = new Point(checked(Screen.PrimaryScreen.WorkingArea.Width - base.Width) / 2, 0);
	}
}
