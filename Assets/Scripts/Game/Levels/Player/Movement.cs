using UnityEngine;

public class Movement : MonoBehaviour
{
    #region RigidBody Movement
    public Rigidbody2D body;

    [Range(0, 0.3f)] [SerializeField] private float smoothing = 0.05f;
    [Range(10, 100f)] [SerializeField] public float speed = 10f;

    private Vector3 _velocity = Vector3.zero;
    private float x;
    private float y;
    #endregion

    private void Awake()
    {
        x = 0f;
        y = 0f;
    }

    void Update()
    {
        AxisLooking();
    }

    void FixedUpdate()
    {
        ForceMove();
    }

    private void AxisLooking()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
    }

    private void ForceMove()
    {
        float increment = Time.fixedDeltaTime * speed * 10f;
        Vector3 targetVelocity = new Vector2(x * increment, y * increment);

        body.velocity = Vector3.SmoothDamp
            (body.velocity, targetVelocity, ref _velocity, smoothing);
    }

    // Mobile touch capture
    private void TouchMove()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        transform.position = new Vector3(pos.x, transform.position.y, transform.position.z);
    }
}