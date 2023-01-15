using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThirdDoor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && Countdown.resumeData) //colliding with player 
        {
            SceneManager.LoadScene(sceneName: "GameLevelFour");
            Countdown.resumeData = false;
            Countdown.monsterSpawned = false;
        }
    }
}
