using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resistencia : Componente
{
    public float resistencia;

    public Resistencia(string nombre, float resistencia)
    {
        this.nombre = nombre;
        this.resistencia = resistencia;
    }

    public override void setValue()
    {
        amperaje = (voltaje / resistencia)*1000;

        if (final != null)
        {
            final.amperaje = amperaje;
            final.voltaje = voltaje;
        }
        
        //resistencia = voltaje / (amperaje/1000);
    }

    public override void setValue(float resistencia)
    {
        this.resistencia = resistencia;
    }
    public override void mostrarDatos()
    {
        Debug.Log("Esta resistencia se llama " + nombre + " y su valor es " + resistencia);
    }

}
