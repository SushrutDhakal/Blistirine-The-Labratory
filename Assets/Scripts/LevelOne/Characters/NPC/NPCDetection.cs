using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDetection : MonoBehaviour
{
    public GameObject Dialogue;
    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("hello");
            Dialogue = GameObject.Find("Canvas");
            Dialogue = Dialogue.transform.GetChild(4).gameObject;
            Dialogue.SetActive(true);
        }
    }
}
