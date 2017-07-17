using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Idle RPG/Queue")]
public class Queue : ScriptableObject
{
    public List<Enemy> enemies;
}
