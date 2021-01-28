using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonCambioModo : MonoBehaviour
{
    public bool modoSimulacion = false;

    private void OnMouseDown()
    {
        if (!modoSimulacion)
        {
            modoSimulacion = true;
            Debug.Log("LA simulación está " + modoSimulacion);
        } 
        
        else
        {
            modoSimulacion = false;
            Debug.Log("La simulación está " + modoSimulacion);
        }
    }
}
