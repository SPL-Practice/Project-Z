using UnityEngine;

public class Gun : MonoBehaviour
{
    public Straight missile;

    public void Unlock()
    {
        gameObject.SetActive(true);
    }

    public void PowerBoost(in ushort power)
    {
        missile.power = power;
    }

    public void Shoot()
    {
        Instantiate(missile.gameObject, transform.position, Quaternion.identity);
    }
}