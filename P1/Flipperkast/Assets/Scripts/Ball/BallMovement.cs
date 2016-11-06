using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {

    Rigidbody rb;
    Vector3 oldVel;
    public float power = 1.0f;

    //Vraagt naar de Rigidbody van het GameObject.
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
    //Slaat elke FixedUpdate op wat de huidige velocity is.
	void FixedUpdate ()
    {
        oldVel = rb.velocity;
	}

    //Wanneer het balletje contact maakt met een bouncer zal hij berekenen wat de hoek van uitval is en zal die kant opgeschoten worden.
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
