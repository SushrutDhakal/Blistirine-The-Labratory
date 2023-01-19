using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionDectector : MonoBehaviour
{

    //Calling player heatlh manager script 
    HealthManager changehealth;
    public AudioSource damage;

    void Start ()
    {
        //Getting correct component 
        changehealth = GameObject.FindGameObjectWithTag("HealthManager").GetComponent<HealthManager>();
    }

    private void OnCollisionStay2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy") //if colliding with player
        {
            changehealth.TakeDamage (0.8f); //deal 0.8 damage to the player's health out of 100 
            damage.Play (); // play a sound
        }
    }
}