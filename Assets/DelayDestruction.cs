using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayDestruction : MonoBehaviour
{
    public GameObject obj;

    private void Start()
    {
        StartCoroutine(Dialogues());
    }

    IEnumerator Dialogues ()
    {
        yield return new WaitForSeconds(5.7f);
        Destroy(obj);
    }

}
