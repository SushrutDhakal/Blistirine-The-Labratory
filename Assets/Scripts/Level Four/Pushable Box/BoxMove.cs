using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// box filled with ghosts so they have a mind of their own and may sometimes move uncoordinated with the player
// (excuse on why the box movement is really weird ( i dont know why its like that ) 

public class BoxMove : MonoBehaviour
{
    public Rigidbody2D rb;

    void Start()
    {
        rb.freezeRotation = true;

    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rb.velocity = collision.gameObject.GetComponent<Rigidbody2D>().velocity;
        }
    }
}
