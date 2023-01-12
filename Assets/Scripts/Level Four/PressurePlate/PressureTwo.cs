using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureTwo : MonoBehaviour
{

    public bool openTwo = false;
    public bool boxPressTwo = false;
    public bool playerPressTwo = false;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") ) //colliding with player 
        {
            openTwo = true;
            playerPressTwo = true;
        }

        if (other.CompareTag("box"))
        {
            openTwo = true;
            boxPressTwo = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("box")) //colliding with player 
        {
            SoundManager.PlaySound("pressure");
        }
    }
}

