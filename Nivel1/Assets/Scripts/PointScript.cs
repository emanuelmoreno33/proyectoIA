using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointScript : MonoBehaviour
{
    [SerializeField]
    private Text Display;

    private int points;
    void Start()
    {
        points = 0;
    }

    public void addPoints(int Valor)
    {
        points += Valor;
        Display.text = points.ToString(); 
    }
    public void removePoints(int Valor)
    {
        points -= Valor;
        Display.text = points.ToString();
    }
}
