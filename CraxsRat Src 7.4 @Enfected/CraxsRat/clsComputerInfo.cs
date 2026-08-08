using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace Eagle_Spy;

public class clsComputerInfo
{
	public static string GetSerialNumber()
	{
		SelectQuery query = new SelectQuery("Win32_BaseBoard");
		ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(query);
		string result = default(string);
		using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = managementObjectSearcher.Get().GetEnumerator())
		{
			if (managementObjectEnumerator.MoveNext())
			{
				ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
				result = managementObject["SerialNumber"].ToString();
				return result;
			}
		}
		return result;
	}

	public static string GetProcessorID()
	{
		SelectQuery query = new SelectQuery("Win32_processor");
		ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(query);
		string result = default(string);
		using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = managementObjectSearcher.Get().GetEnumerator())
		{
			if (managementObjectEnumerator.MoveNext())
			{
				ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
				result = managementObject["processorId"].ToString();
				return result;
			}
		}
		return result;
	}

	public static string GenerateHash(string input)
	{
		byte[] source = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input + GetVolumeSerial()));
		return string.Concat(source.Select([SpecialName] (byte b) => b.ToString("x2")));
	}

	internal static string GetVolumeSerial(string strDriveLetter = "C")
	{
		ManagementObject managementObject = new ManagementObject($"win32_logicaldisk.deviceid=\"{strDriveLetter}:\"");
		managementObject.Get();
		return managementObject["VolumeSerialNumber"].ToString();
	}
}
