using UnityEngine;
using System.Collections;

public class BossController : EnemyController
{
    public override CharacterType type { get { return CharacterType.Enemy; } }

}
