using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rokspuzzle : MonoBehaviour
{
    public string targetTag = "YourTargetTag"; // Set this to the tag you want to verify
    [SerializeField] GameObject puerta;
    [SerializeField] GameObject roks;
    private int collidersInsideTrigger = 0;
    void start()
    {
        Debug.Log(collidersInsideTrigger);
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(targetTag)) // Check if the collider has the specified tag
        {
            collidersInsideTrigger--;

            if (collidersInsideTrigger == 0)
            {
                OnAllCollidersExited();
            }
        }
    }

    private void OnAllCollidersExited()
    {
        Debug.Log("All colliders with tag " + targetTag + " have exited the trigger!");
        opendoor();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            collidersInsideTrigger++;
        }
    }
public void opendoor()
    {
        puerta.SetActive(false);
        roks.SetActive(false);
    }
}

