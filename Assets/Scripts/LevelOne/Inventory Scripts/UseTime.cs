using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseTime : MonoBehaviour
{
    Countdown changetime;

    private void Start()
    {
        changetime = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Countdown>();
    }

    public void Use()
    {
        changetime.addTime();
        Destroy(gameObject);
    }
}