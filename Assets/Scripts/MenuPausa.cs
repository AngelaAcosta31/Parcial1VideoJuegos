using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    private void Awake()
    {
        DesactivarMenuPausa();
    }

    public void ActivarMenuPausa()
    {
        gameObject.SetActive(true);
    }

    public void DesactivarMenuPausa()
    {
        gameObject.SetActive(false);
    }
}
