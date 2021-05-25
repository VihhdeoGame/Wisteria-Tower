using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBattleMovement : MonoBehaviour
{
    public float movespeed;
    public float regularMS;
    public float dodgeMS;
    public Transform movepoint;
    public LayerMask coliders;
    public GameObject shield;
    public CapsuleCollider2D playerCollider;
    void Start()
    {
        movepoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        if(shield.activeInHierarchy)
        {
            movespeed = dodgeMS;
            playerCollider.enabled = false;
        }
        else
        {
            movespeed = regularMS;
            playerCollider.enabled = true;
        }
        transform.position = Vector3.MoveTowards(transform.position, movepoint.position, movespeed*Time.deltaTime);

        if(Vector3.Distance(transform.position,movepoint.position) == 0f)
        {
            if(Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                if(!Physics2D.OverlapCircle(movepoint.position + new Vector3(3*Input.GetAxisRaw("Horizontal"), 0f, 0f), 1f, coliders))
                {
                    movepoint.position += new Vector3(3*Input.GetAxisRaw("Horizontal"), 0f, 0f);
                    if(shield.activeInHierarchy)
                    {
                        if(!Physics2D.OverlapCircle(movepoint.position + new Vector3(3*Input.GetAxisRaw("Horizontal"), 0f, 0f), 1f, coliders))
                            movepoint.position += new Vector3(3*Input.GetAxisRaw("Horizontal"), 0f, 0f);
                    }
                }
            }
        }    
    }
}
