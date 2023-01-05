using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FourDoor : MonoBehaviour
{

    public PressureOne plateOne;
    public PressureTwo plateTwo;

    private bool canOpen;


    void Update()
    {
        if (plateOne.openOne && plateTwo.openTwo)
        {
            canOpen = true;
        }

        else
        {
            canOpen = false;
        }
      
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && canOpen == true) //colliding with player 
        {
            SceneManager.LoadScene(sceneName: "MainMenu");
        }
    }
}
