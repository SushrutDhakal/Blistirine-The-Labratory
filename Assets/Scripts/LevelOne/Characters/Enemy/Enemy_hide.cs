using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_hide : MonoBehaviour
{
    public UnityEngine.Rendering.Universal.Light2D light2D;
    public SpriteRenderer mysprite;
    public Countdown countdown;
    public Transform tf;
    public BoxCollider2D bc;
    public bool monsterAlive = false;
    int TimeStart;

    float defaultLight = 0.6f;
    float monsterLight = 0.15f;
    float midwayLight = 0.37f;

    // Start is called before the first frame update
    void Start()
    {
        hideEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        timeOver();
        StartCoroutine(lightFlicker());

    }

    void timeOver()
    {
        TimeStart = Mathf.RoundToInt(countdown.timeStart);
        if (TimeStart == 0)
        {
            showEnemy();
        }
    }

    void hideEnemy()
    {
        bc.enabled = false;
        mysprite.enabled = false;
    }

    void showEnemy()
    {
        monsterAlive = true;
        light2D.intensity = monsterLight;
        bc.enabled = true;
        mysprite.enabled = true;
        tf.position = new Vector3(7.76f, 3.5f, 0);
    }

    IEnumerator lightFlicker() //play around with this to change flicker times and stuff
    {
        if (countdown.timeStart > 0 && countdown.timeStart < 1f) { 
            yield return new WaitForSeconds(.5f); //delay 
            light2D.intensity = midwayLight;
            yield return new WaitForSeconds(.5f);
            light2D.intensity = defaultLight;
            yield return new WaitForSeconds(.5f);
            light2D.intensity = monsterLight;
            yield return new WaitForSeconds(.5f);
        }
    }
}
