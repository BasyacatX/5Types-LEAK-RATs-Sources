using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
[ToolboxBitmap("ZoomPictureBox.bmp")]
public class ZoomPictureBox : UserControl
{
	public enum ZoomType
	{
		MousePosition,
		ControlCenter,
		ImageCenter
	}

	private IContainer components;

	public int MouseWheelDivisor;

	public int MinimumImageWidth;

	public int MinimumImageHeight;

	public double MaximumZoomFactor;

	public bool EnableMouseWheelZooming;

	public bool EnableMouseDragging;

	private Rectangle _ImageBounds;

	private double _ZoomFactor;

	private Image _Image;

	private Point _startDrag;

	private bool _dragging;

	private ZoomType _ZoomMode;

	[Category("_ZoomPictureBox")]
	public Image Image
	{
		get
		{
			return _Image;
		}
		set
		{
			_Image = value;
			InitializeImage();
		}
	}

	[Category("_ZoomPictureBox")]
	[DefaultValue(0)]
	public ZoomType ZoomMode
	{
		get
		{
			return _ZoomMode;
		}
		set
		{
			_ZoomMode = value;
		}
	}

	[Browsable(false)]
	public double ZoomFactor
	{
		get
		{
			return _ZoomFactor;
		}
		set
		{
			_ZoomFactor = ValidateZoomFactor(value);
			Invalidate(_ImageBounds);
			_ImageBounds = GetZoomedBounds();
			Invalidate(_ImageBounds);
		}
	}

	[Browsable(false)]
	public Point ImagePosition
	{
		get
		{
			return _ImageBounds.Location;
		}
		set
		{
			_ImageBounds.Location = value;
		}
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
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	}

	public ZoomPictureBox()
	{
		MouseWheelDivisor = 4000;
		MinimumImageWidth = 100;
		MinimumImageHeight = 100;
		MaximumZoomFactor = 16.0;
		EnableMouseWheelZooming = true;
		EnableMouseDragging = true;
		_ZoomMode = ZoomType.MousePosition;
		InitializeComponent();
		DoubleBuffered = true;
		BackColor = Color.FromKnownColor(KnownColor.AppWorkspace);
		base.Size = new Size(200, 200);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		if (EnableMouseDragging && e.Button == MouseButtons.Left)
		{
			_startDrag = e.Location;
			_dragging = true;
		}
		base.OnMouseDown(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		checked
		{
			if (_dragging)
			{
				Invalidate(_ImageBounds);
				_ImageBounds.X += e.X - _startDrag.X;
				_ImageBounds.Y += e.Y - _startDrag.Y;
				_startDrag = e.Location;
				Invalidate(_ImageBounds);
			}
			base.OnMouseMove(e);
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		if (_dragging)
		{
			_dragging = false;
			Invalidate();
		}
		base.OnMouseUp(e);
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		Select();
		base.OnMouseEnter(e);
	}

	protected override void OnMouseWheel(MouseEventArgs e)
	{
		if (EnableMouseWheelZooming && base.Bounds.Contains(PointToClient(Control.MousePosition)))
		{
			double zoomFactor = _ZoomFactor;
			zoomFactor *= 1.0 + (double)e.Delta / (double)MouseWheelDivisor;
			ZoomFactor = zoomFactor;
		}
		base.OnMouseWheel(e);
	}

	protected override void OnPaint(PaintEventArgs pe)
	{
		if (_ZoomFactor > 4.0)
		{
			pe.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
			pe.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
		}
		else
			pe.Graphics.InterpolationMode = InterpolationMode.Default;
		if (_Image != null)
			pe.Graphics.DrawImage(_Image, _ImageBounds);
		base.OnPaint(pe);
	}

	protected override void OnParentChanged(EventArgs e)
	{
		InitializeImage();
		base.OnParentChanged(e);
	}

	private void InitializeImage()
	{
		if (_Image != null)
		{
			ZoomFactor = FitImageToControl();
			_ImageBounds = CenterImageBounds();
		}
		Invalidate();
	}

	private double ValidateZoomFactor(double zoom)
	{
		zoom = Math.Min(zoom, MaximumZoomFactor);
		checked
		{
			if (_Image != null)
			{
				if ((int)Math.Round((double)_Image.Width * zoom) < MinimumImageWidth)
					zoom = (double)MinimumImageWidth / (double)_Image.Width;
				if ((int)Math.Round((double)_Image.Height * zoom) < MinimumImageHeight)
					zoom = (double)MinimumImageHeight / (double)_Image.Height;
			}
			return zoom;
		}
	}

	public void RefreshLocation()
	{
		InitializeImage();
	}

	private double FitImageToControl()
	{
		if (base.ClientSize == Size.Empty)
			return 1.0;
		double num = (double)_Image.Width / (double)_Image.Height;
		double num2 = (double)base.ClientSize.Width / (double)base.ClientSize.Height;
		if (num > num2)
			return (double)base.ClientSize.Width / (double)_Image.Width;
		return (double)base.ClientSize.Height / (double)_Image.Height;
	}

	private Rectangle CenterImageBounds()
	{
		int num;
		int num2;
		checked
		{
			num = (int)Math.Round((double)_Image.Width * _ZoomFactor);
			num2 = (int)Math.Round((double)_Image.Height * _ZoomFactor);
		}
		int num3 = checked(base.ClientSize.Width - num) / 2;
		int num4 = checked(base.ClientSize.Height - num2) / 2;
		return new Rectangle(num3, num4, num, num2);
	}

	private Rectangle GetZoomedBounds()
	{
		checked
		{
			Rectangle result = default(Rectangle);
			try
			{
				if (_Image == null)
				{
					result = Rectangle.Empty;
					return result;
				}
				if (_ImageBounds == Rectangle.Empty)
					_ImageBounds = CenterImageBounds();
				Point point = FindZoomCenter(_ZoomMode);
				double num = (double)_ImageBounds.Width / (double)_Image.Width;
				double num2 = _ZoomFactor / num;
				_ImageBounds.Width = (int)Math.Round((double)_ImageBounds.Width * num2);
				_ImageBounds.Height = (int)Math.Round((double)_ImageBounds.Height * num2);
				Point point2 = default(Point);
				point2.X = (int)Math.Round((double)point.X * num2);
				point2.Y = (int)Math.Round((double)point.Y * num2);
				_ImageBounds.X += point.X - point2.X;
				_ImageBounds.Y += point.Y - point2.Y;
				result = _ImageBounds;
				return result;
			}
			catch (Exception)
			{
				//ProjectData.SetProjectError(projectError);
				//////CraxsAlert.Showinformation("Sorry");
			}
			return result;
		}
	}

	private Point FindZoomCenter(ZoomType type)
	{
		checked
		{
			Point result = default(Point);
			switch (type)
			{
			default:
				return Point.Empty;
			case ZoomType.MousePosition:
			{
				Point point = PointToClient(Control.MousePosition);
				result.X = point.X - _ImageBounds.X;
				result.Y = point.Y - _ImageBounds.Y;
				break;
			}
			case ZoomType.ControlCenter:
				result.X = unchecked(base.Width / 2) - _ImageBounds.X;
				result.Y = unchecked(base.Height / 2) - _ImageBounds.Y;
				break;
			case ZoomType.ImageCenter:
				unchecked
				{
					result.X = _ImageBounds.Width / 2;
					result.Y = _ImageBounds.Height / 2;
					break;
				}
			}
			return result;
		}
	}
}
