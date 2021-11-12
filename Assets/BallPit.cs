using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPit : MonoBehaviour
{
    
    Collider2D collider;

    [SerializeField]protected GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider2D>();

        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();

        if(gameManager == null)
        {
            Debug.Log("Problem initializing GameMaster");
        }
        else
        {
            Debug.Log("GameManager Initialized for BallPit");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Ball collided with Ball Pit.  Deleting Ball.");

        Destroy(col.gameObject);

        //Then, we mark that the ball was deleted.

        

    }
}
