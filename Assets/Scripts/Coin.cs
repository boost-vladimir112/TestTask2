using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Coin : MonoBehaviour
{
    [SerializeField] private AudioSource _coinSound;
    [SerializeField] private AudioClip _coinClip;
 
    private void Start()
    {
        _coinClip = _coinSound.clip;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _coinSound.PlayOneShot(_coinClip);

        }
    }
    void Update()
    {
        transform.Rotate(0, 40 * Time.deltaTime, 0);
    }

}


