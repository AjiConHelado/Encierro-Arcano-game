using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tpscroll : MonoBehaviour
{
    public List<GameObject> activate = new List<GameObject>();
    public List<GameObject> deactivate = new List<GameObject>();

    private void OnCollisionEnter(Collision collision)
    {
        // Check the tag of the collided object
       
      
            DeactivateAllGameObjects();
            ActivateAllGameObjects();

        
    }
    public void ActivateAllGameObjects()
    {
        // Loop through each GameObject in the list
        foreach (GameObject obj in activate)
        {
            // Check if the GameObject is not null before deactivating
            if (obj != null)
            {
                // Deactivate the GameObject
                obj.SetActive(true);
            }
        }
    }
    public void DeactivateAllGameObjects()
    {
        // Loop through each GameObject in the list
        foreach (GameObject obj in deactivate)
        {
            // Check if the GameObject is not null before deactivating
            if (obj != null)
            {
                // Deactivate the GameObject
                obj.SetActive(false);
            }
        }
    }

}
