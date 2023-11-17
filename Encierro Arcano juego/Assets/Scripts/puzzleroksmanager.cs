using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzleroksmanager : MonoBehaviour
{
    int count = 0;
    public List<GameObject> activate = new List<GameObject>();


    public void solvedCounter()
    {
        count++;
        Debug.Log("rocapunto" + count);
        if (count == 4)
        {
            abrirPuerta();
        }
    }
    public void unsolvedCounter()
    {
        count--;
        Debug.Log("rocanopunto" + count);

    }


    public void abrirPuerta()
    {
        // Loop through each GameObject in the list
        foreach (GameObject obj in activate)
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
