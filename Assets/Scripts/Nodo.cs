using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodo : MonoBehaviour
{

    public KeyCode ant, sig;

    public float voltaje_V;
    public float amperaje_I = Random.Range(0,1000);
    public List<Componente> conexionesAnt = new List<Componente>();
    public List<Componente> conexionesSig = new List<Componente>();
    
    public Nodo() { }

    public void Update()
    {
        if (Input.GetKeyDown(ant))
        {
            foreach(Componente i in conexionesAnt)
            {
                print(i.nombre);

            }
        }
        if (Input.GetKeyDown(sig))
        {
            foreach(Componente i in conexionesSig)
            {
                print(i.nombre);

            }
        }
    }

}
