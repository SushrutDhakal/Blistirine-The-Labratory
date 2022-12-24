using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 100f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {//rgb
        if (healthAmount <= 0)
        {
            SceneManager.LoadScene("GameOver"); //goes to gameover screen
        }

        /*if (0 < healthAmount && healthAmount < 20)
        {
            healthBar.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }

        if (20 < healthAmount && healthAmount < 40)
        {
            healthBar.color = new Color(1.0f, 0.5f, 0.0f, 1.0f);
        }

        if (40 < healthAmount && healthAmount < 60)
        {
            healthBar.color = new Color(1.0f, 1.0f, 0.0f, 1.0f);
        }

        if (60 < healthAmount && healthAmount < 80)
        {
            healthBar.color = new Color(0.5f, 1.0f, 0.0f, 1.0f);
        }

        if (80 < healthAmount && healthAmount < 100)
        {
            healthBar.color = new Color(0.0f, 1.0f, 0.0f, 1.0f);//green
        } */


        if (Input.GetKeyDown(KeyCode.Return))  //replace with enemy collision
        {
            TakeDamage(20);//how much damage player takes  
        }

        if (Input.GetKeyDown(KeyCode.Space))//replace with potion effect
        {
            Heal(20);
        }
    }

    public void TakeDamage(float damage)
    {
        healthAmount -= damage;
        healthBar.fillAmount = healthAmount / 100f;
    }

    public void Heal(float healingAmount)
    {
        healthAmount += healingAmount;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);//health bar range

        healthBar.fillAmount = healthAmount / 100f;
    }
}
