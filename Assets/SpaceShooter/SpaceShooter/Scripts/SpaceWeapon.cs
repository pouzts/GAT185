using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceWeapon : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] Transform[] spawnTransform;
    [SerializeField] float fireRate;

    float fireTimer = 0;

    private void Update()
    {
        fireTimer -= Time.deltaTime;
    }

    public void Fire()
    {
        if (fireTimer <= 0)
        {
            fireTimer = fireRate;

            foreach (var t in spawnTransform)
            { 
                Instantiate(projectilePrefab, t.position, t.rotation);
            }
        }
    }
}
