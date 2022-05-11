using UnityEngine;
using Helpers;

public class BattleSystem : MonoBehaviour
{
    private TimeSystem _timing;

    #region Attributes
    public GunSystem[] guns;
    public byte improvements = 1;

    public float speed = 6f;
    public ushort power = 10;

    private const float MaxSpeed = 8f;
    private const ushort MaxPower = 100;
    #endregion

    private int reload => (5 + (MaxSpeed - speed)).ToInt();

    private void Shoot()
    {
        for (byte i = 0; i < improvements; i++)
        {
            guns[i].Shoot();
        }
    }

    public void SpeedUp(in float boost)
    {
        if (speed >= MaxSpeed)
            return;

        speed = Mathf.Min(speed + boost, MaxSpeed);

        _timing.delay = reload;
    }

    public void Modify()
    {
        if (improvements >= guns.Length)
            return;

        improvements++;
    }

    internal void Awake()
    {
        _timing = gameObject.AddComponent<TimeSystem>();
        _timing.delay = reload;
    }

    internal void FixedUpdate()
    {
        if (_timing.TimeTick())
        {
            Shoot();
        }
    }
}
