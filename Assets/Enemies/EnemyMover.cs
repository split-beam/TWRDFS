using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<WayPoint> path = new List<WayPoint>();

    // Start is called before the first frame update
    void Start()
    {
        PrintWayPointName();
    }

    void PrintWayPointName()
    {
        foreach(WayPoint waypoint in path) 
        {
            Debug.Log(waypoint.name);
        }
    }
}
