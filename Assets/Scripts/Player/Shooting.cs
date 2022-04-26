using UnityEngine;
using Helpers;

public class Shooting : MonoBehaviour
{
    private TimeSystem Timing { get; set; }

    // Some Prefab here...

    #region SpaceShip Attributes
    public int Count { get; set; }
    public float Speed { get; set; }

    private const int MaxCount = 5;
    private const float MaxSpeed = 8f;
    #endregion

    private void Shoot()
    {
        // Some missiles genereting behaviour here
    }

    public void SpeedUp(in float boost)
    {
        Speed = Mathf.Min(Speed + boost, MaxSpeed);
    }

    public void CountUp(in int boost)
    {
        Count = Mathf.Min(Count + boost, MaxCount);
    }

    internal void Awake()
    {
        Timing = new TimeSystem(0, 50 / Speed.ToInt());
    }

    // Update is called once per frame
    internal void FixedUpdate()
    {
        if (Timing.TimeTick())
        {
            Shoot();
        }
    }
}