using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 


public class Droid1 : MonoBehaviour
{
   enum STATES{
            idle,walking,fight,death
        }
        
    STATES currentState;
    Animator anim;
    NavMeshAgent na;
    float currentDistance;
    public float distanceFollow;
    public GameObject player ;
    public int lifex2;

    void Start()
    {
        anim = GetComponent<Animator>();
        na = GetComponent<NavMeshAgent>();
         
        
         lifex2 = 100;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        currentDistance = Vector3.Distance(transform.position,player.transform.position);
        Debug.Log(currentDistance);
        if (currentDistance < distanceFollow)
        {
           if(currentDistance <= 5)
           {
               currentState = STATES.fight;
               fight();
           } else
           {
              currentState = STATES.walking;
              walking();
           }

           // na.SetDestination(Character.transform.position);
        }
        else {

            currentState=STATES.idle;

        }

        if (lifex2 <=0)
        {
            currentState=STATES.death;
        }

    }



     void makeBehaviour()
    {
        switch (currentState)
        {
            case STATES.idle:
                idle();
                break;
            case STATES.walking:
                walking();
                break;
            case STATES.fight:
                fight();
                break;
            case STATES.death:
                death();
                break;

            default:
                break;
        }
    }

    void walking()
    {
        anim.SetBool("walking",true);
        anim.SetBool("idle",false);
        anim.SetBool("death",false);
     
        anim.SetBool("fighting",false);
        na.SetDestination(player.transform.position);
    }

    void idle()
    {
        anim.SetBool("idle",true);
        anim.SetBool("walking",false);
        anim.SetBool("death",false);
        anim.SetBool("fighting",false);

    }

     void fight()
    {
        anim.SetBool("idle",false);
        anim.SetBool("walking",false);
        anim.SetBool("death",false);
        anim.SetBool("fighting",true);
        
        na.SetDestination(player.transform.position);
    }

     void death()
    {
        anim.SetBool("idle",false);
        anim.SetBool("walking",false);
        anim.SetBool("death",true);
        anim.SetBool("fighting",false);
    }
    
    private void OnDrawGizmos()
    {
        Gizmos.color =  Color.blue;
        Gizmos.DrawWireSphere(transform.position, distanceFollow);
    }









}
