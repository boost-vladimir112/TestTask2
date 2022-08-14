using UnityEngine;
using TMPro;


public class ConvertCoinsToString : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _moneyText;
    private int _coins;

    private void Start()
    {
        _coins = PlayerPrefs.GetInt("coins");
    }
    private void Update()
    {
        ConvertCoinsMethod();
    }
    public void ConvertCoinsMethod()
    {
        PlayerPrefs.SetInt("coins", _coins);
        _moneyText.text = _coins.ToString();
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