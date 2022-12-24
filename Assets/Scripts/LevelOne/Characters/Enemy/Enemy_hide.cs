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
    int TimeStart;

    // Start is called before the first frame update
    void Start()
    {
        bc.enabled = false;
        mysprite.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(timeStart);
        timeOver();
    }

    void timeOver()
    {
        TimeStart = Mathf.RoundToInt(countdown.timeStart);

        Debug.Log(countdown.timeStart);

        if (countdown.timeStart > 0 && countdown.timeStart < 1)
        {
            light2D.intensity = 1f;
        }

        if (TimeStart == 0)
        {
            light2D.intensity = 0.15f;
            bc.enabled = true;
            mysprite.enabled = true;
            tf.position = new Vector3(7.76f, 3.5f, 0);
        }
    }
}
