using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tungstene : MonoBehaviour
{
    public Canvas canvx2; 
    public GameObject finalgatex;

    void Start()
    {
         canvx2.enabled=false;

    }

    
    void Update()
    {
        

    }

    private void OnTriggerStay(Collider col)//recibe el colier del objeto que entro.
    {
        if(col.name== "UDY" && Input.GetKey(KeyCode.E))
        {
            
             Destroy(finalgatex);
             Destroy(this.gameObject);
             canvx2.enabled=true; 
                         
        }
    }

}
