using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField input;

    private int num;
    private int guessNumber;

    void Awake()
    {
        num = 1234;
    }
    public void GetInput(string guess)
    {
        //Debug.Log(guess);
        compareGuess(int.Parse(guess));
        input.text = "";
    }

    void compareGuess(int guess)
    {
        if (guess == num)
        {
            Debug.Log("correct guess");
            //the "soul key" will be trapped inside some barrier colliders
            //guess option will pop up when player collides with barrier
            //if guess is right, player will be able to pick up key to exit 
        }

        else
        {
            Debug.Log("wrong guess");
        }
        
    }
}
