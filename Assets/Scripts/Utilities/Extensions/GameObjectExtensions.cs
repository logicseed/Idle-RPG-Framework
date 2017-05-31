using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
public static class GameObjectExtensions
{
    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="gameObject"></param>
    /// <returns></returns>
    public static T GetRequiredComponent<T>(this GameObject gameObject) where T : MonoBehaviour
    {
        T component = gameObject.GetComponent<T>();

        if (component == null)
        {
            component = gameObject.AddComponent<T>();
        }

        return component;
    }

    /// <summary>
    /// Determines which GameObject is closer to the calling GameObject.
    /// </summary>
    /// <param name="source">The calling GameObject.</param>
    /// <param name="gameObjectA">First GameObject to compare.</param>
    /// <param name="gameObjectB">Second GameObject to compare.</param>
    /// <returns>Reference to the closest GameObject; or gameObjectA if they are equidistant.</returns>
    public static GameObject CloserGameObject(this GameObject source, GameObject gameObjectA, GameObject gameObjectB)
    {
        var distanceToA = source.transform.position.SqrDistance(gameObjectA.transform.position);
        var distanceToB = source.transform.position.SqrDistance(gameObjectB.transform.position);

        if (distanceToB < distanceToA)
        {
            return gameObjectB;
        }
        else
        {
            return gameObjectA;
        }
    }
}
