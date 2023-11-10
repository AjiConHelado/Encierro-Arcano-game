using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastinitial : MonoBehaviour
{
    public float rayDistance = 10f;
    public Color rayColor = Color.red;

    void Update()
    {
        // Cast a ray forward from the object
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        // Visualize the ray in the scene view
        Debug.DrawRay(ray.origin, ray.direction * rayDistance, rayColor);
        
        // Check if the ray hits something
        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            // Do something when the ray hits an object
            Debug.Log("Ray hit: " + hit.collider.gameObject.name);

            // Call another script to cast a ray from the hit object
            HitObjectScript hitObjectScript = hit.collider.gameObject.GetComponent<HitObjectScript>();
            if (hitObjectScript != null)
            {
                hitObjectScript.CastRayFromHitObject();
            }
        }
    }
}
