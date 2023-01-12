using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammerPressure : MonoBehaviour
{

    public bool gotHammer = false;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) //colliding with player 
        {
            gotHammer = true;
        }
    }
}

