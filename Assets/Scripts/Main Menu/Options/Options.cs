using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    [SerializeField] Slider VolumeController;
    
    public void Exit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
