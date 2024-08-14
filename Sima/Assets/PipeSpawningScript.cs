using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawningScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public float spawnInterval;
    private float timer = 0;
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnInterval)
        {
            timer += Time.deltaTime;
            return;
        }
        SpawnPipe();
        timer = 0;
    }

    void SpawnPipe()
    {
        Instantiate(pipe, transform.position + Random.Range(-17, 17) * Vector3.up, transform.rotation);
    }
}
