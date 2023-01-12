using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TwoSoulPickup : MonoBehaviour
{
    private SoulInv inventory;
    public GameObject soulButton, soulMessage;
    public openBook key;

    public bool hasKeycard = false;
    public bool hasSoul = false;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<SoulInv>();
    }

    void Update()
    {
        hasKeycard = key.openedBook;
        Debug.Log(hasKeycard);
    }


    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player") //colliding with player 
        {

            if (hasKeycard)
            {
                soulMessage.SetActive(true);
                if (Input.GetKey("e"))
                {
                    if (inventory.isFull[0] == false)
                    {
                        //add item
                        inventory.isFull[0] = true;
                        hasSoul = true;
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
            soulMessage.SetActive(false);
        }
    }
}