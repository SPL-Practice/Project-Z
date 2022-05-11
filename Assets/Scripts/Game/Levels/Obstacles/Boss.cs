using UnityEngine;
using UnityEngine.UI;
using Helpers;

public class Boss : MonoBehaviour
{
    #region Health Members
    public Slider hp;
    [SerializeField] private int health = 500;

    public void Hit(ushort value)
    {
        Debug.Log("Player ship hit");

        if (hp.Drain(value))
        {
            Defeat();
        }
    }

    private void Defeat()
    {
        Debug.Log("PINKY HAS BEEN DEFEATED");
        Debug.Log("Epic Victory!!!");

        UnityEditor.EditorApplication.isPlaying = false;
    }
    #endregion

    internal void OnEnable()
    {
        ResetLevel();
    }

    private void ResetLevel()
    {
        hp.maxValue = health;
        hp.value = health;
    }
}
