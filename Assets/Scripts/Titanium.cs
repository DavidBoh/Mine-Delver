using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Titanium : MonoBehaviour
{
    public Canvas canvx; 
    public GameObject turtle1, turtle2, turtle3, turtle4, turtle5, turtle6, gatex1;
    void Start()
    {
       canvx.enabled=false;
      
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnTriggerStay(Collider col)//recibe el colier del objeto que entro.
    {
        if(col.name== "UDY" && Input.GetKey(KeyCode.E))
        {
            
             Destroy(turtle1);
             Destroy(turtle2);
             Destroy(turtle3);

             Destroy(turtle4);
             Destroy(turtle5);
             Destroy(turtle6);
             Destroy(gatex1);
             Destroy(this.gameObject);
             canvx.enabled=true; 
                         
        }
    }

    

    

}
