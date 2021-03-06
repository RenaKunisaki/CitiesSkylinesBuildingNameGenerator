using ICities;
using System;
using System.Reflection;
using System.Collections.Generic;
using Moledozer;

namespace WufireNameGenerator
{
  public class LoadingExtension : LoadingExtensionBase
  {
    private List<RedirectCallsState> redirectStates = new List<RedirectCallsState>();

    public override void OnLevelLoaded (LoadMode mode)
    {
      if (mode == LoadMode.LoadGame || mode == LoadMode.NewGame)
      {
        BuildingNameGenerator.Initialize();

        Dictionary<Type, Type> componentRemap = new Dictionary<Type, Type> ();
        componentRemap.Add (typeof(CommercialBuildingAI), typeof(CommercialBuildingAIMod));
        componentRemap.Add (typeof(OfficeBuildingAI), typeof(OfficeBuildingAIMod));
        componentRemap.Add (typeof(IndustrialBuildingAI), typeof(IndustrialBuildingAIMod));
        componentRemap.Add (typeof(ResidentialBuildingAI), typeof(ResidentialBuildingAIMod));

        foreach (var pair in componentRemap)
        {
          redirectStates.Add(NewRedirectState(pair.Key, pair.Value));
        }
      }
    }

    private RedirectCallsState NewRedirectState(Type originalType, Type modType)
    {
      return RedirectionHelper.RedirectCalls(
        originalType.GetMethod("GenerateName", BindingFlags.Instance | BindingFlags.Public),
        modType.GetMethod("GenerateName", BindingFlags.Instance | BindingFlags.Public)
      );
    }

    public override void OnLevelUnloading()
    {
      base.OnLevelUnloading();
      foreach (RedirectCallsState redirectState in redirectStates)
      {
        RedirectionHelper.RevertRedirect(redirectState);
      }
    }
  }
}
