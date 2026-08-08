using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Eagle_Spy.sockets;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class Download : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TimeFinish")]
	private Timer _TimeFinish;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private Timer _TOpacity;

	public TcpClient Client;

	public Client classClient;

	public FileStream FileStream;

	public long _stream;

	public string xName;

	public long TotalSize;

	public TimeSpan elapsed_time;

	public DateTime start_time;

	public DateTime stop_time;

	public string DownFolder;

	public string Title;

	[field: AccessedThroughProperty("ProgressBar1")]
	internal ProgressBar ProgressBar1
    ;

    [field: AccessedThroughProperty("DGV0")]
	internal DataGridView DGV0
	;

	internal Timer TimeFinish
	;

	[field: AccessedThroughProperty("Column1")]
	internal DataGridViewTextBoxColumn Column1
    ;

    [field: AccessedThroughProperty("Column6")]
	internal DataGridViewTextBoxColumn Column6
   ;

	internal Timer TOpacity
	;

	public Download()
	{
		base.Load += Download_Load;
		base.Closing += Download_Closing;
		FileStream = null;
		_stream = 0L;
		xName = "null";
		Title = "null";
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
		this.DGV0 = new System.Windows.Forms.DataGridView();
		this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.TimeFinish = new System.Windows.Forms.Timer(this.components);
		this.TOpacity = new System.Windows.Forms.Timer(this.components);
		((System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
		base.SuspendLayout();

        TimeFinish.Tick += new EventHandler(TimeFinish_Tick);
        TOpacity.Tick += new EventHandler(TOpacity_Tick);











        this.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.ProgressBar1.Location = new System.Drawing.Point(0, 110);
		this.ProgressBar1.Name = "ProgressBar1";
		this.ProgressBar1.Size = new System.Drawing.Size(343, 18);
		this.ProgressBar1.TabIndex = 0;
		this.DGV0.AllowUserToAddRows = false;
		this.DGV0.AllowUserToDeleteRows = false;
		this.DGV0.AllowUserToResizeColumns = false;
		this.DGV0.AllowUserToResizeRows = false;
		this.DGV0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
		this.DGV0.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV0.BackgroundColor = System.Drawing.Color.Black;
		this.DGV0.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV0.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV0.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.DGV0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGV0.Columns.AddRange(this.Column1, this.Column6);
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(190, 190, 190);
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV0.DefaultCellStyle = dataGridViewCellStyle2;
		this.DGV0.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGV0.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGV0.EnableHeadersVisualStyles = false;
		this.DGV0.GridColor = System.Drawing.Color.FromArgb(42, 42, 42);
		this.DGV0.Location = new System.Drawing.Point(0, 0);
		this.DGV0.Name = "DGV0";
		this.DGV0.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		this.DGV0.RowHeadersVisible = false;
		this.DGV0.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.DGV0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV0.Size = new System.Drawing.Size(343, 110);
		this.DGV0.TabIndex = 4;
		this.Column1.HeaderText = "info";
		this.Column1.Name = "Column1";
		this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.Column1.Width = 32;
		this.Column6.HeaderText = "  ";
		this.Column6.Name = "Column6";
		this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.Column6.Width = 17;
		this.TOpacity.Interval = 1;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(343, 128);
		base.Controls.Add(this.DGV0);
		base.Controls.Add(this.ProgressBar1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "Download";
		base.Opacity = 0.0;
		this.Text = "Download";
		((System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
		base.ResumeLayout(false);
	}

	private void SpyStyle()
	{
		foreach (DataGridView item in base.Controls.OfType<DataGridView>())
		{
			item.BackgroundColor = SpySettings.DefaultColor_Background;
			item.BackColor = SpySettings.DefaultColor_Background;
			item.ColumnHeadersDefaultCellStyle.BackColor = SpySettings.DefaultColor_Background;
			item.DefaultCellStyle.BackColor = SpySettings.DefaultColor_Background;
			item.DefaultCellStyle.SelectionForeColor = SpySettings.DefaultColor_Background;
			item.DefaultCellStyle.ForeColor = SpySettings.DefaultColor_Foreground;
			item.DefaultCellStyle.SelectionBackColor = SpySettings.DefaultColor_Foreground;
			item.ColumnHeadersDefaultCellStyle.ForeColor = SpySettings.DefaultColor_Foreground;
		}
	}

	private void TOpacity_Tick(object sender, EventArgs e)
	{
		if (base.Opacity != 1.0)
			base.Opacity += 0.1;
		else
			TOpacity.Enabled = false;
	}

	private void Download_Load(object sender, EventArgs e)
	{
		base.Location = checked(new Point(Screen.PrimaryScreen.WorkingArea.Width - base.Width, Screen.PrimaryScreen.WorkingArea.Height - base.Height));
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\7.ico");
		SpyStyle();
		DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f;
		DGV0.DefaultCellStyle.Font = reso.f;
		TimeFinish.Interval = 1000;
		TimeFinish.Enabled = true;
		Text = Title;
		TOpacity.Interval = SpySettings.T_Interval;
		TOpacity.Enabled = true;
	}

	private void Download_Closing(object sender, CancelEventArgs e)
	{
		TimeFinish.Enabled = false;
		if (classClient != null)
		{
			classClient.qit = true;
			classClient.Close(Client);
		}
		if (FileStream != null)
		{
			FileStream.Dispose();
			FileStream.Close();
		}
	}

	private void TimeFinish_Tick(object sender, EventArgs e)
	{
		if (DGV0.Rows.Count > 0 && _stream <= TotalSize && _stream > 0L)
		{
			stop_time = DateAndTime.Now;
			elapsed_time = stop_time.Subtract(start_time);
			long value = checked((long)Math.Round((double)(TotalSize - _stream) * elapsed_time.TotalSeconds / (double)_stream));
			string text = Codes.ToTime(value);
			if (!text.Equals("0:0:0"))
			{
				DateTime now = DateTime.Now;
				DateTime dateTime = Convert.ToDateTime(text);
				now = now.AddHours(dateTime.Hour).AddMinutes(dateTime.Minute).AddSeconds(dateTime.Second);
				DGV0.Rows[3].Cells[1].Value = $"[{text}]";
			}
		}
	}
}
