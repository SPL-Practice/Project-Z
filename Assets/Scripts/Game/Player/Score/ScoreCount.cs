using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class ScoreCount : MonoBehaviour
{

    public static int scoreValue = 0;
    public static int highScore;
    public GameObject HighScore;

    Text score;
     
    void Start()
    {
        score = GetComponent<Text>();
    }
     
     
    void Update()
    {
     
        score.text = "Score: " + scoreValue;
        if (highScore < scoreValue)
        {
            highScore = scoreValue;
        }
           
    }

    void ShowHigh()
    {
        HighScore.GetComponent<Text>().text = "HighScore: " + highScore;
    }
}
