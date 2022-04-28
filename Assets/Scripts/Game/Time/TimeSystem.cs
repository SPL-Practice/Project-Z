using UnityEngine;

public class TimeSystem : MonoBehaviour
{
    private int _ticks;
    public int delay;

    // Game-in time ticks
    public bool TimeTick()
    {
        bool beat = _ticks > delay;
        _ticks = beat ? 0 : _ticks + 1;
        return beat;
    }
}