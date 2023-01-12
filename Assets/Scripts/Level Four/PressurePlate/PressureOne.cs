using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//add a opening/closing door and when the person/box steps on pressure plate
//door fully opens and in that countdown time, the door slowly closes 

public class PressureOne : MonoBehaviour
{
    public bool openOne = false;
    public bool boxPressOne = false;
    public bool playerPressOne = false;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) //colliding with player 
        {
            openOne = true;
            playerPressOne = true;
        }

        if (other.CompareTag("box"))
        {
            openOne = true;
            boxPressOne = true;
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
