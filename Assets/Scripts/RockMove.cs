using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMove : MonoBehaviour
{
    private Rigidbody2D rb;
    public SpriteRenderer Outline;
    private Color targetColor = new Color(1f, 1f, 1f, 1f);

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void OnCollisionStay2D(Collision2D collision)
    {
        foreach (ContactPoint2D contact in collision.contacts)
        {
            if (collision.collider.CompareTag("Oso"))
            {
                 rb.bodyType = RigidbodyType2D.Dynamic;
            }
            else if (collision.collider.CompareTag("Player") || collision.collider.CompareTag("Conejo")|| collision.collider.CompareTag("Ave")){
                rb.bodyType = RigidbodyType2D.Static;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Oso"))
        {
            setColor(targetColor);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        setColor(Color.clear);
    }

    private void setColor(Color color)
    {
        if (Outline != null){
            Outline.color = color;
        }
    }
}
