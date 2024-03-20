using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public List<GameObject> rockRunes;
    ActivarPilar activarPilar; 
    int numRocasActivadas;

    
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
