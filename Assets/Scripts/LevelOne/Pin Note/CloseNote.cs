using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseNote : MonoBehaviour
{

    public GameObject Note;
    public GameObject drawerOpen;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void closeNote()
    {
        drawerOpen.SetActive(true);
        Note.SetActive(false);
    }
}
