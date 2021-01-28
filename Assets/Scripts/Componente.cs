﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Componente : MonoBehaviour
{
    public string nombre;
    public float amperaje;

    public Nodo inicial;
    public Nodo final;

    public bool conectadoInicial = false;
    public bool conectadoFinal = false;

    public bool rotado= false;

    [SerializeField] public Canvas canvas;

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

        if (!FindObjectOfType<BotonCambioModo>().modoSimulacion)
        {
            mostrarDatos();    
        }
    }

    public virtual void mostrarDatos()
    {
        //Camera camara = FindObjectOfType<Camera>();
    }

    public void OnMouseDrag()
    {
        if (!FindObjectOfType<BotonCambioModo>().modoSimulacion)
        {
            transform.position = (Vector2) Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    public void OnMouseOver()
    {
        Debug.Log("El mouse está sobre el componente");

        if (!FindObjectOfType<BotonCambioModo>().modoSimulacion)
        {
            if (Input.GetMouseButtonDown(1))
            {
                rotar();
            }
        }
    }
    

    public void rotar()
    {
        Debug.Log("Se ha rotado");
        transform.Rotate(0, 0, -90);

    }
}
