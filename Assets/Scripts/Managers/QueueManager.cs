using UnityEngine;
using System.Collections;
using System.Collections.Generic;
[System.Serializable]
public class QueueManager : RegisterList<QueueController>
{
    public QueueManager() : base() { }

    public bool QueuesAreSpawning
    {
        get
        {
            var areSpawning = false;
            foreach (var queue in list)
            {
                if (queue.spawning) areSpawning = true;
            }
            return areSpawning;
        }
    }

    public bool HasQueues
    {
        get
        {
            return list.Count > 0;
        }
    }
}
