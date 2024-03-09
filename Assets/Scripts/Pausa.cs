using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pausa : MonoBehaviour
{
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;
    private bool juegoPausado = false;

    private void update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(juegoPausado){
                Reanudar();
            }else{
                Pausar();
            }
        }
    }
    public void Pausar(){
        juegoPausado = true;
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }

    public void Reanudar(){
        juegoPausado = false;
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }

    public void Reiniciar(){
        juegoPausado = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void Salir(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    Application.Quit();
    }

    public void Sonido(){

    }


}
