using UnityEngine;

public class Upgrade : MonoBehaviour
{

    public float SpeedBoost = 15f;
    public int CountBoost = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (!other.CompareTag("Player"))
        {
            return;
        }

        if (other.GetComponent(nameof(Shooting)) is Shooting player)
        {
            player.SpeedUp(SpeedBoost);
            player.CountUp(CountBoost);

            Destroy(gameObject);
        }

    }
}