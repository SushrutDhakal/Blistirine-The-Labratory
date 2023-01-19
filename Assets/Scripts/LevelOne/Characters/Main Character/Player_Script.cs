using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Main player script 

public class Player_Script : MonoBehaviour
{

    //Intializing variables 
    public float movementSpeed = 5f;
    public Rigidbody2D myrigidbody;
    public SpriteRenderer mysprite;
    public Animator myanimation; //for animation

    //For the player movement
    Vector2 movement;
    Vector3 forward;
    Vector3 backword;
   
    void Start ()
    {

        //Turn off rotation
        myrigidbody.freezeRotation = true;
    }
        

    // Update is called once per frame
    void Update ()
    {
        // Inputs  
        movement.x = Input.GetAxisRaw ("Horizontal");
        movement.y = Input.GetAxisRaw ("Vertical");

        //Animation based on inputs 
        myanimation.SetFloat ("Vertical", movement.y);
        myanimation.SetFloat ("Horizontal", Mathf.Abs (movement.x));

      
    }
    void FixedUpdate ()
    {
        //Flip direction of sprite based on movement    
        if (movement.x > 0)
        {
            mysprite.flipX = false;
        }
        if (movement.x  < 0)
        {
            mysprite.flipX = true;
        }

        //Move players rigid body 
        myrigidbody.velocity = movement * movementSpeed;

    }
}
