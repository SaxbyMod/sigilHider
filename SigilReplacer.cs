using System;
using System.Collections.Generic;
using System.Text;
using BepInEx;
using BepInEx.Logging;
using DiskCardGame;
using HarmonyLib;
using APIPlugin;

namespace sigilManager
{
    internal class SigilReplacer
    {
		public static void DoZergStuff()
		{
			Ability port;
			Ability original;

			port = APIPlugin.AbilityIdentifier.GetAbilityIdentifier(Plugin.VGUID, "Fish Hook").id;
			original = APIPlugin.AbilityIdentifier.GetAbilityIdentifier(Plugin.ZGUID, "Fish Hook").id;
			var card = ScriptableObjectLoader<CardInfo>.AllData;
			var ability = NewAbility.abilities;

			Plugin.Log.LogMessage("Found Original Ability: Fish Hook");

			for (int index = 0; index < card.Count; index++)
			{
				CardInfo info = card[index];
				if (info.HasAbility(port))
				{
					Plugin.Log.LogMessage("Switching Abilities on Card: " + info.name);
					info.DefaultAbilities.Remove(port);
					info.DefaultAbilities.Add(original);
				}
			}

			for (int index = 0; index < ability.Count; index++)
			{
				AbilityInfo info = ability[index].info;
				if (info.ability == port)
				{
					info.metaCategories.Clear();
					info.powerLevel = 8;
					info.opponentUsable = false;
					Plugin.Log.LogMessage("Removing void's version of the ability from the rulebook, totems, and Leshy: " + info.rulebookName);
				}
			}
		}

		public static void DoBloodGuzzler()
		{
			Ability port;
			Ability original;

			port = APIPlugin.AbilityIdentifier.GetAbilityIdentifier(Plugin.VGUID, "BloodGuzzler").id;
			original = APIPlugin.AbilityIdentifier.GetAbilityIdentifier(Plugin.CGUID, "BloodGuzzler").id;
			var card = ScriptableObjectLoader<CardInfo>.AllData;
			var ability = NewAbility.abilities;

			Plugin.Log.LogMessage("Found Original Ability: BloodGuzzler");

			for (int index = 0; index < card.Count; index++)
			{
				CardInfo info = card[index];
				if (info.HasAbility(port))
				{
					Plugin.Log.LogMessage("Switching Abilities on Card: " + info.name);
					info.DefaultAbilities.Remove(port);
					info.DefaultAbilities.Add(original);
				}
			}

			for (int index = 0; index < ability.Count; index++)
			{
				AbilityInfo info = ability[index].info;
				if (info.ability == port)
				{
					info.metaCategories.Clear();
					info.powerLevel = 8;
					info.opponentUsable = false;
					Plugin.Log.LogMessage("Removing void's version of the ability from the rulebook, totems, and Leshy: " + info.rulebookName);
				}
			}
		}

		public static void DoLeech()
		{
			Ability port;
			Ability original;

			port = APIPlugin.AbilityIdentifier.GetAbilityIdentifier(Plugin.VGUID, "Leech").id;
			original = APIPlugin.AbilityIdentifier.GetAbilityIdentifier(Plugin.CGUID, "Leech").id;
			var card = ScriptableObjectLoader<CardInfo>.AllData;
			var ability = NewAbility.abilities;

			Plugin.Log.LogMessage("Found Original Ability: Leech");

			for (int index = 0; index < card.Count; index++)
			{
				CardInfo info = card[index];
				if (info.HasAbility(port))
				{
					Plugin.Log.LogMessage("Switching Abilities on Card: " + info.name);
					info.DefaultAbilities.Remove(port);
					info.DefaultAbilities.Add(original);
				}
			}

			for (int index = 0; index < ability.Count; index++)
			{
				AbilityInfo info = ability[index].info;
				if (info.ability == port)
				{
					info.metaCategories.Clear();
					info.powerLevel = 8;
					info.opponentUsable = false;
					Plugin.Log.LogMessage("Removing void's version of the ability from the rulebook, totems, and Leshy: " + info.rulebookName);
				}
			}
		}

		public static void DoRegen1()
		{
			Ability port;
			Ability original;

			port = APIPlugin.AbilityIdentifier.GetAbilityIdentifier(Plugin.VGUID, "Regen 1").id;
			original = APIPlugin.AbilityIdentifier.GetAbilityIdentifier(Plugin.CGUID, "Regen 1").id;
			var card = ScriptableObjectLoader<CardInfo>.AllData;
			var ability = NewAbility.abilities;

			Plugin.Log.LogMessage("Found Original Ability: Regen 1");

			for (int index = 0; index < card.Count; index++)
			{
				CardInfo info = card[index];
				if (info.HasAbility(port))
				{
					Plugin.Log.LogMessage("Switching Abilities on Card: " + info.name);
					info.DefaultAbilities.Remove(port);
					info.DefaultAbilities.Add(original);
				}
			}

			for (int index = 0; index < ability.Count; index++)
			{
				AbilityInfo info = ability[index].info;
				if (info.ability == port)
				{
					info.metaCategories.Clear();
					info.powerLevel = 8;
					info.opponentUsable = false;
					Plugin.Log.LogMessage("Removing void's version of the ability from the rulebook, totems, and Leshy: " + info.rulebookName);
				}
			}
		}

