using UnityEngine;

public class Obstacle : MonoBehaviour, IWeak
{
    #region Attributes
    public int health = 100;
    public ushort power = 30;

    public uint hitScore;
    public uint destroyScore;
    #endregion

    public AudioSource hitSound;
    public AudioSource destroySound;
    public Score level = null;

    public void Hit(ushort value)
    {
        health -= value;
        level?.Scoring(hitScore);

        if (health > 0)
        {
            hitSound.Play();
            return;
        }

        enabled = false;
        destroySound.Play();
        level?.Scoring(destroyScore);
        Destroy(gameObject, 0.4f);
    }
}