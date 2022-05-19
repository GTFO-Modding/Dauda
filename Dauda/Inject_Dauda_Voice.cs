using AK;
using GameData;
using HarmonyLib;
using Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dauda
{
    [HarmonyPatch(typeof(PlayerVoiceManager), nameof(PlayerVoiceManager.RegisterPlayerVoice))]
    static class Inject_Dauda_Voice
    {
        static void Postfix(PlayerVoice voice)
        {
            voice.m_charSwitch = SWITCHES.CHARACTER.SWITCH.CH_02;
            DaudaLogger.Error("Dauda!!");
        }
    }
}
