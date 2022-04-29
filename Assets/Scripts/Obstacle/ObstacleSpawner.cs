using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Obstacle
{
    public class ObstacleSpawner : MonoBehaviour
    {
        [SerializeField] private Vector2 _frequency; 
        [SerializeField] private List<Obstacle> _obstacles;

        private void Start()
        {
            StartCoroutine(Spawn());
        }

        private IEnumerator Spawn()
        {
            while (true)
            {
                var obstacle = Instantiate(_obstacles[Random.Range(0, _obstacles.Count)], transform);
                obstacle.transform.localPosition = Vector3.zero;
                obstacle.gameObject.SetActive(true);
                yield return new WaitForSeconds(Random.Range(_frequency.x, _frequency.y));
            }
        }
    }
}
