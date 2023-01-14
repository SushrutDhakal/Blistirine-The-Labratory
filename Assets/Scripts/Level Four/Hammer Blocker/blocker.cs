using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class blocker : MonoBehaviour
{

    public PressureOne plateOne;
    public PressureTwo plateTwo;
    public GameObject wall;

    public hammerPressure hammer;

    public float timeStart = 5; //how long they have after pressure plate is touched to escape 

    private bool canOpen;


    void Update()
    {
        if (plateOne.openOne && plateTwo.openTwo)
        {
            Debug.Log(timeStart);
            timeStart -= Time.deltaTime;
            if (timeStart > 0 )
            {
                if ((plateOne.boxPressOne || plateTwo.boxPressTwo))
                {
                    canOpen = true;
                }  
            }

            else
            {
                canOpen = false;
            }        
        }

        else
        {
            
            canOpen = false;
        }

        if (hammer.gotHammer)
        {
            wall.SetActive(false);
        }

        if (canOpen) {wall.SetActive(false); }
        if (!canOpen) { wall.SetActive(true); }
    }
}
