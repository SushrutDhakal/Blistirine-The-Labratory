using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    //Calling the player inventory 
    private Inventory inventory;
    public int index; //inventory index 
    private static Inventory savedData;


    //Get inventory 
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    //Save inventory and update it 
    private void Update()
    {

        var childCount = 0;
        foreach (Transform child in transform)
        {
            childCount++;
        }

        if (childCount <= 0)
        {
            inventory.isFull[index] = false;
        }
        if (!Countdown.resumeData)
        {
            savedData = inventory;
        }
    }

    //Function to drop item on ground 
    public void DropItem()
    {
        foreach (Transform child in transform)
        {
            child.GetComponent<Spawn>().SpawnDroppedItem();//item on ground
            GameObject.Destroy(child.gameObject);//remove from inventory
        }
    }
}