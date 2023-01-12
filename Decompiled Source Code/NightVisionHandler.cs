// Decompiled with JetBrains decompiler
// Type: NightVisionCamera.NightVisionHandler
// Assembly: NightVisionCamera, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47653931-C5E3-4AE7-AB47-079AD24F6E85
// Assembly location: C:\Users\cosma\Desktop\NightVisionCamera\BepInEx\plugins\NightVisionCamera-2020.12.9s.dll

using Reactor.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnhollowerBaseLib;
using UnityEngine;

namespace NightVisionCamera
{
  public static class NightVisionHandler
  {
    public static Dictionary<byte, PlayerLook> playerLooks = new Dictionary<byte, PlayerLook>();
    public static List<GameObject> overlays = new List<GameObject>();
    public static bool isNightVision = false;
    public static Sprite nightVisionOverlay;
    internal static NightVisionHandler.d_LoadImage iCall_LoadImage;

    static NightVisionHandler()
    {
      Texture2D emptyTexture = GUIExtensions.CreateEmptyTexture(0, 0);
      Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("NightVisionCamera.Resources.night_vision_overlay.png");
      byte[] numArray = new byte[manifestResourceStream.Length];
      manifestResourceStream.Read(numArray, 0, (int) manifestResourceStream.Length);
      NightVisionHandler.LoadImage(emptyTexture, numArray, false);
      NightVisionHandler.nightVisionOverlay = Sprite.Create(emptyTexture, new Rect(0.0f, 0.0f, (float) ((Texture) emptyTexture).width, (float) ((Texture) emptyTexture).height), new Vector2(0.5f, 0.5f), 350f);
    }

    public static bool LoadImage(Texture2D tex, byte[] data, bool markNonReadable)
    {
      if (NightVisionHandler.iCall_LoadImage == null)
        NightVisionHandler.iCall_LoadImage = IL2CPP.ResolveICall<NightVisionHandler.d_LoadImage>("UnityEngine.ImageConversion::LoadImage");
      Il2CppStructArray<byte> il2CppStructArray = Il2CppStructArray<byte>.op_Implicit(data);
      return NightVisionHandler.iCall_LoadImage(((Il2CppObjectBase) tex).Pointer, ((Il2CppObjectBase) il2CppStructArray).Pointer, markNonReadable);
    }

    public static bool isLightsOut()
    {
      foreach (Object myTask in FFGALNAPKCD.LocalPlayer.myTasks)
      {
        if (myTask.name.Contains("FixLightsTask"))
          return true;
      }
      return false;
    }

    public static void UpdateNightVision(bool isWatchingCamera)
    {
      // ISSUE: unable to decompile the method.
    }

    internal delegate bool d_LoadImage(IntPtr tex, IntPtr data, bool markNonReadable);
  }
}
