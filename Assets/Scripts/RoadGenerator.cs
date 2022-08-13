using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    [SerializeField] private GameObject [] _roads;

    [SerializeField] private bool _generateStatus;
    [SerializeField] private int _currentRoadLenght = 0;
    [SerializeField] private int _maxRoadLenght = 6;

    private int _currentRoad = -1;

    private void FixedUpdate()
    {
        if(_generateStatus)
        {

        }
    }

}
