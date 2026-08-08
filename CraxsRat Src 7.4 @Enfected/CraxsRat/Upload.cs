using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
public class Upload : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TimeFinish")]
	private System.Windows.Forms.Timer _TimeFinish;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Progr")]
	private System.Windows.Forms.Timer _Progr;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private System.Windows.Forms.Timer _TOpacity;

	public TcpClient Client;

	public Client classClient;

	public FileStream FileStream;

	public long Upstream;

	public long _stream;

	public long TotalSize;

	public TimeSpan elapsed_time;

	public DateTime start_time;

	public DateTime stop_time;

	public string[] SPL;

	public string Title;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Bgworker")]
	private BackgroundWorker _Bgworker;

	[field: AccessedThroughProperty("DGV0")]
	internal DataGridView DGV0
    ;

    [field: AccessedThroughProperty("ProgressBar1")]
	internal ProgressBar ProgressBar1
	;

	internal System.Windows.Forms.Timer TimeFinish
	;


	internal System.Windows.Forms.Timer Progr
;

	[field: AccessedThroughProperty("Column1")]
	internal DataGridViewTextBoxColumn Column1
    ;


    [field: AccessedThroughProperty("Column6")]
	internal DataGridViewTextBoxColumn Column6
    ;


	internal System.Windows.Forms.Timer TOpacity
	;

	internal BackgroundWorker Bgworker
	;

	public Upload()
	{
		base.Load += Upload_Load;
		base.Closing += Upload_Closing;
		FileStream = null;
		Upstream = 0L;
		_stream = 0L;
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
		this.DGV0 = new System.Windows.Forms.DataGridView();
		this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
		this.TimeFinish = new System.Windows.Forms.Timer(this.components);
		this.Progr = new System.Windows.Forms.Timer(this.components);
		this.TOpacity = new System.Windows.Forms.Timer(this.components);
		((System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
		base.SuspendLayout();




        TimeFinish.Tick += new EventHandler(TimeFinish_Tick);
        Progr.Tick += new EventHandler(Progr_Tick);
        TOpacity.Tick += new EventHandler(TOpacity_Tick);



        //DoWorkEventHandler value5 = worker_DoWork;
        //     Bgworker.DoWork += value5;




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
		this.DGV0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV0.Size = new System.Drawing.Size(537, 118);
		this.DGV0.TabIndex = 6;
		this.Column1.HeaderText = "info";
		this.Column1.Name = "Column1";
		this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.Column1.Width = 32;
		this.Column6.HeaderText = "  ";
		this.Column6.Name = "Column6";
		this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.Column6.Width = 15;
		this.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.ProgressBar1.Location = new System.Drawing.Point(0, 118);
		this.ProgressBar1.Name = "ProgressBar1";
		this.ProgressBar1.Size = new System.Drawing.Size(537, 10);
		this.ProgressBar1.TabIndex = 5;
		this.TOpacity.Interval = 1;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(537, 128);
		base.Controls.Add(this.DGV0);
		base.Controls.Add(this.ProgressBar1);
		base.Name = "Upload";
		base.Opacity = 0.0;
		this.Text = "Upload";
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

	private void Upload_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\16.ico");
		SpyStyle();
		DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f;
		DGV0.DefaultCellStyle.Font = reso.f;
		TimeFinish.Interval = 100;
		TimeFinish.Enabled = true;
		if ((FileStream == null) & (Upstream == 0L))
			FileStream = new FileStream(SPL[3], FileMode.Open, FileAccess.Read);
		if (Bgworker == null)
			Bgworker = new BackgroundWorker();
		if (!Bgworker.IsBusy)
			Bgworker.RunWorkerAsync();
		else
		{
			if (FileStream != null)
			{
				FileStream.Dispose();
				FileStream.Close();
			}
			classClient.Close(Client);
			Close();
		}
		Progr.Interval = 10;
		Progr.Enabled = true;
		Text = Title;
		TOpacity.Interval = SpySettings.T_Interval;
		TOpacity.Enabled = true;
	}

	private void worker_DoWork(object sender, DoWorkEventArgs e)
	{
		byte[] array = new byte[4097];
		checked
		{
			if (FileStream != null)
			{
				int num;
				do
				{
					num = FileStream.Read(array, 0, array.Length);
					if (num > 0)
					{
						try
						{
							if (Client.Client.Connected)
							{
								Client.Client.Poll(infoServer.Microseconds, SelectMode.SelectWrite);
								Client.Client.SendBufferSize = array.Length;
								Client.GetStream().Write(array, 0, num);
								_stream += num;
								Upstream += array.Length;
								classClient.MyServer.BytesSent += array.Length;
							}
						}
						catch (Exception)
						{
							//ProjectData.SetProjectError(projectError);
							//////CraxsAlert.Showinformation("Sorry");
							break;
						}
						if (Upstream == Conversions.ToInteger(SPL[1]))
							break;
					}
					Thread.Sleep(1);
				}
				while (num > 0);
			}
			if (FileStream != null)
			{
				FileStream.Dispose();
				FileStream.Close();
			}
		}
	}

	private void Upload_Closing(object sender, CancelEventArgs e)
	{
		TimeFinish.Enabled = false;
		Progr.Enabled = false;
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
		if (Bgworker != null)
			try
			{
				Bgworker.Dispose();
				Bgworker.CancelAsync();
			}
			catch (Exception)
			{
				//ProjectData.SetProjectError(projectError);
				//////CraxsAlert.Showinformation("Sorry");
			}
	}

	private void TimeFinish_Tick(object sender, EventArgs e)
	{
		if (DGV0.Rows.Count <= 0)
			return;
		if (_stream < TotalSize)
		{
			if (_stream > 0L)
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
					DGV0.Rows[4].Cells[1].Value = string.Format("[{0}] [{1}]", text, now.ToString("h:mm:ss"));
				}
			}
		}
		else
			Close();
	}

	private void Progr_Tick(object sender, EventArgs e)
	{
		if (((ulong)_stream > 0uL) | (_stream > ProgressBar1.Maximum))
			ProgressBar1.Value = checked((int)_stream);
	}
}
