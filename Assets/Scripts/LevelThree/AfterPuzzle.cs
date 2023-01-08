using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterPuzzle : MonoBehaviour
{
    public GameObject Dialogue;
    public GameObject script;
    
    void Start()
    {
        if (MainWire.PuzzleComplete)
        {
            Dialogue = GameObject.Find("Canvas");
            Dialogue = Dialogue.transform.GetChild(5).gameObject;
            Dialogue.SetActive(true);

        }
    }
}
