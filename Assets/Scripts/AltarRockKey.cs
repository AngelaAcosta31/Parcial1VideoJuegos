using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarRockKey : MonoBehaviour
{
    public List<SpriteRenderer> runes;

    public GameObject RockRune;
    public List<GameObject> Pilar;

    public float lerpSpeed;

    private Color curColor;
    private Color targetColor;
    public bool Activo;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("KeyRock")){
            targetColor = new Color(1, 1, 1, 1);
            Activo = true;
            RockRune.GetComponent<CircleCollider2D>().enabled = true;
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("KeyRock")){
            targetColor = new Color(1, 1, 1, 0);
            Activo = false;
        }
    }

    private void Update()
    {

        
        curColor = Color.Lerp(curColor, targetColor, lerpSpeed * Time.deltaTime);

        foreach (var r in runes)
        {
            r.color = curColor;
        }

        if (Pilar != null){
            foreach (var p in Pilar)
            {
                if (Activo){
                    p.transform.Find("Glow").gameObject.SetActive(true);
                }
                else{
                    p.transform.Find("Glow").gameObject.SetActive(false);
                }
            }
        }


    }
}
