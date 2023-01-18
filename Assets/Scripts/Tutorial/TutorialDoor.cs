using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialDoor : MonoBehaviour
{
    public TutorialSoul pickup;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {

            if (pickup.hasKey == true)
            {
                SceneManager.LoadScene(sceneName: "GameLevelOne");
            }
        }
    }
}
