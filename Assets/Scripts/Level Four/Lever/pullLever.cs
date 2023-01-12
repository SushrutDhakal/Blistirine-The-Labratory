using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pullLever : MonoBehaviour
{
    public bool pulledLever = false;
    public GameObject brokenGlass, pulled;
    void OnMouseDown()
    {
        pulledLever = true;
        brokenGlass.SetActive(false);
        pulled.SetActive(true);
    }
}