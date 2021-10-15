using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private long score;
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0L;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void AddToScore(long val)
    {
        Debug.Log("GameManager AddToScore called");
        score += val;
    }

    public long GetScore()
    {
        return score;
    }

}
