using UnityEngine;
using UnityEditor;

class EditorGUIToggle : EditorWindow
{
    bool showClose =  true;

    [MenuItem("Window/Toggle")]
    public static void ShowWindow()
    {
        EditorGUIToggle w = (EditorGUIToggle)GetWindow(typeof(EditorGUIToggle));
        w.minSize = new Vector2(300, 500);
        w.maxSize = new Vector2(600, 800);
    }
    void Init()
    {
        EditorGUIToggle window = (EditorGUIToggle)GetWindow(typeof(EditorGUIToggle), true, "My Empty Window");
        window.Show();
    }

    void OnGUI()
    {
        showClose = EditorGUI.Toggle(new Rect(0, 5, position.width, 20),
            "Show Close Button",
            showClose);
        if (showClose)
            if (GUI.Button(new Rect(0, 25, position.width, 100), "Close Window!"))
                this.Close();
    }
}