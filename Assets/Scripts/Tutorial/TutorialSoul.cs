using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TutorialSoul : MonoBehaviour
{
    private SoulInv inventory;
    public GameObject soulButton;
    public AudioSource pickUp;
    public GameObject soulMessage;


    public bool hasKey = false;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<SoulInv>();
    }


    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player") //colliding with player 
        {
            soulMessage.SetActive(true);
            if (Input.GetKey("e"))
            {
                if (inventory.isFull[0] == false)
                {
                    //play sound
                    pickUp.Play();
                    //add item
                    inventory.isFull[0] = true;
                    hasKey = true;
                    Instantiate(soulButton, inventory.slots[0].transform, false);
                    Destroy(gameObject);
                }
            }
    }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            soulMessage.SetActive(false);
            pickUp.Play();
            // Hide the text element
        }
    }
}