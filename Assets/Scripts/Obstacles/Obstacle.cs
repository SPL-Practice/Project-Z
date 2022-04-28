using UnityEngine;

namespace Obstacles
{
    public class Obstacle : MonoBehaviour
    {
        // Damage
        public int power = 30;

        // On player enter
        private void OnCollisionEnter2D(Collision2D collision)
        {
            GameObject other = collision.gameObject;

            if (!other.CompareTag("Player"))
                return;

            if (other.GetComponent(nameof(Status)) is Status player)
            {
                player.Heal(power);
                Destroy(gameObject);
            }
        }
    }
}