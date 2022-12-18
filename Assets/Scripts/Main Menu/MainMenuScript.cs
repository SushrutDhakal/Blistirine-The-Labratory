using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void Play()
    {
        //SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("GameLevelOne");
    }
    
    public void Exit ()
    {
        Application.Quit();
    }
}
