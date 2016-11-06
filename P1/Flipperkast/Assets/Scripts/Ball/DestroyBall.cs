using UnityEngine;
using System.Collections;

public class DestroyBall : MonoBehaviour {

    BallsLeft ballsLeftScript;

    //Zoekt het BallsLeft script op.
	void Start ()
    {
        ballsLeftScript = GameObject.Find("Manager").GetComponent<BallsLeft>();
	}
	
    //Wanneer een pinball de Trigger aanraakt zal hij vernietigt worden, zal er 1 van het aantal balletjes dat je nog over hebt afgehaald worden en zal er voor zorgen dat je een nieuw balletje kunt spawnen.
	void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Pinball")
        {
            Destroy(other.gameObject);
            ballsLeftScript.ChangingBalls(-1, true);
        }
    }
}
