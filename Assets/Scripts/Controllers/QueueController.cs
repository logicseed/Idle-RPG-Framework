using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manages the behaviour of an enemy queue during gameplay.
/// </summary>
public class QueueController : MonoBehaviour
{
    public Queue queue;
    public float timeBetweenSpawns;

    private int spawnIndex;
    private float lastSpawnTime;
    [SerializeField]
    private bool isRepeating;
    [SerializeField]
    private bool isSpawning = true;

    /// <summary>
    /// Whether this queue is repeating the spawn list.
    /// </summary>
    public bool repeating
    {
        get
        {
            return isRepeating;
        }
        set
        {
            isRepeating = value;
        }
    }

    /// <summary>
    /// Whether this queue is actively spawning characters.
    /// </summary>
    public bool spawning
    {
        get
        {
            return isSpawning;
        }
        set
        {
            // Spawn next enemy immediately.
            lastSpawnTime = Time.time - timeBetweenSpawns;
            isSpawning = value;
        }
    }

    private void Start()
    {
        lastSpawnTime = Time.time;
        GameManager.QueueManager.Register(this);
    }

    private void Update()
    {
        if (isSpawning)
        {
            // Is it time to spawn?
            if (spawnIndex < queue.enemies.Count &&
                Time.time > lastSpawnTime + timeBetweenSpawns)
            {
                SpawnNext();
                lastSpawnTime = Time.time;
                spawnIndex++;
            }

            // Should we repeat the queue?
            if (spawnIndex >= queue.enemies.Count)
            {
                if (isRepeating) spawnIndex = 0;
                else isSpawning = false;
            }
        }
    }

    /// <summary>
    /// Spawns the character at spawnIndex from the queue.
    /// </summary>
    public void SpawnNext()
    {
        // Make sure the position in inspector was filled with
        // character prefab.
        if (queue.enemies[spawnIndex] != null)
        {
            var position = transform.position;
            var rotation = Quaternion.identity; // No rotation
            var parent = this.transform;
            var enemy = Instantiate(GameManager.GameSettings.Prefab.Enemy, position, rotation, parent) as GameObject;

            enemy.GetComponent<EnemyController>().enemy = queue.enemies[spawnIndex];
        }
    }
}
