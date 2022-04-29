using UnityEngine;
using Random = UnityEngine.Random;

namespace Obstacle
{
    public class ObstacleRotator : MonoBehaviour
    {
        [SerializeField] [Range(0.1f, 5f)] private float _speed;

        private void Start()
        {
            transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
        }

        private void FixedUpdate()
        {
            Rotate();
        }

        private void Rotate()
        {
            transform.Rotate(0, 0, _speed);
        }
    }
}
