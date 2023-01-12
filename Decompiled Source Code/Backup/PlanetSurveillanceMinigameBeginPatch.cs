// Decompiled with JetBrains decompiler
// Type: NightVisionCamera.PlanetSurveillanceMinigameBeginPatch
// Assembly: NightVisionCamera, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47653931-C5E3-4AE7-AB47-079AD24F6E85
// Assembly location: C:\Users\cosma\Desktop\NightVisionCamera\BepInEx\plugins\NightVisionCamera-2020.12.9s.dll

using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;

namespace NightVisionCamera
{
  [HarmonyPatch(typeof (CFMGBHBGOOC), "Begin")]
  public class PlanetSurveillanceMinigameBeginPatch
  {
    private static void Postfix(CFMGBHBGOOC __instance)
    {
      if (NightVisionCamera.NightVisionCamera.impostorHasNormalCamera.GetValue() && FFGALNAPKCD.LocalPlayer.Data.DAPKNDBLKIA)
        return;
      GameObject gameObject1 = ((Component) __instance.Viewables.transform.Find("CloseButton")).gameObject;
      List<GameObject> gameObjectList = new List<GameObject>();
      GameObject gameObject2 = Object.Instantiate<GameObject>(gameObject1, __instance.Viewables.transform);
      gameObject2.transform.position = new Vector3((float) ((Component) __instance.ViewPort).transform.position.x, (float) ((Component) __instance.ViewPort).transform.position.y, -50f);
      gameObject2.transform.localScale = new Vector3(2.124f, 1.356f, 1f);
      gameObject2.GetComponent<SpriteRenderer>().sprite = (Sprite) null;
      Object.Destroy((Object) gameObject2.GetComponent<CircleCollider2D>());
      gameObjectList.Add(gameObject2);
      NightVisionHandler.overlays = gameObjectList;
      NightVisionHandler.UpdateNightVision(true);
    }
  }
}
