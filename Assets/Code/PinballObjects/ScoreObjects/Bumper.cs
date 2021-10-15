using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : ScoreObject
{



    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision with Pinball");
        
        AddPointsToScore();



    }
}
