using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SoulPickup : MonoBehaviour
{
    private SoulInv inventory;
    public GameObject soulButton, keypad;
    //[SerializeField] TextMeshProUGUI pickupMessage;

    public bool hasKey = false;
    public Keypad guess;

    private void Start()
    {
        keypad.SetActive(false);

        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<SoulInv>();
        //pickupMessage.gameObject.SetActive(false);
    }


    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player") //colliding with player 
        {
            keypad.SetActive(true);

            if (guess.correctGuess == true)
            {


                keypad.SetActive(false);

                //pickupMessage.gameObject.SetActive(true);

                if (Input.GetKey("e"))
                {
                    if (inventory.isFull[0] == false)
                    {
                        //add item
                        inventory.isFull[0] = true;
                        hasKey = true;
                        Instantiate(soulButton, inventory.slots[0].transform, false);
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
            //pickupMessage.gameObject.SetActive(false);
        }
    }
}