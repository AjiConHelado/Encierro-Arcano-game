using System;
using System.Collections;
using UnityEngine;
using DG.Tweening; 
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
    
public class EventManager : MonoBehaviour
{
    public PlayableDirector MainStart; 
    public PlayableDirector MachineCinematic; 
    public PlayableDirector EndCinematic;

    
        private void Update()
        {
          
            if (Input.GetKeyDown(KeyCode.R))
            {
                ReiniciarEscena();
            }

         
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SalirDelJuego();
            }
        }

        public void ReiniciarEscena()
        {
    
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        }

        public void SalirDelJuego()
        {
           
            Application.Quit();
        }
    

    public void StartGame()
    {
        MainStart.Play();
    }

    public void StartCinematic()
    {
        MachineCinematic.Play();
    }

    public void EndCinematicFUCTION()
    {
        EndCinematic.Play();
        StartCoroutine(END()); 
    }

    IEnumerator END()
    {
        yield return new WaitForSeconds(2f);

    }

}
