using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;
    [SerializeField] TextMeshProUGUI pickupMessage;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
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

            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    //add item
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);

                    Destroy(gameObject);
                    break;
                }
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
