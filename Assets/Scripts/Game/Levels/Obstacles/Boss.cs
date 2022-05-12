using UnityEngine;

public class Boss : Obstacle
{
    #region Health Members
    protected override void Defeat()
    {
        Debug.Log("PINKY HAS BEEN DEFEATED");
        Debug.Log("Epic Victory!!!");

        destroySound.Play();
        level?.Scoring(destroyScore);
        level?.SaveHighScore();
        Destroy(gameObject, 0.4f);

        GameManager.Exit();
    }
    #endregion
}
