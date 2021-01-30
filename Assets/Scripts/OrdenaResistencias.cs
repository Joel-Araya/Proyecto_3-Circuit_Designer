using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrdenaResistencias : MonoBehaviour
{
    private bool listaObtenida=false;
    Resistencia[] resistencias;
    List<string> nombres;

    void Update()
    {
        if (FindObjectOfType<BotonCambioModo>().modoSimulacion)
        {
            if (listaObtenida==false)
            {
                resistencias = FindObjectsOfType<Resistencia>();
                obtenerNombres();

                mostrarNombres();
            }
            listaObtenida = true;
        } 
        
        else
        {
            resistencias = null;
            listaObtenida = false;
        }      
    }

    public void obtenerNombres()
    {
        foreach(Resistencia i in resistencias)
        {
            nombres.Add(i.nombre);
        }
    }

    public void mostrarNombres()
    {
        int n = 0;
        foreach(Resistencia i in resistencias)
        {
            Debug.Log("El nombre de la resistencia " + n + " es " + i.nombre + "y su valor es " + i.resistencia);
            n++;
        }
    }

    public void QuickSort(Resistencia[] resistencias)
    {

    }

    public void InsertionSort(Resistencia[] resistencias)
    {

    }
}
