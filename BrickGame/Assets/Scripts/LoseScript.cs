﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.UI;


public class LoseScript : MonoBehaviour {


    LevelManager levelManager = new LevelManager();
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collison");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        levelManager.LoadNewScene("Lose");
    }
}
