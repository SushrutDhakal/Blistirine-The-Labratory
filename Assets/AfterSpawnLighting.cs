using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterSpawnLighting : MonoBehaviour    
{
    public UnityEngine.Rendering.Universal.Light2D lgt2D;

    float defaultLight = 0.6f;
    float monsterLight = 0.15f;
    float midwayLight = 0.37f;
    // Update is called once per frame
    void Update()
    {
        StartCoroutine(lightFlicker());
    }

    IEnumerator lightFlicker() //play around with this to change flicker times and stuff
    {
        if (Countdown.monsterSpawned)
        {
            yield return new WaitForSeconds(.5f); //delay 
            lgt2D.intensity = midwayLight;
            yield return new WaitForSeconds(.5f);
            lgt2D.intensity = defaultLight;
            yield return new WaitForSeconds(.5f);
            lgt2D.intensity = monsterLight;
            yield return new WaitForSeconds(.5f);
        }
    }
}
