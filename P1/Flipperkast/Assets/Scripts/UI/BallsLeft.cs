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
    Score scoreScript;

    //Zoekt een aantal componenten op en laat op het scherm zien met hoeveel balletjes je begint.
	void Start()
    {
        canvasOverlayGroup = GameObject.Find("CanvasOverlay").GetComponent<CanvasGroup>();
        textBallsLeft = GameObject.Find("BallsLeftText").GetComponent<Text>();
        pinballSpawnScript = GetComponent<PinballSpawn>();
        scoreScript = GameObject.Find("Manager").GetComponent<Score>();

        ballsLeft = ballsStarting;
        textBallsLeft.text = ballsLeftText + (ballsLeft + 1);
	}

    // Wanneer allowPinballSpawn true is mag je een nieuw balletje spawnen met een van de vertical buttons en zal het aantal balletjes dat je over hebt op je scherm updaten.
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

    // Wordt aangeroepen wanneer het aantal balletjes dat je nog over hebt moet worden veranderd.
    // Hij telt de meegeven int op bij het aantal balletjes dat je nog over hebt en checkt of je niet GameOVer bent.
    //Als de meegegeven boolean true is mag je een nieuw balletje spawnen, anders update het aanatal balletjes dat je nog over hebt op je scherm.
    public void ChangingBalls(int change, bool newBall = false)
    {
        ballsLeft += change;
        if(ballsLeft < 0)
        {
            scoreScript.FinalScore();
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
