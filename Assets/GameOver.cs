﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
   public void GameOverx() 
    {
        SceneManager.LoadScene("gameover");
        //(SceneManager.GetActiveScene().buildIndex+1);
    }
}