using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UI_Info : MonoBehaviour
{
    public CanvasGroup UI_Infographic;

    public InterfaceAnimManager GlobalInterface;

    public InterfaceAnimManager CrystalInterface;
    public InterfaceAnimManager TapaInterface;
    public InterfaceAnimManager ResistenciaInterface;
    public InterfaceAnimManager CobreInterface;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            UI_Infographic.DOFade(1f, 0f); 
            GLOBALAppear();

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            GlobalInterface.startDisappear();
            CrystalInterface.startDisappear();
            TapaInterface.startDisappear();
            ResistenciaInterface.startDisappear();
            CobreInterface.startDisappear();

        }
    }

    public void Crystal()
    {
        StartCoroutine(CorrutineHide(CrystalInterface));
        ResistenciaInterface.startDisappear();
        GlobalInterface.startDisappear();
        TapaInterface.startDisappear();
        CobreInterface.startDisappear();
    }

    public void Tapa()
    {
        StartCoroutine(CorrutineHide(TapaInterface));
        ResistenciaInterface.startDisappear();
        GlobalInterface.startDisappear();
        CrystalInterface.startDisappear();
        CobreInterface.startDisappear();

    }

    public void GLOBALAppear()
    {
        GlobalInterface.startAppear();
        CrystalInterface.startDisappear();
        TapaInterface.startDisappear();
        ResistenciaInterface.startDisappear();
        CobreInterface.startDisappear();

    }

    public void Resistencia()
    {
        StartCoroutine(CorrutineHide(ResistenciaInterface));
        GlobalInterface.startDisappear();
        CrystalInterface.startDisappear();
        TapaInterface.startDisappear();
        CobreInterface.startDisappear();
    }

    public void Cobre()
    {
        StartCoroutine(CorrutineHide(CobreInterface));
        ResistenciaInterface.startDisappear();
        GlobalInterface.startDisappear();
        CrystalInterface.startDisappear();
        TapaInterface.startDisappear();
    }

    IEnumerator CorrutineHide(InterfaceAnimManager InterfaceAnimManagerA)
    {
        yield return new WaitForSeconds(1.5f);
        InterfaceAnimManagerA.startAppear();
    }



}