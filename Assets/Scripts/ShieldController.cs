using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController : MonoBehaviour
    
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.instance.shield += 1;
        GameManager.instance.shieldCounter += 1;
        Destroy(gameObject);
    }
}
