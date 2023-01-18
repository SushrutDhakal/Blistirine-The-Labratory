using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enemyHealth : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 100f;

    public bool enemyAlive = true;
    public GameObject bossEnemy, lava, rock, ammo, deadText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {//rgb
        if (healthAmount <= 0)
        {
            deadText.SetActive(true);
            lava.SetActive(false);
            ammo.SetActive(false);
            rock.SetActive(true);
            enemyAlive = true; //enemy dies
            bossEnemy.SetActive(false);
        }
    }

    public void TakeDamage(float damage)
    {
        healthAmount -= damage;
        healthBar.fillAmount = healthAmount / 100f;
    }

}

