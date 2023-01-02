using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleCollider : MonoBehaviour
{
    public GameObject puzzle, collectables;

    void Start()
    {
        puzzle.SetActive(false);
    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collectables.SetActive(false);
            puzzle.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collectables.SetActive(true);
            puzzle.SetActive(false);
        }
    }

}