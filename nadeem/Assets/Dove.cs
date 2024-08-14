using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dove : MonoBehaviour
{
    public LogicScript logic;
    public int startingRotation;
    public int fallingRotation;
    public Rigidbody2D myDove;
    public bool birdAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdAlive)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, startingRotation);
            myDove.velocity = Vector2.up * 15;
        }
        transform.Rotate(0, 0, fallingRotation * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdAlive = false;
        logic.showGameOver();
    }
}
