using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePuzzle : MonoBehaviour
{
    public GameObject puzzle, puzzlebook;

    public void Use()
    {
        puzzle.SetActive(false);
        puzzlebook.SetActive(true);
    }
}
