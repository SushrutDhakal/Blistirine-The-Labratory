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
    public SoulPickup collision;
    public GameObject inputField;
    [SerializeField] TextMeshProUGUI guessMessage;
    public bool correctGuess = false;

    void Awake()
    {
        num = 1234;
    }

    void Start()
    {
        guessMessage.gameObject.SetActive(false);
        inputField.SetActive(false);
    }

    void Update()
    {
        if (collision.hasCollided == true)
        {
            inputField.SetActive(true);
        }

        if (collision.hasCollided == false)
        {
            inputField.SetActive(false);
            guessMessage.gameObject.SetActive(false);
        }
    }

    public void GetInput(string guess)
    {
        compareGuess(int.Parse(guess));
        input.text = "";
    }

    void compareGuess(int guess)
    {
        if (guess == num)
        {
            guessMessage.text = "Take the key to the door and leave!";
            guessMessage.gameObject.SetActive(true);
            correctGuess = true;

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
        
    }
}
