using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreObject : MonoBehaviour
{
    [SerializeField]protected GameManager gameManager;
    
    [SerializeField] ScoreValue scoreValue;
    
    // Start is called before the first frame update
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

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected void AddPointsToScore()
    {
        Debug.Log("ScoreObject AddToScore called");    

        if(gameManager != null)
        {
            Debug.Log("ScoreObject AddToScore called with no null gameManager");

            gameManager.AddToScore(scoreValue.GetValue());
        }
        else
        {
            Debug.Log("ScoreObject AddToScore called with null gameManager");
        }

    }



}
