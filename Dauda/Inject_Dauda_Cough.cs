using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dauda
{
    [HarmonyPatch(typeof(PlayerVoice), nameof(PlayerVoice.SayLine))]
    internal static class Inject_Dauda_Cough
    {
        internal static bool Yes = false;

        static void Prefix(ref uint eventID)
        {
            if (Yes)
            {
                eventID = 2514479542;
            }
        }
    }
}
