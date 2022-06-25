using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    public ScoreManager manager;


    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log("Collide");
        if (other.gameObject.CompareTag("Ball"))
        {
            if (gameObject.tag == "P1")
            {  
                
                manager.addP1Score(1);
            }
            else if (gameObject.tag == "P2")
            {
                
                manager.addP2Score(1);
            }
            else if (gameObject.tag == "P3")
            {
               
                manager.addP3Score(1);
            }
            else if (gameObject.tag == "P4")
            {
                
                manager.addP4Score(1);
            }
            
            
        }
    }
}
