using UnityEngine;
using System.Collections;

public class BossController : EnemyController
{
    public override CharacterType CharacterType { get { return CharacterType.Enemy; } }


}
