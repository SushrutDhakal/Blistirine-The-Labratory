using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDoor : MonoBehaviour
{
    public SoulPickup pickup;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && pickup.hasKey == true) //colliding with player 
        {
            SceneManager.LoadScene(sceneName: "GameLevelTwo");
        }
    }
}
