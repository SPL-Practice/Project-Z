using UnityEngine;

namespace Obstacles
{
    [ExecuteAlways]
    public class BezierTest : MonoBehaviour
    {
        public Transform _point0;
        public Transform _point1;
        public Transform _point2;
        public Transform _point3;

        [Range(0,1)]
        public float t;

        private void Update()
        {
            transform.position = Bezier.GetPoint(_point0.position, _point1.position, _point2.position, _point3.position, t);
        }


        private void OnDrawGizmos() {

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
