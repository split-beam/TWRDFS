using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetLocator : MonoBehaviour
{
    [SerializeField] Transform weapon;
    [SerializeField] float range = 15f;
    [SerializeField] ParticleSystem ProjectileParticles;
    Transform target;

    void Update()
    {
        FindClosestTarget();
        AimWeapon();
    }

    void FindClosestTarget()
    {
        Enemy[] enemies = FindObjectsOfType<Enemy>();
        Transform closetTarget = null;
        float maxDistance = Mathf.Infinity;

        foreach(Enemy enemy in enemies)
        {
            float targetDistance = Vector3.Distance(transform.position, enemy.transform.position);

            if(targetDistance < maxDistance)
            {
                closetTarget = enemy.transform;
                maxDistance = targetDistance;
            }
        }

        target = closetTarget;
    }

    void AimWeapon()
    {
        if (target == null) { return; } //Safe Net For When All Enemies are defeated

        float targetDistance = Vector3.Distance(transform.position, target.position);
        weapon.LookAt(target); //wrap in if tracking needs to be turned off
        
        if(targetDistance <= range)
        {
            Attack(true);
        }
        else 
        {
            Attack(false);
        }
    }

    void Attack(bool isActive)
    {
        
        var emissionModuel = ProjectileParticles.emission;
        emissionModuel.enabled = isActive;   
    }
}
