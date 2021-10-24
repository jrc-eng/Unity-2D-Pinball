using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWayWall : MonoBehaviour
{
    Collider2D frontCollider;

    Collider2D backCollider;

    bool openGate = false;

    public float timeToClose = 0.3f;

    float lastOpenedTime;
    
    // Start is called before the first frame update
    void Start()
    {
        frontCollider = this.gameObject.transform.GetChild(0).GetComponent<BoxCollider2D>();
        backCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(openGate && Time.time > lastOpenedTime + timeToClose)
        {
            CloseGate();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        OpenGate();


    }

    void OpenGate()
    {
        openGate = true;
        frontCollider.isTrigger = true;
        lastOpenedTime = Time.time;
    }

    void CloseGate()
    {
        openGate = false;
        frontCollider.isTrigger = false;
    }
}
