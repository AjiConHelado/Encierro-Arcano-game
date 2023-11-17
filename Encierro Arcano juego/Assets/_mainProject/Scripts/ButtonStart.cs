using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStart : MonoBehaviour
{

public EventManager EventManager;


private bool canStart = false; 


private void OnTriggerEnter(Collider other)
    {
       
        

        GameObject target = other.gameObject;
        if (target.CompareTag("Hand") && !canStart)
        {
            canStart = true; 
            EventManager.StartCinematic();
            
        }
            
          
    }
    
}
