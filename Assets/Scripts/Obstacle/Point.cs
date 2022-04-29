using System.Collections.Generic;
using UnityEngine;

namespace Obstacle
{
    [ExecuteAlways]
    public class Point : MonoBehaviour
    {
        private List<Transform> _points;

        public List<Transform> GetPoints() => _points;
        
        private void Start()
        {
            InitializationPoints();
        }

        private void InitializationPoints()
        {
            _points = new List<Transform>();
            foreach (var point in GetComponentsInChildren<Transform>())
                _points.Add(point);
            _points.Remove(_points[0]);
        }
        
        private void OnDrawGizmos()
        {
            InitializationPoints();
            Gizmos.color = Color.green;
            for (var i = 0; i < _points.Count - 1; i++)
                Gizmos.DrawLine(_points[i].position, _points[i+1].position);
        }
    }
}
