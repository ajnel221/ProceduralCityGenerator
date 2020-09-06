using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(VegetationSpawner))]
public class VegetationEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.backgroundColor = new Color(0,1,1,0.5f);

        VegetationSpawner vegetation = (VegetationSpawner) target;
        
        EditorGUILayout.LabelField("City Building Options", EditorStyles.boldLabel);

        vegetation.numItemsToSpawn = EditorGUILayout.IntSlider("Number of Trees to Spawn.", vegetation.numItemsToSpawn, 0, 100);
        vegetation.numOfGrassToSpawn = EditorGUILayout.IntSlider("Number of Grass to Spawn.", vegetation.numOfGrassToSpawn, 0, 100);
        
        EditorGUILayout.LabelField(" ");
        EditorGUILayout.LabelField("City Size Options", EditorStyles.boldLabel);
        vegetation.xSpread = EditorGUILayout.Slider("X - Spread", vegetation.xSpread, 0f, 100);
        vegetation.ySpread = EditorGUILayout.Slider("Y - Spread", vegetation.ySpread, 0f, 100);
        vegetation.zSpread = EditorGUILayout.Slider("Z - Spread", vegetation.zSpread, 0f, 100);
    }
}
