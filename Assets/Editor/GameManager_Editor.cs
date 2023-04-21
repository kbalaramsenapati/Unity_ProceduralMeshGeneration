using UnityEditor;
using UnityEngine;
using static EnemyStatsEditor;

[CustomEditor(typeof(GameManager))]
public class GameManager_Editor : Editor
{
    public enum ShapeCategory
    {
        None, TwoDimensional, Threedimensional
    }
    public ShapeCategory categoryToShape;
    private bool Triangle = false;
    public override void OnInspectorGUI()
    {
        // Display the enum popup in the inspector
        categoryToShape = (ShapeCategory)EditorGUILayout.EnumPopup("ShapeCategory", categoryToShape);

        // Create a space to separate this enum popup from other variables 
        EditorGUILayout.Space();

        // Switch statement to handle what happens for each category
        switch (categoryToShape)
        {
            case ShapeCategory.TwoDimensional:
                DisplayTwoDimensionalInfo();
                break;

            case ShapeCategory.Threedimensional:
                DisplayThreeDimensionalInfo();
                break;

        }
        serializedObject.ApplyModifiedProperties();
    }

    void DisplayTwoDimensionalInfo()
    {
        Triangle = EditorGUILayout.Toggle("Triangle", Triangle);
        if (Triangle)
        {
            EditorGUILayout.PropertyField(serializedObject.FindProperty("Triangle1"));
        }

        #region Dustbin
        //EditorGUILayout.PropertyField(serializedObject.FindProperty("Triangle"));
        //EditorGUILayout.PropertyField(serializedObject.FindProperty("Square"));

        #endregion
    }
    void DisplayThreeDimensionalInfo()
    {
        EditorGUILayout.PropertyField(serializedObject.FindProperty("Cube"));
        //EditorGUILayout.PropertyField(serializedObject.FindProperty("defense"));
        //EditorGUILayout.PropertyField(serializedObject.FindProperty("movementSpeed"));
    }

}
