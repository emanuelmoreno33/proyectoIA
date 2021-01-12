using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruta : MonoBehaviour
{
    public bool IsActivated{ get; set; }

    [SerializeField]
    public int Valor;

    public Fruta()
    {
        IsActivated = true;
    }
}
