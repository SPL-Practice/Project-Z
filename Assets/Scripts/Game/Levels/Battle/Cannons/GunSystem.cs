using System.Collections.Generic;
using UnityEngine;

public class GunSystem : MonoBehaviour
{
    public List<Gun> guns;

    public void Shoot()
    {
        foreach(Gun gun in guns)
        {
            gun.Shoot();
        }
    }
}