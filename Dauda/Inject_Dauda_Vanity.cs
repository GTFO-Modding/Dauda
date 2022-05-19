using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Dauda
{
    [HarmonyPatch(typeof(Resources), nameof(Resources.Load), new Type[] { typeof(string), typeof(Il2CppSystem.Type) })]
    static class Inject_Dauda_Vanity
    {
        static void Postfix(string path, UnityEngine.Object __result)
        {
            if (path.Equals("DefaultCharacterLayouts/DefaultCharacterLayouts", StringComparison.Ordinal))
            {
                var layout = new DefaultCharacterLayouts(__result.Pointer);
                layout.m_layout[0] = layout.m_layout[1];
                layout.m_layout[2] = layout.m_layout[1];
                layout.m_layout[3] = layout.m_layout[1];
                DaudaLogger.Error("Dauda! Dauda!");
            }
        }
    }
}
