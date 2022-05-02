using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(SpellComponent))]
[CanEditMultipleObjects]
public class SpellComponentEditor : Editor
{
    new SerializedProperty name;
    SerializedProperty icon;
    SerializedProperty itemType;
    SerializedProperty price;
    SerializedProperty cost;
    SerializedProperty isStackable;
    SerializedProperty amount;

    private void OnEnable()
    {
        name = serializedObject.FindProperty("name");
        icon = serializedObject.FindProperty("icon");
        itemType = serializedObject.FindProperty("itemType");
        price = serializedObject.FindProperty("price");
        cost = serializedObject.FindProperty("cost");
        isStackable = serializedObject.FindProperty("isStackable");
        amount = serializedObject.FindProperty("amount");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.PropertyField(name);
        EditorGUILayout.PropertyField(icon);
        EditorGUILayout.PropertyField(itemType);
        EditorGUILayout.PropertyField(price);
        EditorGUILayout.PropertyField(cost);
        EditorGUILayout.PropertyField(isStackable);

        if (isStackable.boolValue == true)
        {
            EditorGUILayout.PropertyField(amount);
        }

        serializedObject.ApplyModifiedProperties();
    }

}
