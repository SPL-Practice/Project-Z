using System.Collections.Generic;
using UnityEngine;

public class GunSystem : MonoBehaviour
{
    public List<Gun> guns;

    public void Unlock()
    {
        gameObject.SetActive(true);
    }

    public void PowerBoost(in ushort power)
    {
        foreach (Gun gun in guns)
        {
            gun.PowerBoost(power);
        }
    }

    public void Shoot()
    {
        foreach(Gun gun in guns)
        {
            gun.Shoot();
        }
    }
}