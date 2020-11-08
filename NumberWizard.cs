﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start() {

        Debug.Log("Welcome to Number Wizard, human");
        Debug.Log("Pick a number, don't tell me...");
        Debug.Log("The highest number to pick is: " + max);
        Debug.Log("The lowest number to pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Debug.Log("Up Arrow key was pressed.");
            min = guess;
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            Debug.Log("Down Arrow key was pressed.");
        } else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("Enter key was pressed.");
        }

    }
}
