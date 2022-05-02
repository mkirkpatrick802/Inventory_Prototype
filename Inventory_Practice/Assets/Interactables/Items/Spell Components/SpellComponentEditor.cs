using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(SpellComponent))]
[CanEditMultipleObjects]
public class SpellComponentEditor : ItemEditor
{

    SerializedProperty price;
    SerializedProperty cost;

    protected override void OnEnable()
    {
        base.OnEnable();
        price = serializedObject.FindProperty("price");
        cost = serializedObject.FindProperty("cost");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        base.OnInspectorGUI();
        EditorGUILayout.PropertyField(price);
        EditorGUILayout.PropertyField(cost);
        serializedObject.ApplyModifiedProperties();
    }
}
