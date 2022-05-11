using UnityEngine;
using UnityEngine.UI;
using Helpers;

public class Campaign : MonoBehaviour
{
    private TimeSystem _timing;

    public ulong _episodeLength;
    public GameObject nextLevel = null;

    public Slider _episodeProgress;
    public Score levelScore;

    internal void Awake()
    {
        _timing = gameObject.AddComponent<TimeSystem>();
        _timing.delay = 20;
    }

    internal void OnEnable()
    {
        ResetLevel();
    }

    private void ResetLevel()
    {
        _episodeProgress.maxValue = _episodeLength;
        _episodeProgress.minValue = 0;
        _episodeProgress.value = 0;

        Debug.Log(_episodeLength);
    }

    internal void FixedUpdate()
    {
        if (!_timing.TimeTick())
            return;

        //Debug.Log(_episodeProgress.value + "/" + _episodeProgress.maxValue);
        if (!_episodeProgress.Fill(1))
            return;

        LevelComplete();
    }

    private void LevelComplete()
    {
        Debug.Log("Level Complete");

        gameObject.SetActive(false);
        levelScore.SaveHighScore();

        if (nextLevel is null)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
        else
        {
            nextLevel.SetActive(true);
        }
    }
}
