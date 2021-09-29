using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoints = 5;
    [Tooltip("Adds Amount To MaxHP After Enemy Dies")]

    [SerializeField] int difficultyRamp = 1;

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
            maxHitPoints += difficultyRamp;
            gameObject.SetActive(false);
        }
    }
}
