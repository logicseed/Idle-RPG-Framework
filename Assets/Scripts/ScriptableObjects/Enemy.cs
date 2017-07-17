using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "Idle RPG/Enemy")]
public class Enemy : Character
{
    public override CharacterType type { get { return CharacterType.Enemy; } }
}
