using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListFruit : MonoBehaviour
{
    public static List<Fruta> ListaFrutas;

    [SerializeField]
    private PlacementObject Arbol;

    void Update()
    {
        EndFrutas();
    }
    public void EndFrutas()
    {
        int contador = 0;
        foreach (Fruta fruta in ListaFrutas)
        {
            if (fruta.IsActivated != true)
            {
                contador++;
            }
        }
        if (contador <= 3)
        {
            MeshRenderer meshRenderer = Arbol.GetComponent<MeshRenderer>();
            meshRenderer.material.color = Color.black;
        }
        else
        {
            MeshRenderer meshRenderer = Arbol.GetComponent<MeshRenderer>();
            meshRenderer.material.color = Color.cyan;
        }
    }

    public void addFruta(Fruta arg)
    {
        ListaFrutas.Add(arg);
    }
}
