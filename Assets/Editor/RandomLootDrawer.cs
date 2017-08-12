using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(RandomLoot))]
public class RandomLootDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);
        //position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

        var indent = EditorGUI.indentLevel;
        EditorGUI.indentLevel = 1;

        // Calculate rects
        var equipmentRect = new Rect(position.x, position.y, 200, position.height);
        var randomChanceRect = new Rect(position.x + 200, position.y, position.width - 200, position.height);

        // Draw fields - passs GUIContent.none to each so they are drawn without labels
        EditorGUI.PropertyField(equipmentRect, property.FindPropertyRelative("equipment"), GUIContent.none);
        EditorGUI.PropertyField(randomChanceRect, property.FindPropertyRelative("randomChance"), GUIContent.none);

        // Set indent back to what it was
        EditorGUI.indentLevel = indent;

        EditorGUI.EndProperty();
    }
}