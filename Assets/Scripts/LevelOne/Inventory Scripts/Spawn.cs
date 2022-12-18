using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject item;
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void SpawnDroppedItem()
    { 
        Vector2 playerPos = new Vector2(player.position.x+2, player.position.y);//make the item spawn little infront of player
        Instantiate(item, playerPos, Quaternion.identity); //make the dropped item spawn with no rotation
    }
}
