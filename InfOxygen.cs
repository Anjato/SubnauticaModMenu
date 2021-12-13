using HarmonyLib;


namespace SubnauticaModMenu
{
    class InfOxygen
    {
        [HarmonyPatch(typeof(Oxygen))]
        [HarmonyPatch("RemoveOxygen")]
        internal class Oxygen_RemoveOxygen_Patch
        {
            [HarmonyPostfix]
            public static void InfOxygen(Oxygen __instance)
            {
                if (__instance is Oxygen && QMod.Config.boolInfOxygen)
                {
                    Oxygen oxygen = __instance;

                    float oxyCap = oxygen.oxygenCapacity;

                    oxygen.oxygenAvailable = oxyCap;
                }
               
            }
        }
    }
}
