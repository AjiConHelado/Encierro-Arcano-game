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

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("roca");
        // Check if the colliding GameObject is the targetGameObject
        if (collision.gameObject == targetGameObject)
        {
            // Trigger the Unity event
            onCollisionWithTargetEvent.Invoke();
            Debug.Log("rocacorrecta");
        }
    }
}