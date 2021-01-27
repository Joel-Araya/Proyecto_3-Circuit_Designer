using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente : MonoBehaviour
{
    public string nombre;
    public float amperaje;

    public Nodo inicial;
    public Nodo final;

    public bool conectadoInicial = false;
    public bool conectadoFinal = false;

    public bool rotado= false;

    public Componente(string nombre)
    {
        this.nombre = nombre;
    }    
    
    public Componente() {}


    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void Update()
    {
        if (conectadoInicial == false && inicial != null)
        {
            inicial.conexionesSig.Add(this);
            conectadoInicial = true;
        }

        if (conectadoFinal == false && final != null)
        {
            final.conexionesAnt.Add(this);
            conectadoFinal = true;
        }
    }

    public void OnMouseDrag()
    {
        transform.position = Input.mousePosition;
    }

    public void OnMouseOver()
    {
        Debug.Log("El mouse está sobre el componente");
        if (Input.GetMouseButtonDown(1)) 
        {
            rotar();
        }        
    }

    public void rotar()
    {

        if (!rotado)
        {
            Debug.Log("Se ha rotado");
            transform.Rotate(0, 0, -90);
            rotado = true;
        }

        else
        {
            transform.Rotate(0, 0, 90);
            rotado = false;
        }

    }
}
