using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoints = 5;

    int currentHitPoints = 0;
    Enemy enemy;

    // Start is called before the first frame update
    void OnEnable()
    {
        currentHitPoints = maxHitPoints;
    }

    void Start()
    {
        enemy = GetComponent<Enemy>();
    }
   
    void Update()
    {
        
    }
    void OnParticleCollision(GameObject other)
    {
        ProccessHit();
    }

    void ProccessHit()
    {
        currentHitPoints--;

        if(currentHitPoints <= 0)
        {
            enemy.RewardGold();
            gameObject.SetActive(false);
        }
    }
}
