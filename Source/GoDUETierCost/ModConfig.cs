using BepInEx.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoDUETierCost
{
    public class ModConfig
    {

        public ConfigEntry<int> Tier1Cost { get; set; }
        public ConfigEntry<int> Tier2Cost { get; set; }
        public ConfigEntry<int> Tier3Cost{ get; set; }

        public ModConfig(ConfigFile config)
        {
            Tier1Cost = config.Bind("Tier Cost", "Tier1Cost", 50,
                "The cost for Tier 1 upgrades.  Set to -1 for the game's default.");

            Tier2Cost = config.Bind("Tier Cost", "Tier2Cost", 500,
                "The cost for Tier 2 upgrades.  Set to -1 for the game's default.");

            Tier3Cost = config.Bind("Tier Cost", "Tier3Cost", 2000,
                "The cost for Tier 2 upgrades.  Set to -1 for the game's default.");
        }
    }
}
