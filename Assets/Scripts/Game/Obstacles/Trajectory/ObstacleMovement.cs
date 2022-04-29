using UnityEngine;
using Random = UnityEngine.Random;

namespace Obstacles
{
    public class ObstacleMovement : MonoBehaviour
    {
        [SerializeField] [Range(0.1f, 5f)] private float _speed;
        private void FixedUpdate()
        {
            Move();
        }

        private void Move()
        {
            var direction = new Vector2(Random.Range(-0.3f, 0.3f), -1 * _speed);
            transform.Translate((Vector3)direction * Time.fixedDeltaTime);
        }
    }
}
