using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    int min = 1;
    int max = 100;
    int guess;


    // Start is called before the first frame update
    void Start()
    {
        WriteMessage();
        NextGuess();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Key pressed");
            min = guess + 1;
            NextGuess();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Key pressed");
            max = guess - 1;
            NextGuess();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Key pressed");
            Debug.Log("Fertig");
        }
    }

    private void WriteMessage()
    {
        Debug.Log("Number Wizard");
        Debug.Log("Pick a number between 1 and 100");
    }

    public void NextGuess()
    {
        guess = (min + max) / 2;
        //Debug.Log("Guess " + guess);
        Debug.Log("Is your number higher or lower than " + guess);
    }

    public void numberIsHigher()
    {
        Debug.Log("Button pressed");
        min = guess + 1;
        NextGuess();
    }

    public void numberIsLower()
    {
        Debug.Log("Button pressed");
        max = guess - 1;
        NextGuess();
    }

    public void finishGame()
    {
        Debug.Log("Button pressed");
        Debug.Log("Fertig");
    }

}
