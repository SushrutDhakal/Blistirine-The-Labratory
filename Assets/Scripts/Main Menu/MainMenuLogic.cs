using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLogic : MonoBehaviour
{    
    public void playButton()
    {
        SceneManager.LoadScene(sceneName: "GameLevelOne");
    }

    public void optionsButton()
    {
        SceneManager.LoadScene("Options");
    }

    public void tutorialButton()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void leaveGame()
    {
        Application.Quit();
    }
}
