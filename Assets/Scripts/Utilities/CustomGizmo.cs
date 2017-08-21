using UnityEngine;
using System.Collections;
using System;
#if UNITY_EDITOR
using UnityEditor;
#endif

/// <summary>
/// Allows the easy display of editor gizmos.
/// </summary>
public class CustomGizmo : MonoBehaviour
{
    /// <summary>
    /// Properties of the gizmo.
    /// </summary>
    [Serializable]
    public class Properties
    {
        public Color Color = Color.red;
        public GizmoShape Shape = GizmoShape.Sphere;
        public bool Wireframe = true;
        public float Size = 0.5f;
        public bool ShowLabel = true;
    }

    [SerializeField]
    private Properties properties;

    /// <summary>
    /// Refreshes on gizmo refresh.
    /// </summary>
    private void OnDrawGizmos()
    {
        Gizmos.color = properties.Color;
        var size = properties.Size;

        switch (properties.Shape)
        {
            case GizmoShape.Cube:
                if (properties.Wireframe) Gizmos.DrawWireCube(transform.position, new Vector3(size, size, size));
                else Gizmos.DrawCube(transform.position, new Vector3(size, size, size));
                break;
            case GizmoShape.Sphere:
                if (properties.Wireframe) Gizmos.DrawWireSphere(transform.position, size);
                else Gizmos.DrawSphere(transform.position, size);
                break;
        }
#if UNITY_EDITOR
        if (properties.ShowLabel) Handles.Label(transform.position, transform.name);
#endif
    }

    /// <summary>
    /// Shape of the gizmo.
    /// </summary>
    public enum GizmoShape
    {
        Cube,
        Sphere
    }
}
