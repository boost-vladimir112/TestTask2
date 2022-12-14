using UnityEngine;
public class RoadGenerator : MonoBehaviour
{
    [SerializeField] private Transform _spawnPos;
    [SerializeField] private GameObject[] _roads;

    [SerializeField] private float _spawnTimer = 2.5f;
    private float _currentTimer;

    private GameObject _currentRoad;

    [SerializeField] private PlayerController _playerController;

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
        if (!_playerController.IsDead)
        {
            RandomRoad();
            Instantiate(_currentRoad, _spawnPos.position, transform.rotation);
        }
    }
}