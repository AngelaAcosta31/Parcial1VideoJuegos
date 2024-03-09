using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class creditos : MonoBehaviour
{
    public void Atras(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }
}
