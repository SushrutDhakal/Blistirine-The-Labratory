using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawerCollision : MonoBehaviour
{
    public bool touchingDrawer;
    void Start()
    {
        touchingDrawer = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            touchingDrawer = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            touchingDrawer = false;
        }
    }
}
