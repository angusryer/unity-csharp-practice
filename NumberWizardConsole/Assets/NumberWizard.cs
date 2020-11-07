using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {

        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number that is within the following range:");
        Debug.Log("Highest number: " + max);
        Debug.Log("Lowest number: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push UP for higher, DOWN for lower, and ENTER if the guess is correct.");

        max += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Debug.Log("You guessed " + guess);
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Tell me if your number is higher or lower than " + guess);
    }
}
