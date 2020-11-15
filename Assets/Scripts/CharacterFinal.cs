﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//This scrits makes the character move when the screen is pressed and handles the jump
public class CharacterFinal : MonoBehaviour
{
    public bool jump = false;               // Condition for whether the player should jump.	
    public float jumpForce = 10.0f;         // Amount of force added when the player jumps.
    private bool grounded = false;          // Whether or not the player is grounded.
    public int movementSpeed = 10;          // The vertical speed of the movement
    private Animator anim;                  // The animator that controls the characters animations
    public bool slide= false;
    public GameObject ingamedisplay;

    void Awake()
    {
        Debug.Log("Awake");
        ingamedisplay.SetActive(true);
        anim = GetComponent<Animator>();
    }


    //This method is called when the character collides with a collider (could be a platform).
    void OnCollisionEnter2D(Collision2D hit)
    {
        grounded = true;

    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        if (Input.GetButtonDown("Vertical")){
            Slide();
            
        }
    }

    //The update method is called many times per seconds
    public void Jump()
    {
        Debug.Log("Jump is pressed");
        // If the jump button is pressed and the player is grounded and the character is running forward then the player should jump.
        if (grounded == true)
        {
            jump = true;
            grounded = false;
            //We trigger the Jump animation state
            anim.SetTrigger("Jump");
        }



    }

    public void Slide()
    {
        if (grounded == true)
        {
            slide = true;
            //We trigger the Jump animation state
            anim.SetTrigger("slide");
        }

    }

    //Since we are using physics for movement, we use the FixedUpdate method
    void FixedUpdate()
    {

        //if died that 
        GetComponent<Rigidbody2D>().velocity = new Vector2(movementSpeed, GetComponent<Rigidbody2D>().velocity.y);
        //else
        //moving


        // If jump is set to true we add a quick force impulse for the jump
        if (jump == true)
        {
            // Add a vertical force to the player.
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);

            // We set the variable to false again to avoid adding force constantly
            jump = false;
        }

        if (slide == true)
        {
            // Add a negative vertical force to the player.
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, -jumpForce), ForceMode2D.Impulse);


            // We set the variable to false again to avoid adding force constantly
            slide = false;
        }
    }
}
