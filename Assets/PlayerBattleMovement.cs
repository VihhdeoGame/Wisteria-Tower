using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBattleMovement : MonoBehaviour
{
    [SerializeField]
    private float movespeed;
    [SerializeField]
    private Transform movepoint;
    [SerializeField]
    private LayerMask coliders;
    void Start()
    {
        movepoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movepoint.position, movespeed*Time.deltaTime);

        if(Vector3.Distance(transform.position,movepoint.position) <= 0.1f)
        {
            if(Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                if(!Physics2D.OverlapCircle(movepoint.position + new Vector3(3*Input.GetAxisRaw("Horizontal"), 0f, 0f), 1f, coliders))
                    movepoint.position += new Vector3(3*Input.GetAxisRaw("Horizontal"), 0f, 0f);
            }
        }    
    }
}
