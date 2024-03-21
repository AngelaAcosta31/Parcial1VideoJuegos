using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PropsAltar : MonoBehaviour
{
        public List<SpriteRenderer> runes;
        public List<GameObject> rockRunes;
        public float lerpSpeed;

        private Color curColor;
        private Color targetColor = new Color(1, 1, 1, 1);
        ActivarPilar activarPilar; 

        int numRocasActivadas;

        public bool Activo ;

        void Start()
        {
            if (rockRunes != null){
                numRocasActivadas = rockRunes.Count;
            }
            
        }

        void OnTriggerStay2D(Collider2D other)
        {
            if (Activo){
                    SceneManager.LoadScene("Creditos");
                }
            }

        private void Update()
        {
            int numRocasActivadasActuales = 0;

            foreach (var rock in rockRunes)
            {
                activarPilar = rock.GetComponent<ActivarPilar>();

                if (activarPilar != null && activarPilar.Activado)
                {
                    numRocasActivadasActuales++;
                }
            }
            
            curColor = Color.Lerp(curColor, targetColor, lerpSpeed * Time.deltaTime);

            for (int i = 0; i < numRocasActivadasActuales && i < runes.Count; i++)
            {   
                runes[i].color = curColor;
            }

             if (numRocasActivadasActuales == numRocasActivadas){
                    Activo = true;
            }
        }
    }


