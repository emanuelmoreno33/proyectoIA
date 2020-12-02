using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
public class OnClickTree : MonoBehaviour
{
    [SerializeField]
    private GameObject Arbol;

    [SerializeField]
    private Fruta fruta;

    [SerializeField]
    private GameObject Verdura;

    private GameObject[] frutaspawn;
    private GameObject[] verduraspawn;

    [SerializeField]
    private Camera arCamara;

    private Vector2 touchPosicion = default;

    private bool click;

    void Awake()
    { 
        click = false;
    }
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
                        if (placementObjects.gameObject == Arbol)
                        {
                            if(click == false)
                            {
                                frutaspawn = new GameObject[5];
                                verduraspawn = new GameObject[2];
                                for (int i = 0; i < 5; i++)
                                {
                                    frutaspawn[i] = Instantiate(fruta.gameObject, new Vector3(gameObject.transform.position.x + Random.Range((float)-0.06, (float)0.06), gameObject.transform.position.y, gameObject.transform.position.z - Random.Range((float)0.015, (float)0.06)), Quaternion.identity);
                                }
                                for (int i = 0; i < 2; i++)
                                {
                                    verduraspawn[i] = Instantiate(Verdura, new Vector3(gameObject.transform.position.x + Random.Range((float)-0.06, (float)0.06), gameObject.transform.position.y, gameObject.transform.position.z - Random.Range((float)0.015, (float)0.06)), Quaternion.identity);
                                }
                                click = true;
                            }
                        }
                    }
                }
            }
        }
    }
}
