using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UdyFinalScene : MonoBehaviour
{
    public float speed = 5f;
    public float rotation = 55f;
    public float lifex22 = 100f;
     public Text health;
    public Canvas canv;
   
    void Start()
    {
         
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
        GameOver();
       
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, 0, speed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate( speed * Time.deltaTime,0,0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-speed * Time.deltaTime,0,0);
        }
       
     
    }

   

    public void ManejoVida()
    {
       health.text = "Life: " + lifex22.ToString()+ " %";
    }

    public void GameOver()
    {
        if (lifex22 <= 0)
        {
            SceneManager.LoadScene("gameover");
        }
    }

   

}
