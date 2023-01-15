using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxDetectionScript : MonoBehaviour
{
    public GameObject wirematch;
    void Start ()
    {
        wirematch.SetActive(false);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            wirematch.SetActive(true);
        }
    }
}
