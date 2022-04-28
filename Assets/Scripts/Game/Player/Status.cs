using UnityEngine;
using UnityEngine.UI;
using Helpers;

public class Status : MonoBehaviour
{
    public Slider hp;

    public void Heal(int value)
    {
        hp.Fill(value);
    }

    public void Hit(int value)
    {
        if (hp.Drain(value))
        {
            Defeat();
        }
    }

    private void Defeat()
    {
        // Some behaviour...
    }
}