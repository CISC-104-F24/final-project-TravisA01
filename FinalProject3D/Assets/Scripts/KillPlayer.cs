using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public float threshold = 0.7f; 

    void FixedUpdate()
    {
        if(transform.position.y < threshold)
        {
            transform.position = new Vector3(-17.57f, 1.23f, -92.34f);
        }
    }
}
