using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuInicial : MonoBehaviour
{
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
}
