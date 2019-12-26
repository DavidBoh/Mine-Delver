using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mole : MonoBehaviour
{
    
    public float molehealth = 40f; 

    void Start()
    {
        
    }

    
    void Update()
    {
        EndFight();

        if (Input.GetKeyDown(KeyCode.T))
        {
            molehealth=molehealth-20f;
           
            
        }

    }

    public void EndFight()
    {
        if (molehealth <= 0)
        {
            SceneManager.LoadScene("Game");
        }
    }

}
