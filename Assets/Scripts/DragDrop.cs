using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IPointerUpHandler
{

    [SerializeField] public Canvas canvas;

    public Componente generado;
    public string tipoGenerado;
    Vector3 posOriginal; 

    private RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        posOriginal = new Vector3(rectTransform.position.x, rectTransform.position.y, rectTransform.position.z);
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("OnBeginDrag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("OnEndDrag");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("OnPointerDown");

    }

    public void OnPointerUp(PointerEventData eventData)
    {

        //Debug.Log("OnPointerUp");

        if (tipoGenerado == "Resistencia")
        {
            Instantiate(generado, new Vector2(rectTransform.position.x, rectTransform.position.y), transform.rotation);
            rectTransform.SetPositionAndRotation(posOriginal, transform.rotation);

        }
        else if (tipoGenerado == "Fuente")
        {
            Instantiate(generado, new Vector2(rectTransform.position.x, rectTransform.position.y), transform.rotation);
            rectTransform.SetPositionAndRotation(posOriginal, transform.rotation);
        }
    }
}
