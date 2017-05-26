using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(HelpBoxAttribute))]
public class HelpBoxAttributeDrawer : DecoratorDrawer
{
    public override void OnGUI(Rect position)
    {
        var helpBoxAttribute = attribute as HelpBoxAttribute;

        if (helpBoxAttribute == null) return;

        EditorGUI.HelpBox(position, helpBoxAttribute.message, GetMessageType(helpBoxAttribute.messageType));
    }

    public override float GetHeight()
    {
        var helpBoxAttribute = attribute as HelpBoxAttribute;
        if (helpBoxAttribute == null) return base.GetHeight();

        var helpBoxStyle = (GUI.skin != null) ? GUI.skin.GetStyle("helpbox") : null;
        if (helpBoxStyle == null) return base.GetHeight();

        return Mathf.Max(30f, helpBoxStyle.CalcHeight(new GUIContent(helpBoxAttribute.message), EditorGUIUtility.currentViewWidth) + 5);
    }


    private MessageType GetMessageType(HelpBoxMessageType helpBoxMessageType)
    {
        return (MessageType)helpBoxMessageType;
    }
}