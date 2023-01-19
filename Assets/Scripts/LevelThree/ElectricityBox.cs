using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricityBox : MonoBehaviour
{
    public GameObject wires, wall1, wall2, collectables, canvas, timer, npc, bookshelf, monster;
    public UnityEngine.Rendering.Universal.Light2D light2D;

    private bool done;
    private bool enemy; 

    public MainWire fixd;
    public Enemy_hide hide;

    private void Update()
    {
        done = fixd.wiresFixed;
        enemy = hide.monsterAlive; 
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            light2D.intensity = 0.6f;
            wires.SetActive(true);
            wall1.SetActive(false);
            wall2.SetActive(false);
            canvas.SetActive(false);
            timer.SetActive(false);
            npc.SetActive(false);
            collectables.SetActive(false);
            bookshelf.SetActive(false);

            if (enemy)
            {
                monster.SetActive(false);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (done)
            {
                light2D.intensity = 0.6f;
            }
            else {light2D.intensity = 0.01f; }
            
            wires.SetActive(false);
            wall1.SetActive(true);
            wall2.SetActive(true);
            canvas.SetActive(true);
            timer.SetActive(true);
            npc.SetActive(true);
            collectables.SetActive(true);
            bookshelf.SetActive(true);

            if (enemy)
            {
                monster.SetActive(true);
            }
        }
    }
}