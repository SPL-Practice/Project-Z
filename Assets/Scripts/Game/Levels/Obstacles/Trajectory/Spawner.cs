using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Vector2 _frequency;
    [SerializeField] private List<GameObject> _objects;

    protected void Start()
    {
        PrepareSpawn();
    }

    protected virtual void PrepareSpawn()
    {
        StartCoroutine(Spawn());
    }

    protected IEnumerator Spawn()
    {
        while (true)
        {
            var obstacle = Instantiate(_objects[Random.Range(0, _objects.Count)], transform);
            obstacle.transform.localPosition = Vector3.zero;
            obstacle.gameObject.SetActive(true);
            yield return new WaitForSeconds(Random.Range(_frequency.x, _frequency.y));
        }
    }
}
