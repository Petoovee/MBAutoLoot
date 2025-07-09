using HarmonyLib;
using TaleWorlds.CampaignSystem.Inventory;
using TaleWorlds.CampaignSystem.ViewModelCollection.Inventory;

namespace AutoLoot.Patches
{
    [HarmonyPatch(typeof(SPInventoryVM))]
    public class AutoLootPatch
    {
        [HarmonyPrefix]
        [HarmonyPatch("ExecuteDone")]
        public static bool PrefixDone(ref SPInventoryVM __instance)
        {
            if (InventoryManager.Instance.CurrentMode == InventoryMode.Loot)
            {
                // Only AutoLoot if we are Looting
            }

            return true;
        }
    }
}