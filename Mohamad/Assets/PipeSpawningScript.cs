using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawningScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 3;
    public float timer = 0;
    public float spawnOffset = 5;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<spawnrate){
            timer += Time.deltaTime;
        }else{
            spawnPipe();
           
            timer = 0;
    }


    } 
    void spawnPipe(){
        float lowestPoint = transform.position.y - spawnOffset;
        float highestPoint = transform.position.y + spawnOffset;
         Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint ),0), transform.rotation);
    }     
        
}
