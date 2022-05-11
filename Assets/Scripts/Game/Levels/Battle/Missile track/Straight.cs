using UnityEngine;

public class Straight : MonoBehaviour
{
    #region Missile Attributes
    public Vector2 direction = new Vector2(0, 1);
    public float speed = 10f;
    #endregion

    private Vector2 velocity;

    void Awake()
    {
        Destroy(gameObject, 2);
    }

    void Update()
    {
        velocity = direction * speed;
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        pos += velocity * Time.fixedDeltaTime;

        transform.position = pos;
    }
}