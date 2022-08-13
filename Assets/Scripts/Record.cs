using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Record : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _currentScoreText;
    [SerializeField] private TextMeshProUGUI _recordText;

    private int _currentScore;
    private int _record;
    private void Start()
    {
        _record = PlayerPrefs.GetInt("record");
        _recordText.text = "Record: " + _record.ToString();
    }
    private void Update()
    {
        _currentScore = int.Parse(_currentScoreText.text);
        CompareScore();
        _recordText.text = "Record: " + _record.ToString();
    }
    private void CompareScore()
    {

        if (_currentScore > _record)
        {
            _record = _currentScore;
            PlayerPrefs.SetInt("record", _record);
            PlayerPrefs.Save();
        }
    }

}