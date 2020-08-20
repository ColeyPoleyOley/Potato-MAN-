﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public bool followPlayer = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (followPlayer)
        {
            transform.position = new Vector3(transform.position.x, GameManager.instance.player.transform.position.y, transform.position.z);
        }
    }
}