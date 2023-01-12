using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openBook : MonoBehaviour
{
    public GameObject book, shelfOpened;

    public bool openedBook;

    void OnMouseDown()
    {
        shelfOpened.SetActive(false);
        book.SetActive(true);
        openedBook = true;
    }
}
