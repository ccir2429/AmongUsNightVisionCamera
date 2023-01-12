// Decompiled with JetBrains decompiler
// Type: NightVisionCamera.VersionStartPatch
// Assembly: NightVisionCamera, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47653931-C5E3-4AE7-AB47-079AD24F6E85
// Assembly location: C:\Users\cosma\Desktop\NightVisionCamera\BepInEx\plugins\NightVisionCamera-2020.12.9s.dll

using HarmonyLib;

namespace NightVisionCamera
{
  [HarmonyPatch(typeof (BOCOFLHKCOJ), "Start")]
  public static class VersionStartPatch
  {
    private static void Postfix(BOCOFLHKCOJ __instance)
    {
      if (__instance.text.Text.Contains("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n"))
        __instance.text.Text += "\n[FFFFFFFF]- Loaded NightVisionCam v1.0\n  by [FCCE03FF]Eisbison";
      else
        __instance.text.Text += "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n[FFFFFFFF]- Loaded NightVisionCam v1.0\n  by [FCCE03FF]Eisbison\n";
    }
  }
}
