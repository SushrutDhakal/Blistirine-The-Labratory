using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(switchScene());
    }

    IEnumerator switchScene()
    {
        yield return new WaitForSeconds(16);
        SceneManager.LoadScene(sceneName: "getting Armour Scene");

    }
}
