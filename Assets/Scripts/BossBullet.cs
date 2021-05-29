using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    public bool unblockable;
    public bool follow;
    public float speed;
    public MovePoint PlayerMp;
    public Rigidbody2D rb;
    public int bulletDamage = 100;

    void Start()
    {
        PlayerMp = FindObjectOfType<MovePoint>();
        if(!follow)
            rb.velocity = transform.up * -speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo) 
    {
        if(unblockable)
        {
            ShieldHit hit = hitInfo.GetComponent<ShieldHit>();
            if(hit != null)
            {
                hit.player.TakeDamage(bulletDamage);
            }
        }
        Player player = hitInfo.GetComponent<Player>();
            if(player != null)
            {
                player.TakeDamage(bulletDamage);
            }
        Destroy(gameObject);
    }
    private void Update()
    {
        if(follow)
            transform.position = Vector3.MoveTowards(transform.position, PlayerMp.t.position, speed*Time.deltaTime);            
        if(transform.position.y <= -10)
        {
            Destroy(gameObject);
        }
        
    }
}
