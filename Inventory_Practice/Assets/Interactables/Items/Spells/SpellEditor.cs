using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Spell))]
[CanEditMultipleObjects]
public class SpellEditor : ItemEditor
{
    SerializedProperty damage;
    SerializedProperty cooldown;
    SerializedProperty duration;

    SerializedProperty recipe;

    SerializedProperty prefab;

    protected override void OnEnable()
    {
        base.OnEnable();
        damage = serializedObject.FindProperty("damage");
        cooldown = serializedObject.FindProperty("cooldown");
        duration = serializedObject.FindProperty("duration");
        recipe = serializedObject.FindProperty("recipe");
        prefab = serializedObject.FindProperty("prefab");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        base.OnInspectorGUI();
        EditorGUILayout.PropertyField(damage);
        EditorGUILayout.PropertyField(cooldown);
        EditorGUILayout.PropertyField(duration);
        EditorGUILayout.PropertyField(recipe);
        EditorGUILayout.PropertyField(prefab);
        serializedObject.ApplyModifiedProperties();
    }
}
