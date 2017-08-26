using UnityEditor;
using UnityEngine;

/// <summary>
/// Draws a help box in the inspector.
/// </summary>
[CustomPropertyDrawer(typeof(HelpBoxAttribute))]
public class HelpBoxAttributeDrawer : DecoratorDrawer
{
    /// <summary>
    /// Refreshes the help box GUI.
    /// </summary>
    /// <param name="position">Location to render the help box.</param>
    public override void OnGUI(Rect position)
    {
        var helpBoxAttribute = attribute as HelpBoxAttribute;

        if (helpBoxAttribute == null) return;

        EditorGUI.HelpBox(position, helpBoxAttribute.message, (MessageType)helpBoxAttribute.messageType);
    }

    /// <summary>
    /// Gets the height necessary to draw the help box.
    /// </summary>
    /// <returns>Height of the help box when rendered.</returns>
    public override float GetHeight()
    {
        var helpBoxAttribute = attribute as HelpBoxAttribute;
        if (helpBoxAttribute == null) return base.GetHeight();

        var helpBoxStyle = (GUI.skin != null) ? GUI.skin.GetStyle("helpbox") : null;
        if (helpBoxStyle == null) return base.GetHeight();

        return Mathf.Max(30f, helpBoxStyle.CalcHeight(new GUIContent(helpBoxAttribute.message), EditorGUIUtility.currentViewWidth) + 5);
    }
}