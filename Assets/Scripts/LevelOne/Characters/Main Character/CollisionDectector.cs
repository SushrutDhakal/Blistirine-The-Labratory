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

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            changehealth.TakeDamage(0.8f);
        }
    }

}