using Synapse.Api.Plugin;
using HarmonyLib;
using System;
using Synapse.Api;

namespace InfiniteRadio
{
    [PluginInformation(
       Author = "TypicalIllusion",
       Description = "InfiniteRadio",
       LoadPriority = 0,
       Name = "InfiniteRadio",
       SynapseMajor = 2,
       SynapseMinor = 8,
       SynapsePatch = 0,
       Version = "1.1.0"
   )]
    class Plugin : AbstractPlugin
    {
        public override void Load()
        {
            Patch();
            base.Load();
        }

        private void Patch()
        {
            try
            {
                var instance = new Harmony("InfiniteRadio.Patches");
                instance.PatchAll();
                Logger.Get.Info("Infite Radio patched successfully");
            }
            catch (Exception e)
            {
                Logger.Get.Info($"Patching failed, issues will happen! {e}\n {e.StackTrace}");
                throw;
            }
        }
    }
}
