using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    [SerializeField] private GameObject humano;
    [SerializeField] private GameObject conejo;
    [SerializeField] private GameObject ave;
    [SerializeField] private GameObject oso;
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
            Transformarcion(conejo, 2.5f);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Transformarcion(humano, 5f);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            Transformarcion(ave, 2.5f);
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Transformarcion(oso, 6f);
        }
    }

void Transformarcion(GameObject forma, float zoomCamara)
{
    transform.position = formaInstanciada.transform.position;
    gameObject.layer = formaInstanciada.layer;
    int layer = formaInstanciada.GetComponent<SpriteRenderer>().sortingLayerID;
    Destroy(formaInstanciada);
    formaInstanciada = Instantiate(forma, transform);


    float nuevoAncho = forma.GetComponent<BoxCollider2D>().size.x;
    float nuevoAlto = forma.GetComponent<BoxCollider2D>().size.y;


    formaInstanciada.GetComponent<BoxCollider2D>().size = new Vector2(nuevoAncho, nuevoAlto);



    formaInstanciada.GetComponent<SpriteRenderer>().sortingLayerID = layer;
    formaInstanciada.layer = gameObject.layer;
    StartCoroutine(TransicionZoom(zoomCamara));

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
