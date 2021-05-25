using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public Transform parent, movePoint;
    public GameObject shield;
    private void Update() 
    {
        if(Input.GetButton("Fire2"))
        {
            shield.SetActive(true);
        }
        if(!Input.GetButton("Fire2") && parent.position == movePoint.position)
        {
            shield.SetActive(false);
        }
    }
}