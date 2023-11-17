using System.Collections;
using System.Collections.Generic;
using Tilia.Interactions.Interactables.Interactables;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public List<GameObject> objetosConMeshRender;
    public List<GameObject> AllObjects;
    public List<InteractableFacade> InteractableFecade;
    public Material materiaL;
    public GameObject Capsule;
    public GameObject CapsuleObject;

    public void CambiarMeshRenderers()
    {
        foreach (GameObject objeto in objetosConMeshRender)
        {
            objeto.tag = "Charged";
            MeshRenderer meshRenderer = objeto.GetComponent<MeshRenderer>();

            if (meshRenderer != null)
            {

                meshRenderer.material = materiaL;
            }
            else
            {
                Debug.LogWarning("El objeto " + objeto.name + " no tiene un MeshRenderer.");
            }
        }

        foreach (InteractableFacade interactableFacade in InteractableFecade)
        {
            interactableFacade.enabled = true;
        }
        
        foreach (GameObject objeto in AllObjects)
        {
            objeto.tag = "Charged";
            
        }
    }
    

    public void AddObject()
    {
        
        if (!objetosConMeshRender.Contains(Capsule))
        {
            objetosConMeshRender.Add(Capsule);
            
        }
        
        if (!AllObjects.Contains(CapsuleObject))
        {
            AllObjects.Add(CapsuleObject);
            
        }
     
    }

    public void RemoveObject()
    {
        if (objetosConMeshRender.Contains(Capsule))
        {
            objetosConMeshRender.Remove(Capsule);
        }
        if (AllObjects.Contains(CapsuleObject))
        {
            AllObjects.Remove(CapsuleObject);
            
        }
    }
    
    
}
    

