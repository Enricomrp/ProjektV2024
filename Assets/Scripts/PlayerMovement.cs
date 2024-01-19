using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    public Animator animatior;
    public float speed;
    public float jump; 
    float moveVelocity; 
    float Timer = 1f;
     


    bool isGrounded = true;
    public void Update()
    {
        Movement();
       
    }
    void Animation()
    
    {
        if (Input.GetKeyDown(KeyCode.D))
        {   
            animatior.SetBool("Walk", true);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            animatior.SetBool("Walk", false);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            animatior.SetBool("Walk2", true);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            animatior.SetBool("Walk2", false);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            animatior.SetBool("Walk", true);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            animatior.SetBool("Walk", false);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animatior.SetBool("Walk2", true);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animatior.SetBool("Walk2", false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Timer -= Time.deltaTime;
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
        
       
    }


    void Movement()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.W))
        {
            if (isGrounded)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
                isGrounded = false;
            }
        }
        moveVelocity = 0;

       
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            moveVelocity = -speed;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            moveVelocity = speed;
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

    }
  
    void OnTriggerEnter2D()
    {
        isGrounded = true;
    }
}