using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shelf : MonoBehaviour
{
    public GameObject shelfOpened, book, tooFar;
    public ShelfCollision touch;
    private bool collide;


    // Start is called before the first frame update
    void Start()
    {
        shelfOpened.SetActive(false);
    }

    void Update()
    {
        collide = touch.touchingShelf;
    }

    void OnMouseDown()
    {
        if (collide)
        {
            shelfOpened.SetActive(true);
        }

        if (!collide)
        {
            StartCoroutine(tooFarMessage());
            shelfOpened.SetActive(false);
        }
    }

    IEnumerator tooFarMessage()
    {
        tooFar.SetActive(true);
        yield return new WaitForSeconds(2);
        tooFar.SetActive(false);
    }
}
