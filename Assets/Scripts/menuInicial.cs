using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuInicial : MonoBehaviour
{
   public void Jugar(){
   SceneManager.LoadScene("Nivel");
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
   Debug.Log("Salir....");
   Application.Quit();
   }
}
