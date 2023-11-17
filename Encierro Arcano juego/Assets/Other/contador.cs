using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class contador : MonoBehaviour
{
    public int coniter = 0;
    public TextMeshProUGUI texto;

    private void Update()
    {
        texto.text =   "Puntos: " + coniter.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bola"))
        {
            coniter += 2;
        }
    }
}
