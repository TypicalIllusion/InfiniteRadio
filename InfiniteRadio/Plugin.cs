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
       SynapseMinor = 7,
       SynapsePatch = 2,
       Version = "1.1.0"
   )]
    class Plugin : AbstractPlugin
    {
        private int __patchesCounter;
        public Harmony Harmony { get; private set; }

        [Synapse.Api.Plugin.Config(section = "InfiniteRadio")]
        public static Config Config;

        public override void Load()
        {
            SynapseController.Server.Logger.Info("InfiniteRadio Loaded");
            Patch();
        }

        private void Patch()
        {
            try
            {
                Harmony.PatchAll();
                Logger.Get.Info("Patching patched successfully");
            }
            catch (Exception e)
            {
                Logger.Get.Info($"Patching failed, issues will happen! {e}\n {e.StackTrace}");
                throw;
            }
        }
    }
}
