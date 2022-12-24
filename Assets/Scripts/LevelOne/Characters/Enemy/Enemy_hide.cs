using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_hide : MonoBehaviour
{

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
        showEnemy();
    }

    void showEnemy()
    {
        TimeStart = Mathf.RoundToInt(countdown.timeStart);

        if (TimeStart == 0)
        {
            bc.enabled = true;
            mysprite.enabled = true;
            tf.position = new Vector3(7.76f, 3.5f, 0);
        }
    }
}

    

