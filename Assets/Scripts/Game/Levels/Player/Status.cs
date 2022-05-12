using UnityEngine;
using UnityEngine.UI;
using Helpers;

public class Status : MonoBehaviour, IWeak
{
    public Slider hp;

    public AudioSource hitSound;
    public AudioSource healSound;

    public void Heal(uint value)
    {
        healSound.Play();
        hp.Fill(value);
    }

    public void Hit(ushort value)
    {
        Debug.Log("Player ship hit");

        hitSound.Play();
        if (hp.Drain(value))
        {
            Defeat();
        }
    }

    private void Defeat()
    {
        Debug.Log("Player ship defeated");
        Debug.Log("You lose...");

        GameManager.Exit();
    }

    // On player collide
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject other = collision.gameObject;

        if (!other.CompareTag("Enemy"))
            return;

        GameObject parent = other.transform.parent.gameObject;

        if (parent.GetComponent(nameof(Obstacle)) is Obstacle obstacle)
        {
            Hit(obstacle.power);
        }
    }
}