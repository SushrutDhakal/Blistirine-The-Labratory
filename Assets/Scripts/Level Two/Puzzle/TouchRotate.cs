using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotate : MonoBehaviour
{
    public GameObject puzzleBoard;
    public GameControl complete;

    void Update()
    {
        if (complete.puzzleSolved) 
        { 
            StartCoroutine(hidePuzzle());
        }
    }

    IEnumerator hidePuzzle()
    {
        yield return new WaitForSeconds(1);

        puzzleBoard.SetActive(false);
    }

    private void OnMouseDown()
    {
        if (!complete.puzzleSolved)
        {
            SoundManager.PlaySound("puzzleMove");
            transform.Rotate(0f, 0f, 90f);
        }
    }
}


