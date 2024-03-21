using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Cainos.PixelArtTopDown_Basic
{

    public class PropsAltar : MonoBehaviour
    {
        public List<SpriteRenderer> runes;
        public List<GameObject> rockRunes;
        public float lerpSpeed;

        private Color curColor;
        private Color targetColor;
        ActivarPilar activarPilar; 

        private void OnTriggerEnter2D(Collider2D other)
        {
            targetColor = new Color(1, 1, 1, 1);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            targetColor = new Color(1, 1, 1, 0);
        }

        private void Update()
        {
            int numRocasActivadas = 0;

            foreach (var rock in rockRunes)
            {
                activarPilar = rock.GetComponent<ActivarPilar>();

                if (activarPilar != null && activarPilar.Activado)
                {
                    numRocasActivadas++;
                    Debug.Log(numRocasActivadas);
                }
            }
            
            curColor = Color.Lerp(curColor, targetColor, lerpSpeed * Time.deltaTime);

            for (int i = 0; i < numRocasActivadas && i < runes.Count; i++)
            {
                runes[i].color = curColor;
            }
        }
    }
}
