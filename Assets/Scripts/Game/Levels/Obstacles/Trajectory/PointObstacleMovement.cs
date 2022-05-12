using System;
using System.Collections.Generic;
using UnityEngine;

namespace Obstacles
{
    public class PointObstacleMovement : MonoBehaviour
    {
        [SerializeField] private protected PointPath pointPath;
        [SerializeField] private protected float _speed;

        private protected List<Transform> _points;
        private protected int _currentNumberPosition = 1;

        private void Start()
        {
            _points = pointPath.GetPoints();
        }

        private void Update()
        {
            Move();
        }

        protected virtual void Move()
        {
            MoveToPath();
            IncrementaryMove();
        }

        private protected void MoveToPath()
        {
            transform.position = Vector2.MoveTowards(transform.position,
                _points[_currentNumberPosition].position, _speed * Time.deltaTime);
        }

        private protected virtual void IncrementaryMove()
        {
            var distanceSquare = (transform.position - _points[_currentNumberPosition].position).sqrMagnitude;
            if (distanceSquare < Math.Pow(0.1f, 2) && _currentNumberPosition != _points.Count - 1)
                _currentNumberPosition++;
        }
    }
}
