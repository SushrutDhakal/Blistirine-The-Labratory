using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openBook : MonoBehaviour
{
    public GameObject book, shelfOpened;
    public GameControl puzzle;
    public BoxCollider2D bc;

    public bool openedBook;

    void OnMouseDown()
    {
        shelfOpened.SetActive(false);
        book.SetActive(true);
        openedBook = true;
    }

    void Update()
    {
        if (puzzle.puzzleSolved)
        {
            bc.enabled = true;
        }

        else
        { bc.enabled = false; }
    }
}
