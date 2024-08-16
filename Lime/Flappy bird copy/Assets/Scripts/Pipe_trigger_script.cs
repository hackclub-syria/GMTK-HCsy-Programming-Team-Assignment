using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_trigger_script : MonoBehaviour
{
    public Logic_script logic;
    public float gap;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic_script>();
        Transform Top_pipe = transform.parent.Find("Top Pipe");
        gap = Top_pipe.localPosition.y * 2f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3) logic.Add_score(90f/gap);
    }
}
