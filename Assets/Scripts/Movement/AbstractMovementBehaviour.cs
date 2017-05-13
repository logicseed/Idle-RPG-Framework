using UnityEngine;

/// <summary>
/// A movement behaviour describes the steering necessary to accomplish
/// a desire. This AbstractMovementBehaviour is the root of the decorator
/// pattern used for this movement system.
/// </summary>
public abstract class AbstractMovementBehaviour
{
    /// <summary>
    /// The steering vector desired by this movement behaviour.
    /// </summary>
    /// <returns>The optimal steering vector to accomplish this movement behaviour.</returns>
    public abstract Vector2 Steering();

    /// <summary>
    /// The velocity desired by this movement behaviour.
    /// </summary>
    /// <returns>The optimal velocity vector to accomplish this movement behaviour.</returns>
    public abstract Vector2 CalculateDesiredVelocity();
}
