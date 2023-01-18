using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawer : MonoBehaviour
{
    public GameObject opened, lockedMessage, tooFar, painting;
    public MovePainting drawerKey;
    public drawerCollision touch;

    private bool collide; 
    // Start is called before the first frame update
    void Start()
    {
        opened.SetActive(false);
        lockedMessage.SetActive(false);
    }

    void Update()
    {
        collide = touch.touchingDrawer;
    }

    void OnMouseDown()
    {
        if (drawerKey.hasDrawerKey && collide)
        {
            opened.SetActive(true);
            painting.SetActive(false);
        }

        if (!drawerKey.hasDrawerKey && collide)
        {
            StartCoroutine(noKeyMessage());
        }

        if (!collide)
        {
            StartCoroutine(tooFarMessage());
        }
    }

    IEnumerator noKeyMessage()
    {
        lockedMessage.SetActive(true);
        yield return new WaitForSeconds(2);
        lockedMessage.SetActive(false);
    }

    IEnumerator tooFarMessage()
    {
        tooFar.SetActive(true);
        yield return new WaitForSeconds(2);
        tooFar.SetActive(false);
    }
}
