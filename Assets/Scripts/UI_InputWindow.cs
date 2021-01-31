using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_InputWindow : MonoBehaviour
{
    public Componente comp;
    public bool esconder = true;

    private void Awake()
    {
        Hide();
    }

    public void Show ()
    {
        GetComponentInChildren<Canvas>().enabled = true;
        esconder = false;
       
        //Debug.Log("showing");


    }    
    
    public void Hide ()
    {
        GetComponentInChildren<Canvas>().enabled = false;
        //Debug.Log("hiding");

    }

    public void setHide()
    {
        esconder = true;

        if (comp != null)
        {
            comp.nombrando = false;
            InputField[] hijos = GetComponentInChildren<Canvas>().GetComponentsInChildren<InputField>();

            comp.nombre = hijos[0].text;
            if (comp.tipo == "Resistencia")
            {
                comp.setValue(Int32.Parse(hijos[1].text));
            }

            else if (comp.tipo == "Fuente")
            {
                comp.voltaje = Int32.Parse(hijos[1].text);
            }

            //Debug.Log(hijos[0].text); 
            //Debug.Log(hijos[1].text);

            hijos[0].text = "";
            hijos[1].text = "";
        }
    }

    public void Update()
    {
        if (esconder)
        {
            Hide();
        }

        else
        {
            Show();

        }
        Componente[] componentes = FindObjectsOfType<Componente>();

        foreach (Componente componente in componentes)
        {
            if (componente.nombrando)
            {
                comp = componente;
                break;
            }

            else
            {
                comp = null;
            }
        }

        if (comp != null)
        {
            Show();
        }

    }
}