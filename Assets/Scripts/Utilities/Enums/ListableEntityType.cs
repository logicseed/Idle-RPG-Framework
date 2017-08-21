/// <summary>
/// Type of world entity lists.
/// </summary>
public enum ListableEntityType
{
    /// <summary>
    /// World entity does not get listed.
    /// </summary>
    NonListable,

    /// <summary>
    /// List of abilities.
    /// </summary>
    Ability,

    /// <summary>
    /// List of equipment.
    /// </summary>
    Inventory,

    /// <summary>
    /// List of allies.
    /// </summary>
    Roster
}