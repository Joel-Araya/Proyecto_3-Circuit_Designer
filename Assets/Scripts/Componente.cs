﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente : MonoBehaviour
{
    public string nombre;

    public Nodo inicial;
    public Nodo final;

    public bool conectadoInicial = false;
    public bool conectadoFinal = false;


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
}
