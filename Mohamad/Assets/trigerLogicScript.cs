using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigerLogicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public logicMangerScript logic;
    void Start()
    {
       // Debug.Log("triggered");
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicMangerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
    if (other.gameObject.layer == 3) {
        logic.addscore(1);
    }
}






}
