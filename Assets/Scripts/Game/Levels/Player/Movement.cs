using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D body;


    [Range(0, 0.3f)] [SerializeField] private float smoothing = 0.05f;
    [Range(10, 100f)] [SerializeField] public float speed = 10f;

    private Vector3 _velocity = Vector3.zero;
    private float x;
    private float y;
    

    private void Awake()
    {
        x = 0f;
        y = 0f;
    }

    void Update()
    {
        AxisLooking();
    }

    // Original Movement
    private void Move()
    {
        float horizont = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(horizont, vertical, 0);
        transform.Translate(dir.normalized * Time.deltaTime * speed);
    }

    private void AxisLooking()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
    }

    private void ForceMove()
    {
        float delta = Time.fixedDeltaTime;
        Vector3 targetVelocity = new Vector2
            (x * delta * speed * 10f, y * delta * speed * 10f);

        body.velocity = Vector3.SmoothDamp
            (body.velocity, targetVelocity, ref _velocity, smoothing);
    }

    private void FixedUpdate()
    {
        ForceMove();
    }

    // Mobile touch capture
    private void TouchMove()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        transform.position = new Vector3(pos.x, transform.position.y, transform.position.z);
    }
}