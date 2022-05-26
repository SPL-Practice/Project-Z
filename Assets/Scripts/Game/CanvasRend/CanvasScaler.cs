using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CanvasScaler : MonoBehaviour
{
    private const float V = 0.5f;

    public void Scaler()
    {
        float width;
        float heigh;
        


        width = Screen.width;
        heigh = Screen.height;

        Camera.main.orthographicSize = V * heigh / 100f;
        
    }
}
