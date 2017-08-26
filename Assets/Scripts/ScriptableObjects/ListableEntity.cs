using UnityEngine;

/// <summary>
/// Represents an entity that will be displayed in lists.
/// </summary>
public abstract class ListableEntity : ScriptableObject
{
    [SerializeField]
    public Sprite icon;

    /// <summary>
    /// Icon for the entity when displayed in lists.
    /// </summary>
    public Sprite Icon { get { return icon; } }

    /// <summary>
    /// Type of lists this entity belongs to.
    /// </summary>
    public virtual ListableEntityType ListableType { get { return ListableEntityType.NonListable; } }
}