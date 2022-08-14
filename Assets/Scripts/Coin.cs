using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Coin : MonoBehaviour
{
    [SerializeField] private AudioSource _coinSound;
    [SerializeField] private AudioClip _coinClip;

    [SerializeField] private Transform _spawnPos;
    [SerializeField] private GameObject _coinVFX;

    private void Start()
    {
        _coinClip = _coinSound.clip;
    }
    private void Update()
    {
        transform.Rotate(0, 40 * Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _coinSound.PlayOneShot(_coinClip);
            Instantiate(_coinVFX, _spawnPos.position, transform.rotation);
        }
    }
}