using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassColorChange : MonoBehaviour
{
    public GameObject Grass;

    void Update()
    {
        StartCoroutine(ColorChange());
    }

    IEnumerator ColorChange()
    {
        yield return new WaitForSeconds(11.3f);
        Grass.GetComponent<Renderer>().material.color = new Color(94, 40, 16);
    }
}