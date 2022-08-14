using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RoadMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _lifeTime = 6f;

    [SerializeField] private PlayerController _playerController;
    
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        _lifeTime -= Time.deltaTime;
        if (_lifeTime <= 0f)
        {
            Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {
        if(!_playerController.IsDead)
        {
            rb.velocity = new Vector3(0, 0, -_speed);
        }
        else
        {
            rb.velocity = Vector3.zero;
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
