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

    public static string ResidentialNameFile {
      get {
        return DataLocation.modsPath + "/WufireNameGenerator/ResidentialNames.json";
      }
    }

    public string Description
    {
      get
      {
        return "New names for residential, industrial, office and commercial buildings. Add your own business names in the mods folder!";
      }
    }

    public string Name
    {
      get
      {
        return "Custom Building Name Generator";
      }
    }
  }
}
