// Decompiled with JetBrains decompiler
// Type: NightVisionCamera.DeadBodyCreationColorPatch
// Assembly: NightVisionCamera, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47653931-C5E3-4AE7-AB47-079AD24F6E85
// Assembly location: C:\Users\cosma\Desktop\NightVisionCamera\BepInEx\plugins\NightVisionCamera-2020.12.9s.dll

using HarmonyLib;
using System;
using UnhollowerBaseLib;
using UnityEngine;

namespace NightVisionCamera
{
  [HarmonyPatch(typeof (FFGALNAPKCD), "SetPlayerMaterialColors", new Type[] {typeof (Renderer)})]
  public class DeadBodyCreationColorPatch
  {
    private static void Postfix(FFGALNAPKCD __instance, [HarmonyArgument(0)] Renderer rend)
    {
      if (NightVisionCamera.NightVisionCamera.impostorHasNormalCamera.GetValue() && FFGALNAPKCD.LocalPlayer.Data.DAPKNDBLKIA || !NightVisionHandler.isNightVision || ((Component) rend).gameObject.tag != "DeadBody")
        return;
      PlayerLook playerLook = PlayerLook.nightVisionLook();
      rend.material.SetColor("_BackColor", Color32.op_Implicit(((Il2CppArrayBase<Color32>) LOCPGOACAJF.KBMIDEGKPLP)[(int) playerLook.colorId]));
      rend.material.SetColor("_BodyColor", Color32.op_Implicit(((Il2CppArrayBase<Color32>) LOCPGOACAJF.OPKIKLENHFA)[(int) playerLook.colorId]));
    }
  }
}
