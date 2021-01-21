using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente : MonoBehaviour
{
    public string nombre;

    public Nodo inicial;
    public Nodo final;


    public Componente(string nombre)
    {
        this.nombre = nombre;
    }    
    
    public Componente() {}


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
