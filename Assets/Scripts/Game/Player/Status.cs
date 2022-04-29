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
        // Some behaviour...
    }
}