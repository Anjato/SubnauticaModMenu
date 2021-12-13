using HarmonyLib;


namespace SubnauticaModMenu
{
    class InfVitals
    {
        [HarmonyPatch(typeof(Survival))]
        [HarmonyPatch("UpdateStats")]
        internal class Survival_UpdateHunger_Patch
        {
            [HarmonyPostfix]
            public static void InfVitals(Survival __instance)
            {
                if (__instance is Survival && QMod.Config.boolInfThirst)
                {
                    Survival survival = __instance;

                    survival.water = 100f;
                    
                }

                if (__instance is Survival && QMod.Config.boolInfHunger)
                {
                    Survival survival = __instance;

                    survival.food = 100f;

                }
            }
        }
    }
}
