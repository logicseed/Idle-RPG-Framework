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
    public abstract int MaxUnlocked { get; }
    public abstract int MaxAssigned { get; }
    public abstract string ResourcePath { get; }

    public virtual void AddUnlocked(string name, bool raiseChangeEvent = true)
    {
        if (!Unlocked.Contains(name) && Unlocked.Count < MaxUnlocked)
        {
            Debug.Log("Added to unlocked: " + name);
            Unlocked.Add(name);
            if (raiseChangeEvent) RaiseChangeEvent(WorldEntityListType.Unlocked);
        }
    }

    public virtual void AddAssigned(string name, bool raiseChangeEvent = true)
    {
        if (!Assigned.Contains(name) && Assigned.Count < MaxAssigned)
        {
            Debug.Log("Added to assigned: " + name);
            Assigned.Add(name);
            if (raiseChangeEvent) RaiseChangeEvent(WorldEntityListType.Assigned);
        }
    }

    public virtual void RemoveUnlocked(string name, bool raiseChangeEvent = true)
    {
        if (Unlocked.Contains(name))
        {
            Debug.Log("Removed from unlocked: " + name);

            Unlocked.Remove(name);
            if (objects.ContainsKey(name)) objects.Remove(name);

            if (raiseChangeEvent) RaiseChangeEvent(WorldEntityListType.Unlocked);
        }
    }

    public virtual void RemoveAssigned(string name, bool raiseChangeEvent = true)
    {
        if (Assigned.Contains(name))
        {
            Debug.Log("Removed from assigned: " + name);
            Assigned.Remove(name);
            if (raiseChangeEvent) RaiseChangeEvent(WorldEntityListType.Assigned);
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

    public void RaiseChangeEvent(WorldEntityListType type)
    {
        if (type == WorldEntityListType.Unlocked)
        {
            if (OnUnlockedListChanged != null) OnUnlockedListChanged();
        }
        else
        {
            if (OnAssignedListChanged != null) OnAssignedListChanged();
        }
    }
}
