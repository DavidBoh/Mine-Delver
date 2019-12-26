using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeoff : MonoBehaviour
{
   Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider col)//recibe el colider del objeto que entro.
    {
        if (col.name == "UDY")
        {
            anim.SetBool("takeoff", true);

        }
    }
}
