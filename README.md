# GoDUE Tier Cost
Mod for Guild of Dungeoneering Ultimate Edition which allows the user to customize the build tier costs.

Note - this is only for the Ultimate Edition.  

Want to change the cost of the buildings to the Classic version?  Want them to cost nothing at all?  You can do that!

By default, this mod changes the tier costs to the Classic values of:

Tier 1: 50  
Tier 2: 500  
Tier 3: 2000

These values can be configured in the mod's config file.

# Installation

1. Download the BepInEx utility from https://github.com/BepInEx/BepInEx/releases/download/v5.4.17/BepInEx_x64_5.4.17.0.zip
2. Extract the contents of the zip file into the game's directory (which is GuildofDungeoneeringUlt)
	- There should now be a BepinEx folder in the GuildofDungeoneeringUlt game directory.
3. Run the game and exit once the main screen is shown.
4. If BepInEx ran correctly, there should now be BepInEx\plugins directory in the game directory.
5. Download the latest tier cost mod (com.NBKRedSpy.GoDUETierCost.dll) from here:  https://github.com/NBKRedSpy/GoDueTierCost/releases
6. Copy the com.NBKRedSpy.GoDUETierCost.dll into the BepInEx\plugins directory.
7. Run the game.

The building costs should now reflect the new values.

# Optional Configuration
After running the game with the plugin, there will be a config file called com.NBKRedSpy.GoDUETierCost.cfg located in the 
BepInEx\config\ folder which allows the user to customize the tier costs.  

When the game is not running, edit the file in notepad and set the gold caps to whatever value is desired.  

Use -1 to use the game's tier cost instead.

# Uninstalling

## Uninstall This Mod Only
If you wish to uninstall just this mod, but want to be able to use other mods, delete the file com.NBKRedSpy.GoDUETierCost.dll from the BepInEx\plugins\ folder.  

## Full Uninstall
If you wish to fully uninstall the mod and the mod injector (BepInEx, which is what allows the mod to work), delete the following:
* BepInEx folder
* changelog.txt
* winhttp.dll

If you accidently delete other files, go to your game library in Steam or Epic and use the Verify command.  
This will scan all the game's files and re-download any files that are missing or don't match the expected version.







