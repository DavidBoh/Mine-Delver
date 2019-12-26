using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Character_Movement : MonoBehaviour
{

    public float speed = 5f;
    public float rotation = 55f;
    public float lifex = 100f;
    public Text health;
    public Canvas canv;
    public GameObject Camera1; 
    public GameObject Camera2, PjPrincipal, Jefe, PjSecundario, Jefe2;

    void Start()
    {
         Camera1.SetActive(true);
         Camera2.SetActive(false);
         PjSecundario.SetActive(false);
         Jefe2.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        SwitchCamera(); 
        CheckCond();
        ManejoVida();
        GameOver();
        Debug.Log(lifex);
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotation * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotation * Time.deltaTime, 0);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            lifex=lifex-20f;
           
            
        }
     
    }

    void CheckCond()
    {
       
    }

    public void ManejoVida()
    {
       health.text = "Life: " + lifex.ToString()+ " %";
    }

    public void GameOver()
    {
        if (lifex <= 0)
        {
            SceneManager.LoadScene("gameover");
        }
    }

    void SwitchCamera()
    {
        if(Input.GetKey(KeyCode.P))
        {
           Camera1.SetActive(false);
           Camera2.SetActive(true);
        }
    }

     private void OnTriggerEnter(Collider col)
    {
        if (col.name == "Modelo2")
        {
            Camera1.SetActive(false);
            Camera2.SetActive(true);
            PjPrincipal.SetActive(false);
            Jefe.SetActive(false);
            PjSecundario.SetActive(true);
            Jefe2.SetActive(true);
        }
       
    }



  
}
