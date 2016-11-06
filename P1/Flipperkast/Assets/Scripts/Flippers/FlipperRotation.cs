using UnityEngine;
using System.Collections;

public class FlipperRotation : MonoBehaviour {

    public float flipperStrength = 750f;
    public float pushForce = 300f;

    GameObject leftFlipper;
    GameObject rightFlipper;

    //Zoekt de linker en rechter flipper op.
    void Start()
    {
        leftFlipper = GameObject.Find("Flipper_Links");
        rightFlipper = GameObject.Find("Flipper_Rechts");
    }

    //Wanneer je de button Left indrukt krijgt de linker flipper een kracht toegevoegt waardoor hij gaat bewegen.
    //En hetzelfde gebeurt ook met de rechter flipper wanneer je de button Right in drukt.
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
