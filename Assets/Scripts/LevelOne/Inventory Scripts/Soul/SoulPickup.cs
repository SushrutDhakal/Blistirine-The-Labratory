using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SoulPickup : MonoBehaviour
{
    private SoulInv inventory;
    public GameObject soulButton, keypad;
    public AudioSource pickUp;
    [SerializeField] private TextMeshProUGUI Ans;

    public bool hasKey = false;
    public Keypad guess;

    private void Start()
    {
        keypad.SetActive(false);

        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<SoulInv>();
    }


    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player") //colliding with player 
        {
            keypad.SetActive(true);
            Ans.text = "";

            if (guess.correctGuess == true)
            {

                keypad.SetActive(false);

                if (Input.GetKey("e"))
                {
                    if (inventory.isFull[0] == false)
                    {
                        //add item
                        inventory.isFull[0] = true;
                        hasKey = true;
                        Instantiate(soulButton, inventory.slots[0].transform, false);
                        pickUp.Play();
                        Destroy(gameObject);
                    }
                }
            }
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            keypad.SetActive(false);

            // Hide the text element
        }
    }
}