using UnityEngine;
using System.Collections;

public class FlipperRotation : MonoBehaviour {

    public float flipperStrength = 750f;
    public float pushForce = 300f;

    GameObject leftFlipper;
    GameObject rightFlipper;

    void Start()
    {
        leftFlipper = GameObject.Find("Flipper_Links");
        rightFlipper = GameObject.Find("Flipper_Rechts");
    }

    void FixedUpdate ()
    {
            if(Input.GetButtonDown("Left"))
            {
                Vector3 f = leftFlipper.GetComponent<Transform>().transform.up * flipperStrength;
                Vector3 p = leftFlipper.GetComponent<Transform>().transform.right + leftFlipper.GetComponent<Transform>().transform.position * pushForce;
                leftFlipper.GetComponent<Rigidbody>().AddForceAtPosition(f, p);
            }

        if (Input.GetButtonDown("Right"))
        {
                Vector3 f = rightFlipper.GetComponent<Transform>().transform.up * flipperStrength;
                Vector3 p = rightFlipper.GetComponent<Transform>().transform.right + rightFlipper.GetComponent<Transform>().transform.position * pushForce;
                rightFlipper.GetComponent<Rigidbody>().AddForceAtPosition(f, p);
            }
	}
}
