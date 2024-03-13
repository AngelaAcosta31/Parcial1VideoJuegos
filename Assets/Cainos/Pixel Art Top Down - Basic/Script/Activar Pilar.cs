using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarPilar : MonoBehaviour
{
    public SpriteRenderer Outline;
    public SpriteRenderer Rune;
    private Color curColor;
    private Color targetColor;

    private void OnTriggerEnter2D(Collider2D other)
    {
        targetColor = new Color(255, 255, 255, 255);
        Rune.enabled = true;
        setColor(targetColor);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        targetColor = new Color(0, 0, 0, 0);
        setColor(targetColor);
        Rune.enabled = false;
    }

    private void setColor(Color color)
    {
        curColor = Color.Lerp(curColor, targetColor, 0.00001f * Time.deltaTime);
        Outline.color = targetColor;
    }
    
}
