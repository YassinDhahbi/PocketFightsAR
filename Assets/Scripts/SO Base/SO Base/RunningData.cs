using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "RunningGameData", menuName = "Data Holder/RunningGameData")]
public class RunningData : ScriptableObject
{
    public float playerSpeed;
    public float distance;
    public float minimumSpeed;
    public float distanceToTravel, currentTraveledDistance, scoreAdditionTimer;
    public int currentScore;
    public float turnningSpeed;
    public float movementBoostMultiplier = 1;
    public float speedLimit;
    public bool gameStarted = false;
    public int numberOfLaps = 1;
    public float currentSpeed;
}
