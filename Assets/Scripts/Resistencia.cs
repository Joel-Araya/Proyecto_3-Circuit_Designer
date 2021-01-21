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

}
