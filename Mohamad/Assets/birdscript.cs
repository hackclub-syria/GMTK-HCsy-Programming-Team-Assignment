using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript : MonoBehaviour
{
   public Rigidbody2D myRigidbody;
   public float flapstrength;
   public logicMangerScript logic;
   public bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicMangerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isAlive == true){
        myRigidbody.velocity = Vector2.up * flapstrength ;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D Collision){
            logic.gameOver();
            isAlive = false;


        }
}
