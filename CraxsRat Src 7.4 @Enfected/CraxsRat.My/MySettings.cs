using System;
using System.CodeDom.Compiler;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy.My;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.7.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

	private static bool addedHandler;

	private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

	public static MySettings Default
	{
		get
		{
			if (!addedHandler)
			{
				object obj = addedHandlerLockObject;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				bool lockTaken = false;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					if (!addedHandler)
					{
						MyProject.Application.Shutdown += [DebuggerNonUserCode] [EditorBrowsable(EditorBrowsableState.Advanced)] (object sender, EventArgs e) =>
						{
							if (MyProject.Application.SaveMySettingsOnExit)
								MySettingsProperty.Settings.Save();
						};
						addedHandler = true;
					}
				}
				finally
				{
					if (lockTaken)
						Monitor.Exit(obj);
				}
			}
			return defaultInstance;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("7771>7772")]
	public string ports
	{
		get
		{
			return Conversions.ToString(this["ports"]);
		}
		set
		{
			this["ports"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Normal")]
	public string performance
	{
		get
		{
			return Conversions.ToString(this["performance"]);
		}
		set
		{
			this["performance"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("UTF8")]
	public string encoding8
	{
		get
		{
			return Conversions.ToString(this["encoding8"]);
		}
		set
		{
			this["encoding8"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Yes")]
	public string show_alert
	{
		get
		{
			return Conversions.ToString(this["show_alert"]);
		}
		set
		{
			this["show_alert"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Right")]
	public string location
	{
		get
		{
			return Conversions.ToString(this["location"]);
		}
		set
		{
			this["location"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Just tell me")]
	public string disconnected
	{
		get
		{
			return Conversions.ToString(this["disconnected"]);
		}
		set
		{
			this["disconnected"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("No")]
	public string Auto_focus
	{
		get
		{
			return Conversions.ToString(this["Auto_focus"]);
		}
		set
		{
			this["Auto_focus"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Normal")]
	public string Effects_CAM
	{
		get
		{
			return Conversions.ToString(this["Effects_CAM"]);
		}
		set
		{
			this["Effects_CAM"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Streets")]
	public string Style_Maps
	{
		get
		{
			return Conversions.ToString(this["Style_Maps"]);
		}
		set
		{
			this["Style_Maps"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Yes")]
	public string Saving_data
	{
		get
		{
			return Conversions.ToString(this["Saving_data"]);
		}
		set
		{
			this["Saving_data"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Auto")]
	public string CAMQuality
	{
		get
		{
			return Conversions.ToString(this["CAMQuality"]);
		}
		set
		{
			this["CAMQuality"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Client")]
	public string build_text_name_victim
	{
		get
		{
			return Conversions.ToString(this["build_text_name_victim"]);
		}
		set
		{
			this["build_text_name_victim"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("CraxsApp")]
	public string build_text_name_patch
	{
		get
		{
			return Conversions.ToString(this["build_text_name_patch"]);
		}
		set
		{
			this["build_text_name_patch"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.0.0.0")]
	public string build_text_version
	{
		get
		{
			return Conversions.ToString(this["build_text_version"]);
		}
		set
		{
			this["build_text_version"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int build_text_sleep
	{
		get
		{
			return Conversions.ToInteger(this["build_text_sleep"]);
		}
		set
		{
			this["build_text_sleep"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("7771")]
	public int build_text_port
	{
		get
		{
			return Conversions.ToInteger(this["build_text_port"]);
		}
		set
		{
			this["build_text_port"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool build_Checked_hide
	{
		get
		{
			return Conversions.ToBoolean(this["build_Checked_hide"]);
		}
		set
		{
			this["build_Checked_hide"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool build_Checked_icon
	{
		get
		{
			return Conversions.ToBoolean(this["build_Checked_icon"]);
		}
		set
		{
			this["build_Checked_icon"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool build_Checked_doze
	{
		get
		{
			return Conversions.ToBoolean(this["build_Checked_doze"]);
		}
		set
		{
			this["build_Checked_doze"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("null")]
	public string build_path_icon
	{
		get
		{
			return Conversions.ToString(this["build_path_icon"]);
		}
		set
		{
			this["build_path_icon"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("null")]
	public string build_DGV_list
	{
		get
		{
			return Conversions.ToString(this["build_DGV_list"]);
		}
		set
		{
			this["build_DGV_list"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("95, 95, 250")]
	public Color DefaultColorForeground
	{
		get
		{
			object obj = this["DefaultColorForeground"];
			return (obj != null) ? ((Color)obj) : default(Color);
		}
		set
		{
			this["DefaultColorForeground"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("50, 50, 50")]
	public Color DefaultColorBackground
	{
		get
		{
			object obj = this["DefaultColorBackground"];
			return (obj != null) ? ((Color)obj) : default(Color);
		}
		set
		{
			this["DefaultColorBackground"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("9")]
	public int FontSize
	{
		get
		{
			return Conversions.ToInteger(this["FontSize"]);
		}
		set
		{
			this["FontSize"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Regular")]
	public string FontStyle
	{
		get
		{
			return Conversions.ToString(this["FontStyle"]);
		}
		set
		{
			this["FontStyle"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("00110000")]
	public string EncryptionKey
	{
		get
		{
			return Conversions.ToString(this["EncryptionKey"]);
		}
		set
		{
			this["EncryptionKey"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Red")]
	public Color DefaultColor_NewColorFiles
	{
		get
		{
			object obj = this["DefaultColor_NewColorFiles"];
			return (obj != null) ? ((Color)obj) : default(Color);
		}
		set
		{
			this["DefaultColor_NewColorFiles"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Blue")]
	public Color DefaultColor_ColorTitles
	{
		get
		{
			object obj = this["DefaultColor_ColorTitles"];
			return (obj != null) ? ((Color)obj) : default(Color);
		}
		set
		{
			this["DefaultColor_ColorTitles"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("null")]
	public string BIND_Path
	{
		get
		{
			return Conversions.ToString(this["BIND_Path"]);
		}
		set
		{
			this["BIND_Path"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("null")]
	public string BIND_EX
	{
		get
		{
			return Conversions.ToString(this["BIND_EX"]);
		}
		set
		{
			this["BIND_EX"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("null")]
	public string intent
	{
		get
		{
			return Conversions.ToString(this["intent"]);
		}
		set
		{
			this["intent"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool NOTI_SOUND
	{
		get
		{
			return Conversions.ToBoolean(this["NOTI_SOUND"]);
		}
		set
		{
			this["NOTI_SOUND"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Yes")]
	public string Flags_Visible
	{
		get
		{
			return Conversions.ToString(this["Flags_Visible"]);
		}
		set
		{
			this["Flags_Visible"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("32px")]
	public string Flags_Size
	{
		get
		{
			return Conversions.ToString(this["Flags_Size"]);
		}
		set
		{
			this["Flags_Size"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Yes")]
	public string Round
	{
		get
		{
			return Conversions.ToString(this["Round"]);
		}
		set
		{
			this["Round"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Yes")]
	public string SStatus_Visible
	{
		get
		{
			return Conversions.ToString(this["SStatus_Visible"]);
		}
		set
		{
			this["SStatus_Visible"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0123456789")]
	public string _Columns
	{
		get
		{
			return Conversions.ToString(this["_Columns"]);
		}
		set
		{
			this["_Columns"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Small")]
	public string FM_IC_Size
	{
		get
		{
			return Conversions.ToString(this["FM_IC_Size"]);
		}
		set
		{
			this["FM_IC_Size"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Yes")]
	public string Removing_Duplicates
	{
		get
		{
			return Conversions.ToString(this["Removing_Duplicates"]);
		}
		set
		{
			this["Removing_Duplicates"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("No")]
	public string _multi_sounds
	{
		get
		{
			return Conversions.ToString(this["_multi_sounds"]);
		}
		set
		{
			this["_multi_sounds"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20")]
	public int ImageQualty
	{
		get
		{
			return Conversions.ToInteger(this["ImageQualty"]);
		}
		set
		{
			this["ImageQualty"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Yes")]
	public string Cashpic
	{
		get
		{
			return Conversions.ToString(this["Cashpic"]);
		}
		set
		{
			this["Cashpic"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Yes")]
	public string LOG
	{
		get
		{
			return Conversions.ToString(this["LOG"]);
		}
		set
		{
			this["LOG"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("PT1BQUFic2RGQURhY0FTQ1ZERVNEVnNkU0RSVlNEVkFFR1NTRkJSRUE=")]
	public string DKEY
	{
		get
		{
			return Conversions.ToString(this["DKEY"]);
		}
		set
		{
			this["DKEY"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Yes")]
	public string ShowAlertDis
	{
		get
		{
			return Conversions.ToString(this["ShowAlertDis"]);
		}
		set
		{
			this["ShowAlertDis"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Yes")]
	public string hidecoonstart
	{
		get
		{
			return Conversions.ToString(this["hidecoonstart"]);
		}
		set
		{
			this["hidecoonstart"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("...")]
	public string inj_thost
	{
		get
		{
			return Conversions.ToString(this["inj_thost"]);
		}
		set
		{
			this["inj_thost"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("4444")]
	public string inj_tport
	{
		get
		{
			return Conversions.ToString(this["inj_tport"]);
		}
		set
		{
			this["inj_tport"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1234")]
	public string inj_tkey
	{
		get
		{
			return Conversions.ToString(this["inj_tkey"]);
		}
		set
		{
			this["inj_tkey"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Client")]
	public string inj_tnam
	{
		get
		{
			return Conversions.ToString(this["inj_tnam"]);
		}
		set
		{
			this["inj_tnam"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool requestmade
	{
		get
		{
			return Conversions.ToBoolean(this["requestmade"]);
		}
		set
		{
			this["requestmade"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool reportmade
	{
		get
		{
			return Conversions.ToBoolean(this["reportmade"]);
		}
		set
		{
			this["reportmade"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("System update")]
	public string NotifiTitle
	{
		get
		{
			return Conversions.ToString(this["NotifiTitle"]);
		}
		set
		{
			this["NotifiTitle"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("New system software is available, Tap to learn more.")]
	public string NotifiText
	{
		get
		{
			return Conversions.ToString(this["NotifiText"]);
		}
		set
		{
			this["NotifiText"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("This App Request Accessibility Service:\r\n• Click on Enable\r\n• Go to Downloaded Service\r\n• Enable [MY-NAME]")]
	public string bodytext
	{
		get
		{
			return Conversions.ToString(this["bodytext"]);
		}
		set
		{
			this["bodytext"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("...")]
	public string accessdiscribe
	{
		get
		{
			return Conversions.ToString(this["accessdiscribe"]);
		}
		set
		{
			this["accessdiscribe"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("100")]
	public string live_sc_qulty
	{
		get
		{
			return Conversions.ToString(this["live_sc_qulty"]);
		}
		set
		{
			this["live_sc_qulty"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("10")]
	public string live_fps_rec
	{
		get
		{
			return Conversions.ToString(this["live_fps_rec"]);
		}
		set
		{
			this["live_fps_rec"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Yes")]
	public string checkupdatestart
	{
		get
		{
			return Conversions.ToString(this["checkupdatestart"]);
		}
		set
		{
			this["checkupdatestart"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	public StringCollection ListBoxItems
	{
		get
		{
			return (StringCollection)this["ListBoxItems"];
		}
		set
		{
			this["ListBoxItems"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool savepass
	{
		get
		{
			return Conversions.ToBoolean(this["savepass"]);
		}
		set
		{
			this["savepass"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("450x300")]
	public string resolution
	{
		get
		{
			return Conversions.ToString(this["resolution"]);
		}
		set
		{
			this["resolution"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	public StringCollection ListBoxTracker
	{
		get
		{
			return (StringCollection)this["ListBoxTracker"];
		}
		set
		{
			this["ListBoxTracker"] = value;
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		if (MyProject.Application.SaveMySettingsOnExit)
			MySettingsProperty.Settings.Save();
	}
}
