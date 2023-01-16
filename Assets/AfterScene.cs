using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AfterScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveScene());
    }

    IEnumerator MoveScene ()
    {
        yield return new WaitForSeconds(17f);
        SceneManager.LoadScene("MainMenu");
    }
}
