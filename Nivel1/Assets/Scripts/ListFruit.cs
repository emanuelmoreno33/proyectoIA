using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListFruit : MonoBehaviour
{
    [SerializeField]
    private  PlacementObject Arbol;

    [SerializeField]
    public static List<Fruta> ListaFrutas;

    void Awake()
    {
        ListaFrutas = new List<Fruta>();
    }
    void Update()
    {
        
    }
    public static void EndFrutas(GameObject arg2)
    {
        int contador = 0;
        foreach (Fruta fruit in ListaFrutas)
        {
            if (fruit.IsActivated != false)
            {
                contador++;
            }
        }
        if (contador == 0)
        {
            arg2.SetActive(true);

        }
        else
        {
        }
    }

}
