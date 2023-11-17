using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class FadeManager : MonoBehaviour
{
  public CanvasGroup FadeGroup;

  public void FadeOut()
  {
    FadeGroup.DOFade(0f, 0.8f); 
  }
  
  public void FadeIn()
  {
    FadeGroup.DOFade(1f, 0.8f); 
  }
}
