using HarmonyLib;


namespace SubnauticaModMenu
{
    class InfHealth
    { 
        [HarmonyPatch(typeof(LiveMixin))]
        [HarmonyPatch("TakeDamage")]
        internal class LiveMixin_TakeDamage_Patch
        {
            [HarmonyPostfix]
            public static void NoDamage(LiveMixin __instance)
            {
                if (__instance is LiveMixin & QMod.Config.boolInfHealth) // can also be stated this way (__instance.GetType() == typeof(LiveMixin)

                {
                    LiveMixin liveMixin = __instance;
                    
                    if (liveMixin.player is Player) ; // can also be stated this way (liveMixin.player.GetType() == typeof(Player)

                    float maxHealth = liveMixin.maxHealth;

                    liveMixin.health = maxHealth;

                }
            }
        }
    }
}
