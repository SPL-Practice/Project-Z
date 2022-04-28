using System;
using System.Collections.Generic;
using UnityEngine;

namespace Obstacles
{
    public class FollowPath : MonoBehaviour
    {
        private MovementType _type = MovementType.Moveing;
        public MovementPath MyPath;
        private float speed = 1;
        private float maxDistance = 0.1f;

        private IEnumerator<Transform> _pointInPath;

        private void Start()
        {
            if (MyPath == null)
                throw new Exception("Путь не применен");

            //_pointInPath = MyPath.GetNextPathPoint();
            _pointInPath.MoveNext();
            if (_pointInPath.Current == null)
                throw new Exception("Точек нет");

            transform.position = _pointInPath.Current.position;
        }

        private void Update()
        {
            if (_pointInPath == null || _pointInPath.Current == null)
                return;

            transform.position = Vector2.MoveTowards(transform.position,
                _pointInPath.Current.position, Time.deltaTime * speed);
            
            var distanceSqure = (transform.position - _pointInPath.Current.position).sqrMagnitude;
            if (distanceSqure < Math.Pow(maxDistance, 2))
            {
                _pointInPath.MoveNext();
            }
        }
    }
}
