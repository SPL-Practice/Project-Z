using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    public float speed = 1f;

    void FixedUpdate()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (transform.position.y < -6)
            Destroy(gameObject);
;    }
}
