using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Vector2Extensions
{
    public static float SqrDistance(this Vector2 source, Vector2 destination)
    {
        var differenceVector = destination - source;
        return differenceVector.sqrMagnitude;
    }
}
