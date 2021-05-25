using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int frames = 0;
    void Update()
    {
        frames++;
        if(frames >= 120)
        {
            Shoot();
            frames = 0;
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
