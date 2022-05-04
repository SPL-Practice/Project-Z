using UnityEngine;
using UnityEngine.UI;
using Helpers;

public class Status : MonoBehaviour, IWeak
{
    public Slider hp;

    public void Heal(uint value)
    {
        hp.Fill(value);
    }

    public void Hit(ushort value)
    {
        if (hp.Drain(value))
        {
            Defeat();
        }
    }

    private void Defeat()
    {
        gameObject.SetActive(false);
        // Some behaviour...
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
            Debug.Log("YES X4");
            Hit(obstacle.power);
        }
    }
}