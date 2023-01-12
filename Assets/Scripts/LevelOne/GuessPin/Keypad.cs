using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Keypad : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Ans;
    [SerializeField] TextMeshProUGUI guessMessage;

    [SerializeField] ShowNote password;
    public bool correctGuess = false;
    public GameObject keypad;

    public void Number(int number)
    {
        Ans.text += number.ToString();
    }


    public void compareGuess()
    {
        //int guess = Ans.text;
        //int.Parse(Ans.text);

        if (int.Parse(Ans.text) == password.pin)
        {
            guessMessage.text = "Press E to Pick Up key and take it to the door!";
            guessMessage.gameObject.SetActive(true);

            correctGuess = true;
            keypad.SetActive(false);

            //the "soul key" will be trapped inside some barrier colliders
            //guess option will pop up when player collides with barrier
            //if guess is right, player will be able to pick up key to exit 
        }

        else
        {
            correctGuess = false;
            guessMessage.text = "Wrong Pin! Try Again";
            guessMessage.gameObject.SetActive(true);
        }

        Ans.text = "";
    }
}


