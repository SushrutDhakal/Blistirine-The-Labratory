using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{

    public Image healthBar;
    public float healthAmount = 100f; //full heakth 

    // Update is called once per frame
    void Update()
    {
        //If the player dies, go to the game over scene 
        if (healthAmount <= 0)
        {
            SceneManager.LoadScene("GameOver"); //goes to gameover screen
        }

    }

    //Function to take damage from the player and update it 
    public void TakeDamage (float damage)
    {
        healthAmount -= damage;
        healthBar.fillAmount = healthAmount / 100f;
    }

    //Called when player uses syringe to heal themselves 
    public void Heal (float healingAmount)
    {
        healthAmount += healingAmount;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);//health bar range

        healthBar.fillAmount = healthAmount / 100f;
    }
}
