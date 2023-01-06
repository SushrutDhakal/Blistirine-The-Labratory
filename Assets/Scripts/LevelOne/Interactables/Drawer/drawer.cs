using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawer : MonoBehaviour
{
    public GameObject opened;
    // Start is called before the first frame update
    void Start()
    {
        opened.SetActive(false);
    }

    void OnMouseDown()
    {
        opened.SetActive(true);

    }
}
