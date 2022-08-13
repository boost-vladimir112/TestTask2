using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCheck : MonoBehaviour
{
    [SerializeField] GameObject _losePanel;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            Time.timeScale = 0;
            _losePanel.SetActive(true);
        }

    }


}
