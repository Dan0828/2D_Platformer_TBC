using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareScript : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public float moveSpeed = 12;
    private float moveInput;

    void Start()
    {
        rigidBody = GetComponent<RigidBody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            rigidBody.velocity = Vector2.up * 18;
        }

        moveInput = moveInput.GetAxis("Horizontal");
        rigidBody.velocity = new Vector2(moveInput * moveSpeed, rigidBody.velocity.y);
       
    }
}
