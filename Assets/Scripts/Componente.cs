using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Componente : MonoBehaviour
{
    public string nombre;
    public float amperaje;
    public float voltaje;
    public bool nombrando = false;

    public string tipo;
    public Nodo inicial;
    public Nodo final;

    public bool datosObtenidos=false;
    public bool conectadoInicial = false;
    public bool conectadoFinal = false;

    public bool rotado= false;

    public bool conectando=false;
    public bool esperando = false;
    public Componente(string nombre)
    {
        this.nombre = nombre;
    }    
    
    public Componente() {}


    // Start is called before the first frame update
    void Start()
    {
    
    }

    public void FixedUpdate()
    {
        if (conectando)
        {
            Componente[] componentes = FindObjectsOfType<Componente>();

            foreach (Componente componente in componentes)
            {
                if (componente.esperando)
                {
                    //Debug.Log("El tipo del primer componente es " + componente.tipo);
                    if (componente.tipo == "Nodo")
                    {
                        componente.esperando = false;
                        componente.conectando = false;
                        conectando = false;
                        esperando = false;
                        inicial = (Nodo)componente;
                        break;
                    }

                    else if (componente.tipo == "Fuente" || componente.tipo == "Resistencia")
                    {
                        componente.esperando = false;
                        componente.conectando = false;
                        conectando = false;
                        esperando = false;
                        componente.final = (Nodo)this;
                        break;
                    }
                }
            }
        }
    }

    public virtual void Update()
    {

        if (conectadoInicial == false && inicial != null)
        {
            inicial.conexionesSig.Add(this);
            conectadoInicial = true;
        }

        if (conectadoFinal == false && final != null)
        {
            final.conexionesAnt.Add(this);
            conectadoFinal = true;
            
        }

        if (FindObjectOfType<BotonCambioModo>().modoSimulacion)
        {
            mostrarDatos();
        }
        

    }

    public virtual void setValue() {  }

    public virtual void setValue(float resistencia){  }

    public virtual void mostrarDatos()
    {
        //Camera camara = FindObjectOfType<Camera>();
    }

    public void OnMouseDrag()
    {
        if (!FindObjectOfType<BotonCambioModo>().modoSimulacion)
        {
            transform.position = (Vector2) Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    public void OnMouseOver()
    {
        //Debug.Log("El mouse está sobre el componente");

        if (!FindObjectOfType<BotonCambioModo>().modoSimulacion)
        {
            if (Input.GetMouseButtonDown(1))
            {
                rotar();
            }
        }
        else
        {
            if (tipo == "Nodo")
            {
                mostrarDatos();
            }
        }
    }

    public virtual void rotar()
    {
        //Debug.Log("Se ha rotado");
        if (inicial==null && final==null)
        {
            transform.Rotate(0, 0, -90);
        }

    }
}
