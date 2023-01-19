using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ThreeSoulPickup : MonoBehaviour
{
    private SoulInv inventory;
    public GameObject soulButton, soulMessage;
    public AudioSource pickUp;
    public bool hasKey = false;
    public bool wireFixed;
    public Animator dooranimation;

    public MainWire fixd;

    private void Update()
    {
        wireFixed = fixd.wiresFixed;
    }

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<SoulInv>();
    }


    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player") //colliding with player 
        {
            soulMessage.SetActive(true);

            if (wireFixed) 
            {
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
                        dooranimation.SetBool("open", true);
                        //door animation
                    }
                }
            }
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            soulMessage.SetActive(false);
            // Hide the text element
        }
    }
}