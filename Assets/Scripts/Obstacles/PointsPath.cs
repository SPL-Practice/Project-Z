using System;
using System.Collections.Generic;
using UnityEngine;

namespace Obstacles
{
    public class PointsPath : MonoBehaviour
    {
        private List<Vector2> _points;
        private int _currentNumberPosition = 0;
        private void Start()
        {
            _points = new List<Vector2>();
            foreach (var point in GetComponentsInChildren<Transform>())
                _points.Add(point.position);
        }

        private void Update()
        {
            transform.position = Vector2.MoveTowards(transform.position,
                _points[_currentNumberPosition], Time.deltaTime * 1);
            
            var distanceSqure = ((Vector2)transform.position - _points[_currentNumberPosition]).sqrMagnitude;
            if (distanceSqure < Math.Pow(0.1f, 2))
            {
                _currentNumberPosition++;
            }
        }
    }
}
