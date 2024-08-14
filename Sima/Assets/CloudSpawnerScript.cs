using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawnerScript : MonoBehaviour
{
    public GameObject cloud;
    public float spawnInterval;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        SpawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnInterval)
        {
            timer += Time.deltaTime;
            return;
        }
        SpawnCloud();
        timer = 0;
    }

    void SpawnCloud()
    {
        Instantiate(cloud, transform.position + Random.Range(-150, 150) * Vector3.up, transform.rotation);
    }
}
