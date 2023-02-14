using HarmonyLib;
using InventorySystem.Items.Radio;

namespace InfiniteRadio.Patches
{
    [HarmonyPatch(typeof(RadioItem), nameof(RadioItem.Update))]
    internal static class InfiniteRadio
    {
        [HarmonyPrefix]
        static bool Update(RadioItem __instance)
        {
            return false;
        }
    }
}
