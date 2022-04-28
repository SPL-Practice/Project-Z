using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 3f;
    void Update()
    {
        // Скрипт управления для мобилок
        //Vector3 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        //transform.posistion = new Vector3(pos.x, transform.position.y, transform.position.z);

        // Скрипт для управления на клавиатуре, тестов
        float hor = Input.GetAxisRaw("Horizontal");

        Vector3 dir = new Vector3(hor, 0, 0);
        transform.Translate(dir.normalized * Time.deltaTime * speed);
    }
}
