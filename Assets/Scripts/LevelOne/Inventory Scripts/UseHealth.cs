using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseHealth : MonoBehaviour
{
    HealthManager changehealth;
    private Transform player;

    private void Start()
    {
        changehealth = GameObject.FindGameObjectWithTag("HealthManager").GetComponent<HealthManager>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void Use()
    {
        //potion drinking sound
        changehealth.Heal(20);
        Destroy(gameObject);
    }
}