using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
public class RosterManager : MonoBehaviour
{
    public const int MAX_ACTIVE_ROSTER = 3;

    public List<GameObject> allies;
    public List<GameObject> activeRoster;

    /// <summary>
    ///
    /// </summary>
    /// <param name="ally"></param>
    public void AddToRoster(GameObject ally)
    {
        if (!activeRoster.Contains(ally) && activeRoster.Count < MAX_ACTIVE_ROSTER)
        {
            activeRoster.Add(ally);
        }
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="ally"></param>
    public void RemoveFromRoster(GameObject ally)
    {
        if (activeRoster.Contains(ally)) activeRoster.Remove(ally);
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="ally"></param>
    public void AddToAllies(GameObject ally)
    {
        if (!allies.Contains(ally)) allies.Add(ally);
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="ally"></param>
    public void RemoveFromAllies(GameObject ally)
    {
        if (allies.Contains(ally)) allies.Remove(ally);
    }
}
