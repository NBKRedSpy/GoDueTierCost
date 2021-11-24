using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace GoDUETierCost
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    [BepInProcess("Ultimate Dungeoneering.exe")]    //Make sure someone doesn't try to patch the non Ultimate verison.

    public class Plugin : BaseUnityPlugin
    {
        public static ModConfig ModConfig { get; set; }
        public static ManualLogSource Log = null;

        private void Awake()
        {
            Log = Logger;
            ModConfig = new ModConfig(this.Config);

            Harmony.CreateAndPatchAll(typeof(Plugin));

            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_NAME} is loaded!");
        }


        [HarmonyPatch(typeof(GuildTierTree), "ParseData")]
        [HarmonyPostfix]
        static public void PatchCustomUpgradeCosts(GuildTierTree __instance)
        {
            foreach (var group in __instance.groups)
            {
                switch (group.section)
                {
                    case GuildTierGroup.Section.Dungeoneers:
                    case GuildTierGroup.Section.Blessings:
                    case GuildTierGroup.Section.Loot:
                        break;
                    default:
                        //Ignore this group, not one of the guild tiers
                        continue;
                }

                int tier = 1;

                //Note - The tiers seem to only be denoted by their location in the array, with no other indicator.
                foreach (var tierData in group.tierData)
                {

                    int cost;

                    switch (tier)
                    {
                        case 1:
                            if ((cost = ModConfig.Tier1Cost.Value) > -1)
                            {
                                tierData.cost = cost;
                            }
                            break;
                        case 2:
                            if ((cost = ModConfig.Tier2Cost.Value) > -1)
                            {
                                tierData.cost = cost;
                            }
                            break;
                        case 3:
                            if ((cost = ModConfig.Tier3Cost.Value) > -1)
                            {
                                tierData.cost = cost;
                            }
                            break;
                    }

                    Log.LogDebug($"tier {tier} {group.name} {group.section} {tierData.name} {tierData.cost} ");

                    tier++;
                }

            }
        }
    }
}
