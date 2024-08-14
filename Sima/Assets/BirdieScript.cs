using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdieScript : MonoBehaviour
{
    public Rigidbody2D birdieRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public Sprite WingDown, WingUp;
    public GameObject Wing1, Wing2;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (logic.birdieIsBreathing && Input.GetKeyDown(KeyCode.Space))
        {
            birdieRigidBody.velocity = Vector2.up * flapStrength;
        }
        if (logic.birdieIsBreathing)
        {
            if (birdieRigidBody.velocity.y > 0)
            {
                Wing1.GetComponent<SpriteRenderer>().sprite = WingDown;
                Wing2.GetComponent<SpriteRenderer>().sprite = WingDown;
            }
            else
            {
                Wing1.GetComponent<SpriteRenderer>().sprite = WingUp;
                Wing2.GetComponent<SpriteRenderer>().sprite = WingUp;
            }
        }
        if (logic.birdieIsBreathing && (transform.position.y <= -39 || transform.position.y >= 39))
        {
            logic.GameOver();
        }
        if (transform.position.y <= -39 || transform.position.y >= 39)
        {
            Destroy(gameObject);
            Debug.Log("Birdie's corpse successfully destroyed");
        }
    }
}
