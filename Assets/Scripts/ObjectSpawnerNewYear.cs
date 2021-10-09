using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawnerNewYear : MonoBehaviour
{
    public GameObject objectToSpawn;
    public List<GameObject> objectToSpawnList;
    private PlacementIndicator placementIndicator;

    void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();
    }

    void Update()
    {
        if (Input.touchCount > 2 && Input.touches[0].phase == TouchPhase.Began)
        {
            GameObject obj = Instantiate(objectToSpawn, placementIndicator.transform.position, placementIndicator.transform.rotation);
        }
        else if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            GameObject obj = Instantiate(objectToSpawnList[Random.Range(0, objectToSpawnList.Count)], placementIndicator.transform.position, placementIndicator.transform.rotation);
        }
    }
}
