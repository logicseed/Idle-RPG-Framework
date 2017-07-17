using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "Idle RPG/Hero")]
public class Hero : Character
{
    public override CharacterType type { get { return CharacterType.Hero; } }
}
