using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ExitOptions : MonoBehaviour
{
    public void leaveGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}