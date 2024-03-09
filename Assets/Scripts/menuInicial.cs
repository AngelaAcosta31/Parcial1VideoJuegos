using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuInicial : MonoBehaviour
{
   public void Jugar(){
   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }

   public void Instrucciones(){
   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
   }
   public void Devlog(){
   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
   }

   public void Creditos(){
   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
   }

   public void Salir(){
   Debug.Log("Salir....");
   Application.Quit();
   }
}
