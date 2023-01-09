using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    public static bool resumeData = false; // Accessible boolean that will be the key to store previous data before switching scenes (Enemy position, timer)
    public float timeStart = 40; //how long timer 
    public Enemy_hide monster;
    [SerializeField] TextMeshProUGUI textBox;
    public static float publicTime;


    // Use this for initialization
    void Start()
    {
        textBox.text = timeStart.ToString();
        if (resumeData)
        {
            timeStart = publicTime;
        }
        else
        {
            publicTime = timeStart;
        }

    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;
        textBox.text = Mathf.Round(timeStart).ToString();
        publicTime = timeStart;


        if ((Mathf.Round(timeStart)) == 5)
        {
            SoundManager.PlaySound("alarm");
        }
        if (timeStart <= 0)
        {
            textBox.text = "";
        }
        //Debug.Log(timeStart);
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


