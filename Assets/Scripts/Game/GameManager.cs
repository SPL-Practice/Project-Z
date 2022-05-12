using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Exit();
        }
    }

    public static void Exit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif            
    }
}