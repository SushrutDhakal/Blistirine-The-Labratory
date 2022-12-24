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
        bc.enabled = false; //hide enemy on start 
        mysprite.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        showEnemy();
    }

    void showEnemy() 
    {
        TimeStart = Mathf.RoundToInt(countdown.timeStart);

        //if the rounded time is 0, then show the enemy and transform to that position

        if (TimeStart == 0)
        {
            bc.enabled = true;
            mysprite.enabled = true;
            tf.position = new Vector3(7.76f, 3.5f, 0);
        }
    }
}

    

