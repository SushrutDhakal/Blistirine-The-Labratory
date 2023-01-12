using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeBook : MonoBehaviour
{
    public GameObject openedBook, openedShelf;

    public void close()
    { 
        openedBook.SetActive(false);
        openedShelf.SetActive(true);
    }
}
