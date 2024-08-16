using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_script : MonoBehaviour
{
    public float Left_speed = 5, Down_speed = 3, Dead_zone = -40;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * Left_speed * Time.deltaTime);
        transform.position += (Vector3.down * Down_speed * Time.deltaTime);
        if(transform.position.x < Dead_zone) Destroy(gameObject);
    }
}
