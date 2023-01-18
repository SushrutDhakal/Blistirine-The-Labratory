using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainWire : MonoBehaviour
{
    public GameObject wires, wintext;
    static public MainWire Instance;
    public UnityEngine.Rendering.Universal.Light2D light2D;

    public int successCount = 4;
    private int onCount = 0;
    public bool wiresFixed = false;

    private void Awake()
    {
        Instance = this;
    }


    public void CountChange(int points)
    {
        onCount = onCount + points;
        if (onCount == successCount)
        {
            StartCoroutine(showHide());
            light2D.intensity = 0.6f;
            wiresFixed = true;
            wires.SetActive(false);
        }
    }

    IEnumerator showHide()
    {
        wintext.SetActive(true);
        yield return new WaitForSeconds(3);
        wintext.SetActive(false);

    }
}

