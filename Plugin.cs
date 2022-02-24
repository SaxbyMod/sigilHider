using BepInEx;
using BepInEx.Logging;
using DiskCardGame;
using HarmonyLib;
using System.Collections.Generic;
using BepInEx.Configuration;


namespace sigilManager
{
	[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
	[BepInDependency(APIGUID, BepInDependency.DependencyFlags.HardDependency)]
	[BepInDependency(CGUID, BepInDependency.DependencyFlags.SoftDependency)]
	[BepInDependency(JGUID, BepInDependency.DependencyFlags.SoftDependency)]
	[BepInDependency(GGUID, BepInDependency.DependencyFlags.SoftDependency)]
	[BepInDependency(VGUID, BepInDependency.DependencyFlags.SoftDependency)]
	[BepInDependency(ZGUID, BepInDependency.DependencyFlags.SoftDependency)]
	public partial class Plugin : BaseUnityPlugin
	{
		public const string APIGUID = "cyantist.inscryption.api";
		public const string CGUID = "cyantist.inscryption.sigiladay";
		public const string ZGUID = "jamesgames.inscryption.zergmod";
		public const string GGUID = "gareth48.inscryption.garethmod";
		public const string VGUID = "extraVoid.inscryption.voidSigils";
		private const string JGUID = "MADH.inscryption.JSONLoader";
		public const string PluginGuid = "zzzzVoid.inscryption.sigil_patcher";
		private const string PluginName = "Void's Sigil Manager";
		private const string PluginVersion = "3.0.0";

		internal static ConfigEntry<bool> configHideUnuseAbilities;
		internal static ConfigEntry<bool> configAddAllSigilsToAct1;
		internal static ConfigEntry<string> configList;



		public static string Directory;
		internal static ManualLogSource Log;


		private void Awake()
		{
			Log = base.Logger;

			Harmony harmony = new(PluginGuid);
			harmony.PatchAll();

			configAddAllSigilsToAct1 = Config.Bind("Add All sigils to act 1", "Add All sigils to Act 1", true, "Should all sigils be added to the act 1 rulebook? This is ran before Hide unused Abilities.");
			configHideUnuseAbilities = Config.Bind("Hide Unused Abilities", "Hide Unused Abilities", false, "Should the sigil manager go thru all abilities on cards, and hide those not used? Off by default.");
			ConfigDefinition definition = new ConfigDefinition("Whitelist to Prevent Abilities from being Hidden", "Whitelist");
			ConfigDescription description = new ConfigDescription("Items on this list will not be removed from the rulebook. Put the RULEBOOK names seperated by a comma, like in the example below. Do not remove the default values, as those are there to prevent other sigils from breaking.");

			configList = Config.Bind(definition, "Dying,Sickness,Burning,Paralysis", description);
		}

		private void Start()
        {
			if (configAddAllSigilsToAct1.Value)
            {
				var card = ScriptableObjectLoader<CardInfo>.AllData;
				var abilities = ScriptableObjectLoader<AbilityInfo>.AllData;
				var abilitiesOnCards = new List<Ability>();

				//Search all cards for abilities and add them to the list
				for (int index = 0; index < card.Count; index++)
				{
					CardInfo info = card[index];
					for (int index2 = 0; index2 < info.DefaultAbilities.Count; index2++)
					{
						abilitiesOnCards.Add(info.DefaultAbilities[index2]);
					}
				}

				//Go through the main list and if it can't find an ability, hide it
				for (int index = 0; index < abilities.Count; index++)
				{
					if (abilitiesOnCards.Contains(abilities[index].ability) && !abilities[index].metaCategories.Contains(AbilityMetaCategory.Part1Rulebook) && abilities[index].pixelIcon != null)
					{
						abilities[index].metaCategories.Add(AbilityMetaCategory.Part1Rulebook);
					}
				}
			}
		}

		[HarmonyPatch(typeof(LoadingScreenManager), "LoadGameData")]
		public class LoadingScreenManager_LoadGameData
		{
			public static void Postfix()
			{
				if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(ZGUID))
				{
					Log.LogMessage("Do I see The other DLL? I do, I do see the other DLL! (zerg)");
					SigilReplacer.DoZergStuff();
				}
				else
				{
					Log.LogMessage("Do I see the Zerg DLL? No, no I do not");

				}

				if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(CGUID))
				{
					Log.LogMessage("Do I see The other DLL? I do, I do see the other DLL! (Sigil a day)");
					SigilReplacer.DoBloodGuzzler();
					SigilReplacer.DoBonePicker();
					SigilReplacer.DoLeech();
					SigilReplacer.DoNutritious();
					SigilReplacer.DoPoisonous();
					SigilReplacer.DoRegen1();
					SigilReplacer.DoRegen2();
					SigilReplacer.DoRegen3();
					SigilReplacer.DoRegenFull();
					SigilReplacer.DoThickShell();
					SigilReplacer.DoTransient();
				}
				else
				{
					Log.LogMessage("Do I see the Sigil a Day DLL? No, no I do not");
				}

				if (configHideUnuseAbilities.Value == true)
				{
					SigilHider.HideUnuseSigils();
				}
			}
		}
	}
}