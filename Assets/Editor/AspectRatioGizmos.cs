using UnityEditor;
using UnityEngine;

/// <summary>
/// Editor gizmos representing the common aspect ratios.
/// </summary>
public class AspectRatioGizmos
{
    private const float ASPECT_4_3 = 4 / 3F;
    private const float ASPECT_3_2 = 3 / 2F;
    private const float ASPECT_16_10 = 16 / 10F;
    private const float ASPECT_17_10 = 17 / 10F;
    private const float ASPECT_16_9 = 16 / 9F;

    private static Color COLOR_4_3 = Color.red;
    private static Color COLOR_3_2 = Color.yellow;
    private static Color COLOR_16_10 = Color.green;
    private static Color COLOR_17_10 = Color.yellow;
    private static Color COLOR_16_9 = Color.red;

    /// <summary>
    /// Draws aspect ratio gizmoes when an orthographic camera is selected.
    /// </summary>
    [DrawGizmo(GizmoType.Selected | GizmoType.Active, drawnType = typeof(Camera))]
    public static void DrawAspectRatioGizmos(Camera camera, GizmoType gizmoType)
    {
        DrawAspectRatioCubes(camera, gizmoType);
    }

    /// <summary>
    /// Draws gizmos representing the common aspect ratios.
    /// </summary>
    private static void DrawAspectRatioCubes(Camera camera, GizmoType gizmoType)
    {
        // Position - Assumes camera pointed in positive z-dir
        var position_x = camera.transform.position.x;
        var position_y = camera.transform.position.y;
        var position_z = camera.transform.position.z
                         + (0.5F * (camera.farClipPlane - camera.nearClipPlane));

        // Base scale
        var scale_x = camera.orthographicSize * 2; // * ASPECT_RATIO
        var scale_y = camera.orthographicSize * 2;
        var scale_z = camera.farClipPlane - camera.nearClipPlane;

        Gizmos.color = COLOR_16_9;
        Gizmos.DrawWireCube(new Vector3(position_x, position_y, position_z),
                            new Vector3(scale_x * ASPECT_16_9, scale_y, scale_z));

        Gizmos.color = COLOR_17_10;
        Gizmos.DrawWireCube(new Vector3(position_x, position_y, position_z),
                            new Vector3(scale_x * ASPECT_17_10, scale_y, scale_z));

        Gizmos.color = COLOR_16_10;
        Gizmos.DrawWireCube(new Vector3(position_x, position_y, position_z),
                            new Vector3(scale_x * ASPECT_16_10, scale_y, scale_z));

        Gizmos.color = COLOR_3_2;
        Gizmos.DrawWireCube(new Vector3(position_x, position_y, position_z),
                            new Vector3(scale_x * ASPECT_3_2, scale_y, scale_z));

        Gizmos.color = COLOR_4_3;
        Gizmos.DrawWireCube(new Vector3(position_x, position_y, position_z),
                            new Vector3(scale_x * ASPECT_4_3, scale_y, scale_z));
    }
}