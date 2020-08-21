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

    public GameObject hazardPrefab;

    public GameObject ShieldPrefab;

    GameObject spawnedShield;
    GameObject spawnedHazard;
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
            if (spawnedCoin != null)
            {
                Destroy(spawnedCoin);
            }
            Destroy(spawnedShield);
            Destroy(spawnedHazard);
            startposition = GameManager.instance.spawnPosition[Random.Range(0, GameManager.instance.spawnPosition.Length)];
            transform.position = startposition.position;

            int coin = Random.Range(0, 3);

            switch (coin)
            {
                case 0:



                case 1:
                    spawnedCoin = Instantiate(coinPrefab, coinSpawnPositions[coin].position, Quaternion.identity, transform);
                    break;

                case 2:
                default:
                    break;
            }

            int staticHazard = Random.Range(0, 2);
                    int chances = Random.Range(0, 10);

                    if (chances < 2)
                    {
                        spawnedHazard = Instantiate(hazardPrefab, new Vector3(coinSpawnPositions[staticHazard].position.x, coinSpawnPositions[staticHazard].position.y  +2.00f, coinSpawnPositions[staticHazard].position.z), Quaternion.identity, transform);


                    }
            int staticShield = Random.Range(0, 2);
                    int tomatoes = Random.Range(0, 20);
                    if (tomatoes < 2)
            {
                spawnedShield = Instantiate(ShieldPrefab, new Vector3(coinSpawnPositions[staticShield].position.x, coinSpawnPositions[staticShield].position.y + 1.02f, coinSpawnPositions[staticShield].position.z), Quaternion.identity, transform);
            }//end if tomatoes
            }

        }
    }

