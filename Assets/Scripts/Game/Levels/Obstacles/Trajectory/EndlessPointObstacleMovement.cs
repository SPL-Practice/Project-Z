using System;

namespace Obstacles
{
    public class EndlessPointObstacleMovement : PointObstacleMovement
    {
        private bool IsEndReached = false;

        protected override void Move()
        {
            MoveToPath();
            
            if (IsEndReached)
                DecrementaryMove();
            else
                IncrementaryMove();
        }

        private bool IsDistanceBigger()
        {
            var distanceSquare = (transform.position - _points[_currentNumberPosition].position).sqrMagnitude;
            return distanceSquare >= Math.Pow(0.1f, 2);
        }

        private protected override void IncrementaryMove()
        {
            if (IsDistanceBigger())
                return;

            IsEndReached = _currentNumberPosition >= _points.Count - 1;
            if (!IsEndReached)
            {
                _currentNumberPosition++;
            }
        }

        protected void DecrementaryMove()
        {
            if (IsDistanceBigger())
                return;

            IsEndReached = _currentNumberPosition > 0;
            if (IsEndReached)
            {
                _currentNumberPosition--;
            }
        }
    }
}