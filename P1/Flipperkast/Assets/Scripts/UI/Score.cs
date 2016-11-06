using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public string textScore;
    public string textFinalScore;
    int score = 0;
    Text scoreText;
    Text finalScoreText;

//Zoekt de Text componenten voor de score op, zet de score op nul en update de score op het scherm.
    void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        finalScoreText = GameObject.Find("FinalScoreText").GetComponent<Text>();

        score = 0;
        scoreText.text = textScore + score;
    }
	
    //Wanneer deze functie word aangeroepen telt hij de meegegeven int op bij de score en update de score op het scherm.
    public void AddScore(int points)
    {
        score += points;
        scoreText.text = textScore + score;
    }

    //Wordt aangeroepen wanneer het GamOver is en zak de uiteindelijke score op het scherm weergeven.
    public void FinalScore()
    {
        finalScoreText.text = textFinalScore + score;
    }
}
