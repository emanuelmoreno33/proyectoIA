﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{

public static int score =0;
public string ScoreString = "Puntaje: \r\n";

public Text TextScore;


public static GameController Gamecontroller;

void Awake()
{
	Gamecontroller = this;
}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TextScore != null){
            TextScore.text = ScoreString + score.ToString();
    }
}
}