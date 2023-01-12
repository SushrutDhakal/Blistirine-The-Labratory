using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OnePickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;
    [SerializeField] TextMeshProUGUI pickupMessage;
    private static Inventory savedData;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        pickupMessage.gameObject.SetActive(false);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player")) //colliding with player 
        {
            pickupMessage.gameObject.SetActive(true);
            if (Input.GetKey("e")) { 
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
    }

    void OnMouseDown()
    {
        Debug.Log("sui");
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

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Hide the text element
            pickupMessage.gameObject.SetActive(false);
        }
    }
}
