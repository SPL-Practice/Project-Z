﻿using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        Move();
    }

    // Original Movement
    private void Move()
    {
        float horizont = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(horizont, vertical, 0);
        transform.Translate(dir.normalized * Time.deltaTime * speed);
    }

    // Mobile touch capture
    private void TouchMove()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        transform.position = new Vector3(pos.x, transform.position.y, transform.position.z);
    }
}