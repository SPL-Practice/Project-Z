using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Road : MonoBehaviour
{
    public float speed = 1f;
    public GameObject road;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < -8f)
        {
            //EditorApplication.isPaused = true;
            Instantiate( road, new Vector3(-0.0042f, 12.01f, 0f), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
