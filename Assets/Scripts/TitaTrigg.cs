using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitaTrigg : MonoBehaviour
{
    public GameObject uiObjetc;
    public GameObject DoorTr;
    public float timecount= 0;
    public bool check= false;

    void Start()
    {
        uiObjetc.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (check)
        {
            timecount = timecount + Time.deltaTime;
            if (timecount >=4)
            {     
                uiObjetc.SetActive(false);
            }
        }
    }

    void OnTriggerEnter(Collider coli)
    {

        if (coli.name == "UDY")
        {
          //  can.enabled = true;
              uiObjetc.SetActive(true);
              
        }
    }
    
    void OnTriggerExit(Collider coli)
    {
        check = true;
        
    }

    

    
}
