using UnityEngine;

/// <summary>
/// Extends the Unity Vector3 type.
/// </summary>
public static class Vector3Extensions
{
    /// <summary>
    /// Gets the squared distance between two vectors.
    /// </summary>
    /// <param name="source">The source vector.</param>
    /// <param name="destination">The destination vector.</param>
    /// <returns>A float representing the squared distance between the vectors.</returns>
    public static float SqrDistance(this Vector3 source, Vector3 destination)
    {
        var differenceVector = destination - source;
        return differenceVector.sqrMagnitude;
    }
}