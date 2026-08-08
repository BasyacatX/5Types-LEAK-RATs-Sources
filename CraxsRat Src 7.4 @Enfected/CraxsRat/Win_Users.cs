using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Eagle_Spy.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class Win_Users : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV0")]
	private DataGridView _DGV0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private Timer _TOpacity;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OpenToolStripMenuItem")]
	private ToolStripMenuItem _OpenToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DeleteToolStripMenuItem")]
	private ToolStripMenuItem _DeleteToolStripMenuItem;

	internal DataGridView DGV0
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

	internal Timer TOpacity
	;

	[field: AccessedThroughProperty("ctxz")]
	internal ContextMenuStrip ctxz
	;

	internal ToolStripMenuItem OpenToolStripMenuItem
	;

	internal ToolStripMenuItem DeleteToolStripMenuItem
	;

	public Win_Users()
	{
		base.Load += Win_Users_Load;
		base.Closing += Win_Users_Closing;
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
		this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
		this.TOpacity = new System.Windows.Forms.Timer(this.components);
		this.ctxz = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		((System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
		this.ctxz.SuspendLayout();
		base.SuspendLayout();


        DGV0.CellContentClick += new DataGridViewCellEventHandler(DGV0_CellContentClick);
        DGV0.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(DGV0_CellMouseDoubleClick);
        TOpacity.Tick += new EventHandler(TOpacity_Tick);
        OpenToolStripMenuItem.Click += new EventHandler(OpenToolStripMenuItem_Click);
        DeleteToolStripMenuItem.Click += new EventHandler(DeleteToolStripMenuItem_Click);
































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
		this.DGV0.Columns.AddRange(this.Column1, this.Column6, this.Column3, this.Column2);
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
		this.DGV0.Size = new System.Drawing.Size(393, 338);
		this.DGV0.TabIndex = 4;
		this.Column1.HeaderText = "Name";
		this.Column1.Name = "Column1";
		this.Column1.Width = 61;
		this.Column6.HeaderText = "IP";
		this.Column6.Name = "Column6";
		this.Column6.Width = 40;
		this.Column3.HeaderText = "UUID";
		this.Column3.Name = "Column3";
		this.Column3.Width = 54;
		this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
		this.Column2.FillWeight = 1f;
		this.Column2.HeaderText = "";
		this.Column2.MinimumWidth = 2;
		this.Column2.Name = "Column2";
		this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
		this.Column2.Width = 2;
		this.TOpacity.Interval = 1;
		this.ctxz.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.OpenToolStripMenuItem, this.DeleteToolStripMenuItem });
		this.ctxz.Name = "ctxz";
		this.ctxz.ShowImageMargin = false;
		this.ctxz.Size = new System.Drawing.Size(156, 70);
		this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
		this.OpenToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
		this.OpenToolStripMenuItem.Text = "Open";
		this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
		this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
		this.DeleteToolStripMenuItem.Text = "Delete";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(393, 338);
		base.Controls.Add(this.DGV0);
		base.Name = "Win_Users";
		base.Opacity = 0.0;
		this.Text = "Win_Users";
		((System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
		this.ctxz.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void Win_Users_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\1.ico");
		DGV0.ContextMenuStrip = ctxz;
		DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f;
		DGV0.DefaultCellStyle.Font = reso.f;
		SpyStyle();
		MYTEXT();
		TOpacity.Interval = SpySettings.T_Interval;
		TOpacity.Enabled = true;
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

	private void Win_Users_Closing(object sender, CancelEventArgs e)
	{
		MyProject.Forms.EagleSpyMain.WU = null;
	}

	private void DGV0_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	public void MYTEXT()
	{
		Text = "Users (" + Conversions.ToString(DGV0.Rows.Count) + ")";
	}

	private void DGV0_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		if (DGV0.Rows.Count > 0 && e.RowIndex != -1)
		{
			string text = Conversions.ToString(DGV0.Rows[e.RowIndex].Cells[2].Value);
			string text2 = reso.res_Path + "\\Users\\" + text;
			if (Directory.Exists(text2))
			{
				Process.Start(text2);
				return;
			}
			DGV0.Rows.RemoveAt(e.RowIndex);
			MYTEXT();
		}
	}

	private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
			return;
		checked
		{
			int num = DGV0.SelectedRows.Count - 1;
			for (int i = num; i >= 0; i += -1)
			{
				string text = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[2].Value);
				string text2 = reso.res_Path + "\\Users\\" + text;
				if (Directory.Exists(text2))
				{
					Process.Start(text2);
					continue;
				}
				DGV0.Rows.RemoveAt(DGV0.SelectedRows[i].Index);
				MYTEXT();
			}
		}
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
				string text = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[2].Value);
				string path = reso.res_Path + "\\Users\\" + text;
				DGV0.Rows.RemoveAt(DGV0.SelectedRows[i].Index);
				MYTEXT();
				if (Directory.Exists(path))
					try
					{
						Directory.Delete(path, recursive: true);
					}
					catch (Exception)
					{
						//ProjectData.SetProjectError(projectError);
						//////CraxsAlert.Showinformation("Sorry");
					}
			}
		}
	}
}
