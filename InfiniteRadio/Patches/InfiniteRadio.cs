using HarmonyLib;

namespace InfiniteRadio.Patches
{
    [HarmonyPatch(typeof(Radio))]
    [HarmonyPatch(nameof(Radio.UseBattery))]
    internal static class InfiniteRadio
    {
        static bool Prefix(Radio __instance)
        {
            return false;
        }
    }
}
