using UnityEngine;

public class Gun : MonoBehaviour
{
    public Straight missile;
    private Vector2 _direction;

    private void Awake()
    {
        _direction = (transform.localRotation * Vector2.up).normalized;
    }

    public void Shoot()
    {
        Instantiate(missile.gameObject, transform.position, Quaternion.identity);
        missile.direction = _direction;
    }
}