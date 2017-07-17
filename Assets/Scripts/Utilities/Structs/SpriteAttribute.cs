using System;
using UnityEngine;

[Serializable]
public class SpriteAttribute : PropertyAttribute
{
    public Sprite sprite;
    public SpriteAttribute(Sprite sprite) { this.sprite = sprite; }
}