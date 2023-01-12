using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FourSoul : MonoBehaviour
{
    private SoulInv inventory;
    public GameObject soulButton, soulMessage, noLever;
    public pullLever key;

    public bool hasKeycard = false;
    public bool gotSoul = false;
    private bool hasLever;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<SoulInv>();
    }

    void Update()
    {
        hasLever = key.pulledLever;
        Debug.Log(hasLever);
    }


    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player") //colliding with player 
        {

            if (hasLever)
            {
                soulMessage.SetActive(true);
                if (Input.GetKey("e"))
                {
                    if (inventory.isFull[0] == false)
                    {
                        //add item
                        inventory.isFull[0] = true;
                        gotSoul = true;
                        Instantiate(soulButton, inventory.slots[0].transform, false);
                        Destroy(gameObject);
                    }
                }
            }

            else
            { 
                noLever.SetActive(true);
            }
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            soulMessage.SetActive(false);
        }
    }
}