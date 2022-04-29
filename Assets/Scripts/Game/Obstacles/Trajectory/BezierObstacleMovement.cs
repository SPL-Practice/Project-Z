using System.Collections.Generic;
using UnityEngine;

namespace Obstacles
{
    public class BezierObstacleMovement : MonoBehaviour
    {
        [SerializeField] private BezierPath _bezierPath;
        
        private List<Transform> _points;
        private float _currentTime;
        private readonly float _time = 5;

        private void Start()
        {
            _points = _bezierPath.GetPoints();
        }

        private void FixedUpdate()
        {
            Move();
        }

        private void Move()
        {
            _currentTime += Time.fixedDeltaTime;
            transform.position = Bezier.GetPoint(_points[0].position, 
                                                        _points[1].position, 
                                                        _points[2].position, 
                                                        _points[3].position, _currentTime / _time);
        }
    }
}
