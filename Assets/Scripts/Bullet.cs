using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public int bulletDamage = 50;

    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo) 
    {
        Boss boss = hitInfo.GetComponent<Boss>();
        if(boss != null)
        {
            boss.TakeDamage(bulletDamage);
            Destroy(gameObject);
        }
        
    }
    private void Update()
    {
        if(transform.position.y >= 10)
        {
            Destroy(gameObject);
        }
        
    }
}
