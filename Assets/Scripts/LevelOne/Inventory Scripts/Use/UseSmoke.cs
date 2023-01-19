using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseSmoke : MonoBehaviour
{
    public GameObject effect;
    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    //Create the smoke effect 
    public void Use()
    {
        SoundManager.PlaySound("smoke");
        Instantiate(effect, player.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
