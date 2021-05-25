using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint, parent, movePoint;
    public GameObject bulletPrefab,shield;
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && parent.position == movePoint.position && !shield.activeInHierarchy)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
