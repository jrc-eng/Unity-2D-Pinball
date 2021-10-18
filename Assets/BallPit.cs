using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPit : MonoBehaviour
{
    
    Collider2D collider;
    
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Ball collided with Ball Pit.  Deleting Ball.");

        Destroy(col.gameObject);
    }
}
