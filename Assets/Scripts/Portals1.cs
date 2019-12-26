using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portals1 : MonoBehaviour
{
    public Transform target;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        other.transform.parent.transform.position = target.position;
    }
}
