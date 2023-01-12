using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverColllider : MonoBehaviour
{
    public hammerPressure hammer;
    public GameObject broke;
    public bool touchingLever;
    public pullLever lever;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) //colliding with player 
        {
            touchingLever= true;
            broke.SetActive(true);
        }

        if (lever.pulledLever)
        {
            broke.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")) //colliding with player 
        {
            touchingLever = false;

            broke.SetActive(false);
        }
    }
}
