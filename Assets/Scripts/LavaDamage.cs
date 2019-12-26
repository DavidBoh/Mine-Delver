using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaDamage : MonoBehaviour
{
    public float damagex3 = 2f;

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
            col.GetComponent<Character_Movement>().lifex = col.GetComponent<Character_Movement>().lifex - damagex3;
        }
        if (col.name == "MechaMoleProp")
        {
            col.GetComponent<MoleContact>().molelife = col.GetComponent<MoleContact>().molelife - damagex3;
        }
    }
}
