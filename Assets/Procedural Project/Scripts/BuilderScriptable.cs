using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BuildingData", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class BuilderScriptable : ScriptableObject
{
    public bool randomSeedActive;
    public GameObject[] buildings;
    public float seed;
    public float randomSeed;
    public int mapWidth;
    public int mapHeight;
    public int buildingFootprint;

    public void RandomSeed()
    {
        randomSeed = Random.Range(0,100);
    }
}
