using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Obstacle : MonoBehaviour
{
    [SerializeField] private AudioSource _obstacleSound;
    [SerializeField] private AudioClip _obstacleClip;

    [SerializeField] private Transform _spawnPos;
    [SerializeField] private GameObject _deadVFX;

    private void Start()
    {
        _obstacleClip = _obstacleSound.clip;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Instantiate(_deadVFX, _spawnPos.position, transform.rotation);
            _obstacleSound.PlayOneShot(_obstacleClip);
        }
    }
}