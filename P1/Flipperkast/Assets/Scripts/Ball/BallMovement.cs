using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {

    Rigidbody rb;
    Vector3 oldVel;
    public float power = 1.0f;

	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate ()
    {
        oldVel = rb.velocity;
	}

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "Bouncer")
        {
            ContactPoint cp = col.contacts[0];

            rb.velocity = Vector3.Reflect(oldVel, cp.normal) * power;

            //rb.velocity += cp.normal * power;

        }
    }
}
