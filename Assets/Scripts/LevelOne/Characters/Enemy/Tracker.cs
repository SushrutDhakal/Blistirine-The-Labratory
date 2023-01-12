using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracker : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform player;
    public Rigidbody2D rb;
    private Vector2 movement;
    public Animator myanimation;
    public SpriteRenderer mysprite;
    private bool freeze = false;
    public Sprite frozone;
    private static Vector2 copiedPos;

    // Start is called before the first frame update
    void Start()
    {
        rb.freezeRotation = true;

        if (Countdown.resumeData && Countdown.monsterSpawned)
        {
            transform.position = copiedPos;
            Debug.Log(copiedPos);
        }
    }

    // Update is called once per frame
    void Update()
    {

        float anim_x = 0f;
        float anim_y = 0f;

        Vector3 direction = player.position - transform.position;
        direction.Normalize();
        movement = direction;



        if (movement.x < 0)
        {
            mysprite.flipX = true;
        }

               
        if (movement.x > 0)
        {
            mysprite.flipX = false;
        }

        if (Mathf.Abs(movement.x) > Mathf.Abs(movement.y))
        {
            anim_x = 1f;
            anim_y = 0f;
        }
        
        if (Mathf.Abs(movement.x) < Mathf.Abs(movement.y))
        {
            if (movement.y > 0)
            {
                anim_x = 0f;
                anim_y = 1f;
            }
            
            if (movement.y < 0)
            {
                anim_x = 0f;
                anim_y = -1f;
            }
        }

        myanimation.SetFloat("Vertical", anim_y);
        myanimation.SetFloat("Horizontal", anim_x);

        copiedPos = transform.position;

        if (freeze == true)
        {
            gameObject.GetComponent<Animator>().enabled = false;
            GetComponent<SpriteRenderer>().sprite = frozone; 
        }
    }

    private void FixedUpdate()
    {
        StartCoroutine(moveCharacter(movement));
    }

    public void freezeMonster()
    {
        freeze = true;
    }

    IEnumerator moveCharacter(Vector2 direction)
    {
        if (freeze == false)
        {
            gameObject.GetComponent<Animator>().enabled = true;
            rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
        }

        if (freeze == true) //frozen
        {
            rb.MovePosition((Vector2)transform.position + (direction * 0 * Time.deltaTime));
            yield return new WaitForSeconds(5); //how long enemy frozen for 
            freeze = false;
        }
    }



}