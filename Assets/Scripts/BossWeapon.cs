using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject[] bulletPrefab;
    public float shoot = 0;
    void Shoot(int i)
    {
        Instantiate(bulletPrefab[i], firePoint.position, firePoint.rotation);
    }
}
