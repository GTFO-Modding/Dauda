using BepInEx;
using BepInEx.IL2CPP;
using HarmonyLib;
using Il2CppInterop.Runtime.Runtime;
using System;

namespace Dauda
{
    [BepInPlugin("Dauda", "Dauda", "1.0.0")]
    public class EntryPoint : BasePlugin
    {
        public override unsafe void Load()
        {
            // Creates a new harmony instance to allow for patching into methods
            m_Harmony = new Harmony("Dauda");
            // Apply all patches in the current assembly
            m_Harmony.PatchAll();

            // Log to the console that we have applied all patches
            DaudaLogger.Verbose($"Dauda");

            Inject_Dauda_Cough.Yes = Config.Bind<bool>("Cough", "Cough", false).Value;
        }

        private Harmony m_Harmony;
    }
}
