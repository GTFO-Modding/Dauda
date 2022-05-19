using HarmonyLib;
using SNetwork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dauda
{
    [HarmonyPatch(typeof(SNet_Core), nameof(SNet_Core.GetBotNickname))]
    static class Inject_Dauda_Nickname
    {
        static void Prefix(ref int characterIndex)
        {
            characterIndex = 1;
            DaudaLogger.Error("Dauda!!?!!?!?!");
        }
    }
}
