using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RoadMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(0, 0, -_speed);
    }
}
