using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    [SerializeField] private Transform _spawnPos;
    [SerializeField] private GameObject[] _roads;

    [SerializeField] private float _spawnTimer = 2.5f;
    private float _currentTimer;

    private GameObject _currentRoad;

    private void Start()
    {
        _currentTimer = _spawnTimer;
    }

    private void Update()
    {
        
        _currentTimer -= Time.deltaTime;
        if (_currentTimer <= 0)
        {
            InstantiateRoad();
            _currentTimer = _spawnTimer;
        }
          


    }


    private void RandomRoad()
    {
        _currentRoad = _roads[Random.Range(0, _roads.Length)];
    }
    private void InstantiateRoad()
    {
        RandomRoad();
        Instantiate(_currentRoad, _spawnPos.position, transform.rotation);
    }
 
}

  



