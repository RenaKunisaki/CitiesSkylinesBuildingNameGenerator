// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using ColossalFramework.Globalization;
using ColossalFramework.Math;
using System;
using System.Collections.Generic;
namespace WufireNameGenerator
{
	internal class OfficeBuildingNameMod : OfficeBuildingAI
	{
		//
		// Methods
		//
		public override string GenerateName (ushort buildingID, InstanceID caller)
		{
			string result;
			if (this.m_info.m_prefabDataIndex == -1)
			{
				result = null;
			}
			else
			{
				Randomizer randomizer = new Randomizer ((int)buildingID);
				Random random = new Random ((int)buildingID);
				string text = PrefabCollection<BuildingInfo>.PrefabName ((uint)this.m_info.m_prefabDataIndex);
				uint num = Locale.CountUnchecked ("BUILDING_NAME", text);
				if (num != 0u)
				{
					result = Locale.Get ("BUILDING_NAME", text, randomizer.Int32 (num));
				}
				else
				{
					List<string> list = new List<string> (new string[]
					                                      {
						"The",
						"Business",
						"City",
						"Competent",
						"Digital",
						"Eastern",
						"Efficient",
						"Ethical",
						"Global",
						"Goldberg",
						"Licensed",
						"Lincoln's",
						"National",
						"Pro",
						"Pyramid",
						"Skilled",
						"Smith's",
						"Tactful",
						"Trident",
						"Western",
						"World"
					});
					List<string> list2 = new List<string> (new string[]
					                                       {
						"Accounting",
						"Ad",
						"Banking",
						"Capital",
						"Design",
						"Energy",
						"Finance",
						"Fraud",
						"Insurance",
						"Law",
						"News",
						"Paperwork",
						"Publishing",
						"Sales",
						"Service",
						"Security",
						"Systems",
						"Tech",
						"Telecom",
						"Travel"
					});
					List<string> list3 = new List<string> (new string[]
					                                       {
						"Agency",
						"Alliance",
						"Business",
						"Company",
						"Corporation",
						"Conglomerate",
						"Enterprise",
						"Firm",
						"Group",
						"Inc.",
						"Institute",
						"Limited",
						"Office",
						"Planning",
						"Services",
						"Solutions"
					});
					int num2 = random.Next (list.Count);
					int num3 = random.Next (list2.Count);
					int num4 = random.Next (list3.Count);
					string text2 = list[num2];
					string text3 = list2[num3];
					string text4 = list3[num4];
					string text5 = string.Concat (new string[]
					                              {
						text2,
						" ",
						text3,
						" ",
						text4
					});
					result = text5;
				}
			}
			return result;
		}
	}
}
