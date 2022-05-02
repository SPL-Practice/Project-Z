using UnityEngine;

public class Obstacle : MonoBehaviour, IWeak
{
    public int health = 100;
    public ushort power = 30;

    // On player collide
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject other = collision.gameObject;

        if (!other.CompareTag("Player"))
            return;

        if (other.GetComponent(nameof(Status)) is Status player)
        {
            player.Hit(power);
        }
    }

    public void Hit(ushort value)
    {
        health -= value;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}