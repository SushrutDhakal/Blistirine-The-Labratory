using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxDetectionScript : MonoBehaviour
{
    void Start ()
    {
        if (MainWire.PuzzleComplete)
        {
            Destroy(this);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            SceneManager.LoadScene("WireMatch");
        }
    }
}
