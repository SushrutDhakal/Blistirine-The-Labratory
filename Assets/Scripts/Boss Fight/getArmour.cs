using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class getArmour : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pickupMessage;

    private void Start()
    {

        pickupMessage.gameObject.SetActive(false);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("normalPlayer")) //colliding with player 
        {
            pickupMessage.gameObject.SetActive(true);
            if (Input.GetKey("e"))
            {
                SceneManager.LoadScene(sceneName: "BossFight");
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Hide the text element
            pickupMessage.gameObject.SetActive(false);
        }
    }
}
