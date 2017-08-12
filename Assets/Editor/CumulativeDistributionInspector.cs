using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CumulativeDistribution<Equipment>))]
public class CumulativeDistributionInspector : Editor
{
    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        EditorGUILayout.PropertyField(serializedObject.FindProperty("items"));
        serializedObject.ApplyModifiedProperties();
    }
}