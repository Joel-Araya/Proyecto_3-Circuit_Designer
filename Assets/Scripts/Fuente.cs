using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
// Contiene al componente fuente del circuito
///</summary>
public class Fuente : Componente
{

    public Fuente(string nombre, float fuenteVoltaje)
    {
        this.nombre = nombre;
        this.voltaje = fuenteVoltaje;
    }

    public override void mostrarDatos()
    {
        Debug.Log("Esta fuente se llama " + nombre + " y su valor es " + voltaje + " V");
    }

}
