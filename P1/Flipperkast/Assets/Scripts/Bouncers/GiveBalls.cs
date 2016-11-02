using UnityEngine;
using System.Collections;

public class GiveBalls : MonoBehaviour {

    public int addedBalls;
    public GameObject bonusBallParticleSystem;
    BallsLeft ballsLeftScript;

    void Start()
    {
        ballsLeftScript = GameObject.Find("Manager").GetComponent<BallsLeft>();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Pinball")
        {
            ballsLeftScript.ChangingBalls(addedBalls);
            Instantiate(bonusBallParticleSystem, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
        }
    }
    
    /*
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Instantiate(bonusBallParticleSystem, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
        }
    }
    */
    
}
