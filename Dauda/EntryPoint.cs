using BepInEx;
using BepInEx.IL2CPP;
using HarmonyLib;
using System;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Runtime;
using UnityEngine;

namespace Dauda
{
    [BepInPlugin("Dauda", "Dauda", "1.0.0")]
    public class EntryPoint : BasePlugin
    {
        private unsafe delegate IntPtr ResourceLoad(IntPtr path, IntPtr type, Il2CppMethodInfo* methodInfo);
        private static ResourceLoad _resourceLoadOriginal;

        // The method that gets called when BepInEx tries to load our plugin
        public override unsafe void Load()
        {
            // Creates a new harmony instance to allow for patching into methods
            m_Harmony = new Harmony("Dauda");
            // Apply all patches in the current assembly
            m_Harmony.PatchAll();

            // Log to the console that we have applied all patches
            DaudaLogger.Verbose($"Dauda");
        }

        private Harmony m_Harmony;
    }
}
