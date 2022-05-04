using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        Move();

        //ClampMove();
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

    // Keyboard. For testing
    //private void ClampMove()
    //{
    //    float horizont = Input.GetAxisRaw("Horizontal");
    //    float vertical = Input.GetAxisRaw("Vertical");

    //    Vector3 dir = new Vector3(horizont, vertical, 0);
    //    Vector3 normalization = dir.normalized * Time.deltaTime * speed;
    //    Vector3 future = transform.position;
    //    //Screen.height / 720
    //    //Screen.width / 1280

    //    float x = future.x + normalization.x;
    //    float y = future.y + normalization.y;

    //    float clampX = 8.25f * Screen.width / 1280;
    //    float clampY = 4.5f * Screen.height / 720;

    //    Debug.Log(x);
    //    Debug.Log(y);

    //    Debug.Log(clampX);
    //    Debug.Log(clampY);
    //    if (x > -1 * clampX && x < clampX
    //         && y > -1 * clampY && y < clampY)
    //    {
    //        transform.Translate(normalization);
    //    }
    //}
}