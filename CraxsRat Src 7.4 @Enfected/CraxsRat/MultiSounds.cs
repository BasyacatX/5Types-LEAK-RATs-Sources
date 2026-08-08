using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

public class MultiSounds
{
	private Dictionary<string, string> Snds;

	private int sndcnt;

	public MultiSounds()
	{
		Snds = new Dictionary<string, string>();
		sndcnt = 0;
	}

	[DllImport("winmm.dll")]
	private static extern int mciSendStringW([MarshalAs(UnmanagedType.LPTStr)] string lpszCommand, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpszReturnString, uint cchReturn, IntPtr hwndCallback);

	public bool AddSound(string SoundName, string SndFilePath)
	{
		if ((Operators.CompareString(SoundName.Trim(), "", TextCompare: false) == 0) | !File.Exists(SndFilePath))
			return false;
		if (mciSendStringW("open \"" + SndFilePath + "\" alias Snd_" + sndcnt, null, 0u, IntPtr.Zero) != 0)
			return false;
		Snds.Add(SoundName, "Snd_" + sndcnt);
		checked
		{
			sndcnt++;
			return true;
		}
	}

	public bool Play(string SoundName)
	{
		if (!Snds.ContainsKey(SoundName))
			return false;
		mciSendStringW("seek " + Snds[SoundName] + " to start", null, 0u, IntPtr.Zero);
		if (mciSendStringW("play " + Snds[SoundName], null, 0u, IntPtr.Zero) != 0)
			return false;
		return true;
	}
}
