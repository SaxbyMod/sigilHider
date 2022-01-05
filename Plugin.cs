using BepInEx;
using BepInEx.Logging;
using DiskCardGame;
using HarmonyLib;
using System.Collections.Generic;
using BepInEx.Configuration;


namespace sigilReplacer
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
		private const string PluginVersion = "1.0.0";

		internal static ConfigEntry<bool> configHideUnuseAbilities;

		internal static ConfigEntry<string> configList;



		public static string Directory;
		internal static ManualLogSource Log;


		private void Awake()
		{
			Log = base.Logger;

			Harmony harmony = new(PluginGuid);
			harmony.PatchAll();

			configHideUnuseAbilities = Config.Bind("Hide Unused Abilities", "Hide Unused Abilities", false, "Should the sigil manager go thru all abilities on cards, and hide those not used? Off by default.");
			ConfigDefinition definition = new ConfigDefinition("Whitelist to Prevent Abilities from being Hidden", "Whitelist");
			ConfigDescription description = new ConfigDescription("Items on this list will not be removed from the rulebook. Put the RULEBOOK names seperated by a comma, like in the example below. Do not remove the default values, as those are there to prevent other sigils from breaking.");

			configList = Config.Bind(definition, "Dying,Sickness,Burning", description);
		}

		private void Start()
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