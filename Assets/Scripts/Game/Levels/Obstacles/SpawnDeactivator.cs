using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Helpers;

public class SpawnDeactivator : MonoBehaviour
{
    private TimeSystem _timing;

    [SerializeField] private ulong _episodeLength = 10;
    [SerializeField] private Slider _episodeProgress;

    internal void Awake()
    {
        _timing = gameObject.AddComponent<TimeSystem>();
        _timing.delay = 20;
        Reset();
    }

    private void Reset()
    {
        _episodeProgress.maxValue = _episodeLength;
        _episodeProgress.value = 0;
    }

    internal void FixedUpdate()
    {
        if (!_timing.TimeTick())
            return;

        if (_episodeProgress.Fill(1))
        {
            gameObject.SetActive(false);
        }
    }
}
