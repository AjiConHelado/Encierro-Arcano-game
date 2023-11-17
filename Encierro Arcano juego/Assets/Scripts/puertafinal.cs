using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puertafinal : MonoBehaviour
{ 

    [SerializeField] private GameObject puerta;
    [SerializeField] private GameObject chispas;

    public string targetTag = "Pocion";

    private void OnTriggerEnter(Collider other)
    {

        // Check if the GameObject that touched the collider has a specific tag
        if (other.CompareTag("Pocion"))
        {
            other.gameObject.SetActive(false);
            puerta.SetActive(false);
            chispas.SetActive(false);
        }
    }
}
