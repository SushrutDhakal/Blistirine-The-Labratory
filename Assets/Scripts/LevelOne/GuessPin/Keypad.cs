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

    void Start()
    {
        Ans.text = "";
    }

    public void Number(int number)
    {
        if (Ans.text.Length < 4)
        {
            SoundManager.PlaySound("pin");
            Ans.text += number.ToString();
        }

        else { Ans.text = ""; }
        
    }

    public void compareGuess()
    {

        if (int.Parse(Ans.text) == password.pin)
        {
            guessMessage.text = "Press E to Pick Up key and take it to the door!";
            guessMessage.gameObject.SetActive(true);

            correctGuess = true;
            keypad.SetActive(false);
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


