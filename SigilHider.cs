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
    internal class SigilHider
    {

        public static void HideUnuseSigils()
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


            var split = Plugin.configList.Value.Split(',');

            //Go through the main list and if it can't find an ability, hide it
            for (int index = 0; index < abilities.Count; index++)
            {
                //Make sure to add the exceptions to the list!
                string abilityName = abilities[index].rulebookName;
                for (int index2 = 0; index2 < split.Length; index2++)
                {
                    if (split[index2] == abilityName)
                    {
                        Plugin.Log.LogWarning("Found config to not hide the following ability: " + abilityName);
                        abilitiesOnCards.Add(abilities[index].ability);
                    }
                }
                if (!abilitiesOnCards.Contains(abilities[index].ability))
                {
                    abilities[index].metaCategories.Clear();
                    abilities[index].powerLevel = -10;
                    abilities[index].opponentUsable = false;
                    Plugin.Log.LogMessage("Did not find the following ability on any card, hiding it: " + abilities[index].rulebookName);
                }
            }
        }
    }
}
