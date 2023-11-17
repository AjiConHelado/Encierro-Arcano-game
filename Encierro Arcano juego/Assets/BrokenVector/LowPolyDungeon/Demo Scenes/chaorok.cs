using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaorok : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the GameObject that touched the collider has a specific tag
        if (other.CompareTag("puzzlerocks"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
