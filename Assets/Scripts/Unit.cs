﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    private Game Game;

    // Start is called before the first frame update
    void Start()
    {
        Game = GameObject.Find("Game").GetComponent<Game>();

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("d");
        Game.DebugConsole.Log(Input.GetAxis("Horizontal"),"Horizontal value: ");
    }
}
