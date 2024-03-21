using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OpenDoor : MonoBehaviour
{
    public List<GameObject> rockRunes;
    ActivarPilar activarPilar; 
    int numRocasActivadas;
    public AudioSource clip;

    
    void Start()
    {
        if (rockRunes != null){
            numRocasActivadas = rockRunes.Count;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        int numRocasActivadasActuales = 0;
        foreach (var rock in rockRunes)
            {
                activarPilar = rock.GetComponent<ActivarPilar>();
                clip.Play();

                if (activarPilar != null && activarPilar.Activado)
                {
                    numRocasActivadasActuales ++;
                }
            }

            if (numRocasActivadasActuales == numRocasActivadas){
                transform.Find("PF Props Wooden Gate").gameObject.SetActive(false);
                transform.Find("PF Props Wooden Gate Opened").gameObject.SetActive(true);
            }
    }
}
