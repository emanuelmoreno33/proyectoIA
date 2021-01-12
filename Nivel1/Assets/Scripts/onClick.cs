using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onClick : MonoBehaviour
{
    [SerializeField]
    private Camera arCamara;

    [SerializeField]
    private GameObject pnGanador;

    [SerializeField]
    private PointScript ScriptPoints;

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
                    Fruta placementObjects = hitObject.transform.GetComponent<Fruta>();
                    if (placementObjects != null)
                    {
                        ListFruit.ListaFrutas.Find(x => x.transform.position == placementObjects.transform.position).IsActivated = false;
                        placementObjects.IsActivated = false;
                        placementObjects.gameObject.SetActive(false);
                        ScriptPoints.addPoints(placementObjects.Valor);
                        ListFruit.EndFrutas(pnGanador);
                    }
                }
            }

        }
    }
}
