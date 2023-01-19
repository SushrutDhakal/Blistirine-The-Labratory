using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseFreeze : MonoBehaviour
{
    Tracker monster;

    private void Start()
    {
        monster = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Tracker>();
    }

    //Freeze enemy and destroy gameobject 
    public void Use()
    {
        SoundManager.PlaySound("freeze");
        monster.freezeMonster();
        Destroy(gameObject);
    }
}
