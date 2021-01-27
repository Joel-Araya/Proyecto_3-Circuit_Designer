using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuente : Componente
{
    public float voltaje;

    public Fuente(string nombre, float fuenteVoltaje)
    {
        this.nombre = nombre;
        this.voltaje = fuenteVoltaje;
    }
}
