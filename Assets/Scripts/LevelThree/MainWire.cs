using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainWire : MonoBehaviour
{
    public GameObject Dialogue;
    static public MainWire Instance;
    
    public int successCount = 4;
    private int onCount = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void CountChange (int points)
    {
        onCount = onCount + points;
        if (onCount == successCount)
        {
            SceneManager.LoadScene("GameLevelThree");
            Debug.Log("Success!");
            Countdown.resumeData = true;
        }
    }


}
