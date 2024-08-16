using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_script : MonoBehaviour
{
    public GameObject Pipe_prefab; 
    public float Spawn_rate = 1f, Offset = 10f, Min_gap = 40f, Max_gap = 50f;

    private float timer = 0f;

    void Start()
    {
        Spawn_pipe();
    }

    void Update()
    {
        if (timer < Spawn_rate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Spawn_pipe();
            timer = 0f;
        }
    }

    void Spawn_pipe()
    {
        float Lowest = transform.position.y - Offset;
        float Highest = transform.position.y + Offset;
        Vector3 spawnPosition = new Vector3(transform.position.x, UnityEngine.Random.Range(Lowest, Highest), 0);
        GameObject Pipe = Instantiate(Pipe_prefab, spawnPosition, Quaternion.identity);

        Transform Top_pipe = Pipe.transform.Find("Top Pipe");
        Transform Bottom_pipe = Pipe.transform.Find("Bottom Pipe"); 
        float Gap = UnityEngine.Random.Range(Min_gap, Max_gap);
        Top_pipe.localPosition = new Vector3(Top_pipe.localPosition.x, Gap / 2f, Top_pipe.localPosition.z);
        Bottom_pipe.localPosition = new Vector3(Bottom_pipe.localPosition.x, -Gap / 2f, Bottom_pipe.localPosition.z);
    }
}
