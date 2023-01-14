using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakLever : MonoBehaviour
{
    public LeverColllider lever;
    public hammerPressure hammer;
    public GameObject noHammer, broke, glassLever, noGlassLever;

    void OnMouseDown()
    {
        if (lever.touchingLever)
        {
            if (!hammer.gotHammer)
            { 
                broke.SetActive(false);
                StartCoroutine(showHidetext());
            }

            if (hammer.gotHammer)
            {
                glassLever.SetActive(false);
                noGlassLever.gameObject.SetActive(true);
            }
        }     
    }

    IEnumerator showHidetext()
    {
        noHammer.SetActive(true);
        yield return new WaitForSeconds(1);
        noHammer.SetActive(false);
    }
}
