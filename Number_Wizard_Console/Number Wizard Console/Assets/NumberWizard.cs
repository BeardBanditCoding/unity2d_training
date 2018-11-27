using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    //Class Variables
    int maxNum;
    int minNum;
    int guess;

    // Use this for initialization
    void Start () {

        StartGame();
 
	}

    // Update is called once per frame
    void Update()
    {
        // Validate if the up arrow key was pressed
        // Selected key is pressed continue code block
        if (Input.GetKeyDown(KeyCode.UpArrow)) {

            minNum = guess;
            NextGuess();

        }
        // Vlaidate if down arrow was pressed
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {

            maxNum = guess;
            NextGuess();

        }
        // Validate if return was pressed
        else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("I, the PC, have won!");
            StartGame();
        }

	  }

    void StartGame() {

        maxNum = 1000;
        minNum = 1;
        guess = 500;

        Debug.Log("Welcome to number wizard");
        Debug.Log("Please pick a number... and tell no one what it is!");
        Debug.Log("The highest number can be no greater than: " + maxNum);
        Debug.Log("The lowest number can be no less than: " + minNum);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push up = Higher, Push down = Lower, Push Enter equals = Correct");

        maxNum = maxNum + 1;

    }

    void NextGuess() {

        guess = (maxNum + minNum) / 2;
        Debug.Log("Was my guess higher or lower than: " + guess);

    }
}
