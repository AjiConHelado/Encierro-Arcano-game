using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cauldronpuzzle : MonoBehaviour
{
    public string targetTag = "YourTargetTag"; // Set this to the tag you want to verify
    [SerializeField] GameObject pocion;
    
    private int collidersInsideTrigger = 0;
    void start()
    {
        Debug.Log(collidersInsideTrigger);
    }
   

    private void OnAllCollidersExited()
    {
        Debug.Log("All colliders with tag " + targetTag + " have exited the trigger!");
        spawnpotion();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            collidersInsideTrigger++;
            

            if (collidersInsideTrigger == 5)
            {
                OnAllCollidersExited();
            }
        }
    }
    public void spawnpotion()
    {
        pocion.SetActive(true);
    }
}