		public static void DoRegen2()
		{
			Ability port;
			Ability original;

			port = APIPlugin.AbilityIdentifier.GetAbilityIdentifier(Plugin.VGUID, "Regen 2").id;
			original = APIPlugin.AbilityIdentifier.GetAbilityIdentifier(Plugin.CGUID, "Regen 2").id;
			var card = ScriptableObjectLoader<CardInfo>.AllData;
			var ability = NewAbility.abilities;

			Plugin.Log.LogMessage("Found Original Ability: Regen 2");

			for (int index = 0; index < card.Count; index++)
			{
				CardInfo info = card[index];
				if (info.HasAbility(port))
				{
					Plugin.Log.LogMessage("Switching Abilities on Card: " + info.name);
					info.DefaultAbilities.Remove(port);
					info.DefaultAbilities.Add(original);
				}
			}

			for (int index = 0; index < ability.Count; index++)
			{
				AbilityInfo info = ability[index].info;
				if (info.ability == port)
				{
					info.metaCategories.Clear();
					info.powerLevel = 8;
					info.opponentUsable = false;
					Plugin.Log.LogMessage("Removing void's version of the ability from the rulebook, totems, and Leshy: " + info.rulebookName);
				}
			}
		}

		public static void DoRegen3()
		{
			Ability port;
			Ability original;

			port = APIPlugin.AbilityIdentifier.GetAbilityIdentifier(Plugin.VGUID, "Regen 3").id;
			original = APIPlugin.AbilityIdentifier.GetAbilityIdentifier(Plugin.CGUID, "Regen 3").id;
			var card = ScriptableObjectLoader<CardInfo>.AllData;
			var ability = NewAbility.abilities;

			Plugin.Log.LogMessage("Found Original Ability: Regen 3");

			for (int index = 0; index < card.Count; index++)
			{
				CardInfo info = card[index];
				if (info.HasAbility(port))
				{
					Plugin.Log.LogMessage("Switching Abilities on Card: " + info.name);
					info.DefaultAbilities.Remove(port);
					info.DefaultAbilities.Add(original);
				}
			}

			for (int index = 0; index < ability.Count; index++)
			{
				AbilityInfo info = ability[index].info;
				if (info.ability == port)
				{
					info.metaCategories.Clear();
					info.powerLevel = 8;
					info.opponentUsable = false;
					Plugin.Log.LogMessage("Removing void's version of the ability from the rulebook, totems, and Leshy: " + info.rulebookName);
				}
			}
		}

		public static void DoRegenFull()
		{
			Ability port;
			Ability original;

			port = APIPlugin.AbilityIdentifier.GetAbilityIdentifier(Plugin.VGUID, "Regen").id;
			original = APIPlugin.AbilityIdentifier.GetAbilityIdentifier(Plugin.CGUID, "Regen").id;
			var card = ScriptableObjectLoader<CardInfo>.AllData;
			var ability = NewAbility.abilities;

			Plugin.Log.LogMessage("Found Original Ability: Regen Full");

			for (int index = 0; index < card.Count; index++)
			{
				CardInfo info = card[index];
				if (info.HasAbility(port))
				{
					Plugin.Log.LogMessage("Switching Abilities on Card: " + info.name);
					info.DefaultAbilities.Remove(port);
					info.DefaultAbilities.Add(original);
				}
			}

			for (int index = 0; index < ability.Count; index++)
			{
				AbilityInfo info = ability[index].info;
				if (info.ability == port)
				{
					info.metaCategories.Clear();
					info.powerLevel = 8;
					info.opponentUsable = false;
					Plugin.Log.LogMessage("Removing void's version of the ability from the rulebook, totems, and Leshy: " + info.rulebookName);
				}
			}
		}

		public static void DoPoisonous()
		{
			Ability port;
			Ability original;

			port = APIPlugin.AbilityIdentifier.GetAbilityIdentifier(Plugin.VGUID, "Poisonous").id;
			original = APIPlugin.AbilityIdentifier.GetAbilityIdentifier(Plugin.CGUID, "Poisonous").id;
			var card = ScriptableObjectLoader<CardInfo>.AllData;
			var ability = NewAbility.abilities;

			Plugin.Log.LogMessage("Found Original Ability: Poisonous");

			for (int index = 0; index < card.Count; index++)
			{
				CardInfo info = card[index];
				if (info.HasAbility(port))
				{
					Plugin.Log.LogMessage("Switching Abilities on Card: " + info.name);
					info.DefaultAbilities.Remove(port);
					info.DefaultAbilities.Add(original);
				}
			}

			for (int index = 0; index < ability.Count; index++)
			{
				AbilityInfo info = ability[index].info;
				if (info.ability == port)
				{
					info.metaCategories.Clear();
					info.powerLevel = 8;
					info.opponentUsable = false;
					Plugin.Log.LogMessage("Removing void's version of the ability from the rulebook, totems, and Leshy: " + info.rulebookName);
				}
			}
		}

