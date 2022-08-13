using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int _lineToMove = 1;
    [SerializeField] private float _lineDistance = 4;
    [SerializeField] GameObject _losePanel;
    private bool _isDead;

    public bool IsDead { get => _isDead; set => _isDead = value; }

    private void Update()
    {
        SwipeTracker();
    }
    private void FixedUpdate()
    {
        SwipePosition();
    }

    private void SwipeTracker()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (_lineToMove < 2)
                _lineToMove++;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (_lineToMove > 0)
                _lineToMove--;
        }
    }
    private void SwipePosition()
    {
        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;
        if (_lineToMove == 0)
            targetPosition += Vector3.left * _lineDistance;
        else if (_lineToMove == 2)
            targetPosition += Vector3.right * _lineDistance;

        transform.position = targetPosition;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            Time.timeScale = 0;
            _losePanel.SetActive(true);
            _isDead = true;
        }
    }
}
