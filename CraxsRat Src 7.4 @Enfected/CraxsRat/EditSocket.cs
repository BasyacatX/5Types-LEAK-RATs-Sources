using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class EditSocket : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PanelBOX")]
	private Panel _PanelBOX;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnUp")]
	private Button _btnUp;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnDown")]
	private Button _btnDown;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b_Add")]
	private Button _b_Add;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b_del")]
	private Button _b_del;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OKY")]
	private Button _OKY;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private Timer _TOpacity;

	private List<Rectangle> RectInputText0;

	internal Panel PanelBOX
	;

	internal Button btnUp
	;


	internal Button btnDown
	;

	[field: AccessedThroughProperty("T0")]
	internal Label T0
        ;

    [field: AccessedThroughProperty("Label2")]
	internal Label Label2
        ;

    [field: AccessedThroughProperty("Label1")]
	internal Label Label1
        ;

	internal Button b_Add
	;

	internal Button b_del
	;

	[field: AccessedThroughProperty("DGV0")]
	internal DataGridView DGV0
    ;

    [field: AccessedThroughProperty("Column2")]
	internal DataGridViewTextBoxColumn Column2
    ;

    [field: AccessedThroughProperty("TextIP")]
	internal TextBox TextIP
    ;
	internal Button OKY
	;

	[field: AccessedThroughProperty("po")]
	internal NumericUpDown po
    ;

	internal Timer TOpacity
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
		this.PanelBOX = new System.Windows.Forms.Panel();
		this.OKY = new System.Windows.Forms.Button();
		this.btnUp = new System.Windows.Forms.Button();
		this.btnDown = new System.Windows.Forms.Button();
		this.T0 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.b_Add = new System.Windows.Forms.Button();
		this.b_del = new System.Windows.Forms.Button();
		this.DGV0 = new System.Windows.Forms.DataGridView();
		this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.po = new System.Windows.Forms.NumericUpDown();
		this.TextIP = new System.Windows.Forms.TextBox();
		this.TOpacity = new System.Windows.Forms.Timer(this.components);
		this.PanelBOX.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.po).BeginInit();
		base.SuspendLayout();


        PanelBOX.Paint += new PaintEventHandler(PanelBOX_Paint);
        btnUp.Click += new EventHandler(btnUp_Click);
        btnDown.Click += new EventHandler(btnDown_Click);
        b_Add.Click += new EventHandler(b_Add_Click);
        b_del.Click += new EventHandler(b_del_Click);
        OKY.Click += new EventHandler(OKY_Click);
        TOpacity.Tick += new EventHandler(TOpacity_Tick);






















































        this.PanelBOX.Controls.Add(this.OKY);
		this.PanelBOX.Controls.Add(this.btnUp);
		this.PanelBOX.Controls.Add(this.btnDown);
		this.PanelBOX.Controls.Add(this.T0);
		this.PanelBOX.Controls.Add(this.Label2);
		this.PanelBOX.Controls.Add(this.Label1);
		this.PanelBOX.Controls.Add(this.b_Add);
		this.PanelBOX.Controls.Add(this.b_del);
		this.PanelBOX.Controls.Add(this.DGV0);
		this.PanelBOX.Controls.Add(this.po);
		this.PanelBOX.Controls.Add(this.TextIP);
		this.PanelBOX.Dock = System.Windows.Forms.DockStyle.Fill;
		this.PanelBOX.Location = new System.Drawing.Point(0, 0);
		this.PanelBOX.Name = "PanelBOX";
		this.PanelBOX.Size = new System.Drawing.Size(269, 362);
		this.PanelBOX.TabIndex = 11;
		this.OKY.BackColor = System.Drawing.Color.FromArgb(190, 190, 190);
		this.OKY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.OKY.ForeColor = System.Drawing.Color.Black;
		this.OKY.Location = new System.Drawing.Point(185, 299);
		this.OKY.Name = "OKY";
		this.OKY.Size = new System.Drawing.Size(67, 23);
		this.OKY.TabIndex = 14;
		this.OKY.Text = "OK";
		this.OKY.UseVisualStyleBackColor = false;
		this.btnUp.BackColor = System.Drawing.Color.FromArgb(190, 190, 190);
		this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnUp.ForeColor = System.Drawing.Color.Black;
		this.btnUp.Location = new System.Drawing.Point(185, 241);
		this.btnUp.Name = "btnUp";
		this.btnUp.Size = new System.Drawing.Size(67, 23);
		this.btnUp.TabIndex = 14;
		this.btnUp.Text = "up";
		this.btnUp.UseVisualStyleBackColor = false;
		this.btnDown.BackColor = System.Drawing.Color.FromArgb(190, 190, 190);
		this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDown.ForeColor = System.Drawing.Color.Black;
		this.btnDown.Location = new System.Drawing.Point(185, 270);
		this.btnDown.Name = "btnDown";
		this.btnDown.Size = new System.Drawing.Size(67, 23);
		this.btnDown.TabIndex = 13;
		this.btnDown.Text = "down";
		this.btnDown.UseVisualStyleBackColor = false;
		this.T0.AutoSize = true;
		this.T0.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
		this.T0.Location = new System.Drawing.Point(-1, 0);
		this.T0.Name = "T0";
		this.T0.Size = new System.Drawing.Size(97, 13);
		this.T0.TabIndex = 12;
		this.T0.Text = "[--- connection ---]";
		this.Label2.AutoSize = true;
		this.Label2.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
		this.Label2.Location = new System.Drawing.Point(182, 75);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(27, 13);
		this.Label2.TabIndex = 11;
		this.Label2.Text = "port";
		this.Label1.AutoSize = true;
		this.Label1.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
		this.Label1.Location = new System.Drawing.Point(0, 25);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(81, 13);
		this.Label1.TabIndex = 10;
		this.Label1.Text = "dynamic DNS/ip";
		this.b_Add.BackColor = System.Drawing.Color.FromArgb(190, 190, 190);
		this.b_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.b_Add.ForeColor = System.Drawing.Color.Black;
		this.b_Add.Location = new System.Drawing.Point(185, 130);
		this.b_Add.Name = "b_Add";
		this.b_Add.Size = new System.Drawing.Size(67, 23);
		this.b_Add.TabIndex = 7;
		this.b_Add.Text = "Add";
		this.b_Add.UseVisualStyleBackColor = false;
		this.b_del.BackColor = System.Drawing.Color.FromArgb(190, 190, 190);
		this.b_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.b_del.ForeColor = System.Drawing.Color.Black;
		this.b_del.Location = new System.Drawing.Point(185, 159);
		this.b_del.Name = "b_del";
		this.b_del.Size = new System.Drawing.Size(67, 23);
		this.b_del.TabIndex = 8;
		this.b_del.Text = "DEL";
		this.b_del.UseVisualStyleBackColor = false;
		this.DGV0.AllowUserToAddRows = false;
		this.DGV0.AllowUserToDeleteRows = false;
		this.DGV0.AllowUserToResizeColumns = false;
		this.DGV0.AllowUserToResizeRows = false;
		this.DGV0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
		this.DGV0.Columns.AddRange(this.Column2);
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(190, 190, 190);
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV0.DefaultCellStyle = dataGridViewCellStyle2;
		this.DGV0.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGV0.EnableHeadersVisualStyles = false;
		this.DGV0.GridColor = System.Drawing.Color.FromArgb(42, 42, 42);
		this.DGV0.Location = new System.Drawing.Point(2, 66);
		this.DGV0.Name = "DGV0";
		this.DGV0.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		this.DGV0.RowHeadersVisible = false;
		this.DGV0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV0.Size = new System.Drawing.Size(174, 240);
		this.DGV0.TabIndex = 5;
		this.Column2.HeaderText = "DNS/ip:port";
		this.Column2.Name = "Column2";
		this.po.BackColor = System.Drawing.Color.Black;
		this.po.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.po.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
		this.po.Location = new System.Drawing.Point(185, 91);
		this.po.Maximum = new decimal(new int[4] { 65535, 0, 0, 0 });
		this.po.Name = "po";
		this.po.Size = new System.Drawing.Size(67, 16);
		this.po.TabIndex = 9;
		this.po.Value = new decimal(new int[4] { 7744, 0, 0, 0 });
		this.TextIP.BackColor = System.Drawing.Color.Black;
		this.TextIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.TextIP.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
		this.TextIP.Location = new System.Drawing.Point(3, 44);
		this.TextIP.Name = "TextIP";
		this.TextIP.Size = new System.Drawing.Size(173, 13);
		this.TextIP.TabIndex = 0;
		this.TextIP.Text = "127.0.0.1";
		this.TOpacity.Interval = 1;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.ClientSize = new System.Drawing.Size(269, 362);
		base.Controls.Add(this.PanelBOX);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.Name = "EditSocket";
		base.Opacity = 0.0;
		base.ShowInTaskbar = false;
		this.Text = "EditSocket";
		this.PanelBOX.ResumeLayout(false);
		this.PanelBOX.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
		((System.ComponentModel.ISupportInitialize)this.po).EndInit();
		base.ResumeLayout(false);
	}

	public EditSocket()
	{
		base.Load += EditSocket_Load;
		RectInputText0 = new List<Rectangle>();
		InitializeComponent();
		Font = reso.f;
	}

	private void SpyStyle()
	{
		po.BackColor = SpySettings.DefaultColor_Background;
		po.ForeColor = SpySettings.DefaultColor_Foreground;
		checked
		{
			RectInputText0.Add(new Rectangle(po.Location.X - 1, po.Location.Y - 1, po.Width + 1, po.Height + 1));
			foreach (DataGridView item in PanelBOX.Controls.OfType<DataGridView>())
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
			foreach (Label item2 in PanelBOX.Controls.OfType<Label>())
			{
				item2.ForeColor = SpySettings.DefaultColor_Foreground;
			}
			foreach (Button item3 in PanelBOX.Controls.OfType<Button>())
			{
				item3.BackColor = SpySettings.DefaultColor_Foreground;
				item3.ForeColor = SpySettings.DefaultColor_Background;
			}
			foreach (TextBox item4 in PanelBOX.Controls.OfType<TextBox>())
			{
				item4.BackColor = SpySettings.DefaultColor_Background;
				item4.ForeColor = SpySettings.DefaultColor_Foreground;
				RectInputText0.Add(new Rectangle(item4.Location.X - 1, item4.Location.Y - 1, item4.Width + 1, item4.Height + 1));
			}
			foreach (Panel item5 in base.Controls.OfType<Panel>())
			{
				item5.BackColor = SpySettings.DefaultColor_Background;
			}
			Refresh();
		}
	}

	private void TOpacity_Tick(object sender, EventArgs e)
	{
		if (base.Opacity != 1.0)
			base.Opacity += 0.1;
		else
			TOpacity.Enabled = false;
	}

	private void EditSocket_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\12.ico");
		SpyStyle();
		TextIP.Text = Codes.GetIPAddress();
		TOpacity.Interval = SpySettings.T_Interval;
		TOpacity.Enabled = true;
	}

	private void b_Add_Click(object sender, EventArgs e)
	{
		DGV0.Rows.Add(TextIP.Text + ":" + Conversions.ToString(po.Value));
	}

	private void b_del_Click(object sender, EventArgs e)
	{
		checked
		{
			if (DGV0.SelectedRows.Count > 0)
			{
				int num = DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					DGV0.Rows.RemoveAt(DGV0.SelectedRows[i].Index);
				}
			}
		}
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		Rowinsert(isDown: false);
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		Rowinsert(isDown: true);
	}

	private void Rowinsert(bool isDown)
	{
		if (!((DGV0.SelectedRows.Count == 1) & (DGV0.Rows.Count != 1)))
			return;
		checked
		{
			int num = DGV0.SelectedRows.Count - 1;
			for (int i = num; i >= 0; i += -1)
			{
				string text = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[0].Value);
				if (isDown)
				{
					DGV0.Rows.RemoveAt(DGV0.SelectedRows[i].Index);
					DGV0.Rows.Insert(DGV0.SelectedRows[i].Index + 1, text);
					DGV0.CurrentCell = DGV0.Rows[DGV0.SelectedRows[i].Index + 1].Cells[0];
				}
				else if (DGV0.SelectedRows[i].Index != 0)
				{
					DGV0.Rows.Insert(DGV0.SelectedRows[i].Index - 1, text);
					DGV0.CurrentCell = DGV0.Rows[DGV0.SelectedRows[i].Index - 1].Cells[0];
					DGV0.Rows.RemoveAt(DGV0.SelectedRows[i].Index + 1);
					DGV0.CurrentCell = DGV0.Rows[DGV0.SelectedRows[i].Index - 1].Cells[0];
				}
			}
		}
	}

	private void OKY_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.OK;
	}

	private void PanelBOX_Paint(object sender, PaintEventArgs e)
	{
		e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
		Color defaultColor_Foreground = SpySettings.DefaultColor_Foreground;
		if (RectInputText0.Count <= 0)
			return;
		foreach (Rectangle item in RectInputText0)
		{
			if (item.Width > 0)
				e.Graphics.FillRectangle(new SolidBrush(defaultColor_Foreground), item);
		}
	}
}
