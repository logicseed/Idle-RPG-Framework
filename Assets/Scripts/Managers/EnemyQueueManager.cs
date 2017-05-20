using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manages the behaviour of an enemy queue during gameplay.
/// </summary>
public class EnemyQueueManager : MonoBehaviour
{
    public List<GameObject> enemies;
    public float timeBetweenSpawns;

    private int spawnIndex;
    private float lastSpawnTime;
    [SerializeField]
    private bool repeating;
    private bool spawning = true;

    /// <summary>
    /// Whether this queue is repeating the spawn list.
    /// </summary>
    public bool Repeating
    {
        get
        {
            return repeating;
        }
        set
        {
            repeating = value;
        }
    }

    /// <summary>
    /// Whether this queue is actively spawning enemies.
    /// </summary>
    public bool Spawning
    {
        get
        {
            return spawning;
        }
        set
        {
            // Spawn next enemy immediately.
            lastSpawnTime = Time.time - timeBetweenSpawns;
            spawning = value;
        }
    }

    /// <summary>
    /// Unity Start callback.
    /// </summary>
    private void Start()
    {
        lastSpawnTime = Time.time;
    }

    /// <summary>
    /// Unity Update callback.
    /// </summary>
    private void Update()
    {
        if (spawning)
        {
            // Is it time to spawn?
            if (spawnIndex < enemies.Count &&
                Time.time > lastSpawnTime + timeBetweenSpawns)
            {
                SpawnNext();
                lastSpawnTime = Time.time;
                spawnIndex++;
            }

            // Should we repeat the queue?
            if (spawnIndex >= enemies.Count && repeating)
            {
                spawnIndex = 0;
            }
        }
    }

    /// <summary>
    /// Spawns the enemy at spawnIndex from the queue.
    /// </summary>
    public void SpawnNext()
    {
        // Make sure the position in inspector was filled with
        // enemy prefab.
        if (enemies[spawnIndex] != null)
        {
            var enemy = enemies[spawnIndex];
            var position = transform.position;
            var rotation = Quaternion.identity; // No rotation
            var parent = this.transform;
            Instantiate(enemy, position, rotation, parent);
        }
    }

    /// <summary>
    /// Draws a sphere in the editor to indicate where the
    /// queue is located.
    /// </summary>
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(transform.position, 0.125f);
    }
}
