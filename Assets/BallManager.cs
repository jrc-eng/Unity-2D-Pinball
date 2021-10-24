using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    GameManager gameManager;
    
    [SerializeField] private int maxBalls;

    [SerializeField] private int currentBall;

    [SerializeField] private bool ballInPlay;

    [SerializeField] private BallSpawner ballSpawner;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GetComponent<GameManager>();
        
        maxBalls = gameManager.ballCount;
        
        currentBall = 1;

        ballInPlay = false;

        

    }

    // Update is called once per frame
    void Update()
    {
        if(!ballInPlay)
        {
            SpawnBall();
            ballInPlay = true;
        }
    }


    void SpawnBall()
    {
        if(ballSpawner != null)
        {
            ballSpawner.SpawnBall();
        }

    }

    public void setBallInPlay(bool val)
    {
        ballInPlay = val;

    }
}
