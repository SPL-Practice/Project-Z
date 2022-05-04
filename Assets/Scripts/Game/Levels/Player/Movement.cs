using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        Move();
    }

    // Mobile touch capture
    private void TouchMove()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        transform.position = new Vector3(pos.x, transform.position.y, transform.position.z);
    }

    // Keyboard. For testing
    private void Move()
    {
        float hor = Input.GetAxisRaw("Horizontal");

        Vector3 dir = new Vector3(hor, 0, 0);
        transform.Translate(dir.normalized * Time.deltaTime * speed);
    }
}