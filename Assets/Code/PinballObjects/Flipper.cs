using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    
    [SerializeField] float startAngle = 30f;
    [SerializeField] float rotationLimit = 60f;
    [SerializeField] float flipSpeed;

    private float currentAngle;

    [SerializeField] SideEnum side = SideEnum.RIGHT;

    private float direction; 

    public float turnAmount;

    public bool movingUp;
    

    [Header("Controls")]
    private PinballControls pinballControls;
    public float flipped;


    [Header("FlipperAngle")]
    public float flipperAngle;
    Transform transform;


    [Header("Pinball Physics")]
    public float forceMultiplier = 15f;
    public float upThrust = 30f;
    
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
    
    // Start is called before the first frame update
    void Start()
    {
        flipped = 0f;

        transform = GetComponent<Transform>();

        this.transform.rotation = Quaternion.Euler(0, 0, startAngle);

        turnAmount = 0f;

        direction = side == SideEnum.LEFT ? 1f : -1f;

        movingUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        GetInputValues();

        FlipFlipper();
    }

    void GetInputValues()
    {
        if(side == SideEnum.RIGHT)
        {
            flipped = pinballControls.Pinball.RightFlipper.ReadValue<float>();
        }
        else if(side == SideEnum.LEFT)
        {
            flipped = pinballControls.Pinball.LeftFlipper.ReadValue<float>();
        }

    }


    void FlipFlipper()
    {
        bool up = false;

       if(turnAmount < 1.0f && flipped > 0)
       {
           turnAmount += flipSpeed * Time.deltaTime;

            up = true;
           if(turnAmount > 1.0f)
           {
            up = false;
            turnAmount = 1.0f;
           }
            

       }
       else if(turnAmount > 0 && flipped <= 0)
       {
           turnAmount -= flipSpeed * Time.deltaTime;

           if(turnAmount < 0)
           {
               turnAmount = 0;
           }

       }

       movingUp = up;

        RotateFlipper();

    }

    /*
        RotateFlipper

        Rotate the Flipper depending on the turnAmount variable.

    */
    void RotateFlipper()
    {
        float requiredAngle = startAngle + turnAmount * rotationLimit;


        transform.rotation = Quaternion.Euler(Vector3.forward * requiredAngle);

    }
   
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Pinball")
        {

            var pinballObjectRB = col.gameObject.GetComponent<Rigidbody2D>();

            Vector2 v = pinballObjectRB.velocity;

            if(movingUp)
            {
                pinballObjectRB.velocity = new Vector2(v.x * forceMultiplier * 0.5f, Mathf.Abs(v.y * forceMultiplier));

                pinballObjectRB.AddForce(transform.up * upThrust, ForceMode2D.Impulse);
            }


        }


    }

/*

IPPDEV's Example:



var colliding : Collider;
var body : Rigidbody;
var forceMultiplier = 25;
function OnCollisionEnter (collisionInfo : Collision) {
    if (collisionInfo.gameObject.name == "Pinball") {
        var contactNormal = collisionInfo.contacts[0];
                var rot = Quaternion.FromToRotation(Vector3.up, contactNormal.normal);
                var pos = contactNormal.point;
                var rv = collisionInfo.relativeVelocity.magnitude;
        direction = body.transform.position - pos;
        reflectBallTo = Vector3.Reflect (pos, direction);
        colliding.gameObject.rigidbody.AddForce (reflectBallTo * forceMultiplier);
    }  
}
*/


}
