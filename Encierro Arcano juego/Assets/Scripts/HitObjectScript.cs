using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Events;
public class HitObjectScript : MonoBehaviour
{
    public float secondRayDistance = 5f;
    public Color secondRayColor = Color.blue;
    private LineRenderer lineRenderer;
    public UnityEvent activatescroll;
    public UnityEvent opengate;

    void Start()
    {
        // Create a LineRenderer component and set its properties
        lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.startWidth = 0.05f;
        lineRenderer.endWidth = 0.05f;
        lineRenderer.material = new Material(Shader.Find("Standard"));
        lineRenderer.startColor = secondRayColor;
        lineRenderer.endColor = secondRayColor;
    }
    public void CastRayFromHitObject()
    {
        // Cast a second ray from the hit object
        Ray secondRay = new Ray(transform.position, transform.forward);
        RaycastHit secondHit;
        lineRenderer.SetPosition(0, secondRay.origin);
        // Visualize the second ray in the scene view
        Debug.DrawRay(secondRay.origin, secondRay.direction * secondRayDistance, secondRayColor);

        // Check if the second ray hits something
        if (Physics.Raycast(secondRay, out secondHit, secondRayDistance))
        {
            lineRenderer.SetPosition(1, secondHit.point);
            // Do something when the second ray hits an object
            Debug.Log("Second ray hit: " + secondHit.collider.gameObject.name);
            if (secondHit.collider.CompareTag("puzzlescroll"))
            {  
                activatescroll.Invoke();
            }
            if (secondHit.collider.CompareTag("puzzlescroll1"))
            {
                opengate.Invoke();
            }

        }
        else
        {
            lineRenderer.SetPosition(1, secondRay.origin + secondRay.direction * secondRayDistance);
        }
    }
}