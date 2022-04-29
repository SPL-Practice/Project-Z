using System;
using System.Collections.Generic;
using UnityEngine;

namespace Obstacle
{
    public class PointObstacleMovement : MonoBehaviour
    {
        [SerializeField] private Point _point;
        [SerializeField] private float _speed;
        
        private List<Transform> _points;
        private int _currentNumberPosition = 1;
        
        private void Start()
        {
            _points = _point.GetPoints();
        }

        private void Update()
        {
            Movement();
        }

        private void Movement()
        {
            transform.position = Vector2.MoveTowards(transform.position,
                _points[_currentNumberPosition].position, _speed * Time.deltaTime);
            
            var distanceSquare = (transform.position - _points[_currentNumberPosition].position).sqrMagnitude;
            if (distanceSquare < Math.Pow(0.1f, 2) && _currentNumberPosition != _points.Count - 1)
                _currentNumberPosition++;
        }
    }
}
