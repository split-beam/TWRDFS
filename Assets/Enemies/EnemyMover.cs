using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<WayPoint> path = new List<WayPoint>();
    [SerializeField] float waitTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FollowPath());
    }

    IEnumerator FollowPath()
    {
        foreach(WayPoint waypoint in path) 
        {
            // Debug.Log(waypoint.name);
            transform.position = waypoint.transform.position;
            yield return new WaitForSeconds(waitTime);
        }
    }
}
