using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ThreeSoulPickup : MonoBehaviour
{
    private SoulInv inventory;
    public GameObject soulButton;

    public bool hasSoul = false;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<SoulInv>();
    }


    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player") //colliding with player 
        {

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