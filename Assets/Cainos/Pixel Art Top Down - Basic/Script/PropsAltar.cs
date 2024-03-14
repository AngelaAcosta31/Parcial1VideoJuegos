using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//when something get into the alta, make the runes glow
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
            Debug.Log("Entra");
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            targetColor = new Color(1, 1, 1, 0);
            Debug.Log("Sale");
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
