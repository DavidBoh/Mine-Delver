using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gold : MonoBehaviour
{
    public float healing = 5;
    public Canvas canvx1;
    void Start()
    {
        canvx1.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider col)//recibe el colier del objeto que entro.
    {
        if(col.name== "UDY" && Input.GetKey(KeyCode.E))
        {
            
             
             
             //if((col.GetComponent<Character_Movement>().lifex>80 && col.GetComponent<Character_Movement>().lifex<101))
           //  {
             col.GetComponent<Character_Movement>().lifex = col.GetComponent<Character_Movement>().lifex + healing; 
            // }
             canvx1.enabled=true; 
             Destroy(this.gameObject);
            
        }
    }

}
