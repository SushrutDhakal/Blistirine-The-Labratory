using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armedPlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    public Rigidbody2D myrigidbody;

    public Camera cam;
    Vector2 mousePos;

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

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

    }
    void FixedUpdate()
    {
        myrigidbody.velocity = movement * movementSpeed;

        Vector2 lookDir = mousePos - myrigidbody.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;

        myrigidbody.rotation = angle;

    }
}
