using UnityEngine;
using System.Collections;

public class DestroyBall : MonoBehaviour {

    BallsLeft ballsLeftScript;

	void Start ()
    {
        ballsLeftScript = GameObject.Find("Manager").GetComponent<BallsLeft>();
	}
	
	void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Pinball")
        {
            Destroy(other.gameObject);
            ballsLeftScript.ChangingBalls(-1, true);
        }
    }
}
