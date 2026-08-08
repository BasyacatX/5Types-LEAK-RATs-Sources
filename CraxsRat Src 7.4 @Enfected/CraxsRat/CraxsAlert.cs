using System;
using System.Drawing;
using Eagle_Spy.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[StandardModule]
internal sealed class CraxsAlert
{
	public static void ShowCustome(string msg, Bitmap img, Color backcolor, Color rondcolor)
	{
		try
		{
			alertform alertform2 = new alertform(msg);
			//alertform2.alertimage.Image = img;
			//alertform2.backpanel.FillColor = backcolor;
			//alertform2.lidlamb.ForeColor = rondcolor;
		//	alertform2.backpanel.RectColor = rondcolor;
			alertform2.Show();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	public static void ShowSucess(string msg)
	{
		alertform alertform2 = new alertform(msg);
		//alertform2.alertimage.Image = Resources.sucess48px;
		//alertform2.backpanel.FillColor = Color.Black;
		//alertform2.msglabel.ForeColor = Color.Lime;
		//alertform2.backpanel.RectColor = Color.Lime;
		alertform2.Show();
	}

	public static void ShowWarning(string msg)
	{
		alertform alertform2 = new alertform(msg);
		//alertform2.alertimage.Image = Resources.warning48px;
	//	alertform2.backpanel.FillColor = Color.Black;
	//	alertform2.lidlamb.ForeColor = Color.Orange;
	//	alertform2.backpanel.RectColor = Color.Orange;
		alertform2.Show();
	}

	public static void Showinformation(string msg)
	{
		alertform alertform2 = new alertform(msg);
		//alertform2.alertimage.Image = Resources.information48px;
		//alertform2.backpanel.FillColor = Color.Black;
		//alertform2.lidlamb.ForeColor = Color.LightSkyBlue;
		//alertform2.backpanel.RectColor = Color.LightSkyBlue;
		alertform2.Show();
	}

	public static void ShowError(string msg)
	{
		alertform alertform2 = new alertform(msg);
		//alertform2.alertimage.Image = Resources.error48px;
		//alertform2.backpanel.FillColor = Color.Black;
		//alertform2.lidlamb.ForeColor = Color.Red;
	//	alertform2.backpanel.RectColor = Color.Red;
		alertform2.Show();
	}
}
