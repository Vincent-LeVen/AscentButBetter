using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class IngredientEditor : EditorWindow
{
    [MenuItem("Window/CreateIngredient")]
    static void Init()
    {
        IngredientEditor ingredientEditor = (IngredientEditor)EditorWindow.GetWindow(typeof(IngredientEditor));
        ingredientEditor.Show();
    }

    void OnGUI()
    {
        // "Layout" -> Auto responsive
        GUILayout.Label("New Ingredient settings");
        EditorGUILayout.TextField(ingredientName);
        GUILayout.Button("Boutton");
    }
     
}
