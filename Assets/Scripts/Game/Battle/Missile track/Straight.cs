using UnityEngine;

public class Straight : MonoBehaviour
{
    #region Missile Attributes
    public Vector2 direction = new Vector2(0, 1);
    public float speed = 5f;
    public ushort power = 10;
    #endregion

    private Vector2 velocity;

    void Start()
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject other = collision.gameObject;
        if (other.GetComponent(nameof(Obstacle)) is Obstacle target)
        {
            target.Damage(power);
        }
    }
}