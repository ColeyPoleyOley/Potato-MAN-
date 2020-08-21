using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour

{
    public Transform[] spawnPosition;
    public Transform endPosition;
    public static GameManager instance;

    public Transform[] spawnPosMoveHazard;
    public Transform endMoveHazard;

    public PlayerController player;
    public CameraController cameraa;

    public int currentScore = 0;
    public int shieldCounter = 0;

    public int shield = 0;

    public Text shieldNum;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        
    }

    // Update is called once per frame
    void Update()
    {
        shieldNum.text = shieldCounter + "";
        score.text = currentScore + "";

    }
    public void AddScore()
    {
        currentScore++;
    }
    public void RestartGame()
    {
        score.text = "Fuck you xi";
        SceneManager.LoadSceneAsync(0);
    }
}
