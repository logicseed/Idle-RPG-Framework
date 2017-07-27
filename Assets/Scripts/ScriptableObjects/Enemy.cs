using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "Idle RPG/Enemy")]
public class Enemy : Character
{
    public override CharacterType characterType { get { return CharacterType.Enemy; } }
}
