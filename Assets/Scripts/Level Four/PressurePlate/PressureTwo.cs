using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureTwo : MonoBehaviour
{

    public bool openTwo = false;
    public bool boxPressTwo = false;
    public bool playerPressTwo = false;
    public blocker a;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") ) //colliding with player 
        {
            a.timeStart = 3;
            SoundManager.PlaySound("pressure");
            openTwo = true;
            playerPressTwo = true;
        }

        if (other.CompareTag("box"))
        {
            a.timeStart = 3;
            SoundManager.PlaySound("pressure");
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

