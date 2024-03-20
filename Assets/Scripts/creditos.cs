using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class creditos : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource clip;

    void Start()
    {
        Invoke("Atras",17);
        // Comienza la reproducción de la música cuando la escena inicia.
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
    void Update(){
        if(Input.GetKey(KeyCode.Escape)){
            SceneManager.LoadScene("menuInicial");
        }
    }

    public void Atras(){
        SceneManager.LoadScene("menuInicial");
    }

    IEnumerator FadeOutAudio()
    {
       // Espera hasta que el audio termine de reproducirse
        while (audioSource.isPlaying)
        {
            yield return null;
        }

        // Cambia a la escena "menuInicial"
        SceneManager.LoadScene("menuInicial");
    }
    public void PlaySoundBtn(){
        clip.Play();
    }

}
