using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_script : MonoBehaviour
{
    private Rigidbody2D Bird;
    public AudioClip Flap_sound, Metal_bump_sound, Ground_bump_sound;
    public AudioSource Source;
    public float Flap_strength = 10f, Hold_strength = 0.5f;
    public float Hold_time = 0f, Max_hold = 0.2f;         
    private bool Holding = false;
    public Logic_script logic;
      void Start()
    {
        Bird = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Bird.velocity = new Vector2(Bird.velocity.x, Flap_strength);
            Hold_time = 0f; Holding = true;
            Source.clip = Flap_sound;
            Source.pitch = UnityEngine.Random.Range(0.80f, 1f);
            Source.volume = UnityEngine.Random.Range(0.80f, 1f);
            Source.Play();
            logic.Flap();
        }

        if ((Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0)) && Holding)
        {
            Hold_time += Time.deltaTime;
            if (Hold_time < Max_hold) 
            {
                logic.Flap();
                Bird.velocity = new Vector2(Bird.velocity.x, Bird.velocity.y + (Flap_strength/10) +  Hold_strength * (Hold_time * 20 * Hold_time * Hold_time));
            }
            else Holding = false;
        }

        if (Input.GetKeyUp(KeyCode.Space)) Holding = false;
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 7) Source.clip = Metal_bump_sound;
        if(collision.gameObject.layer == 8) Source.clip = Ground_bump_sound;
        Source.pitch = UnityEngine.Random.Range(0.80f, 1f);
        Source.volume = UnityEngine.Random.Range(0.80f, 1f);
        Source.Play();
        logic.Game_over();
    }
}
