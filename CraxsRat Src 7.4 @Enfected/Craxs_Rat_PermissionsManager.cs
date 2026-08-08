using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x0200000D RID: 13
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Craxs_Rat_PermissionsManager
{
	// Token: 0x060000A7 RID: 167 RVA: 0x00002085 File Offset: 0x00000285
	internal Craxs_Rat_PermissionsManager()
	{
	}

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x060000A8 RID: 168 RVA: 0x00005CC8 File Offset: 0x00003EC8
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (Craxs_Rat_PermissionsManager.resourceMan == null)
			{
				ResourceManager resourceManager = new ResourceManager("Craxs_Rat.PermissionsManager", typeof(Craxs_Rat_PermissionsManager).Assembly);
				Craxs_Rat_PermissionsManager.resourceMan = resourceManager;
			}
			return Craxs_Rat_PermissionsManager.resourceMan;
		}
	}

	// Token: 0x17000093 RID: 147
	// (get) Token: 0x060000A9 RID: 169 RVA: 0x00005D08 File Offset: 0x00003F08
	// (set) Token: 0x060000AA RID: 170 RVA: 0x000020D5 File Offset: 0x000002D5
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return Craxs_Rat_PermissionsManager.resourceCulture;
		}
		set
		{
			Craxs_Rat_PermissionsManager.resourceCulture = value;
		}
	}

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x060000AB RID: 171 RVA: 0x00005D1C File Offset: 0x00003F1C
	internal static Bitmap PictureBox1_Image
	{
		get
		{
			object @object = Craxs_Rat_PermissionsManager.ResourceManager.GetObject("PictureBox1.Image", Craxs_Rat_PermissionsManager.resourceCulture);
			return (Bitmap)@object;
		}
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x060000AC RID: 172 RVA: 0x00005D48 File Offset: 0x00003F48
	internal static Bitmap PictureBox2_Image
	{
		get
		{
			object @object = Craxs_Rat_PermissionsManager.ResourceManager.GetObject("PictureBox2.Image", Craxs_Rat_PermissionsManager.resourceCulture);
			return (Bitmap)@object;
		}
	}

	// Token: 0x04000014 RID: 20
	private static ResourceManager resourceMan;

	// Token: 0x04000015 RID: 21
	private static CultureInfo resourceCulture;
}
