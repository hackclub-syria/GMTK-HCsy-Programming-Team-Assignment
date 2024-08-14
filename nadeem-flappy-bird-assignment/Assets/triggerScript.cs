using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class triggerScript : MonoBehaviour
{
    public LogicScript logic;
    public GameObject pillar;
    public bool gameLost = false;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        pillar = GameObject.FindGameObjectWithTag("pillar");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*        Quaternion angle = pillar.transform.rotation;
                if (angle.eulerAngles.z <= -14 || angle.eulerAngles.z >= 14)
                {
                    logic.increaseScore(5);
                } else
                {
                    logic.increaseScore(1);
                } */
        logic.increaseScore(1);
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }

}
