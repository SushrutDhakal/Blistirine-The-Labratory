using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionDectector : MonoBehaviour 
{ 
    HealthManager changehealth; 

    void Start()
    {
        changehealth = GameObject.FindGameObjectWithTag("HealthManager").GetComponent<HealthManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            changehealth.TakeDamage(20);
        }
    }
}

