using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class escapeDoor : MonoBehaviour
{
    // Start is called before the first frame update
    public enemyHealth alive;
    public bool isAlive;

    public GameObject effect;
    private Transform player;

    void Update()
    {
        isAlive = alive.enemyAlive;
    }

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && isAlive == true) //colliding with player 
        {
            StartCoroutine(Use());
        }
    }

    IEnumerator Use()
    {
        SoundManager.PlaySound("smoke");
        Instantiate(effect, player.position, Quaternion.identity);

        yield return new WaitForSeconds(3);

        SceneManager.LoadScene(sceneName: "MainMenu");
    }


    // Update is called once per frame

}
