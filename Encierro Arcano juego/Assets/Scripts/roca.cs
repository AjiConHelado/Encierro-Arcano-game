using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class roca : MonoBehaviour
{
    // Reference to the GameObject to check for collision
    public GameObject targetGameObject;

    // Unity event to be triggered on collision with the target GameObject
    public UnityEvent onCollisionWithTargetEvent;
    public UnityEvent onExitTargetEvent;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("roca");
        if (other.gameObject == targetGameObject)
        {
            onCollisionWithTargetEvent.Invoke();
            Debug.Log("rocacorrecta.");
            // Realizar acciones cuando el jugador entra en el trigger
        }
    }


    // Se llama cuando un objeto sale del collider trigger

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("rocasalio");
        if (other.gameObject == targetGameObject)
        {
            onExitTargetEvent.Invoke();
            Debug.Log("rocacorrectasalio.");
            Debug.Log("El objeto deseado ha salido del trigger.");
            // Realizar acciones cuando el objeto deseado sale del trigger
        }
    }
}