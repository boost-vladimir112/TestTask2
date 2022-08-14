using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    private int _score;

    [SerializeField] private PlayerController _playerController;
    private void Update()
    {
        if(!_playerController.IsDead)
        {
            _score += 1;
            _scoreText.text = _score.ToString();
        }  
    }
}
