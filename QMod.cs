using System.Reflection;
using HarmonyLib;
using QModManager.API.ModLoading;
using Logger = QModManager.Utility.Logger;
using SMLHelper.V2.Json;
using SMLHelper.V2.Options.Attributes;
using SMLHelper.V2.Handlers;

namespace SubnauticaModMenu
{
    [QModCore]
    public static class QMod
    {
        
        // Set up an instance of the Config class, allowing the player to configure our mod
        internal static Config Config { get; } = OptionsPanelHandler.Main.RegisterModOptions<Config>();

        [QModPatch]
        public static void Patch()
        {

            Config.Load(); // loading from disk, or populating config.json with default values if not found
            Config.boolInfOxygen = false; // overriding the default value
            Config.boolInfHealth = false; // overriding the default value
            Config.Save();
         
            var assembly = Assembly.GetExecutingAssembly();
            var modName = ($"SubnauticaModMenu.Anjato_{assembly.GetName().Name}");
            Logger.Log(Logger.Level.Info, $"Patching {modName}");
            Harmony harmony = new Harmony(modName);
            harmony.PatchAll(assembly);
            Logger.Log(Logger.Level.Info, "Patched successfully!");

        }
    }

    // Set up the Mod menu
    [Menu("Cheat Menu")]
    public class Config : ConfigFile
    {
        [Toggle("Infinite Health")]
        public bool boolInfHealth;

        [Toggle("Infinite Oxygen")]    
        public bool boolInfOxygen;

        [Toggle("Infinite Hunger")]
        public bool boolInfHunger;

        [Toggle("Infinite Thirst")]
        public bool boolInfThirst;
    }

}
