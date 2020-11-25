using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClick : MonoBehaviour
{
    [SerializeField]
    private GameObject obj;

    [SerializeField]
    private Camera arCamara;

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
                        if(placementObjects.gameObject == obj)
                        {
                            obj.SetActive(false);
                        }
                    }
                }
            }

        }
    }
}
