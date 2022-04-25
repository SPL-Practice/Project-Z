using UnityEngine;
using UnityEngine.UI;
using Helpers;

public class Status : MonoBehaviour
{
    public Slider HP;

    public void Heal(int value)
    {
        HP.Fill(value);
    }

    public void Hit(int value)
    {
        if (HP.Drain(value))
        {
            Defeat();
        }
    }

    private void Defeat()
    {
        // Some behaviour...
    }
}