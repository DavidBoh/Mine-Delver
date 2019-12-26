using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleDmg : MonoBehaviour
{
    public float damagex2 = 30f;

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
            col.GetComponent<Character_Movement>().lifex = col.GetComponent<Character_Movement>().lifex - damagex2;
        }
    }
}
