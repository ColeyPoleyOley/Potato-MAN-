using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator anim;
    public Rigidbody2D rb;

    public int jumpForce;
    public Transform groundPoint;

    public LayerMask groundLayer;

    bool grounded;

    public GameObject deathEffect;

    public GameObject gameOver;



    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    //Update method used for phydics in our game, becaues it happens fixed amount of times
    private void FixedUpdate()
    {
        grounded = Physics2D.OverlapPoint(groundPoint.position,groundLayer);
    }//end Fixed Update

    // Update is called once per frame
    void Update()
    {
        if (grounded && Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
            rb.AddForce(Vector2.up * jumpForce);
            


        }//end if

        anim.SetFloat("yVelocity", rb.velocity.y);
        anim.SetBool("Grounded", grounded);
    }

    public void GameOver()
    {
       
            
            GameManager.instance.cameraa.followPlayer = false;
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            gameOver.SetActive(true);
            Destroy(gameObject);
        
    }
}
