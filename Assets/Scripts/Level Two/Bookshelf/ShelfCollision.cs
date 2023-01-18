using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfCollision : MonoBehaviour
{
    public bool touchingShelf;
    public GameObject shelfOpened;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            touchingShelf = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            touchingShelf = false;
        }
    }

    void Update()
    { 
        if (!touchingShelf) 
        {
            shelfOpened.SetActive(false);
        }
    }

}
