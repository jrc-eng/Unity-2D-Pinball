using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plunger : MonoBehaviour
{
    
    
    [Header("Controls")]
    private PinballControls pinballControls;
    public float charging;


    [SerializeField]GameObject ball;

    [Header("Launching")]
    private float launchForce = 100f;


    // Start is called before the first frame update
    void Start()
    {
        ball = null;
    }

    // Update is called once per frame
    void Update()
    {
        
        GetInput();

        if(charging > 0)
        {
            Launch();
        }
        
    }


    void GetInput()
    {
        charging = pinballControls.Pinball.Plunger.ReadValue<float>();
        
    }

    private void Awake()
    {
        pinballControls = new PinballControls();
    }

    private void OnEnable()
    {
        pinballControls.Enable();
    }

    private void OnDisable()
    {
        pinballControls.Disable();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Pinball")
        {
            ball = other.gameObject;

        }
    }


    void Launch()
    {
        if(ball != null)
        ball.GetComponent<Rigidbody2D>().AddForce(transform.up * launchForce, ForceMode2D.Impulse);

        ball = null;
    }

}
