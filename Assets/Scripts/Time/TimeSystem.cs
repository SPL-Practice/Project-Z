using UnityEngine;

public class TimeSystem : MonoBehaviour
{
    private int Ticks { get; set; }
    private int Delay { get; set; }

    public TimeSystem(int ticks, int delay)
    {
        Ticks = ticks;
        SetDelay(delay);
    }

    public void SetDelay(int delay)
    {
        Delay = delay;
    }

    // Game-in time ticks
    public bool TimeTick()
    {
        bool beat = Ticks > Delay;
        Ticks = beat ? 0 : Ticks + 1;
        return beat;
    }
}