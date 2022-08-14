using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private AudioSource _obstacleSound;
    [SerializeField] private AudioClip _obstacleClip;
    private void Start()
    {
        _obstacleClip = _obstacleSound.clip;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _obstacleSound.PlayOneShot(_obstacleClip);
        }
    }
}
