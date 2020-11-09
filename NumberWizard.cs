using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start() {

        Debug.Log("Welcome human.. to the Number Wizard!");
        Debug.Log("Pick a number, don't tell me...");
        Debug.Log("The highest number to pick is: " + max);
        Debug.Log("The lowest number to pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than " + guess + "?");
            Debug.Log(guess);
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than " + guess + "?");
            Debug.Log(guess);
        } else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("Enter key was pressed.");
        }

    }
}
