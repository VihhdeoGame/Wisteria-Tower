using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 300;
    int frames = 1;
    bool invunerable;
    int invunerableT = 0;

    void Update()
    {
        frames++;
        if(frames % 10 == 0 && !invunerable)
        {
            if(health < 300)
                health++;
        }
        if(invunerable)
        {
            invunerableT++;
            if(invunerableT > 20)
            {
                invunerable = false;
                invunerableT = 0;
            }
        }
    }
    public void TakeDamage(int damage)
    {
        if(!invunerable)
        {
            health -= damage;
            invunerable = true;
        }
        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
