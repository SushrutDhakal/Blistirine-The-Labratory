using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class lavaDamage : MonoBehaviour
{
    HealthManager changehealth;

    void Start()
    {
        changehealth = GameObject.FindGameObjectWithTag("HealthManager").GetComponent<HealthManager>();
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player")) //colliding with player 
        {
            changehealth.TakeDamage(0.1f);
        }
    }
}