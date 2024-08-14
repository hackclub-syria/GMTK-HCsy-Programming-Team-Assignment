using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPipes : MonoBehaviour
{
    public GameObject pillar;
    public float interval = 2; // float because Time.deltaTime uses float bc it counts the time from the most recent frame to the current one
    private float time = 0; //private because we won't need to access it through unity :3
    public float heightOffset; // i think it's float bc we'll be picking a random range
    public float rotationOffset; //teehee >:3

    // Start is called before the first frame update
    void Start()
    {
        spawn(); // to spawn a pillar
    }

    // Update is called once per frame
    void Update()
    {
        // Let's spawn some stuff with the Instantiate() thingy
        // transform.position and transform.rotation make the spawned "stuff" inherit these from the spawner
        // let's add a timer to avoid disaster
        if (time > interval)
        {
            spawn();
            time = 0; //we have to reset the time so that it restarts for every pillar :D
        } else
        {
            time += Time.deltaTime; // add more time to the $timer so that it reaches $interval
        }
    }

    void spawn() //create afunction to avoid repetitive code :3
    {
        // the height range in which the pillars will show up
        float maxHeight = transform.position.y + heightOffset;
        float minHeight = transform.position.y - heightOffset;

        float maxRotation = transform.rotation.z + rotationOffset;
        float minRotation = transform.rotation.z - rotationOffset;

        Instantiate(
            pillar,
            new Vector3(transform.position.x, Random.Range(minHeight, maxHeight), 0),
            transform.rotation = Quaternion.Euler(0, 0, Random.Range(minRotation,maxRotation))
            );
    }
}
