using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButtons : MonoBehaviour
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
