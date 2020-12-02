using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spam : MonoBehaviour
{
    public GameObject objectoToSpawn;
    private PlacementIndicator placementIndicator;

    void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            GameObject obj = Instantiate(objectoToSpawn, placementIndicator.transform.position, placementIndicator.transform.rotation);

        }
    }
}
