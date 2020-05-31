using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    //Force of the cube in the direction it is moving
    public float forwardForce;
    public float sideVel;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Player movement based on keys.
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        foreach(Touch touch in Input.touches)
        {
            if(touch.position.x < Screen.width/2)
            {
                rb.AddForce(-sideVel * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if(touch.position.x > Screen.width/2)
            {
                rb.AddForce(sideVel * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sideVel * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if(Input.GetKey("d"))
        {
            rb.AddForce(sideVel * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    public void slowDown()
    {
        forwardForce=forwardForce/2;
    }

    public void speedUp()
    {
        forwardForce=forwardForce*2;
    }
}
