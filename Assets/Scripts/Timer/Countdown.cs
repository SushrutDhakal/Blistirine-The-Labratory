using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class Countdown : MonoBehaviour
{
    private float timeStart = 10; //how long timer 
    [SerializeField] TextMeshProUGUI textBox;

    // Use this for initialization
    void Start()
    {
        textBox.text = timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;
        textBox.text = Mathf.Round(timeStart).ToString();

        if (timeStart <= 0)
        {
            SceneManager.LoadScene("GameOver"); //switch to this scene
        }
    }
}


