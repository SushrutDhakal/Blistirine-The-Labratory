using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePainting : MonoBehaviour
{
    public GameObject painting, key;
    public bool hasDrawerKey;
    private bool canRotate = true;

    void Update()
    {
        if (transform.localRotation.eulerAngles.z == 90) 
        {
            canRotate = false;
        }

    }


    void Start()
    {
        hasDrawerKey = false;
        painting.SetActive(true);
        key.SetActive(false);
    }
    public void Use()
    {
        if (canRotate) 
        {
            transform.Rotate(0f, 0f, 10f);
        }

        key.SetActive(true);
        hasDrawerKey = true;
    }
}
