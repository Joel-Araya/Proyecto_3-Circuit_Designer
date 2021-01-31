using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

///<summary>
// Permite mover objetos e instanciar los componentes del circuito
///</summary>
public class DragDrop : MonoBehaviour
{

    [SerializeField] private UI_InputWindow inputWindow;
    public bool simulación;
    public Componente generado;
    public string tipoGenerado;
    Vector3 posOriginal; 


    private void Awake()
    {
        posOriginal = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        
    }

    public void OnMouseDrag() 
    {
        if (!FindObjectOfType<BotonCambioModo>().modoSimulacion)
        {
            transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    public void OnMouseUp()
    {
        if (!FindObjectOfType<BotonCambioModo>().modoSimulacion)
        {
            //Debug.Log("OnPointerUp");

            if (tipoGenerado == "Resistencia")
            {
                Instantiate(generado, new Vector2(transform.position.x, transform.position.y), transform.rotation);
                transform.SetPositionAndRotation(posOriginal, transform.rotation);

                generado.nombrando = true;
            }

            else if (tipoGenerado == "Fuente")
            {
                Instantiate(generado, new Vector2(transform.position.x, transform.position.y), transform.rotation);
                transform.SetPositionAndRotation(posOriginal, transform.rotation);

                generado.nombrando = true;
            }            

            else if (tipoGenerado == "Nodo")
            {
                Instantiate(generado, new Vector2(transform.position.x, transform.position.y), transform.rotation);
                transform.SetPositionAndRotation(posOriginal, transform.rotation);
            }
        }
    }
}
