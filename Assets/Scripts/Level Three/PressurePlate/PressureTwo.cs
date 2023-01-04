using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureTwo : MonoBehaviour
{
    public bool pressureTwo = false;
    private float timeStart = 100f; //how long they have after pressure plate is touched to escape 
    public bool openTwo = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("box")) //colliding with player 
        {
            timeStart = 100f; //reset timer every time player steps on plate 
            pressureTwo = true;
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
        if (pressureTwo == true)
        {
            timeStart -= Time.deltaTime;
            if (timeStart > 0)
            {
                openTwo = true;
            }

            else
            {
                openTwo = false;
            }

        }
    }
}

