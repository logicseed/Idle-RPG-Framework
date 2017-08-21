using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Abstract class for managing world entities. World entities are entities that are not dependent
/// upon the stage such as roster allies, inventory equipment, etc.
/// </summary>
public abstract class WorldEntityManager
{
    [SerializeField]
    protected List<string> unlocked;

    [SerializeField]
    protected List<string> assigned;

    protected Dictionary<string, ListableEntity> objects;

    /// <summary>
    /// Constructs
    /// </summary>
    /// <param name="save"></param>
    public WorldEntityManager(SaveGame save = null)
    {
        unlocked = new List<string>();
        assigned = new List<string>();
        objects = new Dictionary<string, ListableEntity>();
        Load(save);
    }

    /// <summary>
    /// Assigned list change delegate signature.
    /// </summary>
    public delegate void AssignedListChanged();

    /// <summary>
    /// Unlocked list change delegate signature.
    /// </summary>
    public delegate void UnlockedListChanged();

    /// <summary>
    /// Assigned list change event.
    /// </summary>
    public event AssignedListChanged OnAssignedListChanged;

    /// <summary>
    /// Unlocked list change event.
    /// </summary>
    public event UnlockedListChanged OnUnlockedListChanged;

    /// <summary>
    /// Returns a list of assigned entities.
    /// </summary>
    public List<string> Assigned { get { return assigned; } }

    /// <summary>
    /// Returns the maximum amount of assigned world entities.
    /// </summary>
    public abstract int MaxAssigned { get; }

    /// <summary>
    /// Returns the maximum amount unlocked world entities.
    /// </summary>
    public abstract int MaxUnlocked { get; }

    /// <summary>
    /// Returns the resource path of the world entities.
    /// </summary>
    public abstract string ResourcePath { get; }

    /// <summary>
    /// Returns a list of unlocked entities.
    /// </summary>
    public List<string> Unlocked { get { return unlocked; } }
    /// <summary>
    /// Adds a world entity to the list of assigned entities.
    /// </summary>
    /// <param name="name">The name of the world entity.</param>
    /// <param name="raiseChangeEvent">Whether or not to raise the assigned change event.</param>
    public virtual void AddAssigned(string name, bool raiseChangeEvent = true)
    {
        if (!Assigned.Contains(name) && Assigned.Count < MaxAssigned)
        {
            Assigned.Add(name);
            if (raiseChangeEvent) RaiseChangeEvent(WorldEntityListType.Assigned);
        }
    }

    /// <summary>
    /// Adds a world entity to the list of unlocked entities.
    /// </summary>
    /// <param name="name">The name of the world entity.</param>
    /// <param name="raiseChangeEvent">Whether or not the raise the unlocked change event.</param>
    public virtual void AddUnlocked(string name, bool raiseChangeEvent = true)
    {
        if (!Unlocked.Contains(name) && Unlocked.Count < MaxUnlocked)
        {
            Unlocked.Add(name);
            if (raiseChangeEvent) RaiseChangeEvent(WorldEntityListType.Unlocked);
        }
    }

    /// <summary>
    /// Gets the scriptable object for the world entity.
    /// </summary>
    /// <param name="name">The name of the world entity.</param>
    /// <returns>The scriptable object for the entity.</returns>
    public virtual ListableEntity GetEntityObject(string name)
    {
        ListableEntity entityObject;

        if (objects == null) objects = new Dictionary<string, ListableEntity>();

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

    /// <summary>
    /// Initializes the world entity manager from a saved game.
    /// </summary>
    /// <param name="save">The save game data.</param>
    public abstract void Load(SaveGame save);

    /// <summary>
    /// Raises the list change event.
    /// </summary>
    /// <param name="type">The type of list to raise the event for; unlocked or assigned.</param>
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

    /// <summary>
    /// Removes a world entity from the list of assigned entities.
    /// </summary>
    /// <param name="name">The name of the world entity.</param>
    /// <param name="raiseChangeEvent">Whether or not to raise the assigned change event.</param>
    public virtual void RemoveAssigned(string name, bool raiseChangeEvent = true)
    {
        if (Assigned.Contains(name))
        {
            Assigned.Remove(name);
            if (raiseChangeEvent) RaiseChangeEvent(WorldEntityListType.Assigned);
        }
    }

    /// <summary>
    /// Removes a world entity from the list of unlocked entites.
    /// </summary>
    /// <param name="name">The name of the world entity.</param>
    /// <param name="raiseChangeEvent">Whether or not to raise the unlocked change event.</param>
    public virtual void RemoveUnlocked(string name, bool raiseChangeEvent = true)
    {
        if (Unlocked.Contains(name))
        {
            Unlocked.Remove(name);
            if (objects.ContainsKey(name)) objects.Remove(name);

            if (raiseChangeEvent) RaiseChangeEvent(WorldEntityListType.Unlocked);
        }
    }

    /// <summary>
    /// Fills a save game with data from the world entity manager.
    /// </summary>
    /// <param name="save">The save game data.</param>
    public abstract void Save(ref SaveGame save);
}