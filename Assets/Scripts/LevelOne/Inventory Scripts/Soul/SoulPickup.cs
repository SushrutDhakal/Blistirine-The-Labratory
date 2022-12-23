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

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<SoulInv>();
        pickupMessage.gameObject.SetActive(false);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        pickupMessage.gameObject.SetActive(true); ;

        //this message will activate when it collides with anything
        //if that is a problem then make the message inside 
        // other.CompareTag("Player") if statement then make 
        // Input.GetKey("e") in its own if statement with rest of code 


        if (other.CompareTag("Player") && Input.GetKey("e")) //colliding with player 
        {
            Debug.Log("binger");

            if (inventory.isFull[0] == false)
            {
                //add item
                inventory.isFull[0] = true;
                Instantiate(soulButton, inventory.slots[0].transform, false);
                Destroy(gameObject);
            } 
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Hide the text element
            pickupMessage.gameObject.SetActive(false);
        }
    }
}
