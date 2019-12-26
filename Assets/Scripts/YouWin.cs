using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void OnTriggerStay(Collider col)//recibe el colider del objeto que entro.
    {
        if (col.name == "UDY"&& Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene("WIN");

        }
    }
}
