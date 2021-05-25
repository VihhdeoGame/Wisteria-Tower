using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    public float movespeed;
    public Transform movepoint;
    public LayerMask coliders;
    private int frames = 0;
    private int moveDir = 1;
     void Start()
    {
        movepoint.parent = null;
    }

   void Update()
    {
        frames++;
        transform.position = Vector3.MoveTowards(transform.position, movepoint.position, movespeed*Time.deltaTime);

        if(Vector3.Distance(transform.position,movepoint.position) == 0f)
        {
            if(frames >= 120)
            {
                movepoint.position += new Vector3(3*moveDir, 0f, 0f);
                if(Physics2D.OverlapCircle(movepoint.position + new Vector3(3*moveDir, 0f, 0f), 1f, coliders))
                    moveDir *= -1;
                frames = 0;
            }
        }    
    }
}
