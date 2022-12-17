using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseHealth : MonoBehaviour
{

    private Transform player;
    public GameObject explosionEffect;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void Use()
    {
        Instantiate(explosionEffect, player.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}