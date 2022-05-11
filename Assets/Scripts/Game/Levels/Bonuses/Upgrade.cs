using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public float speedBoost = 1f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
            return;

        if (other.GetComponentInChildren(typeof(BattleSystem)) is BattleSystem player)
        {

            player.Modify();
            player.SpeedUp(speedBoost);

            Destroy(gameObject);
        }
    }
}