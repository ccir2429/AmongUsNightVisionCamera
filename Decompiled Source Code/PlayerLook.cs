// Decompiled with JetBrains decompiler
// Type: NightVisionCamera.PlayerLook
// Assembly: NightVisionCamera, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47653931-C5E3-4AE7-AB47-079AD24F6E85
// Assembly location: C:\Users\cosma\Desktop\NightVisionCamera\BepInEx\plugins\NightVisionCamera-2020.12.9s.dll

namespace NightVisionCamera
{
  public class PlayerLook
  {
    public string name;
    public byte colorId;
    public uint hatId;
    public uint skinId;
    public uint petId;

    public PlayerLook(string name, byte colorId, uint hatId, uint skinId, uint petId)
    {
      this.name = name;
      this.colorId = colorId;
      this.hatId = hatId;
      this.skinId = skinId;
      this.petId = petId;
    }

    public static PlayerLook nightVisionLook() => new PlayerLook("", (byte) 11, 0U, 0U, 0U);
  }
}
