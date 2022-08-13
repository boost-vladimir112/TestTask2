using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private int _coins;

    public int Coins { get => _coins; set => _coins = value; }

    void Update()
    {
        transform.Rotate(0, 40 * Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
            _coins += 1;
    }

}
