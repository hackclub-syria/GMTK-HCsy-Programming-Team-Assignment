using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovemment : MonoBehaviour
{
    public float Pipespeed = 2;
    private  float deadZone = -35;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * Pipespeed ) * Time.deltaTime;
        if(transform.position.x < deadZone){
            Destroy(gameObject);
        }
        
    }
}
