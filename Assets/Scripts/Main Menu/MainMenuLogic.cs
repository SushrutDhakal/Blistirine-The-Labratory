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

    public void leaveGame()
    {
        Application.Quit();

    }
}