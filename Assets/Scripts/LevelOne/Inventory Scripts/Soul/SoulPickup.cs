using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SoulPickup : MonoBehaviour
{
    private SoulInv inventory;
    public GameObject soulButton;
    [SerializeField] TextMeshProUGUI pickupMessage;
    public bool hasKey = false;
    public bool hasCollided = false;
    public GameController guess;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<SoulInv>();
        pickupMessage.gameObject.SetActive(false);
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player") //colliding with player 
        {
            hasCollided = true;

            if (guess.correctGuess == true)
            {

                pickupMessage.gameObject.SetActive(true);
                hasCollided = false;

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
            // Hide the text element
            hasCollided = false;
            pickupMessage.gameObject.SetActive(false);
        }
    }
}