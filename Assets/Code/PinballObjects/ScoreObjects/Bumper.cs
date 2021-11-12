using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : ScoreObject
{
    Animator animator;

    void Start()
    {
        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();

        if(gameManager == null)
        {
            Debug.Log("Problem initializing GameMaster");
        }
        else
        {
            Debug.Log("GameManager Initialized");
        }


        animator = GetComponent<Animator>();



    }


    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision with Pinball");
        
        AddPointsToScore();



    }
}