		public static void DoThickShell()
		{
			Ability port;
			Ability original;

			port = APIPlugin.AbilityIdentifier.GetAbilityIdentifier(Plugin.VGUID, "Thick Shell").id;
			original = APIPlugin.AbilityIdentifier.GetAbilityIdentifier(Plugin.CGUID, "Thick Shell").id;
			var card = ScriptableObjectLoader<CardInfo>.AllData;
			var ability = NewAbility.abilities;

			Plugin.Log.LogMessage("Found Original Ability: Thick Shell");

			for (int index = 0; index < card.Count; index++)
			{
				CardInfo info = card[index];
				if (info.HasAbility(port))
				{
					Plugin.Log.LogMessage("Switching Abilities on Card: " + info.name);
					info.DefaultAbilities.Remove(port);
					info.DefaultAbilities.Add(original);
				}
			}

			for (int index = 0; index < ability.Count; index++)
			{
				AbilityInfo info = ability[index].info;
				if (info.ability == port)
				{
					info.metaCategories.Clear();
					info.powerLevel = 8;
					info.opponentUsable = false;
					Plugin.Log.LogMessage("Removing void's version of the ability from the rulebook, totems, and Leshy: " + info.rulebookName);
				}
			}
		}

		public static void DoBonePicker()
		{
			Ability port;
			Ability original;

			port = APIPlugin.AbilityIdentifier.GetAbilityIdentifier(Plugin.VGUID, "Bone Picker").id;
			original = APIPlugin.AbilityIdentifier.GetAbilityIdentifier(Plugin.CGUID, "Bone Picker").id;
			var card = ScriptableObjectLoader<CardInfo>.AllData;
			var ability = NewAbility.abilities;

			Plugin.Log.LogMessage("Found Original Ability: Bone Picker");

			for (int index = 0; index < card.Count; index++)
			{
				CardInfo info = card[index];
				if (info.HasAbility(port))
				{
					Plugin.Log.LogMessage("Switching Abilities on Card: " + info.name);
					info.DefaultAbilities.Remove(port);
					info.DefaultAbilities.Add(original);
				}
			}

			for (int index = 0; index < ability.Count; index++)
			{
				AbilityInfo info = ability[index].info;
				if (info.ability == port)
				{
					info.metaCategories.Clear();
					info.powerLevel = 8;
					info.opponentUsable = false;
					Plugin.Log.LogMessage("Removing void's version of the ability from the rulebook, totems, and Leshy: " + info.rulebookName);
				}
			}
		}
		public static void DoNutritious()
		{
			Ability port;
			Ability original;

			port = APIPlugin.AbilityIdentifier.GetAbilityIdentifier(Plugin.VGUID, "Nutritious").id;
			original = APIPlugin.AbilityIdentifier.GetAbilityIdentifier(Plugin.CGUID, "Nutritious").id;
			var card = ScriptableObjectLoader<CardInfo>.AllData;
			var ability = NewAbility.abilities;

			Plugin.Log.LogMessage("Found Original Ability: Nutritious");

			for (int index = 0; index < card.Count; index++)
			{
				CardInfo info = card[index];
				if (info.HasAbility(port))
				{
					Plugin.Log.LogMessage("Switching Abilities on Card: " + info.name);
					info.DefaultAbilities.Remove(port);
					info.DefaultAbilities.Add(original);
				}
			}

			for (int index = 0; index < ability.Count; index++)
			{
				AbilityInfo info = ability[index].info;
				if (info.ability == port)
				{
					info.metaCategories.Clear();
					info.powerLevel = 8;
					info.opponentUsable = false;
					Plugin.Log.LogMessage("Removing void's version of the ability from the rulebook, totems, and Leshy: " + info.rulebookName);
				}
			}
		}

		public static void DoTransient()
		{
			Ability port;
			Ability original;

			port = APIPlugin.AbilityIdentifier.GetAbilityIdentifier(Plugin.VGUID, "Transient").id;
			original = APIPlugin.AbilityIdentifier.GetAbilityIdentifier(Plugin.CGUID, "Transient").id;
			var card = ScriptableObjectLoader<CardInfo>.AllData;
			var ability = NewAbility.abilities;

			Plugin.Log.LogMessage("Found Original Ability: Transient");

			for (int index = 0; index < card.Count; index++)
			{
				CardInfo info = card[index];
				if (info.HasAbility(port))
				{
					Plugin.Log.LogMessage("Switching Abilities on Card: " + info.name);
					info.DefaultAbilities.Remove(port);
					info.DefaultAbilities.Add(original);
				}
			}

			for (int index = 0; index < ability.Count; index++)
			{
				AbilityInfo info = ability[index].info;
				if (info.ability == port)
				{
					info.metaCategories.Clear();
					info.powerLevel = 8;
					info.opponentUsable = false;
					Plugin.Log.LogMessage("Removing void's version of the ability from the rulebook, totems, and Leshy: " + info.rulebookName);
				}
			}
		}
	}
}
