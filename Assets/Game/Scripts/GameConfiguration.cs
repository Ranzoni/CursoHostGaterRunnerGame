using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Config", menuName = "HostGator Runner/GameConfiguration", order = 1)]
public class GameConfiguration : ScriptableObject
{
    public float speed = 4f;
    public float minRangeObstacleGenerator;
    public float maxRangeObstacleGenerator;
}
