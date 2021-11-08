using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideLauncher : MonoBehaviour
{
    Collider2D trigger;

    public bool launch;

    GameObject ball;

    Animator animator;

    [SerializeField] float launchForce = 30f;

    [SerializeField] float makeFalseDelay = 0.5f;

    public int aimDirection = 1;

    float lastTrueTime;

    // Start is called before the first frame update
    void Start()
    {
        trigger = this.gameObject.transform.GetChild(0).GetComponent<BoxCollider2D>();
        launch = false;

        ball = null;

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateAnimations();
    }

    void UpdateAnimations()
    {

        animator.SetBool("Launch", launch);

        if(launch && Time.time > lastTrueTime + makeFalseDelay)
        {
            launch = false;
        }
    }

    void LaunchBall()
    {
        if(ball != null)
        {
            ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(aimDirection,1) * launchForce, ForceMode2D.Impulse);
            launch = true;
            ball = null;
        }

    }

    void makeLaunchTrue()
    {
        launch = true;
        lastTrueTime = Time.time;

    }

    void OnTriggerEnter2D(Collider2D col)
    {

        Debug.Log("Pinball touched side launcher pad.");

        ball = col.gameObject;

        LaunchBall();

    }
}
