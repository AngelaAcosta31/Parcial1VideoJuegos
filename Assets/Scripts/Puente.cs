using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puente : MonoBehaviour
{
    private PolygonCollider2D collider;

    void Start()
    {
        collider = GetComponent<PolygonCollider2D>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ave"))
        {
            collider.enabled = false;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {

        collider.enabled = true;

    }

    void Update()
    {

    }
}
