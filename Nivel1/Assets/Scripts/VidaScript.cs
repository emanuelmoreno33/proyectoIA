using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaScript : MonoBehaviour
{
    [SerializeField]
    private Sprite[] Corazones;

    [SerializeField]
    private GameObject pnPerder;

    private int vida;
    void Start()
    {
        vida = 5;
        Changelife();
    }
    public void Changelife()
    {
        vida--;
        if (vida > 0)
        {
            this.GetComponent<Image>().sprite = Corazones[vida];
        }
        else
        {
            vida = 0;
            this.GetComponent<Image>().sprite = Corazones[vida];
            pnPerder.SetActive(true);
        }
    }
}
