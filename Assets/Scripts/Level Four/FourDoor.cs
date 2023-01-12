using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FourDoor : MonoBehaviour
{
    public FourSoul soul;
    private bool escape;


    void Update()
    {
        escape = soul.gotSoul;

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && escape) //colliding with player 
        {
            SceneManager.LoadScene(sceneName: "MainMenu");
        }
    }
}
