// Decompiled with JetBrains decompiler
// Type: NightVisionCamera.PlanetSurveillanceMinigameClosePatch
// Assembly: NightVisionCamera, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47653931-C5E3-4AE7-AB47-079AD24F6E85
// Assembly location: C:\Users\cosma\Desktop\NightVisionCamera\BepInEx\plugins\NightVisionCamera-2020.12.9s.dll

using HarmonyLib;

namespace NightVisionCamera
{
  [HarmonyPatch(typeof (CFMGBHBGOOC), "OnDestroy")]
  public class PlanetSurveillanceMinigameClosePatch
  {
    private static void Postfix(CFMGBHBGOOC __instance)
    {
      if (NightVisionCamera.NightVisionCamera.impostorHasNormalCamera.GetValue() && FFGALNAPKCD.LocalPlayer.Data.DAPKNDBLKIA)
        return;
      NightVisionHandler.UpdateNightVision(false);
    }
  }
}
