using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class Pausa : MonoBehaviour
{
    public AudioSource clip;
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;
    
    private bool juegoPausado = false;
    

    private void update(){
        if(!juegoPausado && Input.GetKeyDown(KeyCode.Pause)){
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
        DontDestroyOnLoad(gameObject);
        
    }

    public void Reanudar(){
        juegoPausado = false;
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
        DontDestroyOnLoad(gameObject);

    }

    public void Reiniciar(){
        juegoPausado = false;
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("Nivel");
    }


    public void Salir(){
        botonPausa.SetActive(false);
        menuPausa.SetActive(false);
        SceneManager.LoadScene("menuInicial");
    }

    public void PlaySoundBtn(){
        clip.Play();
    }

    public void MuteAudio(bool mute){
        if(mute){
            AudioListener.volume = 0;
        }else{
            AudioListener.volume = 1;
        }
    }


}
