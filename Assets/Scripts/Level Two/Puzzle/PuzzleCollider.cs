using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleCollider : MonoBehaviour
{
    public GameObject puzzle;
    private bool first;

    void Start()
    {
        puzzle.SetActive(false);
    }

    private void OnCollisionStay2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && first == false)
        {
            puzzle.SetActive(true);
            first = true;
        }

    }

}