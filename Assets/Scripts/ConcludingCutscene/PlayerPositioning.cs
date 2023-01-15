using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositioning : MonoBehaviour
{
    public float movementSpeed = 5f;
    public Rigidbody2D myrigidbody;
    public SpriteRenderer mysprite;
    public Animator myanimation;
    Vector2 movement;
    Vector3 forward;
    Vector3 backword;

    void Start()
    {
        myrigidbody.freezeRotation = true;
    }


    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {

        if (movement.x > 0)
        {
            mysprite.flipX = false;
        }
        if (movement.x < 0)
        {
            mysprite.flipX = true;
        }
        myrigidbody.velocity = movement * movementSpeed;

    }
}