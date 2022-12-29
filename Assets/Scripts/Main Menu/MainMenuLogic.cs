using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLogic : MonoBehaviour
{
    public void playButton()
    {
        SceneManager.LoadScene(sceneName: "Cutscene");
    }

    public void optionsButton()
    {
        SceneManager.LoadScene("Options");
    }

    public void instructionsButton()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void leaveGame()
    {
        Application.Quit();
    }
}
