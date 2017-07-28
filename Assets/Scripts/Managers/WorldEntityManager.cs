using UnityEngine;
using System.Collections.Generic;

public abstract class WorldEntityManager
{
    [SerializeField]
    protected List<string> unlocked;
    [SerializeField]
    protected List<string> assigned;
    protected Dictionary<string, ListableEntity> objects;

    public List<string> Unlocked { get { return unlocked; } }
    public List<string> Assigned { get { return assigned; } }

    public WorldEntityManager(SaveGame save = null)
    {
        unlocked = new List<string>();
        assigned = new List<string>();
        objects = new Dictionary<string, ListableEntity>();
        Load(save);
    }

    public delegate void UnlockedListChanged();
    public event UnlockedListChanged OnUnlockedListChanged;

    public delegate void AssignedListChanged();
    public event AssignedListChanged OnAssignedListChanged;

    public abstract void Load(SaveGame save);
    public abstract void Save(ref SaveGame save);
    public abstract int MaximumAmount { get; }
    public abstract string ResourcePath { get; }

    public virtual void AddUnlocked(string name)
    {
        if (!unlocked.Contains(name))
        {
            Debug.Log("Added to unlocked: " + name);
            unlocked.Add(name);
            if (OnUnlockedListChanged != null) OnUnlockedListChanged();
        }
    }

    public virtual void AddAssigned(string name)
    {
        if (!assigned.Contains(name) && assigned.Count < MaximumAmount)
        {
            Debug.Log("Added to assigned: " + name);
            assigned.Add(name);
            if (OnAssignedListChanged != null) OnAssignedListChanged();
        }
    }

    public virtual void RemoveUnlocked(string name)
    {
        if (unlocked.Contains(name))
        {
            Debug.Log("Removed from unlocked: " + name);
            unlocked.Remove(name);
            if (OnUnlockedListChanged != null) OnUnlockedListChanged();
        }
    }

    public virtual void RemoveAssigned(string name)
    {
        if (assigned.Contains(name))
        {
            Debug.Log("Removed from assigned: " + name);
            assigned.Remove(name);
            if (OnAssignedListChanged != null) OnAssignedListChanged();
        }
    }

    public virtual ListableEntity GetEntityObject(string name)
    {
        ListableEntity entityObject;

        if (objects.ContainsKey(name))
        {
            entityObject = objects[name];
        }
        else
        {
            entityObject = Resources.Load(ResourcePath + name) as ListableEntity;
            objects.Add(name, entityObject);
        }

        return entityObject;
    }
}
