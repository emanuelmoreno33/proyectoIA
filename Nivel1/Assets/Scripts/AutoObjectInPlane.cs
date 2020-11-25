using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class AutoObjectInPlane : MonoBehaviour
{
    [SerializeField]
    public GameObject SpawnObject;

    private GameObject obj;

    [SerializeField]
    private ARPlaneManager aRPlaneManager;

    void Awake()
    {
        aRPlaneManager = GetComponent<ARPlaneManager>();
        aRPlaneManager.planesChanged += PlaneChange;
    }

    private void PlaneChange(ARPlanesChangedEventArgs args)
    {
        if (args.added != null && obj == null)
        {
            ARPlane arPlane = args.added[0];
            obj = Instantiate(SpawnObject, arPlane.transform.position, Quaternion.identity);
        }
    }

    void Update()
    {

    }
}
