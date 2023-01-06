using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeDrawer : MonoBehaviour
{
    public GameObject drawer;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void drawerClose()
    {
        drawer.SetActive(false);
    }

}
