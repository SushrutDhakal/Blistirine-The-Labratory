using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    public float timeStart = 40; //how long timer 
    public Enemy_hide monster;
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

        if ((Mathf.Round(timeStart)) == 5)
        {
            Debug.Log("sound");
            SoundManager.PlaySound("alarm");
        }
        if (timeStart <= 0)
        {
            textBox.text = "";
        }
    }

    public void addTime()
    {
        if (monster.monsterAlive == false)
        {
            timeStart = timeStart + 10;
        }
        else { }
    }
}


