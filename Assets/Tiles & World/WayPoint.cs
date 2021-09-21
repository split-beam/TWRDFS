using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    [SerializeField] GameObject towerPrefab;
    [SerializeField] bool isPlaceable;
    public bool IsPlaceable { get { return isPlaceable;} } //Public allows other scripts too see (safer than public method, no overriting), Get property, Read Variable

    void OnMouseDown()
    {
        if (isPlaceable)
        {
            Instantiate(towerPrefab, transform.position, Quaternion.identity); //What, Where, Rotation
            isPlaceable = false; //Stop Placing Towers on Towers
        }
    }
}
