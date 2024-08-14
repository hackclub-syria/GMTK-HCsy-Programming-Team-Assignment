using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePillar : MonoBehaviour
{
    public int speed = 7;
    public float despawn = -40; //why is it a float?
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position is the position of the object
        transform.position = transform.position + (Vector3.left * speed * Time.deltaTime);

        if (transform.position.x < despawn)
        {
            Destroy(gameObject);
        }
    }
}
