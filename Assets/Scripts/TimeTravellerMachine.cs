using System;
using TMPro;
using UnityEngine;

[Serializable]
public enum TravelTime
{
    Dinosaur = 0,
    Medieval = 1,
    Home = 2
}

public class TimeTravellerMachine : MonoBehaviour
{
    [SerializeField] private TravelTime[] _travelTimes;
    [SerializeField] private TextMeshPro _machineText;
    
    private int _currentTravelTimeIndex = 0;
    
    public void ChangeTravelTime()
    {
        _currentTravelTimeIndex++;

        if (_currentTravelTimeIndex >= _travelTimes.Length)
        {
            _currentTravelTimeIndex = 0;
        }

        _machineText.text = _travelTimes[_currentTravelTimeIndex].ToString();
    }
}
