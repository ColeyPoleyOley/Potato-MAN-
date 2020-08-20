using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public CameraController cameraa;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If something falls inside here, it's going to be the player
        //Now just stop the camera controller, and kill the player
        GameManager.instance.cameraa.followPlayer = false;
        GameManager.instance.player.GameOver();
    }
}
