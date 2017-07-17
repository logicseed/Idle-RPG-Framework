using UnityEngine;
using System.Collections;
using System;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class CustomGizmo : MonoBehaviour
{
    [Serializable]
    public class Properties
    {
        public Color color = Color.red;
        public GizmoShape shape = GizmoShape.Sphere;
        public bool wireframe = true;
        public float size = 0.5f;
        public bool showLabel = true;
    }

    public Properties properties;

    private void OnDrawGizmos()
    {
        Gizmos.color = properties.color;
        var size = properties.size;

        switch (properties.shape)
        {
            case GizmoShape.Cube:
                if (properties.wireframe) Gizmos.DrawWireCube(transform.position, new Vector3(size, size, size));
                else Gizmos.DrawCube(transform.position, new Vector3(size, size, size));
                break;
            case GizmoShape.Sphere:
                if (properties.wireframe) Gizmos.DrawWireSphere(transform.position, size);
                else Gizmos.DrawSphere(transform.position, size);
                break;
        }
#if UNITY_EDITOR
        if (properties.showLabel) Handles.Label(transform.position, transform.name);
#endif
    }

    public enum GizmoShape
    {
        Cube,
        Sphere
    }
}
