using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    public Rigidbody2D rb;

    public int jumpForce;
    public Transform groundPoint;

    public LayerMask groundLayer;

    public bool grounded;

    // Start is called before the first frame update
    void Start()
    {
      
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
}
