using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Devlog : MonoBehaviour
{
    public void Atras(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
}
