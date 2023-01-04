using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//add a opening/closing door and when the person/box steps on pressure plate
//door fully opens and in that countdown time, the door slowly closes 

public class PressureOne : MonoBehaviour
{
    public bool pressureOne = false;
    private float timeStart = 100f; //how long they have after pressure plate is touched to escape 
    public bool openOne = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("box")) //colliding with player 
        {
            SoundManager.PlaySound("pressure");
            timeStart = 100f; //reset timer every time player steps on plate 
            pressureOne = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("box")) //colliding with player 
        {
            SoundManager.PlaySound("pressure");
        }
    }

    void Update()
    {
        if (pressureOne == true)
        {
            timeStart -= Time.deltaTime;
            if (timeStart > 0)
            {
                openOne = true;
            }

            else
            {
                openOne = false;
            }

        }
    }
}
