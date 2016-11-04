using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public string textScore;
    int score = 0;
    Text scoreText;

    void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        scoreText.text = textScore + score;
    }
	
    public void AddScore(int points)
    {
        score += points;
        scoreText.text = textScore + score;
    }
}
