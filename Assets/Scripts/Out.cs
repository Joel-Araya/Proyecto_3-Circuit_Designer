using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Out : MonoBehaviour
{
    public bool isOnObj = false;
    //private LineDrawer lineDrawer; 
    public LineDrawer bruh;
    private bool lnCreated = false;

    private In[] inScript;

    /*void Awake(){
        //inScript = GameObject.FindObjectsOfType<In> ();
    }*/
    ///<summary>
    // Detecta cuando es presionado el click izquierdo, para crear la linea en la posicion del 
    // mouse, ademas se encarga de detectar con quien se conecta el cable
    ///</summary>

    void OnMouseDown(){
        inScript = GameObject.FindObjectsOfType<In> ();
        Instantiate(bruh,transform.position, transform.rotation);
        lnCreated = true;
        //lineDrawer = GameObject.FindObjectOfType<LineDrawer> ();
        foreach(In i in inScript){
                i.UpdatelnCreated(lnCreated);
            }
        GetComponentInParent<Componente>().esperando=true;


        if (GetComponentInParent<Componente>().tipo == "nodo")
        {
            bruh.nodoP = GetComponentInParent<Nodo>();
        }
        else
        {
            bruh.nodoP = GetComponentInParent<Componente>().final;
        }


    }

    /*void OnMouseOver()
    {            
        //Debug.Log("Mouse is over OUT");
    }

    void OnMouseExit()
    {
        //Debug.Log("Mouse is NOT over OUT");
    }*/
}
