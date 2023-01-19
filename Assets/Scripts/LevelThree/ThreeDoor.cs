using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThreeDoor : MonoBehaviour
{
    public ThreeSoulPickup pickup;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && pickup.hasKey == true) //colliding with player 
        {
            NPCDetection.DialogueComplete = false;
            SceneManager.LoadScene(sceneName: "GameLevelFour");
        }
    }
}
