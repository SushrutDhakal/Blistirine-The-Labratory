using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : MonoBehaviour
{
    public float movementSpeed = 5f;
    public Rigidbody2D myrigidbody;
    //public SpriteRenderer mysprite;
    //public Animator myanimation;
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
        // Inputs 
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }
    void FixedUpdate()
    {

        myrigidbody.velocity = movement * movementSpeed;

    }
}
