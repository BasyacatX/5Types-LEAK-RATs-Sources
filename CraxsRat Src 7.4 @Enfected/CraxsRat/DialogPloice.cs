using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class DialogPloice : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OK_Button")]
	private Button _OK_Button;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Cancel_Button")]
	private Button _Cancel_Button;

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
	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	private string ARTEXT;

	private string ENTEXT;

	private bool IsArab;

	private DateTime StartNow;

	[field: AccessedThroughProperty("TableLayoutPanel1")]
	internal TableLayoutPanel TableLayoutPanel1
	;

	internal Button OK_Button
	;

	internal Button Cancel_Button
	;

	[field: AccessedThroughProperty("MainText")]
	internal TextBox MainText
    ;

	internal Button Button1
	;

	internal Button Button2
	;

	[field: AccessedThroughProperty("Acccheck")]
	internal CheckBox Acccheck
    ;
    private Panel panel1;
    private Label label5;
    private Label label4;
    private Label label6;
    private Label label7;
    private Label label8;
    internal Timer Timer1
	;

	public DialogPloice()
	{
		base.Load += DialogPloice_Load;
		ARTEXT = "انا قرأت ما موجود اعلاه , وموافق على الشروط";
		ENTEXT = "I read all text above, And Accepted All";
		IsArab = false;
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
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.MainText = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Acccheck = new System.Windows.Forms.CheckBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(227, 495);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(205, 37);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Button.Location = new System.Drawing.Point(120, 7);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(67, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // OK_Button
            // 
            this.OK_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.OK_Button.Location = new System.Drawing.Point(0, 476);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(444, 58);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // MainText
            // 
            this.MainText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainText.Location = new System.Drawing.Point(170, 127);
            this.MainText.Multiline = true;
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(34, 27);
            this.MainText.TabIndex = 1;
            this.MainText.Visible = false;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(91, 127);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(50, 32);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "English";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(218, 127);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(76, 32);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "العربية";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Acccheck
            // 
            this.Acccheck.AutoSize = true;
            this.Acccheck.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acccheck.Location = new System.Drawing.Point(12, 274);
            this.Acccheck.Name = "Acccheck";
            this.Acccheck.Size = new System.Drawing.Size(202, 17);
            this.Acccheck.TabIndex = 4;
            this.Acccheck.Text = "I read all text above, And Accepted All";
            this.Acccheck.UseVisualStyleBackColor = true;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.OK_Button);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 534);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(87, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Terms && Conditions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(36, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(378, 100);
            this.label6.TabIndex = 28;
            this.label6.Text = "3. you are the only responsible for any \r\nillegal usage of this software   \r\nowne" +
    "r is not responsible for any \r\ndamage caused by this software.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(35, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(372, 125);
            this.label7.TabIndex = 27;
            this.label7.Text = "2.  You are granted a non-transferable\r\n license for intended use only. \r\nAny for" +
    "m of unauthorized \r\ndistribution or modification is\r\n against the terms of use.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(35, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(319, 100);
            this.label8.TabIndex = 26;
            this.label8.Text = "1.  keep your license key secure, \r\nand ensure that your use of \r\nthe software co" +
    "mplies with all\r\n applicable laws and regulations.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(116, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Terms && Conditions";
            // 
            // DialogPloice
            // 
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(444, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Acccheck);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.MainText);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 573);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 573);
            this.Name = "DialogPloice";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Privacy Policy & Terms of Service";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DialogPloice_Load_1);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

	}

	private void OK_Button_Click(object sender, EventArgs e)
	{
		if (!Acccheck.Checked)
		{
			if (IsArab)
				Interaction.MsgBox("قم بالموافقة على الشروط اولا!");
			else
				Interaction.MsgBox("Accepte Privacy Policy First!");
		}
		else
		{
			base.DialogResult = DialogResult.OK;
			Close();
		}
	}

	private void Cancel_Button_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		Close();
	}

	private void DialogPloice_Load(object sender, EventArgs e)
	{
		StartNow = DateAndTime.Now.AddSeconds(15.0);
		Timer1.Start();
		OK_Button.Enabled = false;
		Cancel_Button.Enabled = false;
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		IsArab = true;
		MainText.Text = "";
		Acccheck.Text = ARTEXT;
		OK_Button.Text = "موافق";
		Cancel_Button.Text = "كلا";
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		IsArab = false;
		MainText.Text = "";
		Acccheck.Text = ENTEXT;
		OK_Button.Text = "OK";
		Cancel_Button.Text = "Cancel";
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (DateTime.Compare(StartNow, DateAndTime.Now) < 0)
		{
			OK_Button.Enabled = true;
			Cancel_Button.Enabled = true;
			Text = " Privacy Policy & Terms of Service";
			Timer1.Stop();
		}
		else
			Text = " Privacy Policy & Terms of Service - " + checked(StartNow.Second - DateAndTime.Now.Second);
	}

    private void DialogPloice_Load_1(object sender, EventArgs e)
    {

    }
}
