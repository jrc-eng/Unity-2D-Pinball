using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargePlunger : Plunger
{

    public float plungerInput;

    public int currentChargeForce;

    public float chargePercent;

    public float durationBetweenChargeForce = 0.4f;

    public float lastChargeTime;

    Animator animator;

    void Start()
    {
        ball = null;

        plungerInput = 0f;

        chargePercent = 0;

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        GetInput();

        ChargeBall();

        LaunchBall();
        
        
    }

    void GetInput()
    {
        plungerInput = pinballControls.Pinball.Plunger.ReadValue<float>();

    }


    void ChargeBall()
    {
        animator.SetBool("Charging", plungerInput > 0);

    }

    void LaunchBall()
    {
        if(plungerInput <= 0 && chargePercent > 0)
        {
            Launch();
        }

    }


    void Launch()
    {
        if(ball != null)
        {
            ball.GetComponent<Rigidbody2D>().AddForce(transform.up * launchForce * chargePercent, ForceMode2D.Impulse);
            ball = null;
        }


    }
}
