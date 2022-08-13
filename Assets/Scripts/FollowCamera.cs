using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform player;
    [SerializeField]
    private Vector3 offset;
    void Update()
    {
        transform.position = player.position + offset;

    }
}
