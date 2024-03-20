using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBotones : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip soundMenuBtn;
    // Start is called before the first frame update
    public void SoundButton(){
        audioSource.clip = soundMenuBtn;
        audioSource.enabled = false;
        audioSource.enabled = true;
    }
}
