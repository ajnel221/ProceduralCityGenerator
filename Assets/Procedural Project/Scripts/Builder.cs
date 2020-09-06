using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Builder : MonoBehaviour
{
    public int[] rotateStuff;
    public BuilderScriptable scriptable;

    [Header("Text That Displays Random Current Seed")]
    public GameObject seedText;

    [HideInInspector]
    public bool randomSeed;

    [Header("The Spawning Object/Parent")]
    public GameObject spawner;

    [Header("The Buildings/Objects That Will Be Spawned")]
    public GameObject[] buildings;
    
    [HideInInspector]
    public int mapWidth;
    
    [HideInInspector]
    public int mapHeigt;
    
    [HideInInspector]
    public int buildingFootprint;

    [HideInInspector]
    public float seed;
    
    [HideInInspector]
    public float manualSeed;

    void Start()
    {
        SpawnCity();
    }

    public void SpawnCity()
    {
        if(randomSeed == true)
        {
            seed = Random.Range(0, 100);
            seedText.SetActive(true);
            seedText.GetComponent<Text>().text = "Seed: " + seed.ToString();

            for (int h = 0; h < mapHeigt; h++)
            {
                for (int w = 0; w < mapWidth; w++)
                {
                    int result = (int) (Mathf.PerlinNoise(w/10.0f + seed, h/10.0f + seed) * 10);
                    Vector3 pos = new Vector3(w * buildingFootprint, 0, h * buildingFootprint);

                    if(result < 2)
                    {
                        int rot = Random.Range(0, rotateStuff.Length);
                        if(rot == 0)
                        {
                            GameObject newSpawn = Instantiate(buildings[0], pos, Quaternion.Euler(0, 90, 0));
                            newSpawn.transform.SetParent(spawner.transform, false);
                        }

                        else
                        {
                            GameObject newSpawn = Instantiate(buildings[0], pos, Quaternion.Euler(0,0,0));
                            newSpawn.transform.SetParent(spawner.transform, false);
                        }
                    }

                    else if(result < 4)
                    {
                        int rot = Random.Range(0, rotateStuff.Length);
                        if(rot == 0)
                        {
                            GameObject newSpawn = Instantiate(buildings[1], pos, Quaternion.Euler(0, 90, 0));
                            newSpawn.transform.SetParent(spawner.transform, false);
                        }

                        else
                        {
                            GameObject newSpawn = Instantiate(buildings[1], pos, Quaternion.Euler(0, 0, 0));
                            newSpawn.transform.SetParent(spawner.transform, false);
                        }
                    }

                    else if(result < 5)
                    {
                        int rot = Random.Range(0, rotateStuff.Length);
                        if(rot == 0)
                        {
                            GameObject newSpawn = Instantiate(buildings[2], pos, Quaternion.Euler(0, 90, 0));
                            newSpawn.transform.SetParent(spawner.transform, false);
                        }

                        else
                        {
                            GameObject newSpawn = Instantiate(buildings[2], pos, Quaternion.Euler(0, 0, 0));
                            newSpawn.transform.SetParent(spawner.transform, false);
                        }
                    }

                    else if(result < 6)
                    {
                        GameObject newSpawn = Instantiate(buildings[3], pos, Quaternion.identity);
                        newSpawn.transform.SetParent(spawner.transform, false);
                    }

                    else if(result < 7)
                    {
                        GameObject newSpawn = Instantiate(buildings[4], pos, Quaternion.identity);
                        newSpawn.transform.SetParent(spawner.transform, false);
                    }
                
                    else if(result < 10)
                    {
                        GameObject newSpawn = Instantiate(buildings[5], pos, Quaternion.identity);
                        newSpawn.transform.SetParent(spawner.transform, false);
                    }
                }   
            }
        }

        else if(randomSeed == false)
        {
            seedText.SetActive(false);
            
            for (int h = 0; h < mapHeigt; h++)
            {
                for (int w = 0; w < mapWidth; w++)
                {
                    int result = (int) (Mathf.PerlinNoise(w/10.0f + manualSeed, h/10.0f + manualSeed) * 10);
                    Vector3 pos = new Vector3(w * buildingFootprint, 0, h * buildingFootprint);

                    if(result < 2)
                    {
                        int rot = Random.Range(0, rotateStuff.Length);
                        if(rot == 0)
                        {
                            GameObject newSpawn = Instantiate(buildings[0], pos, Quaternion.Euler(0, 90, 0));
                            newSpawn.transform.SetParent(spawner.transform, false);
                        }

                        else
                        {
                            GameObject newSpawn = Instantiate(buildings[0], pos, Quaternion.Euler(0,0,0));
                            newSpawn.transform.SetParent(spawner.transform, false);
                        }
                    }

                    else if(result < 4)
                    {
                        int rot = Random.Range(0, rotateStuff.Length);
                        if(rot == 0)
                        {
                            GameObject newSpawn = Instantiate(buildings[1], pos, Quaternion.Euler(0, 90, 0));
                            newSpawn.transform.SetParent(spawner.transform, false);
                        }

                        else
                        {
                            GameObject newSpawn = Instantiate(buildings[1], pos, Quaternion.Euler(0, 0, 0));
                            newSpawn.transform.SetParent(spawner.transform, false);
                        }
                    }

                    else if(result < 5)
                    {
                        int rot = Random.Range(0, rotateStuff.Length);
                        if(rot == 0)
                        {
                            GameObject newSpawn = Instantiate(buildings[2], pos, Quaternion.Euler(0, 90, 0));
                            newSpawn.transform.SetParent(spawner.transform, false);
                        }

                        else
                        {
                            GameObject newSpawn = Instantiate(buildings[2], pos, Quaternion.Euler(0, 0, 0));
                            newSpawn.transform.SetParent(spawner.transform, false);
                        }
                    }

                    else if(result < 6)
                    {
                        GameObject newSpawn = Instantiate(buildings[3], pos, Quaternion.identity);
                        newSpawn.transform.SetParent(spawner.transform, false);
                    }

                    else if(result < 7)
                    {
                        GameObject newSpawn = Instantiate(buildings[4], pos, Quaternion.identity);
                        newSpawn.transform.SetParent(spawner.transform, false);
                    }
                
                    else if(result < 10)
                    {
                        GameObject newSpawn = Instantiate(buildings[5], pos, Quaternion.identity);
                        newSpawn.transform.SetParent(spawner.transform, false);
                    }
                }   
            }
        }
    }

    public void DeleteCity()
    {
        for (int i = 0; i < spawner.transform.childCount; i++)
        {
            GameObject.DestroyImmediate(spawner.transform.GetChild(i).gameObject);
        }
    }

    public void ActivateRandomSeed()
    {
        randomSeed = true;
    }

    public void DeactivateRandomSeed()
    {
        randomSeed = false;
    }

    public void ScriptableCitySpawn()
    {
        if(scriptable.randomSeedActive == false)
        {
            for (int h = 0; h < scriptable.mapHeight; h++)
            {
                for (int w = 0; w < scriptable.mapWidth; w++)
                {
                    int result = (int) (Mathf.PerlinNoise(w/10.0f + scriptable.seed, h/10.0f + scriptable.seed) * 10);
                    Vector3 pos = new Vector3(w * scriptable.buildingFootprint, 0, h * scriptable.buildingFootprint);

                    if(result < 2)
                    {
                        int rot = Random.Range(0, rotateStuff.Length);
                        if(rot == 0)
                        {
                            GameObject newSpawn = Instantiate(scriptable.buildings[0], pos, Quaternion.Euler(0, 90, 0));
                            newSpawn.transform.SetParent(spawner.transform, false);
                        }

                        else
                        {
                            GameObject newSpawn = Instantiate(scriptable.buildings[0], pos, Quaternion.Euler(0, 0, 0));
                            newSpawn.transform.SetParent(spawner.transform, false);
                        }
                    }

                    else if(result < 4)
                    {
                        int rot = Random.Range(0, rotateStuff.Length);
                        if(rot == 0)
                        {
                            GameObject newSpawn = Instantiate(scriptable.buildings[1], pos, Quaternion.Euler(0, 90, 0));
                            newSpawn.transform.SetParent(spawner.transform, false);
                        }

                        else
                        {
                            GameObject newSpawn = Instantiate(scriptable.buildings[1], pos, Quaternion.Euler(0, 0, 0));
                            newSpawn.transform.SetParent(spawner.transform, false);
                        }
                    }

                    else if(result < 5)
                    {
                        int rot = Random.Range(0, rotateStuff.Length);
                        if(rot == 0)
                        {
                            GameObject newSpawn = Instantiate(scriptable.buildings[2], pos, Quaternion.Euler(0, 90, 0));
                            newSpawn.transform.SetParent(spawner.transform, false);
                        }

                        else
                        {
                            GameObject newSpawn = Instantiate(scriptable.buildings[2], pos, Quaternion.Euler(0, 0, 0));
                            newSpawn.transform.SetParent(spawner.transform, false);
                        }
                    }

                    else if(result < 6)
                    {
                        GameObject newSpawn = Instantiate(scriptable.buildings[3], pos, Quaternion.identity);
                        newSpawn.transform.SetParent(spawner.transform, false);
                    }

                    else if(result < 7)
                    {
                        GameObject newSpawn = Instantiate(scriptable.buildings[4], pos, Quaternion.identity);
                        newSpawn.transform.SetParent(spawner.transform, false);
                    }
                
                    else if(result < 10)
                    {
                        GameObject newSpawn = Instantiate(scriptable.buildings[5], pos, Quaternion.identity);
                        newSpawn.transform.SetParent(spawner.transform, false);
                    }
                }   
            }
        }

        else if(scriptable.randomSeedActive == true)
        {
            for (int h = 0; h < scriptable.mapHeight; h++)
            {
                for (int w = 0; w < scriptable.mapWidth; w++)
                {
                    int result = (int) (Mathf.PerlinNoise(w/10.0f + scriptable.randomSeed, h/10.0f + scriptable.randomSeed) * 10);
                    Vector3 pos = new Vector3(w * scriptable.buildingFootprint, 0, h * scriptable.buildingFootprint);

                    if(result < 2)
                    {
                        int rot = Random.Range(0, rotateStuff.Length);
                        if(rot == 0)
                        {
                            GameObject newSpawn = Instantiate(scriptable.buildings[0], pos, Quaternion.Euler(0, 90, 0));
                            newSpawn.transform.SetParent(spawner.transform, false);
                        }

                        else
                        {
                            GameObject newSpawn = Instantiate(scriptable.buildings[0], pos, Quaternion.Euler(0, 0, 0));
                            newSpawn.transform.SetParent(spawner.transform, false);
                        }
                    }

                    else if(result < 4)
                    {
                        int rot = Random.Range(0, rotateStuff.Length);
                        if(rot == 0)
                        {
                            GameObject newSpawn = Instantiate(scriptable.buildings[1], pos, Quaternion.Euler(0, 90, 0));
                            newSpawn.transform.SetParent(spawner.transform, false);
                        }

                        else
                        {
                            GameObject newSpawn = Instantiate(scriptable.buildings[1], pos, Quaternion.Euler(0, 0, 0));
                            newSpawn.transform.SetParent(spawner.transform, false);
                        }
                    }

                    else if(result < 5)
                    {
                        int rot = Random.Range(0, rotateStuff.Length);
                        if(rot == 0)
                        {
                            GameObject newSpawn = Instantiate(scriptable.buildings[2], pos, Quaternion.Euler(0, 90, 0));
                            newSpawn.transform.SetParent(spawner.transform, false);
                        }

                        else
                        {
                            GameObject newSpawn = Instantiate(scriptable.buildings[2], pos, Quaternion.Euler(0, 0, 0));
                            newSpawn.transform.SetParent(spawner.transform, false);
                        }
                    }

                    else if(result < 6)
                    {
                        GameObject newSpawn = Instantiate(scriptable.buildings[3], pos, Quaternion.identity);
                        newSpawn.transform.SetParent(spawner.transform, false);
                    }

                    else if(result < 7)
                    {
                        GameObject newSpawn = Instantiate(scriptable.buildings[4], pos, Quaternion.identity);
                        newSpawn.transform.SetParent(spawner.transform, false);
                    }
                
                    else if(result < 10)
                    {
                        GameObject newSpawn = Instantiate(scriptable.buildings[5], pos, Quaternion.identity);
                        newSpawn.transform.SetParent(spawner.transform, false);
                    }
                }   
            }
        }
    }
}
