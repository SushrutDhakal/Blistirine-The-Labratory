using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelThreeDoor : MonoBehaviour
{
    public ThreeSoulPickup soul;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && soul.hasSoul == true) //colliding with player 
        {
            SceneManager.LoadScene(sceneName: "GameLevelThree");
        }
    }
}
