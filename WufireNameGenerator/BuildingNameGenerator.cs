// ------------------------------------------------------------------------------//  <autogenerated>//      This code was generated by a tool.//      Mono Runtime Version: 4.0.30319.1// //      Changes to this file may cause incorrect behavior and will be lost if //      the code is regenerated.//  </autogenerated>// ------------------------------------------------------------------------------using System;using ICities;using System.Collections.Generic;using ColossalFramework.Math;namespace WufireNameGenerator{	public class BuildingNameGenerator	{		const int MAX_BUILDING_NAME_LENGTH = 32;		private static BuildingNameData bnd;		public BuildingNameGenerator ()		{		}		public static void Initialize() {			bnd = new BuildingNameData();		}		public static string GenerateName(ItemClass.Service service, Randomizer randomizer) {			return _generateNameHelper(bnd.BuildingNameDataForSubService(service.ToString()), randomizer);		}		public static string GenerateName(ItemClass.SubService subservice, Randomizer randomizer) {			return _generateNameHelper(bnd.BuildingNameDataForSubService(subservice.ToString()), randomizer);		}		private static string _generateNameHelper(List<NamePart> nameParts, Randomizer randomizer) {			int index = 0;			string nameString = nameParts[index].nameList[randomizer.Int32((uint)nameParts[index].nameList.Count)] + " ";			index = nameParts.Count - 1;			string postString = nameParts[index].nameList[randomizer.Int32((uint)nameParts[index].nameList.Count)];			for (int i = 1; i < nameParts.Count - 1; i++) {				NamePart part = nameParts[i];				if(part.isOptional) {					if (randomizer.Int32(10) > 5) {						continue;					}				}				string newWord = part.nameList[randomizer.Int32((uint)part.nameList.Count)] + " ";				if (nameString.Length + newWord.Length + postString.Length <= MAX_BUILDING_NAME_LENGTH) {					nameString += newWord;				} else {					break;				}			}			nameString += postString;			return nameString;		}	}}