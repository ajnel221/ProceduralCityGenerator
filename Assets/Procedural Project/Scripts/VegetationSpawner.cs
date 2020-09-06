using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VegetationSpawner : MonoBehaviour
{
    public GameObject treesToSpread;
    public GameObject grassPrefab;
    public GameObject grassObject;

    [HideInInspector]
    public int numItemsToSpawn;

    [HideInInspector]
    public int numOfGrassToSpawn;

    [HideInInspector]
    public float xSpread;

    [HideInInspector]
    public float ySpread;

    [HideInInspector]
    public float zSpread;

    void Start() 
    {
        if(numItemsToSpawn > 0)
        {
            for (int i = 0; i < numItemsToSpawn; i++)
            {
                SpreadItem();
            }
        }
        
        if(numOfGrassToSpawn > 0)
        {
            for (int r = 0; r < numOfGrassToSpawn; r++)
            {
                SpreadGrass();
            }
        }
    }

    public void SpreadItem()
    {
        Vector3 randomPos = new Vector3 (Random.Range(-xSpread, xSpread), Random.Range(-ySpread, ySpread), Random.Range(-zSpread, zSpread));
        GameObject clone = Instantiate(treesToSpread, randomPos, Quaternion.identity);
        clone.transform.SetParent(grassObject.transform, false);
        clone.transform.localScale = new Vector3(5,500,5);
    }

    public void SpreadGrass()
    {
        Vector3 randomGrassPos = new Vector3 (Random.Range(-xSpread, xSpread), Random.Range(-ySpread, ySpread), Random.Range(-zSpread, zSpread));
        GameObject cloneGrass = Instantiate(grassPrefab, randomGrassPos, Quaternion.identity);
        cloneGrass.transform.SetParent(grassObject.transform, false);
        cloneGrass.transform.localScale = new Vector3(5,500,5);
    }
}