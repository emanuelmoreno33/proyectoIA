using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickVerdura : MonoBehaviour
{
    [SerializeField]
    private Camera arCamara;

    [SerializeField]
    private GameObject Verdura;

    [SerializeField]
    private VidaScript Vida;

    [SerializeField]
    private PointScript Points;

    private Vector2 touchPosicion = default;
    
    // Update is called once per frame
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

                if (Physics.Raycast(ray, out hitObject))
                {
                    PlacementObject placementObjects = hitObject.transform.GetComponent<PlacementObject>();
                    if (placementObjects != null)
                    {
                        if (placementObjects.gameObject == Verdura)
                        {
                            Vida.Changelife();
                            Points.removePoints(10);
                        }
                    }
                }
            }

        }
    }
}
