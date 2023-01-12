// Decompiled with JetBrains decompiler
// Type: NightVisionCamera.NightVisionCamera
// Assembly: NightVisionCamera, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47653931-C5E3-4AE7-AB47-079AD24F6E85
// Assembly location: C:\Users\cosma\Desktop\NightVisionCamera\BepInEx\plugins\NightVisionCamera-2020.12.9s.dll

using BepInEx;
using BepInEx.Configuration;
using BepInEx.IL2CPP;
using Essentials.Options;
using HarmonyLib;

namespace NightVisionCamera
{
  [BepInPlugin("gg.reactor.nightvisioncamera", null, null)]
  [BepInProcess("Among Us.exe")]
  [BepInDependency]
  public class NightVisionCamera : BasePlugin
  {
    public const string Id = "gg.reactor.nightvisioncamera";
    public static CustomToggleOption impostorHasNormalCamera = CustomOption.AddToggle("Impostor Has Normal Camera", false);

    public Harmony Harmony { get; } = new Harmony("gg.reactor.nightvisioncamera");

    public ConfigEntry<string> Name { get; private set; }

    public virtual void Load()
    {
      CustomOption.ShamelessPlug = (__Null) 0;
      this.Harmony.PatchAll();
    }
  }
}
