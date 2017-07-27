using UnityEngine;
using System.Collections;

public abstract class ListableEntity : ScriptableObject
{
    public Sprite icon;
    public ListableEntityType type = ListableEntityType.NonListable;
}
