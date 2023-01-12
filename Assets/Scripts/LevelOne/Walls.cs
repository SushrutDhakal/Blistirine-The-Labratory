using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    public UnityEngine.Rendering.Universal.Light2D light2D;
    public Countdown time;


    float defaultLight = 0.6f;
    float monsterLight = 0.15f;
    float midwayLight = 0.37f;

    // Update is called once per frame
    void Update()
    {
        if (time.timeStart <= 0)
        {
            StartCoroutine(lightFlicker());
        }
    }

    IEnumerator lightFlicker() //play around with this to change flicker times and stuff
    {
        if (Countdown.monsterSpawned)
        {
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
