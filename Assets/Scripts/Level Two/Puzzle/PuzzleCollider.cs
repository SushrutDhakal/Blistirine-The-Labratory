using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleCollider : MonoBehaviour
{
    public GameObject puzzle, puzzlebook;

    void Start()
    {
        puzzle.SetActive(false);
        puzzlebook.SetActive(true);
    }

    private void OnMouseDown() 
    {
        puzzlebook.SetActive(false);
        puzzle.SetActive(true);
    }
}