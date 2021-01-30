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
        resistencia = voltaje / (amperaje/1000);
    }

    public override void mostrarDatos()
    {
        Debug.Log("Esta resistencia se llama " + nombre + " y su valor es " + resistencia);
    }

}
