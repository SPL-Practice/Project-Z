using UnityEngine;
using UnityEngine.UI;
using Helpers;

public class Obstacle : MonoBehaviour, IWeak
{
    #region Attributes
    public Slider hp;
    public uint health = 100;
    public ushort power = 30;

    public uint hitScore;
    public uint destroyScore;
    #endregion

    public AudioSource hitSound;
    public AudioSource destroySound;
    public Score level = null;

    internal void OnEnable()
    {
        ResetStats();
    }

    protected void ResetStats()
    {
        hp.maxValue = health;
        hp.value = health;
    }

    public void Hit(ushort value)
    {
        if (Damage(value))
            Destroy(this);
    }

    protected bool Damage(ushort value)
    {
        level?.Scoring(hitScore);
        bool collapsed = hp.Drain(value);

        if (!collapsed)
            hitSound.Play();

        return collapsed;
    }

    protected virtual void Defeat()
    {
        destroySound.Play();
        level?.Scoring(destroyScore);
        Destroy(gameObject, 0.4f);
    }

    protected void OnDestroy()
    {
        Defeat();
    }
}