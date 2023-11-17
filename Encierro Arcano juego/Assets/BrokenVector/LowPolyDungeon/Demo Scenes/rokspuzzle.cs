using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rokspuzzle : MonoBehaviour
{
    public string targetTag = "puzzlerocks"; // Set this to the tag you want to verify
    [SerializeField] GameObject puerta;



    public List<GameObject> gameObjectsList;

    void Update()
    {
        bool allInactive = true;

        foreach (GameObject obj in gameObjectsList)
        {
            if (obj.activeSelf)
            {
                allInactive = false;
                break;
            }
        }

        if (allInactive)
        {
            // Call your method or perform actions when all GameObjects are inactive
            opendoor();
        }
    }

   
public void opendoor()
    {
        puerta.SetActive(false);
       
    }
}
