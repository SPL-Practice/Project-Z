using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPlay : MonoBehaviour
{
    public void NextScense()
    {
        Invoke("Delay", 2.7f);
    }


    public void Delay()
    {
        SceneManager.LoadScene(1);
    }

}
