using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Score : MonoBehaviour
{
    public Text ScoreText;
    public Text FinalScoreText;

    int myScore = 0;
    // Update is called once per frame
    void Update()
    {
        ScoreText.text = myScore.ToString();

        FinalScoreText.text = "Score: " +myScore.ToString();
    }

    public void AddScore (int score)
    {
        myScore = myScore + score;
    }
}
