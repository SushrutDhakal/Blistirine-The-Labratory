using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeDrawer : MonoBehaviour
{
    public GameObject drawer, painting, playerLight;


    public void drawerClose()
    {
        drawer.SetActive(false);
        painting.SetActive(true);
        playerLight.SetActive(true);
    }

}
