using UnityEngine;
using System;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private PlayerController _playerController;

    private int _score;

    private void Update()
    {
        if(!_playerController.IsDead)
        {
            _score += 1;
            _scoreText.text = _score.ToString();
        }  
    }
}
