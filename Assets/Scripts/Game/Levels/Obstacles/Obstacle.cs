using UnityEngine;

public class Obstacle : MonoBehaviour, IWeak
{
    public int health = 100;
    public ushort power = 30;

    public Score level;

    public uint hitScore;
    public uint destroyScore;

    public void Hit(ushort value)
    {
        health -= value;
        level.Scoring(hitScore);
        if (health <= 0)
        {
            level.Scoring(destroyScore);
            Destroy(gameObject);
        }
    }
}