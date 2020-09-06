using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWalls : MonoBehaviour
{
    public GameObject container;
    float distanceTem;
    bool creating;
    bool dragging;
    bool starting = true;
    public GameObject start;
    public GameObject end;
    private GameObject spawnStart;
    private GameObject spawnEnd;
    private GameObject spawnEndTemp;
    public GameObject wallPrefab;
    private GameObject wall;




    //Gate
    float distanceGateTem;
    bool creatingGate;
    bool draggingGate;
    bool startingGate = true;
    public GameObject startGate;
    public GameObject endGate;
    private GameObject spawnStartGate;
    private GameObject spawnEndGate;
    private GameObject spawnEndTempGate;
    public GameObject entrancePrefab;
    private GameObject entrance;









    void Update()
    {
        GetInput();
    }

    public void GetInput()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SetStart();
            dragging = true;
            starting = false;
        }

        else if(Input.GetMouseButtonUp(0))
        {
            SetEnd();
            dragging = false;
        }

        else
        {
            if(creating)
            {
                Adjust();
            }
        }

        if(Input.GetMouseButtonDown(1))
        {
            SetGateStart();
            draggingGate = true;
            startingGate = false;
        }

        else if(Input.GetMouseButtonUp(1))
        {
            SetGateEnd();
            draggingGate = false;
        }

        else
        {
            if(creatingGate)
            {
                AdjustGateFunction();
            }
        }
    }

    public void SetStart()
    {
        creating = true;
        spawnStart = Instantiate(start, getWorldPoint(), Quaternion.identity);
        spawnEndTemp = Instantiate(end, getWorldPoint(), Quaternion.identity);

        spawnStart.transform.SetParent(container.transform, false);
        spawnEndTemp.transform.SetParent(container.transform, false);

        wall = Instantiate(wallPrefab, start.transform.position, Quaternion.identity);
        wall.transform.SetParent(container.transform, false);
    }

    public void SetEnd()
    {
        creating = false;
        Destroy(spawnEndTemp);
        spawnEnd = Instantiate(end, getWorldPoint(), spawnStart.transform.rotation);
        spawnEnd.transform.SetParent(container.transform, false);
        Adjust();
    }

    public void Adjust()
    {
        spawnEndTemp.transform.position = getWorldPoint();
        AdjustWall();
    }

    public void AdjustWall()
    {
        if(dragging == true)
        {
            spawnStart.transform.LookAt(spawnEndTemp.transform.position);
            spawnEndTemp.transform.LookAt(spawnStart.transform.position);
            distanceTem = Vector3.Distance(spawnStart.transform.position, spawnEndTemp.transform.position);
            wall.transform.position = spawnStart.transform.position + distanceTem/2 * spawnStart.transform.forward;
            wall.transform.rotation = spawnStart.transform.rotation;
            wall.transform.localScale = new Vector3(wall.transform.localScale.x, wall.transform.localScale.y, distanceTem);
        }

        if(starting == false && dragging == false)
        {
            spawnStart.transform.LookAt(spawnEnd.transform.position);
            spawnEnd.transform.LookAt(spawnStart.transform.position);
        }
    }

    Vector3 getWorldPoint()
    {
        Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            return hit.point;
        }
        return Vector3.zero;
    }







    //Gate
    public void SetGateStart()
    {
        creatingGate = true;
        spawnStartGate = Instantiate(startGate, getWorldPoint(), Quaternion.identity);
        spawnEndTempGate = Instantiate(endGate, getWorldPoint(), Quaternion.identity);

        spawnStartGate.transform.SetParent(container.transform, false);
        spawnEndTempGate.transform.SetParent(container.transform, false);

        entrance = Instantiate(entrancePrefab, startGate.transform.position, Quaternion.identity);
        entrance.transform.SetParent(container.transform, false);
    }

    public void SetGateEnd()
    {
        creatingGate = false;
        Destroy(spawnEndTempGate);
        spawnEndGate = Instantiate(endGate, getWorldPoint(), spawnStartGate.transform.rotation);
        spawnEndGate.transform.SetParent(container.transform, false);
        AdjustGate();
    }

    public void AdjustGateFunction()
    {
        spawnEndTempGate.transform.position = getWorldPoint();
        AdjustGate();
    }

    public void AdjustGate()
    {
        if(draggingGate == true)
        {
            spawnStartGate.transform.LookAt(spawnEndTempGate.transform.position);
            spawnEndTempGate.transform.LookAt(spawnStartGate.transform.position);
            distanceGateTem = Vector3.Distance(spawnStartGate.transform.position, spawnEndTempGate.transform.position);
            entrance.transform.position = spawnStartGate.transform.position + distanceGateTem/2 * spawnStartGate.transform.forward;
            entrance.transform.rotation = spawnStartGate.transform.rotation;
            entrance.transform.localScale = new Vector3(entrance.transform.localScale.x, entrance.transform.localScale.y, distanceGateTem);
        }

        if(startingGate == false && draggingGate == false)
        {
            spawnStartGate.transform.LookAt(spawnEndTempGate.transform.position);
            spawnEndTempGate.transform.LookAt(spawnStartGate.transform.position);
        }
    }
}
