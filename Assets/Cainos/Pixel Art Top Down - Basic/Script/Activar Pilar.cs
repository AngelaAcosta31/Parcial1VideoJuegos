using UnityEngine;
using UnityEngine.Audio;

public class ActivarPilar : MonoBehaviour
{
    public SpriteRenderer Outline;
    public SpriteRenderer Rune;
    private Color targetColor = new Color(1f, 1f, 1f, 1f);
    private Color activateColor = new Color(94f / 255f, 237f / 255f, 255f / 255f, 0.8f);
    private bool isPlayerInside = false;
    public bool Activado = false;
    public AudioSource clip;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !Activado)
        {
            isPlayerInside = true;
            setColor(targetColor);
            clip.Play();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (!Activado)
        {
            isPlayerInside = false;
            setColor(Color.clear);
            Rune.enabled = false;
        }
    }

    private void Update()
    {
        if (isPlayerInside && Input.GetKeyDown(KeyCode.Q))
        {
            Rune.enabled = true;
            Activado = true;
            setColor(activateColor);
        }
    }

    private void setColor(Color color)
    {
        Outline.color = color;
    }
}
