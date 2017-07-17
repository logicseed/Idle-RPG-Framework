using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
[CustomPropertyDrawer(typeof(SpriteAttribute))]
public class SpritePreviewPropertyDrawer : PropertyDrawer
{
    private const float BUFFER = -20;

    //public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    //{
    //    var ident = EditorGUI.indentLevel;
    //    EditorGUI.indentLevel = 0;


    //    var sprite = (Sprite)property.objectReferenceValue;

    //    var height = sprite.texture.height / (sprite.texture.width / position.width);

    //    var spriteRect = new Rect(position.x, position.y, position.width, height);

    //    //property.objectReferenceValue =
    //    EditorGUI.ObjectField(spriteRect, property.objectReferenceValue, typeof(Sprite), false);

    //    EditorGUI.indentLevel = ident;
    //}

    public override float GetPropertyHeight(SerializedProperty prop, GUIContent label)
    {
        if (prop.objectReferenceValue != null)
        {
            return BUFFER;
        }
        else
        {
            return base.GetPropertyHeight(prop, label);
        }
    }

    //public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    //{
    //    EditorGUI.BeginProperty(position, label, property);

    //    var spriteAttribute = (SpriteAttribute)property.objectReferenceValue;
        
    //    if ((SpriteAttribute)property.objectReferenceValue != null)
    //    {
    //        position.width = EditorGUIUtility.labelWidth;
    //        GUI.Label(position, property.displayName);

    //        position.x += EditorGUIUtility.labelWidth;
    //        var width = EditorGUIUtility.currentViewWidth - EditorGUIUtility.labelWidth + BUFFER;

    //        var sprite = ((Sprite)property.objectReferenceValue);
    //        var height = sprite.texture.height / (sprite.texture.width / width);

    //        position.width = width;
    //        position.height = height;

    //        //property.objectReferenceValue =
    //        EditorGUI.ObjectField(position, property.objectReferenceValue, typeof(Sprite), false);
    //    }
    //    else
    //    {
    //        EditorGUI.PropertyField(position, property, true);
    //    }

    //    EditorGUI.EndProperty();
    //}
}
