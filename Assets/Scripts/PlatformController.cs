using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    
 

    public int moveVel = 5;

    Transform startposition;

    public Transform[] coinSpawnPositions;

    public GameObject coinPrefab;

    GameObject spawnedCoin;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x != GameManager.instance.endPosition.position.x)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(GameManager.instance.endPosition.position.x, transform.position.y, transform.position.z), Time.deltaTime * moveVel);
        }
        else
        {
            if(spawnedCoin != null){
                Destroy(spawnedCoin);
            }
            startposition = GameManager.instance.spawnPosition[Random.Range(0, GameManager.instance.spawnPosition.Length)];
            transform.position = startposition.position;

            int coin = Random.Range(0, 3);

            switch (coin)
            {
                case 0:
                    
        

                case 1:
                    spawnedCoin = Instantiate(coinPrefab, coinSpawnPositions[coin].position, Quaternion.identity,transform);
                    break;

                case 2:
                default:
                    break;

            }
        }

    }
}
