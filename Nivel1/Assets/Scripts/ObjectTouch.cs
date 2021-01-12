using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.SceneManagement;

public class ObjectTouch : MonoBehaviour
{

    [SerializeField]
    private PlacementObject[] placedObjects;

    [SerializeField]
    private Color inactive = Color.gray;

    [SerializeField]
    private Color activated = Color.red;

    [SerializeField]
    private Camera arCamara;

    private Vector2 touchPosicion = default;


    void Awake()
    {
        ChangeSelectedObj(placedObjects[0]);
        //Boton.onClick.AddListener(contar);
    }
    //void contar()

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch posicion = Input.GetTouch(0);
            touchPosicion = posicion.position;

            if (posicion.phase == TouchPhase.Began)
            {
                Ray ray = arCamara.ScreenPointToRay(posicion.position);
                RaycastHit hitObject;

                if (Physics.Raycast(ray,out hitObject))
                {
                    PlacementObject placementObjects = hitObject.transform.GetComponent<PlacementObject>();
                    if (placementObjects != null)
                    {
                        ChangeSelectedObj(placementObjects);
                    }
                }
            }

        }
    }

    void ChangeSelectedObj(PlacementObject selected)
    {
        foreach (PlacementObject current in placedObjects)
        {
            MeshRenderer meshRenderer = current.GetComponent<MeshRenderer>();
            if (selected != current)
            {
                current.IsSelected = false;
                meshRenderer.material.color = inactive;
            }
            else
            {
                current.IsSelected = true;
                meshRenderer.material.color = activated;
            }
        }
    }

}
