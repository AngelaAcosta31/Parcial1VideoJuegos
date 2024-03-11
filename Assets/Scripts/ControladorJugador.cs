using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    [SerializeField] private GameObject humano;
    [SerializeField] private GameObject conejo;
    [SerializeField] private Camera mainCamera;
    
    [SerializeField] private float transitionSpeed = .005f; 

    private GameObject formaInstanciada;

    void Start()
    {
        formaInstanciada = Instantiate(humano, transform.position, transform.rotation, transform);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            TransformarConejo();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            TransformarHumano();
        }
    }

    void TransformarConejo()
    {
        transform.position = formaInstanciada.transform.position;
        gameObject.layer = formaInstanciada.layer;
        int layer = formaInstanciada.GetComponent<SpriteRenderer>().sortingLayerID;
        Destroy(formaInstanciada);
        formaInstanciada = Instantiate(conejo, transform.position, transform.rotation, transform);
        formaInstanciada.GetComponent<SpriteRenderer>().sortingLayerID = layer;
        formaInstanciada.layer =  gameObject.layer;
        StartCoroutine(TransicionZoom(5f));
    }

    void TransformarHumano()
    {
        transform.position = formaInstanciada.transform.position;
        gameObject.layer = formaInstanciada.layer;
        int sortinglayer = formaInstanciada.GetComponent<SpriteRenderer>().sortingLayerID;
        Destroy(formaInstanciada);
        formaInstanciada = Instantiate(humano, transform.position, transform.rotation, transform);
        formaInstanciada.GetComponent<SpriteRenderer>().sortingLayerID = sortinglayer;
        formaInstanciada.layer =  gameObject.layer;
        StartCoroutine(TransicionZoom(5f));
    }

    IEnumerator TransicionZoom(float zoomCamara)
{
    float initialSize = mainCamera.orthographicSize;
    float elapsedTime = 0f;

    while (elapsedTime < transitionSpeed)
    {
        float t = elapsedTime / transitionSpeed;
        float normalizedT = Mathf.Sin(t * Mathf.PI * 0.5f); 

        mainCamera.orthographicSize = Mathf.Lerp(initialSize, zoomCamara, normalizedT);
        elapsedTime += Time.deltaTime;
        yield return null;
    }

    mainCamera.orthographicSize = zoomCamara;
}
}
