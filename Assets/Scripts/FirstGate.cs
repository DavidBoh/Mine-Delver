using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstGate : MonoBehaviour
{
    Animator ani;

    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider col)//recibe el colider del objeto que entro.
    {
        if (col.name == "UDY"&& Input.GetKey(KeyCode.E))
        {
            ani.SetBool("open", true);

        }
    }

}
