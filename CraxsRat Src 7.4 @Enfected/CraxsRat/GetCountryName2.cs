using Eagle_Spy.sockets;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[StandardModule]
public sealed class GetCountryName2
{
	public static string GetCountryName(string ipc)
	{
		string text = Data.GeoIP0.LookupCountryName(ipc.Trim());
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
				text = Codes.Translate(text, "en", "ar");
		}
		else
			text = Codes.Translate(text, "en", "zh");
		return text;
	}
}
