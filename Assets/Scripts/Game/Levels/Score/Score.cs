using UnityEngine;
using UnityEngine.UI;
using Helpers;

public class Score : MonoBehaviour
{
    public Text highScoreLayout;
    public Text scoreLayout;
    public ScoreSerialization serializer;

    public ulong score = 0;
    private const ulong Max = ulong.MaxValue;

    public void Scoring(uint increment)
    {
        SetScore(Mathf.Min(score + increment, Max).ToULong());
    }

    public void SetScore(ulong newScore)
    {
        score = newScore;
        scoreLayout.text = score.ToString();
    }

    public void SaveHighScore()
    {
        highScoreLayout.text = scoreLayout.text;
        serializer.SaveMode(score);
        SetScore(0);
    }

    public void LoadHighScore()
    {
        highScoreLayout.text = serializer.LoadMode().ToString();
    }

    internal void Awake()
    {
        LoadHighScore();
    }
}