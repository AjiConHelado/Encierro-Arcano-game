using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class HitObjectScript : MonoBehaviour
{
    public float secondRayDistance = 5f;
    public Color secondRayColor = Color.blue;

    public void CastRayFromHitObject()
    {
        // Cast a second ray from the hit object
        Ray secondRay = new Ray(transform.position, transform.forward);
        RaycastHit secondHit;

        // Visualize the second ray in the scene view
        Debug.DrawRay(secondRay.origin, secondRay.direction * secondRayDistance, secondRayColor);

        // Check if the second ray hits something
        if (Physics.Raycast(secondRay, out secondHit, secondRayDistance))
        {
            // Do something when the second ray hits an object
            Debug.Log("Second ray hit: " + secondHit.collider.gameObject.name);
        }
    }
}