/// <summary>
/// Manages all the queues on a stage.
/// </summary>
[System.Serializable]
public class QueueManager : RegisterList<QueueController>
{
    /// <summary>
    /// Consructs the queue manager.
    /// </summary>
    public QueueManager() : base() { }

    /// <summary>
    /// Returns whether or not there are queues on the stage.
    /// </summary>
    public bool HasQueues
    {
        get
        {
            return list.Count > 0;
        }
    }

    /// <summary>
    /// Returns whether or not any of the queues are still spawning enemies.
    /// </summary>
    public bool QueuesAreSpawning
    {
        get
        {
            var areSpawning = false;
            foreach (var queue in list)
            {
                if (queue.IsSpawning) areSpawning = true;
            }
            return areSpawning;
        }
    }

    /// <summary>
    /// Whether or not the queues and the enemies they have spawned are completed.
    /// </summary>
    public bool QueuesAreComplete
    {
        get
        {
            return HasQueues && !QueuesAreSpawning;
        }
    }
}