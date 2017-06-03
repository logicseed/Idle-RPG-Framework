using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manages the behaviour of an enemy queue during gameplay.
/// </summary>
public class QueueManager : MonoBehaviour
{
    public List<GameObject> characters;
    public float timeBetweenSpawns;

    private int spawnIndex;
    private float lastSpawnTime;
    [SerializeField]
    private bool isRepeating;
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
    }

    private void Update()
    {
        if (isSpawning)
        {
            // Is it time to spawn?
            if (spawnIndex < characters.Count &&
                Time.time > lastSpawnTime + timeBetweenSpawns)
            {
                SpawnNext();
                lastSpawnTime = Time.time;
                spawnIndex++;
            }

            // Should we repeat the queue?
            if (spawnIndex >= characters.Count && isRepeating)
            {
                spawnIndex = 0;
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
        if (characters[spawnIndex] != null)
        {
            var character = characters[spawnIndex];
            var position = transform.position;
            var rotation = Quaternion.identity; // No rotation
            var parent = this.transform;
            Instantiate(character, position, rotation, parent);
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
