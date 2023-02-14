using HarmonyLib;
using Neuron.Core.Plugins;
using Synapse3.SynapseModule;
using System;

namespace InfiniteRadio;

[Plugin(
    Name = "InfiniteRadion",
    Description = "No more battery for radios!",
    Version = "2.0.0",
    Author = "VT"
)]
class InfiniteRadionPlugin : Plugin
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
        }
        catch (Exception e)
        {
            SynapseLogger<InfiniteRadionPlugin>.Error($"Patching failed, issues will happen! {e}\n {e.StackTrace}");
        }
    }
}
