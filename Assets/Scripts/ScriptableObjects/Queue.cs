using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Represents a queue of enemies.
/// </summary>
[CreateAssetMenu(menuName = "Idle RPG/Queue")]
public class Queue : ScriptableObject
{
    [SerializeField]
    protected List<Enemy> enemies;

    /// <summary>
    /// List of enemies in the queue.
    /// </summary>
    public List<Enemy> Enemies { get { return enemies; } }
}