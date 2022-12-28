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

    public void Use()
    {
        monster.freezeMonster();
        Destroy(gameObject);
    }
}
