using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eagle_Spy.sockets;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class Report : Form
{
	[CompilerGenerated]
	private sealed class VB_0024StateMachine_17_FadeIn : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal Form _0024VB_0024Local_o;

		internal int _0024VB_0024Local_interval;

		internal Report _0024VB_0024Me;

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
				goto IL_005a;
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
						VB_0024StateMachine_17_FadeIn stateMachine = this;
						reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
						return;
					}
					goto IL_005a;
				}
				_0024VB_0024Local_o.Opacity = 1.0;
				goto end_IL_0007;
				IL_005a:
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

	[CompilerGenerated]
	private sealed class VB_0024StateMachine_18_FadeOut : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal Form _0024VB_0024Local_o;

		internal int _0024VB_0024Local_interval;

		internal Report _0024VB_0024Me;

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
				goto IL_005a;
				IL_0028:
				if (_0024VB_0024Local_o.Opacity > 0.0)
				{
					awaiter = Task.Delay(_0024VB_0024Local_interval).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_0024State = 0;
						_0024A0 = awaiter;
						ref AsyncVoidMethodBuilder reference = ref _0024Builder;
						VB_0024StateMachine_18_FadeOut stateMachine = this;
						reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
						return;
					}
					goto IL_005a;
				}
				_0024VB_0024Local_o.Opacity = 0.0;
				goto end_IL_0007;
				IL_005a:
				awaiter.GetResult();
				awaiter = default(TaskAwaiter);
				(_0024S0 = _0024VB_0024Local_o).Opacity = _0024S0.Opacity - 0.05;
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

	[CompilerGenerated]
	private sealed class VB_0024StateMachine_25_Report_MouseClick : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal object _0024VB_0024Local_sender;

		internal MouseEventArgs _0024VB_0024Local_e;

		internal Report _0024VB_0024Me;

		internal TaskAwaiter<object> _0024A0;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			try
			{
				TaskAwaiter<object> awaiter;
				if (num != 0)
				{
					awaiter = Task.Factory.StartNew([SpecialName] () => _0024VB_0024Me.AllClear(), TaskCreationOptions.None).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_0024State = 0;
						_0024A0 = awaiter;
						ref AsyncVoidMethodBuilder reference = ref _0024Builder;
						VB_0024StateMachine_25_Report_MouseClick stateMachine = this;
						reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
						return;
					}
				}
				else
				{
					num = -1;
					_0024State = -1;
					awaiter = _0024A0;
					_0024A0 = default(TaskAwaiter<object>);
				}
				awaiter.GetResult();
				awaiter = default(TaskAwaiter<object>);
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

	[CompilerGenerated]
	internal sealed class _Closure_0024__19_002D0
	{
		public Bitmap _0024VB_0024Local_img;

		public string _0024VB_0024Local_Text;

		public Report _0024VB_0024Me;

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R1()
		{
			_Lambda_0024__0();
		}

		[SpecialName]
		internal object _Lambda_0024__0()
		{
			return _0024VB_0024Me.Add(_0024VB_0024Local_img, _0024VB_0024Local_Text);
		}
	}

	private IContainer components;

	public List<Notifications> Items;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Bgworker")]
	private BackgroundWorker _Bgworker;

	private IntPtr MeHand;

	private Color ColorBack;

	private Color ColorFont;

	private int sizeFontHeight;

	private int sizeFontWidth;

	private int sizeHeightSTOP;

	private int timeOut;

	private bool status;

	public virtual BackgroundWorker Bgworker
	{
		[CompilerGenerated]
		get
		{
			return _Bgworker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatsdsvvwwedsd;
			BackgroundWorker bgworker = _Bgworker;
			if (bgworker != null)
				bgworker.DoWork -= value2;
			_Bgworker = value;
			bgworker = _Bgworker;
			if (bgworker != null)
				bgworker.DoWork += value2;
		}
	}

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = base.CreateParams;
			if (!base.DesignMode)
				createParams.ExStyle |= 524288;
			return createParams;
		}
	}

	public Report()
	{
		base.Load += CraxsRatkfvuiorkenfudpajrsnCraxsRatsdsvwevswefd;
		base.MouseClick += Report_MouseClick;
		base.Closing += Report_Closing;
		ColorBack = Color.Black;
		ColorFont = Color.FromArgb(157, 5, 17);
		sizeFontHeight = 5;
		sizeFontWidth = 5;
		sizeHeightSTOP = 9;
		timeOut = 15;
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
		base.SuspendLayout();
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(95, 95, 95);
		base.ClientSize = new System.Drawing.Size(220, 120);
		base.ControlBox = false;
		this.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Report";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "Notifications";
		base.TopMost = true;
		base.ResumeLayout(false);
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_17_FadeIn))]
	[DebuggerStepThrough]
	private void FadeIn(Form o, int interval = 80)
	{
		VB_0024StateMachine_17_FadeIn stateMachine = new VB_0024StateMachine_17_FadeIn();
		stateMachine._0024VB_0024Me = this;
		stateMachine._0024VB_0024Local_o = o;
		stateMachine._0024VB_0024Local_interval = interval;
		stateMachine._0024State = -1;
		stateMachine._0024Builder = AsyncVoidMethodBuilder.Create();
		stateMachine._0024Builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_18_FadeOut))]
	[DebuggerStepThrough]
	private void FadeOut(Form o, int interval = 80)
	{
		VB_0024StateMachine_18_FadeOut stateMachine = new VB_0024StateMachine_18_FadeOut();
		stateMachine._0024VB_0024Me = this;
		stateMachine._0024VB_0024Local_o = o;
		stateMachine._0024VB_0024Local_interval = interval;
		stateMachine._0024State = -1;
		stateMachine._0024Builder = AsyncVoidMethodBuilder.Create();
		stateMachine._0024Builder.Start(ref stateMachine);
	}

	public void AddItem(Bitmap img, string Text)
	{
		_Closure_0024__19_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__19_002D0();
		CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_img = img;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_Text = Text;
		Task task = new Task([SpecialName] [DebuggerHidden] () =>
		{
			CS_0024_003C_003E8__locals0._Lambda_0024__0();
		});
		task.RunSynchronously();
		task.Wait();
		task.Dispose();
	}

	private object Add(Bitmap img, string Text)
	{
		object syncNotifications = Data.SyncNotifications;
		ObjectFlowControl.CheckForSyncLockOnValueType(syncNotifications);
		bool lockTaken = false;
		try
		{
			Monitor.Enter(syncNotifications, ref lockTaken);
			if (Items.Count >= 60)
				Items.RemoveAt(0);
			try
			{
				Notifications item = new Notifications
				{
					FLAG = img,
					TEXT = Text
				};
				Items.Add(item);
				if ((Items.Count > 0) & !status)
					MyShow();
			}
			catch (InvalidOperationException projectError)
			{
				//ProjectData.SetProjectError(projectError);
				//////CraxsAlert.Showinformation("Sorry");
			}
		}
		finally
		{
			if (lockTaken)
				Monitor.Exit(syncNotifications);
		}
		return null;
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsdsvwevswefd(object sender, EventArgs e)
	{
		MeHand = base.Handle;
		status = false;
		Items = new List<Notifications>();
		checked
		{
			int num = ((Operators.CompareString(SpySettings.LOCATION_NOTICETIGHT, "Right", TextCompare: false) != 0) ? 5 : (Screen.PrimaryScreen.WorkingArea.Width - base.Width));
			int num2 = Screen.PrimaryScreen.WorkingArea.Height - base.Height;
			base.Location = new Point(num, num2);
			Bgworker = new BackgroundWorker();
			if (!Bgworker.IsBusy)
				Bgworker.RunWorkerAsync();
		}
	}

	public void MyShow()
	{
		status = true;
	}

	public void MyHide()
	{
		status = false;
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsdsvvwwedsd(object sender, DoWorkEventArgs e)
	{
		checked
		{
			List<Notifications>.Enumerator enumerator2 = default(List<Notifications>.Enumerator);
			while (true)
			{
				Thread.Sleep(1);
				try
				{
					Thread.Sleep(25);
					if (!((Items.Count > 0) & status))
						continue;
					try
					{
						object syncNotifications = Data.SyncNotifications;
						ObjectFlowControl.CheckForSyncLockOnValueType(syncNotifications);
						bool lockTaken = false;
						try
						{
							Monitor.Enter(syncNotifications, ref lockTaken);
							Bitmap bitmap = new Bitmap(base.Width, base.Height);
							Graphics graphics = Graphics.FromImage(bitmap);
							graphics.SmoothingMode = SmoothingMode.AntiAlias;
							graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
							graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
							graphics.CompositingQuality = CompositingQuality.GammaCorrected;
							graphics.CompositingMode = CompositingMode.SourceOver;
							foreach (Notifications item in Items)
							{
								if (item.sizeHeight <= sizeHeightSTOP)
									item.sizeHeight = sizeHeightSTOP;
								else
								{
									int count = Items.Count;
									if (count > 60)
										item.sizeHeight = sizeHeightSTOP;
									else if (count > 20)
									{
										item.sizeHeight += -14;
									}
									else if (count > 15)
									{
										item.sizeHeight += -8;
									}
									else if (count > 10)
									{
										item.sizeHeight += -4;
									}
									else if (count > 5)
									{
										item.sizeHeight += -2;
									}
									else
									{
										item.sizeHeight += -1;
									}
									if (item.sizeHeight <= sizeHeightSTOP)
										item.sizeHeight = sizeHeightSTOP;
								}
								SizeF sizeF = default(SizeF);
								int num = (int)Math.Round(graphics.MeasureString(item.TEXT, reso.f).Height + (float)sizeFontHeight);
								Rectangle rectangle = new Rectangle(0, item.sizeHeight, base.Width, num);
								LinearGradientBrush brush = new LinearGradientBrush(rectangle, ColorBack, ColorBack, LinearGradientMode.BackwardDiagonal);
								GraphicsPath path = RoundRect(rectangle, (Operators.CompareString(SpySettings.NOTI_Round, "Yes", TextCompare: false) != 0) ? 1 : 12);
								graphics.FillPath(brush, path);
								rectangle = new Rectangle(0, item.sizeHeight - sizeFontHeight, 0, 0);
								ControlPaint.DrawLockedFrame(graphics, rectangle, primary: false);
								object[] array = new object[2]
								{
									RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(item.FLAG.Clone())),
									null
								};
								Point point = new Point(base.Width - item.FLAG.Width - 7, item.sizeHeight + sizeFontHeight);
								array[1] = point;
								NewLateBinding.LateCall(graphics, null, "DrawImage", array, null, null, null, IgnoreReturn: true);
								using (SolidBrush brush2 = new SolidBrush(ColorFont))
									graphics.DrawString(item.TEXT, reso.f, brush2, sizeFontWidth, item.sizeHeight + sizeFontHeight);
								if (item.sizeHeight > base.Height - 50)
									break;
							}
							try
							{
								while (true)
								{
									IL_0313:
									enumerator2 = Items.GetEnumerator();
									while (enumerator2.MoveNext())
									{
										Notifications current2 = enumerator2.Current;
										if (!current2.startTime)
										{
											current2.start = DateTime.Now.AddSeconds(timeOut);
											current2.startTime = true;
										}
										int num2 = DateTime.Compare(current2.start, DateTime.Now);
										if (num2 < 0)
										{
											Items.Remove(current2);
											goto IL_0313;
										}
									}
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator2).Dispose();
							}
							if ((Items.Count == 0) & status)
							{
								bitmap = null;
								MyHide();
							}
							graphics.Flush(FlushIntention.Sync);
							graphics.Dispose();
							UpdateWindow(bitmap);
						}
						finally
						{
							if (lockTaken)
								Monitor.Exit(syncNotifications);
						}
					}
					catch (Exception)
					{
						//ProjectData.SetProjectError(projectError);
						//////CraxsAlert.Showinformation("Sorry");
					}
				}
				catch (Exception)
				{
					//ProjectData.SetProjectError(projectError2);
					//////CraxsAlert.Showinformation("Sorry");
				}
			}
		}
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_25_Report_MouseClick))]
	[DebuggerStepThrough]
	private void Report_MouseClick(object sender, MouseEventArgs e)
	{
		VB_0024StateMachine_25_Report_MouseClick stateMachine = new VB_0024StateMachine_25_Report_MouseClick();
		stateMachine._0024VB_0024Me = this;
		stateMachine._0024VB_0024Local_sender = sender;
		stateMachine._0024VB_0024Local_e = e;
		stateMachine._0024State = -1;
		stateMachine._0024Builder = AsyncVoidMethodBuilder.Create();
		stateMachine._0024Builder.Start(ref stateMachine);
	}

	private object AllClear()
	{
		object syncNotifications = Data.SyncNotifications;
		ObjectFlowControl.CheckForSyncLockOnValueType(syncNotifications);
		bool lockTaken = false;
		try
		{
			Monitor.Enter(syncNotifications, ref lockTaken);
			Items.Clear();
			BitmapClean();
			MyHide();
		}
		finally
		{
			if (lockTaken)
				Monitor.Exit(syncNotifications);
		}
		return null;
	}

	public GraphicsPath RoundRect(Rectangle Rectangle, int Curve)
	{
		GraphicsPath graphicsPath = new GraphicsPath();
		checked
		{
			graphicsPath.AddArc(Rectangle.X + Rectangle.Width - Curve, Rectangle.Y, Curve, Curve, 270f, 90f);
			graphicsPath.AddArc(Rectangle.X + Rectangle.Width - Curve, Rectangle.Y + Rectangle.Height - Curve, Curve, Curve, 0f, 90f);
			graphicsPath.AddArc(Rectangle.X, Rectangle.Y + Rectangle.Height - Curve, Curve, Curve, 90f, 90f);
			graphicsPath.AddArc(Rectangle.X, Rectangle.Y, Curve, Curve, 180f, 90f);
			graphicsPath.CloseFigure();
			return graphicsPath;
		}
	}

	public void BitmapClean()
	{
		if (!base.IsDisposed && base.Width > 0 && base.Height > 0)
		{
			Bitmap bm = new Bitmap(base.Width, base.Height, PixelFormat.Format32bppPArgb);
			UpdateWindow(bm);
		}
	}

	public void UpdateWindow(Bitmap bm)
	{
		if (base.IsDisposed || base.Width <= 0 || base.Height <= 0)
			return;
		using Bitmap bitmap = new Bitmap(base.Width, base.Height, PixelFormat.Format32bppPArgb);
		using Graphics graphics = Graphics.FromImage(bitmap);
		graphics.SmoothingMode = SmoothingMode.AntiAlias;
		graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
		graphics.CompositingQuality = CompositingQuality.GammaCorrected;
		graphics.CompositingMode = CompositingMode.SourceOver;
		if (bm != null)
			graphics.DrawImage(bm, new Rectangle(0, 0, bm.Width, bm.Height));
		IntPtr dC = NativeMethods.GetDC(IntPtr.Zero);
		IntPtr intPtr = NativeMethods.CreateCompatibleDC(dC);
		IntPtr hbitmap = bitmap.GetHbitmap(Color.FromArgb(0));
		IntPtr hObj = NativeMethods.SelectObject(intPtr, hbitmap);
		NativeMethods.BLENDFUNCTION pblend = new NativeMethods.BLENDFUNCTION(225);
		Point pptDst = base.Location;
		Size psize = bitmap.Size;
		Point pptSrc = Point.Empty;
		NativeMethods.UpdateLayeredWindow(MeHand, dC, ref pptDst, ref psize, intPtr, ref pptSrc, 0, ref pblend, 2);
		NativeMethods.SelectObject(intPtr, hObj);
		NativeMethods.DeleteObject(hbitmap);
		NativeMethods.DeleteDC(intPtr);
		NativeMethods.DeleteDC(dC);
	}

	protected override void OnResize(EventArgs e)
	{
		base.OnResize(e);
		if (base.Created)
			UpdateWindow(null);
	}

	protected override void OnLocationChanged(EventArgs e)
	{
		base.OnLocationChanged(e);
		if (base.Created)
			UpdateWindow(null);
	}

	protected override void OnVisibleChanged(EventArgs e)
	{
		base.OnVisibleChanged(e);
		if (base.Visible)
			UpdateWindow(null);
	}

	private void Report_Closing(object sender, CancelEventArgs e)
	{
		if (Bgworker != null)
			Bgworker.Dispose();
	}
}
