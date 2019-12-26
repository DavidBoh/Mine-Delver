using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spark : MonoBehaviour
{
    public float damagex = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.name == "UDY")
        {
            col.GetComponent<Character_Movement>().lifex = col.GetComponent<Character_Movement>().lifex - damagex;
        }
    }



}
