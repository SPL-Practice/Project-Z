using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public float speedBoost = 2f;
    public int countBoost = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
            return;

        if (other.GetComponent(nameof(BattleSystem)) is BattleSystem player)
        {
            player.Modify();
            player.SpeedUp(speedBoost);

            Destroy(gameObject);
        }
    }
}