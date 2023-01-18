using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeDrawer : MonoBehaviour
{
    public GameObject drawer, painting;


    public void drawerClose()
    {
        drawer.SetActive(false);
        painting.SetActive(true);
    }

}
