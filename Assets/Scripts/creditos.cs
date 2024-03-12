using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class creditos : MonoBehaviour
{

    void Start()
    {
        Invoke("Atras",12);
    }
    void Update(){
        if(Input.GetKey(KeyCode.Escape)){
            SceneManager.LoadScene("menuInicial");
        }
    }

    public void Atras(){
        SceneManager.LoadScene("menuInicial");
    }
}
