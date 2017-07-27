using UnityEngine;
using System.Collections;
using System;

[CreateAssetMenu(menuName = "Idle RPG/Ally")]
public class Ally : Character
{
    public override CharacterType characterType { get { return CharacterType.Ally; } }

    public Ability lesson;
    public LevelUpgrades levelUpgrades;
}
