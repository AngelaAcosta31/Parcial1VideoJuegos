using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class menuInicial : MonoBehaviour
{
   public AudioSource clip;
   public void Jugar(){
   SceneManager.LoadScene("Nivel");
   Debug.Log("Escena activa: " + SceneManager.GetActiveScene().name);
   }

   public void Instrucciones(){
   SceneManager.LoadScene("Instrucciones");
   }
   public void Devlog(){
   SceneManager.LoadScene("Devlog");
   }

   public void Creditos(){
   SceneManager.LoadScene("Creditos");
   }

   public void Salir(){
   Application.Quit();
   }

   public void PlaySoundBtn(){
      clip.Play();
   }

}
