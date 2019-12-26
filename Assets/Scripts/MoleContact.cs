using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoleContact : MonoBehaviour
{
    public GameObject molee; 
    public float molelife = 570;
    void Start()
    {
            // Camera.enabled = true;
             //Camera2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        MoleDeath();
    }

    private void OnTriggerStay(Collider col)//recibe el colier del objeto que entro.
    {
        

    }

    public void MoleDeath()
    {
        if (molelife <= 0)
        {
            Destroy(molee);
        }
    }

    public void MoleScene() 
    {
        
        
        


    }

}
