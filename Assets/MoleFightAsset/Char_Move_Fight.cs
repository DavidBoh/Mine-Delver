using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Char_Move_Fight : MonoBehaviour
{

    public float speed = 5f;
    public float rotation = 55f;
    public float lifex = 100f;
    public Text health;
    public Canvas canv;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckCond();
        ManejoVida();
        GameOver();
        Debug.Log(lifex);      
     
    }

    void CheckCond()
    {
        
    }

    public void ManejoVida()
    {
       //health.text = "Life: " + lifex.ToString()+ " %";
    }

    public void GameOver()
    {
        if (lifex <= 0)
        {
            SceneManager.LoadScene("gameover");
        }
    }
  
}
