using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int health = 100;
    public int power = 30;

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

    public void Damage(in ushort value)
    {
        health -= value;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}