using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseHealth : MonoBehaviour
{
    HealthManager changehealth;
    private Transform player;
    public GameObject explosionEffect;

    private void Start()
    {
        changehealth = GameObject.FindGameObjectWithTag("HealthManager").GetComponent<HealthManager>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void Use()
    {
        Instantiate(explosionEffect, player.transform.position, Quaternion.identity);
        changehealth.Heal(20);
        Destroy(gameObject);
    }

}