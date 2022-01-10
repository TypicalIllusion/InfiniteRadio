using HarmonyLib;
using InventorySystem.Items.Radio;
using Mirror;
using UnityEngine;

namespace InfiniteRadio.Patches
{
    [HarmonyPatch(typeof(RadioItem), nameof(RadioItem.Update))]
    internal static class InfiniteRadio
    {
        static bool Prefix(RadioItem __instance)
        {
            if (!__instance.IsUsable) return false;

            if (__instance._battery == 0.0) 
                __instance._radio.ForceDisableRadio();
            __instance.SendStatusMessage();
            return false;
        }
    }
}
