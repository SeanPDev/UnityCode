﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CapsuleCollider playerCollider;
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        playerCollider = GetComponent<CapsuleCollider>();
        playerCollider.height = 1.0f;
        playerCollider.center = new Vector3(0f,0.5f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        //Capture the movement in variables
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //Create a vector3 to hold all the values together
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        //Move the player, allows the movement to be smooth using Time.deltatime
        transform.Translate(movement * Time.deltaTime * moveSpeed);

    }
}

/* To make a character move you have to attach a player script to a character game object.
Then you create variables to hold the input of the horizontal and vertical axis.
Then you Create a new vector3 to hold all the values, setting y = 0, since there is no jumping. 
Then you use the transform.Translate function with the movement variable you created, and multiply that 
against Time.deltatTime for smooth movement. You also multiply it versus moveSpeed to make it faster or slower. 

*/