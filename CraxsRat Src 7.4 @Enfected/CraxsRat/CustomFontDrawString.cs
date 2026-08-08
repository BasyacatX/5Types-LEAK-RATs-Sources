using System.Drawing;
using System.Drawing.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[StandardModule]
internal sealed class CustomFontDrawString
{
	private static PrivateFontCollection privateFonts = null;

	public static Font LoadFont(string name, float size, FontStyle style)
	{
		
			privateFonts = new PrivateFontCollection();
			privateFonts.AddFontFile(reso.res_Path + "\\Fonts\\" + name);
			return new Font(privateFonts.Families[0], size, style);
		
	}
}
