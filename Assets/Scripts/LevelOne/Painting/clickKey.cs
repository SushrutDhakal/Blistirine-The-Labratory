using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickKey : MonoBehaviour
{
    public bool hasDrawerKey;
    // Start is called before the first frame update
    void Start()
    {
        hasDrawerKey = false;
    }

    void OnMouseDown()
    {
        Debug.Log("sui");
        hasDrawerKey = true;

    }
}
