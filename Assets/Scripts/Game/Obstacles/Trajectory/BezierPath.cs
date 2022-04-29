using System.Collections.Generic;
using UnityEngine;

namespace Obstacles
{
    [ExecuteAlways]
    public class BezierPath : MonoBehaviour
    {
        public Transform _point0;
        public Transform _point1;
        public Transform _point2;
        public Transform _point3;

        public List<Transform> GetPoints() => new List<Transform>{ _point0, _point1, _point2, _point3 };
        
        private void OnDrawGizmos() 
        {
            var segmentsNumber = 20;
            var previousPoint = _point0.position;

            Gizmos.color = Color.green;
            Gizmos.DrawLine(_point0.position, _point1.position);
            Gizmos.DrawLine(_point2.position, _point3.position);
            Gizmos.color = Color.red;
            
            for (var i = 0; i < segmentsNumber + 1; i++) {
                var parameter = (float)i / segmentsNumber;
                Vector3 point = Bezier.GetPoint(_point0.position, _point1.position, _point2.position, _point3.position, parameter);
                Gizmos.DrawLine(previousPoint, point);
                previousPoint = point;
            }

        }
    }
}
