using UnityEngine;

/// <summary>
/// Manages the behaviour of an enemy queue during gameplay.
/// </summary>
public class QueueController : MonoBehaviour
{
    private bool isRepeating;

    private bool isSpawning = true;

    private float lastSpawnTime;

    private int spawnIndex;

    [SerializeField]
    protected Queue queue;

    [SerializeField]
    protected float timeBetweenSpawns;

    /// <summary>
    /// Sets up the queue controller.
    /// </summary>
    protected void Start()
    {
        lastSpawnTime = Time.time - timeBetweenSpawns;
        GameManager.QueueManager.Register(this);
    }

    /// <summary>
    /// Updates the queue controller every frame.
    /// </summary>
    protected void Update()
    {
        if (isSpawning)
        {
            // Is it time to spawn?
            if (spawnIndex < queue.Enemies.Count &&
                Time.time > lastSpawnTime + timeBetweenSpawns)
            {
                SpawnNext();
                lastSpawnTime = Time.time;
                spawnIndex++;
            }

            // Should we repeat the queue?
            if (spawnIndex >= queue.Enemies.Count)
            {
                if (isRepeating) spawnIndex = 0;
                else isSpawning = false;
            }
        }
    }

    /// <summary>
    /// Whether this queue is repeating the spawn list.
    /// </summary>
    public bool IsRepeating { get { return isRepeating; } set { isRepeating = value; } }

    /// <summary>
    /// Whether this queue is actively spawning characters.
    /// </summary>
    public bool IsSpawning
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

    /// <summary>
    /// Spawns the character at spawnIndex from the queue.
    /// </summary>
    public void SpawnNext()
    {
        // Make sure the position in inspector was filled with
        // character prefab.
        if (queue.Enemies[spawnIndex] != null)
        {
            var position = transform.position;
            var rotation = Quaternion.identity; // No rotation
            var parent = this.transform;
            var enemy = Instantiate(GameManager.GameSettings.Prefab.Enemy, position, rotation, parent) as GameObject;

            enemy.GetComponent<EnemyController>().EnemyObject = queue.Enemies[spawnIndex];
        }
    }
}