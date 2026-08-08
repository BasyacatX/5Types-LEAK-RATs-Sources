using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Eagle_Spy.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class comptableform : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("loginbtn")]
	private DrakeUIButtonIcon _loginbtn;

	private string armsg;

	private string cnmsg;

	[field: AccessedThroughProperty("Panel1")]
	internal Panel Panel1
    ;
    private Label label5;
    private Label label3;
    private Label label2;
    private Label label1;
    internal DrakeUIButtonIcon loginbtn
	;

	public comptableform()
	{
		base.Load += Comptableform_Load;
		armsg = "اكتشف EagleSpy نظام تشغيل Windows غير متوافق ، إذا واجهت مشكلة في تسجيل الدخول ، فحاول الانتقال إلى Windows 10";
		cnmsg = "EagleSpy检测到不兼容的Windows操作系统，如果您遇到登录问题，请尝试转移到Windows 10";
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
            this.loginbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.loginbtn);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel1.Location = new System.Drawing.Point(0, 493);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(484, 63);
            this.Panel1.TabIndex = 0;
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.Transparent;
            this.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginbtn.FillColor = System.Drawing.Color.Transparent;
            this.loginbtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.loginbtn.FillPressColor = System.Drawing.Color.Black;
            this.loginbtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginbtn.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginbtn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginbtn.Location = new System.Drawing.Point(0, 3);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Radius = 10;
            this.loginbtn.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.loginbtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.loginbtn.RectHoverColor = System.Drawing.Color.White;
            this.loginbtn.RectPressColor = System.Drawing.Color.White;
            this.loginbtn.RectSelectedColor = System.Drawing.Color.White;
            this.loginbtn.Size = new System.Drawing.Size(484, 60);
            this.loginbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.loginbtn.SymbolSize = 0;
            this.loginbtn.TabIndex = 29;
            this.loginbtn.Text = "OK";
            this.loginbtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(133, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Terms && Conditions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(75, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 100);
            this.label3.TabIndex = 28;
            this.label3.Text = "3. you are the only responsible for any \r\nillegal usage of this software   \r\nowne" +
    "r is not responsible for any \r\ndamage caused by this software.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(75, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 125);
            this.label2.TabIndex = 27;
            this.label2.Text = "2.  You are granted a non-transferable\r\n license for intended use only. \r\nAny for" +
    "m of unauthorized \r\ndistribution or modification is\r\n against the terms of use.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(75, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 100);
            this.label1.TabIndex = 26;
            this.label1.Text = "1.  keep your license key secure, \r\nand ensure that your use of \r\nthe software co" +
    "mplies with all\r\n applicable laws and regulations.";
            // 
            // comptableform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 556);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(484, 556);
            this.MinimumSize = new System.Drawing.Size(484, 556);
            this.Name = "comptableform";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "comptableform";
            this.TopMost = true;
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

	}

	private void Loginbtn_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Comptableform_Load(object sender, EventArgs e)
	{
		
	}
}
