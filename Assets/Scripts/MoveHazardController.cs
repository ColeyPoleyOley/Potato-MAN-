﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHazardController : MonoBehaviour
{
    public int moveVel = 5;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameManager.instance.shield < 1)
        {
 
            GameManager.instance.player.GameOver();
        }
        else
        {
            GameManager.instance.shield -= 1;
            GameManager.instance.shieldCounter -= 1;
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > GameManager.instance.endPosition.position.x)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(GameManager.instance.endPosition.position.x, transform.position.y, transform.position.z), Time.deltaTime * moveVel);
        }

    }
}
