using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Builder))]
public class BuildierEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.backgroundColor = new Color(0,1,1,0.5f);

        Builder builder = (Builder) target;
        
        EditorGUILayout.LabelField(" ");
        EditorGUILayout.LabelField(" ");
        EditorGUILayout.LabelField("City Builing/Destroying Options", EditorStyles.boldLabel);

        if(GUILayout.Button("Generate City"))
        {
            builder.SpawnCity();
        }

        if(GUILayout.Button("Delete City"))
        {
            builder.DeleteCity();
        }

        EditorGUILayout.LabelField(" ");
        EditorGUILayout.LabelField("Scriptable Object City", EditorStyles.boldLabel);

        if(GUILayout.Button("Generate Scriptable City"))
        {
            builder.ScriptableCitySpawn();
        }

        if(GUILayout.Button("Delete City"))
        {
            builder.DeleteCity();
        }

        EditorGUILayout.LabelField(" ");
        EditorGUILayout.LabelField("City Building Options", EditorStyles.boldLabel);

        builder.mapHeigt = EditorGUILayout.IntSlider("Map Height", builder.mapHeigt, 1, 100);
        builder.mapWidth = EditorGUILayout.IntSlider("Map Width", builder.mapWidth, 1, 100);
        builder.buildingFootprint = EditorGUILayout.IntSlider("Building Space", builder.buildingFootprint, 1, 100);

        EditorGUILayout.LabelField(" ");
        EditorGUILayout.LabelField("Seed Options", EditorStyles.boldLabel);
        EditorGUILayout.LabelField("Random Seed", EditorStyles.miniBoldLabel);

        if(builder.randomSeed == true)
        {
            EditorGUILayout.Toggle(true);
        }

        else
        {
            EditorGUILayout.Toggle(false);
        }

        GUILayout.BeginHorizontal();
        if(GUILayout.Button("Random Seed Toggle - On"))
        {
            builder.ActivateRandomSeed();
        }

        if(GUILayout.Button("Random Seed Toggle - Off"))
        {
            builder.DeactivateRandomSeed();
        }
        GUILayout.EndHorizontal();

        builder.manualSeed = EditorGUILayout.Slider("Manual Seed", builder.manualSeed, 0.1f, 999f);
    }
}
