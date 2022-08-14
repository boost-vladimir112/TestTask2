using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ConvertCoinsToString : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _moneyText;
    [SerializeField] private int _coins;

    public void ConvertCoinsMethod()
    {
        PlayerPrefs.SetInt("coins", _coins);
        _moneyText.text = _coins.ToString();
    }

    private void Start()
    {
        _coins = PlayerPrefs.GetInt("coins");

    }
    private void Update()
    {
        ConvertCoinsMethod();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "coin")
        {
            Destroy(other.gameObject);
            _coins++;
        }
    }


}