using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodo : Componente
{
    public List<Componente> conexionesAnt = new List<Componente>();
    public List<Componente> conexionesSig = new List<Componente>();
    
    public Nodo() { }

    public void Start()
    {
        voltaje = Random.Range(0, 10);
        amperaje = Random.Range(0, 1000);
    }


    public override void Update()
    {
        if (conexionesSig.Count > 0)
        {
            foreach(Componente componente in conexionesSig)
            {
                componente.amperaje = amperaje;
                componente.voltaje = voltaje;

                if (componente.tipo == "Resistencia")
                {
                    componente.setValue();
                }
            }
        }
    }

    public override void rotar()
    {
        if (conexionesSig.Count==0 && conexionesAnt.Count==0)
        {
            transform.Rotate(0, 0, -90);
        }

    }

    public override void mostrarDatos()
    {
        Debug.Log("En este nodo el voltaje es " + voltaje + " V y el amperaje es " + amperaje + " mA");
    }

}
