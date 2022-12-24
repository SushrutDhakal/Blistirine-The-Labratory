using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    private Inventory inventory;
    public int index;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

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
    }

    public void DropItem()
    {
        foreach (Transform child in transform)
        {
            //child.GetComponent<Spawn>().SpawnDroppedItem();//item on ground
            GameObject.Destroy(child.gameObject);//remove from inventory
        }
    }
}