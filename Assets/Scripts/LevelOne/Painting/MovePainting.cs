using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePainting : MonoBehaviour
{
    public GameObject painting, key;
    public bool hasDrawerKey; 


    void Start()
    {
        hasDrawerKey = false;
        painting.SetActive(true);
        key.SetActive(false);
    }
    public void Use()
    {
        painting.SetActive(false);
        key.SetActive(true);
        hasDrawerKey = true;
    }
}
