using ICities;
using System;
using ColossalFramework.IO;
namespace WufireNameGenerator
{
	public class WufireNameGenerator : IUserMod
	{
		public static string CommercialNameFile {
			get {
				return DataLocation.modsPath + "/WufireNameGenerator/CommercialNames.json";
			}
		}

		public static string OfficeNameFile {
			get {
				return DataLocation.modsPath + "/WufireNameGenerator/OfficeNames.json";
			}
		}

		public static string IndustryNameFile {
			get {
				return DataLocation.modsPath + "/WufireNameGenerator/IndustryNames.json";
			}
		}

		public string Description
		{
			get
			{
				return "Creates new names for industrial, office and commercial buildings. Add your own business names in the mod folder!";
			}
		}
		
		public string Name
		{
			get
			{
				return "Wufire's Business Name Generator";
			}
		}
	}
}

