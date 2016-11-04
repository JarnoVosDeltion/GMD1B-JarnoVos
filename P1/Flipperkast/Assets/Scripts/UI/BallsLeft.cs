using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallsLeft : MonoBehaviour {

    public int ballsStarting = 2;
    public string ballsLeftText;
    int ballsLeft;
    bool allowPinballSpawn = true;
    Text textBallsLeft;
    PinballSpawn pinballSpawnScript;
    CanvasGroup canvasOverlayGroup;

	void Start()
    {
        canvasOverlayGroup = GameObject.Find("CanvasOverlay").GetComponent<CanvasGroup>();
        textBallsLeft = GameObject.Find("BallsLeftText").GetComponent<Text>();
        pinballSpawnScript = GetComponent<PinballSpawn>();

        ballsLeft = ballsStarting;
        textBallsLeft.text = ballsLeftText + (ballsLeft + 1);
	}

    void Update()
    {
        if (allowPinballSpawn)
        {
            if (Input.GetButtonDown("Vertical"))
            {
                pinballSpawnScript.SpawnPinball();
                allowPinballSpawn = false;
                textBallsLeft.text = ballsLeftText + ballsLeft;
            }
        }
    }

    public void ChangingBalls(int change, bool newBall = false)
    {
        ballsLeft += change;
        if(ballsLeft < 0)
        {
            canvasOverlayGroup.alpha = 1;
        }
        else
        {
            if (newBall)
            {
                allowPinballSpawn = newBall;
            }

            else
            {
                textBallsLeft.text = ballsLeftText + ballsLeft;
            }
        }

    }
	
}
