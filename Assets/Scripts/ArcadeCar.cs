/* TODO
 * -Fix gear shift (rapid fire shifting) 
 * -Refine jump
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeCar : MonoBehaviour {
    public float currentSpeed = 0.0f;
    private float acceleration = 20.0f;
    private float deceleration = 25.0f;
    private float jumpDistance = 10.0f;
    private float jumpSpeed = 100.0f;
    public float topSpeed = 100f;
    public bool accelerate = true;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //ramp up to top speed
        if(Input.GetKey(KeyCode.W))
        {
            if(currentSpeed < topSpeed)
            {
                currentSpeed += (acceleration * Time.deltaTime);
            }
        }
        else if (currentSpeed > 0)
        {
            currentSpeed -= (deceleration * Time.deltaTime);
        }

        //gear shift
        if(Input.GetKeyDown(KeyCode.RightShift) || Input.GetKeyDown(KeyCode.LeftShift))
        {
            accelerate = !accelerate;
        }

        //steer left and right
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -5.0f, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 5.0f, 0);
        }

        //handbrake
        if(Input.GetKey(KeyCode.Space))
        {
            deceleration = 75.0f;
        }
        else
        {
            deceleration = 25.0f;
        }

        //crazy jump
        if (Input.GetKey(KeyCode.E))
        {
            if (transform.position.y < jumpDistance) 
            {
                transform.Translate(Vector3.up * jumpSpeed * Time.deltaTime);
            }
        }

        //move forward if 'A' gear...
        if (accelerate)
        {
            transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
        }
        //...move backward if 'R' gear
        else
        {
            transform.Translate(Vector3.back * currentSpeed * Time.deltaTime);
        }

        //Debug.Log("accelerate: " + accelerate);
    }
}
