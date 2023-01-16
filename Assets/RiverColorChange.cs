using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiverColorChange : MonoBehaviour
{
    public GameObject River;
    public AudioSource scream;
    
    void Start()
    {
        StartCoroutine(ColorChange());
    }

    IEnumerator ColorChange ()
    {
        yield return new WaitForSeconds(11.3f);
        River.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
        scream.Play();
    }
}
